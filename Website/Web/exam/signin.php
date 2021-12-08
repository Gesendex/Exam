<?php
  $db = mysqli_connect('localhost', 'root', '', 'exam');
  session_start();
  $data = $_POST;
  if(isset($data['do_signin']))
  {
  $email = $data['email'];
  $password = $data['password'];
  $result = $db->query("SELECT * FROM `users` WHERE `email` = '$email' AND `password` = '$password'");
  $user = $result->fetch_assoc();

  if(count($user) != 0)
  {
      $_SESSION['user'] =
          ["email" => $user['email'],
              "password" => $user['password'],
              "name" => $user['name'],
              "last_name" => $user['last_name']
          ];
      header('location: /auth.php');
  }
}

?>
<!DOCTYPE html>
<html lang="ru">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
    <link rel="stylesheet" href="css/style.css">
</head>
<body>
  

<div id="range1">
<div class="outer">
  <div class="middle">
    <div class="inner">
        <div class="login-wr">
          <h2>Вход</h2>
          <form action="signin.php" method="POST">
          <div class="form">
            <input type="email" name="email" placeholder="Email">
            <input type="password" name="password" placeholder="Пароль">
            <button type="submit" name="do_signin">Войти</button>
          </div>
          </form>
        </div>
    </div>
  </div>
</div>
</div>
</body>
</html> 