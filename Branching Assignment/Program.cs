using System;

class Program
{
    static void Main()
    {
        // Introductory message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Begin scenario
        Console.WriteLine("\nImagine you're preparing a package to ship...");

        // Ask for weight of the package
        Console.Write("Step 1: What is the weight of the package (in lbs)? ");
        decimal weight = Convert.ToDecimal(Console.ReadLine());

        // Weight limit check
        if (weight > 50)
        {
            Console.WriteLine("\nUnfortunately, this package exceeds our weight limit.");
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Ask for dimensions with prompts
        Console.Write("Step 2: What is the width of the package (in inches)? ");
        decimal width = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Step 3: What is the height of the package (in inches)? ");
        decimal height = Convert.ToDecimal(Console.ReadLine());

        Console.Write("Step 4: What is the length of the package (in inches)? ");
        decimal length = Convert.ToDecimal(Console.ReadLine());

        // Check if the package is too big
        if ((width + height + length) > 50)
        {
            Console.WriteLine("\nPackage exceeds our dimensional limits.");
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Perform the shipping quote calculation
        decimal shippingQuote = (width * height * length * weight) / 100;

        // Output the shipping cost
        Console.WriteLine($"\nYour estimated total for shipping this package is: ${shippingQuote:0.00}");
        Console.WriteLine("Thank you for choosing Package Express!");
    }
}
