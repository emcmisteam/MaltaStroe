@Code
    Layout = Nothing
End Code

<!DOCTYPE html>
<html lang="utf-8">
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="shortcut icon" href="~/Content/image/favicon.ico" type="image/x-icon">
    <title>MaltaStore | Error 404 Page </title>
    @Styles.Render("~/Content/page404css")
    <link href='~/Content/font-awesome.css' rel='stylesheet' type='text/css'>
    <link href='~/Content/style-metro-error404.css' rel='stylesheet' type='text/css'>
    <link href='~/Content/style.css' rel='stylesheet' type='text/css'>
    <link href='~/Content/style-responsive.css' rel='stylesheet' type='text/css'>
    <link href='~/Content/uniform.default.css' rel='stylesheet' type='text/css'>
    <link href='~/Content/normalize.css' rel='stylesheet' type='text/css'>
    <link href='~/Content/loading_android.css' rel='stylesheet' type='text/css'>
    @Scripts.Render("~/bundles/core")
    @Scripts.Render("~/bundles/page404Js")
    <!--[if lt IE 9]>
	  <script src="~/Scripts/excanvas.min.js"></script>
	  <script src="~/Scripts/respond.min.js"></script>  
	<![endif]-->
    <script src="~/Scripts/prefixfree.min.js"></script>
    <script src="~/Scripts/modernizr.js"></script>
</head>
<body > 

   <!----------------------------------------------------f58080----------------------------------------------------------------------->
   <!-- BEGIN 404 page -->
   <div class="container">

        <!-- Logo -->
		<div class="row-fluid">
			<div class="span12 coming-soon-header">
				<div class="logo">
	               MLATE <span style="color:#f54b4b">STORE</span>
               </div>
			</div>
		</div>
		<div class="row-fluid">
			<div class="span5 coming-soon-content">
				<h1>喔喔. 系統異常...</h1>
				<p>系統發生不可預期之錯誤, 請聯絡系統管理進行處理!!!<br>或點選下列其他功能連結。</p>
				<br>
				<form class="form-search" action="#">
					<div class="input-append">
                        <button type="button" class="btn green btn-back"><i class="m-icon-swapleft m-icon-white"></i> <span>返回上一頁</span></button>
						<button type="button" class="btn blue btn-dashboard"><i class="icon-home icon-white"></i> <span>資訊儀錶板</span></button>
                        <button type="button" class="btn purple btn-login"><i class="icon-user icon-white"></i> <span>登入</span></button>
					</div>
				</form>
			</div>
			<div class="span7 coming-soon-countdown">
				 <figure>
		            <div class="dot white" ></div>
		            <div class="dot"></div>
		            <div class="dot"></div>
		            <div class="dot"></div>
		            <div class="dot"></div>
	            </figure>
                <div class="number">
				   <strong>404</strong>
			    </div>
			</div>
		</div>
		<!--/end row-fluid-->
		<div class="row-fluid">
			 <div class="span12 coming-soon-footer">
				2013 &copy; MLATESTORE - DASHBOARD. V.0.1
			</div>
		</div>
	</div>
  <!-- END 404 page -->
  <!---------------------------------------------------------------------------------------------------------------------------> 

    <script>
        $(document).ready(function () {
            App.init();

            $(".btn-back").click(function () {
                window.history.back();
            });
            $(".btn-dashboard").click(function () {
                window.location.href = "/Dashboard/Index";
            });
            $(".btn-login").click(function () {
                window.location.href = "/";
            });
            
        });
	</script>
</body>
</html>