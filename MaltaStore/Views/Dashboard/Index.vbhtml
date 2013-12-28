@Code
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
                                <a href="#">OD20131231-0319</a>
                            </td>
                            <td>張怡秀 (新北市)</td>
                            <td>2013/12/31 11:45:58</td>
                            <td>2 項</td>
                            <td>$ 1,990</td>
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