<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="ad.ascx.cs" Inherits="JC.Web.ascx.ad" %>
<div class="sidebar-right">
    <div class="icon">
        <%--//txt，link，picsrc，target，orderby--%>
        <% var plist = mpost.piclist.Split('|'); for (int i = 0; i < plist.Length; i++)
            {%>
        <a class="block" href="<%=plist[i].Split(',')[1] %>" target="<%=plist[i].Split(',')[3] %>"><img class="block g10" alt="<%=plist[i].Split(',')[0] %>" src="<%=plist[i].Split(',')[2] %>" /></a>
        <%  } %>
    </div>
</div>
