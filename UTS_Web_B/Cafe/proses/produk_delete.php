<?php

include "koneksi.php";
$id		= $_GET['id'];
$query	= "delete from inputan where Kode_produk ='$id'";

mysql_query($query);

header("location:../index.php?mod=produk_list");
?>