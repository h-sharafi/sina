$(document).on('click', '#CreateCategory', () => {
    $.post("/Managment/fileWork/AddFileCategoryVC", null,
        function(data, textStatus, jqXHR) {
            $('#exampleModalCenter').modal('show')
            $('#exampleModalLongTitle').text("افزودن دسته بندی فایل ")
            $('#modalBodyId').html(data);
        }, "html"
    );
})

$(document).on('click', '#submitModalId', () => {
    if ($('#Item1_Name').val() == null) {

    } else {
        $.post("/Managment/fileWork/AddFileCategory", {
                Id: $("Item1_Id").val(),
                ParentId: $('#Item1_ParentId').val(),
                Name: $('#Item1_Name').val()
            },
            function(data, textStatus, jqXHR) {
                $('#exampleModalCenter').modal('hide')
                $('#modalBodyId').html(data);
                refreshFc();
            }, "html"
        );
    }
})

$(document).on('click', '.addfc', () => {
    var parentId = $(this).data('id');
    $.post("/Managment/fileWork/AddFileCategoryVC", { parentId: parentId },
        function(data, textStatus, jqXHR) {
            $('#exampleModalCenter').modal('show')
            $('#exampleModalLongTitle').text("افزودن دسته بندی فایل ")
            $('#modalBodyId').html(data);
        }, "html"
    );
})
$(document).on('click', '.deletefc', function() {
    var fcId = $(this).data('id');
    Swal.fire({
        title: 'مطمئنید?',
        text: "فرایند زودودن بدون بازگشت است!",
        icon: 'warning',
        showCancelButton: true,
        confirmButtonColor: '#3085d6',
        cancelButtonColor: '#d33',
        confirmButtonText: 'بله!',
        cancelButtonText: 'بازگشت!'

    }).then((result) => {
        if (result.value) {
            $.post("/Managment/fileWork/DeleteFileCategory", { id: fcId },
                function(data, textStatus, jqXHR) {
                    if (data.result == true) {
                        Swal.fire(
                            ' :) ',
                            'دسته بندی فایل ها  زدوده شد',
                            'success'
                        )
                        $('#fcLi' + fcId).addClass('d-none');
                    } else {

                    }
                }, "json"
            );
            // $.ajax({
            //     type: "post",
            //     url: "/Managment/fileWork/DeleteFileCategoryAsync",
            //     data: { id: fcId },
            //     dataType: "json",
            //     success: function(response) {
            //         if (data.result == true) {
            //             Swal.fire(
            //                 ' :) ',
            //                 'دسته بندی فایل ها  زدوده شد',
            //                 'success'
            //             )
            //             $('#fcLi' + fcId).addClass('d-none');
            //         } else {

            //         }
            //     },
            //     error: function(error) {
            //         console.log(error)
            //     }
            // });
        }
    })

});

const refreshFc = () => {
    $.get("/Managment/fileWork/RefreshFc", null,
        function(data, textStatus, jqXHR) {
            $("#fcId").html(data);
        }, "html"
    );
}