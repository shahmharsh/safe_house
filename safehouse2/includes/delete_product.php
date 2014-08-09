<?php
  include_once 'db_connect.php';


  $flag=1;
  $res="DELETE from product WHERE pid='$_POST[pid]'";
	
  $stmt = $mysqli->prepare($res);
  $stmt->execute();

?>