<?php
    $servidor="127.0.0.1";
    $utilizador="root";
    $senha="";
    $bd="bd_v0068";    
    $ligacao = mysqli_connect($servidor,$utilizador,$senha,$bd);
    if ($ligacao->connect_error)
        die(mysqli_error($ligacao));
?>