<?php
include "koneksi.php";

$id			= $_POST['id'];
$nama		= $_POST['nama_produk'];
$harga		= $_POST['harga'];
$kategori	= $_POST['kategori'];

$query	= "update inputan set Nama_Produk='$nama', harga='$harga', Kategori_id='$kategori' where Kode_produk='$id'";

mysql_query($query);

header("location:../index.php?mod=produk_list");
?>