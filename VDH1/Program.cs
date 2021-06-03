using System;
using VDH1.Students.Dikshya;
using VDH1.Teachers.Niels;

namespace VDH1
{
    class Program
    {
        // Code momments.
        static void Main(string[] args)
        {
            Console.WriteLine((new Niels()).FullName);
            Console.WriteLine((new Gitklasse1()).FullName);
        }
    }
}
