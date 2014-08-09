<html>


<head>
<script>

	function add_prod()
	{
		var varbuilder="";
		//varbuilder+="sid="+sid+"&";
		varbuilder+="pname="+document.getElementById("pname").value+"&";
		varbuilder+="category="+document.getElementById("category").value+"&";
		varbuilder+="company="+document.getElementById("company").value+"&";
		varbuilder+="desc1="+document.getElementById("desc1").value+"&";
		varbuilder+="desc2="+document.getElementById("desc2").value+"&";
		varbuilder+="desc3="+document.getElementById("desc3").value+"&";
		varbuilder+="desc4="+document.getElementById("desc4").value+"&";
		varbuilder+="desc5="+document.getElementById("desc5").value+"&";
		varbuilder+="sellingprice="+document.getElementById("sellingprice").value+"&";
		varbuilder+="costprice="+document.getElementById("costprice").value+"&";
		varbuilder+="dealerprice="+document.getElementById("dealerprice").value+"&";
		varbuilder+="vat="+document.getElementById("vat").value;
		//alert(varbuilder);
		
		var xmlhttp2;
		if (window.XMLHttpRequest)
		  {// code for IE7+, Firefox, Chrome, Opera, Safari
			  xmlhttp2=new XMLHttpRequest();
		  }
		else
		  {// code for IE6, IE5
			  xmlhttp2=new ActiveXObject("Microsoft.XMLHTTP");
		  }
		xmlhttp2.onreadystatechange=function()
		  {
		  if (xmlhttp2.readyState==4 && xmlhttp2.status==200)
		    {
			    alert(xmlhttp2.responseText);
		    }
		  }
		xmlhttp2.open("POST","../includes/add_product.php",true);
		xmlhttp2.setRequestHeader("Content-type","application/x-www-form-urlencoded");
		xmlhttp2.send(varbuilder);
		
					
	}

</script>
</head>

<body>
	    Product name: <input type="text" id="pname" value=""><br>
            Category : <input type="text" id="category" value=""><br>
            Company : <input type="text" id="company" value=""><br>
            Description : 
             <input type="text" id="desc1" value=""><br>
             <input type="text" id="desc2" value=""><br>
             <input type="text" id="desc3" value=""><br>
             <input type="text" id="desc4" value=""><br>
             <input type="text" id="desc5" value=""><br>
            Selling Price: <input type="text" id="sellingprice" value=""><br>
            Cost Price: <input type="text" id="costprice" value=""><br>
            Dealer Price : <input type="text" id="dealerprice" value=""><br>
            Value added Tax ( VAT ) : <input type="text" id="vat" value=""><br>
            
            <input type="button" onClick="add_prod()" value="add product">
</body>
</html>