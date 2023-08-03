using System;

namespace project
{
    class programm
    {
        static void Main(string[] args)
        {
            int Vvod(string text)
            {
                Console.Write(text);
                return Convert.ToInt32(Console.ReadLine());

            }
            void recursion64(int counter, int number)
            {
                if (counter > number) return;
                if (counter % 3 == 0)
                    Console.Write($"{counter} ");
                counter++;
                recursion64(counter, number);

            }

            void recursion66(int counter, int number, int sum)
            {
                if (counter > number) return;
                sum = sum + counter;
                Console.Write($"{counter} ");
                counter++;
                if (counter > number)
                {
                    Console.WriteLine("\nСумма элементов равна " + sum);
                }
                recursion66(counter, number, sum);
            }

            int recursion68(int m, int n)
                {
                    if (m == 0) return n + 1;
                    else if (n == 0) return recursion68(m - 1, 1);
                    else return recursion68(m - 1, recursion68(m, n - 1));
                }


            void task64() //Задайте значения M и N. Напишите рекурсивный метод, который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
            {

                int counter = Vvod("Введите 1-e число: ");
                int number = Vvod("Введите 2-e число: ");
                recursion64(counter, number);

            }


            //task64();

            void task66()   //Задайте значения M и N. Напишите рекурсивный метод, который найдёт сумму натуральных элементов в промежутке от M до N.
            {
                int counter = Vvod("Введите 1-e число: ");
                int number = Vvod("Введите 2-e число: ");
                recursion66(counter, number, 0);
            }

            //task66();

            void task68() //Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
            {
                int m = Vvod("Введите 1-e число: ");
                int n = Vvod("Введите 2-e число: ");
                System.Console.WriteLine(recursion68(m,n));
            }
            //task68();


            
        }
    }
}