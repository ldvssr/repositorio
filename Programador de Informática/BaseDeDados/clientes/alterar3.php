<!DOCTYPE html>
<html lang="pt">
    <head>        
        <meta charset="utf-8">
        <meta http-equiv="refresh" content="3;url=index.html" />
        <title>Gestão de Clientes</title>
    </head>
    <body>
    <h1>Alterar Clientes</h1>
    <br>
    <?php

        $ligacao = mysqli_connect("127.0.0.1","root","12345","0001");

        if (!$ligacao)
        {
            die ("Erro na ligação" . mysql_connect_error());
        }

        $sql = "UPDATE t_cliente SET
        nome='$_POST[nome]',
        morada='$_POST[morada]',
        zona='$_POST[zona]',
        nif='$_POST[nif]',
        vol_fatur=$_POST[vol_fatur]
        WHERE id =$_POST[id]";

        if (mysqli_query($ligacao, $sql))
        {
            echo "<h2>Cliente Alterado com Sucesso!</h2>";
        }

        mysqli_close($ligacao);

    ?>
    <h3> Aguarde, vai ser redirecionado </h3>
    </body>
</html>