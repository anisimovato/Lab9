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
            try
            {
                Console.WriteLine(n < 5);
            }

            catch
            {
                Console.WriteLine("Нет операции с указанным номером");
            }
            try
            {
                Console.WriteLine(x);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Входная строка имела неверный формат.");
            }
            try
            {
                Console.WriteLine(y);
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Входная строка имела неверный формат.");
            }

            //S = (X + Y);
            //R = (X - Y);
            //P = X * Y;
            //Z = X / Y;

            {
                if (n == 1)

                {
                    Console.Write("Результат =");
                    Console.WriteLine(x + y);
                }

                if (n == 2)
                {
                    Console.Write("Результат =");
                    Console.Write(x - y);
                }
                if (n == 3)
                {
                    Console.Write("Результат =");
                    Console.Write(x * y);
                }
                if (n == 4)
                {
                    Console.Write("Результат =");
                    Console.WriteLine(x / y);
                }

                //else
                //{
                //    Console.WriteLine("Нет операции с указанным номером");
                //}
                //Console.WriteLine("{0}+{1} = {1}+{0} = {2}", a, b, a + b);
                //S = (X + Y);
                //R = (X - Y);
                //P = X * Y;
                //Z = X / Y;
                //try
                //{
                //    Console.WriteLine(a / b);
                //}
                //catch(DivideByZeroException ex) when (a==0 && b==0)
                //{
                //    Console.WriteLine("Деление 0 на 0");
                //}
                //catch(Exception ex)
                //{
                //    Console.WriteLine(ex.Message);
                //}

            }
            Console.ReadKey();
        }

    }
}
//Console.WriteLine("{0}+{1} = {1}+{0} = {2}", a, b, a + b);
//S = (X + Y);
//R = (X - Y);
//P = X * Y;
//Z = X / Y;
//try
//{
//    Console.WriteLine(a / b);
//}
//catch(DivideByZeroException ex) when (a==0 && b==0)
//{
//    Console.WriteLine("Деление 0 на 0");
//}
//catch(Exception ex)
//{
//    Console.WriteLine(ex.Message);
//}