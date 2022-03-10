<!DOCTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <title>Vinted</title>
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
    </head>
    <body>
        <h1>Gestão de Categorias</h1>
        <hr>
        <?php
            
            include 'includes/liga_bd.php';
            if(isset($_POST['categoria']))
            {
                $categoria=$_POST['categoria'];
                $subcat=$_POST['subcat'];
                $sql="INSERT INTO t_subcat(categoria, subcat) VALUES ($categoria,'$subcat')";
                if (mysqli_query($ligacao, $sql))
                    echo "<h2>Dados inseridos com sucesso!</h2>";
                header("Location: categorias.php");
            }
        ?>
            <form action="categorias.php" method="post">
                Categoria: <select name="categoria">
                    <?php
                    $sql ="SELECT * FROM t_categoria";
                    $resultado =mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
                    while($linha = mysqli_fetch_assoc($resultado))
                        echo "<option value='".$linha['id']."'>".$linha['categoria']."</option>";
                    ?>
                </select>
                <br>Subcategoria: <input type="text" required name = "subcat">
                <button onclick="location.href='categorias.php'" type="button">Cancelar</button>
                <input type="submit" value="Gravar">
            </form>
        <h2>Categorias</h2>
        <table>
            <tr>
                <th>ID</th>
                <th>Categoria</th>
                <th>Subcategoria</th>
            </tr>
            <?php
                $sql="SELECT * FROM t_subcat";
                $resultado =mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
                while($linha = mysqli_fetch_assoc($resultado))
                {
                    echo "<tr><td>".$linha['id']."</td><td>".$linha['categoria']."</td><td>".$linha['subcat']."</td></tr>";
                }                    
            ?>
        </table>        
    </body>
</html>