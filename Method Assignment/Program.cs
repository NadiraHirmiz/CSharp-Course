using System;

namespace SimpleOperations
{
    class Divider
    {
        public void ShowDivision(int dividend, int label)
        {
            int result = dividend / 2; // Divide the first number by 2
            Console.WriteLine($"Half of the first number ({dividend}) is: {result}");
            Console.WriteLine($"Label value provided: {label}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Divider d = new Divider(); // Instantiate Divider

            d.ShowDivision(40, 999); // Regular call

            d.ShowDivision(label: 111, dividend: 60); // Named params

            Console.ReadLine(); // Wait for input
        }
    }
}
