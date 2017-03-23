//this script reset modal each time when you click on the link:
try {
    $(function () {
        $(".modal-link").click(function (event) {
            event.preventDefault();
            $('#myModal').removeData("modal");
            $('#myModal').modal({ remote: $(this).attr("href") });

        });
    });
}
    catch (e) {
        alert(e);
    }

//define o css de todos os botões de Detalhes do grid.
try {
    $(function () {
        $("tr.grid-row").each(function () {
            var tr = $(this);
            var rows = $(tr).children();
            $(rows[13]).css({ "background-color": "#ffffff", "border-color": "#000000" });
            $(rows[13].setAttribute("class", "btn btn-default"));
            $(rows[13].setAttribute("position", "relative"));
        })
    });
}
catch (e) {
    //alert(e);
}

caminho = document.getElementById("supergrid");

//Faz a soma da coluna 11 e a soma da coluna 4, checando o campo 12, automaticamente e atualiza no final.
try {
    $("tr.grid-row").change(function () {

        $("#resultados").slideDown();
        var soma1 = 0.00;
        var soma2 = 0.00;
        $("tr.grid-row").each(function () {
            var tr = $(this);
            var rows = $(tr).children();

            if (rows[12].getElementsByTagName("input")[0].checked) {

                var valor1 = rows[8].innerHTML;
                var valor2 = rows[9].innerHTML;
                valor1 = valor1.replace(",", ".");
                valor2 = valor2.replace(",", ".");
                valor1 = parseFloat(valor1);
                valor2 = parseFloat(valor2);
                //confirm(valor1);
                soma1 += valor1;
                soma2 += valor2;
            }
        });

        soma1 = soma1.toFixed(2);
        soma2 = soma2.toFixed(2);

        //Aparece cada uma das somas no final do grid.
        //var trTotal = "<tr><td></td><td></td><td></td><td style='color:red;font-weight:bold;'>" + soma + "</td><td></td><td></td></tr>"
        //$("tr.grid-row:last").after(trTotal);

        $("#soma1Total").html("<b>Total</b> <font color='Blue'>Saldo Contábil Devedor:</font> <font style='color:black; font-family:Arial; font-style:normal;'>R$ <b>" + soma1.replace(".", ",") + "</b></font>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;-");
        $("#soma2Total").html("<b>Total</b> <font color='Blue'>Saldo Gerencial:</font> <font style='color:black; font-family:Arial; font-style:normal;'>R$ <b>" + soma2.replace(".", ",") + "</b></font>");

        if (soma1 == 0 && soma2 == 0)
            $("#resultados").fadeOut();
    });
}
catch (e) {
    //alert(e);
}

//Retira o class do botão Detalhes e deixa ele mais bonito".
try {
    caminho.getElementsByTagName("thead")[0]
    .getElementsByTagName("div")[24]
    .getElementsByTagName("span")[0]
    .setAttribute("class", " ");
}
catch (e) {
    //alert(e);
}

//Se os filtros não encontrarem nada imprime a mensagem em português (Não é pela pesquisa do topo da página é pela pesquisa feita nos filtros das colunas!).
//try
//{
//    local = caminho.getElementsByTagName("tbody")[0].getElementsByTagName("tr")[0];
//    if (local.getAttribute("class") == "grid-empty-text") {
//        local.innerHTML = "<td colspan='14'>Nenhum item encontrado</td>";
//    }
//}
//catch(e)
//{
//    //alert(e);
//}

//Traduz o tooltip do filtro da coluna de "Filter this column" para português e coloca o nome da coluna.
try {
    for (i = 1; i <= caminho.getElementsByTagName("span").length - 3; i++) {
        caminho.getElementsByTagName("div")[i * 2]
            .getElementsByTagName("span")[0]
            .setAttribute("title", "Filtrar a coluna " + caminho.getElementsByTagName("div")[i * 2 + 1].textContent + " !");
    }
}
catch (e) {
    //alert(e);
}

