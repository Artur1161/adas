using System;
using MyLibrary;  // Добавьте эту строку

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Создаем экземпляр класса
            var math = new SimpleMath();

            // Тестируем функции
            Console.WriteLine("=== Тестирование математической библиотеки ===");
            Console.WriteLine($"5 + 3 = {math.Add(5, 3)}");
            Console.WriteLine($"10 / 2 = {math.Divide(10, 2)}");
            Console.WriteLine($"5^3 = {math.Power(5, 3)}");
            Console.WriteLine($"Sin(30°) = {math.SinDeg(30)}");
            Console.WriteLine($"7! = {math.Factorial(7)}");
            Console.WriteLine($"НОД(24, 36) = {math.GCD(24, 36)}");
            Console.WriteLine($"17 простое? {math.IsPrime(17)}");
            Console.WriteLine($"8-е число Фибоначчи: {math.Fibonacci(8)}");
            Console.WriteLine($"Площадь круга (r=5): {math.CircleArea(5)}");

            double[] nums = { 5, 2, 8, 1, 9 };
            Console.WriteLine($"Среднее: {math.Average(nums)}");
            Console.WriteLine($"Максимум: {math.Max(nums)}");
            Console.WriteLine($"Минимум: {math.Min(nums)}");

            Console.ReadKey();
        }
    }
}