<!DOCTYPE html>
<html lang="pt">
    <head>
        <!--área reservada para as meta tags -->
        <meta charset="utf-8">
        <meta http-equiv="refresh" content="3;url=login2.php">
        <link type="text/css" rel="stylesheet" href="recursos/style/style.css">
        <title>VINTED</title>
    </head>
    <body>
        <h1>Registo de comentários</h1>
        <?php
        include 'includes/valida.php';

        include 'includes/liga_bd.php';

        //crio a instrução sql para adicionar um registo na base de dados
        $sql ="INSERT INTO t_art_comen (id_artigo, comentario, avaliacao, data, publico, id_user) VALUES
                    ($_POST[id_artigo], '$_POST[comentario]', $_POST[classificacao], '$_POST[data]';
                    $_POST[publico], '".$_SESSION['id']."');";
                // tento inserir na base de dados
                //echo $sql;
                if (mysqli_query($ligacao, $sql))
                    echo "<h2>Comentário inserido com sucesso! </h2>";
        echo $sql;
        mysqli_close($ligacao);
        ?>
        <br/>
        <a href="login2.php" target="_self">Volta ao Menu</a>
    </body>   
</html>