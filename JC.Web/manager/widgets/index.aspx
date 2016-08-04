<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.manager.widgets.index" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title><%=msite.title %>管理后台</title>
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="stylesheet" href="/my/styles/base.css" />
    <link href="/alte/plugins/sweetalert/sweetalert.css" rel="stylesheet" />
    <link rel="stylesheet" href="/alte/plugins/datatables/dataTables.bootstrap.css">
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

                        <div class="box">
                            <!-- /.box-header -->
                            <div class="box-body">
                                <table id="j_table" class="table table-bordered table-hover">
                                    <thead>
                                        <tr>
                                            <th >
                                               <label>
                                                    <input type="checkbox" id="j_ckAll" name="ckAll" value="" />全选
                                                </label>
                                            </th>
                                            <th>ID</th>
                                            <th>模块名称</th>
                                            <th>模块图片列表</th>
                                            <th>模块内容</th>
                                            <th>模块位置</th>
                                            <th>添加日期</th>
                                            <th>有效</th>
                                            <th>新窗口打开</th>
                                            <th>操作</th>
                                        </tr>
                                    </thead>
                                </table>
                            </div>
                            <!-- /.box-body -->
                            <!-- /.box -->

                            <div class="box-footer text-right">
                                <input type="button" value="删除模块" class="btn btn-info" id="j_delIDlist" />
                                <a href="/manager/<%=mymodule %>/edit" class="btn btn-info">添加模块</a>
                            </div>

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
    <script src="/ALTE/plugins/moment/moment.min.js"></script>
    <script src="/alte/plugins/iframeResizer/iframeResizer.contentWindow.min.js"></script>
    <script src="/alte/plugins/sweetalert/sweetalert.min.js"></script>
    <script src="/alte/plugins/datatables/jquery.dataTables.min.js"></script>
    <script src="/alte/plugins/datatables/dataTables.bootstrap.min.js"></script>
    <script src="/my/scripts/core.js"></script>

    <script>

        var mytb = 'posts';
        var mymodule = '<%=mymodule %>';
        var myDataTable = null;

        $(function () {

            myDataTable = $('#j_table').DataTable({
                paging: true,
                serverSide: true,
                processing: true,//载入数据的时候是否显示“载入中”
                language: dtPKG.language,
                pageLength: 10,//首次加载的数据条数
                lengthChange: true,
                searching: true,
                ordering: false,
                info: true,
                autoWidth: false,
                columnDefs: [{
                    targets: -1,
                    data: 'control',
                    defaultContent: ""
                }],
                fields: [],
                columns: [
                    {
                        data: null,
                        render: function (data, type, row) {
                            if (type === 'display') {
                                return '<input data-id=' + row.id + ' type="checkbox" >';
                            }
                            return data;
                        },
                        className: "td-check"
                    },
               { "data": "id" },
               { "data": "title" },
               {
                   "data": "piclist", render: function (data, type, row) {
                       var sb = '';
                       //txt，link，picsrc，target，orderby
                       var arr = data.split('|');
                       for (var i = 0; i < arr.length; i++) {
                           var sub = arr[i].split(',');
                           sb += ("<a href='" + sub[1] + "' target='" + sub[3] + "' title='" + sub[0] + "' class='mr5'><img class='imgpreview' style='width:35px;height:35px;' alt='" + sub[0] + "' src='" + sub[2] + "' /></a>");
                       }
                       return sb;
                   }
               },
               { "data": "content" },//模块内容（富文本编辑器内容）
                { "data": "ext1" },//链接位置
               {
                   "data": "postdate", render: function (data, type, row) {
                       return moment(data).format('YYYY-MM-DD');
                   }
               },
               {
                   "data": "enable",//是否有效
                   render: function (data, type, row) {
                       return "<span data-flag='enable'  data-id='" + row.id + "'   data-flagcn='有效'  data-v='" + data + "'  class='fa-my-controlbar fa fa-" + (data == 1 ? "check" : "close") + "  '></span>";
                   }
               },
               {
                   "data": "blank",//新窗口打开
                   render: function (data, type, row) {
                       return "<span data-flag='blank'  data-id='" + row.id + "'   data-flagcn='新窗口'  data-v='" + data + "'  class='fa-my-controlbar fa fa-" + (data == 1 ? "check" : "close") + "  '></span>";
                   }
               }, {
                   "data": "control",
                   render: function (data, type, row) {
                       return "<a href='javascript:void(0);' data-id='" + row.id + "' class='fa-my-controlbar fa fa-remove mr5  del'></a>&nbsp;&nbsp;<a href='/manager/" + mymodule + "/edit?id=" + row.id + "' class='fa-my-controlbar fa fa-edit mr5 '></a>";
                   }
               }
                ],
                "ajax": {
                    url: '/ashx/get.ashx?moduletype=' + mymodule,
                    type: 'POST'
                },
                "drawCallback": function (settings) {
                    gImgPreview();
                    gInputCheckAll();
                    gTableAjaxControl(mytb);
                }
            });
        });
    </script>


</body>
</html>
