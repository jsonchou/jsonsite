<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.cases.index" %>
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
    <div class="user-case">
        <div class="crumbs fix">
            <div class="crumbs-box">
                <a href="/">首页</a> > <span>用户案例</span>
            </div>
            <div class="crumbs-right">
                <%for (int i = 0; i < menuLevel2List.Count; i++) { %>
                <a href="/<%=tbs %>/?tag=<%=menuLevel2List[i] %>"><span  class="<%=((Server.UrlDecode(Request.QueryString["tag"])==menuLevel2List[i])?"on":"") %>" ></span><%=menuLevel2List[i] %></a>
                <%  } %>
            </div>
        </div>
        <div class="case-ul">
            <ul class="fix">
                <%for (int i = 0; i < mposts.Count; i++)
                  {%>
                <li>
                    <a href="/cases/show?id=<%=mposts[i].id %>">
                        <div class="icon">
                            <img class="block" src="<%=mposts[i].pic %>" /></div>
                        <div class="text">
                            <div class="title"><%=mposts[i].title %></div>
                            <p>房型：<%=mposts[i].ext1 %>   |   建筑面积：<%=mposts[i].ext2 %></p>
                            <p>安装面积：<%=mposts[i].ext3 %></p>
                            <p>产品类型：<%=mposts[i].ext4 %></p>
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
</body>
</html>
