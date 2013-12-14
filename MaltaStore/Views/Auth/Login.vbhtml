@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html lang="utf-8">
<head runat="server">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
	<link rel="shortcut icon" href="~/Content/image/favicon.ico" type="image/x-icon">
    <title>MaltaStore | Login </title>
    <link href='http://fonts.googleapis.com/css?family=Electrolize' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Geo' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Lato:400,900' rel='stylesheet' type='text/css'>
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Content/loginCss")
    @Scripts.Render("~/bundles/core")
    @Scripts.Render("~/bundles/login")
    <!--[if lt IE 9]>
	  <script src="~/Scripts/excanvas.min.js"></script>
	  <script src="~/Scripts/respond.min.js"></script>  
	<![endif]-->  
</head>
<body class="login">
   <!-- BEGIN LOGO -->
   <div class="logo">
	MLATE <span style="color:#f54b4b">STORE<span>
   </div>
   <!-- END LOGO -->


   <!--------------------------------------------------------------------------------------------------------------------------->
   <!-- BEGIN LOGIN -->
   <div class="content">
		<!-- BEGIN LOGIN FORM -->
       <form class="form-vertical login-form" action="Auth/AuthAccount" method="post">
			<h3 class="form-title">登入作業</h3>
			<div class="alert alert-error hide">
				<button class="close" data-dismiss="alert"></button>
				<span>請輸入電子郵件帳號和密碼</span>
			</div>
			<div class="control-group">
				<!--ie8, ie9 does not support html5 placeholder, so we just show field title for that-->
				<label class="control-label visible-ie8 visible-ie9">Username</label>
				<div class="controls">
					<div class="input-icon left">
						<i class="icon-envelope"></i>
						<input class="m-wrap placeholder-no-fix" type="text" placeholder="電子郵件" name="email"/>
					</div>
				</div>
			</div>
			<div class="control-group">
				<label class="control-label visible-ie8 visible-ie9">Password</label>
				<div class="controls">
					<div class="input-icon left">
						<i class="icon-lock"></i>
						<input class="m-wrap placeholder-no-fix" type="password" placeholder="密碼" name="password"/>
					</div>
				</div>
			</div>
			<div class="form-actions">
				<label class="checkbox">
				<input type="checkbox" name="remember" value="1"/> 記住我
				</label>
				<button type="submit" class="btn green pull-right">
				登入 <i class="m-icon-swapright m-icon-white"></i>
				</button>            
			</div>
			<div class="forget-password">
				<h4>忘記密碼 ?</h4>
				<p>
					請從 <a href="javascript:;" class="" id="forget-password">這裡</a>
					重新發送您的密碼至信箱
				</p>
			</div>
			<div class="create-account">
				<p>
					沒有登入帳號 ?&nbsp; 
					<a href="javascript:;" id="register-btn" class="">請新增帳號</a>
				</p>
			</div>
		</form>
        <!-- END LOGIN FORM -->  


        <!-- BEGIN FORGOT PASSWORD FORM -->
        <form class="form-vertical forget-form" action="index.html">
			<h3 class="">忘記密碼 ?</h3>
			<p>請輸入您所註冊的電子郵件信箱,<br>系統將重新發送新密碼至此信箱中</p>
			<div class="control-group">
				<div class="controls">
					<div class="input-icon left">
						<i class="icon-envelope"></i>
						<input class="m-wrap placeholder-no-fix" type="text" placeholder="Email" name="email" />
					</div>
				</div>
			</div>
			<div class="form-actions">
				<button type="button" id="back-btn" class="btn">
				<i class="m-icon-swapleft"></i> Back
				</button>
				<button type="submit" class="btn green pull-right">
				Submit <i class="m-icon-swapright m-icon-white"></i>
				</button>           
			</div>
		</form>
        <!-- END FORGOT PASSWORD FORM -->

        
        <!-- BEGIN REGISTRATION FORM -->
		<form class="form-vertical register-form" action="index.html">
			<h3 class="">註冊</h3>
			<p>請填寫註冊資訊:</p>
			<div class="control-group">
				<label class="control-label visible-ie8 visible-ie9">使用者名稱</label>
				<div class="controls">
					<div class="input-icon left">
						<i class="icon-user"></i>
						<input class="m-wrap placeholder-no-fix" type="text" placeholder="使用者名稱" name="username"/>
					</div>
				</div>
			</div>
			<div class="control-group">
				<label class="control-label visible-ie8 visible-ie9">密碼</label>
				<div class="controls">
					<div class="input-icon left">
						<i class="icon-lock"></i>
						<input class="m-wrap placeholder-no-fix" type="password" id="register_password" placeholder="密碼" name="password"/>
					</div>
				</div>
			</div>
			<div class="control-group">
				<label class="control-label visible-ie8 visible-ie9">密碼確認</label>
				<div class="controls">
					<div class="input-icon left">
						<i class="icon-ok"></i>
						<input class="m-wrap placeholder-no-fix" type="password" placeholder="密碼確認" name="rpassword"/>
					</div>
				</div>
			</div>
			<div class="control-group">
				<!--ie8, ie9 does not support html5 placeholder, so we just show field title for that-->
				<label class="control-label visible-ie8 visible-ie9">電子郵件</label>
				<div class="controls">
					<div class="input-icon left">
						<i class="icon-envelope"></i>
						<input class="m-wrap placeholder-no-fix" type="text" placeholder="電子郵件" name="email"/>
					</div>
				</div>
			</div>
			<div class="form-actions">
				<button id="register-back-btn" type="button" class="btn">
				<i class="m-icon-swapleft"></i>  Back
				</button>
				<button type="submit" id="register-submit-btn" class="btn green pull-right">
				Sign Up <i class="m-icon-swapright m-icon-white"></i>
				</button>            
			</div>

		</form>
        <!-- END REGISTRATION FORM -->


       <!---------------------------------------------------------------------------------------------------------------------------> 
	 
  </div>
  <!-- END LOGIN -->
  




  <!-- BEGIN COPYRIGHT --> 
  <div class="copyright">
	2013 &copy; MLATESTORE - DASHBOARD. V.0.1
  </div>
  <!-- END COPYRIGHT -->

    <script>
      $(document).ready(function(){
          App.init();
          Login.init();
      });
	</script>
</body>
</html>
