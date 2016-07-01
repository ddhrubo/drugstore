<?php 
	ob_start(); 
	require "common.php";
?>

<html>
<head>
	<title></title>
	<style type="text/css">
		#upper_div {
			background-image: url("img/index/mainback.png");
			background-size: 100%;

			width: 100%;
		}
		#lower_div {
			background-size: 100%;

			width: 100%;
		}
		#lower_body {
			padding: 10%;
			padding-top: 0;

			color: rgb(90,90,90);
			font-family: sans-serif;
		}
		#upper_body {
			padding: 10%;

			color: rgb(245,245,245);
			font-family: sans-serif;
		}
		.upper_text {
			text-align: center;

			/*For ease on grow effect*/
            -webkit-transition:all 0.2s ease-out;
            -moz-transition:all 0.2s ease-out;
            -ms-transition:all 0.2s ease-out;
            -o-transition:all 0.2s ease-out;
            transition:all 0.2s ease-out;
		}
		.upper_text:hover {
			text-align: center;

			-webkit-transform: scale(1.3);
            -ms-transform: scale(1.3);
        	transform: scale(1.3);
		}
		.h01 {
			font-size: 80px;
			margin-bottom: 10px;
		}
		.h02 {
			font-size: 25px;
			margin-top: 0;
		}
		.h03 {
			font-size: 50px;
		}
		#menu_form {
			margin-top: 150px;
		}
		input[type=submit] {
			color: rgb(245,245,245);
			font-size: 25px;
			font-family: sans-serif;

			padding: 10px;
			margin-bottom: 15px;

			background-color: rgba(0,0,0,0);

			border: 2px solid;
			border-color: rgb(245,245,245);
			border-radius: 10px;

			/*For ease on grow effect*/
            -webkit-transition:all 0.2s ease-out;
            -moz-transition:all 0.2s ease-out;
            -ms-transition:all 0.2s ease-out;
            -o-transition:all 0.2s ease-out;
            transition:all 0.2s ease-out;
		}
		input[type=submit]:hover {
			cursor: pointer;
		}
	</style>
</head>
<body>
	<div id="upper_div" >
		<div id="upper_body" >
			<div class="upper_text" >
				<h1 class="h01" >Mozumdar Drug Store</h1>
				<h1 class="h02" >Live healthy. Live happy. Live Long.</h1>
			</div>
			<form id="menu_form" >
				<input class="grow" type="submit" name="browse" value="Browse Drugs" ><br>
				<input class="grow" type="submit" name="a" value="Button A" ><br>
				<input class="grow" type="submit" name="b" value="Button B" ><br>
			</form>
		</div>
	</div>

	<div id="lower_div" >
		<div id="lower_body" >
			<h1 class="h03" >Contact us</h1>
			<p class="h02" >
				<b>Mozumdar Drug Store</b><br>
				Mirpur<br>
				Dhaka<br>
				Bangladesh<br>
			</p>
		</div>
	</div>
</body>
</html>