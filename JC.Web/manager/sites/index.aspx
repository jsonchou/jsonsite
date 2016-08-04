<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.manager.sites.index" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title><%=msite.title %>管理后台</title>
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="stylesheet" href="/my/styles/base.css" />
    <link href="/alte/plugins/select2/dist/css/select2.css" rel="stylesheet" />
    <link href="/alte/plugins/select2/dist/css/select2-bootstrap.min.css" rel="stylesheet" />
    <script src="/Content/3rd/ckfinder/ckfinder.js"></script>
</head>
<body>
    <!-- Main content -->
    <section class="content">
        <div class="row">
            <!-- right column -->
            <div class="col-md-12">
                <!-- Horizontal Form -->
                <div class="box box-site">
                    <!-- /.box-header -->
                    <!-- form start -->
                    <form class="form-horizontal" method="post" runat="server">
                        <div class="box-body">

                            <div class="form-group">
                                <label class="col-sm-2 control-label">网站链接地址</label>
                                <div class="col-sm-10">
                                    <input type="text" name="url" value="<%=msite.url %>" placeholder="网站链接地址" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">网站LOGO地址</label>
                                <div class="col-sm-10" style="min-height: 80px;">
                                    <img src="<%=msite.logo %>" class="imgpreview g10 block" style="background: #fff; border: 1px solid #d2d6de; padding: 3px;" alt="" onclick="BrowseServer('Images:/', 'txtLogo');" />
                                    <input type="hidden" name="logo" value="<%=msite.logo %>" id="txtLogo" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">语言</label>
                                <div class="col-sm-10">
                                    <select name="mylang" class="form-control" multiple="multiple">
                                        <%for (int i = 0; i < langs.Count; i++)
                                        {%>
                                        <option data-code="<%=langcodes[i] %>" <%= (( msite.lang.Split(',').Contains(langs[i])) ? "selected" : "") %> value="<%=langs[i] %>"><%=langs[i] %></option>
                                        <%  } %>
                                    </select>
                                    <input type="hidden" name="lang" value="<%=msite.lang %>" />
                                    <input type="hidden" name="langcode" value="<%=msite.langcode %>" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">网站首页标题</label>
                                <div class="col-sm-10">
                                    <input type="text" name="title" value="<%=msite.title %>" placeholder="网站首页标题" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">（请使用逗号分割）网站关键字</label>
                                <div class="col-sm-10">
                                    <input type="text" name="keywords" value="<%=msite.keywords %>" placeholder="网站关键字" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">网站描述</label>
                                <div class="col-sm-10">
                                    <textarea name="description" placeholder="网站描述" class="form-control"><%=msite.description %></textarea>
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label">公司全称</label>
                                <div class="col-sm-10">
                                    <input name="company" placeholder="公司全称" class="form-control" value="<%=msite.company %>" />
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label">网站总号码</label>
                                <div class="col-sm-10">
                                    <input name="freetele" placeholder="网站总号码" class="form-control" value="<%=msite.freetele %>" />
                                </div>
                            </div>

                            <div class="form-group" style="<%=msite.lang.Split(',').Contains("英文")?"": "display:none;" %>">
                                <label class="col-sm-2 control-label">公司简称(english)</label>
                                <div class="col-sm-10">
                                    <input type="text" name="titleen" value="<%=msite.titleen %>" placeholder="公司简称(english)" class="form-control">
                                </div>
                            </div>

                            <div class="form-group" style="<%=msite.lang.Split(',').Contains("英文")?"": "display:none;" %>">
                                <label class="col-sm-2 control-label">（请使用逗号分割）网站关键字(英文)，</label>
                                <div class="col-sm-10">
                                    <input type="text" name="keywordsen" value="<%=msite.keywordsen %>" placeholder="网站关键字(english)" class="form-control">
                                </div>
                            </div>

                            <div class="form-group" style="<%=msite.lang.Split(',').Contains("英文")?"": "display:none;" %>">
                                <label class="col-sm-2 control-label">网站描述(english)</label>
                                <div class="col-sm-10">
                                    <textarea name="descriptionen" placeholder="网站描述(english)" class="form-control"><%=msite.descriptionen %></textarea>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">网站服务邮箱</label>
                                <div class="col-sm-10">
                                    <input type="text" name="mail" value="<%=msite.mail %>" placeholder="网站服务邮箱" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">（已加密）网站服务邮箱密码</label>
                                <div class="col-sm-10">
                                    <input type="password" name="mailpwd" value="<%=msite.mailpwd %>" placeholder="网站服务邮箱密码" class="form-control">
                                    <input type="hidden" name="mailpwdHide" value="<%=msite.mailpwd %>" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">网站服务邮箱SMTP</label>
                                <div class="col-sm-10">
                                    <input type="text" name="mailsmtp" value="<%=msite.mailsmtp %>" placeholder="网站服务邮箱SMTP" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">网站服务邮箱SMTP端口</label>
                                <div class="col-sm-10">
                                    <input type="text" name="mailport" value="<%=msite.mailport %>" placeholder="网站服务邮箱SMTP端口" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="">空图片地址</label>
                                <div class="col-sm-10">
                                    <img src="<%=msite.nopic %>" class='imgpreview' style="width: 35px; height: 35px;" alt="" onclick="BrowseServer('Images:/', 'txtPic');" />
                                    <input type="hidden" value="<%=msite.nopic %>" name="nopic" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="">图片上传最大数量</label>
                                <div class="col-sm-10">
                                    <input type="text" name="picmaxlength" value="<%=msite.picmaxlength %>" placeholder="图片上传最大数量" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="">备案号</label>
                                <div class="col-sm-10">
                                    <input type="text" name="beiancode" value="<%=msite.beiancode %>" placeholder="备案号" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="">统计代码、客服代码</label>
                                <div class="col-sm-10">
                                    <textarea name="sitetrack" placeholder="统计代码、客服代码" class="form-control"><%=msite.sitetrack %></textarea>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="">（等待二次开发，nosql对象数组）联系我们</label>
                                <div class="col-sm-10">
                                    <input name="contact" value="<%=msite.contact %>" type="text" placeholder="联系我们" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="">日志存留天数</label>
                                <div class="col-sm-10">
                                    <input name="logday" value="<%=msite.logday %>" type="text" placeholder="日志存留天数" class="form-control">
                                </div>
                            </div>

                        </div>

                        <div class="callout callout-info hide" runat="server" id="txtMsg">
                            <h4><i class="icon fa fa-info"></i>保存成功</h4>
                        </div>

                        <!-- /.box-body -->
                        <div class="box-footer text-right">
                            <button class="btn btn-default" type="reset">重置</button>
                            <asp:Button CssClass="btn btn-info" ID="btnSave" OnClick="btnSave_Click" Text="保存" runat="server" />
                        </div>
                        <!-- /.box-footer -->
                    </form>
                </div>
                <!-- /.box -->
            </div>
            <!--/.col (right) -->
        </div>
        <!-- /.row -->
    </section>
    <!-- /.content -->

    <script src="/my/scripts/vendor.js"></script>
    <script src="/alte/plugins/iframeResizer/iframeResizer.contentWindow.min.js"></script>
    <script src="/alte/plugins/select2/dist/js/select2.min.js"></script>
    <script src="/my/scripts/core.js"></script>
    <script src="/my/scripts/_src/ckfiles.js"></script>

  <script>

         var mysel = $("select[name=mylang]");
        mysel.select2();

        mysel.on('select2:close', function () {
            var o = $(this);
            var olang = o.siblings('input[name=lang]');
            var olangcode = o.siblings('input[name=langcode]');
            var lis = $('.select2-selection__rendered').children('li.select2-selection__choice');
            var sb = [];
            var sbcode = [];
            lis.each(function (k, v) {
                var oo = $(this);
                sb.push(oo.attr('title'));
            });
            olang.val(sb.join(','));

            var myselops = mysel.children('option');
            myselops.each(function (item, idx) {
                var txt = $(this).attr('value');
                if (sb.indexOf(txt) > -1) {
                    sbcode.push($(this).attr('data-code'));
                }
            });

            olangcode.val(sbcode.join(','));

        });

    </script>

</body>
</html>
