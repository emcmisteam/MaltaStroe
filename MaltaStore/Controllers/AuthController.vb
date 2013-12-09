Public Class AuthController
    Inherits System.Web.Mvc.Controller

    '
    ' GET: /Auth

    Function Login() As ActionResult
        Return View()
    End Function

    '
    ' GET: /Auth/Details/5

    Function Details(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    '
    ' GET: /Auth/Create

    Function Create() As ActionResult
        Return View()
    End Function

    '
    ' POST: /Auth/Create

    <HttpPost()> _
    Function Create(ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Add insert logic here
            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    '
    ' GET: /Auth/Edit/5

    Function Edit(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    '
    ' POST: /Auth/Edit/5

    <HttpPost()> _
    Function Edit(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Add update logic here

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function

    '
    ' GET: /Auth/Delete/5

    Function Delete(ByVal id As Integer) As ActionResult
        Return View()
    End Function

    '
    ' POST: /Auth/Delete/5

    <HttpPost()> _
    Function Delete(ByVal id As Integer, ByVal collection As FormCollection) As ActionResult
        Try
            ' TODO: Add delete logic here

            Return RedirectToAction("Index")
        Catch
            Return View()
        End Try
    End Function
End Class