<!DOCTYPE html>
<!--[if IE 8]> <html lang="utf-8" class="ie8 no-js"> <![endif]-->
<!--[if IE 9]> <html lang="utf-8" class="ie9 no-js"> <![endif]-->
<!--[if !IE]><!-->
<html lang="utf-8" class="no-js">
 <!--<![endif]-->
<head>
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta name="description" content="">
    <meta name="author" content="">
    <link rel="shortcut icon" href="~/Content/image/favicon.ico" type="image/x-icon">
    <title>MaltaStore | Admin </title>
    <link href='http://fonts.googleapis.com/css?family=Electrolize' rel='stylesheet' type='text/css'>
    <link href='http://fonts.googleapis.com/css?family=Geo' rel='stylesheet' type='text/css'>
    @Styles.Render("~/Content/css")
    @Styles.Render("~/Content/dashboardCss")
    @Scripts.Render("~/bundles/core")
    @Scripts.Render("~/bundles/dashboardJs")
    <!--[if lt IE 9]>
      <script src="~/Scripts/excanvas.min.js"></script>
      <script src="~/Scripts/respond.min.js"></script>
    <![endif]-->

</head>
<body class="page-header-fixed">

    <!-- BEGIN HEADER -->
    <div class="header navbar navbar-inverse navbar-fixed-top">
        <!-- BEGIN TOP NAVIGATION BAR -->
        <div class="navbar-inner">
            <div class="container-fluid">
                <!-- BEGIN LOGO -->
                <div class="brand" style="padding-left:25px; color:#fff">
                    MLATE <span style="color:#f54b4b">STORE</span>
                </div>
                <!-- END LOGO -->
                <!-- BEGIN RESPONSIVE MENU TOGGLER -->
                <a href="javascript:;" class="btn-navbar collapsed" data-toggle="collapse" data-target=".nav-collapse">
                    <img src="~/Content/image/menu-toggler.png" alt="" />
                </a>
                <!-- END RESPONSIVE MENU TOGGLER -->
                <!-- BEGIN TOP NAVIGATION MENU -->
                <ul class="nav pull-right">
                    <!-- BEGIN NOTIFICATION DROPDOWN -->
                    <li class="dropdown" id="header_notification_bar">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            <i class="icon-warning-sign"></i>
                            <span class="badge">6</span>
                        </a>
                        <ul class="dropdown-menu extended notification">
                            <li>
                                <p>系統資訊</p>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="label label-success"><i class="icon-plus"></i></span>
                                    使用者註冊通知
                                    <span class="time">Just now</span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="label label-important"><i class="icon-bolt"></i></span>
                                    伺服器#12 記憶體不足
                                    <span class="time">15 mins</span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="label label-warning"><i class="icon-bell"></i></span>
                                    伺服器#4 無回應
                                    <span class="time">22 mins</span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="label label-info"><i class="icon-bullhorn"></i></span>
                                    應用程式錯誤
                                    <span class="time">40 mins</span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="label label-important"><i class="icon-bolt"></i></span>
                                    資料庫負載68%
                                    <span class="time">2 hrs</span>
                                </a>
                            </li>
                            <li class="external">
                                <a href="#">更多系統資訊 <i class="m-icon-swapright"></i></a>
                            </li>
                        </ul>
                    </li>
                    <!-- END NOTIFICATION DROPDOWN -->
                    <!-- BEGIN INBOX DROPDOWN -->
                    <li class="dropdown" id="header_inbox_bar">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            <i class="icon-envelope"></i>
                            <span class="badge">5</span>
                        </a>
                        <ul class="dropdown-menu extended inbox">
                            <li>
                                <p>訊息通知</p>
                            </li>
                            <li>
                                <a href="inbox.html?a=view">
                                    <span class="photo"><img src="~/Content/image/user/avatar2.jpg" alt="" /></span>
                                    <span class="subject">
                                        <span class="from">楊雪舞</span>
                                        <span class="time">Just Now</span>
                                    </span>
                                    <span class="message">
                                        三義6.8度凍!合歡山積雪20公分赤裸上身著短褲合歡山上打雪仗...
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="inbox.html?a=view">
                                    <span class="photo"><img src="~/Content/image/user/avatar3.jpg" alt="" /></span>
                                    <span class="subject">
                                        <span class="from">宇文邕</span>
                                        <span class="time">16 mins</span>
                                    </span>
                                    <span class="message">
                                        快去加油！ 下周油價每公升恐漲0.5元...
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="inbox.html?a=view">
                                    <span class="photo"><img src="~/Content/image/user/avatar1.jpg" alt="" /></span>
                                    <span class="subject">
                                        <span class="from">楊智深</span>
                                        <span class="time">2 hrs</span>
                                    </span>
                                    <span class="message">
                                        明年機戰！三星推智慧手環LG採指紋掃瞄宏達電新4G上市...
                                    </span>
                                </a>
                            </li>
                            <li class="external">
                                <a href="#">更多訊息 <i class="m-icon-swapright"></i></a>
                            </li>
                        </ul>
                    </li>
                    <!-- END INBOX DROPDOWN -->
                    <!-- BEGIN TODO DROPDOWN -->
                    <li class="dropdown" id="header_task_bar">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            <i class="icon-tasks"></i>
                            <span class="badge">5</span>
                        </a>
                        <ul class="dropdown-menu extended tasks">
                            <li>
                                <p>待辦事項</p>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="task">
                                        <span class="desc">OS更新版本 v1.2</span>
                                        <span class="percent">30%</span>
                                    </span>
                                    <span class="progress progress-success ">
                                        <span style="width: 30%;" class="bar"></span>
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="task">
                                        <span class="desc">後台程式上版</span>
                                        <span class="percent">65%</span>
                                    </span>
                                    <span class="progress progress-danger progress-striped active">
                                        <span style="width: 65%;" class="bar"></span>
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="task">
                                        <span class="desc">手機程式更新</span>
                                        <span class="percent">98%</span>
                                    </span>
                                    <span class="progress progress-success">
                                        <span style="width: 98%;" class="bar"></span>
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="task">
                                        <span class="desc">資料庫升級</span>
                                        <span class="percent">10%</span>
                                    </span>
                                    <span class="progress progress-warning progress-striped">
                                        <span style="width: 10%;" class="bar"></span>
                                    </span>
                                </a>
                            </li>
                            <li>
                                <a href="#">
                                    <span class="task">
                                        <span class="desc">前台購物車更新</span>
                                        <span class="percent">58%</span>
                                    </span>
                                    <span class="progress progress-info">
                                        <span style="width: 58%;" class="bar"></span>
                                    </span>
                                </a>
                            </li>
                            <li class="external">
                                <a href="#">更多待辦事項 <i class="m-icon-swapright"></i></a>
                            </li>
                        </ul>
                    </li>
                    <!-- END TODO DROPDOWN -->
                    <!-- BEGIN USER LOGIN DROPDOWN -->
                    <li class="dropdown user">
                        <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                            <img alt="" src="~/Content/image/user/avatar1_small.jpg" />
                            <span class="username">蘭陵王</span>
                            <i class="icon-angle-down"></i>
                        </a>
                        <ul class="dropdown-menu">
                            <li><a href="#"><i class="icon-user"></i> 個人資料</a></li>
                            <li><a href="#"><i class="icon-envelope"></i> 個人訊息(3)</a></li>
                            <li><a href="#"><i class="icon-tasks"></i> 代辦事項</a></li>
                            <li class="divider"></li>
                            <li><a href="~/Auth/Logout"><i class="icon-signout"></i> 登出</a></li>
                        </ul>
                    </li>
                    <!-- END USER LOGIN DROPDOWN -->
                </ul>
                <!-- END TOP NAVIGATION MENU -->
            </div>
        </div>
        <!-- END TOP NAVIGATION BAR -->
    </div>
    <!-- END HEADER -->
    <!---------------------------------------------------------------------------------------------------->
    <!-- BEGIN CONTAINER -->

    <div class="page-container row-fluid">
        <!-- BEGIN SIDEBAR -->
        <div class="page-sidebar nav-collapse collapse">
            <!-- BEGIN SIDEBAR MENU -->
            <ul class="page-sidebar-menu">
                <li>
                    <!-- BEGIN SIDEBAR TOGGLER BUTTON -->
                    <div class="sidebar-toggler hidden-phone"></div>
                    <!-- BEGIN SIDEBAR TOGGLER BUTTON -->
                </li>
                <li>
                    <!-- BEGIN RESPONSIVE QUICK SEARCH FORM -->
                    <form class="sidebar-search">
                        <div class="input-box">
                            <a href="javascript:;" class="remove"></a>
                            <input type="text" placeholder="Search..." />
                            <input type="button" class="submit" value=" " />
                        </div>
                    </form>
                    <!-- END RESPONSIVE QUICK SEARCH FORM -->
                </li>

                <li class="start active">
                    <a href="index">
                        <i class="icon-home"></i>
                        <span class="title">資訊儀表板</span>
                    </a>
                </li>

                <li class="">
                    <a href="javascript:;">
                        <i class="icon-bar-chart"></i>
                        <span class="title">銷售統計</span>
                        <span class="arrow "></span>
                    </a>
                    <ul class="sub-menu">
                        <li>
                            <a href="#">
                                銷售資訊
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                產品資訊
                            </a>
                        </li>
                    </ul>
                </li>

                <li class="">
                    <a href="javascript:;">
                        <i class="icon-shopping-cart"></i>
                        <span class="title">訂單管理</span>
                        <span class="arrow "></span>
                    </a>
                    <ul class="sub-menu">
                        <li>
                            <a href="#">
                                訂單查詢
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                訂單狀態
                            </a>
                        </li>
                    </ul>
                </li>

                <li class="">
                    <a href="javascript:;">
                        <i class="icon-inbox"></i>
                        <span class="title">商品管理</span>
                        <span class="arrow "></span>
                    </a>
                    <ul class="sub-menu">
                        <li>
                            <a href="#">
                                分類管理
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                品牌管理
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                產品銷售管理
                            </a>
                        </li>
                    </ul>
                </li>

                <li class="">
                    <a href="javascript:;">
                        <i class="icon-credit-card"></i>
                        <span class="title">付款方式設定</span>
                        <span class="arrow "></span>
                    </a>
                    <ul class="sub-menu">
                        <li>
                            <a href="#">
                                ATM轉帳/匯款
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                面交
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                線上刷卡
                            </a>
                        </li>
                    </ul>
                </li>

                <li class="">
                    <a href="javascript:;">
                        <i class="icon-truck"></i>
                        <span class="title">配送方式設定</span>
                        <span class="arrow "></span>
                    </a>
                    <ul class="sub-menu">
                        <li>
                            <a href="#">
                                郵寄送貨
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                超商取貨
                            </a>
                        </li>
                    </ul>
                </li>

                <li class="">
                    <a href="javascript:;">
                        <i class="icon-user"></i>
                        <span class="title">後台帳號管理</span>
                        <span class="arrow "></span>
                    </a>
                    <ul class="sub-menu">
                        <li>
                            <a href="#">
                                權限分類
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                帳號管理
                            </a>
                        </li>
                    </ul>
                </li>

                <li class="">
                    <a href="javascript:;">
                        <i class="icon-group"></i>
                        <span class="title">顧客帳號管理</span>
                        <span class="arrow "></span>
                    </a>
                    <ul class="sub-menu">
                        <li>
                            <a href="#">
                                顧客帳號管理
                            </a>
                        </li>
                        <li>
                            <a href="#">
                                消費分析
                            </a>
                        </li>
                    </ul>
                </li>

                <!-- END SIDEBAR MENU -->

        </div>

        <!-- END SIDEBAR -->
        <!---------------------------------------------------------------------------------------------------->
        <!-- BEGIN PAGE -->
        <div class="page-content">
            <!-- BEGIN SAMPLE PORTLET CONFIGURATION MODAL FORM-->
            <div id="portlet-config" class="modal hide">
                <div class="modal-header">
                    <button data-dismiss="modal" class="close" type="button"></button>
                    <h3>Widget Settings</h3>
                </div>
                <div class="modal-body">
                    Widget Settings form goes here
                </div>
            </div>
            <!-- END SAMPLE PORTLET CONFIGURATION MODAL FORM-->
            <!-- BEGIN PAGE CONTAINER-->

            <div class="container-fluid">
                        @RenderBody()
            </div>
        </div>


        <!-- BEGIN FOOTER -->
        <div class="footer">
            <div class="footer-inner">
                2013 &copy; MLATESTORE - DASHBOARD. V.0.1
            </div>
            <div class="footer-tools">
                <span class="go-top">
                    <i class="icon-angle-up"></i>
                </span>
            </div>
        </div>
        <!-- END FOOTER -->
        <!-- Javascript -->
        <script>
            $(document).ready(function () {
                App.init(); // initlayout and core plugins
                Index.init();
               // Index.initJQVMAP(); // init index page's custom scripts
               // Index.initCalendar(); // init index page's custom scripts
               // Index.initCharts(); // init index page's custom scripts
               // Index.initChat();
               // Index.initMiniCharts();
               // Index.initDashboardDaterange();
               // Index.initIntro();
            });
        </script>

</body>
</html>
