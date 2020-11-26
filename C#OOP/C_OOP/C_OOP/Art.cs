using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP
{
    class Art: Electronic
    {
        public bool isart;
        public Art(string name, string author, int year, int size, bool isart) : base(name, author, year, size)
        {
            this.isart = isart;
        }

        public override void contents()
        {
            base.contents();
        }
    }
    
}
