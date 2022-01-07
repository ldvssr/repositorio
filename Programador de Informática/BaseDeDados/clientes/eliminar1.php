<!DOCTYPE html>
<html lang="pt">
    <head>        
        <meta charset="utf-8">
        <title>Gestão de Clientes</title>
    </head>
    <body>
    <h1>Eliminar Clientes</h1>
    <hr><br>

    <form action="eliminar2.php" method="post">
    <p>Qual é o cliente a eliminar?: <select name="cp_id">
    <?php             
    $ligacao = mysqli_connect("127.0.0.1","root","12345","0001");
    if (!$ligacao)
    {
        die ("Erro na ligação" . mysql_connect_error());
    }
    $sql ="SELECT * FROM t_cliente ORDER BY nome";
    $resultado =mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
    while($linha = mysqli_fetch_assoc($resultado))
    {
        echo "<option value ='" . $linha['id'] . "'>" . $linha['nome'];
        echo "</option>";                 
    }        
    mysqli_close($ligacao);             
    ?>
    </select></p>
    <p>
        <input name="submit" type="submit" value="Eliminar"/></p>      
        <input type="button" value="Voltar ao Menu" onclick="window.history.go(-1);">      
    </form> 
    </body>
</html>