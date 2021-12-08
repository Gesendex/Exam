<?php
$db = mysqli_connect('localhost', 'root', '', 'exam');
session_start();
unset($_SESSION['user']);
header('location: /index.php');

