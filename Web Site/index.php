<?php
require_once "session.php";
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
    <title>Title</title>
</head>

<body>

    <!-- Navigation Bar -->

    <div id="nav" class="container">
        <div class="row justify-content-center nav-text pt-3">
            <div class="col-3">
                <a href="#" class="text-decoration-none h1">GAMES</a>
            </div>
            <div class="col-3">
                <a href="#" class="text-decoration-none  h1">DEV TEAM</a>
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
                <h4 id="goalContent">هناك حقيقة مثبتة منذ زمن طويل وهي أن المحتوى المقروء لصفحة ما سيلهي القارئ عن التركيز على الشكل الخارجي للنص أو شكل توضع الفقرات في الصفحة التي يقرأها. ولذلك يتم استخدام طريقة لوريم إيبسوم لأنها تعطي توزيعاَ طبيعياَ -إلى حد ما- للأحرف
                    عوضاً عن استخدام "هنا يوجد محتوى نصي، هنا يوجد محتوى نصي" فتجعلها تبدو (أي الأحرف) وكأنها نص مقروء. العديد من برامح النشر المكتبي وبرامح تحرير صفحات الويب تستخدم لوريم إيبسوم بشكل إفتراضي كنموذج عن النص، وإذا قمت بإدخال "lorem ipsum"
                    في أي محرك بحث ستظهر العديد من المواقع الحديثة العهد في نتائج البحث. على مدى السنين ظهرت نسخ جديدة ومختلفة من نص لوريم إيبسوم، أحياناً عن طريق الصدفة، وأحياناً عن عمد كإدخال بعض العبارات الفكاهية إليها.</h4>
            </div>
            <div class="col">
            </div>
        </div>
    </div>

    <!-- Footer -->
    <div class="container">
        <footer class="page-footer font-small cyan darken-3">

            <!-- Footer Elements -->
            <div class="container">

                <!-- Grid row-->
                <div class="row">

                    <!-- Grid column -->
                    <div class="col-md-12 py-5">
                        <div class="mb-5 flex-center">

                            <!-- Facebook -->
                            <a class="fb-ic">
                                <i class="fab fa-facebook-f fa-lg white-text mr-md-5 mr-3 fa-2x"> </i>
                            </a>
                            <!-- Twitter -->
                            <a class="tw-ic">
                                <i class="fab fa-twitter fa-lg white-text mr-md-5 mr-3 fa-2x"> </i>
                            </a>
                            <!-- Google +-->
                            <a class="gplus-ic">
                                <i class="fab fa-google-plus-g fa-lg white-text mr-md-5 mr-3 fa-2x"> </i>
                            </a>
                            <!--Linkedin -->
                            <a class="li-ic">
                                <i class="fab fa-linkedin-in fa-lg white-text mr-md-5 mr-3 fa-2x"> </i>
                            </a>
                            <!--Instagram-->
                            <a class="ins-ic">
                                <i class="fab fa-instagram fa-lg white-text mr-md-5 mr-3 fa-2x"> </i>
                            </a>
                            <!--Pinterest-->
                            <a class="pin-ic">
                                <i class="fab fa-pinterest fa-lg white-text fa-2x"> </i>
                            </a>
                        </div>
                    </div>
                    <!-- Grid column -->

                </div>
                <!-- Grid row-->

            </div>
            <!-- Footer Elements -->

            <!-- Copyright -->
            <div class="footer-copyright text-center py-3">© 2020 Copyright:
                <a href="https://mdbootstrap.com/"> MDBootstrap.com</a>
            </div>
            <!-- Copyright -->

        </footer>
    </div>
    <!-- Footer -->

</body>

</html>
