namespace Q200298 {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DXSample.FilterColumnProperties filterColumnProperties1 = new DXSample.FilterColumnProperties();
            DXSample.FilterColumnProperties filterColumnProperties2 = new DXSample.FilterColumnProperties();
            DXSample.FilterColumnProperties filterColumnProperties3 = new DXSample.FilterColumnProperties();
            DXSample.FilterColumnProperties filterColumnProperties4 = new DXSample.FilterColumnProperties();
            DXSample.FilterColumnProperties filterColumnProperties5 = new DXSample.FilterColumnProperties();
            DXSample.FilterColumnProperties filterColumnProperties6 = new DXSample.FilterColumnProperties();
            this.leProducts = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cProducts = new DevExpress.Xpo.XPCollection();
            this.leCategories = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.cCategories = new DevExpress.Xpo.XPCollection();
            this.cOrders = new DevExpress.Xpo.XPCollection();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.filterControl1 = new DevExpress.XtraEditors.FilterControl();
            this.filteredXPComponent1 = new DXSample.FilteredXPComponent();
            this.persistentRepository1 = new DevExpress.XtraEditors.Repository.PersistentRepository(this.components);
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colOrderID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colUnitPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.leProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cProducts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCategories)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOrders)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filteredXPComponent1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // leProducts
            // 
            this.leProducts.AutoHeight = false;
            this.leProducts.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leProducts.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ProductName", "Name", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.leProducts.DataSource = this.cProducts;
            this.leProducts.DisplayMember = "ProductName";
            this.leProducts.Name = "leProducts";
            this.leProducts.ValueMember = "This";
            // 
            // cProducts
            // 
            this.cProducts.ObjectType = typeof(Northwind.Products);
            // 
            // leCategories
            // 
            this.leCategories.AutoHeight = false;
            this.leCategories.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leCategories.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("CategoryName", "Name", 33, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Near)});
            this.leCategories.DataSource = this.cCategories;
            this.leCategories.DisplayMember = "CategoryName";
            this.leCategories.Name = "leCategories";
            this.leCategories.ValueMember = "CategoryID";
            // 
            // cCategories
            // 
            this.cCategories.ObjectType = typeof(Northwind.Categories);
            // 
            // cOrders
            // 
            this.cOrders.ObjectType = typeof(Northwind.OrderDetails);
            this.cOrders.DisplayableProperties = "OrderID;Quantity;ProductID!;ProductID.ProductName;ProductID.CategoryID!Key;Produc" +
                "tID.CategoryID.CategoryName";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.filterControl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 558);
            this.panel1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 526);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(267, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Apply Filter";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.OnApplyFilterClick);
            // 
            // filterControl1
            // 
            this.filterControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.filterControl1.Location = new System.Drawing.Point(0, 0);
            this.filterControl1.Name = "filterControl1";
            this.filterControl1.Size = new System.Drawing.Size(293, 520);
            this.filterControl1.SourceControl = this.filteredXPComponent1;
            this.filterControl1.TabIndex = 0;
            this.filterControl1.Text = "filterControl1";
            // 
            // filteredXPComponent1
            // 
            filterColumnProperties1.Caption = "OrderID";
            filterColumnProperties1.DataType = typeof(int);
            filterColumnProperties1.Editor = null;
            filterColumnProperties1.FieldName = "OrderID";
            filterColumnProperties1.Image = null;
            filterColumnProperties2.Caption = "Quantity";
            filterColumnProperties2.DataType = typeof(int);
            filterColumnProperties2.Editor = null;
            filterColumnProperties2.FieldName = "Quantity";
            filterColumnProperties2.Image = null;
            filterColumnProperties3.Caption = "Product";
            filterColumnProperties3.DataType = typeof(Northwind.Products);
            filterColumnProperties3.Editor = this.leProducts;
            filterColumnProperties3.FieldName = "ProductID!";
            filterColumnProperties3.Image = null;
            filterColumnProperties4.Caption = "Product.Name";
            filterColumnProperties4.DataType = typeof(string);
            filterColumnProperties4.Editor = null;
            filterColumnProperties4.FieldName = "ProductID.ProductName";
            filterColumnProperties4.Image = null;
            filterColumnProperties5.Caption = "Product.Category.CategoryID";
            filterColumnProperties5.DataType = typeof(int);
            filterColumnProperties5.Editor = null;
            filterColumnProperties5.FieldName = "ProductID.CategoryID!Key";
            filterColumnProperties5.Image = null;
            filterColumnProperties6.Caption = "Product.Category.Name";
            filterColumnProperties6.DataType = typeof(string);
            filterColumnProperties6.Editor = null;
            filterColumnProperties6.FieldName = "ProductID.CategoryID.CategoryName";
            filterColumnProperties6.Image = null;
            this.filteredXPComponent1.Columns.Add(filterColumnProperties1);
            this.filteredXPComponent1.Columns.Add(filterColumnProperties2);
            this.filteredXPComponent1.Columns.Add(filterColumnProperties3);
            this.filteredXPComponent1.Columns.Add(filterColumnProperties4);
            this.filteredXPComponent1.Columns.Add(filterColumnProperties5);
            this.filteredXPComponent1.Columns.Add(filterColumnProperties6);
            this.filteredXPComponent1.ExternalRepository = this.persistentRepository1;
            this.filteredXPComponent1.Source = this.cOrders;
            this.filteredXPComponent1.CustomFilterColumnEditor += new DXSample.CustomFilterColumnEditorEventHandler(this.filteredXPComponent1_CustomFilterColumnEditor);
            // 
            // persistentRepository1
            // 
            this.persistentRepository1.Items.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.leProducts,
            this.leCategories});
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.cOrders;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.EmbeddedNavigator.Name = "";
            this.gridControl1.Location = new System.Drawing.Point(293, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(668, 558);
            this.gridControl1.TabIndex = 3;
            this.gridControl1.UseEmbeddedNavigator = true;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colOrderID,
            this.colQuantity,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.colUnitPrice,
            this.gridColumn5});
            this.gridView1.CustomizationFormBounds = new System.Drawing.Rectangle(1011, 521, 208, 189);
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colOrderID
            // 
            this.colOrderID.Caption = "OrderID";
            this.colOrderID.FieldName = "OrderID";
            this.colOrderID.Name = "colOrderID";
            this.colOrderID.Visible = true;
            this.colOrderID.VisibleIndex = 0;
            this.colOrderID.Width = 61;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 64;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Product";
            this.gridColumn1.FieldName = "ProductID!";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Width = 49;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Product";
            this.gridColumn2.FieldName = "ProductID.ProductName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 49;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Category";
            this.gridColumn3.FieldName = "ProductID.CategoryID!Key";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Width = 57;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Category";
            this.gridColumn4.FieldName = "ProductID.CategoryID.CategoryName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 67;
            // 
            // colUnitPrice
            // 
            this.colUnitPrice.Caption = "Price";
            this.colUnitPrice.FieldName = "UnitPrice";
            this.colUnitPrice.Name = "colUnitPrice";
            this.colUnitPrice.Visible = true;
            this.colUnitPrice.VisibleIndex = 4;
            this.colUnitPrice.Width = 45;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "CategoryID.CategoryName";
            this.gridColumn5.FieldName = "CategoryID.CategoryName";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.ReadOnly = true;
            this.gridColumn5.Width = 144;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(961, 558);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.leProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cProducts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cCategories)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cOrders)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.filteredXPComponent1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.FilterControl filterControl1;
        private DevExpress.Xpo.XPCollection cOrders;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.Xpo.XPCollection cProducts;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderID;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn colUnitPrice;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.Xpo.XPCollection cCategories;
        private DXSample.FilteredXPComponent filteredXPComponent1;
        private DevExpress.XtraEditors.Repository.PersistentRepository persistentRepository1;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leProducts;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit leCategories;
    }
}

