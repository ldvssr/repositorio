<!DOCTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <title>Vinted</title>
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
    </head>
    <body>
        <h1>Alterar Utilizador</h1>
        <hr>
        <?php
            
            include 'includes/liga_bd.php';
            $sql ="SELECT * FROM t_user WHERE id=$_POST[id_user]";
            $resultado =mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
            $linha = mysqli_fetch_assoc($resultado);
        ?>
        <form action="alterar_u2.php" method="post" enctype="multipart/form-data">
            <p> Id:<input type="text" name="id" size="10" readonly value = "<?php echo $linha['id']?>"></p>
            <p> Nick:<input type="text" name="nick" size="20" required value = "<?php echo $linha['nick']?>"></p>
            <p> Nome:<input type="text" name="nome" size="100" required value = "<?php echo $linha['nome']?>"></p>
            <p> E-mail:<input type="text" name="email" size="50" required value = "<?php echo $linha['email']?>"></p>
            Data Nascimento:<input type="date" name="data_nasc" size="10" required value = "<?php echo $linha['data_nasc'];?>"><br><br>
            Senha:<input type="password" name="pass" size="20"><br><br>
            Foto:<br><img src="pics/<?php echo $linha['foto'];?>" width="150">
            <input type="hidden" name="nome_foto" value="<?php echo $linha['foto'];?>">
            <br><br>Nova Foto: <input type="file" name="ficheiro"><br><br>
            <input type="submit" value="Alterar">
            <br><br>            
            <a href="index.html" target="_self">Voltar ao Menu</a>
        </form>
        <?php
            mysqli_close($ligacao);
        ?>
    </body>
</html>