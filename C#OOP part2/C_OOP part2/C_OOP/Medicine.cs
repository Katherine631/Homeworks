using System;
using System.Collections.Generic;
using System.Text;

namespace C_OOP
{
    class Medicine : Paper
    {
        public bool ismedicine;
        public Medicine(string name, string author, int year, bool isPaper, bool ismedicine) : base(name, author, year, isPaper)
        {
            this.ismedicine = ismedicine;
        }

        public override bool Equals(object obj)
        {
            return obj is Medicine medicine &&
                    name.Contains(medicine.name);
                   
        }

        public override void Open()
        {
            base.Open();
        }
    }
}
