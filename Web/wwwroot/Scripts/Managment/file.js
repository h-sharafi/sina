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
    $('#FileCategoryId').val(id);
    $('.selectFileCategory').removeClass('btn-success');
    $('.selectFileCategory').addClass('btn-outline-success');
    $(this).removeClass('btn-outline-success');
    $(this).addClass('btn-success');
});
$('#formSubmit').click((e) => {
    e.preventDefault();
    var formValid = true;
    var formError = null;
    var file = $('#FormFile')[0];
    if ($('#FileCategoryId').val() == 0) {
        formValid = false;
        formError = 'یک دسته بندی انتخاب کنید'

    } else if (!file || file.files.length == 0) {
        formValid = false;
        formError = 'فایل انتخاب کنید'
    }
    if (!formValid) {
        Swal.fire('خطا', formError, 'error');
    } else {
        debugger

        $(form).submit();
    }
});


// Code to get duration of audio /video file before upload - from: https://coursesweb.net/

//register canplaythrough event to #audio element to can get duration
var f_duration = 0; //store duration
document.getElementById('audio').addEventListener('canplaythrough', function(e) {
    //add duration in the input field #f_du
    f_duration = Math.round(e.currentTarget.duration);
    $('#Duration').val(f_duration);
    URL.revokeObjectURL(obUrl);
});

//when select a file, create an ObjectURL with the file and add it in the #audio element
var obUrl;
document.getElementById('FormFile').addEventListener('change', function(e) {
    var file = e.currentTarget.files[0];
    //check file extension for audio/video type
    if (file.name.match(/\.(avi|mp3|mp4|mpeg|ogg)$/i)) {
        obUrl = URL.createObjectURL(file);
        document.getElementById('audio').setAttribute('src', obUrl);
    }
});