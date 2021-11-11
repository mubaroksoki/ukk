<?php include 'koneksi.php';?>
<!DOCTYPE html>
<html>
  <head>
    <title>CRUD Buku</title>
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <style type="text/css">
      * {
        font-family: "Trebuchet MS";
      }
      h1 {
        text-transform: uppercase;
        color: purple;
      }
   
    a {
          background-color: red;
          color: #fff;
          padding: 10px;
          text-decoration: none;
          font-size: 12px;
    }
    </style>
  </head>
  <body>
  <form method="GET" action="index.php" style="text-align: center;">
		<label>Kata Pencarian : </label>
		<input type="text" name="kata_cari" value="<?php if(isset($_GET['kata_cari'])) { echo $_GET['kata_cari']; } ?>"  />
		<button type="submit">Cari</button>
	</form>


    <center><h1>Data Buku</h1><center>
    <center><a href="tambah_produk.php">+ &nbsp; Tambah Produk</a><center>
    <?php 
        session_start();
        if($_SESSION['status']!="login"){
            header("location:loginform.php?pesan=belum_login");
        }
    ?>
    <h4>Selamat datang, <?php echo $_SESSION['username']; ?>! anda telah login.</h4>
    <br/>
    <a href="logout.php">LOGOUT</a>
   
  </div>
 
    <br/>
    <table class="table table-success table-striped">
      <thead>
        <tr>
          <th>No</th>
          <th>Judul</th>
          <th>pengarang</th>
          <th>penerbit</th>
          <th>gambar</th>
          <th>opsi</th>
          
        </tr>
    </thead>
    <tbody>
      <?php
      if(isset($_GET['kata_cari'])) {
        //menampung variabel kata_cari dari form pencarian
        $kata_cari = $_GET['kata_cari'];

        //jika hanya ingin mencari berdasarkan kode_produk, silahkan hapus dari awal OR
        //jika ingin mencari 1 ketentuan saja query nya ini : SELECT * FROM produk WHERE kode_produk like '%".$kata_cari."%' 
        $query = "SELECT * FROM daftarbuku WHERE judul like '%".$kata_cari."%' OR pengarang like '%".$kata_cari."%' OR penerbit like '%".$kata_cari."%' ORDER BY id_buku ASC";
      } else {
        //jika tidak ada pencarian, default yang dijalankan query ini
        $query = "SELECT * FROM daftarbuku ORDER BY id_buku ASC";
      }
      
      $result = mysqli_query($koneksi, $query);
      //mengecek apakah ada error ketika menjalankan query
      if(!$result){
        die ("Query Error: ".mysqli_errno($koneksi).
           " - ".mysqli_error($koneksi));
      }

      //buat perulangan untuk element tabel dari data mahasiswa
      $no = 1; //variabel untuk membuat nomor urut
      // hasil query akan disimpan dalam variabel $data dalam bentuk array
      // kemudian dicetak dengan perulangan while
      while($row = mysqli_fetch_assoc($result))
      {
      ?>
       <tr>
          <td><?php echo $no; ?></td>
          <td><?php echo $row['judul']; ?></td>
          <td><?php echo $row['pengarang']; ?></td>
          <td><?php echo $row['penerbit']; ?></td>
          
          <td style="text-align: center;"><img src="gambar/<?php echo $row['upload_gambar']; ?>" style="width: 120px;"></td>
          <td>
              <a href="edit_produk.php?id_buku=<?php echo $row['id_buku']; ?>">Edit</a> |
              <a href="proses_hapus.php?id_buku=<?php echo $row['id_buku']; ?>" onclick="return confirm('Anda yakin akan menghapus data ini?')">Hapus</a>
          </td>
      </tr>
         
      <?php
        $no++; //untuk nomor urut terus bertambah 1
      }
      ?>
    </tbody>
    </table>
  </body>
</html>