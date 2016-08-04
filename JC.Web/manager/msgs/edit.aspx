<%@ Page  Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="JC.Web.manager.msgs.edit" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title><%=msite.title %>管理后台</title>
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="stylesheet" href="/my/styles/base.css" />
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
                                <label class="col-sm-2 control-label" for="ckViewed">设置成</label>
                                <div class="col-sm-10">
                                    <label><input type="checkbox" name="ckRead" id="ckRead"  <%=(post.read==1)?"checked":"" %>  /> 已查看</label>
                                    <input type="hidden" name="ckReadHid" id="ckReadHid"  value="<%=post.read %>" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtPostby">昵称</label>
                                <div class="col-sm-10">
                                    <input type="text" name="postby" value="<%=post.postby %>" placeholder="昵称" id="txtPostby" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtContent">留言内容</label>
                                <div class="col-sm-10">
                                    <textarea name="content" placeholder="留言内容" id="txtContent" class="form-control"><%=post.content %></textarea>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt1">手机号/电话号码</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext1" value="<%=post.ext1 %>" placeholder="手机号/电话号码" id="txtExt1"  class="form-control" >
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt2">邮箱</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext2" value="<%=post.ext2 %>"  placeholder="邮箱" id="txtExt2" class="form-control">
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
    <script src="/my/scripts/core.js"></script>
    
</body>
</html>
