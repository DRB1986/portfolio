        function calculateRoots() {
        // Clear previous solution message
        document.getElementById("solution").innerHTML = "";

        // Get user inputs
        let a = parseInt(document.getElementById("inputA").value);
        let b = parseInt(document.getElementById("inputB").value);
        let c = parseInt(document.getElementById("inputC").value);

        // Validate inputs
        let errorMsg = "";
        if (isNaN(a) || isNaN(b) || isNaN(c) || a < -99 || a > 99 || b < -99 || b > 99 || c < -99 || c > 99 || a === 0) {
            errorMsg = "Invalid input: ";
            if (isNaN(a) || a === 0) errorMsg += "a ";
            if (isNaN(b)) errorMsg += "b ";
            if (isNaN(c)) errorMsg += "c ";
            if (a < -99 || a > 99 || b < -99 || b > 99 || c < -99 || c > 99) errorMsg += "must be between -99 and 99 ";
        }

        // Display error message if any
        if (errorMsg !== "") {
            alert(errorMsg);
            return;
        }

        // Calculate discriminant
        let discriminant = b * b - 4 * a * c;

        // Prepare solution message
        let solutionMsg = "Solution: ";
        if (discriminant < 0) {
            solutionMsg += "x’s roots are imaginary";
        } else if (discriminant === 0) {
            let root = -b / (2 * a);
            solutionMsg += "x = " + root;
        } else {
            let root1 = (-b + Math.sqrt(discriminant)) / (2 * a);
            let root2 = (-b - Math.sqrt(discriminant)) / (2 * a);
            solutionMsg += "x = " + root1 + ", x = " + root2;
        }

        // Display solution message
        document.getElementById("solution").innerHTML = solutionMsg;
    }

    function validateInput(inputId) {
        let input = document.getElementById(inputId);
        let value = input.value;
        if (value !== "" && (isNaN(value) || parseInt(value) < -99 || parseInt(value) > 99)) {
            input.style.borderColor = "red";
        } else {
            input.style.borderColor = "";
        }
    }