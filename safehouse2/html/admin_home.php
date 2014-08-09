<?php

include_once '../includes/db_connect.php';
include_once '../includes/functions.php';

sec_session_start();
?>
<!DOCTYPE html>
<html>
    <head>
        <!--[if lt IE 9]>
	<script src="//html5shim.googlecode.com/svn/trunk/html5.js"></script>
	<![endif]-->
	<style>
            html { text-align: center; font-family: sans-serif; }
            body { width: 99%; margin: 0 auto 0 auto; text-align: left; }
            header,footer { width: 99%; display: table; }
            nav { width: 20%; float: left; display: table; }
            article { width: 80%; display: table; }
	    footer { font-size: 10px;text-align: right; position:absolute;bottom:0;}
	    header { text-align: center; }
	    input.logoutButton {float: right}
	</style>
        <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.6.0/jquery.min.js"></script>
        <script type="text/javascript">
            function loadContent(navigateTo) {
                
                    $("#dynamicContent").load(navigateTo+".php?id=" + $("#salesmanID").val());    
           
            }
            
           function populateSalesmanID(){
           //alert($("#username").html());
           	$.ajax({
	            	url: '../includes/get_userid.php',
            		data: 'username=' + $("#username").html(),
            		type: 'POST',
            		success: function(data) {
                		$("#salesmanID").val(data);
                		//alert(data);
            		}
	        });
           } 
        </script>
    </head>
    
    <body>
      
        <?php if (login_check($mysqli) == true) : ?>
       
        
        
            <header>
		<h1>Comapny Name</h1>
		<input class="logoutButton" type="button" name="logout" value="Logout" onclick="location.href='../includes/logout.php'">
	    </header>
	    <nav class="navigation">
                <p>Welcome <span id = "username"><?php echo htmlentities($_SESSION['username']); ?></span>! </p>
                
                <ul>
                    <li><input type="button" name="addSalesman" value="Add Salesman" onclick="loadContent('add_salesman');"></li>
                    <li><input type="button" name="modDelSalesman" value="Modify/Delete Salesman" onclick="loadContent('modify_salesman');"></li>
                    <li><input type="button" name="newQuote" value="Make a Quote" onclick="loadContent('new_quote');"></li>
                    <li><input type="button" name="viewQuote" value="View Quote" onclick="loadContent('view_quote');"></li>
                    <li><input type="button" name="newProduct" value="Add Product" onclick="loadContent('add_product');"></li>
                    <li><input type="button" name="viewProduct" value="Modify/Delete Product" onclick="loadContent('modify_product');"></li>
                    <li><input type="button" name="report" value="Reports"></li>
		</ul>
	    </nav>
            <article>
            	 <input type="hidden" id = "salesmanID"  value = ""/>
            	 <script>populateSalesmanID();</script>
                <div id="dynamicContent" class="dynamicContent">
                    This is the contents of the article element.
                </div>
	    </article>
            <footer>
                Powered by <a href="minesweepers.co">Minesweepers</a>
            </footer>
        <?php else : ?>
            <p>
                <span class="error">You are not authorized to access this page.</span> Please <a href="../loginScreen.php">login</a>.
            </p>
        <?php endif; ?>
    </body>
</html>