<!DOCTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="refresh" content="3;url=index.html">
        <title>Forum dos Programadores</title>
    </head>
    <body style="background-color:black; color: orange;">
        <?php
            session_start();
            $_SESSION = array();
            session_destroy();
        ?>
        <h1 align="center">Sessão Terminada com Sucesso!</h1>
        <hr>
        <input type="button" value="Voltar ao Menu" onclick="window.open('index.html', '_self')">
    </body>
</html>