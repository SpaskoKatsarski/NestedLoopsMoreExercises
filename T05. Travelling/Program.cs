using System;

namespace T05._Travelling
{
    class Program
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            while (destination != "End")
            {
                double neededMoney = double.Parse(Console.ReadLine());
                double sum = 0;
                while (neededMoney > sum)
                {
                    sum += double.Parse(Console.ReadLine());
                }
                Console.WriteLine($"Going to {destination}!");
                destination = Console.ReadLine();
            }
        }
    }
}
