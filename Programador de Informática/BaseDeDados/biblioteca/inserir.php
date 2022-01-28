<!DOCTYPE html>
<html lang="pt">
    <head>
        <meta charset="utf-8">
        <title>Gestão de Livros</title>
        <meta http-equiv="refresh" content="3;url=index.html">
    </head>
    <body>
        <h1>Inserir Livros</h1>
        <hr>      
        <?php
            $ligacao = mysqli_connect("localhost","id18241934_root","FAx1qWM)d0F^Z}5>","id18241934_biblioteca");
            if ($ligacao->connect_error)
                die(mysqli_error($ligacao));
            //if(trim($_POST['numpag'])==NULL && $_POST['pesokb']==NULL && $_POST['autor']==NULL)
            //{
            //    $sql = "INSERT INTO manuais (titulo, numpag, textdescr, pesokb, autor) VALUES
            //    ('$_POST[titulo]','$_POST[numpag]','$_POST[textdescr]','$_POST[pesokb]','$_POST[autor]')";
            //}
            //else
            //{
                $sql = "INSERT INTO manuais (titulo, numpag, textdescr, pesokb, autor) VALUES
                ('$_POST[titulo]','$_POST[numpag]','$_POST[textdescr]','$_POST[pesokb]','$_POST[autor]')";
            //} 
            if (mysqli_query($ligacao, $sql))
                echo "<h3>Cliente inserido com sucesso!</h3>";
            mysqli_close($ligacao);
            echo "<br/>";
        ?>
        <br/>
        <h4>Aguarde que vai ser redirecionado</h4>
        <input type="button" value="Voltar ao Menu" onclick="window.history.go(-1);">
        <!-- <a href="index.html" target="_self">Gestão de Livros</a><br><br> -->
        <br>
    </body>
</html>