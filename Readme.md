<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/Q200298/Form1.cs) (VB: [Form1.vb](./VB/Q200298/Form1.vb))
* [Helper.cs](./CS/Q200298/Helper.cs) (VB: [Helper.vb](./VB/Q200298/Helper.vb))
<!-- default file list end -->
# How to implement an IFilteredComponent interface.


<p>This example demonstrates how to create a component, which wraps the XPCollection and provides a custom mechanism for generating FilterColumns' display names. By default, when the DisplayName attribute is applied to a persistent property, the FilterControl uses  its value for the corresponding FilterColumn's display name. In this example, the display name for the nested persistent property includes a full path to this property where members are separated with a dot. For example: "Category.Name".</p>


<h3>Description</h3>

<p>In version 2011 vol 2, the IFilteredComponent.CreateFilterColumnCollection method signature has been changed. Now, this method should return an instance implementing the DevExpress.XtraEditors.Filtering.IBoundPropertyColleciton interface.</p>

<br/>


