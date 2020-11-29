using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP
{
    class Paper: Book
    {
        public bool isPaper;
        

        public Paper(string name, string author, int year, bool isPaper) : base(name, author, year)
        {
            
            this.isPaper = isPaper;
        }

        public override void Open()
        {
            Console.WriteLine("Бумажная книга открыта"); 
        }

        public override void contents()
        {
            Console.WriteLine("Оглавление бумажной книги открыто");
        }

        public override string ToString()
        {
            return String.Format("Название книги: {0}, автор: {1}, год выпуска: {2}", name, author, year);
        }

        public override bool Equals(object obj)
        {
            return obj is Paper paper &&
                   name == paper.name &&
                   author == paper.author &&
                   year == paper.year;
        }
    }


}
