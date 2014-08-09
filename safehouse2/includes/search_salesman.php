<?php
  include_once 'db_connect.php';


  $flag=1;
  $res="SELECT sid,username,fname,lname,phone,email,discount from salesman where username='$_GET[username]'";
  $returnJSON="";
  //echo $_GET[username];
  $stmt = $mysqli->prepare($res);
  $stmt->execute();
	
  $stmt->store_result();
  $sid = "";
  $username="";
  $fname="";
  $lname="";
  $email="";
  $phone="";
  $discount="";
 // echo "first here ";
  // get variables from result.
  $stmt->bind_result($sid, $username, $fname,$lname,$phone,$email,$discount);
  while($stmt->fetch())
  {
	//  	echo "here";
        //$stmt->fetch();
  	$returnJSON = '{';
  	$returnJSON.= '"sid" :"'.$sid .'",';
  	$returnJSON.= '"username" :"'.$username .'",';
  	$returnJSON.= '"fname" :"'.$fname .'",';
  	$returnJSON.= '"lname" :"'.$lname .'",';
  	$returnJSON.= '"email" :"'.$email .'",';
  	$returnJSON.= '"phone" :"'.$phone .'",';
  	$returnJSON.= '"discount" :"'.$discount .'"';
  	$returnJSON.= '}';
  	//echo "here2";
  	//echo $sid . "*".$username."*" . $fname."*". $lname."*".$email."*".$phone."*".$discount."*";
  	
  }

  echo $returnJSON;

?>