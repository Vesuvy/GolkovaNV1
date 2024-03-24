using System;

namespace CalcLib
{
    public class FunctionCaclulation
    {
        // k - количество итераций
        public double CalculateFunction(double xMin, double N, int k)
        {
            double result = 0;
            try
            {
                for (double x = xMin; x < k; x += 0.1) {
                    if (x == N)
                        throw new DivideByZeroException("ERROR: деление на ноль!");
                    if (k < 0)
                        throw new ArgumentOutOfRangeException("ERROR: k должно быть больше 0!");
                    if (x < 0 || x > k)
                        throw new ArgumentOutOfRangeException($"ERROR: Выход за пределы диапазона. x = [0...{k}]");
                    
                    result = 1 / (x - N);
                    Console.WriteLine($"f({x}) = {result}");
                }
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Выполнение программы завершено! Нажмите любую кнопку...");
            }
            return result;

        }
    }
}
