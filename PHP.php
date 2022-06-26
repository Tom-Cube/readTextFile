<!DOCTYPE html>
<html>
<body>
	<?php
		$myfile = fopen("txt.txt", "r") or die("Unable to open file!");
		echo fread($myfile,filesize("txt.txt"));
		fclose($myfile);
	?> 
</body>
</html>