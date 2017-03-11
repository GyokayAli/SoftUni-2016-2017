<?php
$output = "";
if(isset($_GET['num'])){
    $n = intval($_GET['num']);

    for($i = $n; $i > 1; $i--){
        if(isPrime($i)){
            $output .= " " . $i;
        }
    }
}

function isPrime(int $i) : int {
    $n = 2;
    while ($n < $i) {
        if ($i % $n) {
            $n++;
            continue;
        }
        return false;
    }
    return true;
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