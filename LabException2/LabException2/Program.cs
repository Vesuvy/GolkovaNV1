using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabException2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Введите значение А");
                int A = int.Parse(Console.ReadLine());
                Console.WriteLine("Введите значение B");
                int B = int.Parse(Console.ReadLine());

                try
                {
                    int x = Solve(A, B);
                    Console.WriteLine($"Решение уравнения {A}x = {B}: x = {x}");
                }
                catch (ArgumentException ex)
                {
                    Console.WriteLine($"ERROR: {ex}");
                }
                Console.WriteLine("Чтобы продолжить, нажмите клавишу...");
                Console.ReadLine();
            }
        }

        public static int Solve(int A, int B)
        {
            if (A == 0 && B == 0 ) {
                return 0;
            }
            else if (A == 0 || B % A != 0) {
                throw new ArgumentException("Уравнение не имеет целочисленного решения!");
            }
            else {
                return B / A;
            }
        }
    }
}
