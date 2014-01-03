Imports System.ComponentModel
Imports System.ComponentModel.DataAnnotations
Imports System.ComponentModel.DataAnnotations.Schema
Imports System.Globalization
Imports System.Data.Entity

'Public Class UsersContext
'    Inherits DbContext

'    Public Sub New()
'        MyBase.New("DefaultConnection")
'    End Sub

'    Public Property UserProfiles As DbSet(Of UserProfile)
'End Class

'<Table("UserProfile")> _
'Public Class UserProfile
'    <Key()> _
'    <DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity)> _
'    Public Property UserId As Integer

'    Public Property UserName As String
'End Class

'Public Class RegisterExternalLoginModel
'    <Required()> _
'    <Display(Name:="使用者名稱")> _
'    Public Property UserName As String

'    Public Property ExternalLoginData As String
'End Class

'Public Class LocalPasswordModel
'    <Required()> _
'    <DataType(DataType.Password)> _
'    <Display(Name:="目前密碼")> _
'    Public Property OldPassword As String

'    <Required()> _
'    <StringLength(100, ErrorMessage:="{0} 長度至少必須為 {2} 個字元。", MinimumLength:=6)> _
'    <DataType(DataType.Password)> _
'    <Display(Name:="新密碼")> _
'    Public Property NewPassword As String

'    <DataType(DataType.Password)> _
'    <Display(Name:="確認新密碼")> _
'    <Compare("NewPassword", ErrorMessage:="新密碼與確認密碼不相符。")> _
'    Public Property ConfirmPassword As String
'End Class

'Public Class LoginModel
'    <Required()> _
'    <Display(Name:="使用者名稱")> _
'    Public Property UserName As String

'    <Required()> _
'    <DataType(DataType.Password)> _
'    <Display(Name:="密碼")> _
'    Public Property Password As String

'    <Display(Name:="記住我?")> _
'    Public Property RememberMe As Boolean
'End Class

'Public Class RegisterModel
'    <Required()> _
'    <Display(Name:="使用者名稱")> _
'    Public Property UserName As String

'    <Required()> _
'    <StringLength(100, ErrorMessage:="{0} 長度至少必須為 {2} 個字元。", MinimumLength:=6)> _
'    <DataType(DataType.Password)> _
'    <Display(Name:="密碼")> _
'    Public Property Password As String

'    <DataType(DataType.Password)> _
'    <Display(Name:="確認密碼")> _
'    <Compare("Password", ErrorMessage:="密碼和確認密碼不相符。")> _
'    Public Property ConfirmPassword As String
'End Class

'Public Class ExternalLogin
'    Public Property Provider As String
'    Public Property ProviderDisplayName As String
'    Public Property ProviderUserId As String
'End Class
