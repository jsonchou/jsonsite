<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.huifang.index" %>
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
    <title><%=mmenu.title %>_<%=msite.title %></title>
     <meta name="keywords" content="<%=mmenu.keywords %>" />
    <meta name="description" content="<%=mmenu.description %>" />
    <uc1:static runat="server" ID="static1" />
</head>
<body>
    <div class="header">
        <uc1:header runat="server" ID="header1" />
        <uc1:menu runat="server" id="menu1" />
    </div>
    <div class="banner-wrap">
        <div class="banner">
            <div class="icon">
                <img class="block" src="/content/dist/img/h98.jpg" />
            </div>
        </div>
    </div>
    <div class="news-cont">
        <div class="crumbs fix">
            <div class="crumbs-box">
                <a href="/">首页</a> > <span>用户回访</span>
            </div>
             <div class="crumbs-right">
                <%for (int i = 0; i < menuLevel2List.Count; i++) { %>
                <a href="/<%=tbs %>/?tag=<%=menuLevel2List[i] %>"><span  class="<%=((Server.UrlDecode(Request.QueryString["tag"])==menuLevel2List[i])?"on":"") %>" ></span><%=menuLevel2List[i] %></a>
                <%  } %>
            </div>
        </div>
        <div class="news-center case">
            <ul>
                <%for (int i = 0; i < mposts.Count; i++)
                    {%>
                <li class="fix">
                    <div class="icon">
                        <a href="/huifang/show?id=<%=mposts[i].id %>">
                            <div>
                                <img class="block" src="<%=mposts[i].pic %>" />
                            </div>
                            <div class="icon-text">
                                <p><%=mposts[i].ext7 %></p>
                            </div>
                        </a>
                    </div>
                    <div class="text">
                        <div class="title"><a href="/huifang/show?id=<%=mposts[i].id %>"><%=mposts[i].title %></a></div>
                        <p>
                            <label class="b">安装日期：</label><%=mposts[i].ext1 %> &nbsp;&nbsp;&nbsp;&nbsp;| &nbsp;<label class="b">使用费用：</label><%=mposts[i].ext2 %>
                        </p>
                        <p>
                            <label class="b">房型：</label><%=mposts[i].ext3 %> &nbsp;&nbsp;&nbsp;&nbsp;| &nbsp;<label class="b">建筑面积：</label><%=mposts[i].ext4 %>
                        </p>
                        <p>
                            <label class="b">安装面积：</label><%=mposts[i].ext5 %>
                        </p>
                        <p>
                            <label class="b">产品类型：</label><%=mposts[i].ext6 %>
                        </p>

                        <a href="/huifang/show?id=<%=mposts[i].id %>" class="more">查看详细新闻  ></a>
                    </div>
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
</body>
</html>

