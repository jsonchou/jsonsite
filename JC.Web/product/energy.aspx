<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="energy.aspx.cs" Inherits="JC.Web.product.energy" %>

<%@ Register Src="~/ascx/meta.ascx" TagPrefix="uc1" TagName="meta" %>
<%@ Register Src="~/ascx/static.ascx" TagPrefix="uc1" TagName="static" %>
<%@ Register Src="~/ascx/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/ascx/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="menu.ascx" TagPrefix="uc1" TagName="menu" %>
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
        <uc1:menu runat="server" ID="menu1" />
    </div>
    <div class="banner-wrap">
        <div class="banner">
            <div class="icon">
                <img class="block" src="/content/dist/img/h117.jpg" /></div>
        </div>
    </div>
    <div class="save-cont">
        <ul class="save-ul">
            <li class="fix first">
                <div class="left">
                    <div class="icon" style="top: 50px;"><img class="block" src="/content/dist/img/h49.png" /></div>
                    <div class="li-box">
                        <div class="title">空调（1.5匹）</div>
                        <p>
                            <label>总功率：</label>3千瓦</p>
                        <p>
                            <label>单月用时：</label>8小时/天 × 30天 = 240小时</p>
                        <p>
                            <label>单月耗电：</label>3千瓦 × 240小时 = 720度电</p>
                        <p>
                            <label>单月费用：</label>720度电 × 0.4元/度（平均）= 288元</p>
                    </div>
                </div>
                <div class="right">
                    <h5>使用场景：单间卧室，采暖面积15平方</h5>
                    <div class="li-box">
                        <div class="title">惠申 中小户型地暖</div>
                        <p>
                            <label>总功率：</label>0.15千瓦/平方 × 15平方 = 2.25千瓦</p>
                        <p>
                            <label>使用时间：</label>8小时/天 × 30天 = 240小时</p>
                        <p>
                            <label>总耗电：</label>2.25千瓦 × 240小时 = 540度电</p>
                        <p>
                            <label>单月费用：</label>540度电 × 0.4元/度（平均）= 216元</p>
                    </div>
                </div>
            </li>
        </ul>
        <div class="banner-list identical right">
            <div class="icon">
                <img class="block" src="/content/dist/img/h118.jpg" /></div>
            <div class="text">
                <div class="text-box">
                由于<span class="f72a trademark">惠申<i>TM</i> 中小户型地暖</span> 的热量是均匀的自下而上的散发，无需额外能耗，所有的电都用于电热转化。而空调的热风聚集于房间上方，为了达到设定的温度，必须鼓风将热气强行向下方吹送。因此在实际使用中，<span class="b trademark">惠申<i>TM</i></span>中小户型地暖不但体感更舒适，同时也更省电。
                </div>
            </div>
        </div>
        <ul class="save-ul">
            <li class="fix">
                <div class="left">
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h50.png" /></div>
                    <div class="li-box">
                        <div class="title">传统水暖</div>
                        <p>
                            <label>耗气量：</label>1立方/小时（包含生活热水）</p>
                        <p>
                            <label>单月用时：</label>24小时 × 30天 = 720小时</p>
                        <p>
                            <label>单月耗电：</label>1立方/小时 × 720小时 = 720立方</p>
                        <p>
                            <label>单月费用：</label>720立方 × 2.5元/立方 = 1800元</p>
                    </div>
                </div>
                <div class="right">
                    <h5>使用场景：单间卧室，采暖面积15平方</h5>
                    <div class="li-box">
                        <div class="title">惠申 中小户型地暖</div>
                        <p>
                            <label>总功率：</label>0.15千瓦/平方 × 60平方 = 9千瓦</p>
                        <p>
                            <label>使用时间：</label>8小时/天 × 30天 = 240小时</p>
                        <p>
                            <label>总耗电：</label>9千瓦 × 240小时 = 2160度电</p>
                        <p>
                            <label>单月费用：</label>2160度电 × 0.4元/度（平均）= 864元</p>
                    </div>
                </div>
            </li>
        </ul>
        <div class="banner-list identical left">
            <div class="icon"><img class="block" src="/content/dist/img/h80.png" /></div>
            <div class="text">
                <div class="text-box">    
                <span class="trademark">惠申<i>TM</i></span> 中小户型地暖发热快速，可以分时分区单独控制开关，没有空置能耗，更节能、更省电。
                    </div>
            </div>
        </div>
        <div class="image-text first">
            <div class="icon tc">
                <img src="/content/dist/img/h51.png" /></div>
            <div class="text">
                <div class="title">分时分区控制</div>
                <p><span class="f72a trademark">惠申<i>TM</i></span>中小户型地暖，因为发热快速，即开即热，因此可以分时段、分区域单独控制开关和设定温度，没有空置能耗，更环保省电。</p>
                <div class="j_btns"><span class="on">白天</span> <span>夜晚</span></div>
            </div>
        </div>
        <div class="image-text last">
            <div class="icon tc">
                <img src="/content/dist/img/h52.png" /></div>
            <div class="text">
                <div class="title">多重保温</div>
                <p><span class="f72a trademark">惠申<i>TM</i></span>中小户型地暖，施工完成后，会形成三道保温结构。减少热量流失，提高电热转化效率，节约用电。</p>
            </div>
        </div>
    </div>
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
