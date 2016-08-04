<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="shimu.aspx.cs" Inherits="JC.Web.color.shimu" %>

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
    <div class="productColor">
        <ul>
            <li>
                <div class="icon">
                    <img class="block" src="/content/dist/img/h85.jpg" /></div>
                <div class="box tc white">
                    <div class="title">实木多层系列</div>
                    <div class="font"><span class="trademark">惠申<i>TM</i> </span>实多层系列，更贴近自然，脚感更舒适，适用于家庭用户。</div>
                    <div class="labels">
                        <label class="on">客厅</label><label class="on">饭厅</label><label class="on">卧室</label><label class="on">书房</label><label>厨房</label></div>
                </div>
            </li>
        </ul>
    </div>
    <div class="product-detailed">
        <div class="crumbs">
            <div class="crumbs-box">
                <a href="/">首页</a> > <a href="/color/">产品花色</a> > <span>实木多层系列</span>
            </div>
        </div>
        <ul class="detailed-list">
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h63.jpg" /></div>
                <div class="right">
                    <div class="title">蜜意人生（冰糖果）</div>
                    <div class="font">通透的质感，明艳的色调，恰如一枚让人垂涎的冰糖果，鲜活灵动，阳光洒进来，满心满眼都是蜜意！生活如是，多么醉人！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h74.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h64.jpg" /></div>
                <div class="right">
                    <div class="title">凸凹有致（榆木）</div>
                    <div class="font">经典的复古纹理，真实的浮雕触感，油画般的呈现，浑然一体的协调，追溯一种独一无二的美，古朴雅致，凸凹有致，给爱家别样的表达！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h75.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h65.jpg" /></div>
                <div class="right">
                    <div class="title">传奇故事（黑胡桃）</div>
                    <div class="font">唯有时间，见证价值！旷日持久的磨砺，烙在或深或浅的纹路里，铅华洗尽，品质浑然天成，于从容淡定中，书写传奇人生，为成就喝彩！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h76.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h66.jpg" /></div>
                <div class="right">
                    <div class="title">红檀印象（红檀香）</div>
                    <div class="font">红檀，得天地精华之滋养，从厚重的历史中走来，持守古韵雅风，沉淀经典奢华，古朴细致，匠心独具，尽显返璞归真的通透智慧！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h77.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h67.jpg" /></div>
                <div class="right">
                    <div class="title">天生梨质（花梨木）</div>
                    <div class="font">成长没有捷径，几十载雕琢洗礼，难掩花梨木天生丽质，如一朵惊艳绽放的牡丹，生而有别，气度顿生，岁月芳华，富贵典藏！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h78.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h68.jpg" /></div>
                <div class="right">
                    <div class="title">湖光涟漪（橡木）</div>
                    <div class="font">安静的生活，笑起来都象一湖清水，泛起涟漪，变幻出千百般的美，岁月静好，默契欢喜，每一刻，都有幸福溢出来！ </div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h79.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h69.jpg" /></div>
                <div class="right">
                    <div class="title">流云之光（酸枝木）</div>
                    <div class="font">天上流云，宛如视觉的艺术，天马行空，倏忽变幻，已胜却人间无数，奇思妙想，自在随心，用灵感点亮每天的好心情！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h80.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h70.jpg" /></div>
                <div class="right">
                    <div class="title">暖阳之彩（柚木）</div>
                    <div class="font">生活需要明媚的阳光，恰如披着霓裳的金色柚木，每一丝纹路都透着温暖，让每个平凡的日子都熠熠生辉，宠爱要有温度，记得对自己好点！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h81.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h71.jpg" /></div>
                <div class="right">
                    <div class="title">时光烙印（榆木浮雕）</div>
                    <div class="font">造化之手蕴灵秀，指点江山，点滴如画，连绵山势，鲜活生动。于无声处，漫无边际地开出朵朵花儿，温情的表达，让人沉醉，不能自拔！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h82.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h72.jpg" /></div>
                <div class="right">
                    <div class="title">珠圆玉润（圆盘豆）</div>
                    <div class="font">玛瑙般的肤色，暖玉般的光泽，红袖添香，岁月悠长，慵懒惬意，居家味道，坐看风景，晴暖如春，温暖入梦！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h83.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h73.jpg" /></div>
                <div class="right">
                    <div class="title">彼岸花开（柞木）</div>
                    <div class="font">经得起平淡的流年，耐得住风霜的考验，如同柞木，贫瘠之地却滋养出优雅的纹路！境由心生，心存美意，拥抱生活，则终得圆满！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h84.jpg" /></div>
                </div>
            </li>
        </ul>
    </div>
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
