Imports DevExpress.Xpo
Imports System.Drawing

Namespace Northwind

    Public Class Categories
        Inherits XPLiteObject

        Private fCategoryID As Integer

        <Key(True)>
        Public Property CategoryID As Integer
            Get
                Return fCategoryID
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("CategoryID", fCategoryID, value)
            End Set
        End Property

        Private fCategoryName As String

        <Size(15), DisplayName("Name")>
        Public Property CategoryName As String
            Get
                Return fCategoryName
            End Get

            Set(ByVal value As String)
                SetPropertyValue("CategoryName", fCategoryName, value)
            End Set
        End Property

        Private fDescription As String

        <Size(1073741823)>
        Public Property Description As String
            Get
                Return fDescription
            End Get

            Set(ByVal value As String)
                SetPropertyValue("Description", fDescription, value)
            End Set
        End Property

        <Association("Category-Products", GetType(Products))>
        Public ReadOnly Property Products As XPCollection(Of Products)
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

        <Key(True)>
        Public Property ProductID As Integer
            Get
                Return fProductID
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ProductID", fProductID, value)
            End Set
        End Property

        Private fProductName As String

        <Size(40), DisplayName("Name")>
        Public Property ProductName As String
            Get
                Return fProductName
            End Get

            Set(ByVal value As String)
                SetPropertyValue("ProductName", fProductName, value)
            End Set
        End Property

        Private fSupplierID As Integer

        <DisplayName("Supplier")>
        Public Property SupplierID As Integer
            Get
                Return fSupplierID
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("SupplierID", fSupplierID, value)
            End Set
        End Property

        Private fCategoryID As Categories

        <Association("Category-Products")>
        <DisplayName("Category")>
        Public Property CategoryID As Categories
            Get
                Return fCategoryID
            End Get

            Set(ByVal value As Categories)
                SetPropertyValue("CategoryID", fCategoryID, value)
            End Set
        End Property

        <Association("Product-OrderDetails")>
        Public ReadOnly Property OrderDetails As XPCollection(Of OrderDetails)
            Get
                Return GetCollection(Of OrderDetails)("OrderDetails")
            End Get
        End Property

        Private fQuantityPerUnit As String

        <Size(20), DisplayName("Quantity per Unit")>
        Public Property QuantityPerUnit As String
            Get
                Return fQuantityPerUnit
            End Get

            Set(ByVal value As String)
                SetPropertyValue("QuantityPerUnit", fQuantityPerUnit, value)
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

    <Persistent("Order Details")>
    Public Class OrderDetails
        Inherits XPLiteObject

        Public Sub New()
            MyBase.New()
        End Sub

        Public Sub New(ByVal session As Session)
            MyBase.New(session)
        End Sub

        Private idField As Integer

        <Key(True), DisplayName("ID")>
        Public Property ID As Integer
            Get
                Return idField
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("ID", idField, value)
            End Set
        End Property

        Private orderIdField As Integer

        Public Property OrderID As Integer
            Get
                Return orderIdField
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("OrderID", orderIdField, value)
            End Set
        End Property

        Private productIdField As Products

        <Association("Product-OrderDetails"), DisplayName("Product")>
        Public Property ProductID As Products
            Get
                Return productIdField
            End Get

            Set(ByVal value As Products)
                SetPropertyValue("ProductID", productIdField, value)
            End Set
        End Property

        Private unitPriceField As Decimal

        <DisplayName("Price")>
        Public Property UnitPrice As Decimal
            Get
                Return unitPriceField
            End Get

            Set(ByVal value As Decimal)
                SetPropertyValue(Of Decimal)("UnitPrice", unitPriceField, value)
            End Set
        End Property

        Private quantityField As Integer

        Public Property Quantity As Integer
            Get
                Return quantityField
            End Get

            Set(ByVal value As Integer)
                SetPropertyValue(Of Integer)("Quantity", quantityField, value)
            End Set
        End Property

        Private discountField As Short

        Private Property Discount As Short
            Get
                Return discountField
            End Get

            Set(ByVal value As Short)
                SetPropertyValue("Discount", discountField, value)
            End Set
        End Property
    End Class
End Namespace
