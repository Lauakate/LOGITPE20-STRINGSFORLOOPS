using System;

namespace AInUserInput
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Whats your name?");
            string UserInput = Console.ReadLine();
            char searchCriteria = 'a';
            int stringLength = UserInput.Length;
            int counter = 0;
            foreach (char letter in UserInput)
            {
                if (letter == searchCriteria)
                {
                    counter += 1;
                }
            }
            if (counter >= 1)
            {
                Console.WriteLine($"You have {counter} As in your name");


            }
            else
            {
                Console.WriteLine("No As found");
            }

            
                    
        }
    }
}
