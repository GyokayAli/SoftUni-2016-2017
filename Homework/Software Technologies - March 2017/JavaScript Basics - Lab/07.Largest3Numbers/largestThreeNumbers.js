function findLargestThreeNums(arr){
    let count = 3;
    let nums = arr.sort(function(a, b){return b - a}).slice(0, count)

    nums.forEach(function(n) {
        console.log(n);
    });
}