<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.manager.index" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title><%=msite.title %>管理后台</title>
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <!-- build:css /my/styles/base.css -->
    <link rel="stylesheet" href="../alte/bootstrap/css/bootstrap.min.css">
    <link rel="stylesheet" href="../alte/plugins/font-awesome/css/font-awesome.min.css">
    <link rel="stylesheet" href="../alte/plugins/ionicons/css/ionicons.min.css">
    <link rel="stylesheet" href="../alte/dist/css/AdminLTE.min.css">
    <link rel="stylesheet" href="../alte/dist/css/skins/_all-skins.css">
    <link rel="stylesheet" href="../alte/plugins/iCheck/flat/blue.css">
    <!-- endbuild -->
</head>
<body class="hold-transition skin-blue sidebar-mini" style="overflow-x:hidden;max-height:100%;">
    <div class="wrapper">

        <header class="main-header">
            <!-- Logo -->
            <a href="/manager/" class="logo">
                <!-- mini logo for sidebar mini 50x50 pixels -->
                <span class="logo-mini"><b><%=msite.title.Substring(0,1) %></b><%=msite.title.Substring(1) %></span>
                <!-- logo for regular state and mobile devices -->
                <span class="logo-lg"><b><%=msite.title %></b>管理后台</span>
            </a>
            <!-- Header Navbar: style can be found in header.less -->
            <nav class="navbar navbar-static-top">
                <!-- Sidebar toggle button-->
                <a href="#" class="sidebar-toggle" data-toggle="offcanvas" role="button">
                    <span class="sr-only">切换导航</span>
                </a>

                <div class="navbar-custom-menu">
                    <ul class="nav navbar-nav">
                        <!-- Messages: style can be found in dropdown.less-->
                         
                        <!-- Notifications: style can be found in dropdown.less -->
                        <li class="dropdown notifications-menu">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                <i class="fa fa-envelope-o"></i>
                                <%if(msgUnRead>0) { %>
                                <span class="label label-warning"><%=msgUnRead %></span>
                                <% }%>
                            </a>
                            <ul class="dropdown-menu" id="j_shortcutTop">
                                <li class="header">你有<%=msgUnRead %>条通知</li>
                                <li>
                                    <!-- inner menu: contains the actual data -->
                                    <ul class="menu">
                                        
                                        <%if(msgUnRead>0) { %>
                                        <li>
                                            <a class="my-trigger" href="/manager/msgs">
                                                <i class="fa fa-users text-red"></i> <%=msgUnRead %>条未读留言
                                            </a>
                                        </li>
                                        <%} %>

                                    </ul>
                                </li>
                            </ul>
                        </li>
                        <!-- Tasks: style can be found in dropdown.less -->
                         
                        <!-- User Account: style can be found in dropdown.less -->
                        <li class="dropdown user user-menu">
                            <a href="#" class="dropdown-toggle" data-toggle="dropdown">
                                <img src="<%=muser.avator %>" class="user-image" alt="User Image">
                                <span class="hidden-xs"><%=muser.username %></span>
                            </a>
                            <ul class="dropdown-menu">
                                <!-- User image -->
                                <li class="user-header">
                                    <img src="<%=muser.avator %>" class="img-circle" alt="User Image">

                                    <p>
                                        <%=muser.username %>
                                        <small>自<b><%=muser.postdate %></b>，登录了<b><%=muser.logtime %></b>次</small>
                                    </p>
                                </li>
                                <!-- Menu Body -->
                                <!-- Menu Footer-->
                                <li class="user-footer">
                                    <div class="pull-left">
                                        <a href="/manager/users/edit?id=<%=muser.id %>" target="_blank" class="btn btn-default btn-flat">个人信息</a>
                                    </div>
                                    <div class="pull-right">
                                        <a href="/manager/logout" class="btn btn-default btn-flat">退出</a>
                                    </div>
                                </li>
                            </ul>
                        </li>
                        <!-- Control Sidebar Toggle Button -->
                        <li>
                            <a href="#" data-toggle="control-sidebar"><i class="fa fa-gears"></i></a>
                        </li>
                    </ul>
                </div>
            </nav>
        </header>
        <!-- Left side column. contains the logo and sidebar -->
        <aside class="main-sidebar">
            <!-- sidebar: style can be found in sidebar.less -->
            <section class="sidebar">
                <!-- Sidebar user panel -->
                <div class="user-panel">
                    <div class="pull-left image">
                        <img src="<%=muser.avator %>" class="img-circle" alt="User Image">
                    </div>
                    <div class="pull-left site">
                        <p><%=muser.username %></p>
                        <a href="#"><i class="fa fa-circle text-success"></i> 在线</a>
                    </div>
                </div>
                <!-- sidebar menu: : style can be found in sidebar.less -->
                <ul class="sidebar-menu">
                    <li class="header">主菜单</li>
                </ul>
            </section>
            <!-- /.sidebar -->
        </aside>

        <!-- Content Wrapper. Contains page content -->
        <div class="content-wrapper">
            <div class="content-wrapper-main" id="j_ContentWrapperMain">
                <div class="content-wrapper-main-menu clearfix">
                    <span class="fl arrow arrow-left slick-prev slick-arrow"><i class="fa fa-angle-double-left "></i></span>
                    <span class="fr arrow arrow-right slick-next slick-arrow"><i class="fa fa-angle-double-right "></i></span>
                    <div class="menu-list clearfix" id="j_menuList">
                        <div data-id="0" data-href="/manager/main" class="item on"><span>首页</span></div>
                    </div>
                </div>

                <div class="content-wrapper-main-center">
                    <div class="content-wrapper-main-item content-wrapper-main-item-off">
                        <div class="content-loader"><span class="fa fa-spinner"></span></div>
                        <div class="content-main">
                            <section class="content-header"><h1>快速入口<small></small></h1><ol class="breadcrumb"><li><a href="#"><i class="fa fa-dashboard"></i> 首页</a></li><li class="active">快速入口</li></ol></section>
                            <section class="content"><iframe frameborder="0" src="/manager/main"></iframe></section>
                        </div>
                    </div>
                </div>

            </div>
        </div>
        <!-- /.content-wrapper -->
        <footer class="main-footer hide">
            <div class="pull-right hidden-xs">
                <b>Version</b> 2.3.3
            </div>
                Copyright &copy; 2014-2016
                reserved.
        </footer>

        <!-- Control Sidebar -->
        <aside class="control-sidebar control-sidebar-dark">
            <!-- Create the tabs -->
            <ul class="nav nav-tabs nav-justified control-sidebar-tabs">
                <li><a href="#control-sidebar-home-tab" data-toggle="tab"><i class="fa fa-gears"></i></a></li>
            </ul>
            <!-- Tab panes -->
            <div class="tab-content">
                <!-- Home tab content -->
                <div class="tab-pane" id="control-sidebar-home-tab">
                    <h3 class="control-sidebar-heading">最近操作</h3>
                    <ul class="control-sidebar-menu">
                        <%var colors =new List<string>() { "bg-red", "bg-yellow", "bg-aqua", "bg-blue", "bg-light-blue", "bg-green", "bg-navy", "bg-teal", "bg-olive", "bg-lime", "bg-orange", "bg-fuchsia", "bg-purple", "bg-maroon", "bg-black" }; %>
                        <%for (int i = 0; i < loglist.Count; i++)
                            {%>
                         <li>
                            <a href="javascript:void(0)">
                                <i class="menu-icon fa fa-<%=loglist[i].logtype.Split(':')[1] %> <%=colors[i] %> mr5"></i>
                                <div class="menu-site">
                                    <h4 class="control-sidebar-subheading"><%=loglist[i].loginfo %></h4>
                                    <p><%=string.Format("{0:yyyy-MM-dd HH:mm:ss}",loglist[i].postdate) %></p>
                                </div>
                            </a>
                        </li>
                          <%  } %>
                    </ul>
                    <!-- /.control-sidebar-menu -->

                    <!-- /.control-sidebar-menu -->

                </div>
                
            </div>
        </aside>
        <!-- /.control-sidebar -->
        <!-- Add the sidebar's background. This div must be placed
             immediately after the control sidebar -->
        <div class="control-sidebar-bg"></div>
    </div>
    <!-- ./wrapper -->

    <script src="/my/scripts/vendor.js"></script>

    <script src="../alte/plugins/iframeresizer/iframeresizer.min.js"></script>

    <!--菜单滚动插件-->
    <script src="../alte/plugins/slick/slick.min.js"></script>
    <!--邮件菜单插件-->
    <script src="../alte/plugins/smartmenu/jquery-smartmenu-min.js"></script>
    <!--模拟滚动条插件-->
    <script src="../alte/plugins/slimScroll/jquery.slimscroll.min.js"></script> 
   
    <!-- build:js /my/scripts/core.js -->
    <script src="../my/scripts/_src/util.js"></script>
    <script src="../alte/dist/js/app.min.js"></script>
    <script src="../alte/dist/js/demo.js"></script>
    <script src="../my/scripts/_src/common.js"></script>
    <!-- endbuild -->

    <!--main.js 外围iframeJS-->

    <!-- build:js /my/scripts/main.js -->
    <script src="../my/scripts/_src/main.js"></script>
    <!-- endbuild -->

</body>
</html>
