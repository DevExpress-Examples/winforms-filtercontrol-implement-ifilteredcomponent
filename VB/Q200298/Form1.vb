Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports DevExpress.Xpo
Imports DevExpress.Xpo.DB
Imports DevExpress.XtraEditors.Filtering
Imports DXSample
Imports Northwind
Imports DevExpress.Xpo.Metadata
Imports DevExpress.XtraEditors.Controls

Namespace Q200298
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			XpoDefault.ConnectionString = AccessConnectionProvider.GetConnectionString("..\..\nwind.mdb")
			InitializeComponent()
		End Sub

		Private Sub OnApplyFilterClick(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			filterControl1.ApplyFilter()
		End Sub

		Private Sub OnhProductsCustomDisplayText(ByVal sender As Object, ByVal e As CustomDisplayTextEventArgs)
			If e.DisplayText = String.Empty Then
				Dim o As Object = e.Value
			End If
		End Sub

		Private Sub filteredXPComponent1_CustomFilterColumnEditor(ByVal sender As Object, ByVal e As CustomHelperFilterColumnEditorEventArgs) Handles filteredXPComponent1.CustomFilterColumnEditor
			If e.Column.FieldName = "ProductID.CategoryID!Key" Then
				e.Editor = leCategories
			End If
		End Sub
	End Class
End Namespace