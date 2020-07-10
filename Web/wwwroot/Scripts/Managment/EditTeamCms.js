function fileshow(pageIndex, pageSize, fileCategoryId, fileType, selectFileClass) {
    $.post("/Managment/Component/GetFile", {
            pageIndex: pageIndex,
            pageSize: pageSize,
            fileCategoryId: fileCategoryId,
            fileType: fileType,
            selectFileClass: selectFileClass
        },
        function(data, textStatus, jqXHR) {
            $('#fileShowId').html(data);
            $('#exampleModalCenter').modal('show')
            $('.modal-dialog').addClass('m-w-100');
            $('#exampleModalLongTitle').text("انتخاب فایل ")
            $('#modalBodyId').html(data);
        },
        "html"
    );

}


$(document).on('click', '.selectfilebtnclsschangeCategory', function() {

    var id = $(this).data('id');
    localStorage.setItem("CASFileCategoryId", id);
    // $('.selectfilebtnclsschangeCategory').removeClass('btn-success');
    // $('.selectfilebtnclsschangeCategory').removeClass('btn-outline-success');
    // $('.selectfilebtnclsschangeCategory').addClass('btn-outline-success');
    // $(this).removeClass('btn-outline-success');
    // $(this).addClass('btn-success');

    var pageIndex = 1;
    localStorage.setItem("pageIndex", Number(pageIndex));
    var pageSize = localStorage.getItem("CASpageSize");
    var fileType = "image"
    selectFileClass = "selectfilebtnclss";
    fileshow(pageIndex, pageSize, id, fileType, selectFileClass);

});

$(document).on('click', '.pageIndexClick', function(e) {
    var pageIndexClick = $(this).data('pageindex');
    localStorage.setItem("pageIndex", Number(pageIndexClick));
    var pageSize = localStorage.getItem("pageSize");
    localStorage.setItem("pageSize", Number(pageSize) + 1);
    var fileCategoryId = localStorage.getItem("FileCategoryId");
    var fileType = "image"
    let selectFileClass = "selectfilebtnclss"
    fileshow(pageIndex, pageSize, id, fileType, selectFileClass);
})

$('#formSubmitId').click(function(e) {
    e.preventDefault();
    var isValid = true;
    var errorMessage = "";
    if (!$('#BreifKnowledge')) {
        isValid = false;
        errorMessage = "توضیحات را وارد کنید";
    } else if ($('#ProfileImageId').val() == 0) {
        isValid = false;
        errorMessage = "یک تصویر انتخاب کنید";
    } else if (!$('#TeamAppUserId').val()) {
        isValid = false;
        errorMessage = "یک کاربر انتخاب کنید";
    }
    if (!isValid) {
        Swal.fire('خطا', errorMessage, 'error');
    } else {
        $('form').submit();
    }

});
// cover Image 
$(document).on('click', '#selectCoverImage', function(e) {
    e.preventDefault();
    pageIndex = 1;
    pageSize = 12;
    var fileType = "image";
    var id = null;
    fileshow(pageIndex, pageSize, id, fileType, "selectfilebtnclss");

})

//  select file 
$(document).on('click', '.selectfilebtnclss', function() {
    var id = $(this).data('id');
    $('#ProfileImageId').val(id);
    $('#exampleModalCenter').modal('hide')
    $.post("/Managment/Content/ShowCreateContentCover", { file: null, fileId: id },
        function(data, textStatus, jqXHR) {
            $('#coverImagePlcId').html(data);
        },
        "html"
    );
});
// slelect User 
$(document).on('click', '#selectUSerbtnId', function(e) {
    e.preventDefault();

    $.post("/Managment/SiteSetting/ReturnAppUSerList", null,
        function(data, textStatus, jqXHR) {

            $('#exampleModalCenter').modal('show')
            $('.modal-dialog').addClass('m-w-60');
            $('#exampleModalLongTitle').text("انتخاب کاریر ")
            $('#modalBodyId').html(data);
        },
        "html"
    );
})

$(document).on('click', '.selectUserForTeam', function(e) {
    e.preventDefault();
    var id = $(this).data('id');
    $('#TeamAppUserId').val(id);
    $('#exampleModalCenter').modal('hide')
    $.post("/Managment/SiteSetting/SHowUserInfoInTeam", { userId: id },
        function(data, textStatus, jqXHR) {
            $('#userInfoId').html(data);
        },
        "html"
    );

})