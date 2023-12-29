<!-- default file list -->
*Files to look at*:

* [HomeController.cs](./CS/DXWebApplication1/Controllers/HomeController.cs) (VB: [HomeController.vb](./VB/DXWebApplication1/Controllers/HomeController.vb))
* [Person.cs](./CS/DXWebApplication1/Models/Person.cs) (VB: [PersonsList.vb](./VB/DXWebApplication1/Models/PersonsList.vb))
* [PersonsList.cs](./CS/DXWebApplication1/Models/PersonsList.cs) (VB: [PersonsList.vb](./VB/DXWebApplication1/Models/PersonsList.vb))
* **[GridViewPartial.cshtml](./CS/DXWebApplication1/Views/Home/GridViewPartial.cshtml)**
* [Index.cshtml](./CS/DXWebApplication1/Views/Home/Index.cshtml)
* [_Layout.cshtml](./CS/DXWebApplication1/Views/Shared/_Layout.cshtml)
<!-- default file list end -->
# GridView - How to use Bootstrap Glyphicons as Command Buttons


This example is based on the approach illustrated in the <a href="https://www.devexpress.com/Support/Center/p/E4058">How to emulate the Command Column with a data column DataItemTemplate</a> example.<br />It illustrates how to define custom HTML elements with specific class names inside a column's DataItemTemplate in order to apply a specific appearance (such as Bootstrap Glyphicon):<br />- Specify a custom column's content (DataItemTemplate) via the <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebMvcMVCxGridViewColumn_SetDataItemTemplateContenttopic">MVCxGridViewColumn.SetDataItemTemplateContent</a> method.<br />- Define the target expected HTML content inside it.<br />- Attach the client-side "click" event handler to the corresponding HTML elements. Use the related row's data (<a href="https://documentation.devexpress.com/#AspNet/DevExpressWebGridViewDataItemTemplateContainerMembersTopicAll">GridViewDataItemTemplateContainer</a>) and client-side <a href="https://documentation.devexpress.com/#AspNet/DevExpressWebScriptsASPxClientGridViewMembersTopicAll">ASPxClientGridView</a> API to mimic the built-in Command Buttons behavior.

<br/>


