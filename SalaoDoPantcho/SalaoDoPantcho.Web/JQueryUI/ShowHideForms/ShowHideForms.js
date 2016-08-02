$(document).ready(function () {
    $("#MostrarfrmRecuperacao").click(MostrarfrmRecuperacao);
    $("#MostrarfrmLogin").click(MostrarfrmLogin);
});

function MostrarfrmRecuperacao() {
    $("#frmLogin").hide(1000);
    $("#frmRecuperacao").show(1000);
}
function MostrarfrmLogin() {
    $("#frmRecuperacao").hide(1000);
    $("#frmLogin").show(1000);
}