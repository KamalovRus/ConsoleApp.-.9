using System;

namespace Task9
{
    public class Program
    {
        public static void Calculate()
        {
            Calculator.TakeNumbers();
            Calculator.TakeOperator();
            Calculator.DoOperation();
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Добро пожаловать в калькулятор!");
            Calculate();
        }
    }

    public class Calculator
    {
        public static int x;
        public static int y;
        public static int input;
        public static void TakeNumbers()
        {
            while (true)
            {
                try
                {
                    Console.Write("Введите целое число x = ");
                    x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Введите целое число y = ");
                    y = Convert.ToInt32(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка, неверный формат!");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Число было слишком большим!");
                    continue;
                }
                break;
            }
        }
        public static void TakeOperator()
        {
            while (true)
            {
                try
                {
                    Console.WriteLine("Введите код операции:\n\t1 - Сложение\n\t2 - Вычитание\n\t3 - Умножение\n\t4 - Деление");
                    input = Convert.ToInt32(Console.ReadLine());
                    if (!(input > 0 & input < 5))
                    {
                        Console.WriteLine("Такой команды не существует!");
                        continue;
                    }
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка, неверный формат!");
                    continue;
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Число было слишком большим!");
                    continue;
                }
                break;
            }
        }
        public static void DoOperation()
        {
            switch (input)
            {
                case 1:
                    Console.WriteLine($"Результат - {Sum(x, y)}");
                    break;
                case 2:
                    Console.WriteLine($"Результат - {Sub(x, y)}");
                    break;
                case 3:
                    Console.WriteLine($"Результат - {Mul(x, y)}");
                    break;
                case 4:
                    Console.WriteLine($"Результат - {Div(x, y)}");
                    break;
            }
            Program.Calculate();
        }
        public static int Sum(int x, int y)
        {
            return x + y;
        }
        public static int Sub(int x, int y)
        {
            return x - y;
        }
        public static int Mul(int x, int y)
        {
            try
            {
                return x * y;
            }
            catch (OverflowException)
            {
                Console.WriteLine("Переполнение Int32, попробуйте числа поменьше");
                Program.Calculate();
            }
            return 0;
        }
        public static int Div(int x, int y)
        {
            if (y == 0)
            {
                Console.WriteLine("Делить на ноль нельзя!");
                Program.Calculate();
            }
            return x / y;
        }
    }
}
