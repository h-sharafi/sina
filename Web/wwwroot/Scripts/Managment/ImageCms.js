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

function replaceImage(fileId) {
    $.post("/Managment/Component/ImageComponentShow", {
            fileId: fileId
        },
        function(data, textStatus, jqXHR) {
            $('#coverPlaceId').html(data);
        },
        "html"
    );
}
$('#selectCoverImage').click(function(e) {
    e.preventDefault();
    pageIndex = 1;
    pageSize = 12;
    localStorage.setItem('CASpageIndex', '1');
    localStorage.setItem('CASpageSize', '12');
    var fileType = "image"
    var id = null;
    let selectFileClass = "selectfilebtnclss"
    fileshow(pageIndex, pageSize, id, fileType, selectFileClass);
});
// انتخاب دسته بندی
$(document).on('click', '.selectfilebtnclsschangeCategory', function() {

    var id = $(this).data('id');
    localStorage.setItem("CASFileCategoryId", id);
    $('.selectfilebtnclsschangeCategory').removeClass('btn-success');
    $('.selectfilebtnclsschangeCategory').addClass('btn-outline-success');
    $(this).removeClass('btn-outline-success');
    $(this).addClass('btn-success');

    var pageIndex = 1;
    var pageSize = 12;
    localStorage.setItem("pageIndex", Number(pageIndex));
    var fileType = "image"
    let selectFileClass = "selectfilebtnclss"
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


// انتخاب تصویر به عنوان کاور 
$(document).on('click', '.selectfilebtnclss', function() {
    var id = $(this).data('id');
    $('#FileId').val(id);
    $('#exampleModalCenter').modal('hide')
    replaceImage(id);
});
$('#formSubmit').click(function(e) {
    e.preventDefault();
    var isValid = true;
    var errorMessage = "";
    if ($('#FileId').val() == 0) {
        isValid = false;
        errorMessage = "یک فایل انتخاب کنید";
    } else if (!$('#Name').val()) {
        isValid = false;
        errorMessage = "نام را وارد کنید";
    }
    if (!isValid) {
        Swal.fire('خطا', errorMessage, 'error');
    } else {
        $('#form').submit();
    }

});

function copyToClipboard(element) {
    var $temp = $("<input>");
    $("body").append($temp);
    $temp.val($(element).text()).select();
    document.execCommand("copy");
    $temp.remove();
    Swal.fire('', 'کپی شد', 'success');
}
$('#audiocopybtn').click(function() {
    copyToClipboard('#p1');
});

$('.copyAudio').click(function() {
    var id = $(this).data('id');
    copyToClipboard('#p' + id);
})

// delete ImageCms


$(document).on('click', '.deleteImage', function(e) {
    let id = $(this).data('id');
    Swal.fire({
        title: 'آیا مطمئن هستین',
        text: "فرایند حذف قابل برگشت نیست",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله ، حذف کن',
        cancelButtonText: 'برگشت',
    }).then((result) => {
        if (result.value) {

            $.post("/Managment/Component/DeleteImageCms", { "id": id }, function(data, textStatus, jqXHR) {
                if (data.result) {
                    $('#listTr' + id).addClass('d-none')
                    Swal.fire(
                        'Deleted!',
                        'عملیات حذف با موفقیت انجام شد',
                        'success'
                    )
                } else {
                    Swal.fire(
                        'Deleted!',
                        'یک خطا در هنگام حذف به وجود آمد',
                        'error'
                    )
                }
            }, "json");
        }
    })



});

// // cover Image 

// $(document).on('click', '#selectCoverImage', function(e) {
//     e.preventDefault();
//     pageIndex = 1;
//     pageSize = 12;
//     var fileType = "image";
//     var id = null;
//     fileshow(pageIndex, pageSize, id, fileType);

// })

// //  select file 
// $(document).on('click', '.selectfilebtnclss', function() {
//     var id = $(this).data('id');
//     $('#FileId').val(id);
//     $('#exampleModalCenter').modal('hide')
//     $.post("/Managment/Content/ShowCreateContentCover", { file: null, fileId: id },
//         function(data, textStatus, jqXHR) {
//             $('#coverImagePlcId').html(data);
//         },
//         "html"
//     );
// });