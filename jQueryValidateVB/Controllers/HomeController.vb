Public Class HomeController
    Inherits System.Web.Mvc.Controller

    Function Index() As ActionResult
        Return View()
    End Function

    <HttpPost>
    Function Index(form As FormCollection) As ActionResult

        ' replace with database operation. for now using a registration success view.
        If form IsNot Nothing Then
            Return RedirectToAction("RegistrationSuccess")
        End If

        Return View()

    End Function

    <HttpPost>
    Function EmailExists(email As String) As JsonResult

        ' replace sample code with database checking of email.
        Return Json(Not String.Equals(email, "testing@mail.ph", StringComparison.OrdinalIgnoreCase))
    End Function

    Function RegistrationSuccess() As ActionResult
        Return View()
    End Function

    Function About() As ActionResult
        ViewData("Message") = "Your application description page."

        Return View()
    End Function

    Function Contact() As ActionResult
        ViewData("Message") = "Your contact page."

        Return View()
    End Function
End Class
