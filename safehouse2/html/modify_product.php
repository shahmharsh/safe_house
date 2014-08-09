<html>
	<head>
	
	<script>
	    function goDelete(rowID)
	    {
	    	var myRow = document.getElementById("rowNo" + rowID);
                var cells = myRow.getElementsByTagName('td');
                 
	    	var query_var = "pid="+cells[0].innerHTML;
	    	var xmlhttp3;
		if (window.XMLHttpRequest)
		  {// code for IE7+, Firefox, Chrome, Opera, Safari
			  xmlhttp3=new XMLHttpRequest();
		  }
		else
		  {// code for IE6, IE5
			  xmlhttp3=new ActiveXObject("Microsoft.XMLHTTP");
		  }
		xmlhttp3.onreadystatechange=function()
		  {
		 	 if (xmlhttp3.readyState==4 && xmlhttp3.status==200)
			    {
			    	//var txt=//success
			    }
		  }
		xmlhttp3.open("POST","../includes/delete_product.php",true);
		xmlhttp3.setRequestHeader("Content-type","application/x-www-form-urlencoded");
		xmlhttp3.send(query_var);
	    }
            function goModify(rowID) {
                var myRow = document.getElementById("rowNo" + rowID);
                var cells = myRow.getElementsByTagName('td');
                var data= "";
                
                data += 'desc1=' + cells[4].innerHTML + "&";
                data += 'desc2=' + cells[5].innerHTML + "&";
                data += 'desc3=' + cells[6].innerHTML + "&";
                data += 'desc4=' + cells[7].innerHTML + "&";
                data += 'desc5=' + cells[8].innerHTML + "&";
                data += 'sellingprice=' + cells[9].innerHTML + "&";
                data += 'costprice=' + cells[10].innerHTML + "&";
                data += 'dealerprice=' + cells[11].innerHTML + "&";
                data += 'vat=' + cells[12].innerHTML + "&";
                data += 'pid=' + cells[0].innerHTML;
                //alert(data);
                //$res="UPDATE  product SET desc1='$_POST[desc1]' , desc2='$_POST[desc2]' , desc3='$_POST[desc3]' , desc4 = '$_POST[desc4]' , desc5= '$_POST[desc5]' , sellingprice='$_POST[sellingprice]' , costprice='$_POST[costprice]' , dealerprice='$_POST[dealerprice]' , vat='$_POST[vat]'  where pid='$_POST[pid]'";
                
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
			    	//success
			    }
		  }
		xmlhttp2.open("POST","../includes/modify_product.php",true);
		xmlhttp2.setRequestHeader("Content-type","application/x-www-form-urlencoded");
		xmlhttp2.send(data);
            }
        </script>
	
	<script>	
	
	
	
	function goSearch(sid, pname_val, cat_val, comp_val)
	{
		finaltext='';
		finaltext+='id='+sid+'&';
		finaltext+='pname='+pname_val+'&';
		finaltext+='cat='+cat_val+'&';
		finaltext+='comp='+comp_val;


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
				    //document.getElementById("results").innerHTML=(xmlhttp2.responseText);
				    // Got back JSON
				    
				    var parsedJSON = JSON.parse(xmlhttp2.responseText);
                
                var data = "<table border=\"1\"><thead><tr><th>ID</th><th>Product Name</th><th>Category</th><th>Company</th><th>Desc1</th><th>Desc2</th><th>Desc3</th><th>Desc4</th><th>Desc5</th><th>Selling Price</th><th>Cost Price</th><th>Dealer Price</th><th>VAT</th><th>Edit</th><th>Delete</th></tr></thead><tbody>";
                
                for(i=0;i<parsedJSON.products.length;i++)
                {
                    data += "<tr id=rowNo"+ i + "><td>" + parsedJSON.products[i].pid + "</td><td>"+ parsedJSON.products[i].pname + "</td><td>" + parsedJSON.products[i].category + "</td><td>"+ parsedJSON.products[i].company + "</td><td contenteditable=\"true\">"+ parsedJSON.products[i].desc1 + "</td><td contenteditable=\"true\">"+ parsedJSON.products[i].desc2 + "</td><td contenteditable=\"true\">"+ parsedJSON.products[i].desc3  + "</td><td contenteditable=\"true\">"+ parsedJSON.products[i].desc4 + "</td><td contenteditable=\"true\">"+ parsedJSON.products[i].desc5 + "</td><td contenteditable=\"true\">"+ parsedJSON.products[i].sellingprice + "</td><td contenteditable=\"true\">"+ parsedJSON.products[i].costprice +  "</td><td contenteditable=\"true\">"+ parsedJSON.products[i].dealerprice + "</td><td contenteditable=\"true\">"+ parsedJSON.products[i].vat + "</td><td><input type=\"button\" value=\"Save\" onclick=\"goModify(" + i + ");\"></td><td><input type=\"button\" value=\"Delete\" onclick=\"goDelete(" + i + ");\"></td></tr>";
                }
                
                data += "</tbody></table>"
                document.getElementById("results").innerHTML= data;
			    }
		  }
		xmlhttp2.open("POST","../includes/search_product.php",true);
		xmlhttp2.setRequestHeader("Content-type","application/x-www-form-urlencoded");
		xmlhttp2.send(finaltext);
	
	}


	function onPsearch()
	{
		sid=0;
		pname_val="";
		cat_val="";
		comp_val="";
		document.getElementById("results").innerHTML="";
			if(document.getElementById("pname_text").value=="")
			{
				document.getElementById("error_p").innerHTML="Blank Product Name !";
			}
			else
			{
				sid=1;
				document.getElementById("error_p").innerHTML="";
				document.getElementById("results").innerHTML="clicked pname";
				pname_val=document.getElementById("pname_text").value;
				cat_val="";
				comp_val="";
                                goSearch(sid, pname_val, cat_val, comp_val);
				// call search function AJAX
			}
	}

	function onC_Csearch()
	{
	
		var comp_option = document.getElementById("comp_list");
		var select_comp = comp_option.options[comp_option.selectedIndex].value;
		
		var cat_option = document.getElementById("cat_list");
		var select_cat = cat_option.options[cat_option.selectedIndex].value;
		
		sid=0;
		pname_val="";
		cat_val="";
		comp_val="";
			document.getElementById("results").innerHTML="";
			if(select_comp=="null" && select_cat=="null" )
			{
				document.getElementById("error_comp").innerHTML="Both Company and category empty !";
			}
			else
			{
				pname_val="";
				document.getElementById("error_comp").innerHTML="";
				document.getElementById("results").innerHTML="clicked cat&comp";
				if(select_cat=="null")
				{
					sid=2; 	// only company
					cat_val="";
					comp_val=select_comp;
				}
				else if(select_comp=="null")
				{
					sid=3;	// only category
					comp_val="";
					cat_val=select_cat;
				}
				else
				{
					sid=4;	// category + company
					comp_val=select_comp;
					cat_val=select_cat;
				}

				goSearch(sid, pname_val, cat_val, comp_val);
				// call AJAX search

			}

	}
	function populateCompany()
	{
		 var xmlhttp_comp;
		if (window.XMLHttpRequest)
		  {// code for IE7+, Firefox, Chrome, Opera, Safari
			  xmlhttp_comp=new XMLHttpRequest();
		  }
		else
		  {// code for IE6, IE5
			  xmlhttp_comp=new ActiveXObject("Microsoft.XMLHTTP");
		  }
		xmlhttp_comp.onreadystatechange=function()
		  {
		 	 if (xmlhttp_comp.readyState==4 && xmlhttp_comp.status==200)
			    {
			    	var result = xmlhttp_comp.responseText;
			    	var list_of_companies= new Array();
			    	list_of_companies = result.split("|");
			    	var select_element  = document.getElementById("comp_list");
			    	select_element.innerHTML = "<option value='null' selected>---------</option>"
			    	
			    	for(var i=0;i<list_of_companies.length;i++)
			    	{
			    		select_element.innerHTML+="<option value='"+list_of_companies[i]+"'>"+list_of_companies[i]+"</option>";
			    	}
			    	
			    }
		  }
		xmlhttp_comp.open("POST","../includes/get_company_list.php",true);
		xmlhttp_comp.setRequestHeader("Content-type","application/x-www-form-urlencoded");
		xmlhttp_comp.send();
	}
	
	function populateCategory()
	{
		 var xmlhttp_cat;
		if (window.XMLHttpRequest)
		  {// code for IE7+, Firefox, Chrome, Opera, Safari
			  xmlhttp_cat=new XMLHttpRequest();
		  }
		else
		  {// code for IE6, IE5
			  xmlhttp_cat=new ActiveXObject("Microsoft.XMLHTTP");
		  }
		xmlhttp_cat.onreadystatechange=function()
		  {
		 	 if (xmlhttp_cat.readyState==4 && xmlhttp_cat.status==200)
			    {
			    	var result = xmlhttp_cat.responseText;
			    	var list_of_companies= new Array();
			    	list_of_companies = result.split("|");
			    	var select_element  = document.getElementById("cat_list");
			    	select_element.innerHTML = "<option value='null' selected>---------</option>"
			    	
			    	for(var i=0;i<list_of_companies.length;i++)
			    	{
			    		select_element.innerHTML+="<option value='"+list_of_companies[i]+"'>"+list_of_companies[i]+"</option>";
			    	}
			    	
			    }
		  }
		xmlhttp_cat.open("POST","../includes/get_category_list.php",true);
		xmlhttp_cat.setRequestHeader("Content-type","application/x-www-form-urlencoded");
		xmlhttp_cat.send();
	}
	
	</script>
	</head>


<body>
<script>
populateCompany();populateCategory();
</script>

	<form >
	Product Name :
	<input type="text" id="pname_text" value=""><span id="error_p"></span>
	<input type="button" value="Search via Product Name" onClick="onPsearch();"><br>

	Category Name :<select id="cat_list" name="cat_list"></select>
	
	Company Name :<select id="comp_list" name="comp_list"></select>
	
	<span id="error_comp"></span>
	<input type="button" value="Search via Company name and Category" onClick="onC_Csearch();"><br>
	
	


	</form>


<div id=results>&nbsp
</div>
</body>


</html>