Imports System
Imports System.Text
Imports System.Drawing
Imports DevExpress.Xpo
Imports System.ComponentModel
Imports DevExpress.Xpo.Metadata
Imports DevExpress.Data.Filtering
Imports System.Collections.Generic
Imports DevExpress.XtraEditors.Controls
Imports DevExpress.Xpo.Metadata.Helpers
Imports DevExpress.XtraEditors.Container
Imports DevExpress.XtraEditors.Filtering
Imports DevExpress.XtraEditors.Repository
Imports DevExpress.Data.Filtering.Helpers
Imports System.Windows.Forms
Imports System.ComponentModel.Design

Namespace DXSample

    <ToolboxItem(True)>
    Public Class FilteredXPComponent
        Inherits ComponentEditorContainer
        Implements IFilteredComponent

        Private Filter As FilteredXPComponentMessageFilter

        Public Sub New()
            MyBase.New()
            Filter = New FilteredXPComponentMessageFilter()
            AddHandler Filter.OnShowWindow, AddressOf OnShowWindow
            Application.AddMessageFilter(Filter)
        End Sub

        Private sourceField As XPCollection

        Public Property Source As XPCollection
            Get
                Return sourceField
            End Get

            Set(ByVal value As XPCollection)
                If ReferenceEquals(sourceField, value) Then Return
                sourceField = value
                If isInitializing Then Return
                PopulateColumns()
                RaisePropertiesChanged()
            End Set
        End Property

        Private Sub PopulateColumns()
            If columnsField.Count > 0 Then Return
            PopulateColumnsFromDisplayableProperties()
        End Sub

        Private Sub PopulateColumnsFromDisplayableProperties()
            Dim properties As String() = sourceField.DisplayableProperties.Split(";"c)
            For Each [property] As String In properties
                If [property].Contains("!") Then
                    CreateColumnFromPropertyDescriptor([property])
                ElseIf [property].Contains(".") Then
                    columnsField.Add(CreateColumnFromNestedProperty([property]))
                Else
                    columnsField.Add(CreateColumnFromXMember([property]))
                End If
            Next
        End Sub

        Private Sub CreateColumnFromPropertyDescriptor(ByVal [property] As String)
            Dim temp As String() = [property].Split(New Char() {"!"c}, StringSplitOptions.RemoveEmptyEntries)
            Dim props As FilterColumnProperties
            If temp.Length = 1 Then
                props = ParsePropertyPath(temp(0))
            Else
                props = ParsePropertyPath(String.Format("{0}.!Key", temp(0)))
            End If

            props.FieldName = [property]
            columnsField.Add(props)
        End Sub

        Private Function ParsePropertyPath(ByVal path As String) As FilterColumnProperties
            If path.Contains(".") Then
                Return CreateColumnFromNestedProperty(path)
            Else
                Return CreateColumnFromXMember(path)
            End If
        End Function

        Private Function CreateColumnFromXMember(ByVal [property] As String) As FilterColumnProperties
            Dim member As XPMemberInfo = sourceField.ObjectClassInfo.GetMember([property])
            Return CreateFilterColumnProperties([property], member.MemberType, member.DisplayName)
        End Function

        Private Function CreateColumnFromNestedProperty(ByVal [property] As String) As FilterColumnProperties
            Dim member As XPTypeInfo = sourceField.ObjectClassInfo
            Dim displayName As String = ProcessNestedProperty([property], member)
            Return CreateFilterColumnProperties([property], CType(member, XPMemberInfo).MemberType, displayName)
        End Function

        Private Function CreateFilterColumnProperties(ByVal [property] As String, ByVal memberType As Type, ByVal displayName As String) As FilterColumnProperties
            If String.IsNullOrEmpty(displayName) Then displayName = [property]
            If Site IsNot Nothing Then
                Dim host As IDesignerHost = TryCast(Site.GetService(GetType(IDesignerHost)), IDesignerHost)
                If host IsNot Nothing Then
                    Dim result As FilterColumnProperties = TryCast(host.CreateComponent(GetType(FilterColumnProperties)), FilterColumnProperties)
                    If result IsNot Nothing Then
                        result.FieldName = [property]
                        result.DataType = memberType
                        result.Caption = displayName
                        Return result
                    End If
                End If
            End If

            Return New FilterColumnProperties([property], memberType, displayName)
        End Function

        Private Function ProcessNestedProperty(ByRef [property] As String, ByRef member As XPTypeInfo) As String
            Dim displayName As StringBuilder = New StringBuilder()
            Dim path As StringBuilder = New StringBuilder()
            Dim elements As String() = [property].Split("."c)
            For i As Integer = 0 To elements.Length - 1
                member = GetNestedMemberInfo(elements(i), member)
                Dim format As String = If(i < elements.Length - 1, "{0}.", "{0}")
                Dim dn As String = CType(member, XPMemberInfo).DisplayName
                displayName.AppendFormat(format, If(String.IsNullOrEmpty(dn), CType(member, XPMemberInfo).Name, dn))
                path.AppendFormat(format, CType(member, XPMemberInfo).Name)
            Next

            [property] = path.ToString()
            Return displayName.ToString()
        End Function

        Private Function GetNestedMemberInfo(ByVal element As String, ByVal member As XPTypeInfo) As XPMemberInfo
            If TypeOf member Is XPClassInfo Then
                Return CType(member, XPClassInfo).GetMember(element)
            Else
                Return GetNestedMemberInfo(element, CType(member, XPMemberInfo))
            End If
        End Function

        Private Function GetNestedMemberInfo(ByRef element As String, ByVal member As XPMemberInfo) As XPMemberInfo
            Dim dict As XPDictionary = CType(sourceField, IXPDictionaryProvider).Dictionary
            Dim cInfo As XPClassInfo = dict.GetClassInfo(member.MemberType)
            If Equals(element, "!Key") Then element = cInfo.KeyProperty.Name
            Return cInfo.GetMember(element)
        End Function

        Private columnsField As List(Of FilterColumnProperties) = New List(Of FilterColumnProperties)()

        <EditorBrowsable(EditorBrowsableState.Never)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Content)>
        Public ReadOnly Property Columns As List(Of FilterColumnProperties)
            Get
                Return columnsField
            End Get
        End Property

