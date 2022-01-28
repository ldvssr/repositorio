<!DOCTYPE html>
<html lang="pt">
    <head>
        <meta charset="utf-8">
        <title>Gestão de Livros</title>
    </head>
    <body>
        <h1>Alterar Livros</h1>
        <hr>
        <?php
            $cp_id=$_POST['cp_id'];
            $ligacao = mysqli_connect("localhost","id18241934_root","FAx1qWM)d0F^Z}5>","id18241934_biblioteca");
            if ($ligacao->connect_error)
                die(mysqli_error($ligacao));
            $sql ="SELECT * FROM manuais WHERE id=" . $cp_id;
            $resultado =mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
            $linha = mysqli_fetch_assoc($resultado);
        ?>
        <form action="alterar3.php" method="post">
        <p> Id:<input type="text" name="id" size="5" value = "<?php echo $linha['id']?>" readonly></p>
        <p> Título:<input type="text" name="titulo" size="40" value = "<?php echo $linha['titulo']?>"></p>
        <p> Número de Páginas:<input type="text" name="numpag" size="11" value = "<?php echo $linha['numpag']?>"></p>
        <p> Texto Descritivo:<input type="text" name="textdescr" size="255" value = "<?php echo $linha['textdescr']?>"></p>
        <p> Peso (kb):<input type="text" name="pesokb" size="6" value = "<?php echo $linha['pesokb']?>"></p>
        <p> Autor:<input type="text" name="autor" size="20" value = "<?php echo $linha['autor']?>"></p>
        <input type="submit" value="Alterar">
        <input type="button" value="Limpar">
        <input type="button" value="Voltar ao Menu" onclick="window.history.go(-1);">
        <!-- <a href="index.html" target="_self">Gestão de Livros</a><br><br> -->
        </form>
        <?php
        mysqli_close($ligacao);
        ?>
    </body>
</html>