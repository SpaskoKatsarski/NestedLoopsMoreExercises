using System;
using System.Collections.Generic;

namespace T02._Letters_Combinations
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstNumber = Console.ReadLine();
            string secondNumber = Console.ReadLine();
            string thirdNumber = Console.ReadLine();

            int counter = 0;
            string collect = String.Empty;

            for (char i = firstNumber[0]; i <= secondNumber[0]; i++)
            {
                for (char j = firstNumber[0]; j <= secondNumber[0]; j++)
                {
                    for (char k = firstNumber[0]; k <= secondNumber[0]; k++)
                    {
                        if (i != thirdNumber[0] && j != thirdNumber[0] && k != thirdNumber[0])
                        {
                            collect += $"{i}{j}{k} ";
                            counter++;
                        }
                    }
                }
            }
            Console.Write($"{collect}{counter}");
        }
    }
}
