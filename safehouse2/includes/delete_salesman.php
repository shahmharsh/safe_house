<?php
  include_once 'db_connect.php';


  $flag=1;
  $res="DELETE from salesman WHERE sid='$_POST[sid]'";
	//echo($res);
  $stmt = $mysqli->prepare($res);
  $stmt->execute();

?>