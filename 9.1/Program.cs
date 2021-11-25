using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
                

                switch (n)
                {
                    case 1:
                        Console.WriteLine($"Результат = {x + y}");
                        break;
                    case 2:
                        Console.WriteLine($"Результат = {x + y}");
                        break;
                    case 3:
                        Console.WriteLine($"Результат = {x * y}");
                        break;
                    case 4:
                        Console.WriteLine($"Результат = {x / y}");
                        break;

                    default:
                        Console.WriteLine("Неизвестное имя");
                        break;
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

