<?php
require_once "session.php";


?>

<!DOCTYPE html>
<html lang="en">
<head>
    <link href="https://fonts.googleapis.com/css2?family=Oswald:wght@200;500&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Graduate&family=Notable&family=Titan+One&display=swap"
          rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Noto+Sans+KR:wght@700&display=swap" rel="stylesheet">
    <!-- CSS -->
    <link rel="stylesheet" href="style/style.css">
    <!-- Bootstrap 4 -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <meta charset="UTF-8">
    <title>Title</title>
</head>
<body id="team">
<div id="nav" class="container">
    <div class="row justify-content-center nav-text pt-3">
        <div class="col-3">
            <a href="#" class="text-decoration-none h1">GAMES</a>
        </div>
        <div class="col-3">
            <a href="#" class="text-decoration-none  h1">DEV TEAM</a>
        </div>
        <?php login_or_greeting($username); ?>

        <?php reg_or_logout($username); ?>

    </div>
    <hr>
</div>
<div class="container ">
    <div class="row pt-4">
        <div class="col-4 h100 w100">
            <div class="card" style="width: 18rem;">
                <img class="card-img-top" src="img/manager.svg" alt="Card image cap">
                <div class="card-body">
                    <h5 class="card-title">Илиян Илиев</h5>
                    <p class="card-text">Manager</p>
                </div>
            </div>
        </div>

        <div class="col-4 h100 w100">
            <div class="card" style="width: 18rem;">
                <img class="card-img-top" src="img/web.svg" alt="Card image cap">
                <div class="card-body">
                    <h5 class="card-title">Иван Димов</h5>
                    <p class="card-text">Web developer</p>
                </div>

            </div>
        </div>

        <div class="col-4 h100 w100">
            <div class="card" style="width: 18rem;">
                <img class="card-img-top" src="img/designer.svg" alt="Card image cap">
                <div class="card-body">
                    <h5 class="card-title">Ема Матева</h5>
                    <p class="card-text">Designer</p>
                </div>
            </div>
        </div>

    </div>
    <div class="row team pt-4 pb-5">
        <div class="col-4 h100 w100">
            <div class="card" style="width: 18rem;">
                <img class="card-img-top" src="img/dev.svg" alt="Card image cap">
                <div class="card-body">
                    <h5 class="card-title">Димитър Калчев</h5>
                    <p class="card-text">Developer</p>
                </div>
            </div>
        </div>
        <div class="col-4 h100 w100">
            <div class="card" style="width: 18rem;">
                <img class="card-img-top" src="img/director.svg" alt="Card image cap">
                <div class="card-body">
                    <h5 class="card-title">Стас Узунов</h5>
                    <p class="card-text">Game Director</p>
                </div>
            </div>
        </div>
        <div class="col-4 h100 w100">

            <div class="card" style="width: 18rem;">
                <img class="card-img-top" src="img/dev.svg" alt="Card image cap">
                <div class="card-body">
                    <h5 class="card-title">Стоян Иванов</h5>
                    <p class="card-text">Developer</p>
                </div>
            </div>
        </div>
    </div>
</div>
</body>
</html>
