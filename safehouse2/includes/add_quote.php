<?php

include_once 'db_connect.php';



$res="INSERT INTO quotations(customername,customertype,quotedate,salesmanID,customerEmail,accountPhone,salesPhone,ownerPhone,cstNo,tinNo,totalPrice,installationCost,salesTax,discount,quoteObj) VALUES('$_POST[customername]','$_POST[customertype]',CURDATE(),'$_POST[salesmanID]','$_POST[customerEmail]','$_POST[accountPhone]','$_POST[salesPhone]','$_POST[ownerPhone]','$_POST[cstNo]','$_POST[tinNo]','$_POST[totalPrice]','$_POST[installationCost]','$_POST[salesTax]','$_POST[fdiscount]','$_POST[quoteObj]')";

//echo $res;
   $stmt = $mysqli->prepare($res);
   $stmt->execute();

?>