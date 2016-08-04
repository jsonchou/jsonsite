<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.news.index" %>

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
</head>
<body>

    <asp:Label runat="server" ID="lb_txt" EnableViewState="false"></asp:Label>

    <div class="header">
        <uc1:header runat="server" ID="header1" />
    </div>
    <div class="news-banner" style="background: url(/content/dist/img/h31.jpg) repeat 0 0;">
        <div class="fix" id="j_newsFocus">
            <div class="iocn-left iocn-left-on">
                <div class="icon">
                    <img class="block" style="width:661px;height:403px;" src="<%=postfocus[0].pic %>" /></div>
                <div class="text">
                    <div class="title"><%=postfocus[0].title %></div>
                    <div class="font"><%=postfocus[0].description %></div>
                </div>
            </div>
            <div class="icon-right">
                <ul class="fix">
                    <%for (int i = 0; i < postfocus.Count; i++){%>
                        <li class="<%=(i==1?"on":"") %>">
                            <div class="icon"><img class="block" src="<%=postfocus[i].pic %>" alt="<%=postfocus[i].title %>" /></div>
                            <div class="seo"><%=postfocus[i].description %></div>
                        </li>
                      <%  } %>
                </ul>
            </div>
        </div>
    </div>
    <div class="news-cont">
        <div class="crumbs fix">
            <div class="crumbs-box">
                <a href="/">首页</a> > <span>新闻中心</span>
            </div>
            <div class="crumbs-right">
                <%for (int i = 0; i < menuLevel2List.Count; i++) { %>
                <a href="/<%=tbs %>/?typeid=<%=menuLevel2List[i].id %>"><span  class="<%=((Request.QueryString["typeid"]==menuLevel2List[i].id.ToString())?"on":"") %>" ></span><%=menuLevel2List[i].title %></a>
                <%  } %>
            </div>
        </div>
        <div class="news-center">
            <ul>
                 <%for (int i = 0; i < mposts.Count; i++)
                    {%>
                <li class="fix">
                    <a href="/news/show?id=<%=mposts[i].id %>">
                        <div class="icon">
                            <img class="block" src="<%=mposts[i].pic %>" /></div>
                        <div class="text">
                            <div class="title"><%=mposts[i].title %></div>
                            <div class="tiem"><%=mposts[i].postdate.Value.ToString("yyyy-MM-dd") %></div>
                            <div class="font"><%=mposts[i].description %>...</div>
                            <span class="more">查看详细新闻  ></span>
                        </div>
                    </a>
                </li>
                <% } %>
            </ul>

            <div class="page tc fix" style="margin: 80px 0">
                 <webdiyer:aspnetpager 
                     ID="pager1" 
                     PageSize="10"
                     runat="server" 
                     CurrentPageButtonClass="on"
                     horizontalalign="Center" 
                     PagingButtonSpacing="8px" 
                     onpagechanged="PageChanged"
                     UrlPaging="True" 
                     Width="100%" 
                     ShowNavigationToolTip="false" 
                     UrlPageIndexName="num">
                 </webdiyer:aspnetpager>
            </div>

        </div>
    </div>
    <uc1:footer runat="server" ID="footer1" />

    <script>
        $('.crumbs').find('input:checkbox').on('change', function () {
            var o = $(this);
            var op = o.parent('a');

        })
    </script>

</body>
</html>
