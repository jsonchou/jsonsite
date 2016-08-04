/*!
 * jsonchou 实体接口
 * v: 1.1
 * d: 2016-5-23
*/

var _env = 'real'; //real,dev

var _host = document.location.host;
if (_host.indexOf('localhost:') > -1 || _host.indexOf('127.0.0.1') > -1 || _host.indexOf('10.1.') > -1 || location.href.toLowerCase().indexOf('file://') > -1) {
    _env = 'dev';
}

var _domain = 'jsonchou.com';
var _ua = navigator.userAgent.toLowerCase();
var _uzw = window._uzw || {}; //外部暴露
var _atom = window._atom || {}; //原子类,统一私有方法
var _util = window._util || {}; //简单通用方法

_util = {
    url: {},
    check: {},
    array: {},
    localStorage: {},
    unicode: {},
    user: {},
    cdn: {},
    string: {},
    file: {},
    apis: {}
};

_uzw = {
    env: _env,//real 正式， dev 开发环境
    cookie: {},
    user: {},
    regex: {},
    cooperate: {}, //合作
    mobile: {},
    domain: {},
    ui: {},
    iframe: {},
    apis: {},
    clear: null
};

_util.string = {
    _code: ["\u0009" /*Horizontal tab*/,
    "\u000A" /*Line feed or New line*/,
    "\u000B" /*Vertical tab*/,
    "\u000C" /*Formfeed*/,
    "\u000D" /*Carriage return*/,
    "\u0020" /*Space*/,
    "\u00A0" /*Non-breaking space*/,
    "\u1680" /*Ogham space mark*/,
    "\u180E" /*Mongolian vowel separator*/,
    "\u2000" /*En quad*/,
    "\u2001" /*Em quad*/,
    "\u2002" /*En space*/,
    "\u2003" /*Em space*/,
    "\u2004" /*Three-per-em space*/,
    "\u2005" /*Four-per-em space*/,
    "\u2006" /*Six-per-em space*/,
    "\u2007" /*Figure space*/,
    "\u2008" /*Punctuation space*/,
    "\u2009" /*Thin space*/,
    "\u200A" /*Hair space*/,
    "\u200B" /*Zero width space*/,
    "\u2028" /*Line separator*/,
    "\u2029" /*Paragraph separator*/,
    "\u202F" /*Narrow no-break space*/,
    "\u205F" /*Medium mathematical space*/,
    "\u3000" /*Ideographic space*/],
    trimL: function (str, chars) {
        if (chars == null) {
            chars = this._code;
        }
        if (str == null || str == "") {
            return "";
        }
        var i;
        var l = str.length;
        for (i = 0; (i < l) && (chars.indexOf(str.charAt(i)) > -1) ; i++) {
        }
        return str.substring(i);
    },
    trimR: function (str, chars) {
        if (chars == null) {
            chars = this._code;
        }
        if (str == null || str == "") {
            return "";
        }
        var i;
        var l = str.length;
        for (i = str.length - 1; (i >= 0) && (chars.indexOf(str.charAt(i)) > -1) ; i--) {
        }
        return str.substring(0, i + 1);
    },
    trim: function (str, chars) {
        if (chars == null) {
            chars = this._code;
        }

        var source = str;
        if (source == null || source == "") {
            return "";
        }

        var i;
        var l=source.length;

        for (i = 0 ; (i < l) && (chars.indexOf(source.charAt(i)) > -1) ; i++) {

        }

        source = source.substring(i);

        l = source.length;
        for (i = source.length - 1; (i >= 0) && (chars.indexOf(source.charAt(i)) > -1) ; i--) {
        }
        source = source.substring(0, i + 1);

        return source;
    },
    cut: function (str,len,dot) {
        if (str) {
            if (str.length > len) {
                return str.substring(0, len) + (dot ? "..." : "");
            }
            return str;
        }
        return '';
    }
};

