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
            $sql = "SELECT * FROM t_categorias";
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
        <form action="vender2.php" id="f2" method="post" enctype="multipart/form/data">
            <input type="hidden" size="20" name="id_user" value="<?php echo $_SESSION['id'];?>" required>
            <input type="hidden" size="30" name="valor_cat" id="valor_cat" required>
            <input type="hidden" size="30" name="valor_subcat" required>
            Título: <input type="text" size="50" name="titulo" required><br><br>
            Descrição:<br>
                <textarea cols="80" rows="5" name="descricao"></textarea><br><br>
            Estado: <select name="estado">
                <option value="1"> 1 estrela </option>
                <option value="2"> 2 estrelas </option>
                <option value="3"> 3 estrelas </option>
                <option value="4"> 4 estrelas </option>
                <option value="5"> 5 estrelas </option>
        </select><br><br>
        Foto1:<input type="file" name="ficheiro1"><br><br>
        Foto2:<input type="file" name="ficheiro2"><br><br>
        Foto3:<input type="file" name="ficheiro3"><br><br>
        <input type="submit" value="Vender">
        <input type="reset" value="Limpar">
        </form>
    </body>
</html>