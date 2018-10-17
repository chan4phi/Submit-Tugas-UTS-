<?php
include "koneksi.php";

$produkID		=	getAutoId('Kode_produk', 'inputan', 'CID');
$nama_produk	=	$_POST['nama_produk'];
$harga			=	$_POST['harga'];
$kategori		=	$_POST['kategori'];

$namaFile		=	$_Files['gambar']['name'];
$namaSementara	=	$_Files['gambar']['tmp_name'];
$dirUpload		=	"../gambar";

$terupload		=	move_uploaded_file($namaSementara,$dirUpload.$namaFile);

$gambar			=	"gambar/".$namaFile;

$query = "INSERT INTO `inputan`
	(`Kode_produk`, `Nama_produk`, `Kategori_id`, `harga`, `Foto_produk`) VALUES ('$produkID', '$nama_produk', '$kategori', '$harga', '$gambar')";

	
	mysql_query($query);
header("location:../index.php?mod=produk_form");	


?>