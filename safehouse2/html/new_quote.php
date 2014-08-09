<html>
	<head>
	
	<style type="text/css">
		.hideCell{display:none;}
		.rightAlign{text-align:right;}
		.centerAlign{text-align:center;}
	</style>
	
	
	<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.0/jquery.min.js"></script> 
	
	
	
	
	<script>
	
	function del(rowID)
	{
		document.getElementById("quoteTable").deleteRow(rowID.parentNode.parentNode.rowIndex);
		getTotal();
	}
	
	function makeJSONAndSend()
	{
		var flag = false;
		var jsonString='{"quotation":[ {  "version" : "1",    "date":"date", "subject" : "' + $("#subject").val() +'" , "totalPrice":""  , "products": [';
		
		$('#quoteTable tr:not(:first, :last)').each(function() {
			var pid = $(this).find("td").eq(0).html();
	    		jsonString += "{\"pid\" : \"" + pid + "\",\"pname\" : \"" + $(this).find("td").eq(1).html() + "\",\"category\" : \"" + $(this).find("td").eq(2).html() +"\",\"company\" : \"" + $(this).find("td").eq(3).html() +"\",\"desc1\" : \"" + $(this).find("td").eq(4).html() + "\",\"desc2\" : \"" + $(this).find("td").eq(5).html() + "\",\"desc3\" : \"" + $(this).find("td").eq(6).html() + "\",\"desc4\" : \"" + $(this).find("td").eq(7).html() + "\",\"desc5\" : \"" + $(this).find("td").eq(8).html() + "\",\"price\" : \"" + $(this).find("td").eq(9).html() + "\",\"vat\" : \"" + $(this).find("td").eq(11).html() + "\",\"quantity\" : \"" +$("#qty" + pid).val() +"\" },";
	    		flag = true;
		});
		
		if(flag)
		{
			jsonString = jsonString.slice(0,-1);
			jsonString += "] } ] }";
			
			var customerType = ($('#radioCust').is(':checked'))?"c":"d";
			var finalText = "";
			finalText += "customername="+$("#customerName").val() + "&";
			finalText += "quotedate=" + "&";
			finalText += "salesmanID=" + $("#salesmanID").val() + "&";
			finalText += "customerEmail=" + "&";
			finalText += "accountPhone=" + "&";
			finalText += "salesPhone=" + "&";
			finalText += "ownerPhone=" + "&";
			finalText += "cstNo=" + "&";
			finalText += "tinNo=" + "&";
			finalText += "totalPrice=" + $("#totalCost").html() +"&" ;
			finalText += "installationCost=" + "&";
			finalText += "salesTax=" + "&";
			finalText += "discount=" + "&";
			finalText +="customertype=" + customerType + "&"
			finalText += "quoteObj=" + jsonString ;
		//alert($("#salesmanID").val());
		
			$('#JSON').html(jsonString);
		
			var xmlhttp_addQuote;
			if (window.XMLHttpRequest)
		  	{// code for IE7+, Firefox, Chrome, Opera, Safari
			  xmlhttp_addQuote=new XMLHttpRequest();
		  	}
			else
		  	{// code for IE6, IE5
			  xmlhttp_addQuote=new ActiveXObject("Microsoft.XMLHTTP");
		  	}
			xmlhttp_addQuote.onreadystatechange=function()
		  	{
		 	    if (xmlhttp_addQuote.readyState==4 && xmlhttp_addQuote.status==200)
			    {
				    //document.getElementById("results").innerHTML=(xmlhttp2.responseText);
				    // Got back JSON
				    //$('#JSON').html(xmlhttp_addQuote.responseText);
				    
			    }
		  	}
			xmlhttp_addQuote.open("POST","../includes/add_quote.php",true);
			xmlhttp_addQuote.setRequestHeader("Content-type","application/x-www-form-urlencoded");
			xmlhttp_addQuote.send(finalText);
		}
	}
	
	
	function toggleTables()
	{
		$('#quoteTable tr:not(:first, :last)').each(function() {
	    		var tmp = $(this).find("td").eq(9).html(); 
	    		$(this).find("td").eq(9).html( $(this).find("td").eq(10).html());
	    		$(this).find("td").eq(10).html(tmp) ;
		});
		$('#productsTable tr').each(function() {
	    		var tmp = $(this).find("td").eq(9).html(); 
	    		$(this).find("td").eq(9).html( $(this).find("td").eq(10).html());
	    		$(this).find("td").eq(10).html(tmp) ;
		});
		getTotal();
		
	}
	
	function getTotal()
	{
		var total = 0;
		$('#quoteTable tr:not(:first, :last)').each(function() {
			var pid = $(this).find("td").eq(0).html();
	    		var price = parseInt($(this).find("td").eq(9).html());
	    		var vat = parseInt($(this).find("td").eq(11).html());	
	    		var qty = parseInt($("#qty"+pid).val());  		
	    		total += ((price + (price * vat * 0.01))*qty);
		});
		
		$('#totalCost').html((Math.round(total * 100)/100).toFixed(2));
	}
	
	function addToQuote(rowID)
	{
		
		var myRow = document.getElementById("rowNo" + rowID);
                var cells = myRow.getElementsByTagName('td');
                var data= "<tr>";
                var pid = cells[0].innerHTML;
                var qty = document.getElementById("textBox" + rowID).value;
                
                var flag = true;
                
                $('#quoteTable tr').each(function() {
	    		var existingPid = $(this).find("td").eq(0).html(); 
	    		if(pid == existingPid)
	    		{
	    			flag = false;
	    			//$("#qty" + pid).val(parseInt($("#qty" + pid).val()) + parseInt(qty));
	    			var tmpQty = (parseInt($("#qty" + pid).val()) + parseInt(qty));
	    			$("#qty" + pid).parent().html('<input id=qty'+ pid + ' type="text" value="' + tmpQty +'" size="4" class="rightAlign" onchange="getTotal();"/>');
	    			
	    		}
		});
                
                if(flag)
                {
                
                	data += '<td class="hideCell">' + pid + '</td>'; //PID                
	                data += '<td>' + cells[1].innerHTML + '</td>'; //Product Name
	                data += '<td>' + cells[2].innerHTML + '</td>'; //Category
	                data += '<td>' + cells[3].innerHTML + '</td>'; //Company
	                data += '<td>' + cells[4].innerHTML + '</td>'; //Desc1
        	        data += '<td>' + cells[5].innerHTML + '</td>'; //Desc2
	                data += '<td>' + cells[6].innerHTML + '</td>'; //Desc3
		        data += '<td>' + cells[7].innerHTML + '</td>'; //Desc4
	                data += '<td>' + cells[8].innerHTML + '</td>'; //Desc5
	                data += '<td>' + cells[9].innerHTML + '</td>'; //Price
	                data += '<td class="hideCell">' + cells[10].innerHTML + '</td>'; //TogglePrice
        	        data += '<td>' + cells[11].innerHTML + '</td>'; //vat
	                data += '<td><input id=qty'+ pid + ' type="text" value="' + qty +'" size="4" class="rightAlign" onchange="getTotal();"/></td>'; //qty
			data += '<td> <input id=delete' + pid +' type="button" class="deleteButton" value="delete" onclick="del(this)"/></td>'; //Delete Button
	                data += '</tr>';
                
        	        tableDiv = document.getElementById("tableBody");
                	tableDiv.innerHTML +=  data;
                }
                
                getTotal();
	}
	
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
                
                var data = "<table id='productsTable' border=\"1\"><thead><tr><th class='hideCell'>ID</th><th>Product Name</th><th>Category</th><th>Company</th><th>Desc1</th><th>Desc2</th><th>Desc3</th><th>Desc4</th><th>Desc5</th><th>Price</th><th class='hideCell'>Toggle Price</th><th>VAT</th><th>Qty</th><th>Add to Quotation</th></tr></thead><tbody>";
                
                for(i=0;i<parsedJSON.products.length;i++)
                {
                    data += "<tr id=rowNo"+ i + "><td class='hideCell'>" + parsedJSON.products[i].pid + "</td><td>"
                    + parsedJSON.products[i].pname + "</td><td>" 
                    + parsedJSON.products[i].category + "</td><td>"
                    + parsedJSON.products[i].company + "</td><td>"
                    + parsedJSON.products[i].desc1 + "</td><td>"
                    + parsedJSON.products[i].desc2 + "</td><td>"
                    + parsedJSON.products[i].desc3  + "</td><td >"
                    + parsedJSON.products[i].desc4 + "</td><td >"
                    + parsedJSON.products[i].desc5 + "</td><td >";
                    if(document.getElementById('radioCust').checked)
                    {
                    	data += parsedJSON.products[i].sellingprice + "</td><td class='hideCell' >"
                    		+ parsedJSON.products[i].dealerprice + "</td><td >";
                    }
                    else
                    {
                    	data += parsedJSON.products[i].dealerprice+ "</td><td class='hideCell' >"
                    		+ parsedJSON.products[i].sellingprice + "</td><td >";
                    }
                    
                    data += parsedJSON.products[i].vat + "</td><td>"
                    +"<input id=textBox"+ i +" type=\"text\" value=\"1\" size='4' class='rightAlign'></td>"
                    +"<td class='centerAlign'><input type=\"button\" value=\"Add\" onClick='addToQuote("+ i +");' ></td></tr>";
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
	<script>populateCompany();populateCategory();</script>	
	<? echo '<input type="hidden" id = "salesmanID"  value = "'. $_GET["id"]. '">' ?>
	
	Customer Name: <input type="text" id="customerName">  <input type="radio" id="radioCust" name="custType" value="c" checked="checked" onchange="toggleTables()">Customer
<input type="radio" id="radioDeal" name="custType" value="d" onchange="toggleTables()">Dealer<br>
	
  	Subject: <input type="text" id="subject"> <br>
	Product Name :
	<input type="text" id="pname_text" value=""><span id="error_p"></span>
	<input type="button" value="Search via Product Name" onClick="onPsearch();"><br>

	Category Name :<select id="cat_list" name="cat_list"></select>
	
	Company Name :<select id="comp_list" name="comp_list"></select>
	
	<span id="error_comp"></span>
	<input type="button" value="Search via Company name and Category" onClick="onC_Csearch();"><br>



<div id=results>&nbsp
</div>

<table id="quoteTable" border="1">
  <thead>
    <tr>
      <th class="hideCell">ID</th>
      <th>Product Name</th>
      <th>Category</th>
      <th>Company</th>
      <th>Desc1</th>
      <th>Desc2</th>
      <th>Desc3</th>
      <th>Desc4</th>
      <th>Desc5</th>
      <th>Price</th>
      <th class="hideCell">Toggle Price</th>
      <th>VAT</th>
      <th>Qty</th>
      <th>Delete</th>
    </tr>
  </thead>
  <tbody id="tableBody">
  </tbody>
  <tfoot>
  <tr><td></td><td></td><td></td><td></td><td></td><td></td><td colspan = "2">inclusive of VAT</td><td>Total: </td><td id="totalCost">0</td></tr>
  </tfoot>
</table>

<input type = "button" value="Save" onClick="makeJSONAndSend();">

<div id="JSON"></div>

</body>


</html>