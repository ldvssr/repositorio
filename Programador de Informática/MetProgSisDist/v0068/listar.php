<!DOCTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <title>Vinted</title>
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
    </head>
    <body>
        <h1>Gerir Utilizadores</h1>
        <hr>
        <?php            
            include 'includes/liga_bd.php';
            $sql ="SELECT * FROM t_user";
            $resultado =mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
            $conta=0;
            
            
            while($linha = mysqli_fetch_assoc($resultado))
            {
                if ($linha['apagado']==1)
                    echo "<div style='background-color:red'>";
                echo "<br>Id: ". $linha['id']. "<br>";
                echo "Nick: ". $linha['nick']. "<br>";
                echo "Nome: ". $linha['nome']. "<br>";
                echo "E-mail: ". $linha['email']. "<br>";
                echo "Data de nascimento: ". $linha['data_nasc']. "<br>";
                echo "Foto:<br> <img src='pics/". $linha['foto']. "' height='100'><br>";
                if ($linha['apagado']==0)
                {
                    ?>
                    <form action="bloquear_u.php" method="post">
                        <input type="hidden" name="id_user" value="<?php echo $linha['id'];?>"><br>
                        <input type="submit" value="bloquear">
                    </form><br>
                    <?php
                }
                else
                {
                    
                    ?>
                    <form action="desbloquear_u.php" method="post">
                        <input type="hidden" name="id_user" value="<?php echo $linha['id'];?>"><br>
                        <input type="submit" value="Desbloquear">
                    </form><br>
                    <?php
                    echo "</div>";
                }
                ?>
                <form action="alterar_u.php" method="post">
                    <input type="hidden" name="id_user" value="<?php echo $linha['id'];?>"><br>
                    <input type="submit" value="alterar">
                </form><br>
                <?php
                echo "<hr>";
                $conta = $conta + 1;
            }
            
            mysqli_close($ligacao);
        ?>
        <br><br>
        <input type="button" value="Voltar ao Menu" onclick="window.open('login2.php','_self')">
    </body>
</html>