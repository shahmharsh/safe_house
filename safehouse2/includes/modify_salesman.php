<?php
  include_once 'db_connect.php';


  $flag=1;
  $res="UPDATE  salesman SET fname='$_POST[fname]' , lname='$_POST[lname]' , username='$_POST[username]' , email = '$_POST[email]' , phone= '$_POST[phone]' , discount='$_POST[discount]' where sid='$_POST[sid]'";


  $stmt = $mysqli->prepare($res);
  $stmt->execute();

?>
