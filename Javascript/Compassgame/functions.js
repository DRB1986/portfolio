// functions.js

// Function to swap direction letters
function swapLetters(direction1, direction2) {
    let temp = direction1.innerText;
    direction1.innerText = direction2.innerText;
    direction2.innerText = temp;
}

// Function to swap top-left arrow
function swapLeftTop() {
    let top = document.getElementById("top-input");
    let left = document.getElementById("left-input");
    let cellTop = document.querySelector(".row:nth-child(1) .cell:nth-child(2)");
    let cellLeft = document.querySelector(".row:nth-child(2) .cell:nth-child(1)");

    swapLetters(top, left);
    swapLetters(cellTop, cellLeft);
}

// Function to swap left-right arrows
function swapLeftRight() {
    let left = document.getElementById("left-input");
    let right = document.getElementById("right-input");
    let cellLeft = document.querySelector(".row:nth-child(2) .cell:nth-child(1)");
    let cellRight = document.querySelector(".row:nth-child(2) .cell:nth-child(3)");

    swapLetters(left, right);
    swapLetters(cellLeft, cellRight);
}

// Function to swap bottom-right arrow
function swapBottomRight() {
    let bottom = document.getElementById("bottom-input");
    let right = document.getElementById("right-input");
    let cellBottom = document.querySelector(".row:nth-child(3) .cell:nth-child(2)");
    let cellRight = document.querySelector(".row:nth-child(2) .cell:nth-child(3)");

    swapLetters(bottom, right);
    swapLetters(cellBottom, cellRight);
}

// Function to enable text inputs and update button
function restartGame() {
    let inputs = document.querySelectorAll(".compass-form input[type=text]");
    let updateBtn = document.getElementById("update-compass-btn");

    inputs.forEach(function(input) {
        input.disabled = false;
        input.value = "";
    });

    updateBtn.disabled = false;
}

// Function to update compass based on user input
function updateCompass(form) {
    let top = form.elements["top"].value;
    let left = form.elements["left"].value;
    let right = form.elements["right"].value;
    let bottom = form.elements["bottom"].value;

    let cellTop = document.querySelector(".row:nth-child(1) .cell:nth-child(2)");
    let cellLeft = document.querySelector(".row:nth-child(2) .cell:nth-child(1)");
    let cellRight = document.querySelector(".row:nth-child(2) .cell:nth-child(3)");
    let cellBottom = document.querySelector(".row:nth-child(3) .cell:nth-child(2)");

    cellTop.innerText = top;
    cellLeft.innerText = left;
    cellRight.innerText = right;
    cellBottom.innerText = bottom;

    // Disable text inputs and update button after updating compass
    let inputs = form.querySelectorAll("input[type=text]");
    let updateBtn = form.querySelector("input[type=button]");
    inputs.forEach(function(input) {
        input.disabled = true;
    });
    updateBtn.disabled = true;
}

