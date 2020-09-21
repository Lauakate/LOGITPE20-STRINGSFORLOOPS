using System;

namespace LongerName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first name");
            string name1 = Console.ReadLine();
            Console.WriteLine("Enter second name");
            string name2 = Console.ReadLine();

            int length = 0;
            int length2 = 0;

            foreach (char letter in name1)
            {
                length = length + 1;
            }
            foreach (char letter in name2)
            {
                length2 = length2 + 1;
            }
            if (length > length2)
            {
                Console.WriteLine("Name one is longer");
            }
            else if (length < length2)
            {
                Console.WriteLine("Name two is longer");
            }
            else
            {
                Console.WriteLine("Both names are the same length");
            }
        }
    }
}
