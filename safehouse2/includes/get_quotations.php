<?php

include_once 'db_connect.php';

function IsNullOrEmptyString($question){
    return (!isset($question) || trim($question)==='');
}

ini_set('memory_limit','256M');

$res="SELECT  qid,customername,customertype,quotedate,salesmanID,customerEmail,accountPhone,salesPhone,ownerPhone,cstNo,tinNo,totalPrice,installationCost,salesTax,discount,quoteObj from quotations "; 

//$res = "SELECT count(*) from quotations";
//echo $res;

if(($_POST[sid])!="")
{
	$res.="WHERE salesmanID='$_POST[sid]'";
}
else if (($_POST[qid])!="")
{
	$res.="WHERE qid='$_POST[qid]'";
}

   $stmt = $mysqli->prepare($res);
// "here";	
   $stmt->execute();
 //  echo "here2";


$qid="";
  $customername="";
  $customertype ="";
  $quotedate="";
  $salesmanID="";
  $customerEmail="";
  $accountPhone="";
  $salesPhone="";
  $ownerPhone="";
  $cstNo="";
  $tinNo="";
  $totalPrice="";
  $installationCost="";
  $salesTax="";
  $discount="";
  $quoteObj="";


 // echo "first here ";
  // get variables from result.
  $stmt->bind_result($qid, $customername, $customertype,$quotedate,$salesmanID,$customerEmail,$accountPhone,$salesPhone,$ownerPhone,$cstNo,$tinNo,$totalPrice,$installationCost,$salesTax,$discount,$quoteObj);
  $temp="";
  $temp1="";
  //echo "here3";
  $returnJSON='{"quotes":[ ';
  while($stmt->fetch())
  {
	//  	echo "here";
        //$stmt->fetch();
  	$returnJSON .= '{';
  	$returnJSON.= '"qid" :"'.$qid .'",';
  	$returnJSON.= '"customername" :"'.$customername .'",';
  	$returnJSON.= '"customertype" :"'.$customertype .'",';
  	$returnJSON.= '"quotedate" :"'.$quotedate .'",';
  	$returnJSON.= '"salesmanID" :"'.$salesmanID .'",';
  	$returnJSON.= '"customerEmail" :"'.$customerEmail .'",';
  	$returnJSON.= '"accountPhone" :"'.$accountPhone .'",';
  	$returnJSON.= '"salesPhone" :"'.$salesPhone .'",';
  	$returnJSON.= '"ownerPhone" :"'.$ownerPhone .'",';
  	$returnJSON.= '"cstNo" :"'.$cstNo .'",';
  	$returnJSON.= '"tinNo" :"'.$tinNo .'",';
  	$returnJSON.= '"totalPrice" :"'.$totalPrice .'",';
  	$returnJSON.= '"installationCost" :"'.$installationCost .'",';
  	$returnJSON.= '"salesTax" :"'.$salesTax .'",';
  	$returnJSON.= '"discount" :"'.$discount .'",';
  	/*if(strcmp($quoteObj,"")==0)
  	{
  		$returnJSON.= '"quoteObj" :"'.ltrim($quoteObj,"{") .'"';
  	}
  	else*/
  	{
  		//$temp=ltrim($quoteObj,"{");
  		//$temp1  = str_replace($temp, "\"", "|");
  		//$returnJSON.= '"quoteObj" :'.ltrim($quoteObj,"{") .'';
  		$returnJSON.= '"quoteObj" :'.$quoteObj .'';
  	}
  	
    	
  	$returnJSON.= '},';
  	
  	flush();
  }
  $returnJSON=rtrim($returnJSON, ",");
  $returnJSON.='] }';

  echo $returnJSON;

?>