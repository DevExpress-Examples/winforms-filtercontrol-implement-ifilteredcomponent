using System;
using DevExpress.Xpo;
using System.Drawing;
namespace Northwind {

    public class Categories : XPLiteObject {
        int fCategoryID;
        [Key(true)]
        public int CategoryID {
            get { return fCategoryID; }
            set { SetPropertyValue<int>("CategoryID", ref fCategoryID, value); }
        }
        string fCategoryName;
        [Size(15), DisplayName("Name")]
        public string CategoryName {
            get { return fCategoryName; }
            set { SetPropertyValue<string>("CategoryName", ref fCategoryName, value); }
        }
        string fDescription;
        [Size(1073741823)]
        public string Description {
            get { return fDescription; }
            set { SetPropertyValue<string>("Description", ref fDescription, value); }
        }
        [Association("Category-Products", typeof(Products))]
        public XPCollection<Products> Products { get { return GetCollection<Products>("Products"); } }
        public Categories(Session session) : base(session) { }
        public Categories() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }

    public class Products : XPLiteObject {
        int fProductID;
        [Key(true)]
        public int ProductID {
            get { return fProductID; }
            set { SetPropertyValue<int>("ProductID", ref fProductID, value); }
        }
        string fProductName;
        [Size(40), DisplayName("Name")]
        public string ProductName {
            get { return fProductName; }
            set { SetPropertyValue<string>("ProductName", ref fProductName, value); }
        }
        int fSupplierID;
        [DisplayName("Supplier")]
        public int SupplierID {
            get { return fSupplierID; }
            set { SetPropertyValue<int>("SupplierID", ref fSupplierID, value); }
        }
        Categories fCategoryID;
        [Association("Category-Products")]
        [DisplayName("Category")]
        public Categories CategoryID {
            get { return fCategoryID; }
            set { SetPropertyValue<Categories>("CategoryID", ref fCategoryID, value); }
        }
        [Association("Product-OrderDetails")]
        public XPCollection<OrderDetails> OrderDetails { get { return GetCollection<OrderDetails>("OrderDetails"); } }
        string fQuantityPerUnit;
        [Size(20), DisplayName("Quantity per Unit")]
        public string QuantityPerUnit {
            get { return fQuantityPerUnit; }
            set { SetPropertyValue<string>("QuantityPerUnit", ref fQuantityPerUnit, value); }
        }
        public Products(Session session) : base(session) { }
        public Products() : base(Session.DefaultSession) { }
        public override void AfterConstruction() { base.AfterConstruction(); }
    }
    [Persistent("Order Details")]
    public class OrderDetails : XPLiteObject {
        public OrderDetails() : base() { }
        public OrderDetails(Session session) : base(session) { }
        private int id;
        [Key(true), DisplayName("ID")]
        public int ID {
            get { return id; }
            set { SetPropertyValue<int>("ID", ref id, value); }
        }
        private int orderId;
        public int OrderID {
            get { return orderId; }
            set { SetPropertyValue<int>("OrderID", ref orderId, value); }
        }
        private Products productId;
        [Association("Product-OrderDetails"), DisplayName("Product")]
        public Products ProductID {
            get { return productId; }
            set { SetPropertyValue<Products>("ProductID", ref productId, value); }
        }
        private decimal unitPrice;
        [DisplayName("Price")]
        public decimal UnitPrice {
            get { return unitPrice; }
            set { SetPropertyValue<decimal>("UnitPrice", ref unitPrice, value); }
        }
        private int quantity;
        public int Quantity {
            get { return quantity; }
            set { SetPropertyValue<int>("Quantity", ref quantity, value); }
        }
        private short discount;
        private short Discount {
            get { return discount; }
            set { SetPropertyValue<short>("Discount", ref discount, value); }
        }
    }
}