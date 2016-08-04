<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.manager.caches.index" %>

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
                                <label class="col-sm-3 control-label" for="ckViewed">回收站点配置信息</label>
                                <div class="col-sm-9">
                                    <asp:Button CssClass="btn btn-info" runat="server" ID="btnSite" OnClick="btnSite_Click" Text="清除缓存"></asp:Button>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-3 control-label" for="ckViewed">回收Session信息（重新登录）</label>
                                <div class="col-sm-9">
                                    <asp:Button CssClass="btn btn-info" runat="server" ID="btnSession" OnClick="btnSession_Click" Text="清除缓存"></asp:Button>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-3 control-label" for="ckViewed">回收Cookie信息（重新登录）</label>
                                <div class="col-sm-9">
                                    <asp:Button CssClass="btn btn-info" runat="server" ID="btnCookie" OnClick="btnCookie_Click" Text="清除缓存"></asp:Button>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-3 control-label" for="ckViewed">回收Cache信息（重新登录）</label>
                                <div class="col-sm-9">
                                    <asp:Button CssClass="btn btn-info" runat="server" ID="btnCache" OnClick="btnCache_Click" Text="清除缓存"></asp:Button>
                                </div>
                            </div>


                              <div class="form-group">
                                <label class="col-sm-3 control-label" for="ckViewed">清空全部缓存</label>
                                <div class="col-sm-9">
                                    <asp:Button CssClass="btn btn-info" runat="server" ID="btnAll" OnClick="btnAll_Click" Text="清空全部缓存"></asp:Button>
                                </div>
                            </div>

                        </div>

                        <div class="callout callout-info hide" runat="server" id="txtMsg">
                            <h4><i class="icon fa fa-info"></i>清除成功</h4>
                        </div>


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
