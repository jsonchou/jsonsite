<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="header.ascx.cs" Inherits="JC.Web.ascx.header" %>
<div class="header-t fix">
        <div class="logo fl"><a href="/" title="<%=msite.title %>"><img alt="<%=msite.title %>" src="<%=msite.logo %>" /> </a></div>
        <div class="contactUs fr">
            <div class="t-nav"><a href="/">首页</a>&frasl;<a href="/about/">关于惠申</a>&frasl;<a href="/contact/">联系我们</a></div>
            <div class="Tel"><%=msite.freetele %></div>
        </div>
        <div class="nav fr">
            <ul class="nav-hd">
                <li class="<%=JC.Common.Common.ShowClass("/product/","on") %>"><a href="/product/">产品介绍</a></li>
                <li class="<%=JC.Common.Common.ShowClass("/solution/","on") %>"><a href="/solution/">解决方案</a></li>
                <li class="<%=JC.Common.Common.ShowClass("/cases/","on") %>"><a href="/cases/">用户见证</a></li>
                <li class="<%=JC.Common.Common.ShowClass("/color/","on") %>"><a href="/color/">产品花色</a></li>
            </ul>
        </div>
    </div>