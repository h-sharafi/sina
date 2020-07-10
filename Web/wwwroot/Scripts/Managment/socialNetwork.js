// لود کردن مودال
function CreateOrEditSocialNetwork(id, teamId) {
    $.post("/Managment/SiteSetting/CreateOrEditSocialNetwork", {
            id: id,
            teamId: teamId
        },
        function(data, textStatus, jqXHR) {
            $('#fileShowId').html(data);
            $('#exampleModalCenter').modal('show');
            $('.modal-dialog').addClass('m-w-60');
            $('#exampleModalLongTitle').text(id == 0 ? "ویرایش شبکه اجتماعی" : "ساخت شبکه اجتماعی");
            $('#modalBodyId').html(data);
        },
        "html"
    );

}
// افزودن لیست و ویرایش ویو کامپوننت 
function CreateOrEditSocialNetworkSubmit(id, siteSettingId, teamId, name, address, faClass) {
    $.post("/Managment/SiteSetting/SubmitCreateOrEditScoialNetwork", {
            id: id,
            siteSettingId: siteSettingId,
            teamId: teamId,
            name: name,
            address: address,
            faClass: faClass
        },
        function(data, textStatus, jqXHR) {
            $('#socialPlaceId').html(data);
        },
        "html"
    );

}
// رفرش کردن وی کامپوننت لیست 
function RefreshSocialViewComponent(teamId) {
    $.post("/Managment/SiteSetting/RefreshSocialViewComponent", {
            teamId: teamId,
        },
        function(data, textStatus, jqXHR) {
            $('#socialPlaceId').html(data);
        },
        "html"
    );

}

// افزودن شبکه اجتماعی
$(document).on('click', '#createScoialNetworkId', function(e) {
    e.preventDefault();
    var teamId = $(this).data('id');
    var id = 0;
    CreateOrEditSocialNetwork(id, teamId);
})
$(document).on('click', '.editSocialNetwork', function(e) {
    e.preventDefault();
    var teamId = null;
    var id = $(this).data('id');
    CreateOrEditSocialNetwork(id, teamId);
});
// فعال  شبکه اجتماعی
$(document).on('click', '.activeSocialNetwork', function(e) {
    var id = $(this).data('id');
    var teamId = $(this).data('teamid');
    $.post("/Managment/SiteSetting/ActiveOrDeActiveSN", {
            id: id,
        },
        function(data, textStatus, jqXHR) {
            if (data.result) {
                RefreshSocialViewComponent(teamId);
            }
        },
        "json"
    );
});
$(document).on('click', '#submitModalId', function(e) {
    e.preventDefault();
    var siteSettingId = $('#SiteSettingId').val();
    var teamId = $('#TeamId').val();
    var id = $('#SocialNetworkId').val();
    var name = $('#SocialNetName').val();
    var address = $('#Address').val();
    var faClass = $('#FaClass').val();

    var formValid = true;
    var errorMessage = "";

    if (!name) {
        formValid = false;
        errorMessage = "نام را وارد کنید";
    } else if (!address) {
        formValid = false;
        errorMessage = "آدرس را وارد کنید";
    } else if (!faClass) {
        formValid = false;
        errorMessage = "کلاس فو ایکون را وارد کنید";
    }
    if (formValid) {
        Swal.fire("oops", 'success', 'success');
        $('#exampleModalCenter').modal('hide');
        CreateOrEditSocialNetworkSubmit(id, siteSettingId, teamId, name, address, faClass)
    } else {
        Swal.fire("oops", errorMessage, 'error');
    }
})

// Remove SocialNetwork
$(document).on('click', '.deleteSocialNetwork', function(e) {
    e.preventDefault();
    var id = $(this).data('id');
    var teamId = $(this).data('teamid');
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

            $.post("/Managment/SiteSetting/DeleteSocialNetwork", { "id": id }, function(data, textStatus, jqXHR) {
                if (data.result) {
                    $('#listTr' + id).addClass('d-none');

                    RefreshSocialViewComponent(teamId);
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