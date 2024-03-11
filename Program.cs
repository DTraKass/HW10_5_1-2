using System;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Logger.LoggerCallCulator();
        }

        public interface ICalculate
        {
            void Calculate(float x, float y);
        }

        public class Calculator : ICalculate
        {
            public static float Result;
            public void Calculate(float x, float y)
            {
                Result = x + y;
            }
        }

        public class Logger
        {
            public static void LoggerCallCulator()
            {
                float X, Y;

                var calculator = new Calculator();

                try
                {
                    Console.ForegroundColor = ConsoleColor.Blue;

                    Console.WriteLine("Введите число 1");
                    X = float.Parse(Console.ReadLine());

                    Console.WriteLine("Введите число 2");
                    Y = float.Parse(Console.ReadLine());

                    ((ICalculate)calculator).Calculate(X, Y);

                    Console.WriteLine(Calculator.Result);
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(ex);
                }
            }
        }
    }
}