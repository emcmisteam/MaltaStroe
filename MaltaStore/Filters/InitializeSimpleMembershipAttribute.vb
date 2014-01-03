'Imports System.Data.Entity
'Imports System.Data.Entity.Infrastructure
'Imports System.Threading
'Imports WebMatrix.WebData

'<AttributeUsage(AttributeTargets.Class Or AttributeTargets.Method, AllowMultiple:=False, Inherited:=True)>
'Public NotInheritable Class InitializeSimpleMembershipAttribute
'    Inherits ActionFilterAttribute

'    Private Shared _initializer As SimpleMembershipInitializer
'    Private Shared _initializerLock As New Object
'    Private Shared _isInitialized As Boolean

'    Public Overrides Sub OnActionExecuting(filterContext As ActionExecutingContext)
'        ' 請確定一個應用程式啟動只起始一次 ASP.NET Simple Membership
'        LazyInitializer.EnsureInitialized(_initializer, _isInitialized, _initializerLock)
'    End Sub

'    Private Class SimpleMembershipInitializer
'        Public Sub New()
'            Database.SetInitializer(Of UsersContext)(Nothing)

'            Try
'                Using context As New UsersContext()
'                    If Not context.Database.Exists() Then
'                        ' 建立沒有 Entity Framework 移轉結構描述的 SimpleMembership 資料庫 
'                        CType(context, IObjectContextAdapter).ObjectContext.CreateDatabase()
'                    End If
'                End Using

'                WebSecurity.InitializeDatabaseConnection("DefaultConnection", "UserProfile", "UserId", "UserName", autoCreateTables:=True)
'            Catch ex As Exception
'                Throw New InvalidOperationException("無法起始 ASP.NET Simple Membership 資料庫。如需詳細資訊，請參閱 http://go.microsoft.com/fwlink/?LinkId=256588", ex)
'            End Try
'        End Sub
'    End Class
'End Class
