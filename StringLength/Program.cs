﻿using System;

namespace StringLength
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            int counter = 0;

            foreach (char letter in name)
            {
                //Console.WriteLine(letter);
                counter = counter + 1;
                Console.WriteLine($"letter {letter} is at {counter}");
            }
            Console.WriteLine($"Your name is {counter} characters long");

        }
    }
}
