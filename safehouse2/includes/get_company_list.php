<?php
  include_once 'db_connect.php';


  
//  $res="SELECT sid,username,fname,lname,phone,email,discount from salesman where username='$_GET[username]'";
  $res="SELECT DISTINCT company from product";
  $returnJSON="";
  
  
  $stmt = $mysqli->prepare($res);
  $stmt->execute();
	
  $stmt->store_result();
  
  $company="";
  
  $stmt->bind_result($company);

  while($stmt->fetch())
  {
	//  	echo "here";
        //$stmt->fetch();

  	$returnJSON.= $company .'|';
  	
  	//echo $sid . "*".$username."*" . $fname."*". $lname."*".$email."*".$phone."*".$discount."*";
  	
  }
  $returnJSON = rtrim($returnJSON,"|");
  echo $returnJSON;

?>