_util.localStorage = {
    ok: window.localStorage,
    set: function (k, v) {
        if (this.ok) {
            window.localStorage.setItem(k, v);
        }
    },
    get: function (k) {
        if (this.ok) {
            return window.localStorage.getItem(k);
        }
    },
    remove: function (k) {
        if (this.ok) {
            window.localStorage.removeItem(k);
        }
    },
    clear: function () {
        if (this.ok) {
            window.localStorage.clear();
        }
    },
    cache: function (lsName, expday, dfr, cb) {
        var ok = window.localStorage;
        var ckn = lsName + "-EndTime";//localStorage expire flag cookie

        if (typeof dfr !== 'function') {
            return;
        }

        if (!_uzw.cookie.get(ckn)) {
            _util.localStorage.remove(lsName);
            _uzw.cookie.set(ckn, '1', expday || 1);
        }

        var _don = function (mydfr) {
            mydfr.done(function (data) {
                cb(data);
                if (data) {
                    if (typeof (JSON) !== 'undefined') {
                        try {
                            if (typeof (data) == 'object') {
                                _util.localStorage.set(lsName, JSON.stringify(data));
                            }
                        } catch (e) {

                        }
                    }
                }
            });
        };

        var _get = function () {
            var mydfr = dfr();
           
            var doneExt = mydfr.doneExt;
            if (typeof doneExt !== 'undefined') {
                mydfr.doneExt(function () {
                    _don(mydfr);
                });
            } else {
                _don(mydfr);
            }

        };

        if (ok) {
            if (_util.localStorage.get(lsName)) {
                var data = _util.localStorage.get(lsName);
                if (typeof (JSON) !== 'undefined') {
                    try {
                        cb(JSON.parse(data));
                    } catch (e) {
                        _get();
                    }
                } else {
                    _get();
                }
            } else {
                _get();
            }
        } else {
            _get();
        }
    }
};

_uzw.cookie = {
    set: function (k, v, day) {
        day = (arguments.length === 3) ? day : 7;
        try {
            v = encodeURIComponent(v);
        } catch (ex) {
            v = escape(v);
        }
        $.cookie(k, v, { expires: day, path: '/', domain: _uzw.env === 'real' ? _domain : '' });
    },
    get: function (k) {
        var ck = $.cookie(k);
        if (ck) {
            try {
                ck = decodeURIComponent(ck);
            } catch (ex) {
                ck = unescape(ck);
            }
            return ck;
        }
        return null;
    },
    del: function (k) {
        var ck = _uzw.cookie.get(k);
        if (ck) {
            $.cookie(k, '', { expires: -1, path: '/', domain: _uzw.env === 'real' ? _domain : '' });
        }
    }
};

_uzw.ui = {
    loader: _uzw.domain.cdn + '/content/m/images/common/gray.gif',
    preloader: _uzw.domain.cdn + '/content/m/images/common/preloader.gif',
    tab: function (node, cb) {
        var nd = $('#' + node);
        if (!nd.get(0)) {
            nd = $('.' + node);
        }
        var tabEvent = nd.attr('data-event') === 'hover' ? 'mouseenter' : 'click';
        if (window._tap === 'tap') {
            tabEvent = 'tap';
        }
        if (nd.get(0)) {
            nd.children('.hd').on(tabEvent, 'li', function () {
                var o = $(this);
                var op = o.parents('.hd');
                var os = o.siblings('li');
                var index = o.index();

                os.removeClass('on');
                o.addClass('on');

                var items = op.siblings('.bd').children('.item');
                items.hide();
                items.eq(index).show();

                var otab = op.parent();

                cb && cb(index, otab);

            });
        }
    },
    mask: {
        show: function (callback) {
            $('.fn-mask').remove();
            var fmh = (_util.check.isIE6 ? document.body.clientHeight : '100%');
            var css = {
                'height': fmh,
                'opacity': '0.5'
            };
            $('body').append("<div class='fn-mask'></div>");
            $('.fn-mask').css(css);
            if (callback) {
                callback();
            }
        },
        hide: function (callback) {
            $('.fn-mask').css({ 'opacity': '0', 'z-index': '-1' });
            //$('.fn-mask').remove();
            if (callback) {
                callback();
            }
        }
    }
};



//防止window.onload事件重载
function gWinLoadFix(fn) {
    if (fn) {
        if (window.addEventListener) {
            window.addEventListener('load', fn, false);
        } else {
            window.attachEvent('onload', fn);
        }
    }
}
 

 