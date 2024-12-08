using System;

namespace Method_Class_Assignment
{
    public class MathOperations
    {
        public void PerformOperation(int num1, int num2)
        {
            // The number is raised to the third power.
            var result = Math.Pow(num1, 3);

            // Display the result of the operation
            Console.WriteLine($"The result of the number {num1} to the power of 3: {result}");

            // Display the second integer
            Console.WriteLine($"The second integer is: {num2}");
        }
    }
}
