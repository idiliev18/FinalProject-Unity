<?php
require_once "config.php";
if (!empty($_COOKIE["Re"])){
    $sql = "SELECT username FROM users WHERE remember_token=:token";
    if($stmt = $pdo->prepare($sql)){
        $stmt->bindParam(":token", $_COOKIE["Re"], PDO::PARAM_STR);

        if ($stmt->execute()){

            if ($row = $stmt->fetch()){
                $username = $row["username"];
            }
        }
    }
} else{

  $username=NULL;
}
function login_or_greeting($username){

    if (!empty(trim($username))){
        echo '<div class="col-3">
                <a href="login.php" class="text-decoration-none h1">'.$username.'</a>
            </div>';
    }
    else{
        echo '
    <div class="col-3">
                <a href="login.php" class="text-decoration-none h1">&nbsp;&nbsp; LOGIN</a>
            </div>';
    }

}
function reg_or_logout($username){
    if (!empty(trim($username))){
        echo  '<div class="col-3">
                <a href="?logout" class="text-decoration-none h1">Log out </a>
            </div>';
    }
    else{
        echo ' <div class="col-3">
                <a href="register.php" class="text-decoration-none h1">REGISTER </a>
            </div>';
    }
}
if (isset($_GET['logout'])){
    setcookie("Re","",time() - 3600);
    setcookie("Ga","",time() - 3600);
    $page = $_SERVER['PHP_SELF'];
    header("location: $page");
}
