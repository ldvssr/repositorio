<!DOCTYPE html>
<html lang="pt">
    <head>
        <meta charset="utf-8">
        <title>Gestão de Clientes</title>
        <meta http-equiv="refresh" content="3;url=index.html">
    </head>
    <body>
        <h1>Inserir Clientes</h1>
        <br>

        <!-- TODO: implementar métodos para inserir -->

        <?php
             
            $ligacao = mysqli_connect("127.0.0.1","root","12345","0001");

            if ($ligacao->connect_error)
                die(mysqli_error($ligacao));

            $sql = "INSERT INTO t_cliente (nome, morada, zona, nif, vol_fatur) VALUES
                ('$_POST[nome]','$_POST[morada]','$_POST[zona]','$_POST[nif]',$_POST[vol_fatur])";

            if (mysqli_query($ligacao, $sql))
                echo "<h3>Cliente inserido com sucesso!</h3>";

            mysqli_close($ligacao);            
            
            echo "<br/>";

        ?>
        
        <br/>

        <h4>Aguarde que vai ser redirecionado</h4>

        <input type="button" value="Voltar ao Menu" onclick="window.history.go(-1);">
        <!-- <a href="index.html" target="_self">Gestão de Clientes</a><br><br> -->
        
        <br>        
    </body>
</html>