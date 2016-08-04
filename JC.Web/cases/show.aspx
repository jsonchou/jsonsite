<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show.aspx.cs" Inherits="JC.Web.cases.show" %>

<%@ Register Src="~/ascx/meta.ascx" TagPrefix="uc1" TagName="meta" %>
<%@ Register Src="~/ascx/static.ascx" TagPrefix="uc1" TagName="static" %>
<%@ Register Src="~/ascx/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/ascx/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/huifang/menu.ascx" TagPrefix="uc1" TagName="menu" %>
<%@ Register Src="~/ascx/problem.ascx" TagPrefix="uc1" TagName="problem" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <uc1:meta runat="server" ID="meta1" />
     <title><%=mpost.title %>_<%=msite.title %></title>
    <meta name="keywords" content="<%=mpost.keywords %>" />
    <meta name="description" content="<%=mpost.description %>" />
    <uc1:static runat="server" ID="static1" />
</head>
<body>
    <div class="header">
        <uc1:header runat="server" ID="header1" />
        <uc1:menu runat="server" ID="menu1" />
    </div>

    <div class="user-case">
        <div class="crumbs fix" style="margin-bottom: 40px;">
            <div class="crumbs-box">
                <a href="/">首页</a> > <a href="/cases/">用户案例</a> > <span><%=mpost.title %></span>
            </div>
            <div class="crumbs-right">
                <%for (int i = 0; i < menuLevel2List.Count; i++) { %>
                <a href="/<%=tbs %>/?tag=<%=menuLevel2List[i] %>"><span  class="<%=((Server.UrlDecode(Request.QueryString["tag"])==menuLevel2List[i])?"on":"") %>" ></span><%=menuLevel2List[i] %></a>
                <%  } %>
            </div>
        </div>
        <div class="case-details">
            <div class="title fix">
                <h3><%=mpost.title %></h3>
                <div class="share vm" style="display: inline-block;">
                    <div class="bdsharebuttonbox">
                        <a href="#" class="bds_more" data-cmd="more"></a><a title="分享到QQ空间" href="#" class="bds_qzone" data-cmd="qzone"></a><a title="分享到新浪微博" href="#" class="bds_tsina" data-cmd="tsina"></a><a title="分享到腾讯微博" href="#" class="bds_tqq" data-cmd="tqq"></a><a title="分享到人人网" href="#" class="bds_renren" data-cmd="renren"></a><a title="分享到微信" href="#" class="bds_weixin" data-cmd="weixin"></a>
                    </div>
                    <script>window._bd_share_config = {
    "common": { "bdSnsKey": {}, "bdText": "<%=mpost.title %>", "bdMini": "2", "bdMiniList": false, "bdPic": "<%=msite.url + mpost.pic %>", "bdStyle": "1", "bdSize": "16" },
    "share": {},
    "image": { "viewList": ["qzone", "tsina", "tqq", "renren", "weixin"], "viewText": "分享到：", "viewSize": "16" },
    "selectShare": { "bdContainerClass": null, "bdSelectMiniList": ["qzone", "tsina", "tqq", "renren", "weixin"] }
}; with (document) 0[(getElementsByTagName('head')[0] || body).appendChild(createElement('script')).src = 'http://bdimg.share.baidu.com/static/api/js/share.js?v=89860593.js?cdnversion=' + ~(-new Date() / 36e5)];</script>
                </div>
                <a href="/<%=tbs %>/" class="go-back">
                    <img src="/content/dist/img/h39.png" class="vm" />
                    返回上页</a>
            </div>
            <div class="text-box fix">
                <div class="left">
                    <dl>
                        <dt>房型:</dt>
                        <dd><%=mpost.ext1 %></dd>
                    </dl>
                    <dl>
                        <dt>建筑面积:</dt>
                        <dd><%=mpost.ext2 %></dd>
                    </dl>
                    <dl>
                        <dt>安装面积:</dt>
                        <dd><%=mpost.ext3 %></dd>
                    </dl>
                    <dl>
                        <dt>产品类型:</dt>
                        <dd><%=mpost.ext4 %></dd>
                    </dl>
                </div>
                <div class="right">
                    <div class="paragraph"><%=Server.HtmlDecode(mpost.content) %></div>
                </div>
            </div>
            <div class="icon-box">
                <ul>
                    <% 
                        var plist = mpost.piclist.Split('|');
                        for (int i = 0; i < plist.Length; i++){%>
                    <li><img class="block" src="<%=plist[i] %>" /></li>
                    <%  } %>
                </ul>
            </div>
        </div>
    </div>

    <uc1:problem runat="server" ID="problem1" />
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
