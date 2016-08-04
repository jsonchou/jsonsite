<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.qa.index" %>

<%@ Register Src="~/ascx/meta.ascx" TagPrefix="uc1" TagName="meta" %>
<%@ Register Src="~/ascx/static.ascx" TagPrefix="uc1" TagName="static" %>
<%@ Register Src="~/ascx/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/ascx/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/ascx/problem.ascx" TagPrefix="uc1" TagName="problem" %>
<%@ Register Src="~/ascx/ad.ascx" TagPrefix="uc1" TagName="ad" %>

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
    </div>
    <div class="faq-cont">
        <div class="crumbs fix" style="margin-bottom: 35px;">
            <div class="crumbs-box">
                <a href="/">首页</a> > <a href="#">常见问题</a>
            </div>
        </div>
        <div class="faq-box fix">
            <div class="faq-left" id="j_qAbox">
                    <%for (int i = 0; i < mposts.Count; i++)
                        {%>
                <dl>
                    <dt>
                        <div class="title pointer"><%=mposts[i].title %></div>
                    </dt>
                    <dd class="on hide">
                        <div class="text">
                              <div class="title"><%=mposts[i].content %></div>
                        </div>
                    </dd>
                     </dl>
                    <% } %>
               
            </div>
            <uc1:ad runat="server" id="ad1" />
        </div>
    </div>

     <uc1:problem runat="server" id="problem1" />
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
