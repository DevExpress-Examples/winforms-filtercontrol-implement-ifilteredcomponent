Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DXSample
Imports DevExpress.XtraEditors.Controls

Namespace Q200298

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            XpoDefault.ConnectionString = AccessConnectionProvider.GetConnectionString("..\..\nwind.mdb")
            InitializeComponent()
        End Sub

        Private Sub OnApplyFilterClick(ByVal sender As Object, ByVal e As EventArgs)
            filterControl1.ApplyFilter()
        End Sub

        Private Sub OnhProductsCustomDisplayText(ByVal sender As Object, ByVal e As CustomDisplayTextEventArgs)
            If Equals(e.DisplayText, String.Empty) Then
                Dim o As Object = e.Value
            End If
        End Sub

        Private Sub filteredXPComponent1_CustomFilterColumnEditor(ByVal sender As Object, ByVal e As CustomHelperFilterColumnEditorEventArgs)
            If Equals(e.Column.FieldName, "ProductID.CategoryID!Key") Then e.Editor = leCategories
        End Sub
    End Class
End Namespace
