<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128551127/19.1.8%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E2836)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Grid View for ASP.NET MVC - How to bind grid to XPO in server mode

This example demonstrates how to use the [GridViewExtension.BindToLINQ](https://docs.devexpress.com/AspNetMvc/DevExpress.Web.Mvc.GridViewExtension.BindToLINQ.overloads) method to bind the [GridView](https://docs.devexpress.com/AspNetMvc/8966/components/grid-view) extension to a **LINQ to XPO** data source.

```csharp
@Html.DevExpress().GridView(settings => {
    settings.Name = "gvDataBindingToLinq";
    // ...
}).BindToLINQ(string.Empty, string.Empty, (s, e) => {
    e.KeyExpression = "Oid";
    DevExpress.Xpo.Session session = XpoHelper.GetNewSession();
    DevExpress.Xpo.XPQuery<MyObject> query = new DevExpress.Xpo.XPQuery<MyObject>(session);
    e.QueryableSource = query;
}).GetHtml()
```

## Files to Review

* [_GridViewPartial.cshtml](./CS/E2836/Views/Home/_GridViewPartial.cshtml) (VB: [GridViewPartial.vbhtml](./VB/E2836/Views/Home/_GridViewPartial.vbhtml))

## Documentation

* [XPO Tutorials - ASP.NET](https://github.com/DevExpress/XPO/tree/master/Tutorials/ASP.NET)
<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-grid-bind-to-xpo-in-server-mode&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=asp-net-mvc-grid-bind-to-xpo-in-server-mode&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->
