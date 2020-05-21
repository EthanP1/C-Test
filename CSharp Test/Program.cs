using System;

namespace CSharp_Test
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wait a minite, who are you?");
            string name = Console.ReadLine();
            Console.WriteLine("Well hello {0}.", name);
        }
    }
}