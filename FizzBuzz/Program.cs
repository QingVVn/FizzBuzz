using System;

namespace FizzBuzz
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Filter fizzbuzz = new FizzBuzzFilter();
            Filter buzz = new BuzzFilter();
            Filter fizz = new FizzFilter();
            Filter nop = new NoFilter();

            fizzbuzz.SetNextFilter(buzz);
            buzz.SetNextFilter(fizz);
            fizz.SetNextFilter(nop);

            for (int i = 1; i <= 100; i++)
            {
                Console.WriteLine(fizzbuzz.GetValue(i));
            }

            Console.ReadLine();
        }
    }
}