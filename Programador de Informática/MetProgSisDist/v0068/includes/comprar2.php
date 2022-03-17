<!DOCTYPE html>
<html>
<head>
        <meta charset="utf-8">
        <title>VINTED</title>
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
</head>
<body>
<h1>Venda de artigos</h1>
<?php
    include 'includes/valida.php';
     //estabelece a conexão à base de dados
    include 'includes/liga_bd.php';

        $sid_artigo=$_POST['id_artigo'];
        ?>
            <?php
            $sql ="SELECT * FROM t_artigo where id=" . $id_artigo;
            //echo $sql;
            // a variavel resultado vai aguardar todos os dados de todos os clientes
            $resultado =mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
            $linha = mysqli_fetch_assoc($resultado);
            ?>

            Id: <?php echo $linh['id'];?><br><br>
            Titulo: <?php echo $linha['titulo'];><br><br>
            Descrição: <?php echo $linha['descricao'];?><br><br>
            Preço: <b> <?php echo $linha['preco'];?> € </b><br><br>
            Estado: <php echo $linha['estado'];?> estrelas<br><br>
            <img src="artigos/<?php echo $linha['foto1']?>" width="150">
            <!-- devem fazer a validação se os campos estão vazios ou não -->
            <img src="artigos/<?php echo $linha['foto2']?>" width="150">
            <img src="artigos/<?php echo $linha['foto3']?>" width="150">
        </from>
        <h2>Comentários </h2>
        <table>
        <tr>
            <td>Id</td>
            <td>Comentário</td>
            <td>Classificação</td>
            <td>Data</td>
            <td>Utilizador</td>
        </tr>
        <?php
            $sql ="SELECT * FROM t_art_comen WHERE publico=0";

            // a variavel resultado vai guardar todos os dados de todos os clientes
            $resultado =mysqli_query($ligacao,$sql) or die(mysqli_error($ligacao));
            //variavel para contar os registos
            //enquanto conseguir ler os dados do array resultado imprime
            while($linha =mysqli_fetch_assoc($resultado))
            {
                echo "<tr><td>".$linha['id']."</td><td>".$linha['comentario']."</td><td>".$linha['classificacao']."</td>";
                echo "<td>".$linha['data']."</td><td".$linha['id_user']."</td></tr>";
                ?>

            >?php
            }
            ?>
        </table>
        <br><br>
        <form action-"comprar3.php" method-"post">
            <input type="hidden" name="id_artigo" value="<? echo $id_artigo;?>">
            Comentaário:<br>
            <textarea cols="80" rows="5" name="comentario"></textarea><br><br>
            Classificação:<input type="number" min="1" max="5" name="classificacao"><br><br>
            Data:<input type="text" readonly name="data" value="<?php echo date("h:i:sa");?>"><br><br>
            Publico: <select name="publico">
                     <option value="0">Publico</option>
                     <option value="1"> Privado</option>
                </select>
            <input type="submit" value="Comentar">
        </form>        

</body>
</html>        