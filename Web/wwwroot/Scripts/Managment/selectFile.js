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

$(document).on('click', '.pageIndexClick', function(e) {
    var pageIndexClick = $(this).data('pageindex');
    localStorage.setItem("pageIndex", Number(pageIndexClick));
    var pageSize = localStorage.getItem("pageSize");
    var fileCategoryId = localStorage.getItem("FileCategoryId");
    var fileType = "image";
    let selectFileClass = "selectfilebtnclss"
    fileshow(pageIndexClick, pageSize, fileCategoryId, fileType, selectFileClass);
})


//==================================================== انتخاب لوگو های سایت
// انتخاب لوگو
$(document).on('click', '#selectCoverImage', function(e) {
    e.preventDefault();
    var type = $(this).data('type');
    $('#typeId').val(type);
    pageIndex = 1;
    pageSize = 12;
    var fileType = "image";
    let selectFileClass = "selectfilebtnclss"
    var id = null;
    fileshow(pageIndex, pageSize, id, fileType, selectFileClass);

})

$(document).on('click', '.selectfilebtnclss', function() {
    var id = $(this).data('id');
    let type = $('#typeId').val();
    $('#exampleModalCenter').modal('hide')
    $.post("/Managment/SiteSetting/ReturnLogoImage", { file: null, fileId: id, typeId: type },
        function(data, textStatus, jqXHR) {

            if (type == 'selectLogobtnId') {
                $('#selectLogobtnId').html(data);
                $('#SiteLogoId').val(id);
            } else if (type == 'selectFooterLogobtnId') {
                $('#selectFooterLogobtnId').html(data);
                $('#FooterLogoId').val(id);
            } else {
                $('#faviconbtnId').html(data);
                $('#FavIconId').val(id);
            }

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

//==================================================== اسلایدر اصلی
// MainSlider 

// رفرش اسلایدر اصلی
function RefreshMainSlider() {
    $.post("/Managment/SiteSetting/RefreshMainSideBar", null,
        function(data, textStatus, jqXHR) {
            $('#mainSliderPlc').html(data);
        },
        "html"
    );
}
//افزودن فایل به اسلایدر اصلی 
function addFileToSlider(id) {
    $.post("/Managment/SiteSetting/AddFileToSlider", { id: id },
        function(data, textStatus, jqXHR) {
            if (data.result) {
                RefreshMainSlider();
                Swal.fire('', 'افزودن فایل به اسلایدر با موفقیت انجام شد', 'success');
            }
        },
        "json"
    );
}
// افزودن فایل به اسلایدر 
$(document).on('click', '#addSliderFileId', function(e) {
    e.preventDefault();
    pageIndex = 1;
    pageSize = 12;
    var fileType = "image";
    let selectFileClass = "addFileToSliderCls"
    var id = null;
    fileshow(pageIndex, pageSize, id, fileType, selectFileClass);
})

$(document).on('click', '.addFileToSliderCls', function(e) {
    e.preventDefault();
    var id = $(this).data('id');
    $('#exampleModalCenter').modal('hide')
    addFileToSlider(id);
});
// انتخاب دسته بندی اسلایدر
$(document).on('click', '.addFileToSliderClschangeCategory', function() {

    var id = $(this).data('id');

    localStorage.setItem("CASFileCategoryId", id);
    $('.addFileToSliderClschangeCategory').removeClass('btn-success');
    $('.addFileToSliderClschangeCategory').addClass('btn-outline-success');
    $(this).removeClass('btn-outline-success');
    $(this).addClass('btn-success');

    var pageIndex = localStorage.getItem("CASpageIndex");
    var pageSize = localStorage.getItem("CASpageSize");
    var fileType = "image"
    let selectFileClass = "addFileToSliderCls"
    fileshow(pageIndex, pageSize, id, fileType, selectFileClass);

});
//حذف فایل از اسلایدر
$(document).on('click', '.deleteSliderFileCls', function(e) {
    e.preventDefault();
    var id = $(this).data('id');
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

            $.post("/Managment/SiteSetting/DeleteSliderFile", { id: id },
                function(data, textStatus, jqXHR) {
                    if (data.result) {
                        RefreshMainSlider();
                        Swal.fire('', 'افزودن به زباله دان با موفقیت انجام شد', 'error');
                    }
                },
                "json"
            );
        }
    })


})