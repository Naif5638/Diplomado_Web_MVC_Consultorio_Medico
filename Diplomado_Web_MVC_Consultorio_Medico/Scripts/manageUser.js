function ManageUser() {
    $.ajax({
        url: "/Manage/ManageUser",
        type: "GET",
        dataType: "json",
        contentType: "application/json; charset=utf-8",
        success: function (result) {
            console.log(result);
            LoadUser(result.data);
        }


    })
}

function LoadUser(data) {
    $("#nombres").val(data.Nombre);
    $("#apellidos").val(data.Apellido);
    $("#direccion").val(data.Direccion);
    $("#identificacion").val(data.Identificacion);
    $("#fechaNacimiento").val(Date(data.Fecha_Nacimiento));

    console.log(Date(data.Fecha_Nacimiento))
}