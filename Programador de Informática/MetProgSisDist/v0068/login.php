<!DOCTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <title>Vinted</title>
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
    </head>
    <body>
        <h1>Ínicio de Sessão</h1>
        <hr>
        <?php
            include 'includes/liga_bd.php';
            if (session_status() !== PHP_SESSION_ACTIVE)
            {
                $sql ="SELECT * FROM t_user WHERE nick='$_POST[nick]'";
                $resultado =mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
                $linha = mysqli_fetch_assoc($resultado);
                if ($linha == NULL)
                    header('Location: erro.html');
                if (password_verify($_POST['pass'],$linha['senha']))
                {
                    if ($linha['apagado']==1)
                    {
                        echo "<h1>Utilizador Bloqueado Pelo Administrador!</h1>";
                        ?>
                        <input type="button" value="Voltar ao Menu" onclick="window.open('index.html','_self')">
                        <?php
                    }
                    else
                    {
                    echo "<h2>Sessão iniciada com sucesso!</h2>";
                    echo "<h2>Bem-vindo ".$linha['nome']."!</h2>";
                    session_start();
                    $_SESSION['id']=$linha['id'];
                    $_SESSION['nick']=$linha['nick'];
                    header('Location: login2.php');
                    }
                }
                else
                {
                    header('Location: erro.html');
                }
            }
            mysqli_close($ligacao);
        ?>
    </body>
</html>