using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP
{
    class Electronic: Book
    {
        public int size;

        public Electronic(string name, string author, int year, int size) : base(name, author, year)
        {
            this.size = size;
        }
        public override void Open()
        {
            Console.WriteLine("Электронная книга открыта");
        }
        public override void contents()
        {
            Console.WriteLine("Оглавление электронной книги открыто");
        }
    }
}
