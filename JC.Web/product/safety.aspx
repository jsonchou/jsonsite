<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="safety.aspx.cs" Inherits="JC.Web.product.safety" %>

<%@ Register Src="~/ascx/meta.ascx" TagPrefix="uc1" TagName="meta" %>
<%@ Register Src="~/ascx/static.ascx" TagPrefix="uc1" TagName="static" %>
<%@ Register Src="~/ascx/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/ascx/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="menu.ascx" TagPrefix="uc1" TagName="menu" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <uc1:meta runat="server" ID="meta1" />
    <title><%=mmenu.title %>_<%=msite.title %></title>
    <meta name="keywords" content="<%=mmenu.keywords %>" />
    <meta name="description" content="<%=mmenu.description %>" />
    <uc1:static runat="server" ID="static1" />
</head>
<body>
    <div class="header">
        <uc1:header runat="server" ID="header1" />
        <uc1:menu runat="server" ID="menu1" />
    </div>
    <div class="banner-wrap" style="background: url(/content/dist/img/h1.jpg) repeat 0 0;">
        <div class="banner">
            <div class="icon">
                <img class="block" src="/content/dist/img/h58.png" /></div>
        </div>
    </div>
    <div class="huanbao">
        <div class="fix">
            <div class="text fl">
                <div class="title">密封防水</div>
                <div class="font"><span class="f72a trademark">惠申<i>TM</i></span> 中小户型地暖的发热系统置于地板（瓷砖）内部，少量渗水并不会接触到发热系统。同时，发热系统由硅胶密封包裹，防水耐高温，可长期有效隔绝与外界接触。</div>
            </div>
            <div class="icon fr on">
                <img src="/content/dist/img/h59.png" /></div>
        </div>
        <div class="fix">
            <div class="icon fl" style="margin-right: 95px;">
                <img src="/content/dist/img/h60.png" /></div>
            <div class="text fl" style="margin-top: 115px;">
                <div class="title">漏电保护</div>
                <div class="font"><span class="f72a trademark">惠申<i>TM</i></span> 中小户型地暖带有漏电保护功能，一发生漏电风险，立刻断开，确保安全。</div>
            </div>
        </div>
        <div class="huanbao-banner" style="background: #c7222a; padding: 50px 0 70px;">
            <div class="fix fff">
                <div class="text fl">
                    <div class="title" style="color: #fff;">无辐射危害</div>
                    <div class="font">
                        <span class="trademark">惠申<i>TM</i></span>中小户型地暖使用的是35HZ的家用电，所产生的电磁辐射非常微弱，对人体没有任何影响。
                            测试值均低于手机蓝牙，电脑机箱，路由器等家用电器的辐射值。
                    </div>
                </div>
                <div class="icon fr">
                    <div>
                        <img src="/content/dist/img/h71.png" /></div>
                    <p class="tc icon-font">家用电:35Hz</p>
                </div>
            </div>
        </div>
        <div class="huanbao-banner">
            <div class="fix">
                <div class="icon fl">
                    <div>
                        <img src="/content/dist/img/h72.png" /></div>
                </div>
                <div class="text fr" style="width: 515px">
                    <div class="title">无甲醛危害</div>
                    <div class="font">
                        <span class="trademark f72a">惠申<i>TM</i></span>中小户型地暖，选用优质基材，甲醛释放量均远优于国家标准。<br />
                        <span class="trademark f72a">惠申<i>TM</i></span>中小户型地暖的发热温度最高不超过35℃，因此使用中不会加速甲醛的挥发。
                    </div>
                </div>
            </div>
        </div>
        <div class="huanbao-banner" style="background: url(/content/dist/img/h135.jpg) no-repeat center center; height: 442px; padding: 0;background-size:100% 100%;">
            <div class="fix" style="">
                <div class="text fl fff">
                    <div class="title" style="color: #fff;">35℃安全采暖</div>
                    <div class="font">
                        <span class="trademark">惠申<i>TM</i></span>中小户型地暖的最高设定温度不超过35℃，等同于地板（瓷砖）在夏天阳光直晒时温度。杜绝了皮肤长时间直接接触地板（瓷砖）表面时带来的低温烫伤，也不会加速甲醛挥发。
                    </div>
                </div>
            </div>
        </div>
    </div>
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
