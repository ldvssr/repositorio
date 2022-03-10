<!DOCTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <title>Vinted</title>
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
        <meta http-equiv="refresh" content="3;url=index.html">
    </head>
    <body>
        <h1>Registar Utilizadores</h1>
        <hr>
        <?php
            include 'includes/liga_bd.php';
            include 'includes/valida_foto.php';
            if ($uploadOk == 0)
            {
                echo "O seu ficheiro não foi enviado.";
            }
            else
            {
                if ($uploadOk == 1)
                {
                    move_uploaded_file($_FILES["ficheiro"]["tmp_name"], $target_file);
                    $sql = "INSERT INTO t_user (nick, nome, email, data_nasc, senha, foto) VALUES
                    ('$_POST[nick]','$_POST[nome]','$_POST[email]','$_POST[data_nasc]','$_POST[pass]','".$foto."')";
                    if (mysqli_query($ligacao, $sql))
                    echo "<h1>Registo efetuado com sucesso!</h1>";
                }
            }           
            mysqli_close($ligacao);
        ?>
        <h2>Aguarde que vai ser redirecionado</h2>
        <input type="button" value="Voltar ao Menu" onclick="window.open('index.html','_self')">
    </body>
</html>