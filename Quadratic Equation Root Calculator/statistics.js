class NumberList {
    constructor(numbers) {
        this.numbers = numbers;
    }

    mean() {
        return this.numbers.reduce((acc, val) => acc + val, 0) / this.numbers.length;
    }

    variance() {
        const mean = this.mean();
        return this.numbers.reduce((acc, val) => acc + Math.pow(val - mean, 2), 0) / this.numbers.length;
    }

    stdDeviation() {
        return Math.sqrt(this.variance());
    }
}

function validateInput(numbersInput) {
    const numbersArray = numbersInput.split(" ").filter(num => num !== "").map(Number);

    if (numbersArray.length === 0) {
        displayError("Please enter at least one number.");
        return null;
    }

    if (numbersArray.some(isNaN)) {
        displayError("Invalid input. Please enter numbers separated by one or more spaces.");
        return null;
    }

    return numbersArray;
}

function displayError(message) {
    document.getElementById('output').style.color = 'red';
    document.getElementById('output').textContent = message;
    document.getElementById('result').style.display = 'block';
}

function calculateMean() {
    const numbersInput = document.getElementById('numbers').value.trim();
    const numbersArray = validateInput(numbersInput);

    if (numbersArray) {
        const numberList = new NumberList(numbersArray);
        const mean = numberList.mean();
        document.getElementById('output').style.color = 'green';
        document.getElementById('output').textContent = `Mean: ${mean.toFixed(2)}`;
        document.getElementById('result').style.display = 'block';
    }
}

function calculateVariance() {
    const numbersInput = document.getElementById('numbers').value.trim();
    const numbersArray = validateInput(numbersInput);

    if (numbersArray) {
        const numberList = new NumberList(numbersArray);
        const variance = numberList.variance();
        document.getElementById('output').style.color = 'green';
        document.getElementById('output').textContent = `Variance: ${variance.toFixed(2)}`;
        document.getElementById('result').style.display = 'block';
    }
}

function calculateStdDeviation() {
    const numbersInput = document.getElementById('numbers').value.trim();
    const numbersArray = validateInput(numbersInput);

    if (numbersArray) {
        const numberList = new NumberList(numbersArray);
        const stdDeviation = numberList.stdDeviation();
        document.getElementById('output').style.color = 'green';
        document.getElementById('output').textContent = `Standard Deviation: ${stdDeviation.toFixed(2)}`;
        document.getElementById('result').style.display = 'block';
    }
}
