<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.manager.menus.index" %>

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
                                            <th><label><input type='checkbox' name='ckAll' id='j_ckAll' />全选</label></th>
                                            <th>ID</th>
                                            <th>父级ID</th>
                                            <th>标签名称</th>
                                            <th>标题</th>
                                            <th>内容</th>
                                            <th>图片</th>
                                            <th>排序</th>
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
    <script src="/alte/plugins/iframeResizer/iframeResizer.contentWindow.min.js"></script>
    <script src="/alte/plugins/datatables/jquery.dataTables.min.js"></script>
    <script src="/alte/plugins/datatables/dataTables.bootstrap.min.js"></script>
    <script src="/alte/plugins/sweetalert/sweetalert.min.js"></script>
    <script src="/my/scripts/core.js"></script>

    <script>

        var mytb = 'menus';
        var mymodule = '<%=mymodule %>';
        var paths = [];
        var myDataTable = null;

        $(function () {

            myDataTable = $('#j_table').DataTable({
                paging: true,
                serverSide: true,
                processing: true,//载入数据的时候是否显示“载入中”
                language: dtPKG.language,
                pageLength: 100,//首次加载的数据条数
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
                createdRow: function (row, data, index) {
                    row.className = (data.parentid == 0 ? "td-stem-root" : "td-stem-sub");
                }, columns: [
                    {
                        data: null,
                        render: function (data, type, row) {
                            if (type === 'display') {
                                return '<input data-id=' + row.id + ' type="checkbox" >';
                            }
                            return data;
                        },
                        className: 'td-check'
                    },
               { "data": "id" },
               {
                   "data": "parentid", render: function (data, type, row) {
                       return wrapNode(row.path) + data;
                   }
               },
               {
                   "data": "linktag", render: function (data, type, row) {
                       return wrapNode(row.path) + data;
                   }
               },
               {
                   "data": "title", render: function (data, type, row) {
                       return wrapNode(row.path) + data;
                   }
               },
               {
                   "data": "content", render: function (data, type, row) {
                       return wrapNode(row.path) + data;
                   }
               },
                {
                    "data": "pic",render: function (data, type, row) {
                        return wrapNode(row.path) + "<img class='imgpreview' style='width:35px;height:35px;' src='" + data + "' />";
                    }
                },
               {
                   "data": "orderby", render: function (data, type, row) {
                       return wrapNode(row.path) + data;
                   }
               },
               {
                   "data": "control",render: function (data, type, row) {
                       return "<a href='javascript:void(0);' data-id='" + row.id + "'  class='fa-my-controlbar fa fa-remove mr5  del'></a>&nbsp;&nbsp;<a href='/manager/" + mymodule + "/edit?id=" + row.id + "' class='fa-my-controlbar fa fa-edit mr5 '></a>&nbsp;&nbsp;" + (row.haschild == 1 ? "<a href='javascript:void(0);' class='fa-my-controlbar fa fa-angle-double-down td-fold mr5 pointer'>展开</a>" : "");
                   }
               }
                ],
                "ajax": {
                    url: '/ashx/get.ashx?moduletype=' + mymodule + '&id=<%=mymoduleid%>',
                    type: 'POST'
                },
                "drawCallback": function (settings) {
                    gImgPreview();
                    gInputCheckAll();
                    gTableFold();
                    gTableAjaxControl(mytb);
                }
            });
        });

        function wrapNode(path) {
            if (path) {
                path = _util.string.trim(path, '-');
                var len = path.split('-').length;
                if (len >= 2) {
                    var sb = [];
                    for (var i = 0; i < len; i++) {
                        if (i === 0) {
                            continue;
                        }
                        else if (i === 1) {
                            sb.push("<img src='/content/base/node.png' />");
                        } else {
                            sb.push("<img src='/content/base/line.png' />");
                        }
                    }
                    return sb.join('');
                }
                return '';
            }
            return '';
        }

    </script>


</body>
</html>
