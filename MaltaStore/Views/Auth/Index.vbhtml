@Code
    Layout = Nothing
End Code

<!DOCTYPE html>

<html lang="utf-8">
<head runat="server">
    <meta name="viewport" content="width=device-width" />
    <title>Check Account</title>
     <link href='~/Content/normalize.css' rel='stylesheet' type='text/css'>
     <link href='~/Content/loading_android.css' rel='stylesheet' type='text/css'>
    <script src="~/Scripts/jquery-1.10.1_min.js"></script>
    <script src="~/Scripts/prefixfree.min.js"></script>
    <script src="~/Scripts/modernizr.js"></script>
    <style>
        .load-Title {
            position: absolute;
            margin: auto;
            color:#fff;
            text-align:center;
            font-size:14px;
            top: -15%; bottom: 0; left: 0; right: 0;
            width: 6.250em; height: 6.250em;
            animation: rotate 2.4s linear infinite;
        }
    </style>
    <script>
        $(document).ready(function () {
            setTimeout(function () {
                window.location.href = "Login";
            }, 10000);
        });
    </script>
</head>
<body>
    <span class="load-Title">驗證中</span>
    <figure>
		<div class="dot white"></div>
		<div class="dot"></div>
		<div class="dot"></div>
		<div class="dot"></div>
		<div class="dot"></div>
	</figure>
    
</body>
</html>
