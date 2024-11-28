using System;

class Program
{
    static void Main()
    {
    // Get a valid positive integer
        int number = GetPositiveInteger();
        
    // Handle the special case where the number is 1
        if (number == 1)
        {
            Console.WriteLine("The number 1 has no prime factors.");
        }
        else
        {
    // Get the prime factors and display them
            Console.WriteLine($"The smallest prime factors of {number} are: {GetPrimeFactors(number)}");
        }
    }

    // Method to get a valid positive integer
    static int GetPositiveInteger()
    {
        int number = 0;
        bool isValid = false;

    // Loop until the user provides a valid positive integer
        while (!isValid)
        {
            Console.Write("Enter a positive whole number: ");
            string? input = Console.ReadLine();

    // Check if the input is valid
            if (input != null && int.TryParse(input, out number) && number > 0)
            {
                isValid = true;
            }
            else
            {
    // Inform the user of invalid input
                Console.WriteLine("Invalid input. Please enter a positive whole number.");
            }
        }

        return number;
    }

    // Method to get the prime factors
    static string GetPrimeFactors(int number)
    {
    // Use StringBuilder to build the output string
        var factors = new System.Text.StringBuilder();
        
    // Iterate over all potential factors
        for (int i = 2; i <= number; i++)
        {
    // Check if 'i' is a factor of 'number'
            while (number % i == 0)
            {
                // Append the factor to the StringBuilder
                factors.Append(i + " X ");
    // Divide the number by 'i' to reduce it
                number /= i;
            }
        }
        
    // Remove the trailing " X " if factors were added
        if (factors.Length > 0)
        {
            factors.Length -= 3; // Remove the last " X "
        }
        else
        {
    // Append the number itself if it is a prime number
            factors.Append(number);
        }

    // Return the constructed string of prime factors
        return factors.ToString();
    }
}
