<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="edit.aspx.cs" Inherits="JC.Web.manager.widgets.edit" %>

<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title><%=msite.title %>管理后台</title>
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="stylesheet" href="/my/styles/base.css" />
    <link href="/alte/plugins/select2/dist/css/select2.css" rel="stylesheet" />
    <link href="/alte/plugins/select2/dist/css/select2-bootstrap.min.css" rel="stylesheet" />
    <script src="/content/3rd/ckeditor/ckeditor.js"></script>
    <script src="/content/3rd/ckeditor/config.js"></script>
    <script src="/content/3rd/ckfinder/ckfinder.js"></script>
    <style>
        .txt{border:none}
    </style>
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
                                <label class="col-sm-2 control-label">设置成</label>
                                <div class="col-sm-10">
                                    <label>
                                        <input type="checkbox" name="blank" <%=(post.blank==1)?"checked":"" %> />新窗口打开</label>
                                    <input type="hidden" name="blankHid" id="blankHid" value="<%=(post.blank==1)?"1":"0" %>" />
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">设置成</label>
                                <div class="col-sm-10">
                                    <label>
                                        <input type="checkbox" name="enable" id="enable" <%=(post.enable==1)?"checked":"" %> />有效</label>
                                    <input type="hidden" name="enableHid" id="enableHid" value="<%=post.enable %>" />
                                </div>
                            </div>

                              <div class="form-group">
                                <label class="col-sm-2 control-label">模块位置</label>
                                <div class="col-sm-2">
                                    <select name="ext1" class="form-control">
                                        <%for (int i = 0; i < pos.Count; i++){%>
                                        <option <%= (pos[i] == post.ext1 ? "selected" : "") %> value="<%=pos[i] %>"><%=pos[i] %></option>
                                        <%  } %>
                                    </select>
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">模块名称</label>
                                <div class="col-sm-10">
                                    <input type="text" name="title" value="<%=post.title %>" placeholder="模块名称" class="form-control">
                                </div>
                            </div>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">模块内容</label>
                                <div class="col-sm-10">
                                    <textarea name="content" placeholder="模块内容" class="form-control"><%=post.content %></textarea>
                                </div>
                            </div>

                            <%----------------------------------------------%>
                            <%-- txt，link，picsrc，target，orderby--%>
                            <%----------------------------------------------%>

                            <div class="form-group">
                                <label class="col-sm-2 control-label">模块图片列表</label>
                                <div class="col-sm-10">
                                    <% 
                                        string[] plist = null;
                                        plist = post.piclist != msite.nopic ? post.piclist.Split('|') : null;

                                        for (int i = 0; i < msite.picmaxlength; i++)
                                        {%>
                                    <%if (plist!=null&&(plist.Length > i) && !string.IsNullOrEmpty(plist[i]))
                                        {%>
                                    <%if (plist[i].Split(',').Length == 5)
                                        { %>
                                    <div class="form-control mb5" style="height: 48px;">
                                        <div class="imgpreview-wrap">
                                            <i class="fa-my-controlbar fa fa-close "></i>
                                            <img src="<%=plist[i].Split(',')[2] %>" class='imgpreview' style="width: 35px; height: 35px;"  alt="" onclick="BrowseServer('Images:/', 'txtPicList<%=i + 1 %>');" />
                                            <input type="hidden" value="<%=plist[i].Split(',')[2] %>" name="piclist<%=i + 1 %>" id="txtPicList<%=i + 1 %>" />
                                        </div>
                                        <input type="text" style="width: 40%" value="<%=plist[i].Split(',')[0] %>" name="piclist<%=i + 1 %>txt" placeholder="请输入图片标题" class="txt"/>
                                        <input type="text" style="width: 40%" value="<%=plist[i].Split(',')[1] %>" name="piclist<%=i + 1 %>link" placeholder="请输入链接地址" class="txt" />
                                        <input type="text" style="width: 65px;" name="piclist<%=i + 1 %>orderby" value="<%=plist[i].Split(',')[4] %>" placeholder="排序" class="txt" />
                                        <label>
                                            <input type="checkbox" <%=(plist[i].Split(',')[3] == "_blank") ? "checked" : "" %> name="piclist<%=i + 1 %>target" />
                                            <input type="hidden" name="piclist<%=i + 1 %>targetHid" id="piclist<%=i + 1 %>targetHid" value="<%=(plist[i].Split(',')[3] == "_blank") ? "1" : "0" %>" />
                                            新窗口打开</label>
                                    </div>
                                    <% } %>
                                    <% }
                                        else
                                        {%>
                                    <div class="form-control mb5" style="height: 48px;">
                                        <div class="imgpreview-wrap">
                                            <i class="fa-my-controlbar fa fa-close "></i>
                                            <img src="<%=msite.nopic %>" class='imgpreview' style="width: 35px; height: 35px;"  alt="" onclick="BrowseServer('Images:/', 'txtPicList<%=i+1 %>');" />
                                            <input type="hidden" value="<%=msite.nopic %>" name="piclist<%=i+1 %>" id="txtPicList<%=i+1 %>" />
                                        </div>
                                        <input type="text" style="width: 40%" value="" name="piclist<%=i+1 %>txt" placeholder="请输入图片标题" class="txt"/>
                                        <input type="text" style="width: 40%" value="" name="piclist<%=i+1 %>link" placeholder="请输入链接地址" class="txt"/>
                                        <input type="text" style="width: 65px;" value="<%=i+1+100 %>" name="piclist<%=i + 1 %>orderby" placeholder="排序值" class="txt" />
                                        <label>
                                            <input type="checkbox" name="piclist<%=i+1 %>target" checked />
                                            <input type="hidden" name="piclist<%=i+1 %>targetHid" id="piclist<%=i+1 %>targetHid" value="1" />
                                            新窗口打开</label>
                                    </div>
                                    <% } %>
                                    <% } %>
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
    <script src="/alte/plugins/select2/dist/js/select2.min.js"></script>
    <script src="/my/scripts/core.js"></script>
    <script src="/my/scripts/_src/ckfiles.js"></script>
    <script>
        $("select[name='ext1']").select2();
    </script>
</body>
</html>
