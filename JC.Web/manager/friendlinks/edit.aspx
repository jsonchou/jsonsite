<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="JC.Web.manager.friendlinks.edit" %>
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
                                <label class="col-sm-2 control-label" for="ckEnable">设置成</label>
                                <div class="col-sm-10">
                                    <label>
                                        <input type="checkbox" name="enable" id="enable" <%=(post.enable==1)?"checked":"" %> />有效</label>
                                    <input type="hidden" name="enableHid" id="enableHid" value="<%=post.enable %>" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="ckViewed">设置成</label>
                                <div class="col-sm-10">
                                    <label>
                                        <input type="checkbox" name="blank" <%=(post.blank==1)?"checked":"" %> />新窗口打开</label>
                                        <input type="hidden" name="blankHid" id="blankHid" value="<%=(post.blank==1)?"1":"0" %>" />
                                </div>
                            </div>
                             
                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt3">链接位置</label>
                                <div class="col-sm-2">
                                    <select name="ext3" class="form-control">
                                        <%for (int i = 0; i < pos.Count; i++){%>
                                        <option <%= (pos[i] == post.ext3 ? "selected" : "") %> value="<%=pos[i] %>"><%=pos[i] %></option>
                                        <%  } %>
                                    </select>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" >关键字（SEO）</label>
                                <div class="col-sm-10">
                                    <input type="text" name="keywords" value="<%=post.keywords %>" placeholder="关键字（SEO）" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" >链接地址</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext1" value="<%=post.ext1 %>" placeholder="链接地址" class="form-control"   />
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtPic">图片</label>
                                <div class="col-sm-10">
                                    <div class="imgpreview-wrap">
                                        <i class="fa-my-controlbar fa fa-close "></i>
                                        <img src="<%=post.pic %>" class='imgpreview' style="width: 35px; height: 35px;"  alt="" onclick="BrowseServer('Images:/', 'txtPic');" />
                                        <input type="hidden" name="pic" value="<%=post.pic %>" id="txtPic" />
                                    </div>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" >联系人信息（QQ，邮箱）</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext2" value="<%=post.ext2 %>" placeholder="联系人信息（QQ，邮箱）"  class="form-control" >
                                </div>
                            </div>
                             
                            <div class="form-group">
                                <label class="col-sm-2 control-label" >排序</label>
                                <div class="col-sm-10">
                                    <input type="text" name="orderby" value="<%=post.orderby %>" placeholder="排序"  class="form-control" >
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
        $("select[name='ext3']").select2();
    </script>
</body>
</html>
