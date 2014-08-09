<?php

include_once 'db_connect.php';

// Create connection
//$con=mysqli_connect("localhost","myroot","password1","first_db");
// Check connection
//if (mysqli_connect_errno())
  //{
  //echo "error";
  //}

$flag=1;
$random_salt = hash('sha512',uniqid(openssl_random_pseudo_bytes(16), TRUE));
        // Create salted password 
        $password = hash('sha512', $_POST[p]. $random_salt);

$res="INSERT INTO salesman(username,fname,lname,phone,email,discount,password,salt) VALUES
      ('$_POST[username]','$_POST[fname]','$_POST[lname]','$_POST[phone]','$_POST[email]','$_POST[discount]','$password','$random_salt')";

 
   $stmt = $mysqli->prepare($res);
   $stmt->execute();
   //$stmt->close();

//mysqli_query($con, $res);

//mysqli_close($con);
?>