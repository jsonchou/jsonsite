<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="qianghua.aspx.cs" Inherits="JC.Web.color.qianghua" %>

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
                    <img class="block" src="/content/dist/img/h137.jpg" /></div>
                <div class="box tc white">
                    <div class="title">强化复合系列   </div>
                    <div class="font"><span class="trademark">惠申<i>TM</i> </span>强化复合系列，木纹漂亮，安全环保，经济耐用，适用于家庭及工装用户。</div>
                    <div class="labels">
                        <label class="on">客厅</label><label class="on">饭厅</label><label class="on">卧室</label><label class="on">书房</label><label>厨房</label></div>
                </div>
            </li>
        </ul>
    </div>
    <div class="product-detailed">
        <div class="crumbs">
            <div class="crumbs-box">
                <a href="/">首页</a> > <a href="/color/">产品花色</a> > <span>强化复合系列</span>
            </div>
        </div>
        <ul class="detailed-list">
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h37.jpg" /></div>
                <div class="right">
                    <div class="title">写意生活</div>
                    <div class="font">犹如简笔写意的素描，寥寥几笔，恬淡勾勒，却不事张扬，优雅小调，俯仰皆是，家里有了它，便有了品味与休闲！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h50.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h38.jpg" /></div>
                <div class="right">
                    <div class="title">幸福温度</div>
                    <div class="font">褚红色的温度，不浓不淡，不深不浅，刚刚好，恰如娴静的生活，行云流水、进退自如的才是幸福应有的节奏，你的家，就要如此温馨舒适！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h51.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h39.jpg" /></div>
                <div class="right">
                    <div class="title">暖心沙滩</div>
                    <div class="font">葡萄牙的风情小调，优美的海滩、古典的建筑，掩映着高大的乔木，一路阳光作伴，古朴的年轮里，见证了一颗树成长的历程，温暖相遇，地老天荒！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h52.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h40.jpg" /></div>
                <div class="right">
                    <div class="title">高棉金柚</div>
                    <div class="font">金色的温度，裹挟着热带特有的热情，披挂着繁茂雨林的风情，游荡的风，扑面而来的醉人温暖，一见，就已钟情！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h53.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h41.jpg" /></div>
                <div class="right">
                    <div class="title">彩云出釉</div>
                    <div class="font">早起清晨，彩云簇拥着朝阳向上攀升，披满了五彩的霞光，向长天大地倾洒满心的热情，唤醒大地，万物生长，新的一天，赏心悦目地开启！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h54.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h42.jpg" /></div>
                <div class="right">
                    <div class="title">田园之风</div>
                    <div class="font">起风了，麦浪翻滚，翩然起舞，光影变幻，错落有致，如同一串流动的音符，涟漪般扩散，回望，炊烟袅袅，那是梦里的美丽田园！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h55.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h43.jpg" /></div>
                <div class="right">
                    <div class="title">草原秋色</div>
                    <div class="font">秋天的草原，走过水草丰美的夏季，褪去了青涩，散发着成熟的味道，抽出丝质的柔情，温煦如风，梦想在望，家人在旁，拥抱并温暖你！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h56.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h44.jpg" /></div>
                <div class="right">
                    <div class="title">艺术之河</div>
                    <div class="font">星罗棋布的河流，恰如造诣高神的绘画大师，在大地这无边的巨幅上，挥毫泼墨，灵思泉涌，一气呵成，自然的艺术，更贴近美好的生活！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h57.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h45.jpg" /></div>
                <div class="right">
                    <div class="title">江山入画</div>
                    <div class="font">造化之手蕴灵秀，指点江山，点滴如画，连绵山势，鲜活生动。于无声处，漫无边际地开出朵朵花儿，温情的表达，让人沉醉，不能自拔！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h58.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h46.jpg" /></div>
                <div class="right">
                    <div class="title">暖心沙滩</div>
                    <div class="font">如同温热的沙滩，蕴藏着大地的体温，临摹着曼妙的海岸线，褪却浮华，不喧哗自有形，沉稳静谧，有它陪着，每一个日子都倍感踏实！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h59.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h47.jpg" /></div>
                <div class="right">
                    <div class="title">大地之意</div>
                    <div class="font">感谢大地，赠与我赤子的颜色，赋予我深沉的爱意，生活需要明艳，于是我奋力向前，为了心中的美好，不妥协一直到老！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h60.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h48.jpg" /></div>
                <div class="right">
                    <div class="title">枫叶之心</div>
                    <div class="font">枫叶红了，带着阳光的温热，带着油画的质感，不流于平庸，不甘于苍白，自由地旋舞飘落，在泥土中舒展，神奇生命，绚烂如花！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h61.jpg" /></div>
                </div>
            </li>
            <li class="fix">
                <div class="icon">
                    <img class="block" src="/content/dist/img/h49.jpg" /></div>
                <div class="right">
                    <div class="title">梦中桃源</div>
                    <div class="font">枫叶红了，带着阳光的温热，带着油画的质感，不流于平庸，不甘于苍白，自由地旋舞飘落，在泥土中舒展，神奇生命，绚烂如花！</div>
                    <div class="icon">
                        <img class="block" src="/content/dist/img/h62.jpg" /></div>
                </div>
            </li>
        </ul>
    </div>
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
