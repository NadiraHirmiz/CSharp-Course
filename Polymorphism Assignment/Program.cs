using System;

namespace QuitApp_V3
{
    interface IQuittable
    {
        void Quit();
    }

    // Manager class adds logic before quitting
    class Manager : IQuittable
    {
        public string Department { get; set; }

        public void Quit()
        {
            Console.WriteLine($"Manager from {Department} department has formally resigned.");
            Console.WriteLine("Resignation notice: 2 weeks.");
        }
    }

    class Program
    {
        static void Main()
        {
            Manager mgr = new Manager { Department = "Engineering" };

            // Assign as interface type
            IQuittable quitter = mgr;

            quitter.Quit();

            Console.ReadKey();
        }
    }
}
