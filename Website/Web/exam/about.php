<?php
$db = mysqli_connect('localhost', 'root', '', 'exam');
session_start();
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
<nav>
    <ul class="menu-main">
        <li><a href="#" class="current">Главная</a></li>
        <li><a href="#">О нас</a></li>
        <li><a href="#">Услуги</a></li>
        <li><a href="#">Контакты</a></li>
        <?php if(isset($_SESSION['user'])) : ?>
            <li><a href="/profile.php"><?php echo $_SESSION['user']['name'];?></a></li>
            <li><a href="/logout.php">Выйти</a></li>
        <?php endif; ?>
    </ul>
</nav>
>

</body>
</html>
