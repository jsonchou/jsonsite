/*!
 * jsonchou 外围框架JS
 * v: 1.1
 * d: 2016-5-23
*/

var wrapper, tabs, conts, menus;
var rootUrl = "";//网站全域名
var pageTab = window.pageTab || {};

$(function () {
    gInitNode();
    gLoadUserMenu();
    gPageTab.init();
    gContextMenu();
    gFixIframeHeight();
    gTriggerMenu();
});

function gInitNode() {
    wrapper = $('#j_ContentWrapperMain');
    tabs = wrapper.children('.content-wrapper-main-menu');
    conts = wrapper.children('.content-wrapper-main-center');
    menus = $('.sidebar-menu');
}

function gLoadUserMenu() {
    var stockName = "gUzaiManagerMenu";
    var ck = _uzw.cookie.get(stockName);
    var gm = _util.localStorage.get(stockName);
    var icons = ['fa-area-chart', 'fa-headphones', 'fa-pie-chart', 'fa-list', 'fa-dollar', 'fa-cubes', 'fa-briefcase', 'fa-search', 'fa-cc-visa', 'fa-tv', 'fa-hourglass-end', 'fa-truck', 'fa-thumbs-o-up', 'fa-battery-3', 'fa-qq', 'fa-wifi', 'fa-user', 'fa-gear'];
    var iconsKey = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18];
    
    var dfr = function () {
        var mydfr = $.ajax({
            url: '/ashx/modules.ashx',
            //url: '/ashx/test.json',
            cache: true,
            type: "GET",
            dataType:"json",
            beforeSend: function () {
                menus.append('<li class="menu-loading tc"><i class="fa fa-spinner"></i> 菜单载入中...</li>')
            }
        });

        mydfr.fail(function () {
            mydfr.doneExt();
        });

        mydfr.doneExt = function (mycb) {
            setTimeout(function () {
                menus.find('.menu-loading').remove();
                mycb && mycb();
            }, 2000);
        };

        return mydfr;
    }

    _util.localStorage.cache(stockName, 1, dfr, function (res) {
        if (res) {
             
            //m_StringValue
            var msv = res.data.m_StringValue;
            if (msv) {

                var data = JSON.parse(msv);

                if (data && data.length) {
                    //递归
                    var point = 0;
                    function renderHtml(data) {
                        var sb = "";
                        $.each(data, function (k, v) {
                            var url = v.url ? (v.url.indexOf('//') > -1 ? v.url : (rootUrl + v.url)) : '#';
                            var stem = false;
                            //leaf 叶子
                            if (v.leaf == 'false' && v.parentid == 0) {
                                stem = true;
                            }

                            if (stem) {
                                point = iconsKey.indexOf(parseInt(v.orderby));
                            }

                            

                            sb += "<li class='treeview' data-id='" + v.id + "' data-txt='" + v.text + "' data-href='" + url + "' data-target='" + v.target + "'>";
                            sb += "<a>";
                            sb += "<i class='fa " + (stem ? icons[point] : 'fa-circle-o') + "'></i> <span>" + v.text + "</span>";
                            sb += "<i class='fa pull-right " + (v.leaf == 'false' ? 'fa-angle-left' : '') + "'></i>";
                            if (v.target == '_blank') {
                                sb += "<i class='fa fa-mail-forward pull-right'></i>";
                            }
                            sb += "</a>";

                            if (v && v.children) {
                                sb += "<ul class='treeview-menu'>";
                                sb += renderHtml(v.children);
                                sb += "</ul>";
                            } else {
                                //sb += "<li><a href='" + (url) + "'><i class='fa fa-circle-o'></i> " + v.text + "</a></li>";
                            }
                            sb += "</li>";
                        });
                        return sb;
                    }
                    var myHtml = renderHtml(data);
                    menus.children('.header').eq(0).after(myHtml);
                }
               
            }
        }
    })

}

