using System;

namespace T06._Cinema_Tickets
{
    class Program
    {
        static void Main(string[] args)
        {
            string film = Console.ReadLine();

            int sum = 0;
            int sumStudents = 0;
            int sumStandards = 0;
            int sumKids = 0;

            while (film != "Finish")
            {
                int tickets = 0;

                int students = 0;
                int standards = 0;
                int kids = 0;

                double percentageAll = 0;

                int freePlaces = int.Parse(Console.ReadLine());
                string command = Console.ReadLine();

                while (command != "End")
                {
                    if (command == "student")
                    {
                        students++;
                        sumStudents++;
                    }
                    else if (command == "standard")
                    {
                        standards++;
                        sumStandards++;
                    }
                    else if (command == "kid")
                    {
                        kids++;
                        sumKids++;
                    }

                    sum++;
                    tickets++;

                    if (tickets == freePlaces)
                    {
                        break;
                    }
                    command = Console.ReadLine();
                }

                percentageAll = (double)(tickets) / freePlaces * 100;
                Console.WriteLine($"{film} - {percentageAll:f2}% full.");
                film = Console.ReadLine();
            }
            Console.WriteLine($"Total tickets: {sum}");
            double percentageStudents = (double)sumStudents / sum * 100;
            double percentageStandards = (double)sumStandards / sum * 100;
            double percentageKids = (double)sumKids / sum * 100;
            Console.WriteLine($"{percentageStudents:f2}% student tickets.");
            Console.WriteLine($"{percentageStandards:f2}% standard tickets.");
            Console.WriteLine($"{percentageKids:f2}% kids tickets.");
        }
    }
}
