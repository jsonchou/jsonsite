<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.solution.index" %>

<%@ Register Src="~/ascx/meta.ascx" TagPrefix="uc1" TagName="meta" %>
<%@ Register Src="~/ascx/static.ascx" TagPrefix="uc1" TagName="static" %>
<%@ Register Src="~/ascx/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/ascx/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <uc1:meta runat="server" ID="meta1" />
    <title><%=mmenu.title %>_<%=msite.title %></title>
    <meta name="keywords" content="<%=mmenu.keywords %>" />
    <meta name="description" content="<%=mmenu.description %>" />
    <uc1:static runat="server" ID="static1" />
    <script>
        $(function () {
            $('.banner-install').find('p').children('a').on('click', function () {
                var o = $(this);
                var index = o.index();
                var family = $('.j_family').offset().top;
                var engineering = $('.j_engineering').offset().top;
                if (index == 0) {
                    $('html').animate({ scrollTop: family }, 500);
                }
                if (index == 1) {
                    $('html').animate({ scrollTop: engineering }, 500);
                }
            });
        })
    </script>
</head>
<body>
    <div class="header">
        <uc1:header runat="server" ID="header1" />
    </div>
    <div class="banner-wrap">
        <div class="banner">
            <div class="icon">
                <img class="block" src="/content/dist/img/h21.jpg" /></div>
            <div class="banner-install tc">
                <p>为您解决多种地暖使用需求</p>
                <p><a class="cup">家庭安装</a> <a class="cup">工程安装</a> </p>
            </div>
        </div>
    </div>
    <div class="example-list">
        <ul>
            <li class="fix j_family li1">
                <div class="icon fl">
                    <img src="/content/dist/img/h12.png" /></div>
                <div class="detail fr">
                    <div class="title">中小户型新房采暖</div>
                    <div class="font"><span class="f72a trademark">惠申<i>TM</i> </span>中小户型地暖，地暖（瓷砖）与地暖二合一，发热快、安装简单。最适合中小户型（建筑150平米以内）的地暖。新房装修，地暖（瓷砖）+地暖一步到位，享受更好的冬季品质生活。</div>
                    <div class="labels"><span>实木复合地板系列</span> <span>强化复合地板系列</span> <span>瓷砖系列</span></div>
                    <div class="detail-list">
                        <ul class="fix">
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h32.png" /></div>
                                <div class="text">
                                    <h6>地板（瓷砖）+地暖二合一</h6>
                                    <p>花一份钱买两样，性价比更高</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h18.png" /></div>
                                <div class="text">
                                    <h6>安装快捷</h6>
                                    <p>无需大兴土木，不占层高</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h27.png" /></div>
                                <div class="text">
                                    <h6>发热快</h6>
                                    <p>转化效率高，即开即热</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h24.png" /></div>
                                <div class="text">
                                    <h6>节能省电</h6>
                                    <p>分时分区控制，没有空置能耗</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h23.png" /></div>
                                <div class="text">
                                    <h6>安全环保</h6>
                                    <p>没有漏电、辐射、甲醛危害</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h33.png" /></div>
                                <div class="text">
                                    <h6>智能家居</h6>
                                    <p>智能温控器，远程控制室内温度</p>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </li>
            <li class="fix li2">
                <div class="icon fr">
                    <img src="/content/dist/img/h13.png" /></div>
                <div class="detail fl">
                    <div class="title">单间、局部安装地暖</div>
                    <div class="font"><span class="f72a trademark">惠申<i>TM</i> </span>中小户型地暖，结构简单，铺装与普通地板一样，铺装面积、位置自由设定。没有传统水暖的复杂配件，安装费用更低。</div>
                    <div class="labels"><span>实木复合地板系列</span> <span>强化复合地板系列</span> <span>瓷砖系列</span></div>
                    <div class="detail-list">
                        <ul class="fix">
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h29.png" /></div>
                                <div class="text">
                                    <h6>结构简单</h6>
                                    <p>铺装面积自由设定,一个房间也可装</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h18.png" /></div>
                                <div class="text">
                                    <h6>安装快捷</h6>
                                    <p>单个房间一天就可装好</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h31.png" /></div>
                                <div class="text">
                                    <h6>费用更低</h6>
                                    <p>按平方计费，单个房间低至4000元</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h21.png" /></div>
                                <div class="text">
                                    <h6>施工方便</h6>
                                    <p>无需大兴土木，不用开墙破洞</p>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </li>
            <li class="fix li3" style="margin-bottom:80px;">
                <div class="icon fl">
                    <img src="/content/dist/img/h14.png" /></div>
                <div class="detail fr">
                    <div class="title">已装修房（老房）加装地暖</div>
                    <div class="font"><span class="f72a trademark">惠申<i>TM</i> </span>对原有房型结构、承重、层高没有限制。铺装简单，不占层高，安装速度快。可在原有地面材料上直接铺装。是老房采暖改造的唯一选择。</div>
                    <div class="labels"><span>实木复合地板系列</span> <span>强化复合地板系列</span> <span>瓷砖系列</span></div>
                    <div class="detail-list">
                        <ul class="fix">
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h18.png" /></div>
                                <div class="text">
                                    <h6>安装快捷</h6>
                                    <p>铺装和普通地板一行便捷，当天装当天用</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h19.png" /></div>
                                <div class="text">
                                    <h6>原地铺装</h6>
                                    <p>可在原有地面材料上直接铺装</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h20.png" /></div>
                                <div class="text">
                                    <h6>不占层高</h6>
                                    <p>厚度只有1.5厘米，不影响承重，不占层高</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h21.png" /></div>
                                <div class="text">
                                    <h6>施工方便</h6>
                                    <p>无需大兴土木，不用开墙破洞</p>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </li>
            <li class="fix j_engineering li4">
                <div class="icon fr">
                    <img src="/content/dist/img/h15.png" /></div>
                <div class="detail fl">
                    <div class="title">精装房 / 样板房 / 酒店客房</div>
                    <div class="font"><span class="f72a trademark">惠申<i>TM</i> </span>中小户型地暖，只装地板（瓷砖），就有地暖。安装简单快速，初装成本低。日常使用无需维护，30年保修，使用成本更低。</div>
                    <div class="labels"><span>实木复合地板系列</span> <span>强化复合地板系列</span> <span>瓷砖系列</span></div>
                    <div class="detail-list">
                        <ul class="fix">
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h22.png" /></div>
                                <div class="text">
                                    <h6>初装成本低</h6>
                                    <p>只装地板（瓷砖），就有地暖</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h18.png" /></div>
                                <div class="text">
                                    <h6>安装快捷</h6>
                                    <p>无需大兴土木，不占层高，安装速度快</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h23.png" /></div>
                                <div class="text">
                                    <h6>安全环保</h6>
                                    <p>没有漏电、辐射、甲醛危害</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h24.png" /></div>
                                <div class="text">
                                    <h6>节能省电</h6>
                                    <p>发热快，分时分区控制，没有空置能耗</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h25.png" /></div>
                                <div class="text">
                                    <h6>长久耐用</h6>
                                    <p>30年保修承诺，日常使用无需维护</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h26.png" /></div>
                                <div class="text">
                                    <h6>维修简单</h6>
                                    <p>并连技术，单片故障不影响整体，更换简单</p>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </li>
            <li class="fix li5">
                <div class="icon fl">
                    <img src="/content/dist/img/h16.png" /></div>
                <div class="detail fr">
                    <div class="title">舞蹈房 / 瑜伽房</div>
                    <div class="font"><span class="f72a trademark">惠申<i>TM</i> </span>分时分区控制，发热快，即开即热，使用成本低。热量由地面均匀向上散发，人体直接接触更舒适。</div>
                    <div class="labels"><span>强化复合地板系列</span> <span>瓷砖系列</span></div>
                    <div class="detail-list">
                        <ul class="fix">
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h22.png" /></div>
                                <div class="text">
                                    <h6>初装成本低</h6>
                                    <p>只装地板（瓷砖），就有地暖，安装简单</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h27.png" /></div>
                                <div class="text">
                                    <h6>发热快</h6>
                                    <p>转化效率高，即开即热</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h23.png" /></div>
                                <div class="text">
                                    <h6>安全环保</h6>
                                    <p>没有漏电、辐射、甲醛危害</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h24.png" /></div>
                                <div class="text">
                                    <h6>节能省电</h6>
                                    <p>分时分区控制，没有空置能耗</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h25.png" /></div>
                                <div class="text">
                                    <h6>长久耐用</h6>
                                    <p>30年保修承诺，日常使用无需维护</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h28.png" /></div>
                                <div class="text">
                                    <h6>重复使用</h6>
                                    <p>使用寿命长，可拆除重新使用</p>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </li>
            <li class="fix li6">
                <div class="icon fr">
                    <img src="/content/dist/img/h15.png" /></div>
                <div class="detail fl">
                    <div class="title">幼儿园 / 养老院 / 寺庙</div>
                    <div class="font"><span class="f72a trademark">惠申<i>TM</i> </span>可每个房间单独安装，单独控制，初装成本低，使用维护简单，后期使用费用低。冬季采暖更安静、更舒适。</div>
                    <div class="labels"><span>强化复合地板系列</span> <span>瓷砖系列</span></div>
                    <div class="detail-list">
                        <ul class="fix">
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h22.png" /></div>
                                <div class="text">
                                    <h6>初装成本低</h6>
                                    <p>只装地板（瓷砖），就有地暖</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h29.png" /></div>
                                <div class="text">
                                    <h6>单间可装</h6>
                                    <p>结构简单，铺装面积自由设定,单间也可装</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h23.png" /></div>
                                <div class="text">
                                    <h6>安全环保</h6>
                                    <p>没有漏电、辐射、甲醛危害</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h24.png" /></div>
                                <div class="text">
                                    <h6>节能省电</h6>
                                    <p>发热快，分时分区控制，没有空置能耗</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h25.png" /></div>
                                <div class="text">
                                    <h6>长久耐用</h6>
                                    <p>30年保修承诺，日常使用无需维护</p>
                                </div>
                            </li>
                            <li>
                                <div class="smallIcon">
                                    <img src="/content/dist/img/h30.png" /></div>
                                <div class="text">
                                    <h6>体感舒适</h6>
                                    <p>热量由下而上均匀散发，更符合人体舒适度</p>
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
            </li>
        </ul>
    </div>
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
