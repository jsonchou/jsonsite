<%@ Page  Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="JC.Web.manager.qa.edit" %>
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
                                    <label><input type="checkbox" name="ckEnable" id="ckTop"  <%=(post.enable==1)?"checked":"" %>  /> 有效</label>
                                    <input type="hidden" name="ckEnableHid" id="ckEnableHid"  value="<%=post.enable %>" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label"  >留言内容</label>
                                <div class="col-sm-10">
                                    <textarea name="title" placeholder="留言内容" class="form-control"><%=post.title %></textarea>
                                </div>
                            </div>

                              <div class="form-group">
                                <label class="col-sm-2 control-label"  >回复内容</label>
                                <div class="col-sm-10">
                                    <textarea name="content" placeholder="回复内容" class="form-control"><%=post.content %></textarea>
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" >设置成</label>
                                <div class="col-sm-10">
                                    <label><input type="checkbox" name="ckTop" id="ckTop"  <%=(post.top==1)?"checked":"" %>  /> 置顶</label>
                                    <input type="hidden" name="ckTopHid" id="ckTopHid"  value="<%=post.top %>" />
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
