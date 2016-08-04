if (typeof CKFinder == 'function') {
    var finder = new CKFinder();
    finder.basePath = '/content/3rd/ckfinder/';
    finder.skin = 'bootstrap';

    //ckfinder
    function BrowseServer(startupPath, functionData) {
        finder.startupPath = startupPath;
        finder.selectActionFunction = SetFileField;
        finder.selectActionData = functionData;
        finder.selectThumbnailActionFunction = ShowThumbnails;
        finder.popup();
    }

    function SetFileField(fileUrl, data) {
        document.getElementById(data["selectActionData"]).value = fileUrl;
        $('#' + data["selectActionData"]).prev('img').attr('src', fileUrl);
        gImgClose();//check close status
    }

    function ShowThumbnails(fileUrl, data) {
        var sFileName = this.getSelectedFile().name;
        document.getElementById('thumbnails').innerHTML +=
                '<div class="thumb">' +
                    '<img src="' + fileUrl + '" />' +
                    '<div class="caption">' +
                        '<a href="' + data["fileUrl"] + '" target="_blank">' + sFileName + '</a> (' + data["fileSize"] + 'KB)' +
                    '</div>' +
                '</div>';
        document.getElementById('preview').style.display = "";
        return false;
    }
   
}

if (typeof CKEDITOR == 'object') {

    /* exported initSample */
    if (CKEDITOR.env.ie && CKEDITOR.env.version < 9)
        CKEDITOR.tools.enableHtml5Elements(document);

    // The trick to keep the editor in the sample quite small
    // unless user specified own height.
    CKEDITOR.config.height = 180;
    CKEDITOR.config.width = 'auto';

    function myEditor(txtArea) {
        var txtNode = $('textarea[name="' + txtArea + '"]');
        if (txtNode.get(0)) {
            var editor = CKEDITOR.replace(txtArea);
            CKFinder.setupCKEditor(editor, '/content/3rd/ckfinder/');

            //check content changed
            editor.on('change', function (evt) {
                txtNode.val(evt.editor.getData());
            });
        }
    }

    myEditor('content');
    myEditor('contenten');

}

