/// <reference path="../../libs/jquery-1.11.0.min.js" />

$(function () {

    jcMail();
    jcLazyload();
    jcQA();
    jcNews();

    $('.save-cont').find('.j_btns').find('span').on('click', function () {
        var o = $(this);
        var icon = o.parents('.text').siblings('.icon').children('img');
        var os = o.siblings('span');
        var index = o.index();

        o.addClass('on');
        os.removeClass('on');

        if (index == 0) {
            icon.attr('src', '/content/dist/img/h51.png')
        }
        if (index == 1) {
            icon.attr('src', '/content/dist/img/h70.png')
        }
    });
});

function jcLazyload() {
    var jlz = $('.j_lazy');
    if (jlz.get(0) != null) {
        $(".j_lazy").find('img[data-original]').lazyload({
            effest: 'fadeIn',
            threshold: 500
        });
    }
}
 
function jcMail() {
    var fom = $('#j_form');
    var ua = "PC";

    fom.find('input,textarea').on('keyup blur', function () {
        var o = $(this);
        o.removeClass('on');
    });

    fom.find('.btn').on('click', function () {
        var name = fom.find('input[name=name]');
        var mobile = fom.find('input[name=mobile]');
        var info = fom.find('textarea[name=info]');
        var mobileRex = "^(13|14||15|17|18)[0-9]{9}$";
        if (!name.val()) {
            name.addClass('on');
            alert('请输入您的用户名称');
            return;
        } else if (!mobile.val()) {
            mobile.addClass('on');
            alert('请输入您的手机号码');
            return;
        } else if (!mobile.val().match(mobileRex)) {
            mobile.addClass('on');
            alert('请输入正确的手机号码');
            return;
        } else if (!info.val()) {
            info.addClass('on');
            alert('请输入咨询内容');
            return;
        } else if (info.val().length <= 10) {
            info.addClass('on');
            alert('咨询内容请超过10个字符');
            return;
        } else {
            $.ajax({
                cache: false,
                type: 'POST',
                url: '/ashx/mail.ashx',
                data: { 'name': name.val(), 'mobile': mobile.val(), 'info': info.val(), 'ua': ua + "，" + navigator.userAgent },
                dataType: 'json',
                success: function (res) {
                    //res && alert(res.msg);
                },
                error: function (info) {
                    //alert(JSON.stringify(info));
                },
                complete: function () {
                    alert('邮件发送成功！');
                    fom.find('textarea[name=info]').val('');
                }
            });
        }
    });
}

function jcQA() {
    var obj = $('#j_qAbox');
    obj.find('dt').on('click', function () {
        var o = $(this);
        var op = o.parent('dl')
        var os = o.next('dd');
        var dls = op.siblings('dl');
        dls.find('dd').slideUp('slow');

        if (op.hasClass('on')) {
            op.removeClass('on');
            os.slideUp();
        } else {
            op.addClass('on');
            os.slideDown();
        }
    });
}

function jcNews() {
    var fcs = $('#j_newsFocus');
    fcs.find('li').on('click', function () {
        var o = $(this);
        var os=o.siblings('li')
        var osrc = o.find('img').attr('src');
        var otit = o.find('img').attr('alt');
        var otxt = o.find('.seo').text();

        os.removeClass('on');
        o.addClass('on');

        var otar = fcs.find('.iocn-left');
        otar.find('img').attr('src', osrc);
        otar.find('.title').text(otit);
        otar.find('.font').text(otxt);

        otar.fadeIn('slow');

    })
}









