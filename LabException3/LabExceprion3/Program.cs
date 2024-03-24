using System;
using CalcLib;

namespace LabException3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FunctionCaclulation fc = new FunctionCaclulation();

            Console.WriteLine("Введите значение x:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите значение N:");
            int N = int.Parse(Console.ReadLine());            
            Console.WriteLine("Введите значение k итераций:");
            int k = int.Parse(Console.ReadLine());

            fc.CalculateFunction(x, N, k);

            Console.ReadLine();
        }
    }
}
