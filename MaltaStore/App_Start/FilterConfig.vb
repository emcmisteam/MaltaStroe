Imports System.Web
Imports System.Web.Mvc

Public Class FilterConfig
    Public Shared Sub RegisterGlobalFilters(ByVal filters As GlobalFilterCollection)

        Debug.WriteLine(" ---[RegisterGlobalFilters]---")

        'filters.Add(new HandleErrorAttribute( _
        '  ExceptionType = typeof(System.Data.DataException),
        '  View = "DatabaseError" _
        '   )

        filters.Add(New HandleErrorAttribute())
        'filters.Add(New WebAuthorizeFilter())

    End Sub
End Class