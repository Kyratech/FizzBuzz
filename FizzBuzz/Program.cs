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
            bool fizzResult = PrintFizzTest(n);
            bool buzzResult = PrintBuzzTest(n);

            if(NeitherFizzOrBuzz(fizzResult, buzzResult))
            {
                PrintInteger(n);
            }

            PrintNewline();
        }

        private bool PrintFizzTest(int n)
        {
            if(IsFizz(n))
            {
                Console.Write("Fizz");
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool PrintBuzzTest(int n)
        {
            if(IsBuzz(n))
            {
                Console.Write("Buzz");
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool NeitherFizzOrBuzz(bool fizz, bool buzz)
        {
            return !(fizz || buzz);
        }

        private void PrintInteger(int n)
        {
            Console.Write(n);
        }

        private void PrintNewline()
        {
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
    }
}
