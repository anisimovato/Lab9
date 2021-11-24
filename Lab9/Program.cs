using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab9
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Вас приветствует супер калькулятор!");
                Console.Write("Введите целое число. X=");
                int x = Convert.ToInt32(Console.ReadLine());
                Console.Write("Введите целое число. Y=");
                int y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Введите код операции:");
                Console.WriteLine("1 сложение");
                Console.WriteLine("2 вычитание");
                Console.WriteLine("3 произведение");
                Console.WriteLine("4 частное");
                Console.Write("Ваш выбор: ");
                int n = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(n < 5);
                if (n > 4 || n < 0)
                {
                    Console.Write("Некорректный номер операции");
                }
                {
                    if (n == 1)
                    {
                        Console.Write($"Результат = {x + y}");
                    }
                    if (n == 2)
                    {
                        Console.Write($"Результат = {x - y}");
                    }
                    if (n == 3)
                    {
                        Console.Write($"Результат = {x * y}");
                    }
                    if (n == 4)
                    {
                        Console.Write($"Результат = {x / y}");
                    }
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Входная строка имела неверный формат.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadKey();
        }

    }
}

