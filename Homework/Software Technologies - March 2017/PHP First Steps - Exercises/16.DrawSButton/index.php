<?php
function blankButton(){
    echo "<button>0</button>";
}
function blueButton(){
    echo "<button style='background-color: blue;'>1</button>";
}
?>
<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <title>First Steps Into PHP</title>
</head>
<body>
<?php
    for ($i = 1; $i <= 9; $i++ ){
        if($i == 1 || $i == 5 || $i == 9){
            for($j = 1; $j <= 5; $j ++) {
                blueButton();
            }
        }
        if($i > 1 && $i < 5){
            blueButton();
            for($j = 1; $j <= 4; $j ++) {
                blankButton();
            }
        }
        if($i > 5 && $i < 9){
            for($j = 1; $j <= 4; $j ++) {
                blankButton();
            }
            blueButton();
        }
        ?> <br /> <?php
    }
?>
</body>
</html>