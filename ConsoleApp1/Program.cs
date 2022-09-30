using System;
using System.Reflection.Metadata;

internal class Program
{
    private static void Main(string[] args)
    {
        bool IsWorking = true;
        while(IsWorking)
        {
            Console.WriteLine("Введите комманду:");

            string Comm = Console.ReadLine();
            /*


            if (Comm.ToLower().Contains("сумма"))
            {
                Console.WriteLine("Введите первую переменную");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите вторую переменную");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат: " + (A + B));
            }
            else if (Comm.ToLower().Contains("разниц"))
            {
                Console.WriteLine("Введите первую переменную");
                int A = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите вторую переменную");
                int B = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Результат: " + (A - B));
            }
            else
                Console.WriteLine("Команда не опознана");
            */

            try
            {
                switch (Comm.ToLower())
                {
                    case "сумма":
                        Console.WriteLine("Введите первую переменную");
                        int A = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите вторую переменную");
                        int B = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Результат: " + (A + B));
                        break;
                    case "разница":

                        Console.WriteLine("Введите первую переменную");
                        int A_ = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Введите вторую переменную");
                        int B_ = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Результат: " + (A_ - B_));
                        break;
                    case "стоп":
                        IsWorking = false;
                        break;
                    default:
                        Console.WriteLine("Команда не опознана");
                        break;

                }
            }
            catch(FormatException ex)
            {
                Console.WriteLine($"Ошибка не правильный формат данных: {ex.Message}") ;
                
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Не опознан: {ex.Message}");
            }

            Console.WriteLine(Environment.NewLine);
            Console.WriteLine(Environment.NewLine);
        }
       

    }
}