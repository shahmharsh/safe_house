<?php
include_once 'includes/db_connect.php';
include_once 'includes/functions.php';
 
sec_session_start();
 
if (login_check($mysqli) == true) {
    $logged = 'in';
} else {
    $logged = 'out';
}
?>

<!DOCTYPE html>
<!--[if lt IE 7 ]> <html lang="en" class="no-js ie6 lt8"> <![endif]-->
<!--[if IE 7 ]>    <html lang="en" class="no-js ie7 lt8"> <![endif]-->
<!--[if IE 8 ]>    <html lang="en" class="no-js ie8 lt8"> <![endif]-->
<!--[if IE 9 ]>    <html lang="en" class="no-js ie9"> <![endif]-->
<!--[if (gt IE 9)|!(IE)]><!--> <html lang="en" class="no-js"> <!--<![endif]-->
    <head>
        <meta charset="UTF-8" />
        <!-- <meta http-equiv="X-UA-Compatible" content="IE=edge,chrome=1">  -->
        <title>Login Form</title>
        <link rel="shortcut icon" href="../favicon.ico"> 
        <link rel="stylesheet" type="text/css" href="css/demo.css" />
        <link rel="stylesheet" type="text/css" href="css/style.css" />
	<link rel="stylesheet" type="text/css" href="css/animate-custom.css" />
	<!--<script src = "/scripts/loginCredentialCheck.js"></script>-->
	<script type="text/JavaScript" src="js/sha512.js"></script> 
        <script type="text/JavaScript" src="js/forms.js"></script>
	
    </head>
    <body>
	 
        <div class="container">
            <!-- Codrops top bar -->
            <div class="Company-Header">
		Company Name
                <div class="clr"></div>
            </div>
            <br><br>
            <section>				
                <div id="container_demo" >
                    <a class="hiddenanchor" id="tologin"></a>
                    <div id="wrapper">
                        <div id="login" class="animate form">
			    
                            <form  action="includes/process_login.php" autocomplete="on" method="post" name="login_form">
				
                                <h1>Log in</h1> 
                                <p> 
                                    <label for="username" class="uname" data-icon="u"> Your username </label>
                                    <input id="username" name="username" required="required" type="text" placeholder="myusername"/>
                                </p>
                                <p> 
                                    <label for="password" class="youpasswd" data-icon="p"> Your password </label>
                                    <input id="password" name="password"  type="password" placeholder="mypassword" /> 
                                </p>
                                <!-- <p class="keeplogin"> 
				    <input type="checkbox" name="loginkeeping" id="loginkeeping" value="loginkeeping" /> 
				    <label for="loginkeeping">Keep me logged in</label>
				</p> -->
				<br>
                                <p class="login button"> 
                                    <input type="submit" value="Login"  onclick="formhash(this.form, this.form.password);"/> 
				</p>
				<div id="somethingWentWrong" class="error">
					<?php 
        					if (isset($_GET['error'])) {
					        	echo '<p class="error">*Please Enter valid Username/Password </p>';
					        }
				        ?>			
        			</div>
                            </form>
                        </div>
                    </div>
                </div>  
            </section>
	    <footer class="minesweepersfooter">
		<p>Powered by <a href="http://minesweepers.co"> Minesweepers</a></p>
	    </footer>
        </div>
    </body>
</html>