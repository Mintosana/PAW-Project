using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Resurse_Umane
{
    internal class Curs : ICloneable, IComparable<Curs>
    {
        private string nume;
        private tipCurs tip;

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }

        public tipCurs Tip
        {
            get { return tip; }
        }

        public Curs(string nume, tipCurs tip)
        {
            this.nume = nume;
            this.tip = tip;
        }

        public Curs()
        {
            this.nume = "Inexistent";
            this.tip = 0;
        }



        public enum tipCurs
        {
            None = 0,
            Compliance,
            Onboarding,
            Tehnical,
            Management
        }

        public object Clone()
        {
            return new Curs(nume,tip);
        }

        public int CompareTo(Curs other)
        {
            return nume.CompareTo(other.nume);
        }
    }
}
