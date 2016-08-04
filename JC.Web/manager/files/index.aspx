<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="JC.Web.manager.files.index" %>
<!DOCTYPE html>
<html>
<head>
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <title><%=msite.title %>管理后台</title>
    <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
    <link rel="stylesheet" href="/my/styles/base.css" />
    <link rel="stylesheet" href="/alte/plugins/morris/morris.css">
    <link rel="stylesheet" href="/alte/plugins/jvectormap/jquery-jvectormap-1.2.2.css">
    <link rel="stylesheet" href="/alte/plugins/datepicker/datepicker3.css">
    <link rel="stylesheet" href="/alte/plugins/daterangepicker/daterangepicker-bs3.css">
    <link rel="stylesheet" href="/alte/plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css">
    <script src="/Content/3rd/ckfinder/ckfinder.js"></script>
    <script type="text/javascript">
        var sh = document.documentElement.clientHeight;
        var finder = new CKFinder();
        finder.basePath = '/content/3rd/ckfinder/';
        finder.height = sh;
        finder.skin = 'bootstrap';
        finder.create();
</script>
</head>
<body>
    <script src="/my/scripts/vendor.js"></script>
    <script src="/alte/plugins/iframeResizer/iframeResizer.contentWindow.min.js"></script>
    <script src="/my/scripts/core.js"></script>
    <script src="/alte/dist/js/pages/dashboard.js"></script>
</body>
</html>
