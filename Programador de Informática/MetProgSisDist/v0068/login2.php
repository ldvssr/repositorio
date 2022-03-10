<!DOCTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <title>Vinted</title>
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
    </head>
    <body>
        <h1>Forum dos Programadores</h1>
        <hr>
        <?php
            include 'includes/valida.php';            
            echo "<h2>Sessão iniciada com sucesso!</h2>";
            echo "<h2>Bem-vindo ".$_SESSION['nick']."!</h2>";
        ?>
        <input type="button" value="Editar Perfil" onclick="window.open('perfil.php','_self')">
        
        <!-- <input type="button" value="Vender" onclick="window.open('vender.php','_self')"> -->
        
        <form action="vender.php" method="post">
            <input type="hidden" name="categoria" value="1">
            <input type="submit" value="vender">
        </form>

        <input type="button" value="Comprar" onclick="window.open('listar.php?tema=Todos','_self')">
        <input type="button" value="Pesquisar" onclick="window.open('pesquisar.php','_self')">
        <input type="button" value="Histórico" onclick="window.open('historico.php','_self')">
        <input type="button" value="Terminar Sessão" onclick="window.open('logout.php','_self')">
        <?php
            if (strcmp($_SESSION['nick'],"admin")==0)
            {
                ?>
                <br><br>
                <hr>
                <h2>Área de Administração</h2>
                <input type="button" value="Pesquisar Utilizadores" onclick="window.open('pesquisar_u.php','_self')">
                <input type="button" value="Gerir Utilizadores" onclick="window.open('gerir_u.php','_self')">
                <input type="button" value="Gerir Publicações" onclick="window.open('gerir_p.php','_self')">
                <input type="button" value="Gerir Respostas" onclick="window.open('gerir_r.php','_self')">
                <?php
            }
        ?>
    </body>
</html>