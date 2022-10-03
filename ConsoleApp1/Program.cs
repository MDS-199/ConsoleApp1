using System;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {

        {
            Console.WriteLine("Вывести таблицу умножения на экран ?");
            string OTVET = Console.ReadLine();
            if (OTVET.ToLower().Contains("да"))
            {
                for (int Q = 1; Q < 10; Q++)
                {int A = 1; Console.Write("\n");
                    while (A < 10)
                    {
                        Console.Write($" {A}*{Q}={Q*A}\t");
                        ++A;
                    }
                } 
            }

            else Console.WriteLine("Ну нет так нет");
        }
    }
}