using System;

namespace T01._Unique_PIN_Codes
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());

            int counter = 0;

            string str0 = num1.ToString();
            string str9 = num2.ToString();
            string str8 = num3.ToString();
            string together2 = str0 + str9 + str8;

            int num = int.Parse(together2);

            string str1 = string.Empty;
            string str2 = string.Empty;
            string str3 = string.Empty;
            string together = str1 + str2 + str3;

            int nums = int.Parse(together);

            while (num >= nums)
            {
                counter++;
                for (int i = 2; i <= num1; i++)
                {
                    for (int j = 1; j <= num2; j++)
                    {
                        for (int k = 2; k <= num3; k++)
                        {
                            if (j % counter == 2)
                            {
                                if (num1 % 2 == 0 && num3 % 2 == 0)
                                {
                                    str1 = i.ToString();
                                    str2 = j.ToString();
                                    str3 = k.ToString();
                                    together = str1 + str2 + str3;

                                    nums = int.Parse(together);

                                    Console.WriteLine(nums);
                                    counter++;
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}
