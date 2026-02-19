using System;
using System.Collections.Generic;
using System.Linq;

namespace MyLibrary
{
    /// <summary>
    /// Простая математическая библиотека
    /// </summary>
    public class SimpleMath
    {
        // Константы
        public const double Pi = 3.141592653589793;
        public const double E = 2.718281828459045;

        #region Базовые операции

        public double Add(double a, double b) => a + b;
        public double Subtract(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;

        public double Divide(double a, double b)
        {
            if (b == 0) throw new DivideByZeroException("На ноль делить нельзя!");
            return a / b;
        }

        public double Power(double base_, double exponent) => Math.Pow(base_, exponent);
        public double Sqrt(double number) => Math.Sqrt(number);

        #endregion

        #region Тригонометрия

        public double Sin(double angle) => Math.Sin(angle);
        public double Cos(double angle) => Math.Cos(angle);
        public double Tan(double angle) => Math.Tan(angle);

        // Тригонометрия в градусах
        public double SinDeg(double degrees) => Math.Sin(degrees * Pi / 180);
        public double CosDeg(double degrees) => Math.Cos(degrees * Pi / 180);
        public double TanDeg(double degrees) => Math.Tan(degrees * Pi / 180);

        #endregion

        #region Продвинутые операции

        /// <summary>
        /// Факториал числа
        /// </summary>
        public long Factorial(int n)
        {
            if (n < 0) throw new ArgumentException("Факториал отрицательного числа не определен");

            long result = 1;
            for (int i = 2; i <= n; i++)
                result *= i;
            return result;
        }

        /// <summary>
        /// Наибольший общий делитель (НОД)
        /// </summary>
        public long GCD(long a, long b)
        {
            a = Math.Abs(a);
            b = Math.Abs(b);

            while (b != 0)
            {
                long temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        /// <summary>
        /// Наименьшее общее кратное (НОК)
        /// </summary>
        public long LCM(long a, long b)
        {
            if (a == 0 || b == 0) return 0;
            return Math.Abs(a * b) / GCD(a, b);
        }

        /// <summary>
        /// Проверка на простое число
        /// </summary>
        public bool IsPrime(int number)
        {
            if (number <= 1) return false;
            if (number == 2) return true;
            if (number % 2 == 0) return false;

            for (int i = 3; i * i <= number; i += 2)
                if (number % i == 0) return false;

            return true;
        }

        /// <summary>
        /// Число Фибоначчи
        /// </summary>
        public long Fibonacci(int n)
        {
            if (n < 0) throw new ArgumentException("Индекс не может быть отрицательным");
            if (n <= 1) return n;

            long prev = 0, curr = 1;
            for (int i = 2; i <= n; i++)
            {
                long next = prev + curr;
                prev = curr;
                curr = next;
            }
            return curr;
        }

        #endregion

        #region Геометрия

        public double CircleArea(double radius) => Pi * radius * radius;
        public double CircleLength(double radius) => 2 * Pi * radius;

        public double RectangleArea(double length, double width) => length * width;
        public double TriangleArea(double base_, double height) => 0.5 * base_ * height;

        public double Distance2D(double x1, double y1, double x2, double y2) =>
            Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));

        #endregion

        #region Статистика

        public double Average(double[] numbers)
        {
            if (numbers.Length == 0) return 0;

            double sum = 0;
            foreach (double num in numbers) sum += num;
            return sum / numbers.Length;
        }

        public double Max(double[] numbers)
        {
            if (numbers.Length == 0) return 0;
            double max = numbers[0];
            foreach (double num in numbers)
                if (num > max) max = num;
            return max;
        }

        public double Min(double[] numbers)
        {
            if (numbers.Length == 0) return 0;
            double min = numbers[0];
            foreach (double num in numbers)
                if (num < min) min = num;
            return min;
        }

        #endregion
    }
}