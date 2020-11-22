using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP
{
    abstract class Book
    {
        public string name;
        public string author;
        public int year;


        public Book(string name, string author, int year)
        {
            this.name = name;
            this.author = author;
            this.year = year;
        }

        abstract public void Open(); //открыть книгу
        public virtual void contents() // открыть оглавление
        {
            Console.WriteLine("Оглавление открыто");
        }

    }
}
