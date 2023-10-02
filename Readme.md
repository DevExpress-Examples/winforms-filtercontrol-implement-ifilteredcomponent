<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128621164/13.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1350)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->

# WinForms Filter Control - How to implement an IFilteredComponent interface

This example demonstrates how to create a component that wraps [XPCollection](https://docs.devexpress.com/XPO/DevExpress.Xpo.XPCollection) and implements a custom mechanism to generate display names of filter columns (`FilterColumn`). If the `DisplayName` attribute is applied to a persistent property, the `FilterControl` uses its value to display a filter column name.

In this example, the display name of the nested persistent property includes a full path to this property (for example, "Category.Name").


## Files to Review

* [Form1.cs](./CS/Q200298/Form1.cs) (VB: [Form1.vb](./VB/Q200298/Form1.vb))
* [Helper.cs](./CS/Q200298/Helper.cs) (VB: [Helper.vb](./VB/Q200298/Helper.vb))
