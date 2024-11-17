using System;

namespace BranchingAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Display a welcome message to the user
            Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

            // Prompt the user to enter the package weight
            Console.Write("Please enter the package weight: ");
            double weight = Convert.ToDouble(Console.ReadLine()); // Read and convert input to double

            // If the weight is greater than 50, display an error and terminate the program
            if (weight > 50)
            {
                Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
                return; // Exit the program if the weight is too heavy
            }

            // Prompt the user to enter the package width
            Console.Write("Please enter the package width: ");
            double width = Convert.ToDouble(Console.ReadLine()); // Read and convert input to double

            // Prompt the user to enter the package height
            Console.Write("Please enter the package height: ");
            double height = Convert.ToDouble(Console.ReadLine()); // Read and convert input to double

            // Prompt the user to enter the package length
            Console.Write("Please enter the package length: ");
            double length = Convert.ToDouble(Console.ReadLine()); // Read and convert input to double

            // If the total of the dimensions (width + height + length) is greater than 50, display an error and terminate
            if (width + height + length > 50)
            {
                Console.WriteLine("Package too big to be shipped via Package Express.");
                return; // Exit the program if the total dimensions are too large
            }

            // Calculate the shipping quote: (width * height * length * weight) / 100
            double quote = (width * height * length * weight) / 100;

            // Display the estimated shipping cost
            Console.WriteLine($"Your estimated total for shipping this package is: ${quote:F2}");

            // Display a thank you message
            Console.WriteLine("Thank you!");
            Console.ReadKey();
        }
    }
}
