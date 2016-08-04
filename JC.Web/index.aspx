<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.index" %>

<%@ Register Src="~/ascx/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="~/ascx/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/ascx/static.ascx" TagPrefix="uc1" TagName="static" %>
<%@ Register Src="~/ascx/meta.ascx" TagPrefix="uc1" TagName="meta" %>
<%@ Register Src="~/ascx/problem.ascx" TagPrefix="uc1" TagName="problem" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <uc1:meta runat="server" ID="meta" />
    <title><%=msite.title %></title>
    <meta name="keywords" content="<%=msite.keywords %>" />
    <meta name="description" content="<%=msite.description %>" />
    <uc1:static runat="server" ID="static1" />
    <script>
        $(function () {
            $('#slides').slidesjs({
                play: {
                    active: false,
                    effect: "slide",
                    interval: 5000,
                    auto: true,
                    swap: false,
                    pauseOnHover: false,
                }
            });

            var news = $('#j_news');
            news.owlCarousel({
                loop: true,
                nav: true,
                margin: 8,
                items: 3
            });
        });
    </script>
</head>
<body>

    <div class="header">
        <uc1:header runat="server" ID="header1" />
    </div>
    <div class="banner-wrap">
        <div id="slides">
            <%--//txt，link，picsrc，target，orderby--%>
             <%  if(mpost!=null&&!string.IsNullOrEmpty(mpost.piclist)) { %>
            <% var plist = mpost.piclist.Split('|'); for (int i = 0; i < plist.Length; i++){%>
            <a class="banner" href="<%=plist[i].Split(',')[1] %>" target="<%=plist[i].Split(',')[3] %>" style="background-image:url(<%=plist[i].Split(',')[2] %>)" ><%=plist[i].Split(',')[0] %></a>
            <%  } %>
             <%  } %>
        </div>
        <div class="banner-bottom">
            <ul class="banner-ul w">
                <li>
                    <a href="/product/">
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h3.jpg" /></div>
                    <div class="text">地板/瓷砖与地暖二合一<br />
                        新房采暖，一步到位   </div>
                    <div class="summarize"><span>中小户型新房装地暖</span></div>
                        </a>
                </li>
                <li>
                    <a href="/product/">
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h4.jpg" /></div>
                    <div class="text">单个房间也可安装<br />
                        当天装，当天用   </div>
                    <div class="summarize"><span>单间局部安装地暖</span></div>
                        </a>
                </li>
                <li>
                    <a href="/product/">
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h5.jpg" /></div>
                    <div class="text">可在原有地面加铺<br />
                        不占层高，施工简单   </div>
                    <div class="summarize"><span>已装修房加装地暖</span></div>
                        </a>
                </li>
            </ul>
        </div>
        <div class="banner-img">
            <div>
                <img class="block" src="/content/dist/img/h7.jpg" height="860" />
            </div>
                <ul class="fix">
                    <li>
                        <a href="/product/convenient">
                            <div class="icon" style="background-image: url(/content/dist/img/h65.png);"></div>
                            <div class="font">
                                安装便捷
                                    <br />
                                结构简单，不占层高
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href="/product/fast">
                            <div class="icon" style="background-image: url(/content/dist/img/h66.png);"></div>
                            <div class="font">
                                即开即用
                                    <br />
                                15分钟，快速升温
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href="/product/energy">
                            <div class="icon" style="background-image: url(/content/dist/img/h67.png);"></div>
                            <div class="font">
                                高效省电
                                    <br />
                                分时分区，无空置能耗
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href="/product/safety">
                            <div class="icon" style="background-image: url(/content/dist/img/h68.png);"></div>
                            <div class="font">
                                安全环保
                                    <br />
                                无漏电、辐射危险
                            </div>
                        </a>
                    </li>
                    <li>
                        <a href="/product/durable">
                            <div class="icon" style="background-image: url(/content/dist/img/h69.png);"></div>
                            <div class="font">
                                超久耐用
                                    <br />
                                30年保修，无需维护
                            </div>
                        </a>
                    </li>
                </ul>
        </div>
    </div>
    <div class="news w">
        <div class="news-head fix">
            <h3>新闻中心</h3>
        </div>
        <div class="news-list">
            <ul id="j_news">
                <%for (int i = 0; i < mposts.Count; i++) {%>
                  <li>
                    <div class="icon"><a href="/news/show?id=<%=mposts[i].id %>"><img src="<%=mposts[i].pic %>" /></a></div>
                    <div class="box">
                        <div class="title"><a href="/news/show?id=<%=mposts[i].id %>"><%=mposts[i].title %></a></div>
                        <div class="text"><%=mposts[i].description %></div>
                    </div>
                    <div class="record"><i><%=mposts[i].postdate.Value.Day %></i><em><%=mposts[i].postdate.Value.Year %>.<%=mposts[i].postdate.Value.Month %></em></div>
                </li>
                  <%  } %>
              
            </ul>
        </div>
        <div class="more"><a href="/news/" >更多新闻</a></div>
    </div>
    <uc1:problem runat="server" ID="problem" />
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
