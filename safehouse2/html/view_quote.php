<html>
<head>

<style type="text/css">
	.hideCell{display:none;}
	.rightAlign{text-align:right;}
	.centerAlign{text-align:center;}
</style>
<script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.0/jquery.min.js"></script> 
<script type="text/javascript">

	function takeQuoteForModify()
	{
		//alert($("#hiddenTextBoxSelectedQuotation").val());
		
	        $('#selectedQuote > tbody > tr').each(function() {
	    		//Make qty editable
	    		var pid = $(this).find("td").eq(0).html(); 
	    		var _cell = $(this).find("td").eq(11);
      			_cell.data('text', _cell.html()).html('');
      
      			var $input = $('<input id="qty'+pid+'" type="text" onChange="getTotal();"/>')
        				.val(_cell.data('text'))
        				.width(_cell.width() );
        
      			_cell.append($input);
      			var deleteButton = '<td> <input id="delete' + pid +'" type="button" class="deleteButton" value="delete" onclick="del(this)"/></td>'; //Delete Button;
      			
      			$(this).append(deleteButton);
		});
	       
		
	}
	
	function isNumber(n) 
	{
  		return !isNaN(parseFloat(n)) && isFinite(n);
	}
	
	function del(rowID)
	{
		document.getElementById("selectedQuote").deleteRow(rowID.parentNode.parentNode.rowIndex);
		getTotal();
	}
	
	function getTotal()
	{
		var total = 0;
		$('#selectedQuote > tbody > tr').each(function() {
		
			var price = parseInt($(this).find("td").eq(9).html());
	    		var vat = parseInt($(this).find("td").eq(10).html());	
	    		var qty = parseInt($(this).find("td").eq(11).html());
			if(isNumber(qty))
			{
				total += ((price + (price * vat * 0.01))*qty);
			}
			else
			{
				var pid = $(this).find("td").eq(0).html();
				total += ((price + (price * vat * 0.01))*parseInt($("#qty"+pid).val()));
			}
	    		
	    		
		});
		
		$('#totalCost').html((Math.round(total * 100)/100).toFixed(2));
	}
	
	

	function viewQuote(viewButton)
	{
		var quoteID = $(viewButton).parent().parent().find("td").eq(0).html();
		//alert(quoteID);
		
	       $.ajax({
	            	url: '../includes/get_quotations.php',
            		data: 'qid=' + quoteID,
            		type: 'POST',
            		success: function(data) {
            			quoteJSON = JSON.parse(data);
                		var tableBody = '<table id="selectedQuote" border="1"><thead>';
                		tableBody += '<tr><th class="hideCell">ID</th>';
				tableBody += '<th>Product Name</th>';
				tableBody += '<th>Category</th>';
				tableBody += '<th>Company</th>';
				tableBody += '<th>Desc1</th>';
				tableBody += '<th>Desc2</th>';
				tableBody += '<th>Desc3</th>';
				tableBody += '<th>Desc4</th>';
				tableBody += '<th>Desc5</th>';
				tableBody += '<th>Price</th>';
				tableBody += '<th>VAT</th>';
				tableBody += '<th>Qty</th>';
				tableBody += '</tr></thead><tbody id="tableBody">';
				
				quoteJSON = quoteJSON.quotes[0].quoteObj.quotation;
				quoteJSON = quoteJSON[quoteJSON.length-1];
				
				quoteJSON = quoteJSON.products;
				
                  		for(i=0;i<quoteJSON.length;i++)
                		{
                			tableBody += '<tr><td class="hideCell">' + quoteJSON[i].pid + '</td>'; //PID                
			                tableBody += '<td>' + quoteJSON[i].pname + '</td>'; //Product Name
	        		        tableBody += '<td>' + quoteJSON[i].category + '</td>'; //Category
			                tableBody += '<td>' + quoteJSON[i].company + '</td>'; //Company
			                tableBody += '<td>' + quoteJSON[i].desc1 + '</td>'; //Desc1
		        	        tableBody += '<td>' + quoteJSON[i].desc2 + '</td>'; //Desc2
	        		        tableBody += '<td>' + quoteJSON[i].desc3 + '</td>'; //Desc3
				        tableBody += '<td>' + quoteJSON[i].desc4 + '</td>'; //Desc4
			                tableBody += '<td>' + quoteJSON[i].desc5 + '</td>'; //Desc5
			                tableBody += '<td>' + quoteJSON[i].price + '</td>'; //Price
		        	        tableBody += '<td>' + quoteJSON[i].vat + '</td>'; //vat
			                tableBody += '<td>' + quoteJSON[i].quantity + '</td>'; //qty
			                tableBody += '</tr>';
                		}
                		
                		tableBody += '</tbody><tfoot><tr><td></td><td></td><td></td><td></td><td></td><td colspan = "2">inclusive of VAT</td><td>Total: </td><td id="totalCost">0</td></tr></tfoot></table><input id="modifyQuote" type = "button" value="Modify" onClick="takeQuoteForModify();"></input>';
                		//alert(tableBody);
                		$("#selectedQuotesTable").html(tableBody);
                		$("#hiddenTextBoxSelectedQuotation").val(quoteID);
                		getTotal();

                	}
	        });
	}

	function populateQuoteTable()
	{
		var quoteJSON = "";
		//get quotation JSON for this salesman
		$.ajax({
	            	url: '../includes/get_quotations.php',
            		data: 'sid=' + $("#salesmanID").val(),
            		type: 'POST',
            		success: function(data) {
            		//alert(data);
                		quoteJSON = JSON.parse(data);
                		var tableBody = '<table id="quoteTable" border="1"><thead><tr><th class="hideCell">ID</th><th>Customer Name</th><th>Customer Type</th> <!--<th>Subject</th>--><th>Date</th><th>View Details</th></tr></thead><tbody id="tableBody">';
                		
                		for(i=0;i<quoteJSON.quotes.length;i++)
                		{
                			tableBody += "<tr><td class='hideCell'> " + quoteJSON.quotes[i].qid + "</td>" ;
                			tableBody += "<td>" + quoteJSON.quotes[i].customername + "</td>" 
                			var customerType = (quoteJSON.quotes[i].customertype == "c") ? "Customer" : "Dealer";
                			tableBody += "<td>" + customerType + "</td>" ;
                			//tableBody += "<td>" + quoteJSON.quotes.subject+ "</td>" ;
                			tableBody += "<td>" + quoteJSON.quotes[i].quotedate + "</td>" ;
                			tableBody += "<td class='centerAlign'>" + "<input type='button' value='View' onclick='viewQuote(this)'/>" + "</td></tr>";
                		}
                		
                		tableBody += '</tbody><tfoot></tfoot></table>';
                		//alert(tableBody);
                		$("#allQuotesTable").html(tableBody);
                	}
	        });
	        
	        
	}
	
	
</script>

</head>
<body>
<? echo '<input type="hidden" id = "salesmanID"  value = "'. $_GET["id"]. '">' ?>



<div id="allQuotesTable">
</div>
<script>populateQuoteTable();</script>
<div id="selectedQuotesTable">
</div>
<input id="hiddenTextBoxSelectedQuotation" type = "hidden" value = ""></input>

<div style="width:100%;">
<div id ="newVersion" style="float:left; width:70%;">  </div>
<div id ="addNewOptions" style="float:right; width:30%;">  </div>
</div>




</body>
</html>