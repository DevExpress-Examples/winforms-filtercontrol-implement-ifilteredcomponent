using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.Xpo;
using DevExpress.Xpo.DB;
using DevExpress.XtraEditors.Filtering;
using DXSample;
using Northwind;
using DevExpress.Xpo.Metadata;
using DevExpress.XtraEditors.Controls;

namespace Q200298 {
    public partial class Form1 : Form {
        public Form1() {
            XpoDefault.ConnectionString = AccessConnectionProvider.GetConnectionString(@"..\..\nwind.mdb");
            InitializeComponent();
        }

        private void OnApplyFilterClick(object sender, EventArgs e) {
            filterControl1.ApplyFilter();
        }

        private void OnhProductsCustomDisplayText(object sender, CustomDisplayTextEventArgs e) {
            if (e.DisplayText == string.Empty) {
                object o = e.Value;
            }
        }

        private void filteredXPComponent1_CustomFilterColumnEditor(object sender, CustomHelperFilterColumnEditorEventArgs e) {
            if (e.Column.FieldName == "ProductID.CategoryID!Key")
                e.Editor = leCategories;
        }
    }
}