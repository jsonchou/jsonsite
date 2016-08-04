<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="durable.aspx.cs" Inherits="JC.Web.product.durable" %>
<%@ Register Src="~/ascx/meta.ascx" TagPrefix="uc1" TagName="meta" %>
<%@ Register Src="~/ascx/static.ascx" TagPrefix="uc1" TagName="static" %>
<%@ Register Src="~/ascx/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/ascx/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="menu.ascx" TagPrefix="uc1" TagName="menu" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <uc1:meta runat="server" id="meta1" />
    <title><%=mmenu.title %>_<%=msite.title %></title>
    <meta name="keywords" content="<%=mmenu.keywords %>" />
    <meta name="description" content="<%=mmenu.description %>" />
    <uc1:static runat="server" id="static1" />
</head>
<body>
        <div class="header">
            <uc1:header runat="server" id="header1" />
            <uc1:menu runat="server" id="menu1" />
        </div>
           <div class="banner-wrap">
            <div class="banner">
                <div class="icon"><img class="block" src="/content/dist/img/h121.jpg" /></div>
            </div>
        </div>
        <div class="durable-cont">
            <div class="box1">
                <div class="wrap">
                    <div class="icon"><img src="/content/dist/img/h55.png" /></div>
                    <div class="text">
                        <div class="title">高品质基材</div>
                        <div class="font"><span class="f72a trademark">惠申<i>TM</i></span> 中小户型地暖，选用高品质基材。比起传统地板（瓷砖）更适用于地暖环境。<br />长期使用不变形、不起翘。耐磨、环保系数优于国家标准，更环保、更耐用。</div>
                    </div>
                </div>
            </div>
            <div class="box2">
                <div class="icon"><img class="block" src="/content/dist/img/h122.jpg" /></div>
                <div class="wrap">
                    <div class="text">
                        <div class="title">无需维护</div>
                        <div class="font"><span class="trademark">惠申<i>TM</i></span>中小户型地暖，结构简单，无需保养和配件的更换，无需维护。<br />日常使用与普通地板（瓷砖）无异。</div>
                    </div>
                </div>
            </div>
            <div class="box3">
                <div class="wrap">
                    <div class="icon"><img src="/content/dist/img/h56.png" /></div>
                    <div class="text">
                        <div class="title">维修简单</div>
                        <div class="font"><span class="f72a trademark">惠申<i>TM</i></span> 中小户型地暖采用并联技术，单块故障不影响整体使用。<br />维修方便，只需更换故障产品即可，施工简单，无需大兴土木。</div>
                    </div>
                </div>
            </div>
            <div class="box4">
                <div class="icon"><img class="block" src="/content/dist/img/h123.jpg" /></div>
                <div class="wrap">
                    <div class="text">
                        <div class="title">可重复使用</div>
                        <div class="font"><span class="trademark">惠申<i>TM</i></span>中小户型地暖，地暖（瓷砖）+地暖合二为一，发热系统嵌入于内部，<br />拆装地板（瓷砖）不会破坏发热系统。因此可反复拆装使用。</div>
                    </div>
                </div>
            </div>
        </div>
        <uc1:footer runat="server" ID="footer1" />
</body>
</html>
