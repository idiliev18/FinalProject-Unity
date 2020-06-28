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
