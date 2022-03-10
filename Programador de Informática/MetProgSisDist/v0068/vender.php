<!DOCTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <title>Vinted</title>
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
        <script type="text/javascript">
            function atualiza()
            {
                document.getElementById("f2").elements.namedItem("valor_cat").value=
                    document.getElementById("f1").elements.namedItem("categoria").value
                document.getElementById("f2").elements.namedItem("valor_subcat").value=
                    document.getElementById("f1").elements.namedItem("subcategoria").value
            }
            atualiza();
        </script>
    </head>
    <body>
        <h1>Vender Artigos</h1>
        <?php
        include 'includes/valida.php';
        include 'includes/liga_bd.php';
        $categoria=$_POST['categoria'];
        ?>
        <form action="vender.php" id="f1" method="post">
            Categoria: <select name="categoria" id="categoria" onchange="this.form.submit();">
            <?php
            $sql = "SELECT * FROM t_categoria";
            $resultado = mysqli_query($ligacao, $sql) or die(mysqli_error($ligacao));
            while($linha = mysqli_fetch_assoc($resultado))
            {
                if ($_POST['categoria']==$linha['id'])
                    echo "<option value='".$linha['id']."' selected>".$linha['categoria']."</option>";
                else
                    echo "<option value='".$linha['id']."'>".$linha['categoria']."</option>";
            }
            ?>
            </select>
            <br>
            Subcategoria: <select name="subcategoria" id="subcategoria" onchange="atualiza();">
            <?php
            $sql2 = "SELECT * FROM t_subcat where categoria=".$_POST['categoria'];
            $resultado = mysqli_query($ligacao, $sql2) or die(mysqli_error($ligacao));
            while($linha2 = mysqli_fetch_assoc($resultado2))
            {
                echo "<option value='".$linha2['id']."'>".$linha2['subcat']."</option>";
            }
            ?>
            </select>
        </form>
        <form>
            
        </form>
    </body>
</html>