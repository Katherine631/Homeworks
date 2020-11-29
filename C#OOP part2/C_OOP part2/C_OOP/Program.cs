using System;

namespace C_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Paper book2 = new Paper("Финансист", "Драйзер", 2020, true);
            Paper book6 = new Paper("Финансист", "Драйзер", 2020, true);

            Paper book5 = new Paper("Три товарища", "Ремарк", 2019, true);

            Console.WriteLine(book2.ToString());
            Console.WriteLine(book5.ToString());

            Console.WriteLine(book2.Equals(book6));
            Console.WriteLine(book2.Equals(book5));
            Console.WriteLine(book2.year.Equals(book5.year));


            Medicine book7 = new Medicine("Медицина для всех", "Воеводин", 2018, true, true);
            Medicine book8 = new Medicine("Медицина", "Иванович", 2017, true, true);
            Console.WriteLine(book7.Equals(book8));

            Electronic<int> book9 = new Electronic<int>("Три товарища", "Ремарк", 2019, 20);
            Electronic<double> book10 = new Electronic<double>("Три товарища", "Ремарк", 2019, 2.1520);
            Electronic<string> book11 = new Electronic<string>("Три товарища", "Ремарк", 2019, "20");
            
            Console.WriteLine(book9.ToString());
            Console.WriteLine(book10.ToString());
            Console.WriteLine(book11.ToString());
        }
    }
}
