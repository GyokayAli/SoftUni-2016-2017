<?php
$output = "";
if(isset($_GET['num'])){
    $n = intval($_GET['num']);
    $fact = 1;
    for($i = 1; $i <= $n; $i++){
        $fact = $fact * $i;
    }
    $output = $fact;
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<form>
    N: <input type="text" name="num" />
    <input type="submit" />
</form>
<span><?= $output ?></span>
</body>
</html>