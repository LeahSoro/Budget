$(function () {
    $("#addstore").on('click', function () {
        $("#store-name").val('');
        $(".modal").modal();


    });
    $(".submit").on('click', function () {
        $.post('/home/addstore',
        { store: $("#store-name").val() }, function () {

            $(".modal").modal('hide');
        });
    });

});