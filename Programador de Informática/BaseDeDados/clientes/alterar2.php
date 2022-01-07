<!DOCTYPE html>
<html lang="pt">
    <head>        
        <meta charset="utf-8">
        <title>Gestão de Clientes</title>
    </head>
    <body>
        <h1>Alterar Clientes</h1>
        
        <?php
            
            $cp_id=$_POST['cp_id'];

            $ligacao = mysqli_connect("127.0.0.1","root","12345","0001");

            if ($ligacao->connect_error)
                die(mysqli_error($ligacao));
            
            $sql ="SELECT * FROM t_cliente WHERE id=" . $cp_id;
            $resultado =mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
            $linha = mysqli_fetch_assoc($resultado);
            
        ?>

        <hr>
        <form action="alterar3.php" method="post">
        <p> Id:<input type="text" name="id" size="5" value = "<?php echo $linha['id']?>" readonly></p>
        <p> Nome:<input type="text" name="nome" size="100" value = "<?php echo $linha['nome']?>"></p>
        <p> Morada:<input type="text" name="morada" size="100" value = "<?php echo $linha['morada']?>"></p>
        <p> Zona:<input type="text" name="zona" size="30" value = "<?php echo $linha['zona']?>"></p>
        <p> Nif:<input type="text" name="nif" size="9" value = "<?php echo $linha['nif']?>"></p>
        <p> Volume de Faturação:<input type="text" name="vol_fatur" size="10" value = "<?php echo $linha['vol_fatur']?>"></p>

        <input type="submit" value="Alterar">        
        <input type="button" value="Limpar">
        <input type="button" value="Voltar ao Menu" onclick="window.history.go(-1);">
        <!-- <a href="index.html" target="_self">Gestão de Clientes</a><br><br> -->
        </form>

        <?php
        mysqli_close($ligacao);
        ?>
    </body>
</html>