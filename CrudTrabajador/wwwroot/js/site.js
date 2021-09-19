// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.




$("body").on("click", "a.newTrabajador-dialog-window", null, function (e) {
    e.preventDefault();
    var $link = $(this);
    var url = $(this).attr('href');
    if (url.indexOf('#') == 0) {
        $('#NewTrabaj').modal('show');
    }
    else {
        $.get(url, function (info) {
            $('#NewTrabaj .cuerpoTrabaModal').html(info);
            $('#NewTrabaj').modal();
        }).success(function (){});
    }
});

$("body").on("click", "a.EditarTrabajador-dialog-window", null, function (e) {
    e.preventDefault();
    var $link = $(this);
    var url = $(this).attr('href');
    if (url.indexOf('#') == 0) {
        $('#EditTrabaj').modal('show');
    }
    else {
        $.get(url, function (info) {
            $('#EditTrabaj .cuerpoEditTrabaModal').html(info);
            $('#EditTrabaj').modal();
        }).success(function (){});
    }
});



$("body").on("click", "a.ElimiTrabajador-dialog-window", null, function (e) {
    e.preventDefault();
    var $link = $(this);
    var url = $(this).attr('href');
    if (url.indexOf('#') == 0) {
        $('#ElimiTrabaj').modal('show');
    }
    else {
        $.get(url, function (info) {
            $('#ElimiTrabaj .cuerpoElimiTrabaModal').html(info);
            $('#ElimiTrabaj').modal();
        }).success(function (){});
    }
});


function CerarDelete() {
    $('#ElimiTrabaj').modal('hide');
}


