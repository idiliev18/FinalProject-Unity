<?php
require_once "session.php";

if (isset($_GET['getGame'])&&$username!=NULL){
    $sql = "UPDATE users SET arduino_game = :game WHERE username = :username";
    if ($stmt=$pdo->prepare($sql)){
        $game = '1';
        $stmt->bindParam(":game", $game,PDO::PARAM_STR);
        $stmt->bindParam(":username", $username,PDO::PARAM_STR);
        if ($stmt->execute()){
            setcookie("Ga",$game, time()+60*60*24*30);
            header("location: games.php");
        }else{
            echo 'Something went wrong, try again';
        }
    }
}

function gameStatus(){
    if (isset($_COOKIE['Ga'])){
        if ($_COOKIE['Ga']=='0'){
            echo ' <a href="?getGame" class="btn btn-primary">Get the game</a>';
        }
        else{
            echo ' <a href="Arduino 101.exe" download="Arduino 101.exe" class="btn btn-primary">Download the game</a>';
        }
    }
    else{
        echo ' <a href="login.php" class="btn btn-primary">You need to have account</a>';
    }
}

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
    <title>Games</title>
</head>
<body>
<div  class="container">
    <div class="row justify-content-center nav-text pt-3" id="nav">
        <div class="col-3">
            <a href="games.php" class="text-decoration-none h1">GAMES</a>
        </div>
        <div class="col-3">
            <a href="team.php" class="text-decoration-none  h1">DEV TEAM</a>
        </div>
        <?php login_or_greeting($username); ?>

        <?php reg_or_logout($username); ?>

    </div>
    <hr>
    <div class="row pt-5">
        <div class="col-3">

        </div>
        <div class="col-6">
            <div class="card" >
                <img class="card-img-top" src="img/prototype3.png" alt="Card image cap">
                <div class="card-body">
                    <h5 class="card-title">Arduino 101</h5>
                    <p class="card-text">You are a young enthusiast who loves to learn new things; therefore, you went to school to learn Arduino with the best teacher Kondoriano. He will give you different tasks. You are going to be looking for Arduino parts, which were hidden in the Programming Company and after that, Kondoriano will show you how to combine them and how to make working Arduino system. He will also tell you some facts about the Arduino system. In the beginning, it will be easy but as the levels go up, the hardness will too. After you complete all levels, you will have basic knowledge of Arduino and you will be ready for the second part of our game. </p>
                    <?php gameStatus();  ?>
                </div>
            </div>
        </div>
        <div class="col-3">

        </div>

    </div>

</div>
</body>
