<?php


if(isset($_GET['pesan'])){
    if($_GET['pesan'] == "gagal"){
        echo "Login gagal! username dan password salah!";
    }
    else if($_GET['pesan'] == "logout"){
        echo "Anda telah berhasil logout";
    }
    else if($_GET['pesan'] == "belum_login"){
        echo "Anda harus login untuk mengakses halaman admin";
    }
}



?>

<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.1.3/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-1BmE4kWBq78iYhFldvKuhfTAU6auU8tT94WrHftjDbrCEXSU1oBoqyl2QvZ6jIW3" crossorigin="anonymous">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
<div class="mb-3">
<form action="login_process.php" method="POST">
  <label for="exampleFormControlInput1" class="form-control form-control-sm">Username</label>
  <input type="text" class="form-control" name="username"id="exampleFormControlInput1" >
  <label for="exampleFormControlInput1" class="form-label">Password</label>
  <input type="password" class="form-control" name="password"id="exampleFormControlInput1" >
  <tr>
      <td>
          <input type="submit" name="submit" value="submit">
      </td>
  </tr>
</form>
</div>
    
</body>
</html>

