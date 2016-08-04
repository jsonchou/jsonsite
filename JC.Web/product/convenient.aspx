<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="convenient.aspx.cs" Inherits="JC.Web.product.convenient" %>

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
                <img class="block" src="/content/dist/img/h124.jpg" />
            </div>
        </div>
    </div>
    <div class="express-setup">
        <div class="box1">
            <div class="text">
                <div class="title">不占层高</div>
                <div class="font"><span class="f72a trademark">惠申<i>TM</i></span>中小户型地暖外观与传统地板（瓷砖）一样，不占用额外层高，对房屋承重也没有影响，是老房加装地暖的唯一选择。</div>
            </div>
            <div class="graphic">
                <img class="block" src="/content/dist/img/h125.jpg" />
            </div>
        </div>
        <div class="no-hole identical">
            <div class="icon">
                <img class="block" src="/content/dist/img/h127.jpg" />
            </div>
            <div class="text">
                <div class="text-box">
                    <div class="title">不用开墙破洞，不用大兴土木</div>
                    <div class="font">
                        <span class="f72a trademark">惠申<i>TM</i></span> 中小户型地暖，安装与传统地板（瓷砖）一样，施工简单快速。<br />
                        无需像水暖一样需要开墙破洞、回填水泥等大兴土木的施工步骤，同时也杜绝了繁琐施工中出现质量问题的几率。
                    </div>
                </div>
            </div>
        </div>
        <div class="no-hole-list identical">
            <div class="icon">
                <img class="block" src="/content/dist/img/h128.jpg" />
            </div>
            <div class="text">
                <div class="fix">
                    <div class="li">
                        <div class="pic">
                            <img class="block" src="/content/dist/img/h79.png" /></div>
                        <p>无需开墙破洞</p>
                    </div>
                    <div class="li">
                        <div class="pic">
                            <img class="block" src="/content/dist/img/h79.png" /></div>
                        <p>没有复杂结构</p>
                    </div>
                    <div class="li">
                        <div class="pic">
                            <img class="block" src="/content/dist/img/h79.png" /></div>
                        <p>无需回填水泥</p>
                    </div>
                    <div class="li">
                        <div class="pic">
                            <img class="block" src="/content/dist/img/h79.png" /></div>
                        <p>无后期维护担心</p>
                    </div>
                </div>
            </div>
        </div>
        <div class="box2 tc">
            <div class="title">可在原有地面材料上铺装</div>
            <div class="text">
                <span class="f72a trademark">惠申<i>TM</i></span>中小户型地暖结构、铺装简单，可在不拆除原有地板（瓷砖）的情况下直接家装。<br />
                方便简单，将对原有生活的影响减至最低，非常适用于已装修的用户加装地暖。
            </div>
        </div>
        <div class="icon" style="margin-top: -20px;">
            <img class="block" src="/content/dist/img/h57.png" />
        </div>
        <div class="box3">
            <div class="text tc">
                <div class="title">安装面积任意设定</div>
                <div class="font">
                    <span class="f72a trademark">惠申<i>TM</i></span>中小户型地暖铺装与普通地板（瓷砖）一样方便，无论是单个房间还是局部铺设都方便快捷。<br />
                    并且可根据用户家装需求，在一些传统水暖无法铺设的位置加装地暖。
                </div>
            </div>
        </div>
        <div class="ovh">
            <ul class="ul-box fix">
                <li>
                    <a href="/product/">
                        <div class="icon">
                            <img class="block" src="/content/dist/img/h129.jpg" />
                        </div>
                        <input type="button" value="特殊造型" /></a>
                </li>
                <li>
                    <a href="/product/">
                        <div class="icon">
                            <img class="block" src="/content/dist/img/h130.jpg" />
                        </div>
                        <input type="button" value="楼梯" />
                    </a>
                </li>
                <li>
                    <a href="/product/">
                        <div class="icon">
                            <img class="block" src="/content/dist/img/h131.jpg" />
                        </div>
                        <input type="button" value="单间" />
                    </a>
                </li>
                <li>
                    <a href="/product/">
                        <div class="icon">
                            <img class="block" src="/content/dist/img/h132.jpg" />
                        </div>
                        <input type="button" value="飘窗" />
                    </a>
                </li>
            </ul>
        </div>
    </div>
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
