using System;

namespace EmailGeneratorApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your first name:");
            string firstName = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter your last name:");
            string lastName = Console.ReadLine() ?? string.Empty;

            Console.WriteLine("Enter your year of birth:");
            string input = Console.ReadLine();
            int yearOfBirth;
            while (!int.TryParse(input, out yearOfBirth))
            {
                Console.WriteLine("Invalid year of birth. Please enter a valid integer:");
                input = Console.ReadLine();
            }

            string email = GenerateEmail(firstName, lastName, yearOfBirth);

            Console.WriteLine($"Hello {firstName} {lastName}, welcome to Robertson College!");
            Console.WriteLine($"Your new email address is {email}");
        }

        static string GenerateEmail(string firstName, string lastName, int yearOfBirth)
        {
            string firstInitial = string.IsNullOrEmpty(firstName) ? "" : firstName[0].ToString().ToLower();
            string email = $"{firstInitial}{lastName.ToLower()}{yearOfBirth}@robertsoncollege.ca";
            return email;
        }
    }
}
