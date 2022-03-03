// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.

function filtrar_receitas()
{

    var e = document.getElementById("filtro-select");
    var opcao = e.value;

    if (isNaN(opcao)) return;

    //alert(opcao);

    debugger;

    $.ajax({
        url: '/Home/Filtrar',
        type: 'POST',
        dataType: 'json',
        data: { opcao: opcao },
        success: function (data)
        {

            debugger;

            $('#mytable tbody').empty();

            data.forEach(addRowToTable);

        },
        error: function ()
        {

        }
    });

}

function addRowToTable(row)
{
    var imagem = "<img alt='Imagem' width='100' src=" + "/images/" + row.imagem + ">";

    $("#mytable").append(
        "<tr>" +
        //"<td>" + row.id + "</td>" +
        "<td>" + row.ingredientes + "</td>" +
        "<td>" + row.preparacao + "</td>" +
        "<td>" + row.nivel_dificuldade + "</td>" +
        "<td>" + row.tempo_preparacao + "</td>" +
        "<td>" + imagem + "</td>" +
        //"<td>" + row.tipo_receita + "</td>" +
        "<td>" + row.tipo_de_receita + "</td>" +
        "<td><a href='/home/edit/" + row.id + "' class='btn'>Editar</a>" +
        "<a href='/home/details/" + row.id + "' class='btn'>Detalhes</a>" +
        "<a href='/home/delete/" + row.id + "' class='btn'>Eliminar</a>" +
        "</td>" +
        "</tr>"
    );

}
