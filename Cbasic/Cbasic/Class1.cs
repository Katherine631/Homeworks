using System;
using System.Collections.Generic;
using System.Text;

namespace Cbasic
{
    class Class1
    {
        static public void calculator()
        {
            Console.WriteLine("Введите аргумент и нажмите Enter:");
            double x = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите оператор и нажмите Enter:");
            string d = Console.ReadLine();
            Console.WriteLine("Введите аргумент и нажмите Enter:");
            double y = double.Parse(Console.ReadLine());

            switch (d)
            {
                case "+": Console.WriteLine("Результат равен {0}", (x + y)); break;
                case "-": Console.WriteLine("Результат равен {0}", (x - y)); break;
                case "/": Console.WriteLine("Результат равен {0}", (x / y)); break;
                case "*": Console.WriteLine("Результат равен {0}", (x * y)); break;
                default: Console.WriteLine("Операция недоступна"); break;
            }

        }
        static public void massiv()
        {
            int n;
            Console.Write("Введите число элементов массива: ");
            n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write("Введите arr[{0}] ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.ReadLine();

            int t;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = i + 1; j < n; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        t = arr[i];
                        arr[i] = arr[j];
                        arr[j] = t;
                    }
                }
            }

            //Console.WriteLine("Элементы массива:");
            //for (int i = 0; i < n; i++)
            //{
            //    Console.WriteLine("arr[{0}] = {1}",
            //    i, arr[i]);
            //}
            //Console.ReadLine();

            foreach (int i in arr)
            {
                Console.WriteLine(i);
            }
        }
    }
}
