<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="fast.aspx.cs" Inherits="JC.Web.product.fast" %>

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
    <div class="banner-wrap">
        <div class="banner">
            <div class="icon">
                <img class="block" src="/content/dist/img/h120.jpg" /></div>
        </div>
    </div>
    <div class="rapid-heating">
        <div class="heating-box1 tc">
            <div class="icon">
                <img src="/content/dist/img/h53.png" /></div>
            <div class="text">
                <div class="title">导热路径短</div>
                <div class="font">
                    <span class="f72a trademark">惠申<i>TM</i></span>中小户型地暖，将发热系统置于地板（瓷砖）内部，热源离地表不到1厘米，<br />
                    开启之后，热量可迅速传递至地面，15分钟就可享受温暖！
                </div>
            </div>
        </div>
        <div class="w">
            <div class="heating-box2 tc">
                <div class="icon">
                    <img src="/content/dist/img/h54.png" />
                </div>
                <div class="text">
                    <div class="title">发热纤维电热转化率高</div>
                    <div class="font">
                        <span class="f72a trademark">惠申<i>TM</i></span>所使用的热源纤维，电热转化率可达97%。<br />
                        开启2分钟内，岂可产生稳定热量，结构简单，效率高，更节能省电。
                    </div>
                </div>
            </div>
        </div>
    </div>
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
