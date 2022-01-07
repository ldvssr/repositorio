<html>
    <head>
        <meta charset="utf-8">
        <title>Gestão de Clientes</title>
    </head>
    <body>
        <h1>Listagem de Clientes</h1>
        <br>
        <?php
             
             $ligacao = mysqli_connect("127.0.0.1","root","12345","0001");

             if ($ligacao->connect_error)
                 die(mysqli_error($ligacao));
 
             $consulta ="SELECT * FROM t_cliente";
             $resultado =mysqli_query($ligacao, $consulta) or die(mysqli_error($ligacao));
             $conta=0;
 
             while($linha = mysqli_fetch_assoc($resultado))
             {
                 echo "Id: ". $linha['id']. "<br/>";
                 echo "Nome: ". $linha['nome']. "<br/>";
                 echo "Morada: ". $linha['morada']. "<br/>";
                 echo "Zona: ". $linha['zona']. "<br/>";
                 echo "Nif: ". $linha['nif']. "<br/>";
                 echo "Volume de faturação: ". $linha['vol_fatur']. "<br/>";
                 echo "<hr/>";
                 $conta++;
             }
 
             mysqli_close($ligacao);
             
             echo "<br/>";
             echo "<b>Numero de clientes na base de dados -> " . $conta . "</b>";
             
        ?>
        <br>
        <input type="button" value="Voltar ao Menu" onclick="window.history.go(-1);">
        <!-- <a href="index.html" target="_self">Gestão de Clientes</a><br><br> --> 
    </body>
</html>