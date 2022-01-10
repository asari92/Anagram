using System;

namespace AnagramNS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Type string to reverse: ");
            Console.Write(Anagram.Reverse(Console.ReadLine()));
        }
    }
}