<?php
  include_once 'db_connect.php';


  
//  $res="SELECT sid,username,fname,lname,phone,email,discount from salesman where username='$_GET[username]'";
  $res="SELECT sid from salesman WHERE username='$_POST[username]'";

  
 
  $stmt = $mysqli->prepare($res);
  $stmt->execute();
	
  $stmt->store_result();
  
  $sid="";
  
  $stmt->bind_result($sid);

  $stmt->fetch();
  
  echo $sid 
  

?>