using System;

namespace practicalwork
{
    class Program
    {
        static void Main(string[] args)
        {
            var test = new Calculator();

            //test.Division(5, 0);
            Console.WriteLine(test.SumResultsOfDivision());
        }
    }
}
