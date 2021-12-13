using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba3
{
    internal class Program
    {

        //третий вариант
        static void Main(string[] args)
        {
            Console.WriteLine("Какую задачу хотите посмотреть? Доступные варианты: 1.1, 1.4, 1.8, 2.3, 2.8, 2.10, 3.1. \n Введите номер в формате таблица.номер_задачи: ");
            switch(Console.ReadLine())
            {
                case "1.1":
                    Console.WriteLine("Номер 1 из таблицы 1, введите число n: ");
                    Console.WriteLine("Результат: " + SheetOneNumberOne(int.Parse(Console.ReadLine())) + "\n");
                    Console.ReadLine();
                    break;
                case "1.4":
                    Console.WriteLine("Номер 4 из таблицы 1, введите число x, затем через пробел число n: ");
                    string line = Console.ReadLine();
                    string[] tokens = line.Split(' ');
                    double x = double.Parse(tokens[0]);
                    int n = int.Parse(tokens[1]);
                    Console.WriteLine("Результат: " + SheetOneNumberFour(x, n) + "\n");
                    Console.ReadLine();
                    break;
                case "1.8":
                    Console.WriteLine("Номер 8 из таблицы 1, введите e: ");
                    Console.WriteLine("Результат: " + SheetOneNumberEight(double.Parse(Console.ReadLine())) + "\n");
                    Console.ReadLine();
                    break;
                case "2.3":
                    Console.WriteLine("Номер 3 из таблицы 2");
                    Console.WriteLine("Результат: " + SheetTwoNumberThree());
                    Console.ReadLine();
                    break;
                case "2.8":
                    Console.WriteLine("Номер 8 из таблицы 2");
                    Console.WriteLine("Результат: " + SheetTwoNumberEight());
                    Console.ReadLine();
                    break;
                case "2.10":
                    Console.WriteLine("Номер 10 из таблицы 2, введите число m:");
                    SheetTwoNumberTen(int.Parse(Console.ReadLine()));
                    Console.ReadLine();
                    break;
                case "3.1":
                    Console.WriteLine("Номер 1 из таблицы 3, введите число m:");
                    int rightBorder = int.Parse(Console.ReadLine());
                    var values = Enumerable.Range(1, rightBorder).Where(z => SheetThreeNumberOne(z));
                    Console.WriteLine("Числа Армстронга на промежутке от 1 до " + rightBorder);
                    foreach (var value in values) Console.WriteLine(value);
                    Console.ReadLine();
                    break;
                default:
                    Console.WriteLine("Такой задачи нет");
                    Console.ReadLine();
                    break;
            }
        }


        public static double SheetOneNumberOne(int n)
        {
            double sum = 0;
            for( double i = 1; i <= n; i++)
            {
                sum += (1 + (1 / (i * i)));
                
            }
            return sum;
        }

        public static double SheetOneNumberFour(double x, int n)
        {
            double sum = 1/x;
            double result = 0;
            for (double i = 0; i < n; i++)
            {
                result += sum;
                sum *= 1 / (x + i);
            }
            return sum;
        }

        public static double SheetOneNumberEight(double e) 
        {
            double sum = 0;
            double i = 1;
            double result = 0;
            String numberOfDigits = e.ToString().Substring(2);
            double Answer = Math.Round(Math.PI * Math.PI / 6, numberOfDigits.Length);
            Console.WriteLine(result);
            while(sum <= Answer)
            {
                result = 1 / Math.Pow(i, 2);
                i++;
                Console.WriteLine(sum + " " + Answer );
                sum = Math.Round(sum + result, numberOfDigits.Length);
                                                        
            }
            return sum; 
        }

        public static int SheetTwoNumberThree()
        {
            int sum = 0;
            for( int i = 100;i <= 999;i++)
            {
                int first = i / 100;
                int second = i / 10 % 10;
                int third = i % 10;
                if(second == first + third)
                {
                    Console.WriteLine("Это число: " + i);
                    sum++;
                }
            }
            return sum;
        }

        public static int SheetTwoNumberEight()
        {
            int sum = 0;
            for (int i = 10; i <= 99; i++)
            {
                int first = i / 10;
                int second = i % 10;
                if (i == (first * second) *3 )
                {
                    Console.WriteLine("Это число: " + i);
                    sum++;
                }
            }
            return sum;
        }

        public static void SheetTwoNumberTen(int m)
        {
            for( int i = 0; i < m; i++)
            {
                for (int j = 0; j < m; j++) { 
                    if( i*i + j*j == m)
                    {
                        Console.WriteLine("Это числа: " + i + ", " + j);
                    }
                }
            }
        }

        public static bool SheetThreeNumberOne(int _val)
        {
            string valueInString = _val.ToString(); //получаем строковое представление числа

            var digits = valueInString.Select(x => int.Parse(x.ToString())); //последовательность цифр в числе - каждый символ строки, приведенный к int

            int n = digits.Count();//количество цифр

            return _val == digits.Select(x => Math.Pow(x, n)).Sum(); //каждую цифру возводим в степень - последовательность суммируем,  проверяем на равность исходному числу и возвращаем да\нет

        }

    }
}
