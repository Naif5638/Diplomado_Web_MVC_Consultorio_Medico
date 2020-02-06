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
    var date = new Date(parseFloat(data.Fecha_Nacimiento.match(/\d+/g)));
    var day = ("0" + (date.getDate())).slice(-2);
    var month = ("0" + (date.getMonth() + 1)).slice(-2)
    //var fecha = date.getDate() + "/" + (date.getMonth() + 1) + "/" + date.getFullYear();
    fecha = date.getFullYear() + "-" + month + "-" + day;
    $("#nombres").val(data.Nombre);
    $("#apellidos").val(data.Apellido);
    $("#direccion").val(data.Direccion);
    $("#identificacion").val(data.Identificacion);
    document.getElementById("fechaNacimiento").value = fecha;
}

function Save() {
    var obj = {
        Id: document.getElementById("UserId").value,
        Nombre: document.getElementById("nombres").value,
        Apellido: document.getElementById("apellidos").value,
        Direccion: document.getElementById("direccion").value,
        Identificacion: document.getElementById("identificacion").value,
        Fecha_Nacimiento: document.getElementById("fechaNacimiento").value
    };

    var bool = confirm("Desea guardar los datos?");
    if (bool) {
        $.ajax({
            url: "/Manage/ManageUser",
            data: JSON.stringify(obj),
            type: "POST",
            contentType: "application/json; charset=utf-8",
            dataType: "json",
            success: function (result) {
                alert("Datos guardados satisfactoriamente...")
                $("#personalData").modal("hide");
            }

        });
    }
    
    console.log(document.getElementById("fechaNacimiento").value)
}