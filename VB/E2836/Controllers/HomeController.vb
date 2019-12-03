Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        ViewData("Message") = "How to bind GridView to XPO in Server Mode"

        Return View()
    End Function

    Public Function GridViewPartial() As ActionResult
        Return PartialView("_GridViewPartial")
    End Function
End Class