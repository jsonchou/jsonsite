<%@ Page  Language="C#" AutoEventWireup="true" CodeBehind="ext.aspx.cs" Inherits="JC.Web.manager.sites.ext" %>
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
                                <label class="col-sm-2 control-label" for="txtExt1">扩展字段1</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext1" value="<%=msite.ext1 %>"  placeholder="扩展字段1" id="txtExt1" class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt2">扩展字段2</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext2" value="<%=msite.ext2 %>"  placeholder="扩展字段2" id="txtExt2" class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt3">扩展字段3</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext3" value="<%=msite.ext3 %>"  placeholder="扩展字段3" id="txtExt3" class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt4">扩展字段4</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext4" value="<%=msite.ext4 %>"  placeholder="扩展字段4" id="txtExt4" class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt5">扩展字段5</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext5" value="<%=msite.ext5 %>"  placeholder="扩展字段5" id="txtExt5" class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt6">扩展字段6</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext6" value="<%=msite.ext6 %>"  placeholder="扩展字段6" id="txtExt6" class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt7">扩展字段7</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext7" value="<%=msite.ext7 %>"  placeholder="扩展字段7" id="txtExt7" class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt8">扩展字段8</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext8" value="<%=msite.ext8 %>"  placeholder="扩展字段8" id="txtExt8" class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt9">扩展字段9</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext9" value="<%=msite.ext9 %>"  placeholder="扩展字段9" id="txtExt9" class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" for="txtExt10">扩展字段10</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext10" value="<%=msite.ext10 %>"  placeholder="扩展字段10" id="txtExt10" class="form-control">
                                </div>
                            </div>

                        </div>
                       
                         <div class="callout callout-info hide" runat="server" id="txtMsg">
                            <h4><i class="icon fa fa-info"></i>保存成功</h4>
                        </div>

                        <!-- /.box-body -->
                        <div class="box-footer text-right">

                            <button class="btn btn-default" type="reset">重置</button>
                            <asp:Button CssClass="btn btn-info" ID="btnSave" OnClick="btnSave_Click"  Text="保存" runat="server" />
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
