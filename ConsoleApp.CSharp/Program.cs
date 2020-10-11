using System;
using static LanguageExt.Prelude;

namespace ConsoleApp.CSharp
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var f = fun((int x, int y, int z) => x * y + z);

            var c = curry(f);

            var c1 = c(2);
            var c2 = c1(3);
            var c3 = c2(5);

            Console.WriteLine($"Curry: {c3}");

            var pa = fun((int x) => f(x, 3, 5));

            Console.WriteLine($"PA: {pa(2)}");
        }
    }
}