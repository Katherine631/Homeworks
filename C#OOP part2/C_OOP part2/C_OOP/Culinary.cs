using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP
{
    class Culinary: Paper
    {
        public bool isculinary;
        public Culinary(string name, string author, int year, bool isPaper, bool isculinary) : base(name, author, year, isPaper)
        {

            this.isculinary = isculinary;
        }

        public override void Open()
        {
            base.Open();
        }
    }
}
