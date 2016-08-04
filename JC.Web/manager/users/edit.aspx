<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="JC.Web.manager.users.edit" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title><%=msite.title %>管理后台</title>
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="stylesheet" href="/my/styles/base.css" />
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
                                <label class="col-sm-2 control-label" >设置成管理员</label>
                                <div class="col-sm-10">
                                    <label><input type="checkbox" name="isadmin" id="ckIsAdmin"  <%=(user.isadmin==1)?"checked":"" %>  /> 是</label>
                                    <input type="hidden" name="isadminHid" id="isadminHid"  value="<%=user.isadmin %>" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label" >用户名</label>
                                <div class="col-sm-10">
                                    <input type="text" name="username" value="<%=user.username %>" placeholder="用户名"  class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label" >昵称</label>
                                <div class="col-sm-10">
                                    <input type="text" name="nickname" value="<%=user.nickname %>" placeholder="昵称"  class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label"  >邮箱</label>
                                <div class="col-sm-10">
                                    <input type="text" name="email" value="<%=user.email %>" placeholder="邮箱"  class="form-control" >
                                </div>
                            </div>

                            <div class="form-group" >
                                <label class="col-sm-2 control-label"  >密码</label>
                                <div class="col-sm-10">
                                    <input type="password" name="pwd" value="<%=user.pwd %>" placeholder="密码"  class="form-control" >
                                    <input type="hidden" name="pwdHide" value="<%=user.pwd %>"  class="form-control" >
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label"  >用户头像</label>
                                <div class="col-sm-10">
                                    <div class="imgpreview-wrap">
                                        <i class="fa-my-controlbar fa fa-close "></i>
                                        <img src="<%=user.avator %>" class='imgpreview' style="width: 35px; height: 35px;" data-pic="txtAvator" onclick="BrowseServer('Images:/', 'txtAvator');" />
                                        <input type="hidden" name="avator" value="<%=user.avator %>"  />
                                    </div>
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label"  >扩展字段1</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext1" value="<%=user.ext1 %>"  placeholder="扩展字段1"  class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label"  >扩展字段2</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext2" value="<%=user.ext2 %>"  placeholder="扩展字段2"  class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label"  >扩展字段3</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext3" value="<%=user.ext3 %>"  placeholder="扩展字段3"  class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label"  >扩展字段4</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext4" value="<%=user.ext4 %>"  placeholder="扩展字段4"   class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label"  >扩展字段5</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext5" value="<%=user.ext5 %>"  placeholder="扩展字段5"  class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label"  >扩展字段6</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext6" value="<%=user.ext6 %>"  placeholder="扩展字段6"  class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label"  >扩展字段7</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext7" value="<%=user.ext7 %>"  placeholder="扩展字段7"   class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label"  >扩展字段8</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext8" value="<%=user.ext8 %>"  placeholder="扩展字段8"  class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label"  >扩展字段9</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext9" value="<%=user.ext9 %>"  placeholder="扩展字段9"   class="form-control">
                                </div>
                            </div>

                             <div class="form-group">
                                <label class="col-sm-2 control-label"  >扩展字段10</label>
                                <div class="col-sm-10">
                                    <input type="text" name="ext10" value="<%=user.ext10 %>"  placeholder="扩展字段10"  class="form-control">
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
    <script src="/my/scripts/_src/ckfiles.js"></script>
</body>
</html>
