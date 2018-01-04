using System;

namespace HelloSourceControl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a greeting");
            string greeting = Console.ReadLine();
            Console.WriteLine(greeting); 
            Console.ReadKey();
        }
    }
}
