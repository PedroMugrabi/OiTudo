using System;

namespace Teste3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cubednumber = cube(5);
           
            
            Console.WriteLine(cubednumber);
          
            Console.WriteLine(GetMax(20, 10, 4));
            
        }
        static int cube(int num)
        {
            int result = num * num * num;
            return result;
        }
        static int GetMax(int num1, int num2, int num3)
        {
            int result;
            if (num1 >= num2 && num1 >= num3)
            {
                result = num1;
            }
            else if (num2 >= num1 && num2 >= num3)
            {
                result = num2;
            }
            else
            {
                result = num3;

                
            }
            return result;
        }
    }
}
