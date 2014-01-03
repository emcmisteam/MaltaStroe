<System.AttributeUsage(System.AttributeTargets.All, AllowMultiple:=False, Inherited:=True)>
Public Class WebAuthorizeFilter
    Inherits System.Web.Mvc.ActionFilterAttribute
    'Implements IActionFilter, IResultFilter

    'Private _isAuth As Boolean

    'Public Property IsAuth() As Boolean
    '    Get
    '        Return _isAuth
    '    End Get
    '    Private Set(ByVal value As Boolean)
    '        _isAuth = value
    '    End Set
    'End Property

    Dim logConsole As New DebugLog


    ''' <summary>
    ''' 在Action method之前執行
    ''' </summary>
    ''' <param name="filterContext"></param>
    ''' <remarks></remarks>
    Public Overrides Sub OnActionExecuting(filterContext As ActionExecutingContext)
        'Protected Overrides Function AuthorizeCore(httpContext As HttpContextBase) As Boolean
        logConsole.LogToConsole(" [OnAuthorization Filter][在Action method之前執行]........")
        ' Debug.WriteLine("----------------- >> _isAuth >> " + _isAuth)
        logConsole.LogToConsole(" AuthorizationContext RawUrl >> " + filterContext.HttpContext.Request.RawUrl)
        'Dim authroized As Boolean
        'authroized =

        'Me.OnActionExecuting(filterContext)
        'Dim hhtpResul As HttpUnauthorizedResult
        'hhtpResul = filterContext.Result

        'Me.OnAuthorization(filterContext)
        'If filterContext.Result Then
        '    Debug.WriteLine("AuthorizationContext Result >> true")
        '    Return
        'Else
        '    Debug.WriteLine("AuthorizationContext Result >> false")

        'End If

        Dim filterInfo As New filterContextInfo()
        filterInfo.GetFilterContext(filterContext)

        logConsole.LogToConsole(" [OnAuthorization Filter][controllerName] >> " + filterInfo.controllerName)
        logConsole.LogToConsole(" [OnAuthorization Filter][actionName] >> " + filterInfo.actionName)



        logConsole.LogToConsole(" [判斷Session.User是否存在][Start]")

        Dim url As String = filterInfo.domainName

        If filterContext.HttpContext.Session("User") Is Nothing Then
            logConsole.LogToConsole(" session.user 不存在,導向: Auth/Login")
            url = "/"
            filterContext.Result = New RedirectResult(url)
        Else
            url = filterContext.HttpContext.Request.RawUrl
            logConsole.LogToConsole(" session.user 存在, 不需檢查, 直接轉向")
            logConsole.LogToConsole(" Session.User >> " + _
                                filterContext.HttpContext.Session("User").email + " / " + _
                                filterContext.HttpContext.Session("User").password)
        End If

        logConsole.LogToConsole(" [判斷Session.User是否存在][End]")


        'Dim url As String = "Dashboard/Index"
        'Dim controller As String = filterContext.RouteData.Values("controller")
        'Dim action As String = filterContext.RouteData.Values("action")

        'Debug.WriteLine("AuthorizationContext controller >> " + controller)
        'Debug.WriteLine("AuthorizationContext controller >> " + action)


        'If String.Compare(controller, "Auth") = 0 Or controller Is Nothing Then
        '    ' 進入登入驗證, 不需檢查, 直接轉向
        '    Debug.WriteLine("----------- >> 進入登入驗證, 不需檢查, 直接轉向")
        '    url = filterContext.HttpContext.Request.RawUrl
        'Else
        '    ' 不是Auth Controller, 就都需要進行驗證
        '    ' 判斷 session.user 是否存在
        '    Debug.WriteLine("----------- >> 判斷 session.user 是否存在")
        '    'If filterContext.HttpContext.Session("user") Is Nothing Then
        '    '    url = "/Auth/Login"
        '    '    Debug.WriteLine("----------- >> session.user 不存在 url =" + url)
        '    'Else
        '    '    url = "/Dashboard/Index"
        '    '    Debug.WriteLine("----------- >> session.user 存在 url =" + url)
        '    'End If
        '    'filterContext.Result = New RedirectResult(url)
        'End If





        'Debug.WriteLine("AuthorizationContext IsAjaxRequest >> " + filterContext.HttpContext.Request.IsAjaxRequest)
        'Debug.WriteLine("AuthorizationContext controller >> " + filterContext.RouteData.Values("controller"))
        'Debug.WriteLine("AuthorizationContext action >> " + filterContext.RouteData.Values("action"))
        Return
    End Sub

    ''' <summary>
    ''' 在Action method之後執行
    ''' </summary>
    ''' <param name="filterContext"></param>
    ''' <remarks></remarks>
    Public Overrides Sub OnActionExecuted(filterContext As ActionExecutedContext)
        logConsole.LogToConsole(" [OnActionExecuted Filter][在Action method之後執行]")
        'Me.OnActionExecuted(filterContext)

    End Sub

    ''' <summary>
    ''' 在返回view之前執行
    ''' </summary>
    ''' <param name="filterContext"></param>
    ''' <remarks></remarks>
    Public Overrides Sub OnResultExecuting(filterContext As ResultExecutingContext)
        logConsole.LogToConsole(" [OnResultExecuting Filter][在返回view之前執行]")
        'Me.OnResultExecuting(filterContext)

    End Sub

    ''' <summary>
    ''' 在返回view之後執行
    ''' </summary>
    ''' <param name="filterContext"></param>
    ''' <remarks></remarks>
    Public Overrides Sub OnResultExecuted(filterContext As ResultExecutedContext)
        logConsole.LogToConsole(" [OnResultExecuting Filter][在返回view之後執行]")
        'Me.OnResultExecuted(filterContext)

    End Sub

End Class



Public Class filterContextInfo
    Dim logConsole As New DebugLog

    Private _domainName As String

    Public Property domainName() As String
        Get
            Return _domainName
        End Get
        Private Set(ByVal value As String)
            _domainName = value
        End Set
    End Property

    Private _moduleStr As String
    Public Property moduleName() As String
        Get
            Return _moduleStr
        End Get
        Private Set(ByVal value As String)
            _moduleStr = value
        End Set
    End Property

    Private _controllerName As String
    Public Property controllerName() As String
        Get
            Return _controllerName
        End Get
        Private Set(ByVal value As String)
            _controllerName = value
        End Set
    End Property

    Private _actionName As String
    Public Property actionName() As String
        Get
            Return _actionName
        End Get
        Private Set(ByVal value As String)
            _actionName = value
        End Set
    End Property

    Public Sub GetFilterContext(filterContext As ActionExecutingContext)
        ' #region 取得連接中的字串
        ' 取得網域名()
        domainName = filterContext.HttpContext.Request.Url.Authority
        logConsole.LogToConsole("網域名:" + domainName)

        ' 取得模組名稱
        'moduleName = filterContext.HttpContext.Request.Url.Segments(1).Replace("/", " ").Trim()
        'logConsole.LogToConsole("模組名:" + moduleName)

        ' 取得 controller 名稱
        controllerName = filterContext.RouteData.Values("controller").ToString()
        logConsole.LogToConsole("controller: " + controllerName)

        ' 取得 ACTION 名稱
        actionName = filterContext.RouteData.Values("action").ToString()
        logConsole.LogToConsole("actionName: " + actionName)
    End Sub

End Class

Public Class DebugLog

    Public Sub LogToConsole(logContent As String)
        Debug.WriteLine("[Debug.log] >>> " + logContent)
    End Sub
End Class