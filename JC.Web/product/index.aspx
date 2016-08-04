<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.product.index" %>

<%@ Register Src="~/ascx/meta.ascx" TagPrefix="uc1" TagName="meta" %>
<%@ Register Src="~/ascx/static.ascx" TagPrefix="uc1" TagName="static" %>
<%@ Register Src="~/ascx/header.ascx" TagPrefix="uc1" TagName="header" %>
<%@ Register Src="~/ascx/footer.ascx" TagPrefix="uc1" TagName="footer" %>
<%@ Register Src="menu.ascx" TagPrefix="uc1" TagName="menu" %>
<%@ Register Src="~/ascx/problem.ascx" TagPrefix="uc1" TagName="problem" %>
<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <uc1:meta runat="server" ID="meta1" />
    <title><%=mmenu.title %>_<%=msite.title %></title>
    <meta name="keywords" content="<%=mmenu.keywords %>" />
    <meta name="description" content="<%=mmenu.description %>" />
    <uc1:static runat="server" ID="static1" />
    <style>
        .slidesjs-pagination { bottom: 23%; }
    </style>
    <script src="/content/libs/jquery.easing.js"></script>
    <script src="/content/libs/jquery.mousewheel.min.js"></script>
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

            var pnl = $('#j_panel');
            $('.characteristic-box').find('.chara-slide').css({ 'height': $(window).height(), 'line-height': $(window).height() + 'px' });

            pnl.mousewheel(function (event, delta) {
                var o = $(this);
                var img = o.attr('src');
                var idx = parseInt(o.attr('data-eq'));
                if (delta < 0) {
                    //向下
                    if (idx <= 10) {
                        o.attr('data-eq', idx + 1);
                       
                        var ost = o.children('.chara-slide').eq(idx + 1).offset().top;

                        $('body,html').stop().animate({
                            scrollTop: ost
                        }, 0, function () {
                            o.children('.chara-slide').removeClass('chara-slide-on');
                            o.children('.chara-slide').eq(idx + 1).addClass('chara-slide-on');
                        });

                        return false;
                    } else {
                        pnl.unmousewheel(function () {
                            console.log(1);
                        });
                    }
                } else if (delta > 0) {
                    //向上
                    if (idx >= 1) {
                        o.attr('data-eq', idx - 1);
                        

                        var ost = o.children('.chara-slide').eq(idx - 1).offset().top;

                        $('body,html').stop().animate({
                            scrollTop: ost
                        },0, function () {
                            o.children('.chara-slide').removeClass('chara-slide-on');
                            o.children('.chara-slide').eq(idx - 1).addClass('chara-slide-on');
                        });

                        return false;

                    } else {
                        pnl.unmousewheel(function () {
                            
                        });
                    }
                }
              
            });

            //page init
            $(window).scrollTop(0);

        });
    </script>
