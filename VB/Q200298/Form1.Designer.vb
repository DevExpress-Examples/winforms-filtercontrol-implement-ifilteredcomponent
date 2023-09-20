Namespace Q200298

    Partial Class Form1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Windows Form Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim filterColumnProperties1 As DXSample.FilterColumnProperties = New DXSample.FilterColumnProperties()
            Dim filterColumnProperties2 As DXSample.FilterColumnProperties = New DXSample.FilterColumnProperties()
            Dim filterColumnProperties3 As DXSample.FilterColumnProperties = New DXSample.FilterColumnProperties()
            Dim filterColumnProperties4 As DXSample.FilterColumnProperties = New DXSample.FilterColumnProperties()
            Dim filterColumnProperties5 As DXSample.FilterColumnProperties = New DXSample.FilterColumnProperties()
            Dim filterColumnProperties6 As DXSample.FilterColumnProperties = New DXSample.FilterColumnProperties()
            Me.leProducts = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.cProducts = New DevExpress.Xpo.XPCollection()
            Me.leCategories = New DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit()
            Me.cCategories = New DevExpress.Xpo.XPCollection()
            Me.cOrders = New DevExpress.Xpo.XPCollection()
            Me.panel1 = New System.Windows.Forms.Panel()
            Me.button1 = New System.Windows.Forms.Button()
            Me.filterControl1 = New DevExpress.XtraEditors.FilterControl()
            Me.filteredXPComponent1 = New DXSample.FilteredXPComponent()
            Me.persistentRepository1 = New DevExpress.XtraEditors.Repository.PersistentRepository(Me.components)
            Me.gridControl1 = New DevExpress.XtraGrid.GridControl()
            Me.gridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
            Me.colOrderID = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colQuantity = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.colUnitPrice = New DevExpress.XtraGrid.Columns.GridColumn()
            Me.gridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
            CType((Me.leProducts), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cProducts), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.leCategories), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cCategories), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.cOrders), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.panel1.SuspendLayout()
            CType((Me.filteredXPComponent1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' leProducts
            ' 
            Me.leProducts.AutoHeight = False
            Me.leProducts.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.leProducts.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Name", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
            Me.leProducts.DataSource = Me.cProducts
            Me.leProducts.DisplayMember = "ProductName"
            Me.leProducts.Name = "leProducts"
            Me.leProducts.ValueMember = "This"
            ' 
            ' cProducts
            ' 
            Me.cProducts.ObjectType = GetType(Northwind.Products)
            ' 
            ' leCategories
            ' 
            Me.leCategories.AutoHeight = False
            Me.leCategories.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
            Me.leCategories.Columns.AddRange(New DevExpress.XtraEditors.Controls.LookUpColumnInfo() {New DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Name", 33, DevExpress.Utils.FormatType.None, "", True, DevExpress.Utils.HorzAlignment.Near)})
            Me.leCategories.DataSource = Me.cCategories
            Me.leCategories.DisplayMember = "CategoryName"
            Me.leCategories.Name = "leCategories"
            Me.leCategories.ValueMember = "CategoryID"
            ' 
            ' cCategories
            ' 
            Me.cCategories.ObjectType = GetType(Northwind.Categories)
            ' 
            ' cOrders
            ' 
            Me.cOrders.ObjectType = GetType(Northwind.OrderDetails)
            Me.cOrders.DisplayableProperties = "OrderID;Quantity;ProductID!;ProductID.ProductName;ProductID.CategoryID!Key;Produc" & "tID.CategoryID.CategoryName"
            ' 
            ' panel1
            ' 
            Me.panel1.Controls.Add(Me.button1)
            Me.panel1.Controls.Add(Me.filterControl1)
            Me.panel1.Dock = System.Windows.Forms.DockStyle.Left
            Me.panel1.Location = New System.Drawing.Point(0, 0)
            Me.panel1.Name = "panel1"
            Me.panel1.Size = New System.Drawing.Size(293, 558)
            Me.panel1.TabIndex = 2
            ' 
            ' button1
            ' 
            Me.button1.Location = New System.Drawing.Point(12, 526)
            Me.button1.Name = "button1"
            Me.button1.Size = New System.Drawing.Size(267, 23)
            Me.button1.TabIndex = 1
            Me.button1.Text = "Apply Filter"
            Me.button1.UseVisualStyleBackColor = True
            AddHandler Me.button1.Click, New System.EventHandler(AddressOf Me.OnApplyFilterClick)
            ' 
            ' filterControl1
            ' 
            Me.filterControl1.Dock = System.Windows.Forms.DockStyle.Top
            Me.filterControl1.Location = New System.Drawing.Point(0, 0)
            Me.filterControl1.Name = "filterControl1"
            Me.filterControl1.Size = New System.Drawing.Size(293, 520)
            Me.filterControl1.SourceControl = Me.filteredXPComponent1
            Me.filterControl1.TabIndex = 0
            Me.filterControl1.Text = "filterControl1"
            ' 
            ' filteredXPComponent1
            ' 
            filterColumnProperties1.Caption = "OrderID"
            filterColumnProperties1.DataType = GetType(Integer)
            filterColumnProperties1.Editor = Nothing
            filterColumnProperties1.FieldName = "OrderID"
            filterColumnProperties1.Image = Nothing
            filterColumnProperties2.Caption = "Quantity"
            filterColumnProperties2.DataType = GetType(Integer)
            filterColumnProperties2.Editor = Nothing
            filterColumnProperties2.FieldName = "Quantity"
            filterColumnProperties2.Image = Nothing
            filterColumnProperties3.Caption = "Product"
            filterColumnProperties3.DataType = GetType(Northwind.Products)
            filterColumnProperties3.Editor = Me.leProducts
            filterColumnProperties3.FieldName = "ProductID!"
            filterColumnProperties3.Image = Nothing
            filterColumnProperties4.Caption = "Product.Name"
            filterColumnProperties4.DataType = GetType(String)
            filterColumnProperties4.Editor = Nothing
            filterColumnProperties4.FieldName = "ProductID.ProductName"
            filterColumnProperties4.Image = Nothing
            filterColumnProperties5.Caption = "Product.Category.CategoryID"
            filterColumnProperties5.DataType = GetType(Integer)
            filterColumnProperties5.Editor = Nothing
            filterColumnProperties5.FieldName = "ProductID.CategoryID!Key"
            filterColumnProperties5.Image = Nothing
            filterColumnProperties6.Caption = "Product.Category.Name"
            filterColumnProperties6.DataType = GetType(String)
            filterColumnProperties6.Editor = Nothing
            filterColumnProperties6.FieldName = "ProductID.CategoryID.CategoryName"
            filterColumnProperties6.Image = Nothing
            Me.filteredXPComponent1.Columns.Add(filterColumnProperties1)
            Me.filteredXPComponent1.Columns.Add(filterColumnProperties2)
            Me.filteredXPComponent1.Columns.Add(filterColumnProperties3)
            Me.filteredXPComponent1.Columns.Add(filterColumnProperties4)
            Me.filteredXPComponent1.Columns.Add(filterColumnProperties5)
            Me.filteredXPComponent1.Columns.Add(filterColumnProperties6)
            Me.filteredXPComponent1.ExternalRepository = Me.persistentRepository1
            Me.filteredXPComponent1.Source = Me.cOrders
            AddHandler Me.filteredXPComponent1.CustomFilterColumnEditor, New DXSample.CustomFilterColumnEditorEventHandler(AddressOf Me.filteredXPComponent1_CustomFilterColumnEditor)
            ' 
            ' persistentRepository1
            ' 
            Me.persistentRepository1.Items.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.leProducts, Me.leCategories})
            ' 
            ' gridControl1
            ' 
            Me.gridControl1.DataSource = Me.cOrders
            Me.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill
            Me.gridControl1.EmbeddedNavigator.Name = ""
            Me.gridControl1.Location = New System.Drawing.Point(293, 0)
            Me.gridControl1.MainView = Me.gridView1
            Me.gridControl1.Name = "gridControl1"
            Me.gridControl1.Size = New System.Drawing.Size(668, 558)
            Me.gridControl1.TabIndex = 3
            Me.gridControl1.UseEmbeddedNavigator = True
            Me.gridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.gridView1})
            ' 
            ' gridView1
            ' 
            Me.gridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.colOrderID, Me.colQuantity, Me.gridColumn1, Me.gridColumn2, Me.gridColumn3, Me.gridColumn4, Me.colUnitPrice, Me.gridColumn5})
            Me.gridView1.CustomizationFormBounds = New System.Drawing.Rectangle(1011, 521, 208, 189)
            Me.gridView1.GridControl = Me.gridControl1
            Me.gridView1.Name = "gridView1"
            ' 
            ' colOrderID
            ' 
            Me.colOrderID.Caption = "OrderID"
            Me.colOrderID.FieldName = "OrderID"
            Me.colOrderID.Name = "colOrderID"
            Me.colOrderID.Visible = True
            Me.colOrderID.VisibleIndex = 0
            Me.colOrderID.Width = 61
            ' 
            ' colQuantity
            ' 
            Me.colQuantity.Caption = "Quantity"
            Me.colQuantity.FieldName = "Quantity"
            Me.colQuantity.Name = "colQuantity"
            Me.colQuantity.Visible = True
            Me.colQuantity.VisibleIndex = 1
            Me.colQuantity.Width = 64
            ' 
            ' gridColumn1
            ' 
            Me.gridColumn1.Caption = "Product"
            Me.gridColumn1.FieldName = "ProductID!"
            Me.gridColumn1.Name = "gridColumn1"
            Me.gridColumn1.Width = 49
            ' 
            ' gridColumn2
            ' 
            Me.gridColumn2.Caption = "Product"
            Me.gridColumn2.FieldName = "ProductID.ProductName"
            Me.gridColumn2.Name = "gridColumn2"
            Me.gridColumn2.OptionsColumn.[ReadOnly] = True
            Me.gridColumn2.Visible = True
            Me.gridColumn2.VisibleIndex = 2
            Me.gridColumn2.Width = 49
            ' 
            ' gridColumn3
            ' 
            Me.gridColumn3.Caption = "Category"
            Me.gridColumn3.FieldName = "ProductID.CategoryID!Key"
            Me.gridColumn3.Name = "gridColumn3"
            Me.gridColumn3.OptionsColumn.[ReadOnly] = True
            Me.gridColumn3.Width = 57
            ' 
            ' gridColumn4
            ' 
            Me.gridColumn4.Caption = "Category"
            Me.gridColumn4.FieldName = "ProductID.CategoryID.CategoryName"
            Me.gridColumn4.Name = "gridColumn4"
            Me.gridColumn4.OptionsColumn.[ReadOnly] = True
            Me.gridColumn4.Visible = True
            Me.gridColumn4.VisibleIndex = 3
            Me.gridColumn4.Width = 67
            ' 
            ' colUnitPrice
            ' 
            Me.colUnitPrice.Caption = "Price"
            Me.colUnitPrice.FieldName = "UnitPrice"
            Me.colUnitPrice.Name = "colUnitPrice"
            Me.colUnitPrice.Visible = True
            Me.colUnitPrice.VisibleIndex = 4
            Me.colUnitPrice.Width = 45
            ' 
            ' gridColumn5
            ' 
            Me.gridColumn5.Caption = "CategoryID.CategoryName"
            Me.gridColumn5.FieldName = "CategoryID.CategoryName"
            Me.gridColumn5.Name = "gridColumn5"
            Me.gridColumn5.OptionsColumn.[ReadOnly] = True
            Me.gridColumn5.Width = 144
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(961, 558)
            Me.Controls.Add(Me.gridControl1)
            Me.Controls.Add(Me.panel1)
            Me.Name = "Form1"
            Me.Text = "Form1"
            CType((Me.leProducts), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cProducts), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.leCategories), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cCategories), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.cOrders), System.ComponentModel.ISupportInitialize).EndInit()
            Me.panel1.ResumeLayout(False)
            CType((Me.filteredXPComponent1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridControl1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me.gridView1), System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)
        End Sub

'#End Region
        Private filterControl1 As DevExpress.XtraEditors.FilterControl

        Private cOrders As DevExpress.Xpo.XPCollection

        Private panel1 As System.Windows.Forms.Panel

        Private button1 As System.Windows.Forms.Button

        Private gridControl1 As DevExpress.XtraGrid.GridControl

        Private gridView1 As DevExpress.XtraGrid.Views.Grid.GridView

        Private cProducts As DevExpress.Xpo.XPCollection

        Private colOrderID As DevExpress.XtraGrid.Columns.GridColumn

        Private colQuantity As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn1 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn2 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn3 As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn4 As DevExpress.XtraGrid.Columns.GridColumn

        Private colUnitPrice As DevExpress.XtraGrid.Columns.GridColumn

        Private gridColumn5 As DevExpress.XtraGrid.Columns.GridColumn

        Private cCategories As DevExpress.Xpo.XPCollection

        Private filteredXPComponent1 As DXSample.FilteredXPComponent

        Private persistentRepository1 As DevExpress.XtraEditors.Repository.PersistentRepository

        Private leProducts As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit

        Private leCategories As DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit
    End Class
End Namespace
