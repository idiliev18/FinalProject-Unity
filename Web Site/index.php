<?php
require_once "session.php";


?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">

    <!-- Fonts -->
    <link href="https://fonts.googleapis.com/css2?family=Oswald:wght@200;500&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Graduate&family=Notable&family=Titan+One&display=swap" rel="stylesheet">
    <link href="https://fonts.googleapis.com/css2?family=Noto+Sans+KR:wght@700&display=swap" rel="stylesheet">
    <!-- CSS -->
    <link rel="stylesheet" href="style/style.css">
    <!-- Bootstrap 4 -->
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>
    <!--  -->
    <title>Home Page</title>
</head>

<body>

    <!-- Navigation Bar -->

    <div id="nav" class="container">
        <div class="row justify-content-center nav-text pt-3">
            <div class="col-3">
                <a href="games.php" class="text-decoration-none h1">GAMES</a>
            </div>
            <div class="col-3">
                <a href="team.php" class="text-decoration-none  h1">DEV TEAM</a>
            </div>
            <?php  login_or_greeting($username);?>

            <?php  reg_or_logout($username);?>

        </div>
        <hr>
    </div>


    <!-- image slideshow -->
    <div id="carouselExampleIndicators" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#carouselExampleIndicators" data-slide-to="0" class="active"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="1"></li>
            <li data-target="#carouselExampleIndicators" data-slide-to="2"></li>
        </ol>
        <div class="carousel-inner ">
            <div class="carousel-item active">
                <img class="d-block w-100 img-fluid" src="img/prototype1.png" alt="First slide">
                <div class="carousel-caption d-none d-md-block">
                    <h1>Team Byal Dunav</h1>
                </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="img/prototype2.png" alt="Second slide">
                <div class="carousel-caption d-none d-md-block ">
                    <h1>HAVE FUN</h1>
                </div>
            </div>
            <div class="carousel-item">
                <img class="d-block w-100" src="img/prototype3.png" alt="Third slide">
                <div class="carousel-caption d-none d-md-block ">
                    <h1>LEARN ARDUINO</h1>
                </div>
            </div>
        </div>
        <a class="carousel-control-prev" href="#carouselExampleIndicators" role="button" data-slide="prev">
            <span class="carousel-control-prev-icon" aria-hidden="true"></span>
            <span class="sr-only">Previous</span>
        </a>
        <a class="carousel-control-next" href="#carouselExampleIndicators" role="button" data-slide="next">
            <span class="carousel-control-next-icon" aria-hidden="true"></span>
            <span class="sr-only">Next</span>
        </a>

    </div>

    <div class="container">
        <div class="row mt-5">
            <div class="col">

            </div>
            <div class="col-6 d-flex justify-content-center">
                <h1 id="goalTitle">Our goal!</h1>
            </div>
            <div class="col">
            </div>
        </div>
        <div class="row mt-5">
            <div class="col">

            </div>
            <div class="col-6 d-flex justify-content-center">
                <h4 id="goalContent">The purposes of our set of games are to help student to learn how the Arduino works. In the first game, Arduino 101, they will learn the main Arduino components and how to use them while assembling simple schemes. The next game Arduino 202 is the programming. The teacher will teach you how to program basic things, for example how to turn on and off a diode. After the student learn everything in the first two games, he unlocks the final game, Arduino 303. In this game the student's task is to make a project with the skills he learned in the previous games. Like that playing all the games the student can learn the basics of Arduino.  </h4>
            </div>
            <div class="col">
            </div>
        </div>
    </div>


</body>

</html>
