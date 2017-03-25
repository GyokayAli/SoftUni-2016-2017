function symmetricNumbers(arr){
    let n = Number(arr[0]);

    let numbers = [];
    for (let i = 1; i <= n; i++)
        if (isSymmetric(i.toString()))
            numbers.push(i);
    console.log(numbers.join(" "));

    function isSymmetric(str) {
        for (let i = 0; i < str.length / 2; i++)
            if (str[i] != str[str.length - i - 1])
                return false;
        return true;
    }
}