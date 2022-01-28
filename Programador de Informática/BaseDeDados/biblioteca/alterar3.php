<!DOCTYPE html>
<html lang="pt">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="refresh" content="3;url=index.html" />
        <title>Gestão de Livros</title>
    </head>
    <body>
    <h1>Alterar Livros</h1>
    <hr>
    <?php
        $ligacao = mysqli_connect("localhost","id18241934_root","FAx1qWM)d0F^Z}5>","id18241934_biblioteca");
        if (!$ligacao)
        {
            die ("Erro na ligação" . mysql_connect_error());
        }
        $sql = "UPDATE manuais SET
        titulo='$_POST[titulo]',
        numpag='$_POST[numpag]',
        textdescr='$_POST[textdescr]',
        pesokb='$_POST[pesokb]',
        autor='$_POST[autor]'
        WHERE id =$_POST[id]";
        if (mysqli_query($ligacao, $sql))
        {
            echo "<h2>Livro Alterado com Sucesso!</h2>";
        }
        mysqli_close($ligacao);
    ?>
    <h3> Aguarde, vai ser redirecionado </h3>
    </body>
</html>