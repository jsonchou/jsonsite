var dtPKG = {
    language: {
        "emptyTable": "数据为空",
        "info": "显示第 _START_ 至 _END_ 项结果，共 _TOTAL_ 项",
        "infoEmpty": "没有数据",
        "lengthMenu": "显示 _MENU_ 项结果",
        "zeroRecords": "没有匹配结果",
        "processing": "<img src='/content/base/loader.gif'> 载入中...",
        "paginate": {
            "first": "首页",
            "last": "末页",
            "next": "下页",
            "previous": "上页"
        }
    }
}

$(function () {
    gInputCheck();
    gSelect();
    gInputCheckAll();
    gImgPreview();
    gImgClose();
    gTableFold();
});

function gInputCheck() {
    $('input:checkbox').on('change', function () {
        var o = $(this);
        var oname = o.attr('name');
        if (oname) {
            $('#' + oname + 'Hid').val(o.prop('checked') ? 1 : 0);
        }
    });
}

function gInputCheckAll() {
    $('#j_ckAll').on('change', function () {
        var o = $(this);
        var ost = o.prop('checked');
        var ck = $('#j_table').find('.td-check').children('input:checkbox');
        ck.prop('checked', ost);
    })
}

function gImgPreview() {
    var $container = $('#imgPreviewContainer');

    if (!$container.get(0)) {
        $container = $('<div/>').attr('id', 'imgPreviewContainer').append('<img/>').hide().css('position', 'absolute').appendTo('body');
    }

    var timg = $container.children('img');

    myimgs = $('img.imgpreview');
    myimgs.on('mouseenter', function () {
        var o = $(this);
        $container.show();
        timg.load(function () {
            timg.show().animate({
                opacity: 1
            }, 300);
        }).attr('src', o.attr('src'));
    }).on('mousemove', function (e) {
        var iX = $(window).width() - $container.width() - 50;
        var xAxis = e.pageX > iX ? iX : e.pageX + 10;
        $container.css({
            top: e.pageY + 10,
            left: xAxis,
            zIndex: 99
        });
    }).on('mouseleave', function () {
        $container.hide();
        timg.unbind('load').attr('src', '').hide().stop().css({
            opacity: 0
        });
    });

}

function gImgClose() {
    var iwps = $('.imgpreview-wrap');
    var nopic = '/content/base/nopic.png';

    //check close status
    var imgs = iwps.children('img');
    imgs.each(function (k,v) {
        var o = $(this);
        var osrc = o.attr('src');
        var os = o.siblings('.fa-my-controlbar');
        if (osrc != nopic) {
            os.show();
        } else {
            os.hide();
        }
    });

    //delete img
    
    iwps.children('.fa-my-controlbar').on('click', function () {
        var close = $(this);
        var img = close.siblings('img');
        var ohid = img.siblings('input:hidden');
        var osrc = img.attr('src');
        if (osrc != nopic) {
            img.attr('src', nopic);
            ohid.val(nopic);
            close.hide();
        }
    });
}

function gTableAjaxControl(model, cb) {

    var _unitDel = function (idlist) {
        swal({
            title: "确定要删除选中的信息？",
            text: "其他附加，相关的信息都会删除",
            type: "warning",
            showCancelButton: true,
            confirmButtonColor: '#DD6B55',
            confirmButtonText: '是的, 我要删除!',
            closeOnConfirm: false
        }, function () {
            $.ajax({
                cache: false,
                url: '/ashx/delete.ashx',
                data: { id: idlist, model: model },
                type: 'POST',
                dataType: 'json',
                success: function (data) {
                    if (data) {
                        if (data.code === 1) {
                            swal("删除成功!", "信息已删除!", "success");
                            myDataTable.row('.selected').remove().draw(false);
                            cb && cb(idlist);
                        } else {
                            swal("出现错误!", data.msg, "error");
                        }
                    }
                }
            });

        });
    }

    var _unitUpd = function (idlist, obj) {

        var flag = obj.attr('data-flag');
        var flagcn = obj.attr('data-flagcn');
        var v = obj.attr('data-v');

        swal({
            title: "确定要修改选中的信息？",
            text: "其他附加，相关的信息都会修改",
            type: "warning",
            showCancelButton: true,
            confirmButtonColor: '#DD6B55',
            confirmButtonText: '是的, 我要修改!',
            closeOnConfirm: false
        }, function () {
            $.ajax({
                cache: false,
                url: '/ashx/update.ashx',
                data: { id: idlist, model: model, flag: flag, flagcn: flagcn, v: v == 1 ? "0" : "1" },
                type: 'POST',
                dataType: 'json',
                success: function (data) {
                    if (data) {
                        if (data.code === 1) {
                            swal("修改成功!", "信息已修改!", "success");
                            obj.attr('data-v', obj.attr('data-v') == '1' ? "0" : "1");
                            obj.removeClass('fa-check').removeClass('fa-close');
                            obj.addClass(obj.attr('data-v') == '1' ? "fa-check" : "fa-close");
                            cb && cb(idlist);
                        } else {
                            swal("出现错误!", data.msg, "error");
                        }
                    }
                }
            });

        });
    }

    //点击操作
    $('#j_table').on('click', '.fa-my-controlbar', function () {

        var o = $(this);
        var oid = o.attr('data-id');
        if (o.hasClass('fa-remove')) {
            _unitDel(oid);
            return false;
        } else if (o.attr('data-flag') && o.attr('data-flagcn') && o.attr('data-v')) {
            _unitUpd(oid, o);
            return false;
        }

    });

    $('#j_delIDlist').on('click', function () {
        var cks = $('#j_table').find('.td-check').children('input:checked');
        var ids = [];
        cks.each(function (k, v) {
            var o = $(this);
            var oid = o.attr('data-id');
            ids.push(oid);
        });

        if (ids.length) {
            _unitDel(ids.join(','));
        } else {
            swal("请选择要删除的行！");
        }

    })

}

function gTableFold() {
    $('.td-fold').on('click', function () {
        var o = $(this);
        if (o.hasClass('fa-angle-double-down')) {
            o.removeClass('fa-angle-double-down');
            o.removeClass('fa-angle-double-up');
            o.addClass('fa-angle-double-up').text('收起');
            var op = o.parents('tr');
            var opNA = op.nextAll();
            opNA.each(function () {
                var oo = $(this);
                if (oo.hasClass('td-stem-root')) {
                    return false;
                }
                oo.show();
            });
        } else {
            o.removeClass('fa-angle-double-down');
            o.removeClass('fa-angle-double-up');
            o.addClass('fa-angle-double-down').text('展开');
            var op = o.parents('tr');
            var opNA = op.nextAll();
            opNA.each(function () {
                var oo = $(this);
                if (oo.hasClass('td-stem-root')) {
                    return false;
                }
                oo.hide();
            });
        }
    })
}

function gSelect() {
    
}