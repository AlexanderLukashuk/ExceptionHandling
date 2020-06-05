using System;

namespace practicalwork
{
    public class Calculator
    {
        public int Division()
        {
            int firstNumber = 0;
            int secondNumber = 0;
            int result = 0;
            string input;

            Console.WriteLine("Enter first number: ");
            input = Console.ReadLine();
            try
            {
                firstNumber = int.Parse(input);
            }
            catch
            {
                Console.WriteLine("Вы ввели неверное значение, число будет равно 0");
            }

            Console.WriteLine("Enter second number: ");
            input = Console.ReadLine();
            try
            {
                secondNumber = int.Parse(input);
            }
            catch
            {
                Console.WriteLine("Вы ввели неверное значение, число будет равно 0");
            }

            if (secondNumber == 0)
            {
                throw new ArgumentException("На ноль делить НЕЛЬЗЯ");
            }
            else
            {
                result = firstNumber / secondNumber;
            }

            return result;
        }

        public int SumResultsOfDivision()
        {
            int firstResult = Division();
            int secondResult = Division();

            return firstResult + secondResult;
        }
    }
}