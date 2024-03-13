using Productie.Clase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productie
{
    internal class Job : ICalculareComision
    {
        private string nume;
        private string departament;
        private float salariu;

        public Job(string nume, string departament, float salariu)
        {
            this.nume = nume;
            this.departament = departament;
            this.salariu = salariu - CalculComision(salariu);
        }

        public static Job operator ++(Job obj)
        {
            obj.salariu += 100;
            return obj;
        }

        public static Job operator --(Job obj)
        {
            obj.salariu -= 100;
            return obj;
        }

        public float CalculComision(float salariu)
        {
            if (salariu < 2000) return 0;
            else if (salariu >= 2000 && salariu < 5000) return salariu * 10 / 100;
            else return salariu * 20 / 100;
        }

        public string Nume
        {
            get { return nume; }
            set { nume = value; }
        }
        public string Departament
        {
            get { return departament; }
            set { departament = value; }
        }
        public float Salariu
        {
            get { return salariu; }
            set { salariu = value; }
        }
    }
}

