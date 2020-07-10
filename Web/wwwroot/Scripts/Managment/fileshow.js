function fileshow(pageIndex, pageSize, fileCategoryId, fileType) {
    $.post("/Managment/fileWork/GetFile", {
            pageIndex: pageIndex,
            pageSize: pageSize,
            fileCategoryId: fileCategoryId,
            fileType: fileType
        },
        function(data, textStatus, jqXHR) {
            $('#fileShowId').html(data);

        },
        "html"
    );

}
$(document).ready(function() {
    var pageIndex = localStorage.getItem("pageIndex");
    if (!pageIndex) {
        localStorage.setItem("pageIndex", 1);
        localStorage.setItem("pageSize", 12);
        $('#preveBtnId').addClass('d-none');
    } else {
        if (Number(pageIndex) == 1) {
            $('#preveBtnId').addClass('d-none');
        } else {
            $('#preveBtnId').removeClass('d-none');
        }
    }

    var pageIndex = localStorage.getItem("pageIndex");
    var pageSize = localStorage.getItem("pageSize");
    var fileCategoryId = localStorage.getItem("FileCategoryId");
    $('#sfc' + fileCategoryId).addClass('btn-success');

    fileshow(pageIndex, pageSize, fileCategoryId);

});
$('button.showToggle').on('click', function() {

    var id = $(this).data('id');
    let isShow = $(this).data('show') == 'true';
    var showdiv = '#showdiv' + id;
    var tbn = '#tbn' + id;


    if (isShow) {
        $(showdiv).removeClass();
        $(showdiv).addClass('d-none');
        $(tbn).html('<i class="fa fa-chevron-down" aria-hidden="true"></i>')
        $(tbn).addClass('btn-outline-info');
        $(tbn).removeClass('btn-outline-danger');
        $(tbn).data('show', 'false');
    } else {
        $(showdiv).removeClass();
        $(tbn).data('show', 'true');
        $(tbn).html('<i class="fa fa-chevron-up" aria-hidden="true"></i>')
        $(tbn).removeClass('btn-outline-info');
        $(tbn).addClass('btn-outline-danger');


    }
})


$('button.selectFileCategory').on('click', function() {

    var id = $(this).data('id');
    localStorage.setItem("FileCategoryId", id);
    $('.selectFileCategory').removeClass('btn-success');
    $('.selectFileCategory').addClass('btn-outline-success');
    $(this).removeClass('btn-outline-success');
    $(this).addClass('btn-success');

    var pageIndex = localStorage.getItem("pageIndex");
    var pageSize = localStorage.getItem("pageSize");
    var fileType = null
    fileshow(pageIndex, pageSize, id, fileType);

});

$(document).on('click', '.pageIndexClick', function(e) {
    var pageIndexClick = $(this).data('pageindex');
    localStorage.setItem("pageIndex", Number(pageIndexClick));
    var pageSize = localStorage.getItem("pageSize");
    var fileCategoryId = localStorage.getItem("FileCategoryId");
    var fileType = null
    fileshow(pageIndexClick, pageSize, fileCategoryId, fileType);
});