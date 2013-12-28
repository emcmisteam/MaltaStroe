﻿@Code
    ViewData("Title") = "Index"
    Layout = "~/Views/Shared/_Layout.vbhtml"
End Code

<!-- BEGIN PAGE HEADER-->
<div class="row-fluid">
    <div class="span12"> 
        <!-- BEGIN PAGE TITLE & BREADCRUMB-->
        <h3 class="page-title">
            資訊儀表板 <small>(資料匯整)</small>
        </h3>
        <ul class="breadcrumb">
            <li>
                <i class="icon-home"></i>
                <a href="index.html">首頁</a>
                <i class="icon-angle-right"></i>
            </li>
            <li><a href="#">資訊儀表板</a></li>
            <li class="pull-right no-text-shadow">
                <div id="dashboard-report-range" class="dashboard-date-range tooltips no-tooltip-on-touch-device responsive" data-tablet="" data-desktop="tooltips" data-placement="top" data-original-title="Change dashboard date range">
                    <i class="icon-calendar"></i>
                    <span></span>
                    <i class="icon-angle-down"></i>
                </div>
            </li>
        </ul>
        <!-- END PAGE TITLE & BREADCRUMB-->
    </div>
</div>
<!-- END PAGE HEADER-->


<div id="dashboard">
    <!-- BEGIN DASHBOARD STATS -->
    <div class="row-fluid">
        <div class="span3 responsive" data-tablet="span6" data-desktop="span3">
            <div class="dashboard-stat blue">
                <div class="visual">
                    <i class="icon-inbox"></i>
                </div>
                <div class="details">
                    <div class="number">
                        1349
                    </div>
                    <div class="desc">
                        庫存商品
                    </div>
                </div>
                <a class="more" href="#">
                    查看更多 <i class="m-icon-swapright m-icon-white"></i>
                </a>
            </div>
        </div>

        <div class="span3 responsive" data-tablet="span6" data-desktop="span3">
            <div class="dashboard-stat green">
                <div class="visual">
                    <i class="icon-shopping-cart"></i>
                </div>
                <div class="details">
                    <div class="number">549</div>
                    <div class="desc">新增訂單</div>
                </div>
                <a class="more" href="#">
                    查看更多 <i class="m-icon-swapright m-icon-white"></i>
                </a>
            </div>
        </div>

        <div class="span3 responsive" data-tablet="span6  fix-offset" data-desktop="span3">
            <div class="dashboard-stat purple">
                <div class="visual">
                    <i class="icon-globe"></i>
                </div>
                <div class="details">
                    <div class="number">+89%</div>
                    <div class="desc">銷售分析</div>
                </div>
                <a class="more" href="#">
                    查看更多 <i class="m-icon-swapright m-icon-white"></i>
                </a>
            </div>
        </div>

        <div class="span3 responsive" data-tablet="span6" data-desktop="span3">
            <div class="dashboard-stat yellow">
                <div class="visual">
                    <i class="icon-bar-chart"></i>
                </div>
                <div class="details">
                    <div class="number">12,5M$</div>
                    <div class="desc">獲利報告</div>
                </div>
                <a class="more" href="#">
                    查看更多 <i class="m-icon-swapright m-icon-white"></i>
                </a>
            </div>
        </div>
    </div>
    <!-- END DASHBOARD STATS -->
</div>


