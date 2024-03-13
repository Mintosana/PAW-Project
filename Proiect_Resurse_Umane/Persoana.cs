using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_Resurse_Umane
{
    internal class Persoana : ICloneable , IComparable<Persoana>
    {
        private string nume;
        private int varsta;
        private string facultate;
        private Curs[] cursuri;  // To Further Implement

        private int id;

        private static int nextId;

        public Persoana(string nume,int varsta, string facultate)
        {
            this.nume = nume;
            this.varsta = varsta;
            this.facultate = facultate;
            this.id = Interlocked.Increment(ref nextId);
           
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public int Id { 
            get { return id; } 
            set { id = value; }
        }
        public int Varsta
        {
            get { return varsta; }
            set { varsta = value; }
        }
        public string Facultate
        {
            get { return facultate; }
            set { facultate = value; }
        }

        public object Clone()
        {
            return new Persoana(nume,varsta,facultate);
        }

        public int CompareTo(Persoana other)
        {
            return id.CompareTo(other.Id);
        }
    }
}
