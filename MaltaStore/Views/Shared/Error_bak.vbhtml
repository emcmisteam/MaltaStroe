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
    <link href='http://fonts.googleapis.com/css?family=Electrolize' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Geo' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Lato:400,900' rel='stylesheet' type='text/css'>
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Content/page404css")
    @Scripts.Render("~/bundles/page404Js")
    <!--[if lt IE 9]>
	  <script src="~/Scripts/excanvas.min.js"></script>
	  <script src="~/Scripts/respond.min.js"></script>  
	<![endif]-->
</head>
<body class="page-404-full-page">

   <!----------------------------------------------------f58080----------------------------------------------------------------------->
   <!-- BEGIN 404 page -->
   <div class="row-fluid">
		<div class="span12 page-404">
			<div class="number" style="color:#eb6c6c">
				<strong>404</strong>
			</div>
			<div class="details">
				<h2>喔喔, 系統異常...</h2>
				<p style="font-size:16px;line-height:20px;">系統發生不可預期之錯誤, 請聯絡系統管理進行處理!!!<br /><br />
                    <button type="button" id="back-btn" class="btn black pull-right">
				    <i class="icon-user icon-white"></i> 登入
				    </button>
                    <button type="button" id="dashboard-btn" class="btn purple pull-right">
				    <i class="m-icon-swapleft m-icon-white"></i> 返回首頁 
				    </button>   
				</p>
                
			</div>
		</div>
   </div>
  <!-- END 404 page -->
  <!---------------------------------------------------------------------------------------------------------------------------> 

    <script>
        $(document).ready(function () {
            App.init();

            $("#back-btn").click(function () {
                window.location.href = "/Auth/Login";
            });
            $("#dashboard-btn").click(function () {
                window.location.href = "/Dashboard/Index";
            });
        });
	</script>
</body>
</html>