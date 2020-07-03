<?php

use PHPMailer\PHPMailer\PHPMailer;
use PHPMailer\PHPMailer\Exception;
require '..\vendor\autoload.php';

$email_err = $email = $token = "";



$unique = $error = false;
require_once "config.php";

if ($_SERVER["REQUEST_METHOD"] == "POST") {
    if (empty(trim($_POST["email"]))) {
        $email_err = "Please enter email.";
    } else {
        $email = trim($_POST["email"]);
    }

    if (empty($email_err)) {

        $sql = "SELECT email FROM users WHERE email=:email";

        if ($stmt = $pdo->prepare($sql)) {

            $stmt->bindParam(":email", $email, PDO::PARAM_STR);

            if ($stmt->execute()) {

                if ($stmt->rowCount() == 1) {
                    $token = $email . date("Y/m/d").date("h:i:s");
                    $token = hash('sha256', $token);
                    $sql = "INSERT INTO password_reset(email,token) VALUES (:email,:token)";

                    if ($stmt = $pdo->prepare($sql)) {

                        $stmt->bindParam(":email", $email, PDO::PARAM_STR);
                        $stmt->bindParam(":token", $token, PDO::PARAM_STR);
                        if ($stmt->execute()) {

                            $mail = new PHPMailer();

                            $message = "Hi there, click on this <a href=\"http://87.119.112.231:2502/FinalProject-Unity/Web%20Site/newPassword.php?token=" . $token . "\">link</a> to reset your password on our site";
                            $name = "TEST";
                            // specify SMTP credentials
                            $mail->isSMTP();
                            $mail->Host = 'smtp.mailtrap.io';
                            $mail->SMTPAuth = true;
                            $mail->Username = 'dc4e50f08f6639';
                            $mail->Password = '4c2b6d6bab3cb6';
                            $mail->SMTPSecure = 'tls';
                            $mail->Port = 2525;

                            $mail->setFrom('byaldunav@mailtrap.io', 'Team Byal Dunav');
                            $mail->addAddress($email, 'Me');
                            $mail->Subject = 'reset password';

                            // Enable HTML if needed
                            $mail->isHTML(true);

                            $bodyParagraphs = ["Name: {$name}", "Email: {$email}", "Message:", nl2br($message)];
                            $body = join('<br />', $bodyParagraphs);
                            $mail->Body = $body;

                            echo $body;

                            if($mail->send()){

                                header('Location: index.php'); // redirect to 'thank you' page
                            } else {

                                $errorMessage = 'Oops, something went wrong. Mailer Error: ' . $mail->ErrorInfo;
                                var_dump($errorMessage);
                                die();
                            }





                            header("location: index.php");
                        } else {
                            $email_err = "Something went wrong. Try again";
                        }
                    }
                } else {
                    $email_err = "There is no such an email";
                }
            } else {
                $email_err = "Something went wrong. Try again";
            }
        }
    } else {
        $email_err = "Something went wrong. Try again";
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

    <title>Reset Password</title>
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
                        <h5 class="card-title text-center">Enter you email</h5>
                        <form class="form-signin" action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
                            <div class="form-label-group">
                                <input type="email" id="inputEmail" class="form-control" placeholder="Username"
                                       name="email" value="<?php echo $email; ?>">
                                <label for="inputEmail" class="label">Email</label>
                                <span class="help-block"><?php echo $email_err; ?></span>
                            </div>

                            <button class="btn btn-lg btn-primary btn-block text-uppercase" type="submit">Reset password
                            </button>
                        </form>
                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
</body>

</html>

