using System;

namespace LabException1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Бесконечный цикл
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите число A:");
                    double A = double.Parse(Console.ReadLine());
                    Console.WriteLine("Введите число B:");
                    double B = double.Parse(Console.ReadLine());

                    if (B == 0)
                    {
                        throw new DivideByZeroException("ERROR666: Деление на ноль!");
                    }

                    double result = A / B;
                    Console.WriteLine($"Результат деления A на B: {result}");

                }
                catch (FormatException)
                {
                    Console.WriteLine("ERROR: некорректное значение.");
                }
                catch (DivideByZeroException ex) //деление на ноль
                {
                    Console.WriteLine(ex.Message);
                }
                finally
                {
                    Console.WriteLine("Продолжаем вычисления...");
                }
            }
        }
    }
}
