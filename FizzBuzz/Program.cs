using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            Program fizzBuzzProgram = new FizzBuzz.Program();
            fizzBuzzProgram.PrintFizzBuzzToNInclusive(200);
        }

        private void PrintFizzBuzzToNInclusive(int n)
        {
            int current = 0;
            while(current <= n)
            {
                PrintFizzBuzzTest(current);
                current++;
            }
        }

        private void PrintFizzBuzzTest(int n)
        {
            FizzBuzzResult fizzBuzzResult = new FizzBuzzResult();

            bool bongResult = IsBong(n);
            if (bongResult)
            {
                fizzBuzzResult.SetFezz(IsFezz(n));
                if (fizzBuzzResult.GetFezz())
                    Console.Write("Fezz");

                Console.Write("Bong");
            }
            else
            {
                fizzBuzzResult.SetFizz(IsFizz(n));
                if (fizzBuzzResult.GetFizz())
                    Console.Write("Fizz");

                fizzBuzzResult.SetFezz(IsFezz(n));
                if (fizzBuzzResult.GetFezz())
                    Console.Write("Fezz");

                fizzBuzzResult.SetBuzz(IsBuzz(n));
                if (fizzBuzzResult.GetBuzz())
                    Console.Write("Buzz");

                fizzBuzzResult.SetBang(IsBang(n));
                if (fizzBuzzResult.GetBang())
                    Console.Write("Bang");

                if (fizzBuzzResult.NoSpecialCase())
                {
                    Console.Write(n);
                }
            }

            Console.WriteLine();
        }
        private bool IsFizz(int n)
        {
            return (n % 3 == 0);
        }

        private bool IsBuzz(int n)
        {
            return (n % 5 == 0);
        }

        private bool IsBang(int n)
        {
            return (n % 7 == 0);
        }

        private bool IsBong(int n)
        {
            return (n % 11 == 0);
        }

        private bool IsFezz(int n)
        {
            return (n % 13 == 0);
        }

        private bool NoSpecialCase(bool fizz, bool buzz, bool bang)
        {
            return !(fizz || buzz || bang);
        }
    }
}
