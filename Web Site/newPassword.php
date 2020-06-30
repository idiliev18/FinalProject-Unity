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
    <p>Enter new password</p>
    <form action="<?php echo htmlspecialchars($_SERVER["PHP_SELF"]); ?>" method="post">
        <div class="form-group <?php echo (!empty($password_err)) ? 'has-error' : ''; ?>">
            <label>New password</label>
            <input type="text" name="newPassword" class="form-control" value="<?php echo $email; ?>">
            <span class="help-block"><?php echo $password_err; ?></span>
        </div>
        <div class="form-group <?php echo (!empty($confirm_password_err)) ? 'has-error' : ''; ?>">
            <label>Confirm new password</label>
            <input type="text" name="ConfirmNewPassword" class="form-control">
            <span class="help-block"><?php echo $confirm_password_err; ?></span>
        </div>
        <div class="form-group">
            <input type="submit" class="btn btn-primary" value="newPasswords">
        </div>
    </form>
</body>
</html>

