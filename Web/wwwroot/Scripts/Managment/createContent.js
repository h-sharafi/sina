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
// log


function replaceLogo(fileId) {
    $.post("/Managment/Component/ImageComponentShow", {
            fileId: fileId
        },
        function(data, textStatus, jqXHR) {
            $('#coverPlaceId').html(data);
        },
        "html"
    );
}

// cover Image 
//========================================================انتخاب فایل مودال
$(document).on('click', '#selectcoverImagePlcId', function(e) {
    e.preventDefault();
    pageIndex = 1;
    pageSize = 12;
    var fileType = "image"
    let selectFileClass = "selectfilebtnclss"
    var id = null;
    fileshow(pageIndex, pageSize, id, fileType, selectFileClass);

});
//  select file 
$(document).on('click', '.selectfilebtnclss', function() {
    var id = $(this).data('id');
    $('#CoverImageId').val(id);
    $('#exampleModalCenter').modal('hide')
    $.post("/Managment/Content/ShowCreateContentCover", { file: null, fileId: id },
        function(data, textStatus, jqXHR) {
            $('#coverImagePlcId').html(data);
        },
        "html"
    );
});

$(document).on('click', '.selectfilebtnclsschangeCategory', function() {

    var id = $(this).data('id');

    localStorage.setItem("CASFileCategoryId", id);
    $('.selectFileCategory').removeClass('btn-success');
    $('.selectFileCategory').addClass('btn-outline-success');
    $(this).removeClass('btn-outline-success');
    $(this).addClass('btn-success');

    var pageIndex = 1;
    var pageSize = 12;
    var fileType = "image"
    let selectFileClass = "selectfilebtnclss"
    fileshow(pageIndex, pageSize, id, fileType, selectFileClass);

});
//====================================================== انتخاب تصویر پروفایل 
$(document).on('click', '#selectprofileImagePlcId', function(e) {
    e.preventDefault();
    pageIndex = 1;
    pageSize = 12;
    var fileType = "image"
    let selectFileClass = "selectProfilebtnclss"
    var id = null;
    fileshow(pageIndex, pageSize, id, fileType, selectFileClass);

});
//  select file 
$(document).on('click', '.selectProfilebtnclss', function() {
    var id = $(this).data('id');
    $('#ProfileImageId').val(id);
    $('#exampleModalCenter').modal('hide')
    $.post("/Managment/Content/ShowCreateContentCover", { file: null, fileId: id },
        function(data, textStatus, jqXHR) {
            $('#profileImagePlcId').html(data);
        },
        "html"
    );
});

$(document).on('click', '.selectProfilebtnclsschangeCategory', function() {

    var id = $(this).data('id');

    localStorage.setItem("CASFileCategoryId", id);
    $('.selectFileCategory').removeClass('btn-success');
    $('.selectFileCategory').addClass('btn-outline-success');
    $(this).removeClass('btn-outline-success');
    $(this).addClass('btn-success');

    var pageIndex = 1;
    var pageSize = 12;
    var fileType = "image"
    let selectFileClass = "selectProfilebtnclss"
    fileshow(pageIndex, pageSize, id, fileType, selectFileClass);

});
// ===================================================== افزودن نوع محتوا 
$(document).on('click', '#addConetntType', () => {
    $.post("/Managment/Content/CreateContentTypePartial", null,
        function(data, textStatus, jqXHR) {
            $('#exampleModalCenter').modal('show')
            $('#exampleModalLongTitle').text("افزودن نوع محتوا")
            $('#modeDialog').removeClass('m-w-100')
            $('#modeDialog').addClass('m-w-60')
            $('#modalBodyId').html(data);
        }, "html"
    );
});
$(document).on('click', '.changeContentTypeActive', function() {
    var contentTypeId = $(this).data('id');
    $.post("/Managment/Content/ChangeContentTypeActive", { id: contentTypeId },
        function(data, textStatus, jqXHR) {
            if (data.result) {
                var isActive = data.isActive;
                $('#changeContentTypeActiveId' + contentTypeId).html(isActive ?
                    "<button class='btn btn-outline-success changeContentTypeActive' data-id=" + contentTypeId + "><i class='fa fa-eye' aria-hidden='true'></i></button>" :
                    "<button class='btn btn-outline-danger changeContentTypeActive' data-id= " + contentTypeId + "><i class='fa fa-eye-slash' aria-hidden='true'></i></button>");
            }
        }, "json"
    );
})
$(document).on('click', '#submitModalId', () => {
    let value = $('#contentTypeNameId').val();
    if (value !== null) {
        var isMainPage = $('#idMainPageId').val();
        $.post("/Managment/Content/AddConetntType", { "name": value, "isMainPage": isMainPage }, function(data, textStatus, jqXHR) {
            $('#closeModal').click();
            $('#contentType').html(data);
        }, "html");
    } else {
        alert("وارد کن")
    }
});

$(document).on('click', '.selectContentType', (e) => {
    let ctId = e.target.dataset.id;
    $('#ContentTypeId').attr("value", ctId);
    $.post("/Managment/Content/SetActiveContentType", { "id": ctId }, function(data, textStatus, jqXHR) {
        $('#contentType').html(data);
    }, "html");
});

// form submit 
$('#formSumbitId').click((e) => {
    e.preventDefault();
    let categoryId = $('#ContentTypeId').val();
    var isValid = true;
    var errorMessage = "";
    if (!$('#Name').val()) {
        isValid = false;
        errorMessage = "یک نام انتخاب کنید"
    } else if (!$('#Title').val()) {
        isValid = false;
        errorMessage = "عنوان را وارد کنید"
    } else if (!CKEDITOR.instances["description"].getData()) {
        isValid = false;
        errorMessage = "محتوا بدون متن می باشد"
    } else if (!$('#Description').val()) {
        isValid = false;
        errorMessage = "توضیحات را وارد کنید"
    } else if (categoryId == "0") {
        isValid = false;
        errorMessage = "یک دسته بندی اینتخاب کنید"
    }
    if (!isValid) {
        Swal.fire('خطا', errorMessage, 'error');
    } else {
        $('#createContentFormId').submit();
    }

})