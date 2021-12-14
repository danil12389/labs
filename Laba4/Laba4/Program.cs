using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laba4
{
    internal class Program
    {
        //третий вариант
        static void Main(string[] args)
        {
           
            NumberOne(int.Parse(Console.ReadLine()));
            Console.WriteLine("----------------------------------------------------");
            NumberFour();
            Console.WriteLine("----------------------------------------------------");
            NumberNineB();
            Console.WriteLine("----------------------------------------------------");
            NumberTenA();
            Console.ReadLine();

        }


        public static void NumberOne(int n)
        {
            int[] arr = new int[n];
            Random rand = new Random();
            for (int i = 0; i < arr.Length; i++)
                arr[i] = rand.Next(-100, 100);
            int numberOfNegativeDigits = 0;
            int numberOfPositiveDigits = 0;
            int lowestEvenNumber = arr.Max();
            int biggestUnevenNumber = arr.Min();
            int count = 0;
            for (int i = 0;i < arr.Length;i++)
            {
                if(arr[i] < 0)
                {
                    numberOfNegativeDigits++;
                }
                if(arr[i] > 0)
                {
                    numberOfPositiveDigits++;
                }
                if(arr[i] % 2 == 0)
                {
                    if(lowestEvenNumber > arr[i])
                    {
                        lowestEvenNumber = arr[i];
                    }
                }
                if (arr[i] % 2 != 0)
                {
                    if (biggestUnevenNumber < arr[i])
                    {   
                        biggestUnevenNumber = arr[i];
                    }
                }
                Console.WriteLine(arr[i]);
            }
            for (int i = 1; i < arr.Length - 1; i++)
                if ((arr[i] > arr[i - 1]) && (arr[i] > arr[i + 1]))
                    count++;
            Console.WriteLine("Количество положительных чисел: " + numberOfPositiveDigits + "\nКоличество отрицательных чисел: " + numberOfNegativeDigits + "\nНаименьшее четное число: " + lowestEvenNumber + "\nНаибольшее нечетное число: " + biggestUnevenNumber + "\nМинимальное значение: " + arr.Min() + "\nМаксимальное значение: "+ arr.Max() + "\nКоличество чисел, которые больше своих соседей: "+ count);

        }

        public static void NumberFour()
        {
            double[] result = new double[100];
            result[0] = 0.3;
            result[1] = -0.3;
            double sum = 0;
            for(int i  = 2; i < 100; i++)
            {
                result[i] = i + Math.Sin(result[i - 2]);
            }
            for (int i = 0; i < 100; i++)
            {
                sum += result[i] * result[99 - i];
                
            }
            Console.WriteLine("Результат: " + sum);
        }

        public static void NumberNineB()
        {
            //Xi = a + ih, h = (b-a)/h
            //y = sqrt(x*x+2), a = -3, b = 5, n = 40;
            double h = 8.0 / 40.0;
            double[] xArray = new double[40];
            double[] yArray = new double[40];
            for(int i = 0; i < 40; i++)
            {
                xArray[i] = -3 + i*h;
            }
            for(int j = 0; j < 40; j++)
            {
                yArray[j] = Math.Sqrt(xArray[j] * xArray[j] + 2);
                Console.WriteLine("Значение функции: " + yArray[j] + ", Значение аргумента: " + xArray[j]);
            }
         }

        public static void NumberTenA()
        {
            //Ak = Sin^2(3k+5)-Cos(k^2-15)
            int k = 0;
            double pow1 = 0;
            int counter = 0;
            double[] arr = new double[1000];
            for(int i = 0;i < 1000;i++)
            {
                arr[i] = Math.Sin(3 * i + 5) * Math.Sin(3 * i + 5) - Math.Cos(i * i - 15);
            }
            while (k <= 1000)
            {
                if(arr[k] < 0.25) {
                    counter++;
                }
                k = (int)Math.Pow(2.0, pow1);
           
                pow1++;
            }
            Console.WriteLine("Количество чисел меньше 0,25: " + counter);
        }
    }
}
