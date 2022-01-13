function DeleteConfirm(id, name) {
    $('.modal').modal({
        dismissble: true
    });
    let texto = "do contato " + name
    $(".name").text(texto);
    const url = "/Contact/Delete";
    $(".btnExcluir").on('click', function () {
        $.ajax({
            method: "POST",
            url: url,
            data: { id: id },
            success: function (data) {
                location.reload(true);
            }
        })
    })
}