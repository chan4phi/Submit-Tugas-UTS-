<?php

include"proses/koneksi.php";
$id		= $_GET['id'];
$query	= "delete from inputan wehere Kode_produk ='$id'";

mysql_query($query);

header("location:../index.php?mod=produk_list");
?>