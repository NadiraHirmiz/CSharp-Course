using System;

namespace EmployeeEqualityApp
{
    class EmployeeV4
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public static bool operator ==(EmployeeV4 e1, EmployeeV4 e2)
        {
            if (ReferenceEquals(e1, e2)) return true;
            if (ReferenceEquals(e1, null) || ReferenceEquals(e2, null)) return false;
            return e1.Id == e2.Id;
        }

        public static bool operator !=(EmployeeV4 e1, EmployeeV4 e2)
        {
            return !(e1 == e2);
        }

        public override bool Equals(object obj)
        {
            var other = obj as EmployeeV4;
            return other != null && Id == other.Id;
        }

        public override int GetHashCode()
        {
            return Id;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {FirstName} {LastName}");
        }
    }

    class Program4
    {
        static void Main()
        {
            EmployeeV4 empA = new EmployeeV4 { Id = 3, FirstName = "Nadira", LastName = "Hirmiz" };
            EmployeeV4 empB = new EmployeeV4 { Id = 4, FirstName = "Bob", LastName = "TheBuilder" };

            empA.PrintInfo();
            empB.PrintInfo();

            Console.WriteLine("Equal by ID? " + (empA == empB));
            Console.ReadKey();
        }
    }
}
