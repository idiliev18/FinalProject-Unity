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
                    $token = $token . date("Y/m/d").date("h:i:s");
                    $token = hash('sha256', $email);
                    $sql = "INSERT INTO password_reset(email,token) VALUES (:email,:token)";

                    if ($stmt = $pdo->prepare($sql)) {

                        $stmt->bindParam(":email", $email, PDO::PARAM_STR);
                        $stmt->bindParam(":token", $token, PDO::PARAM_STR);
                        if ($stmt->execute()) {

                            $mail = new PHPMailer();

                            $message = "Hi there, click on this <a href=\"http://localhost:8888/newPassword.php?token=" . $token . "\">link</a> to reset your password on our site";
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
    <title>Login</title>
    <link rel="stylesheet" href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.7/css/bootstrap.css">
    <style type="text/css">
        body {
            font: 14px sans-serif;
        }

        .wrapper {
            width: 350px;
            padding: 20px;
        }
    </style>
</head>
<body>
<div class="wrapper">
    <h2>Reset password</h2>
    <p>Enter the email of you account</p>
    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
        <div class="form-group <?php echo (!empty($email_err)) ? 'has-error' : ''; ?>">
            <label>Email</label>
            <input type="text" name="email" class="form-control" value="<?php echo $email; ?>">
            <span class="help-block"><?php echo $email_err; ?></span>
        </div>
        <div class="form-group">
            <input type="submit" class="btn btn-primary" value="resetPassword">
        </div>
    </form>
</div>
</body>
</html>

