<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="main.aspx.cs" Inherits="JC.Web.manager.main" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title>首页</title>
    <!-- Tell the browser to be responsive to screen width -->
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="stylesheet" href="/my/styles/base.css" />
</head>
<body>
    <!-- Main content -->
    <section class="content">
        <!-- Small boxes (Stat box) -->
        <div class="row" id="j_shortcut">
            <div class="col-lg-2 col-xs-6">
                <!-- small box -->
                <div class="small-box bg-aqua">
                    <a href="/manager/msgs" >
                        <div class="inner">
                            <h3><%=msgsUnread %>/<%=msgsAll %></h3>
                            <p>未读留言</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-file-text"></i>
                        </div>
                        <span class="small-box-footer">更多 <i class="fa fa-arrow-circle-right"></i></span>
                    </a>
                </div>
            </div>
            <!-- ./col -->
            <div class="col-lg-2 col-xs-6">
                <!-- small box -->
                <div class="small-box bg-green">
                    <a href="/manager/news">
                        <div class="inner">
                            <h3><%=newsAll %></h3>
                            <p>新闻</p>
                        </div>
                        <div class="icon">
                            <i class="fa fa-newspaper-o"></i>
                        </div>
                        <span class="small-box-footer">更多 <i class="fa fa-arrow-circle-right"></i></span>
                    </a>
                </div>
            </div>
            <!-- ./col -->
            <div class="col-lg-2 col-xs-6">
                <!-- small box -->
                <div class="small-box bg-yellow">
                    <a href="/manager/cases">
                    <div class="inner">
                        <h3><%=casesAll %></h3>
                        <p>案例</p>
                    </div>
                    <div class="icon">
                        <i class="fa fa-briefcase"></i>
                    </div>
                    <span class="small-box-footer">更多 <i class="fa fa-arrow-circle-right"></i></span>
                        </a>
                </div>
            </div>
            <!-- ./col -->
            <div class="col-lg-2 col-xs-6">
                <!-- small box -->
                <div class="small-box bg-red">
                    <a href="/manager/huifang">
                    <div class="inner">
                         <h3><%=huifangAll %></h3>
                        <p>回访</p>
                    </div>
                    <div class="icon">
                        <i class="fa fa-suitcase"></i>
                    </div>
                    <span  class="small-box-footer">更多 <i class="fa fa-arrow-circle-right"></i></span>
                        </a>
                </div>
            </div>
            <!-- ./col -->

              <!-- ./col -->
            <div class="col-lg-2 col-xs-6">
                <!-- small box -->
                <div class="small-box bg-maroon">
                    <a href="/manager/users">
                    <div class="inner">
                         <h3><%=usersAdmin %>/<%=usersAll %></h3>
                        <p>管理员</p>
                    </div>
                    <div class="icon">
                        <i class="ion ion-person-add"></i>
                    </div>
                    <span class="small-box-footer">更多 <i class="fa fa-arrow-circle-right"></i></span>
                        </a>
                </div>
            </div>
            <!-- ./col -->

              <!-- ./col -->
            <div class="col-lg-2 col-xs-6">
                <!-- small box -->
                <div class="small-box bg-teal">
                    <a href="/manager/friendlinks">
                    <div class="inner">
                         <h3><%=friendlinksAll %></h3>
                        <p>友情链接</p>
                    </div>
                    <div class="icon">
                        <i class="fa fa-link"></i>
                    </div>
                    <span class="small-box-footer">更多 <i class="fa fa-arrow-circle-right"></i></span>
                        </a>
                </div>
            </div>
            <!-- ./col -->
             
        </div>
        <!-- /.row -->
        <!-- /.row (main row) -->

    </section>
    <!-- /.content -->

    <script src="/my/scripts/vendor.js"></script>
    <script src="/alte/plugins/iframeResizer/iframeResizer.contentWindow.min.js"></script>
    <script src="/my/scripts/core.js"></script>
    <script src="/alte/dist/js/pages/dashboard.js"></script>

    <script>
        var sba = $('#j_shortcut').find('.small-box').children('a');
        sba.on('click', function () {
            var o = $(this);
            var ohref = o.attr('href');
            var winp = window.parent;
            if (winp) {
                var lis = $(winp.document).find('.sidebar').find(".treeview[data-href='" + ohref + "']");
                lis.trigger('click');
            }
        });
    </script>

</body>
</html>
