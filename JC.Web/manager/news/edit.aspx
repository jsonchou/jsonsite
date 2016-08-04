<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="JC.Web.manager.news.edit" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title><%=msite.title %>管理后台</title>
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="stylesheet" href="/my/styles/base.css" />
    <link rel="stylesheet" href="/alte/plugins/datepicker/datepicker3.css">
    <link href="/alte/plugins/select2/dist/css/select2.css" rel="stylesheet" />
    <link href="/alte/plugins/select2/dist/css/select2-bootstrap.min.css" rel="stylesheet" />
    <script src="/content/3rd/ckeditor/ckeditor.js"></script>
    <script src="/content/3rd/ckeditor/config.js"></script>
    <script src="/content/3rd/ckfinder/ckfinder.js"></script>
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
                                <label class="col-sm-2 control-label">设置成</label>
                                <div class="col-sm-10">
                                    <label>
                                        <input type="checkbox" name="enable" id="enable" <%=(post.enable==1)?"checked":"" %> />有效</label>
                                    <input type="hidden" name="enableHid" id="enableHid" value="<%=post.enable %>" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">所属分类</label>

                                <div class="col-sm-2">
                                    <select name="select-sub-0" data-parentid="0" class="form-control" <%= !string.IsNullOrEmpty(mymenuid)?"disabled":"" %>>
                                        <option value="-1">请选择</option>
                                        <%
                                            var unitModelSingle = singleMenus(0);
                                            for (int i = 0; i < unitModelSingle.Count; i++)
                                            { %>
                                        <option <%=(!string.IsNullOrEmpty(mypath)&&mypath.Trim('-').Split('-')[0]==unitModelSingle[i].id.ToString())?"selected":"" %> data-path="<%=unitModelSingle[i].path %>" value="<%=unitModelSingle[i].id %>"><%=unitModelSingle[i].title %></option>
                                        <%  } %>
                                    </select>
                                </div>

                                <%if (!string.IsNullOrEmpty(mypath)){ %>
                                <%
                                    var arr = mypath.Trim('-').Split('-');
                                    for (int m = 0; m < arr.Length; m++)
                                    {%>
                                 <%if (arr[m] != mymenuid)
                                { %>
                                
                                    
                                         <% var unitModel = singleMenus(int.Parse(arr[m]));%>
                                        <%if(unitModel.Count>0) {%>
                                        <div class="col-sm-2">
                                        <select name="select-sub-<%=arr[m] %>" data-parentid="<%=arr[m] %>" class="form-control" <%= !string.IsNullOrEmpty(mymenuid)?"disabled":"" %> >
                                        <option value="-1">请选择</option>
                                         <% for (int i = 0; i < unitModel.Count; i++){%>
                                        <option <%=(mypath.IndexOf(unitModel[i].path)>-1)?"selected":"" %> value="<%=unitModel[i].id %>"><%=unitModel[i].title %></option>
                                        <%  } %>
                                        </select>
                                            </div>
                                        <%  } %>
                                    
                                
                                <%} %>
                                <%} %>
                                <%} %>

                                <input type="hidden" value="<%=mypath %>" name="path" />
                                <input type="hidden" value="<%=myparentid %>" name="parentid" />

                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label"  >标题</label>
                                <div class="col-sm-10">
                                    <input type="text" name="title" value="<%=post.title %>" placeholder="标题"  class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label"  >关键字（SEO）</label>
                                <div class="col-sm-10">
                                    <input type="text" name="keywords" placeholder="关键字（SEO）"  class="form-control" value="<%=post.keywords %>" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label"  >简述（SEO）</label>
                                <div class="col-sm-10">
                                     <textarea name="description" placeholder="简述（SEO），为空将自动从内容里截取"   class="form-control"><%=post.description %></textarea>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label"  >内容</label>
                                <div class="col-sm-10">
                                    <textarea name="content" placeholder="内容"  class="form-control"><%=post.content %></textarea>
                                </div>
                            </div>

                            <div class="form-group" style="<%=msite.lang.Split(',').Contains("英文")?"": "display:none;" %>">
                                <label class="col-sm-2 control-label"  >标题英文</label>
                                <div class="col-sm-10">
                                    <input type="text" name="titleen" placeholder="标题英文"  class="form-control" value="<%=post.titleen %>">
                                </div>
                            </div>

                            <div class="form-group" style="<%=msite.lang.Split(',').Contains("英文")?"": "display:none;" %>">
                                <label class="col-sm-2 control-label"  >关键字英文</label>
                                <div class="col-sm-10">
                                    <input type="text" name="keywordsen" placeholder="关键字英文"  class="form-control" value="<%=post.keywordsen %>" />
                                </div>
                            </div>

                            <div class="form-group" style="<%=msite.lang.Split(',').Contains("英文")?"": "display:none;" %>">
                                <label class="col-sm-2 control-label"  >简述（SEO）英文</label>
                                <div class="col-sm-10">
                                    <input type="text" name="descriptionen" placeholder="简述（SEO）英文，为空将自动从内容里截取"  class="form-control" value="<%=post.descriptionen %>" />
                                </div>
                            </div>

                            <div class="form-group" style="<%=msite.lang.Split(',').Contains("英文")?"": "display:none;" %>">
                                <label class="col-sm-2 control-label"  >内容英文</label>
                                <div class="col-sm-10">
                                    <textarea name="contenten" placeholder="内容英文" class="form-control"><%=post.contenten %></textarea>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label"  >(建议尺寸660*400)封面图片</label>
                                <div class="col-sm-10">
                                    <div class="imgpreview-wrap">
                                        <i class="fa-my-controlbar fa fa-close "></i>
                                        <img src="<%=post.pic %>" class='imgpreview' style="width: 35px; height: 35px;" alt="" onclick="BrowseServer('Images:/', 'txtPic');" />
                                        <input type="hidden" name="pic" value="<%=post.pic %>" id="txtPic" />
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" >点击量</label>
                                <div class="col-sm-10">
                                    <input name="hit" placeholder="点击量" id="txtHit" class="form-control" value="<%=post.hit %>" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label"  >设置成</label>
                                <div class="col-sm-10">
                                    <label>
                                        <input type="checkbox" name="ckTop" id="ckTop" <%=(post.top==1)?"checked":"" %> />
                                        置顶</label>
                                    <input type="hidden" name="ckTopHid" id="ckTopHid" value="<%=post.top %>" />

                                    <label>
                                        <input type="checkbox" name="ckHot" id="ckHot" <%=(post.hot==1)?"checked":"" %> />
                                        热门</label>
                                    <input type="hidden" name="ckHotHid" id="ckHotHid" value="<%=post.hot %>" />

                                    <label>
                                        <input type="checkbox" name="ckIntro" id="ckIntro" <%=(post.intro==1)?"checked":"" %> />
                                        推荐</label>
                                    <input type="hidden" name="ckIntroHid" id="ckIntroHid" value="<%=post.intro %>" />
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
    <script src="/alte/plugins/datepicker/bootstrap-datepicker.js"></script>
    <script src="/alte/plugins/select2/dist/js/select2.min.js"></script>
    <script src="/my/scripts/core.js"></script>
    <script src="/my/scripts/_src/ckfiles.js"></script>

    <script>

        $('.datepicker').datepicker({
            autoclose: true,
            format: 'yyyy-mm-dd'
        });

        var mytablename = '<%=mytablename%>';
        var mypathNode = $('input:hidden[name=path]');
        var myparentidNode = $('input:hidden[name=parentid]');

        function _unitSelect(selname) {
            var mysel = $("select[name=" + selname + "]");
            mysel.select2();

            mysel.on('select2:close', function () {
                var o = $(this);
                var sels = $('select[name^=select-sub-]');

                //fix path
                var sb = [];
                sels.each(function () {
                    var oo = $(this);
                    var oov = oo.val();
                    if (oov == -1) {
                        oov = '';
                    } else {
                        oov = '-' + oov;
                    }
                    sb.push(oov);
                });
                mypathNode.val(sb.join('') + '-');

                //fix parentid

                var pathArr = _util.string.trim(mypathNode.val(), '-').split('-');
                var pathLes = pathArr.length;

                myparentidNode.val(pathLes == 1 ? "0" : pathArr[pathLes - 2]);
            });

            mysel.on('change', function () {
                var o = $(this);
                var op = o.parents('.col-sm-2');
                var opnext = op.nextAll('.col-sm-2').remove();//移除后续节点
                var opid = op.children('select').val();

                $.ajax({
                    url: '/ashx/cascadingmenu.ashx',
                    type: 'post',
                    dataType: 'json',
                    cache: true,
                    data: { id: opid, module: mytablename },
                    success: function (res) {
                        if (res) {
                            if (res.data && res.data.length) {
                                var sb = [];
                                sb.push("<select class='form-control' name='select-sub-" + opid + "' data-parentid='" + opid + "'><option value='-1'>请选择</option>");
                                res.data.forEach(function (item, idx) {
                                    sb.push("<option value='" + item.id + "'>" + item.title + "</option>");
                                });
                                sb.push("</select>");
                                op.after("<div class='col-sm-2'>" + sb.join('') + "</div>");

                                _unitSelect('select-sub-' + opid);

                            }
                        }
                    }
                });

            });

        }

        //select 初始化
        var sels = $('select[name^=select-sub-]');
        sels.each(function (k, v) {
            var oo = $(this);
            var ooname = oo.attr('name');
            _unitSelect(ooname);
        });

    </script>

</body>
</html>