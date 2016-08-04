<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="menu.ascx.cs" Inherits="JC.Web.color.menu" %>
<div class="nav-bd">
    <ul class="fix">
        <%for (int i = 0; i < menulist.Count; i++)
            {%>
        <li class="<%=JC.Common.Common.ShowClassAbs("/"+linktag+"/"+menulist[i].linktag,"on") %>"><a href="/<%=linktag %>/<%=menulist[i].linktag %>"><%=menulist[i].title %></a></li>
        <% } %>
    </ul>
</div>
