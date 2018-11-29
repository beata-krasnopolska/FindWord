using System;
using System.Collections.Generic;
using System.Linq;

namespace FindWord
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Program finds a word that strats and ends with a specified character");

            List<string> cities = new List<string>() { "Warsaw", "Cracow", "Rome", "London", "Berlin", "Paris", "Madrid" };            
            TextHolder(cities);
            Console.WriteLine("Enter starting character for the string:");
            string firstChar = Console.ReadLine();
            Console.WriteLine("Enter ending character for the string:");
            string lastChar = Console.ReadLine();

            var words = from word in cities
                        where word.StartsWith(firstChar)
                        && word.EndsWith(lastChar)
                        select word;

            var wordsLambda = cities.Where(p => p.StartsWith(firstChar) && p.EndsWith(lastChar));

            Console.WriteLine("First check with LINQ query");
            foreach (var i in words)
            {
                Console.WriteLine("The city starting with {0} and ending with {1} is {2}", firstChar, lastChar, i);
            }
            Console.WriteLine("Second check with LINQ method");
            foreach (var i in wordsLambda)
            {
                Console.WriteLine("The city starting with {0} and ending with {1} is {2}", firstChar, lastChar, i);
            }
            Console.ReadLine();
        }

        private static void TextHolder(List<string> cities)
        {
            var text = "The cities on the list are: ";
            var n = 0;
            foreach (var i in cities)
            {
                text += i;
                if (n != cities.Count - 1)
                {
                    text += ", ";
                }
                n++;
            }
            Console.WriteLine(text);
        }
    }
}
