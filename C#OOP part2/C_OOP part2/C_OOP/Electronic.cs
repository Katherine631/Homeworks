using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP
{
    class Electronic <T>
    {
        public T size;
        public string name;
        public string author;
        public int year;

        public Electronic(string name, string author, int year, T size) 
        {
            this.name = name;
            this.author = author;
            this.year = year;
            this.size = size;
        }

        public override string ToString()
        {
            return String.Format("Название книги: {0}, автор: {1}, год выпуска: {2}, размер файла: {3}",name, author, year, size);
        }
    }
}
