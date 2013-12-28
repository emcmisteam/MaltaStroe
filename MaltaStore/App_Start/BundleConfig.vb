Imports System.Web
Imports System.Web.Optimization

Public Class BundleConfig
    ' 如需 Bundling 的詳細資訊，請造訪 http://go.microsoft.com/fwlink/?LinkId=254725
    Public Shared Sub RegisterBundles(ByVal bundles As BundleCollection)

        ' GLOBAL CORE JS
        bundles.Add(New ScriptBundle("~/bundles/core").Include(
                    "~/Scripts/jquery-1.10.1_min.js",
                    "~/Scripts/jquery-migrate-1.2.1_min.js",
                    "~/Scripts/jquery-ui-1.10.1.custom_min.js",
                    "~/Scripts/bootstrap_min.js",
                    "~/Scripts/jquery.slimscroll_min.js",
                    "~/Scripts/jquery.blockui_min.js",
                    "~/Scripts/jquery.cookie_min.js",
                    "~/Scripts/jquery.uniform_min.js"))

        ' PAGE LEVEL Login JS
        bundles.Add(New ScriptBundle("~/bundles/login").Include(
                   "~/Scripts/jquery.validate_min.js",
                   "~/Scripts/app.js",
                   "~/Scripts/login.js",
                   "~/Scripts/prefixfree.min.js",
                   "~/Scripts/modernizr.js"))

        ' PAGE LEVEL page404 JS
        bundles.Add(New ScriptBundle("~/bundles/page404Js").Include(
                   "~/Scripts/jquery.countdown.js",
                   "~/Scripts/jquery.backstretch.min.js",
                   "~/Scripts/app.js",
                   "~/Scripts/error404.js"))

        ' PAGE LEVEL Dashboard JS
        bundles.Add(New ScriptBundle("~/bundles/dashboardJs").Include(
                   "~/Scripts/jquery.vmap.js",
                   "~/Scripts/jquery.vmap.russia.js",
                   "~/Scripts/jquery.vmap.world.js",
                   "~/Scripts/jquery.vmap.europe.js",
                   "~/Scripts/jquery.vmap.germany.js",
                   "~/Scripts/jquery.vmap.usa.js",
                   "~/Scripts/jquery.vmap.sampledata.js",
                   "~/Scripts/jquery.flot.js",
                   "~/Scripts/jquery.flot.resize.js",
                   "~/Scripts/jquery.pulsate.min.js",
                   "~/Scripts/date.js",
                   "~/Scripts/daterangepicker.js",
                   "~/Scripts/jquery.gritter.js",
                   "~/Scripts/fullcalendar.min.js",
                   "~/Scripts/jquery.easy-pie-chart.js",
                   "~/Scripts/jquery.sparkline.min.js",
                   "~/Scripts/Chart_min.js",
                   "~/Scripts/app.js",
                   "~/Scripts/index.js"))


        ' GLOBAL STYLE CSS
        bundles.Add(New StyleBundle("~/Content/css").Include(
                    "~/Content/bootstrap_min.css",
                    "~/Content/bootstrap-responsive_min.css",
                    "~/Content/font-awesome.css",
                    "~/Content/style-metro.css",
                    "~/Content/style.css",
                    "~/Content/style-responsive.css",
                    "~/Content/default.css",
                    "~/Content/uniform.default.css"))

        ' PAGE LEVEL Login STYLE CSS
        bundles.Add(New StyleBundle("~/Content/loginCss").Include(
                    "~/Content/normalize.css",
                    "~/Content/login.css"))

        ' PAGE LEVEL Page404 STYLE CSS
        bundles.Add(New StyleBundle("~/Content/page404css").Include(
                    "~/Content/bootstrap_min.css",
                    "~/Content/bootstrap-responsive_min.css",
                    "~/Content/error404.css"))

        ' PAGE LEVEL Dashboard STYLE CSS
        bundles.Add(New StyleBundle("~/Content/dashboardCss").Include(
                    "~/Content/jquery.gritter.css",
                    "~/Content/daterangepicker.css",
                    "~/Content/fullcalendar.css",
                    "~/Content/jqvmap.css",
                    "~/Content/jquery.easy-pie-chart.css",
                    "~/Content/DT_bootstrap.css"))


        'bundles.Add(New ScriptBundle("~/bundles/jquery").Include(
        '           "~/Scripts/jquery-{version}.js"))

        'bundles.Add(New ScriptBundle("~/bundles/jqueryui").Include(
        '            "~/Scripts/jquery-ui-{version}.js"))

        'bundles.Add(New ScriptBundle("~/bundles/jqueryval").Include(
        '            "~/Scripts/jquery.unobtrusive*",
        '            "~/Scripts/jquery.validate*"))

        '' 使用開發版本的 Modernizr 進行開發並學習。然後，當您
        '' 準備好實際執行時，請使用 http://modernizr.com 上的建置工具，只選擇您需要的測試。
        'bundles.Add(New ScriptBundle("~/bundles/modernizr").Include(
        '            "~/Scripts/modernizr-*"))

        'bundles.Add(New StyleBundle("~/Content/css").Include("~/Content/site.css"))

        'bundles.Add(New StyleBundle("~/Content/themes/base/css").Include(
        '            "~/Content/themes/base/jquery.ui.core.css",
        '            "~/Content/themes/base/jquery.ui.resizable.css",
        '            "~/Content/themes/base/jquery.ui.selectable.css",
        '            "~/Content/themes/base/jquery.ui.accordion.css",
        '            "~/Content/themes/base/jquery.ui.autocomplete.css",
        '            "~/Content/themes/base/jquery.ui.button.css",
        '            "~/Content/themes/base/jquery.ui.dialog.css",
        '            "~/Content/themes/base/jquery.ui.slider.css",
        '            "~/Content/themes/base/jquery.ui.tabs.css",
        '            "~/Content/themes/base/jquery.ui.datepicker.css",
        '            "~/Content/themes/base/jquery.ui.progressbar.css",
        '            "~/Content/themes/base/jquery.ui.theme.css"))
    End Sub
End Class