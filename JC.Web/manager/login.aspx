<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="login.aspx.cs" Inherits="JC.Web.manager.login" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title><%=msite.title %>后台管理系统 | 登录</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="stylesheet" href="/my/styles/base.css">
    <!-- iCheck -->
    <link rel="stylesheet" href="/alte/plugins/iCheck/square/blue.css">

    <style>
        #tree td a img { width: 20px; }
    </style>

    <script>
        if (window.self != window.top) {
            parent.window.location.replace(window.location.href);
        }
    </script>

</head>
<body class="hold-transition login-page">
    <div class="login-box">
        <div class="login-logo">
            <a href="/"><%=msite.title %>后台管理系统</a>
        </div>
        <!-- /.login-logo -->
        <div class="login-box-body">
            <p class="login-box-msg">请登录
                <label runat="server" id="lblMsg"></label>
            </p>

            <form runat="server" method="post">
                <div class="form-group has-feedback">
                    <input type="text" runat="server" id="txtName" class="form-control" placeholder="请输入用户名/邮箱">
                    <span class="glyphicon glyphicon-envelope form-control-feedback"></span>
                </div>
                <div class="form-group has-feedback">
                    <input type="password" runat="server" id="txtPwd" class="form-control" placeholder="请输入密码">
                    <span class="glyphicon glyphicon-lock form-control-feedback"></span>
                </div>
                <div class="row">
                    <div class="col-xs-8">
                        <div class="checkbox icheck">
                            <label>
                                <asp:CheckBox runat="server" ID="ckRember" Checked="true" Text="记住我" />
                            </label>
                        </div>
                    </div>
                    <!-- /.col -->
                    <div class="col-xs-4">
                        <asp:Button ID="btnLogin" OnClick="btnLogin_Click" runat="server" Text="登录" CssClass="btn btn-primary btn-block btn-flat" />
                    </div>
                    <!-- /.col -->
                </div>

            </form>

            <!-- /.social-auth-links -->

            <a href="#">忘记密码</a><br>
        </div>
        <!-- /.login-box-body -->
    </div>
    <!-- /.login-box -->

    <script src="/my/scripts/vendor.js"></script>

    <!-- iCheck -->
    <script src="/alte/plugins/iCheck/icheck.min.js"></script>
    <script>
        $(function () {
            $('input').iCheck({
                checkboxClass: 'icheckbox_square-blue',
                radioClass: 'iradio_square-blue',
                increaseArea: '20%' // optional
            });
        });
    </script>
</body>
</html>
