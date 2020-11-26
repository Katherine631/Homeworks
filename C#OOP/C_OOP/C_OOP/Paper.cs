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
    }


}
