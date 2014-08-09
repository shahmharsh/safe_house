<?php

include_once 'db_connect.php';
include_once 'functions.php';

sec_session_start(); // Our custom secure way of starting a PHP session.

if (isset($_POST['username'], $_POST['p'])) {
    $username = filter_input(INPUT_POST, 'username', FILTER_SANITIZE_EMAIL);
    $password = $_POST['p']; // The hashed password.
    //alert($username);
    //echo ($password);
    if (login($username, $password, $mysqli) == true) {
        // Login success
        if($username == "admin1")
        {
            header("Location: ../html/admin_home.php");    
        }
        else
        {
            header("Location: ../protected_page.php");
        }
        
        exit();
    } else {
        //Login failed 
        header('Location: ../loginScreen.php?error=1');
        exit();
    }
} else {
    // The correct POST variables were not sent to this page. 
    header('Location: ../error.php?err=Could not process login');
    exit();
}