<html>
	<head>
	<script>
	function add_salesman()
	{
		var varbuilder="";
		//varbuilder+="sid="+sid+"&";
		varbuilder+="username="+document.getElementById("username").value+"&";
		varbuilder+="fname="+document.getElementById("fname").value+"&";
		varbuilder+="lname="+document.getElementById("lname").value+"&";
		varbuilder+="phone="+document.getElementById("phone").value+"&";
		varbuilder+="email="+document.getElementById("email").value+"&";
		varbuilder+="discount="+document.getElementById("discount").value+"&";
		varbuilder+="p="+document.getElementById("p").value;
		alert(varbuilder);
		
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
		xmlhttp2.open("POST","../includes/add_salesman.php",true);
		xmlhttp2.setRequestHeader("Content-type","application/x-www-form-urlencoded");
		xmlhttp2.send(varbuilder);
		
					
	}	
	</script>	
	</head>
	<body>
		<script type="text/JavaScript" src="../js/sha512.js"></script> 
		<script type="text/JavaScript" src="../js/forms.js"></script>
		<form >
			Username : <input type="text" id="username" name="username" value=""><br>
			First Name : <input type="text" id="fname" name="fname" value=""><br>
			Last Name : <input type="text" id="lname" name="lname" value=""><br>
			Phone Number : <input type="text" id="phone" name="phone" value=""><br>
			Email Id : <input type="text" id ="email" name="email" value=""><br>
			Discount : <input type="text" id="discount" name="discount" value=""><br>
			Password : <input type="text" id="password" name="password" value="defaultpassword"><br>
			<input type="button" value="Add" onclick="regformhash(this.form,
                                   this.form.username,
                                   this.form.email,
                                   this.form.password);add_salesman();">
		</form>		
	</body>
</html>