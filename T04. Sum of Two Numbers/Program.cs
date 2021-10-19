using System;

namespace T04._Sum_of_Two_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int start = int.Parse(Console.ReadLine());
            int end = int.Parse(Console.ReadLine());
            int magicNum = int.Parse(Console.ReadLine());

            int counter = 0;
            bool isFound = false;

            for (int i = start; i <= end; i++)
            {
                for (int j = start; j <= end; j++)
                {
                    counter++;
                    if (i + j == magicNum)
                    {
                        isFound = true;
                        Console.WriteLine($"Combination N:{counter} ({i} + {j} = {magicNum})");
                        break;
                    }
                }
                if (isFound)
                {
                    break;
                }
            }
            if (!isFound)
            {
                Console.WriteLine($"{counter} combinations - neither equals {magicNum}");
            }
        }
    }
}
