<?php include"proses/koneksi.php";?>
<?php
	$id = "";
	$nama_produk="";
	$harga="";
	$kategori="";
	$action ="proses/produk_add.php";
 if(isset($_GET['id'])){
	 $id = $_GET['id'];
	 
	 $query = "select * from inputan where Kode_produk = '".$id."'";
	 $row = mysql_query($query);
	 $res = mysql_fetch_array($row);
	 $nama_produk= $res['Nama_produk'];
	 $harga= $res['harga'];
	 $kategori= $res['Kategori_id'];
	 $action ="proses/produk_update.php";
}
 ?>
	<form class="form-vertical" method= "POST" action="<?php echo $action; ?>" enctype="multipart/form-data">
	<input type="hidden" value="<?php echo $id; ?>" name="id">
	<div align="center">
	<table border="0" cellpadding="3" width="50%" id="table1">
		<tr>
	<td><center>Nama Produk</center></td>
	<td><div class="col-sm-12"><input type="text" class="form-control" value="<?php echo $nama_produk; ?>" name="nama_produk"></div></td>
		</tr>
 
		<tr>
    <td><center>Kategori</center></td>
	<td><div class="form-group"><div class="col-sm-8">
	    <select class="form-control" align="center" value="<?php echo $kategori; ?>" name="kategori">
	    <option value="" selected="selected"><center>Pilihan Kategori</center></option>
	  <?php
		
		$query = "select * from kategori";
		$hasil = mysql_query($query);
		while ($data = mysql_fetch_array($hasil))
		{
			echo "<option value='".$data['Kategori_desc']."'>".$data['Kategori_desc']."</option>";
		}
	?>
		</select></div></div>
    </td>
		</tr>
	
		<tr>
	<td><center>Harga</center></td>
	<td><div class="form-group">
	<div class="col-sm-12"><input type="text" class="form-control" value="<?php echo $harga; ?>" name="harga"></div></div>
	</td>
		</tr>
     
        <tr>
    <td><center>Foto Produk</td>
	<td><div class="form-group"><div class="col-sm-9">
	<input type="file" class="form-control" name="gambar"></div></div>
	</td>
		</tr>
  
		<tr>
	<td colspan="3"><center><button type="reset" class="btn btn-warning">Batal</button>
	<button type="submit" class="btn btn-info">Simpan</button></center>
	</td>
		</tr>
	</table>
	</div>
</form> 
