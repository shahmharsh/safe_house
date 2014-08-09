<?php
  include_once 'db_connect.php';


  $flag=1;
  $res="INSERT INTO product (pname,category,company,desc1,desc2,desc3,desc4,desc5,sellingprice,costprice,dealerprice,vat) VALUES
      ('$_POST[pname]','$_POST[category]','$_POST[company]','$_POST[desc1]','$_POST[desc2]','$_POST[desc3]','$_POST[desc4]','$_POST[desc5]',
       '$_POST[sellingprice]','$_POST[costprice]','$_POST[dealerprice]','$_POST[vat]')";


  $stmt = $mysqli->prepare($res);
  $stmt->execute();

?>