'#Region "IFilteredComponent Members"
        Public Function CreateFilterColumnCollection() As IBoundPropertyCollection Implements IFilteredComponent.CreateFilterColumnCollection
            Dim result As HelperFilterColumnCollection = New HelperFilterColumnCollection(Me)
            AddHandler result.CustomFilterColumnEditor, New CustomFilterColumnEditorEventHandler(AddressOf OnCustomFilterColumnEditor)
            result.CreateColumns()
            RemoveHandler result.CustomFilterColumnEditor, New CustomFilterColumnEditorEventHandler(AddressOf OnCustomFilterColumnEditor)
            Return result
        End Function

        Private Sub OnCustomFilterColumnEditor(ByVal sender As Object, ByVal e As CustomHelperFilterColumnEditorEventArgs)
            RaiseCustomFilterColumnEditor(e)
        End Sub

        Private Shared ReadOnly fCustomFilterColumnEditor As Object = New Object()

        Public Custom Event CustomFilterColumnEditor As CustomFilterColumnEditorEventHandler
            AddHandler(ByVal value As CustomFilterColumnEditorEventHandler)
                Events.AddHandler(fCustomFilterColumnEditor, value)
            End AddHandler

            RemoveHandler(ByVal value As CustomFilterColumnEditorEventHandler)
                Events.RemoveHandler(fCustomFilterColumnEditor, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As CustomHelperFilterColumnEditorEventArgs)
            End RaiseEvent
        End Event

        Private Sub RaiseCustomFilterColumnEditor(ByVal args As CustomHelperFilterColumnEditorEventArgs)
            Dim handler As CustomFilterColumnEditorEventHandler = TryCast(Events(fCustomFilterColumnEditor), CustomFilterColumnEditorEventHandler)
            If handler IsNot Nothing Then handler(Me, args)
        End Sub

        Private propertiesChangedField As EventHandler

        Public Custom Event PropertiesChanged As EventHandler Implements IFilteredComponentBase.PropertiesChanged
            AddHandler(ByVal value As EventHandler)
                propertiesChangedField = [Delegate].Combine(propertiesChangedField, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                propertiesChangedField = [Delegate].Remove(propertiesChangedField, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
                If propertiesChangedField IsNot Nothing Then
                    propertiesChangedField(sender, e)
                End If
            End RaiseEvent
        End Event

        Private Sub RaisePropertiesChanged()
            If propertiesChangedField IsNot Nothing Then propertiesChangedField(Me, EventArgs.Empty)
        End Sub

        <Browsable(False)>
        <DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)>
        Public Property RowCriteria As CriteriaOperator Implements IFilteredComponentBase.RowCriteria
            Get
                If sourceField Is Nothing Then Return Nothing
                Return sourceField.Criteria
            End Get

            Set(ByVal value As CriteriaOperator)
                If ReferenceEquals(sourceField.Criteria, value) Then Return
                sourceField.Criteria = value
                RaiseRowFilterChanged()
            End Set
        End Property

        Private rowFilterChangedField As EventHandler

        Public Custom Event RowFilterChanged As EventHandler Implements IFilteredComponentBase.RowFilterChanged
            AddHandler(ByVal value As EventHandler)
                rowFilterChangedField = [Delegate].Combine(rowFilterChangedField, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                rowFilterChangedField = [Delegate].Remove(rowFilterChangedField, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
                If rowFilterChangedField IsNot Nothing Then
                    rowFilterChangedField(sender, e)
                End If
            End RaiseEvent
        End Event

        Private Sub RaiseRowFilterChanged()
            If rowFilterChangedField IsNot Nothing Then rowFilterChangedField(Me, EventArgs.Empty)
        End Sub

'#End Region
        Protected Overrides Function CreateHelper() As ComponentEditorContainerHelper
            Return New FilteredXPComponentContainerHelper(Me)
        End Function

        Private isInitializing As Boolean = False

        Public Overrides Sub BeginInit()
            isInitializing = True
            MyBase.BeginInit()
        End Sub

        Public Overrides Sub EndInit()
            isInitializing = False
            RaisePropertiesChanged()
            MyBase.EndInit()
        End Sub

        Public Sub AddColumn(ByVal col As FilterColumnProperties)
            Columns.Add(col)
            RaisePropertiesChanged()
        End Sub

        Public Sub AdddColumns(ParamArray columnsToAdd As FilterColumnProperties())
            Columns.AddRange(columnsToAdd)
            RaisePropertiesChanged()
        End Sub

        Private Sub OnShowWindow(ByVal sender As Object, ByVal e As EventArgs)
            EditorHelper.InitializePosponedRespositories()
            RemoveHandler Filter.OnShowWindow, AddressOf OnShowWindow
            Application.RemoveMessageFilter(Filter)
            Filter = Nothing
        End Sub
    End Class

    Public Class FilteredXPComponentContainerHelper
        Inherits ComponentEditorContainerHelper

        Public Sub New(ByVal container As FilteredXPComponent)
            MyBase.New(container)
        End Sub

        Protected Overrides Sub RaiseInvalidValueException(ByVal e As InvalidValueExceptionEventArgs)
        End Sub

        Protected Overrides Sub RaiseValidatingEditor(ByVal va As BaseContainerValidateEditorEventArgs)
        End Sub
    End Class

    Public Class HelperFilterColumnCollection
        Inherits FilterColumnCollection

        Private filteredComponent As FilteredXPComponent

        Public Sub New(ByVal filteredComponent As FilteredXPComponent)
            Me.filteredComponent = filteredComponent
        End Sub

        Friend Sub CreateColumns()
            For Each properties As FilterColumnProperties In filteredComponent.Columns
                If IsColumnForFilter(properties) Then Add(New HelperFilterColumn(properties))
            Next
        End Sub

        Private Function IsColumnForFilter(ByVal properties As FilterColumnProperties) As Boolean
            If properties.Editor Is Nothing Then
                Dim args As CustomHelperFilterColumnEditorEventArgs = New CustomHelperFilterColumnEditorEventArgs(properties)
                RaiseCustomFilterColumnEditor(args)
                properties.Editor = args.Editor
            End If

            If properties.DataType Is Nothing AndAlso filteredComponent.Source IsNot Nothing Then
                Dim [property] As PropertyDescriptor = CType(filteredComponent.Source, ITypedList).GetItemProperties(Nothing).Find(properties.FieldName, False)
                If [property] IsNot Nothing Then properties.DataType = [property].PropertyType
            End If

            Return properties.Editor IsNot Nothing OrElse properties.DataType Is GetType(String) OrElse properties.DataType Is GetType(Short) OrElse properties.DataType Is GetType(Integer) OrElse properties.DataType Is GetType(Long) OrElse properties.DataType Is GetType(Decimal) OrElse properties.DataType Is GetType(Double) OrElse properties.DataType Is GetType(Single) OrElse properties.DataType Is GetType(Date) OrElse properties.DataType Is GetType(Boolean)
        End Function

        Public Event CustomFilterColumnEditor As CustomFilterColumnEditorEventHandler

        Private Sub RaiseCustomFilterColumnEditor(ByVal arg As CustomHelperFilterColumnEditorEventArgs)
            RaiseEvent CustomFilterColumnEditor(Me, arg)
        End Sub
    End Class

    Public Class HelperFilterColumn
        Inherits FilterColumn

        Private properties As FilterColumnProperties

        Public Sub New(ByVal properties As FilterColumnProperties)
            Me.properties = properties
        End Sub

        Public Overrides ReadOnly Property ClauseClass As FilterColumnClauseClass
            Get
                If properties.Editor Is Nothing Then
                    Return GetClauseByType()
                Else
                    Return GetClauseByEditor()
                End If
            End Get
        End Property

        Private Function GetClauseByType() As FilterColumnClauseClass
            If ColumnType Is GetType(Image) OrElse ColumnType Is GetType(Bitmap) OrElse ColumnType Is GetType(Byte()) Then
                Return FilterColumnClauseClass.Blob
            ElseIf ColumnType Is GetType(String) Then
                Return FilterColumnClauseClass.String
            Else
                Return FilterColumnClauseClass.Generic
            End If
        End Function

        Private Function GetClauseByEditor() As FilterColumnClauseClass
            If IsBlobEditor() Then
                Return FilterColumnClauseClass.Blob
            ElseIf IsLookUpEditor() Then
                Return FilterColumnClauseClass.Lookup
            ElseIf IsTextEditor() Then
                Return FilterColumnClauseClass.String
            Else
                Return FilterColumnClauseClass.Generic
            End If
        End Function

        Private Function IsTextEditor() As Boolean
            Return TypeOf ColumnEditor Is RepositoryItemTextEdit OrElse TypeOf ColumnEditor Is RepositoryItemMemoEdit
        End Function

        Private Function IsLookUpEditor() As Boolean
            Return TypeOf ColumnEditor Is RepositoryItemLookUpEdit OrElse TypeOf ColumnEditor Is RepositoryItemGridLookUpEdit
        End Function

        Private Function IsBlobEditor() As Boolean
            Return TypeOf ColumnEditor Is RepositoryItemPictureEdit OrElse TypeOf ColumnEditor Is RepositoryItemImageEdit
        End Function

        Public Overrides ReadOnly Property ColumnCaption As String
            Get
                Return properties.Caption
            End Get
        End Property

        Public Overrides ReadOnly Property ColumnEditor As RepositoryItem
            Get
                If properties.Editor Is Nothing Then CreateEditor()
                Return properties.Editor
            End Get
        End Property

        Private Sub CreateEditor()
            Select Case ClauseClass
                Case FilterColumnClauseClass.Generic
                    CreateGenericEditor()
                Case FilterColumnClauseClass.String
                    properties.Editor = New RepositoryItemTextEdit()
            End Select
        End Sub

        Private Sub CreateGenericEditor()
            If ColumnType Is GetType(Integer) OrElse ColumnType Is GetType(Decimal) OrElse ColumnType Is GetType(Short) OrElse ColumnType Is GetType(Long) OrElse ColumnType Is GetType(Single) OrElse ColumnType Is GetType(Double) Then
                properties.Editor = New RepositoryItemSpinEdit()
            ElseIf ColumnType Is GetType(Date) Then
                properties.Editor = New RepositoryItemDateEdit()
            ElseIf ColumnType Is GetType(Boolean) Then
                properties.Editor = New RepositoryItemCheckEdit()
            Else
                properties.Editor = New RepositoryItemTextEdit()
            End If
        End Sub

        Public Overrides ReadOnly Property ColumnType As Type
            Get
                Return properties.DataType
            End Get
        End Property

        Public Overrides ReadOnly Property FieldName As String
            Get
                Return properties.FieldName
            End Get
        End Property

        Public Overrides ReadOnly Property Image As Image
            Get
                Return properties.Image
            End Get
        End Property
    End Class

    Public Delegate Sub CustomFilterColumnEditorEventHandler(ByVal sender As Object, ByVal e As CustomHelperFilterColumnEditorEventArgs)

    Public Class CustomHelperFilterColumnEditorEventArgs
        Inherits EventArgs

        Public Sub New(ByVal column As FilterColumnProperties)
            fColumn = column
        End Sub

        Private fColumn As FilterColumnProperties

        Public ReadOnly Property Column As FilterColumnProperties
            Get
                Return fColumn
            End Get
        End Property

        Private fEditor As RepositoryItem

        Public Property Editor As RepositoryItem
            Get
                Return fEditor
            End Get

            Set(ByVal value As RepositoryItem)
                fEditor = value
            End Set
        End Property
    End Class

    <ToolboxItem(False), DesignTimeVisible(False)>
    Public Class FilterColumnProperties
        Inherits Component

        Public Sub New()
        End Sub

        Public Sub New(ByVal fieldName As String, ByVal type As Type, ByVal caption As String)
            fieldNameField = fieldName
            dataTypeField = type
            If String.IsNullOrEmpty(caption) Then
                captionField = fieldName
            Else
                captionField = caption
            End If
        End Sub

        Private captionField As String

        <Localizable(True)>
        Public Property Caption As String
            Get
                Return captionField
            End Get

            Set(ByVal value As String)
                captionField = value
            End Set
        End Property

        Private fieldNameField As String

        Public Property FieldName As String
            Get
                Return fieldNameField
            End Get

            Set(ByVal value As String)
                fieldNameField = value
            End Set
        End Property

        Private dataTypeField As Type

        <Browsable(False)>
        Public Property DataType As Type
            Get
                Return dataTypeField
            End Get

            Set(ByVal value As Type)
                dataTypeField = value
            End Set
        End Property

        Private editorField As RepositoryItem

        Public Property Editor As RepositoryItem
            Get
                Return editorField
            End Get

            Set(ByVal value As RepositoryItem)
                editorField = value
            End Set
        End Property

        Private imageField As Image

        Public Property Image As Image
            Get
                Return imageField
            End Get

            Set(ByVal value As Image)
                imageField = value
            End Set
        End Property
    End Class

    Public Class FilteredXPComponentMessageFilter
        Implements IMessageFilter

        Const WM_SHOWWINDOW As Integer = &H18

        Private fOnShowWindow As EventHandler

        Public Custom Event OnShowWindow As EventHandler
            AddHandler(ByVal value As EventHandler)
                fOnShowWindow = [Delegate].Combine(fOnShowWindow, value)
            End AddHandler

            RemoveHandler(ByVal value As EventHandler)
                fOnShowWindow = [Delegate].Remove(fOnShowWindow, value)
            End RemoveHandler

            RaiseEvent(ByVal sender As Object, ByVal e As EventArgs)
                If fOnShowWindow IsNot Nothing Then
                    fOnShowWindow(sender, e)
                End If
            End RaiseEvent
        End Event

        Private Sub RaiseOnShowWindow()
            If fOnShowWindow IsNot Nothing Then fOnShowWindow(Me, EventArgs.Empty)
        End Sub

'#Region "IMessageFilter Members"
        Private Function PreFilterMessage(ByRef m As Message) As Boolean Implements IMessageFilter.PreFilterMessage
            RaiseOnShowWindow()
            Return False
        End Function
'#End Region
    End Class
End Namespace