<div class="row-fluid">
    <div class="span6">
        <!-- BEGIN SAMPLE TABLE PORTLET-->
        <div class="portlet">
            <div class="portlet-title">
                <div class="caption"><i class="icon-comments"></i>最新登入客戶</div>
                <div class="tools">
                    <a href="javascript:;" class="collapse"></a>
                    <a href="#portlet-config" data-toggle="modal" class="config"></a>
                    <a href="javascript:;" class="reload"></a>
                    <!--a href="javascript:;" class="remove"></a -->
                </div>
            </div>
            <div class="portlet-body">
                <table class="table table-striped table-bordered table-advance table-hover">
                    <thead>
                        <tr>
                            <th><i class="icon-user"></i> 客戶名稱</th>
                            <th><i class="icon-map-marker"></i> 居住城市</th>
                            <th><i class="icon-time"></i> 最新登入時間</th>
                            <th><i class="icon-retweet"></i> 登入總數</th>
                            <th><i class="icon-shopping-cart"></i> 訂單總數</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td class="highlight">
                                <div class="success"></div>
                                <a href="#">梁次震</a>
                            </td>
                            <td>台北市</td>
                            <td>2013/12/31 13:20:11</td>
                            <td>23 次</td>
                            <td>5 筆, $ 4,560</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="info"></div>
                                <a href="#">陳秋華</a>
                            </td>
                            <td>台中市</td>
                            <td>2013/12/31 12:51:48</td>
                            <td>67 次</td>
                            <td>9 筆, $ 15,360</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="important"></div>
                                <a href="#">David</a>
                            </td>
                            <td>新竹市</td>
                            <td>2013/12/31 12:11:35</td>
                            <td>201 次</td>
                            <td>12 筆, $ 37,431</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="warning"></div>
                                <a href="#">Justin</a>
                            </td>
                            <td>新北市</td>
                            <td>2013/12/31 11:45:58</td>
                            <td>79 次</td>
                            <td>6 筆, $ 8,490</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="success"></div>
                                <a href="#">林曉東</a>
                            </td>
                            <td>高雄市</td>
                            <td>2013/12/31 11:20:11</td>
                            <td>44 次</td>
                            <td>5 筆, $ 5,560</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="info"></div>
                                <a href="#">Angel</a>
                            </td>
                            <td>新北市</td>
                            <td>2013/12/31 11:11:33</td>
                            <td>67 次</td>
                            <td>9 筆, $ 12,311</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="important"></div>
                                <a href="#">許文華</a>
                            </td>
                            <td>台北市</td>
                            <td>2013/12/31 10:59:37</td>
                            <td>7 次</td>
                            <td>0 筆, $ 0</td>
                        </tr>
                    </tbody>
                    <tfoot>
                        <tr>
                            <td colspan="5" style="font-size:10px;padding-left:8px">
                                <a href="#" class="btn mini blue-stripe">查看更多...</a>
                            </td>
                        </tr>
                    </tfoot>
                </table>
            </div>
        </div>
        <!-- END SAMPLE TABLE PORTLET-->
    </div>

    <div class="span6">
        <!-- BEGIN SAMPLE TABLE PORTLET-->
        <div class="portlet">
            <div class="portlet-title">
                <div class="caption"><i class="icon-comments"></i>最新訂單</div>
                <div class="tools">
                    <a href="javascript:;" class="collapse"></a>
                    <a href="#portlet-config" data-toggle="modal" class="config"></a>
                    <a href="javascript:;" class="reload"></a>
                    <!--a href="javascript:;" class="remove"></a -->
                </div>
            </div>
            <div class="portlet-body">
                <table class="table table-striped table-bordered table-advance table-hover">
                    <thead>
                        <tr>
                            <th><i class="icon-bookmark"></i> 訂單編號</th>
                            <th><i class="icon-user"></i> 客戶名稱</th>
                            <th><i class="icon-time"></i> 訂購時間</th>
                            <th><i class="icon-reorder"></i> 明細數量</th>
                            <th><i class="icon-shopping-cart"></i> 訂單總額</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td class="highlight">
                                <div class="success"></div>
                                <a href="#">OD20131231-0321</a>
                            </td>
                            <td>張榮華 (台北市)</td>
                            <td>2013/12/31 17:33:11</td>
                            <td>2 項</td>
                            <td>$ 4,560</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="info"></div>
                                <a href="#">OD20131231-0320</a>
                            </td>
                            <td>林艾咪 (高雄市)</td>
                            <td>2013/12/31 16:51:48</td>
                            <td>1 項</td>
                            <td>$ 1,360</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="important"></div>
                                <a href="#">OD20131231-0319</a>
                            </td>
                            <td>Alen (新竹市)</td>
                            <td>2013/12/31 16:11:35</td>
                            <td>5 項</td>
                            <td>$ 37,431</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="warning"></div>
                                <a href="#">OD20131231-0318</a>
                            </td>
                            <td>張怡秀 (新北市)</td>
                            <td>2013/12/31 11:45:58</td>
                            <td>2 項</td>
                            <td>$ 1,990</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="success"></div>
                                <a href="#">OD20131231-0317</a>
                            </td>
                            <td>林志豪 (嘉義市)</td>
                            <td>2013/12/31 10:41:18</td>
                            <td>1 項</td>
                            <td>$ 990</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="info"></div>
                                <a href="#">OD20131231-0316</a>
                            </td>
                            <td>ViVi (台北市)</td>
                            <td>2013/12/31 10:35:30</td>
                            <td>2 項</td>
                            <td>$ 2,590</td>
                        </tr>
                        <tr>
                            <td class="highlight">
                                <div class="important"></div>
                                <a href="#">OD20131231-0316</a>
                            </td>
                            <td>楊溢伶 (新竹市)</td>
                            <td>2013/12/31 10:15:22</td>
                            <td>1 項</td>
                            <td>$ 1,190</td>
                        </tr>
                    </tbody>
                    <tfoot>
                        <tr>
                            <td colspan="5" style="font-size:10px;padding-left:8px">
                                <a href="#" class="btn mini blue-stripe">查看更多...</a>
                            </td>
                        </tr>
                    </tfoot>
                </table>
            </div>
        </div>
        <!-- END SAMPLE TABLE PORTLET-->
    </div>
