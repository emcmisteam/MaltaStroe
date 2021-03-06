﻿
Public Class AuthController
    Inherits System.Web.Mvc.Controller

    Dim logConsole As New DebugLog

    '
    ' GET: /Index

    Function Index() As ActionResult
        Return View()
    End Function

    '
    ' GET: /Login

    Function Login() As ActionResult
        logConsole.LogToConsole(" [Auth/Login]")

        If TempData("Error") IsNot Nothing Then
            logConsole.LogToConsole(" -------- Error Msg: " + TempData("Error"))
            ' [ViewData ] [ViewBag] [TempData] 請參考: http://www.dotblogs.com.tw/jasonyah/archive/2013/04/18/explain-viewbag-viewdata.aspx
            ViewBag.Error = TempData("Error")
        End If

        Return View()
    End Function

    '
    ' POST: /Login

    <HttpPost()> _
    Function AuthAccount(account As AuthLoginAccountModel, ByVal from As FormCollection) As ActionResult



        logConsole.LogToConsole(" [Auth/AuthAccount]")
        logConsole.LogToConsole(" [email] " + from("email"))
        logConsole.LogToConsole(" [password] " + from("password"))
        logConsole.LogToConsole(" ------------------------------------")
        logConsole.LogToConsole(" [email] " + account.email + "---")
        logConsole.LogToConsole(" [password] " + account.password + "---" + ModelState.IsValid.ToString)

        If account.email.Length > 0 And account.password.Length > 0 Then
            Dim userAdp As New UserDataSetTableAdapters.Store_UserTableAdapter
            If userAdp.CheckUserExist(account.email, account.password) > 0 Then
                Session("User") = account
                logConsole.LogToConsole(" [Auth/AuthAccount][Set Session.User.Email]>> " + Session("User").email.ToString + " <<")
                logConsole.LogToConsole(" [Auth/AuthAccount][Set Session.User.Password]>> " + Session("User").password.ToString + " <<")
                Return RedirectToAction("Index", "Dashboard")
            Else
                TempData("Error") = "帳號密碼錯誤!"
                Return RedirectToAction("Login")
            End If

            
            
        Else
            TempData("Error") = "server端驗證 - 錯訊訊息"
            Return RedirectToAction("Login")
        End If

    End Function


    '
    ' GET: /Logout

    Function Logout() As ActionResult
        Session("User") = Nothing
        logConsole.LogToConsole(" [Auth/Logout][Session.User]>> " + Session("user") + " <<")
        Return RedirectToAction("Index")
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




Public Class AuthLoginAccountModel
    Public Property email As String
    Public Property password As String
End Class