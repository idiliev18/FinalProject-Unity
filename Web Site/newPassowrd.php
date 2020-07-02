<?php
require_once "config.php";
session_start();

$email = $password = $confirm_password = $token = "";
$password_err = $confirm_password_err = "";

if ($_SERVER["REQUEST_METHOD"] == "GET") {
    if (isset($_GET['token'])) {
        $sql = "SELECT email FROM password_reset WHERE token=:token";
        if ($stmt = $pdo->prepare($sql)) {
            $stmt->bindParam(':token', $_GET['token']);
            if ($stmt->execute()) {
                if ($stmt->rowCount() > 0) {
                    if ($row = $stmt->fetch()) {

                        $_SESSION['email']=$row['email'];
                    }
                } else {
                    header("location: index.php");
                }
            }
        }
    } else {
        header("location: index.php");
    }
}
// Validate password

if ($_SERVER["REQUEST_METHOD"] == "POST") {

    if (empty(trim($_POST["newPassword"]))) {
        $password_err = "Please enter a password.";
    } elseif (strlen(trim($_POST["newPassword"])) < 6) {
        $password_err = "Password must have atleast 6 characters.";
    } else {
        $password = trim($_POST["newPassword"]);
    }

    if (empty(trim($_POST["ConfirmNewPassword"]))) {
        $confirm_password_err = "Please confirm password.";
    } else {
        $confirm_password = trim($_POST["ConfirmNewPassword"]);
        if (empty($password_err) && ($password != $confirm_password)) {
            $confirm_password_err = "Password did not match.";
        }
    }
    if (empty($password_err) && empty($confirm_password_err)) {
        $sql = "UPDATE users SET password = :password WHERE email= :email";
        if ($stmt = $pdo->prepare($sql)) {
            $password = password_hash($password, PASSWORD_DEFAULT);

            $stmt->bindParam(":password", $password, PDO::PARAM_STR);
            $stmt->bindParam(":email", $email, PDO::PARAM_STR);

            if ($stmt->execute()) {

                $sql = "DELETE FROM password_reset WHERE email = :email";
                if ($stmt = $pdo->prepare($sql)) {

                    $email = $_SESSION['email'];
                    $stmt->bindParam(":email", $email, PDO::PARAM_STR);

                    if ($stmt->execute()) {
                        session_destroy();
                        header("location: login.php");
                    }
                }

            } else {
                echo "Something went wrong. Please try again later.";
            }
        }
    }


}
?>
<!DOCTYPE html>
<html lang="en">

<head>
    <meta charset="UTF-8">

    <link rel="stylesheet" href="style/login.css">

    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/css/bootstrap.min.css">
    <script src="https://ajax.googleapis.com/ajax/libs/jquery/3.5.1/jquery.min.js"></script>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/popper.js/1.16.0/umd/popper.min.js"></script>
    <script src="https://maxcdn.bootstrapcdn.com/bootstrap/4.5.0/js/bootstrap.min.js"></script>

    <script>
        $(document).ready(function () {
            $("#form").fadeIn(2000);
        });
    </script>

    <title>Title</title>
</head>

<!--Navigation Bar-->
<body>
<div id="nav" class="container">
    <div class="row justify-content-center nav-text pt-3">
        <div class="col-3">
            <a href="#" class="text-decoration-none h1">GAMES</a>
        </div>
        <div class="col-3">
            <a href="#" class="text-decoration-none  h1">DEV TEAM</a>
        </div>
        <div class="col-3">
            <a href="login1.php" class="text-decoration-none h1">&nbsp;&nbsp; LOGIN</a>
        </div>
        <div class="col-3">
            <a href="register.php" class="text-decoration-none h1">REGISTER</a>
        </div>
    </div>
    <hr>
</div>


<!--Login Form-->


<div class="bg">
    <div class="container">

        <div class="row">
            <div class="col-sm-9 col-md-7 col-lg-5 mx-auto">
                <div class="card card-signin my-5" id="form" style="display: none">
                    <div class="card-body">
                        <h5 class="card-title text-center">New password</h5>
                        <form class="form-signin" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
                            <div class="form-label-group">
                                <input type="password" id="inputPassword" class="form-control" placeholder="Password"
                                       name="newPassword">
                                <label for="inputPassword" class="label"  value="<?php echo $password; ?>">Password</label>
                                <span class="help-block"><?php echo $password_err; ?></span>
                            </div>
                            <div class="form-label-group">
                                <input type="password" id="inputPassword" class="form-control" placeholder="Confirm password"
                                       name="ConfirmNewPassword" value="<?php echo $confirm_password; ?>">
                                <label for="inputPassword" class="label">Confirm password</label>
                                <span class="help-block"><?php echo $confirm_password_err; ?></span>
                            </div>
                            <button class="btn btn-lg btn-primary btn-block text-uppercase" type="submit">Sign in
                            </button>
                        </form>
                        <div class="card-text text-center pt-2">
                            <p>You can't login.<a href="resetPassword.php">Forgot password</a></p>
                            <p>Don't have account.<a href="register.php">Register</a></p>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</body>

</html>
