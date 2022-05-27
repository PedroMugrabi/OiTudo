using System;

namespace Teste5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetDay(0));
        }

        static string GetDay(int daynum)
        {
            string dayName;

            switch (daynum)
            {
                case 0:
                    dayName = "Sunday";
                    break;
                case 1:
                    dayName = "Monday";
                    break;
                case 2:
                    dayName = "Tuesday";
                    break;
                case 3:
                    dayName = "Wednesday";
                    break;
                case 4:
                    dayName = "Thursday";
                    break;
                case 5:
                    dayName = "Friday";
                    break;
                case 6:
                    dayName = "Saturday";
                    break;

                default:
                    dayName = "Invalid number";
                    break;

            }
                



            return dayName;
        }
    }
}
