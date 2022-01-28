<!DOCTYPE html>
<html lang="pt">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="refresh" content="3;url=index.html" />
        <title>Gestão de Livros</title>
    </head>
    <body>
        <h1>Eliminar Livros</h1>
        <hr>
        <?php
            $cp_id=$_POST['cp_id'];
            $ligacao = mysqli_connect("localhost","id18241934_root","FAx1qWM)d0F^Z}5>","id18241934_biblioteca");
            if ($ligacao->connect_error)
            {
                die(mysqli_error($ligacao));
            }
            $sql = "DELETE FROM manuais WHERE id=".$cp_id;
            if (mysqli_query($ligacao, $sql))
            {
                echo "<h2>Livro Eliminado com Sucesso!</h2>";
            }
            else
            {
                echo "Erro! " . mysqli_error($ligacao);
            }
            mysqli_close($ligacao);
        ?>
        <p>
            <h2> Aguarde, vai ser redirecionado </h2>
        <!-- <input type="button" value="Voltar ao Menu" onclick="window.history.go(-1);"> -->
        <!-- <a href="index.html" target="_self">Gestão de Livros</a><br><br> -->
        <br>
    </body>
</html>