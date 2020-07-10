function fileshow(pageIndex, pageSize, fileCategoryId, fileType) {
    $.post("/Managment/Component/GetFile", {
            pageIndex: pageIndex,
            pageSize: pageSize,
            fileCategoryId: fileCategoryId,
            fileType: fileType
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

function replaceAudio(fileId) {
    $.post("/Managment/Component/AudioComponentShow", {
            fileId: fileId
        },
        function(data, textStatus, jqXHR) {
            $('#fileAudio').html(data);
        },
        "html"
    );
}
$('#selectAudioFile').click(function(e) {
    e.preventDefault();
    pageIndex = 1;
    pageSize = 12;
    localStorage.setItem('CASpageIndex', '1');
    localStorage.setItem('CASpageSize', '12');
    var fileType = "audio"
    var id = null;
    fileshow(pageIndex, pageSize, id, fileType);
});
$(document).on('click', '.selectFileCategory', function() {

    var id = $(this).data('id');
    localStorage.setItem("CASFileCategoryId", id);
    $('.selectFileCategory').removeClass('btn-success');
    $('.selectFileCategory').addClass('btn-outline-success');
    $(this).removeClass('btn-outline-success');
    $(this).addClass('btn-success');

    var pageIndex = localStorage.getItem("CASpageIndex");
    var pageSize = localStorage.getItem("CASpageSize");
    var fileType = "audio"
    fileshow(pageIndex, pageSize, id, fileType);

});

$(document).on('click', '.pageIndexClick', function(e) {
        var pageIndexClick = $(this).data('pageindex');
        localStorage.setItem("pageIndex", Number(pageIndexClick));
        var pageSize = localStorage.getItem("pageSize");
        var fileCategoryId = localStorage.getItem("FileCategoryId");
        var fileType = "audio"
        fileshow(pageIndexClick, pageSize, fileCategoryId, fileType);
    })
    // select File Audio 
$(document).on('click', '.selectfilebtnclss', function() {
    var id = $(this).data('id');
    $('#FileId').val(id);
    $('#exampleModalCenter').modal('hide')
    replaceAudio(id);
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

// delete AusioCms


$(document).on('click', '.deleteAudio', function(e) {
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

            $.post("/Managment/Component/DeleteAudioCms", { "id": id }, function(data, textStatus, jqXHR) {
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

$(document).on('click', '.deleteTeamId', function(e) {
    e.preventDefault();
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

            $.post("/Managment/SiteSetting/Delete", { "id": id }, function(data, textStatus, jqXHR) {
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
})