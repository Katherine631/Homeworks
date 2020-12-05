using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace C_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Paper book1 = new Paper("Финансист", "Драйзер", 2020, true);
            Paper book2 = new Paper("Финансист", "Драйзер", 2017, true);
            Paper book3 = new Paper("Три товарища", "Ремарк", 2019, true);
            

            Medicine book4 = new Medicine("Медицина для всех", "Воеводин", 2018, true, true);
            Medicine book5 = new Medicine("Медицина", "Иванович", 2017, true, true);

            

            List<Paper> temp = new List<Paper>();
            temp.Add(book1);
            temp.Add(book2);
            temp.Add(book3);
            temp.Add(book4);
            temp.Add(book5);

            
            static void print_list(List<Paper> temp)
            {
               
                foreach (var i in temp)
                {
                    Console.WriteLine(i.ToString());
                }

                Console.WriteLine("-------------------");

            }

            print_list(temp);
            List<Paper> temp2 = temp.Where(x => x.year > 2017).ToList();
            print_list(temp2);
            List<Paper> temp3 = temp.OrderBy(x => x.year).ToList();
            print_list(temp3);

            Console.WriteLine("Введите год издания книги:");
            
            int[] d = new int[2021];

            try
            {
                int y = int.Parse(Console.ReadLine());
                d[y] = 1; 
            }
            catch (FormatException x)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(x.Message);
            }

            catch (IndexOutOfRangeException x)
            {
                Console.WriteLine("Error!");
                Console.WriteLine(x.Message);
            }



        }
    }
}
