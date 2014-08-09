<?php

include_once 'db_connect.php';



$res="UPDATE quotations  SET customername='$_POST[customername]',customertype='$_POST[customertype]',quotedate='$_POST[quotedate]',salesmanID='$_POST[salesmanID]',customerEmail='$_POST[customerEmail]',accountPhone='$_POST[accountPhone]',salesPhone='$_POST[salesPhone]',ownerPhone='$_POST[ownerPhone]',cstNo='$_POST[cstNo]',tinNo='$_POST[tinNo]',totalPrice='$_POST[totalPrice]',installationCost='$_POST[installationCost]',salesTax='$_POST[salesTax]',discount='$_POST[fdiscount]',quoteObj='$_POST[quoteObj]' WHERE qid='$_POST[qid]'";


   $stmt = $mysqli->prepare($res);
   $stmt->execute();

?>