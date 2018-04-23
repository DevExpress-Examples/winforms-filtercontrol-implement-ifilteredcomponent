# How to implement an IFilteredComponent interface.


<p>This example demonstrates how to create a component, which wraps the XPCollection and provides a custom mechanism for generating FilterColumns' display names. By default, when the DisplayName attribute is applied to a persistent property, the FilterControl uses  its value for the corresponding FilterColumn's display name. In this example, the display name for the nested persistent property includes a full path to this property where members are separated with a dot. For example: "Category.Name".</p>

<br/>


