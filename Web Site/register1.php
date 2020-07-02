<?php

// Include config file
require_once "config.php";

// Define variables and initialize with empty values
$username = $password = $confirm_password = $email = "";
$username_err = $password_err = $confirm_password_err = $email_err = "";

// Processing form data when form is submitted
if ($_SERVER["REQUEST_METHOD"] == "POST") {

    if (empty(trim($_POST["email"]))) {
        $email_err = "Please enter a email.";
    } else {
        // Prepare a select statement
        $sql = "SELECT id FROM users WHERE email = :email";

        if ($stmt = $pdo->prepare($sql)) {
            // Bind variables to the prepared statement as parameters
            $stmt->bindParam(":email", $param_email, PDO::PARAM_STR);

            // Set parameters
            $param_email = trim($_POST["email"]);

            // Attempt to execute the prepared statement
            if ($stmt->execute()) {
                if ($stmt->rowCount() == 1) {
                    $email_err = "This email is already taken.";
                } else {
                    $email = trim($_POST["email"]);
                }
            } else {
                echo "Oops! Something went wrong. Please try again later.";
            }

            // Close statement
            unset($stmt);
        }
    }
    // Validate username
    if (empty(trim($_POST["username"]))) {
        $username_err = "Please enter a username.";
    } else {
        // Prepare a select statement
        $sql = "SELECT id FROM users WHERE username = :username";

        if ($stmt = $pdo->prepare($sql)) {
            // Bind variables to the prepared statement as parameters
            $stmt->bindParam(":username", $param_username, PDO::PARAM_STR);

            // Set parameters
            $param_username = trim($_POST["username"]);

            // Attempt to execute the prepared statement
            if ($stmt->execute()) {
                if ($stmt->rowCount() == 1) {
                    $username_err = "This username is already taken.";
                } else {
                    $username = trim($_POST["username"]);
                }
            } else {
                echo "Oops! Something went wrong. Please try again later.";
            }

            // Close statement
            unset($stmt);
        }
    }

    // Validate password
    if (empty(trim($_POST["password"]))) {
        $password_err = "Please enter a password.";
    } elseif (strlen(trim($_POST["password"])) < 6) {
        $password_err = "Password must have atleast 6 characters.";
    } else {
        $password = trim($_POST["password"]);
    }

    // Validate confirm password
    if (empty(trim($_POST["confirm_password"]))) {
        $confirm_password_err = "Please confirm password.";
    } else {
        $confirm_password = trim($_POST["confirm_password"]);
        if (empty($password_err) && ($password != $confirm_password)) {
            $confirm_password_err = "Password did not match.";
        }
    }

    // Check input errors before inserting in database
    if (empty($username_err) && empty($password_err) && empty($confirm_password_err) && empty($email_err)) {

        // Prepare an insert statement
        $sql = "INSERT INTO users (email,username, password) VALUES (:email, :username, :password)";

        if ($stmt = $pdo->prepare($sql)) {
            // Bind variables to the prepared statement as parameters
            $stmt->bindParam(":username", $param_username, PDO::PARAM_STR);
            $stmt->bindParam(":password", $param_password, PDO::PARAM_STR);
            $stmt->bindParam(":email", $param_email, PDO::PARAM_STR);

            // Set parameters
            $param_email = $email;
            $param_username = $username;
            $param_password = password_hash($password, PASSWORD_DEFAULT); // Creates a password hash
            // Attempt to execute the prepared statement
            if ($stmt->execute()) {
                // Redirect to login page
                header("location: login.php");
            } else {
                echo "Something went wrong. Please try again later.";
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
                        <h5 class="card-title text-center">Sign In</h5>
                        <form class="form-signin" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
                            <div class="form-label-group">
                                <input type="email" id="inputEmail" class="form-control" placeholder="Username"
                                       name="username" value="<?php echo $email; ?>">
                                <label for="inputEmail" class="label">Email</label>
                                <span class="help-block"><?php echo $email_err; ?></span>
                            </div>
                            <div class="form-label-group">
                                <input type="text" id="inputEmail" class="form-control" placeholder="Username"
                                       name="username" value="<?php echo $username; ?>">
                                <label for="inputEmail" class="label">Username</label>
                                <span class="help-block"><?php echo $username_err; ?></span>
                            </div>
                            <div class="form-label-group">
                                <input type="password" id="inputPassword" class="form-control" placeholder="Password"
                                       name="password">
                                <label for="inputPassword" class="label"  value="<?php echo $password; ?>">Password</label>
                                <span class="help-block"><?php echo $password_err; ?></span>
                            </div>
                            <div class="form-label-group">
                                <input type="password" id="inputPassword" class="form-control" placeholder="Confirm password"
                                       name="confirm_password" value="<?php echo $confirm_password; ?>">
                                <label for="inputPassword" class="label">Confirm password</label>
                                <span class="help-block"><?php echo $confirm_password_err; ?></span>
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

