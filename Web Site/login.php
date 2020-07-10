<?php
// Initialize the session
session_start();

// Check if the user is already logged in, if yes then redirect him to welcome page
//if(isset($_SESSION["loggedin"]) && $_SESSION["loggedin"] === true){
//    header("location: welcome.php");
//    exit;
//}

// Include config file
require_once "config.php";

// Define variables and initialize with empty values
$username = $password = "";
$username_err = $password_err = "";
// Processing form data when form is submitted
if ($_SERVER["REQUEST_METHOD"] == "POST") {
// Check if username is empty
    if (empty(trim($_POST["username"]))) {
        $username_err = "Please enter username.";
    } else {
        $username = trim($_POST["username"]);
    }

// Check if password is empty
    if (empty(trim($_POST["password"]))) {
        $password_err = "Please enter your password.";
    } else {
        $password = trim($_POST["password"]);
    }

// Validate credentials
    if (empty($username_err) && empty($password_err)) {
// Prepare a select statement
        $sql = "SELECT id, username, password, arduino_game FROM users WHERE username = :username";

        if ($stmt = $pdo->prepare($sql)) {
// Bind variables to the prepared statement as parameters
            $stmt->bindParam(":username", $param_username, PDO::PARAM_STR);

// Set parameters
            $param_username = trim($_POST["username"]);

// Attempt to execute the prepared statement
            if ($stmt->execute()) {
// Check if username exists, if yes then verify password
                if ($stmt->rowCount() == 1) {
                    if ($row = $stmt->fetch()) {
                        $id = $row["id"];
                        $username = $row["username"];
                        $hashed_password = $row["password"];
                        $game = $row["arduino_game"];
                        if (password_verify($password, $hashed_password)) {
                            $remember_token = hash('sha256', $username);
                            if (!isset($_POST["remember"])) {
                                setcookie("Re", hash('sha256', $username), 0);
                                setcookie("Ga", $game, 0);

                            } else {
                                setcookie("Re", hash('sha256', $username), time() + 60 * 60 * 24 * 30);
                                setcookie("Ga", $game, time() + 60 * 60 * 24 * 30);
                            }

                            $sql = "UPDATE users  SET remember_token = :remember_token  WHERE id = :id ";

                            if ($stmt = $pdo->prepare($sql)) {

                                $stmt->bindParam(":remember_token", $remember_token, PDO::PARAM_STR);
                                $stmt->bindParam(":id", $id, PDO::PARAM_INT);

                                if ($stmt->execute()) {
// Redirect to login page

                                    header("location: index.html");
                                } else {
                                    echo "Something went wrong. Please try again later.";
                                }
                            }
// Redirect user to welcome page
                            header("location: index.php");
                        } else {
// Display an error message if password is not valid
                            $password_err = "The password you entered was not valid.";
                        }
                    }
                } else {
// Display an error message if username doesn't exist
                    $username_err = "No account found with that username.";
                }
            } else {
                echo "Oops! Something went wrong. Please try again later.";
            }

// Close statement
            unset($stmt);
        }
    }

// Close connection
    unset($pdo);
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

    <title>Login</title>
</head>

<!--Navigation Bar-->
<body>
<div id="nav" class="container">
    <div class="row justify-content-center nav-text pt-3">
        <div class="col-3">
            <a href="games.php" class="text-decoration-none h1">GAMES</a>
        </div>
        <div class="col-3">
            <a href="team.php" class="text-decoration-none  h1">DEV TEAM</a>
        </div>
        <div class="col-3">
            <a href="login.php" class="text-decoration-none h1">&nbsp;&nbsp; LOGIN</a>
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
                        <h5 class="card-title text-center">Sign In</h5>
                        <form class="form-signin" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
                            <div class="form-label-group">
                                <input type="text" id="inputEmail" class="form-control" placeholder="Username"
                                       name="username" value="<?php echo $username; ?>">
                                <label for="inputEmail" class="label">Username</label>
                                <span class="help-block"><?php echo $username_err; ?></span>
                            </div>

                            <div class="form-label-group">
                                <input type="password" id="inputPassword" class="form-control" placeholder="Password"
                                       name="password">
                                <label for="inputPassword" class="label">Password</label>
                                <span class="help-block"><?php echo $password_err; ?></span>
                            </div>

                            <div class="custom-control custom-checkbox mb-3">
                                <input type="checkbox" name="remember" class="custom-control-input" id="customCheck1"
                                       value="1">
                                <label class="custom-control-label" for="customCheck1">Remember password</label>
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