gPageTab = {
    init: function () {
        this.slide();
        this.append();
        this.click();
        this.dblclick();
        this.close();
    },
    getMaxTabNum: function () {
        //重新设置
        var jml = $('#j_menuList');
        var jmlW = jml.outerWidth();
        var myItems = jml.find('.item');
        var myLens = myItems.length;

        //比较长度
        var minLen = 20;//默认最小数量

        var w = 0;
        myItems.each(function (k, v) {
            w += $(this).outerWidth();
            if (jmlW <= w) {
                minLen = k - 1;
                return false;
            } else {
                minLen = k + 1;//继续走
            }
        });
         
        //console.log('list-width：' + jmlW + ',new-width：' + w + ",my number：" + minLen);

        return minLen;
    },
    slide: function () {
        var lens = this.getMaxTabNum();
        if ($.fn.slick) {
            $('#j_menuList').slick({
                prevArrow: '.slick-prev',
                nextArrow: '.slick-next',
                slidesToShow: lens,
                slidesToScroll: 1,
                dots: false,
                infinite: false,
                speed: 300,
                centerMode: false,
                variableWidth: true
            });
        }
    },
    append: function () {
        var me = this;
        menus.on('click', '.treeview', function () {
            var o = $(this);
            var dhref = o.attr('data-href');
            var did = o.attr('data-id');
            var dtxt = o.attr('data-txt');
            var dtarget = o.attr('data-target');
            if (dtarget == '_blank') {
                return;//跳出iframe页面
            }

            //点击左侧菜单，永远刷新
            if (me.check(did)) {
                me.refresh(did);
            } else {
                if (dhref && dhref != '#') {
                    me.clear();
                    //添加tab ifrmae
                    var hnode = "<div data-id='" + did + "' data-href='" + dhref + "' class='item on'><span>" + dtxt + "</span><i class='fa fa-close'></i></div>";
                    $('#j_menuList').slick('slickAdd', hnode);
                    $('#j_menuList').slick('slickSetOption', 'slidesToShow', me.getMaxTabNum(), true);//重载

                    var hhd = "<section class='content-header'><h1>" + dtxt + "<small></small></h1><ol class='breadcrumb'><li><a href='#'><i class='fa fa-dashboard'></i> 首页</a></li><li class='active'>" + dtxt + "</li></ol></section>";
                    var hbd = "<section class='content'><iframe class='j_iframeInnerPage' id='j_iframeInnerPage" + did + "' src='" + dhref + "' frameborder='0'></iframe></section>";
                    var loader = "<div class='content-loader'><span class='fa fa-spinner'></span></div>";
                    conts.append('<div class="content-wrapper-main-item">' + loader + "<div class='content-main'>" + hhd + hbd + '</div></div>');
                     
                    gContextMenu();
                    me.refresh(did);
                }
            }
        });
    },
    check: function (id) {
        return tabs.find('.item[data-id=' + id + ']').get(0);
    },
    click: function () {
        var me = this;

        tabs.on('click', '.item', function () {
            var o = $(this);
            var idx = o.index();
            var lis = tabs.find('.item');
            var mcons = conts.children('.content-wrapper-main-item');

            me.clear();

            lis.eq(idx).addClass('on');
            mcons.eq(idx).show();
        });

    },
    dblclick: function () {
        //双击关闭
        var me = this;
        tabs.on('dblclick', '.item', function () {
            me.active();
            var node = me.get();
            node.find('.fa-close').trigger('click');
        });
    },
    active: function (id) {
        tabs.find('.item[data-id=' + id + ']').trigger('click');
    },
    clear: function () {
        tabs.find('.item').removeClass('on')
        conts.children('.content-wrapper-main-item').hide();
    },
    refresh: function (id) {
        this.active(id);

        _uzw.ui.mask.show(function () {

        });

        var idx = this.index();

        var citem = conts.find('.content-wrapper-main-item').eq(idx);
     
        citem.removeClass('content-wrapper-main-item-off');

        var ifr = citem.find('iframe');

        ifr.attr('src', this.get().attr('data-href') + '#' + Math.random());

        ifr.on('load', function () {
            gFixIframeHeight();
        });

        setTimeout(function () {
            _uzw.ui.mask.hide(function () {
                citem.addClass('content-wrapper-main-item-off');
            });
        }, 2000);
    },
    index: function () {
        return this.get().index();
    },
    get: function () {
        return tabs.find('.item').filter('.on');
    },
    close: function () {
        var me = this;
        tabs.on('click', '.fa-close', function () {
            var o = $(this);
            var op = o.parent('.item');
            var oid = op.attr('data-id');
            if (oid == 0) {
                return;//首页不允许关闭
            }
            var idx = op.index();
            var lis = tabs.find('.item');
            var mcons = conts.children('.content-wrapper-main-item');

            lis.eq(idx).remove();
            mcons.eq(idx).remove();

            //下一个选项卡默认点击
            lis = tabs.find('.item');

            if (lis.length > idx) {
                lis.eq(idx).trigger('click');
            } else {
                lis.eq(idx - 1).trigger('click');
            }

            $('#j_menuList').slick('slickSetOption', 'slidesToShow', me.getMaxTabNum(), true);//重载

            return false;//防止冒泡
        });
    }
}

//content tab menu 
function gContextMenu() {
    var imageMenuData = [
   [{
       text: "关闭当前页",
       func: function () {
           var o = $(this);
           var idx = o.index();
           o.find('.fa-close').trigger('click');
       }
   }, {
       text: "关闭其他",
       func: function () {
           var o = $(this);
           var idx = o.index();

           var lis = tabs.find('.item');
           var items = conts.children('.content-wrapper-main-item');

           lis.not(o).not(':first').remove();
           items.filter(':hidden').not(':first').remove();
       }
   }],
   [{
       text: "关闭所有",
       func: function () {
           tabs.find('.item').not(':first').remove();
           conts.children('.content-wrapper-main-item').not(':first').remove();
           gPageTab.active(0);//激活首页
       }
   }, {
       text: "刷新",
       func: function () {
           var o = $(this);
           var idx = o.index();
           var oid = o.attr('data-id');
           var ohref = o.attr('data-href');

           var lis = tabs.find('.item');
           var items = conts.children('.content-wrapper-main-item');
           gPageTab.refresh(oid);

       }
   }]
    ];

    tabs.find('.item').smartMenu(imageMenuData, {
        name: "image",
        beforeShow: function () {
            $(this).trigger('click');
        },
        afterShow: function () {
            var sm = $('#smartMenu_image');
            sm.find('.smart_menu_li_separate').addClass('divider')
            sm.find('.smart_menu_ul').addClass('dropdown-menu').show();
        }
    });
}


function gFixIframeHeight() {
    var frms = conts.children('.content-wrapper-main-item').find('iframe');
    frms.each(function () {
        var o = $(this);
        var ocnt = o.parent('.content');
        o.css('min-height', ocnt.height());

        o.iFrameResize({
            log: false
        });

    });
  
}


function gTriggerMenu() {
    var sba = $('#j_shortcutTop').find('.my-trigger');
    sba.on('click', function () {
        var o = $(this);
        var ohref = o.attr('href');
        var lis = $('.sidebar').find(".treeview[data-href='" + ohref + "']");
        lis.trigger('click');
        return false;
    });
}
