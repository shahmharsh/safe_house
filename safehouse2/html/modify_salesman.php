<html>
	<head>
	<script>	
	sid=0;
	
	function delete_info()
	{
		if(confirm("Are you sure you want to delete this User ?"))
		{
			var passer="";
			passer+="sid="+sid;
			
			
			var xmlhttp;
			if (window.XMLHttpRequest)
			  {// code for IE7+, Firefox, Chrome, Opera, Safari
				  xmlhttp=new XMLHttpRequest();
			  }
			else
			  {// code for IE6, IE5
				  xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
			  }
			xmlhttp.onreadystatechange=function()
			  {
			  if (xmlhttp.readyState==4 && xmlhttp.status==200)
			    {
				    alert(xmlhttp.responseText);
			    }
			  }
			xmlhttp.open("POST","../includes/delete_salesman.php",true);
			xmlhttp.setRequestHeader("Content-type","application/x-www-form-urlencoded");
			xmlhttp.send(passer);
			
		}
	}
	
	function update_info()
	{
		var varbuilder="";
		varbuilder+="sid="+sid+"&";
		varbuilder+="fname="+document.getElementById("fname_final").value+"&";
		varbuilder+="lname="+document.getElementById("lname_final").value+"&";
		varbuilder+="username="+document.getElementById("username_final").value+"&";
		varbuilder+="email="+document.getElementById("email_final").value+"&";
		varbuilder+="phone="+document.getElementById("phone_final").value+"&";
		varbuilder+="discount="+document.getElementById("discount_final").value;
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
		xmlhttp2.open("POST","../includes/modify_salesman.php",true);
		xmlhttp2.setRequestHeader("Content-type","application/x-www-form-urlencoded");
		xmlhttp2.send(varbuilder);
		
					
	}
	
	
	function fill_form(jsontxt)
	{
		var div_to_fill = document.getElementById("results");
		//div_to_fill.innerHTML =div_to_fill.innerHTML+ "clicked !!";
		if(jsontxt=="")
		{
			div_to_fill.innerHTML ="user not found !";
			return;
		}
		var obj = eval ("(" + jsontxt + ")");
		var finaltext='';
		sid=obj.sid;
		finaltext=finaltext + ' username : <input id="username_final" type="text" value="'+obj.username+'"/><br/>';
		finaltext=finaltext + ' First Name : <input id="fname_final" type="text" value="'+obj.fname+'"/><br/>';
		finaltext=finaltext + ' Last Name : <input id="lname_final" type="text" value="'+obj.lname+'"/><br/>';
		finaltext=finaltext + ' Email : <input id="email_final" type="text" value="'+obj.email+'"/><br/>';
		finaltext=finaltext + ' Phone No : <input id="phone_final" type="text" value="'+obj.phone+'"/><br/>';
		finaltext=finaltext + ' Discount : <input id="discount_final" type="text" value="'+obj.discount+'"/><br/>';
		finaltext=finaltext + ' <input  type="button" value="Modify" onClick="update_info()"/>';
		finaltext=finaltext + ' <input  type="button" value="Delete" onClick="delete_info()"/><br/>';
		div_to_fill.innerHTML=finaltext;
	}	

	function showUser(str)
	{
		var xmlhttp;
		if (window.XMLHttpRequest)
		  {// code for IE7+, Firefox, Chrome, Opera, Safari
			  xmlhttp=new XMLHttpRequest();
		  }
		else
		  {// code for IE6, IE5
			  xmlhttp=new ActiveXObject("Microsoft.XMLHTTP");
		  }
		xmlhttp.onreadystatechange=function()
		  {
			  if (xmlhttp.readyState==4 && xmlhttp.status==200)
			    {
				    fill_form(xmlhttp.responseText);
			    }
		  }
		xmlhttp.open("GET","../includes/search_salesman.php?username="+String(str),true);
		xmlhttp.send();
	}
	
	function onSearchClick()
	{
		sid=0;
		var error_div=document.getElementById("error");
		var div_to_filled = document.getElementById("results");
		div_to_filled.innerHTML ="";
		//var username_value=document.getElementById("username").value;
		if (document.getElementById("username").value=="")
		{
			error_div.innerHTML="Blank Username !";
			//return;
		}			
		else
		{
			error_div.innerHTML="";
			showUser(document.getElementById("username").value);
			//var div_to_filled = document.getElementById("results");
			//div_to_filled.innerHTML ="";
		}
	}
	</script>
	</head>


<body>

	<form >
	Enter user name : 
	<input type="text" id="username" value=""><span id="error"></span><br>
	<input type="button" id="search" name="search" value="Search" onClick="onSearchClick()">
	</form>
<div id=results>&nbsp
</div>
</body>


</html>