self.addEventListener("message", function (event) {
    const number = event.data;
    const factorial = calculateFactorial(number);
    self.postMessage(factorial);
});

function calculateFactorial(number) {
    if ((number == 0) || (number == 1)) {
        return 1;
    }
    let result = 1;
    for (let i = 2; i <= number; i++) {
        result *= i;
    }
    return result;
}
