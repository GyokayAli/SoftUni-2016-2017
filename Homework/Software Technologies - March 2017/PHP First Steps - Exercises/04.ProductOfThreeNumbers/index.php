<?php
$output = "";
if(isset($_GET['num1']) && isset($_GET['num2']) && isset($_GET['num3'])){
    $n = intval($_GET['num1']);
    $m = intval($_GET['num2']);
    $k = intval($_GET['num3']);

    $count = 0;

    if($n == 0 || $m == 0 || $k == 0){
        $output = "Positive";
    }else{
        if($n < 0)
            $count++;
        if($m < 0)
            $count++;
        if($k < 0)
            $count++;

        if($count % 2 == 0)
            $output = "Positive";
        else
            $output = "Negative";
    }
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
    X: <input type="text" name="num1" />
    Y: <input type="text" name="num2" />
    Z: <input type="text" name="num3" />
    <input type="submit" />
</form>
<span><?= $output ?></span>
</body>
</html>