</head>
<body>
    <div class="header">
        <uc1:header runat="server" ID="header1" />
        <uc1:menu runat="server" ID="menu1" />
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
            <ul class="banner-ul" style="top: -130px;">
                <li>
                    <a href="/product/">
                        <div class="icon">
                            <img class="block" src="/content/dist/img/h14.jpg" />
                        </div>
                        <div class="summarize"><span>中小户型新房装地暖</span></div>
                    </a>
                </li>
                <li>
                    <a href="/product/">
                        <div class="icon">
                            <img class="block" src="/content/dist/img/h15.jpg" />
                        </div>
                        <div class="summarize"><span>单间局部安装地暖</span></div>
                    </a>
                </li>
                <li>
                    <a href="/product/">
                        <div class="icon">
                            <img class="block" src="/content/dist/img/h16.jpg" />
                        </div>
                        <div class="summarize"><span>已装修房加装地暖</span></div>
                    </a>
                </li>
            </ul>
        </div>
    </div>

    <div class="characteristic characteristic-on">
        <div class="characteristic-box">
            <div class="icon">
                <div class="panel" id="j_panel" data-eq="0">
                    <div class="chara-slide chara-slide-1 chara-slide-on">
                        <img src="/content/dist/img/f1.png" />
                    </div>
                    <div class="chara-slide chara-slide-2">
                        <img src="/content/dist/img/f2.png" />
                    </div>
                    <div class="chara-slide chara-slide-3">
                        <img src="/content/dist/img/f3.png" />
                    </div>
                    <div class="chara-slide chara-slide-4">
                        <img src="/content/dist/img/f4.png" />
                    </div>
                    <div class="chara-slide chara-slide-5">
                        <img src="/content/dist/img/f5.png" />
                    </div>
                    <div class="chara-slide chara-slide-6">
                        <img src="/content/dist/img/f6.png" />
                    </div>
                    <div class="chara-slide chara-slide-7">
                        <img src="/content/dist/img/f7.png" />
                    </div>
                    <div class="chara-slide chara-slide-8">
                        <img src="/content/dist/img/f8.png" />
                    </div>
                    <div class="chara-slide chara-slide-9">
                        <img src="/content/dist/img/f9.png" />
                    </div>
                    <div class="chara-slide chara-slide-10">
                        <img src="/content/dist/img/f10.png" />
                    </div>
                    <div class="chara-slide chara-slide-11">
                        <img src="/content/dist/img/f11.png" />
                    </div>
                    <div class="chara-slide chara-slide-12">
                        <img src="/content/dist/img/f12.png" />
                    </div>
                </div>
            </div>
            <div class="stress tc">
                地板(瓷砖)+地暖全集成，不占层高，安装方便
                <br />
                是中小户型安装地暖的最佳选择
            </div>
            <div class="text tl" style="width: 900px; margin: 0 auto;"><span class="f72a trademark">惠申<i>TM</i> </span>中小户型地暖，将发热系统集成到地板/瓷砖内部，外观与普通地板/瓷砖一样，结构简单、安装便捷、不占层高。发热快，可分时分区控制，没有空置能耗，更省电。发热系统技术成熟，防水防漏电，使用寿命长，无需维护，30年保修承诺更安心。相对于更适合大户型的水暖，<span class="f72a trademark">惠申<i>TM</i></span>是中小户型用户安装地暖的最佳选择！</div>
        </div>
    </div>
    <div style="margin-top: -121px; height: 482px;" class="j_offset1 identical">
        <div class="icon">
            <img class="block" src="/content/dist/img/h4.png" style="height: 482px;" />
        </div>
        <div class="text">
            <div class="text-box">
                <div class="title">电地暖-更清洁的采暖方式</div>
                <div class="font">近年，国家多个部位联合印发了《关于推进电能替代的指导意见》（发改能源[2016]1054号），为全面推进电能替代提供了政策依据。使用可再生的电能，不但可以保护我们的环境，同时使用更方便，发热更快。面对长江流域忽冷忽热的潮湿气候，传统水暖无法及时应对，<span class="f72a trademark">惠申<i>TM</i> </span>中小户型地暖即开即热，从容应对多变天气。</div>
            </div>
        </div>
    </div>
    <div class="quickInstallation j_offset2 identical">
        <div class="icon">
            <img class="block" src="/content/dist/img/h17.jpg" />
        </div>
        <div class="text">
            <div class="text-box">
                <div class="title">电地暖-安装便捷</div>
                <div class="font">
                    <span class="f72a trademark">惠申<i>TM</i> </span>中小户型地暖，地暖/瓷砖+地暖合二为一，结构简单，安装速度快。<br />
                    铺装无需开墙破洞，单个房间当天就可装完！
                </div>
                <ul class="fix">
                    <li>
                        <a href="/product">
                            <div class="pic" style="background-image: url(/content/dist/img/h76.png); background-position: 0 0;"></div>
                            <p>最快地暖一天装好</p>
                        </a>
                    </li>
                    <li>
                        <a href="/product">
                            <div class="pic" style="background-image: url(/content/dist/img/h76.png); background-position: -96px 0;"></div>
                            <p>不占房屋层高</p>
                        </a>
                    </li>
                    <li>
                        <a href="/product">
                            <div class="pic" style="background-image: url(/content/dist/img/h76.png); background-position: -192px 0;"></div>
                            <p>不用开墙破洞</p>
                        </a>
                    </li>
                    <li>
                        <a href="/product">
                            <div class="pic" style="background-image: url(/content/dist/img/h76.png); background-position: -288px 0;"></div>
                            <p>可原地面上加装</p>
                        </a>
                    </li>
                    <li>
                        <a href="/product">
                            <div class="pic" style="background-image: url(/content/dist/img/h76.png); background-position: -384px 0;"></div>
                            <p>任意面积大小</p>
                        </a>
                    </li>
                </ul>
                <a class="more" href="/product/convenient">了解安装快 ></a>
            </div>
        </div>
    </div>
    <div class="rapidHeating j_offset3 identical">
        <div class="icon">
            <img class="block" src="/content/dist/img/h18.jpg" />
        </div>
        <div class="text">
            <div class="text-box">
                <div class="title">即开即用</div>
                <div class="font">
                    <span class="f72a trademark">惠申<i>TM</i> </span>中小户型地暖发热快，开启15分钟地面即热，30分钟左右房间就可达到舒适温度。<br />
                    即开即热，轻松应对长江流域忽冷忽热的气候。
                </div>
                <div class="pic">
                    <img src="/content/dist/img/h78.png" />
                </div>
                <a class="more" href="/product/fast">了解发热快 ></a>
            </div>
        </div>
    </div>
    <div class="powerSaving identical">
        <div class="icon">
            <img class="block" src="/content/dist/img/h19.jpg" />
        </div>
        <div class="text">
            <div class="text-box">
                <div class="title">高效省电</div>
                <div class="font">
                    <span class="f72a trademark">惠申<i>TM</i> </span>中小户型地暖结构简单，发热系统的热转化效率更高，多重结构减少空置能耗。<br />
                    平均耗电低至一小时0.05度/每平方。
                </div>
                <a href="/product/energy">了解更省电 ></a>
            </div>
        </div>
        <div class="powerSaving-list">
            <div class="box fix">
                <div class="left">
                    <img class="block" src="/content/dist/img/h77.png" />
                </div>
                <ul class="fix right">
                    <li>
                        <a href="/product">
                            <div class="pic" style="background-image: url(/content/dist/img/h75.png); background-position: 0 0;"></div>
                            <p>热转化效率高</p>
                        </a>
                    </li>
                    <li>
                        <a href="/product">
                            <div class="pic" style="background-image: url(/content/dist/img/h75.png); background-position: -192px 0;"></div>
                            <p>分时分区控制</p>
                        </a>
                    </li>
                    <li>
                        <a href="/product">
                            <div class="pic" style="background-image: url(/content/dist/img/h75.png); background-position: -288px 0;"></div>
                            <p>多重保温</p>
                        </a>
                    </li>
                    <li>
                        <a href="/product">
                            <div class="pic" style="background-image: url(/content/dist/img/h75.png); background-position: -384px 0;"></div>
                            <p>导热路径短</p>
                        </a>
                    </li>
                </ul>
            </div>
        </div>
    </div>
    <div class="security">
        <div class="icon tc">
            <img src="/content/dist/img/h5.png" />
        </div>
        <div class="text tc">
            <div class="title">安全环保</div>
            <div class="font">
                <span class="f72a trademark">惠申<i>TM</i></span>中小户型地暖通过欧盟3C认证，从技术到材料，从每个角度确保产品安全环保。<br />
                无需担心漏电、漏水、辐射及甲醛的危害。
            </div>
        </div>
        <ul class="list tc">
            <li>
                <div class="icon">
                    <img class="block" src="/content/dist/img/h6.png" />
                </div>
                <p>漏电保护</p>
            </li>
            <li>
                <div class="icon">
                    <img class="block" src="/content/dist/img/h7.png" />
                </div>
                <p>密封防水</p>
            </li>
            <li>
                <div class="icon">
                    <img class="block" src="/content/dist/img/h8.png" />
                </div>
                <p>无辐射危害</p>
            </li>
            <li>
                <div class="icon">
                    <img class="block" src="/content/dist/img/h9.png" />
                </div>
                <p>无甲醛挥发</p>
            </li>
            <li>
                <div class="icon">
                    <img class="block" src="/content/dist/img/h10.png" />
                </div>
                <p>35℃安全采暖</p>
            </li>
        </ul>
        <div class="tc f18 more"><a href="/product/safety">了解安全环保  ></a></div>
    </div>
    <div class="durable identical">
        <div class="icon">
            <img class="block" src="/content/dist/img/h11.png" />
        </div>
        <div class="text">
            <div class="text-box">
                <div class="title">超久耐用</div>
                <div class="font">
                    <span class="f72a trademark">惠申<i>TM</i></span>中小户型地暖，基材高于国家耐用标准，发热系统使用寿命超过10万小时。<br />
                    30年保修承诺，后期使用无需维护，维修简单。
                </div>
                <a class="more" href="/product/durable">了解超久耐用  ></a>
            </div>
        </div>
    </div>
    <div class="temperature-control identical">
        <div class="icon">
            <img class="block" src="/content/dist/img/h20.jpg" />
        </div>
        <div class="text">
            <div class="text-box">
                <div class="title">智能温控</div>
                <div class="font">
                    <span class="f72a trademark">惠申<i>TM</i></span>中小户型地暖搭配新一代智能温控器，分分钟让普通地暖变成智能家居。<br />
                    无论身在何处，都能掌控家中地暖温度，冬天进门就感受到温暖的家！
                </div>
            </div>
        </div>
    </div>
    <uc1:problem runat="server" ID="problem" />
    <uc1:footer runat="server" ID="footer1" />
</body>
</html>
