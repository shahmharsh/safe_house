<?php
  include_once 'db_connect.php';


  $flag=1;
  $res="UPDATE  product SET desc1='$_POST[desc1]' , desc2='$_POST[desc2]' , desc3='$_POST[desc3]' , desc4 = '$_POST[desc4]' , desc5= '$_POST[desc5]' , sellingprice='$_POST[sellingprice]' , costprice='$_POST[costprice]' , dealerprice='$_POST[dealerprice]' , vat='$_POST[vat]'  where pid='$_POST[pid]'";


  $stmt = $mysqli->prepare($res);
  $stmt->execute();

?>
