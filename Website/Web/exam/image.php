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
    <link rel="stylesheet" href="css/slider.css">
</head>
<body>
<div class="eight columns all">
    <a id="link" href="#"><img id="img-slide"></a>
</div>

<script>
    function slide1(){
    document.getElementById('img-slide').src="img/1.jpg";
    document.getElementById('link').href="https://vk.com/vorobyssshek";
    setTimeout("slide2()", 4000);
}

function slide2(){
    document.getElementById('img-slide').src="img/2.jpg";
    document.getElementById('link').href="https://www.youtube.com/watch?v=py1dfWtTwLs&list=PLM2Q6lcZo4MexclJrYxA0Is42qWBBuHpB&index=8&ab_channel=AlexeyBychkov%3A%D0%B2%D0%B5%D0%B1-%D0%B4%D0%B8%D0%B7%D0%B0%D0%B9%D0%BD%D0%B8%D1%84%D1%80%D0%B8%D0%BB%D0%B0%D0%BD%D1%81";
    setTimeout("slide3()", 4000);
}

function slide3(){
    document.getElementById('img-slide').src="img/3.jpg";
    document.getElementById('link').href="https://codepen.io/damianmuti/pen/MvYPPa";
    setTimeout("slide1()", 4000);
}
slide1();
</script>
</body>
</html>