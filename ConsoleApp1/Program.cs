using System;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {

        {   
            bool ItWorking = true;
            Console.WriteLine("Введите 2 числа от 0 до 10: ");
            while (ItWorking)
            {
                int A = Convert.ToInt32(Console.ReadLine());
                int B = Convert.ToInt32(Console.ReadLine());
                if (A < 10 & A > 0 & B > 0 & B < 10)
                {
                    Console.WriteLine($"{A}*{B}={A * B}");
                    break;
                }
                else
                    {
                    Console.WriteLine("Введены недопустимые значения");
                    Console.WriteLine("Введите 2 числа от 0 до 10: ");
                    }
            }       
        }       
    }
}