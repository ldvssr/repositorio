<!DOCTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <title>Vinted</title>
        <meta http-equiv="refresh" content="3;url=login2.php">
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
    </head>
    <body>
        <h1>Alterar Dados Pessoais</h1>
        <hr>
        <?php
            include 'includes/valida.php';
            include 'includes/liga_bd.php';
            $tmp=password_hash($_POST['pass'], PASSWORD_DEFAULT);
            if (empty($_FILES['ficheiro']['name'][0]))
            {
                $sql = "UPDATE t_user SET
                nick='$_POST[nick]',
                nome='$_POST[nome]',
                email='$_POST[email]',
                data_nasc='$_POST[data_nasc]',
                senha='".$tmp."' WHERE id = $_POST[id]";
            }
            else
            {
                include 'includes/valida_foto.php';
                if ($uploadOk == 1)
                {
                    move_uploaded_file($_FILES["ficheiro"]["tmp_name"], $target_file);
                    unlink('pics/'.$_POST['nome_foto']);
                    $tmp=password_hash($_POST['pass'], PASSWORD_DEFAULT);
                    $sql = "UPDATE t_user SET
                    nick='$_POST[nick]',
                    nome='$_POST[nome]',
                    email='$_POST[email]',
                    data_nasc='$_POST[data_nasc]',
                    senha='".$tmp."',
                    foto='".$foto."' WHERE id = $_POST[id]";
                }
            }
                       
            if (mysqli_query($ligacao, $sql))
            {
                echo "<h2>Utilizador Alterado com Sucesso!</h2>";
            }
            mysqli_close($ligacao);
        ?>
    <h3> Aguarde, vai ser redirecionado </h3>
    <a href="index.html" target="_self">Voltar ao Menu</a>
    </body>
</html>