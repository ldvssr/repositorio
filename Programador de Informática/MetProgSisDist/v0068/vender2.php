<!DOCKTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="refresh" content="3;url=login2.php">
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
        <title>Vinted</title>
    </head>
    <body>
        <h1>Registo de Utilizadores</h1>
        <?php
            include 'includes/liga_bd.php';
            $_FILES["ficheiro"]=$_FILES["fivheiro1"];
            include 'includes/valida_fotoa.php';
            if ($uploadOk == 0)
            {
                echo "O seu ficheiro não foi enviado.";
            }
            else
            {
                if ($uploadOk == 1)
                {
                    move_uploaded_file($_FILES["ficheiro"]["tmp_name"], $target_file);
                    $sql = "INSERT INTO t_artigo (id_user, cat, subcat, titulo, descricao, preco, estado, foto1) VALUES
                        ($_POST[id_user], $_POST[valor_cat], $_POST[valor_subcat], '$_POST[titulo]',
                        '$_POST[descricao]', $_POST[preco], $_POST[estado], '".$foto."');";
                    if(mysqli_query($ligacao, $sql))
                        echo "<h2>Registo efetuado com sucesso!</h2>";
                    if(!empty($_FILES['ficheiro2']['name'][0]))
                    {
                        $sql = "SELECT id FROM t_artigo ORDER BY id DESC";
                        $resultado = mysqli_query($ligacao, $sql) or die (mysqli_error($ligacao));
                        $linha = mysqli_fetch_assoc($resultado);
                        $_FILES["ficheiro"]=$_FILES["ficheiro2"];
                        include 'includes/valida_fotoa.php';
                        if ($uploadOk == 1)
                        {
                            move_uploaded_file($_FILES["ficheiro"]["tmp_name"], $target_file);
                            $sql2 ="UPDATE t_artigo SET foto2 = '".$foto."' WHERE  id= $linha[id];";
                            mysqli_query($ligacao, $sql2);
                        }
                    }
                    if (!empty($_FILES['ficheiro3']['name'][0]))
                    {
                        $sql = "SELECT id FROM t_artigo ORDER BY id DESC";
                        $resultado = mysqli_query($ligacao, $sql) or die (mysqli_error($ligacao));
                        $linha = mysqli_fetch_assoc($resultado);
                        $_FILES["ficheiro"]=$_FILES["ficheiro3"];
                        include 'includes/valida_fotoa.php';
                        if ($uploadOk == 1)
                        {
                            move_uploaded_file($_FILES["ficheiro"]["tmp_name"], $target_file);
                            $sql3 ="UPDATE t_artigo SET foto3 = '".$foto."' WHERE  id= $linha[id];";
                            mysqli_query($ligacao, $sql3);
                        }
                    }
                }
            }
            mysqli_close($ligacao);
        ?>
        <br>
        <a href="index.html" target="_self">Volta ao Menu</a>
    </body>
</html>