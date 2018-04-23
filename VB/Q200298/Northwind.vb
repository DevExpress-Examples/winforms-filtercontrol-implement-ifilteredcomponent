Imports Microsoft.VisualBasic
Imports System
Imports DevExpress.Xpo
Imports System.Drawing
Namespace Northwind

	Public Class Categories
		Inherits XPLiteObject
		Private fCategoryID As Integer
		<Key(True)> _
		Public Property CategoryID() As Integer
			Get
				Return fCategoryID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("CategoryID", fCategoryID, value)
			End Set
		End Property
		Private fCategoryName As String
		<Size(15), DisplayName("Name")> _
		Public Property CategoryName() As String
			Get
				Return fCategoryName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("CategoryName", fCategoryName, value)
			End Set
		End Property
		Private fDescription As String
		<Size(1073741823)> _
		Public Property Description() As String
			Get
				Return fDescription
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("Description", fDescription, value)
			End Set
		End Property
		<Association("Category-Products", GetType(Products))> _
		Public ReadOnly Property Products() As XPCollection(Of Products)
			Get
				Return GetCollection(Of Products)("Products")
			End Get
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class

	Public Class Products
		Inherits XPLiteObject
		Private fProductID As Integer
		<Key(True)> _
		Public Property ProductID() As Integer
			Get
				Return fProductID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("ProductID", fProductID, value)
			End Set
		End Property
		Private fProductName As String
		<Size(40), DisplayName("Name")> _
		Public Property ProductName() As String
			Get
				Return fProductName
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("ProductName", fProductName, value)
			End Set
		End Property
		Private fSupplierID As Integer
		<DisplayName("Supplier")> _
		Public Property SupplierID() As Integer
			Get
				Return fSupplierID
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("SupplierID", fSupplierID, value)
			End Set
		End Property
		Private fCategoryID As Categories
		<Association("Category-Products"), DisplayName("Category")> _
		Public Property CategoryID() As Categories
			Get
				Return fCategoryID
			End Get
			Set(ByVal value As Categories)
				SetPropertyValue(Of Categories)("CategoryID", fCategoryID, value)
			End Set
		End Property
		<Association("Product-OrderDetails")> _
		Public ReadOnly Property OrderDetails() As XPCollection(Of OrderDetails)
			Get
				Return GetCollection(Of OrderDetails)("OrderDetails")
			End Get
		End Property
		Private fQuantityPerUnit As String
		<Size(20), DisplayName("Quantity per Unit")> _
		Public Property QuantityPerUnit() As String
			Get
				Return fQuantityPerUnit
			End Get
			Set(ByVal value As String)
				SetPropertyValue(Of String)("QuantityPerUnit", fQuantityPerUnit, value)
			End Set
		End Property
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Public Sub New()
			MyBase.New(Session.DefaultSession)
		End Sub
		Public Overrides Sub AfterConstruction()
			MyBase.AfterConstruction()
		End Sub
	End Class
	<Persistent("Order Details")> _
	Public Class OrderDetails
		Inherits XPLiteObject
		Public Sub New()
			MyBase.New()
		End Sub
		Public Sub New(ByVal session As Session)
			MyBase.New(session)
		End Sub
		Private id_Renamed As Integer
		<Key(True), DisplayName("ID")> _
		Public Property ID() As Integer
			Get
				Return id_Renamed
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("ID", id_Renamed, value)
			End Set
		End Property
		Private orderId_Renamed As Integer
		Public Property OrderID() As Integer
			Get
				Return orderId_Renamed
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("OrderID", orderId_Renamed, value)
			End Set
		End Property
		Private productId_Renamed As Products
		<Association("Product-OrderDetails"), DisplayName("Product")> _
		Public Property ProductID() As Products
			Get
				Return productId_Renamed
			End Get
			Set(ByVal value As Products)
				SetPropertyValue(Of Products)("ProductID", productId_Renamed, value)
			End Set
		End Property
		Private unitPrice_Renamed As Decimal
		<DisplayName("Price")> _
		Public Property UnitPrice() As Decimal
			Get
				Return unitPrice_Renamed
			End Get
			Set(ByVal value As Decimal)
				SetPropertyValue(Of Decimal)("UnitPrice", unitPrice_Renamed, value)
			End Set
		End Property
		Private quantity_Renamed As Integer
		Public Property Quantity() As Integer
			Get
				Return quantity_Renamed
			End Get
			Set(ByVal value As Integer)
				SetPropertyValue(Of Integer)("Quantity", quantity_Renamed, value)
			End Set
		End Property
		Private discount_Renamed As Short
		Private Property Discount() As Short
			Get
				Return discount_Renamed
			End Get
			Set(ByVal value As Short)
				SetPropertyValue(Of Short)("Discount", discount_Renamed, value)
			End Set
		End Property
	End Class
End Namespace