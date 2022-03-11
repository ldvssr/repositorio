<!DOCKTYPE html>
<html lang="pt-PT">
    <head>
        <meta charset="utf-8">
        <meta http-equiv="refresh" content="3;url=login2.php">
        <link href="recursos/style/style.css" rel="stylesheet" type="text/css">
        <title>Vinted</title>
        <!--
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
        -->
    </head>
    <body>
        <!-- <h1>Vender Artigos</h1> -->
        <h1>Registo de Utilizadores</h1>
        <?php
            // include 'includes/valida.php';
            include 'includes/liga_bd.php';
            // $categoria=$_POST['categoria'];
            $_FILES["ficheiro"]=$_FILES["fivheiro1"];
            include 'includes/valida_foto.php';
            if ($uploadOk == 0)
            {
                echo "O seu ficheiro não foi enviado.";
            }
            else
            {
                if ($uploadOk == 1)
                {
                    move_uploaded_file($_FILES["ficheiro"]["tmp_name"], $target_file);
                    $sql = "INSERT INTO t_artigo (id_user, cat, subcat, titulo, descricao, preco, estado, foto1) VALUES
                        ($_POST[id_user], $_POST[valor_cat], $_POST[valor_subcat], '$_POST[titulo]',
                        '$_POST[descricao]', $_POST[preco], $_POST[estado], '".$foto."');";
                    if(mysqli_query($ligacao, $sql))
                        echo "<h2>Registo efetuado com sucesso!</h2>";
                    if(!empty($_FILES['ficheiro2']['name'][0]))
                    {
                        $sql = "SELECT id FROM t_artigo ORDER BY id DESC";
                        $resultado = mysqli_query($ligacao, $sql) or die (mysqli_error($ligacao));
                        $linha = mysqli_fetch_assoc($resultado);
                        $_FILES["ficheiro"]=$_FILES["ficheiro2"];
                        include 'includes/valida_foto.php';
                        if ($uploadOk == 1)
                        {
                            move_uploaded_file($_FILES["ficheiro"]["tmp_name"], $target_file);
                            $sql2 ="UPDATE t_artigo SET foto2 = '".$foto."' WHERE  id= $linha[id];";
                            mysqli_query($ligacao, $sql2);
                        }
                    }
                    if (!empty($_FILES['ficheiro3']['name'][0]))
                    {
                        $sql = "SELECT id FROM t_artigo ORDER BY id DESC";
                        $resultado = mysqli_query($ligacao, $sql) or die (mysqli_error($ligacao));
                        $linha = mysqli_fetch_assoc($resultado);
                        $_FILES["ficheiro"]=$_FILES["ficheiro3"];
                        include 'includes/valida_foto.php';
                        if ($uploadOk == 1)
                        {
                            move_uploaded_file($_FILES["ficheiro"]["tmp_name"], $target_file);
                            $sql3 ="UPDATE t_artigo SET foto3 = '".$foto."' WHERE  id= $linha[id];";
                            mysqli_query($ligacao, $sql3);
                        }
                    }
                }
            }
            mysqli_close($ligacao);
        ?>
        <br>
        <a href="index.html" target="_self">Volta ao Menu</a>
        <!--
        <form action="vender.php" id="f1" method="post">
            Categoria: <select name="categoria" id="categoria" onchange="this.form.submit();">
        -->
            <?php
                $sql="SELECT * FROM t_categoria";
                $resultado=mysqli_query($ligacao, $sql) or die (mysqli_error($ligacao));
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
                    $sql2="SELECT * FROM t_subcat WHERE categoria=".$_POST['categoria'];
                    $resultado2=mysqli_query($ligacao, $sql2) or die (mysqli_error($ligacao));
                    while($linha2 = mysqli_fetch_assoc($resultado2))
                    {
                        echo "<option value='".$linha['id']."' selected>".$linha['categoria']."</option>";                    
                    }
                ?>
            </select>
        </form>
        <form action="vender2.php" id="f2" method="post" enctype="multipart/form-data">
            <input type="hidden" size="20" name="id_user" value="<?php echo $_SESSION['id'];?>" required>
            <input type="hidden" size="30" name="valor_cat" id="valor_cat" required>
            <input type="hidden" size="30" name="valor_subcat" id="valor_subcat" required>
            Título:<input type="text" size="50" name="titulo" required><br><br>
            Descrição:<br>
                <textarea cols="80" rows="5" name="descricao"></textarea><br><br>
            Estado:<select name="estado">
                <option value="1"> 1 estrela</option>
                <option value="2"> 2 estrela</option>
                <option value="3"> 3 estrela</option>
                <option value="4"> 4 estrela</option>
                <option value="5"> 5 estrela</option>
            </select><br><br>
            Foto1:<input type="file" name="ficheiro1"><br><br>
            Foto2:<input type="file" name="ficheiro2"><br><br>
            Foto3:<input type="file" name="ficheiro3"><br><br>
            <input type="submit" value="Vender">
            <input type="reset" value="Limpar">
        </form>
    </body>
</html>