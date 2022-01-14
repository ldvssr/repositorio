<html>
    <head>
        <meta charset="utf-8">
        <title>Gestão de Livros</title>
    </head>
    <body>
        <h1>Listagem de Livros</h1>
        <hr>
        <?php
             $ligacao = mysqli_connect("127.0.0.1","root","12345","biblioteca");
             if ($ligacao->connect_error)
                 die(mysqli_error($ligacao)); 
             $consulta ="SELECT * FROM manuais";
             $resultado =mysqli_query($ligacao, $consulta) or die(mysqli_error($ligacao));
             $conta=0; 
             while($linha = mysqli_fetch_assoc($resultado))
             {
                 echo "Id: ". $linha['id']. "<br/>";
                 echo "Título: ". $linha['titulo']. "<br/>";
                 echo "Número de Páginas: ". $linha['numpag']. "<br/>";
                 echo "Texto Descritivo: ". $linha['textdescr']. "<br/>";
                 echo "Peso (kb): ". $linha['pesokb']. "<br/>";
                 echo "Autor: ". $linha['autor']. "<br/>";
                 echo "<hr/>";
                 $conta++;
             }
             mysqli_close($ligacao);
             //echo "<br/>";
             echo "<b>Numero de Livros na base de dados -> " . $conta . "</b>";
             echo "<br/>";
        ?>
        <br>
        <input type="button" value="Voltar ao Menu" onclick="window.history.go(-1);">
        <!-- <a href="index.html" target="_self">Gestão de Livros</a><br><br> --> 
    </body>
</html>