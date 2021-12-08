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
</head>
<body>
<p>Вы успешно авторизовались! Удачи на экзамене!</p>
<script>
    window.setTimeout(function () {
        window.parent.location.reload();
    }, 1000);
</script>
</body>
</html>