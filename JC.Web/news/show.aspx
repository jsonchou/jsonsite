<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="show.aspx.cs" Inherits="JC.Web.news.show" %>

<%@ Register Src="~/ascx/meta.ascx" TagPrefix="uc1" TagName="meta" %>
<%@ Register Src="~/ascx/static.ascx" TagPrefix="uc1" TagName="static" %>
<%@ Register Src="~/ascx/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/ascx/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/ascx/ad.ascx" TagPrefix="uc1" TagName="ad" %>

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
        <div class="nav-bd" style="height:30px;"></div>
    </div>
    <div class="news-cont">
        <div class="crumbs fix">
            <div class="crumbs-box">
                <a href="/">首页</a> > <span>新闻中心</span>
            </div>
            <div class="crumbs-right">
                <a class="go-back cup" href="/<%=tbs %>/">
                    <img class="vm" src="/content/dist/img/h39.png" />
                    返回上页</a>
            </div>
        </div>
        <div class="details news-details fix">
            <div class="article">
                <div class="title"><%=mpost.title %></div>
                <div class="tiem"><%=mpost.postdate.Value.ToString("yyyy-MM-dd") %></div>
                <div class="share vm" style="margin-bottom: 50px;">
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
                <div class="paragraph">
                    <%=Server.HtmlDecode(mpost.content) %>
                </div>
            </div>
            <uc1:ad runat="server" ID="ad1" />
        </div>
    </div>
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>

