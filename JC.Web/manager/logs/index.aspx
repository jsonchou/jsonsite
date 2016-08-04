<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.manager.logs.index" %>

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
                                            <th>操作人</th>
                                            <th>操作类型</th>
                                            <th>日志</th>
                                            <th>操作日期</th>
                                            <th>操作</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                    </tbody>
                                </table>
                            </div>
                            <!-- /.box-body -->
                            <!-- /.box -->

                            <div class="box-footer text-right">
                                 <input type="button" value="删除日志" class="btn btn-info" id="j_delIDlist" />
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
    <script src="/alte/plugins/datatables/jquery.dataTables.min.js"></script>
    <script src="/alte/plugins/datatables/dataTables.bootstrap.min.js"></script>
    <script src="/alte/plugins/sweetalert/sweetalert.min.js"></script>
    <script src="/my/scripts/core.js"></script>

    <script>
        var mytb = 'logs';
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
                { "data": "username" },
               {
                   "data": "logtype", render: function (data,type,row) {
                       return "<span class='fa fa-" + data.split(':')[1] + " mr5 '></span>" + data.split(':')[0];
                   }
               },
               { "data": "loginfo" },

               {
                   "data": "postdate", render: function (data, type, row) {
                       return moment(data).format('YYYY-MM-DD');
                   }
               },

                  {
                      "data": "control",
                      render: function (data, type, row) {
                          return "<a href='javascript:void(0);' data-id='" + row.id + "'  class='fa-my-controlbar fa fa-remove mr5  del'></a>";
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
