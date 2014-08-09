<?php
  include_once 'db_connect.php';


  $flag=1;
//  $res="SELECT sid,username,fname,lname,phone,email,discount from salesman where username='$_GET[username]'";
  $res="SELECT pid,pname,category,company,desc1,desc2,desc3,desc4,desc5,sellingprice,costprice,dealerprice,vat from product";
  $returnJSON="";
  // id 1 = just name ; 2 = only company ; 3 = only category ; 4 = company + category
  if($_POST[id]==1)
  {
  	$res=$res." WHERE pname LIKE '%".$_POST[pname]."%' ORDER BY pname";
  }
  else if($_POST[id]==2)
  {
  	$res=$res." WHERE company LIKE '%".$_POST[comp]."%' ORDER BY company";
  }
  else if($_POST[id]==3)
  {
  	$res=$res." WHERE category LIKE '%".$_POST[cat]."%' ORDER BY category";
  }
  else if($_POST[id]=4)
  {
  	$res=$res." WHERE category LIKE '%".$_POST[cat]."%' AND company LIKE '%".$_POST[comp]."%' ORDER BY company , category";
  }
  
  
  //echo "gand";
  //echo $res;
  $stmt = $mysqli->prepare($res);
  $stmt->execute();
	
  $stmt->store_result();
  
  $pid="";
  $pname="";
  $category ="";
  $company="";
  $desc1="";
  $desc2="";
  $desc3="";
  $desc4="";
  $desc5="";
  $sellingprice="";
  $costprice="";
  $dealerprice="";
  $vat="";


 // echo "first here ";
  // get variables from result.
  $stmt->bind_result($pid, $pname, $category,$company,$desc1,$desc2,$desc3,$desc4,$desc5,$sellingprice,$costprice,$dealerprice,$vat);
  $returnJSON='{"products": [';
  while($stmt->fetch())
  {
	//  	echo "here";
        //$stmt->fetch();
  	$returnJSON .= '{';
  	$returnJSON.= '"pid" :"'.$pid .'",';
  	$returnJSON.= '"pname" :"'.$pname .'",';
  	$returnJSON.= '"category" :"'.$category .'",';
  	$returnJSON.= '"company" :"'.$company .'",';
  	$returnJSON.= '"desc1" :"'.$desc1 .'",';
  	$returnJSON.= '"desc2" :"'.$desc2 .'",';
  	$returnJSON.= '"desc3" :"'.$desc3 .'",';
  	$returnJSON.= '"desc4" :"'.$desc4 .'",';
  	$returnJSON.= '"desc5" :"'.$desc5 .'",';
  	$returnJSON.= '"sellingprice" :"'.$sellingprice .'",';
  	$returnJSON.= '"costprice" :"'.$costprice .'",';
  	$returnJSON.= '"dealerprice" :"'.$dealerprice .'",';
  	$returnJSON.= '"vat" :"'.$vat .'"';
  	$returnJSON.= '},';
  	//echo "here2";
  	
  	//echo $sid . "*".$username."*" . $fname."*". $lname."*".$email."*".$phone."*".$discount."*";
  	
  }
  $returnJSON=rtrim($returnJSON, ",");
  $returnJSON.='] }';

  echo $returnJSON;

?>