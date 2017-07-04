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
            fizzBuzzProgram.PrintFizzBuzzToNInclusive(100);
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
            bool fizzResult = IsFizz(n);
            if(fizzResult)
                Console.Write("Fizz");

            bool buzzResult = IsBuzz(n);
            if (buzzResult)
                Console.Write("Buzz");

            bool bangResult = IsBang(n);
            if (bangResult)
                Console.Write("Bang");

            if(NoSpecialCase(fizzResult, buzzResult, bangResult))
            {
                Console.Write(n);
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

        private bool NoSpecialCase(bool fizz, bool buzz, bool bang)
        {
            return !(fizz || buzz || bang);
        }
    }
}
