function extractCapitalCaseWords(arr) {
    let text = arr.join(",");
    let words = text.split(/\W+/);
    let uppercaseWords = words
        .filter(w => w.length > 0)
        .filter(x => x.toUpperCase() == x);
    console.log(uppercaseWords.join(", "));
}