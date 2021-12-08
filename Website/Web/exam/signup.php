<?php
$db = mysqli_connect('localhost', 'root', '', 'exam');
session_start();
$data = $_POST;
if(isset($data['do_signup']))
{
    $name = $data['name'];
    $last_name = $data['last_name'];
    $email = $data['email'];
    $password = $data['password'];
    $db->query("INSERT INTO `users` (`name`,`last_name`,`email`,`password`) VALUES('$name','$last_name', '$email', '$password')");
    header("location: /reg.php");
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
          <h2>Регистрация</h2>
          <form action="signup.php" method="POST">
          <div class="form">
            <input type="text" name="name" placeholder="Имя">
            <input type="text" name="last_name" placeholder="Фамилия">
            <input type="email" name="email" placeholder="Email">
            <input type="password" name="password" placeholder="Пароль">
            <input type="password" name="password2" placeholder="Повторите пароль">
            <button type="submit" name="do_signup">Зарегистрироваться</button>
          </div>
          </form>
        </div>
    </div>
  </div>
</div>
</div>
</body>
</html> 