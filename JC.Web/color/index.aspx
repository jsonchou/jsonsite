<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.color.index" %>

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
    <div class="productColor on">
        <ul>
            <li>
                <a href="/color/shimu">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h34.jpg" /></div>
                <div class="box tc white">
                    <div class="title">实木复合系列</div>
                    <div class="font"><span class="f72a trademark">惠申<i>TM</i> </span>实木复合系列，更贴近自然，脚感更舒适，适用于家庭用户。</div>
                    <div class="labels">
                        <label class="on">客厅</label><label class="on">饭厅</label><label class="on">卧室</label><label class="on">书房</label><label>厨房</label></div>
                </div>
                    </a>
            </li>
            <li>
                <a href="/color/qianghua">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h35.jpg" /></div>
                <div class="box tc white">
                    <div class="title">强化复合系列   </div>
                    <div class="font"><span class="trademark">惠申<i>TM</i> </span>强化复合系列，耐磨指数更高，除了家庭用户，也适用于工装用户</div>
                    <div class="labels">
                        <label class="on">客厅</label><label class="on">饭厅</label><label class="on">卧室</label><label class="on">书房</label><label>厨房</label></div>
                </div>
                    </a>
            </li>
        </ul>
    </div>
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
