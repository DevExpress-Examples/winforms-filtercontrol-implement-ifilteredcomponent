<!-- default badges list -->
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1350)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q200298/Form1.cs) (VB: [Form1.vb](./VB/Q200298/Form1.vb))
* [Helper.cs](./CS/Q200298/Helper.cs) (VB: [Helper.vb](./VB/Q200298/Helper.vb))
* [Northwind.cs](./CS/Q200298/Northwind.cs) (VB: [Northwind.vb](./VB/Q200298/Northwind.vb))
<!-- default file list end -->
# How to implement an IFilteredComponent interface.


<p>This example demonstrates how to create a component, which wraps the XPCollection and provides a custom mechanism for generating FilterColumns' display names. By default, when the DisplayName attribute is applied to a persistent property, the FilterControl uses  its value for the corresponding FilterColumn's display name. In this example, the display name for the nested persistent property includes a full path to this property where members are separated with a dot. For example: "Category.Name".</p>

<br/>


