<?php include "proses\koneksi.php";?>
<div class="container">
                                                                                       
  <div class="table-responsive">          
  <table class="table table-bordered">
    <thead>
      <tr>
        <th>No</th>
        <th>Gambar</th>
		<th>Nama Produk</th>
        <th>Kategori</th>
        <th>Harga</th>
        <th>Aksi</th>
      </tr>
    </thead>
    <tbody>
	
	<?php 
	
	$query = "select * from inputan";
	$res = mysql_query($query);
	$no=1;
	while($row=mysql_fetch_array($res)){
	?>
      <tr>
        <td><?php echo $row['Kode_produk'];?></td>
        <td><img src="<?php echo $row['Foto_produk'];?>" width="80"> </td>
        <td><?php echo $row['Nama_produk'];?></td>
        <td><?php echo $row['Kategori_id'];?></td>
		<td><?php echo $row['harga'];?></td>
        <td><a href="index.php?mod=produk_form&id=<?php echo $row['Kode_produk']; ?>" >Edit
		| <a onclick="return confirm('Yakin data ini akan dihapus? ')" href="proses/produk_delete.php?id=<?php echo $row['Kode_produk']; ?>">Delete
		
		</td>
		
      </tr>
	<?php } ?>
    </tbody>
  </table>
  </div>
</div>

