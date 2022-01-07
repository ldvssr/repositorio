<!DOCTYPE html>
<html lang="pt">
    <head>        
        <meta charset="utf-8">
        <meta http-equiv="refresh" content="3;url=index.html" />
        <title>Gestão de Clientes</title>
    </head>
    <body>
        <h1>Eliminar Clientes</h1>
        <hr>
        <?php
            
            $cp_id=$_POST['cp_id'];

            $ligacao = mysqli_connect("127.0.0.1","root","12345","0001");

            if ($ligacao->connect_error)
            {
                die(mysqli_error($ligacao));
            }
                        
            $sql = "DELETE FROM t_cliente WHERE id=".$cp_id;

            if (mysqli_query($ligacao, $sql))
            {
                echo "<h2>Cliente Eliminado com Sucesso!</h2>";   
            }
            else
            {
                echo "Erro! " . mysqli_error($ligacao);
            }

            mysqli_close($ligacao);
             
        ?>

        <p>
            <h2> Aguarde, vai ser redirecionado </h2>

        <!-- <input type="button" value="Voltar ao Menu" onclick="window.history.go(-1);"> -->
        <!-- <a href="index.html" target="_self">Gestão de Clientes</a><br><br> -->
        
        <br> 
    </body>
</html>