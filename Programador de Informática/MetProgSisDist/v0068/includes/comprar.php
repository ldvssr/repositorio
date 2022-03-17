<!DOCKTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
        <title>Vinted</title>
    </head>
    <body>
        <h1>Vender Artigos</h1>
        <?php
            include 'includes/valida.php';
            include 'includes/liga_bd';
            $categoria=$_POST['categoria'];
        ?>
        <form action="comprar.php" id="f1" method="post">
            Categoria: <select name="categoria" id="categoria" onchange="this.form.submin();">
                <?php
                    $sql = "SELECT * FROM t_categoria";
                    $resultado = mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
                    echo "<option value='0'> Todos</option>";
                    while($linha = mysqli_fetch_assoc($resultado))
                    {
                        if($_POST['categoria']==$linha['id'])
                            echo "<option value='".$linha['id']."' selected>".$linha['categoria']."</option>";
                        else
                            echo "<option value='".$linha['id']."'>".$linha['categoria']."</option>";
                    }
                ?>
            </select>
        </form>
        <h2>Produtos</h2>
        <table>
            <tr>
                <td>ID</td><td>Título</td>
                <td>Descrição</td><td>Preço</td>
                <td>Estado</td><td>Fotos</td>
                <td>Comprar</td>
            </tr>
            <?php
                if ($_POST['categoria']==0)
                    $sql = "SELECT * FROM t_artigo WHERE vendido = 0";
                else
                    $sql = "SELECT * FROM t_artigo WHERE vendido = 0 AND cat=".$_POST['categoria'];
                $resultado = mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
                while($linha = mysqli_fetch_assoc($resultado))
                {
                    echo "<tr><td>".$linha['id']."</td><td>".$linha['titulo']."</td><td>".$linha['descricao']."</td>";
                    echo "<td>".$linha['preco']."</td><td>".$linha['estado']."</td>";
                    echo "<td><img src-'artigos/".$linha['foto1']."' width-'100'></td><td>';
                    ?>
                    <form action="comprar2.php" id="f1" method="post">
                    <input type="text" size="20" name="id_artigo" value="<?php echo $linha['id'];?>">
                    <input type="submit" value="Ver comentários / Comprar">
                    </form>

                    </td></tr>
                <?php
                }
            ?>
        </table>
</body>
</html>