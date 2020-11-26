using System;

namespace C_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            Electronic book1 = new Electronic("Дубровский", "Пушкин", 2019, 2);
            Paper book2 = new Paper("Финансист", "Драйзер", 2020, true);

            book1.Open();
            book2.contents();

            Culinary book3 = new Culinary("100 рецептов", "Высоцкая", 2020, true, true);

            book3.contents();

            Art book4 = new Art("Бременские музыканты", "Перро", 2017, 4, true);
            book4.Open();
        }
    }
}
