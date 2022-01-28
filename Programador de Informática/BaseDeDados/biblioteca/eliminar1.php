<!DOCTYPE html>
<html lang="pt">
    <head>
        <meta charset="utf-8">
        <title>Gestão de Livros</title>
    </head>
    <body>
    <h1>Eliminar Livros</h1>
    <hr>
    <form action="eliminar2.php" method="post">
    <p>Qual é o livro a eliminar?: <select name="cp_id">
    <?php
    $ligacao = mysqli_connect("localhost","id18241934_root","FAx1qWM)d0F^Z}5>","id18241934_biblioteca");
    if (!$ligacao)
    {
        die ("Erro na ligação" . mysql_connect_error());
    }
    $sql ="SELECT * FROM manuais ORDER BY titulo";
    $resultado =mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
    while($linha = mysqli_fetch_assoc($resultado))
    {
        echo "<option value ='" . $linha['id'] . "'>" . $linha['titulo'];
        echo "</option>";
    }        
    mysqli_close($ligacao);
    ?>
    </select></p>
    <p>
        <input name="submit" type="submit" value="Eliminar"/></p>
        <input type="button" value="Voltar ao Menu" onclick="window.history.go(-1);">
    </form>
    </body>
</html>