</div>


<div class="row-fluid">
    <div class="span6">
        <!-- BEGIN PORTLET-->
        <div class="portlet solid bordered light-grey">
            <div class="portlet-title">
                <div class="caption"><i class="icon-bar-chart"></i>登入次數 & 訂單數量分析圖 <small>(月統計)</small></div>
                <div class="tools">
                    <div class="btn-group pull-right" data-toggle="buttons-radio">
                        <span class="btn mini" style="color:#fff; background-color:rgba(147, 147, 147, 0.84)">登入次數</span>
                        <span class="btn mini" style="color:#fff; background-color:rgba(100, 186, 248, 0.8)">訂單數量</span>
                    </div>
                </div>
            </div>
            <div class="portlet-body">
                <canvas id="loginAndOrderChart" height="450" width="600"></canvas>
            </div>
        </div>
        <!-- END PORTLET-->
    </div>

<script>
    $(document).ready(function () {

        // 登入次數與訂單次數分析圖
        var lineChartData = {
            labels: ["January", "February", "March", "April", "May", "June", "July"],
            datasets: [
				{
				    fillColor: "rgba(220,220,220,0.5)",
				    strokeColor: "rgba(220,220,220,1)",
				    pointColor: "rgba(220,220,220,1)",
				    pointStrokeColor: "#fff",
				    data: [65, 59, 90, 81, 56, 55, 40]
				},
				{
				    fillColor: "rgba(151,187,205,0.5)",
				    strokeColor: "rgba(151,187,205,1)",
				    pointColor: "rgba(151,187,205,1)",
				    pointStrokeColor: "#fff",
				    data: [28, 48, 40, 19, 66, 27, 95]
				}
            ]

        }
        var chart01 = new Chart(document.getElementById("loginAndOrderChart").getContext("2d")).Line(lineChartData);
    });
</script>



    <div class="span6">
        <!-- BEGIN PORTLET-->
        <div class="portlet solid bordered light-grey">
            <div class="portlet-title">
                <div class="caption"><i class="icon-bar-chart"></i>熱門瀏覽商品 <small>(日統計)</small></div>
                <!--div class="tools">
                    <div class="btn-group pull-right" data-toggle="buttons-radio">
                        <span class="btn mini" style="color:#fff; background-color:rgba(147, 147, 147, 0.84)">登入次數</span>
                        <span class="btn mini" style="color:#fff; background-color:rgba(100, 186, 248, 0.8)">訂單數量</span>
                    </div>
                </div -->
            </div>
            <div class="portlet-body">
                <div id="topProductChart" style="height:180px; width:600px"></div>
            </div>
        </div>
        <!-- END PORTLET-->
        <!-- BEGIN PORTLET-->
        <div class="portlet solid bordered light-grey">
            <div class="portlet-title">
                <div class="caption"><i class="icon-bar-chart"></i>熱門訂購商品 <small>(日統計)</small></div>
                <!--div class="tools">
                <div class="btn-group pull-right" data-toggle="buttons-radio">
                    <span class="btn mini" style="color:#fff; background-color:rgba(147, 147, 147, 0.84)">登入次數</span>
                    <span class="btn mini" style="color:#fff; background-color:rgba(100, 186, 248, 0.8)">訂單數量</span>
                </div>
            </div -->
            </div>
            <div class="portlet-body">
                <div id="topSaleProductChart" style="height:180px; width:600px"></div>
            </div>
        </div>
        <!-- END PORTLET-->
    </div>
</div>

<script>
    var myPie = new Chartkick.PieChart("topProductChart", [["羽絨外套", 57], ["羊毛針織衫", 42], ["發熱內搭衣", 37], ["牛角排釦外套", 29]], { "library": { "backgroundColor": "#fafafa" } });
    new Chartkick.BarChart("topSaleProductChart",
        [["發熱內搭衣", 128],
         ["口袋圓領衫", 67],
         ["木釦開襟圓領衫", 59],
         ["純色高領", 51],
         ["特級鵝絨背心", 35]], { "library": { "backgroundColor": "#fafafa" } });
</script>