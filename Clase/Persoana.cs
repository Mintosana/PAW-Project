using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Productie
{
    public partial class Persoana : ICloneable, IComparable
    {
        private int id;
        private string nume;
        private string prenume;
        private string telefon;
        private string email;
        private string educatie; // to do
        private bool engleza; // grija e bool

        private string username;
        private string parola;
        private string parolaConf;

        public static int contor = 0;

        public Persoana()
        {
            nume = "Nume";
            prenume = "Prenume";
            telefon = "+40....";
            email = "domeniu@gmail.com";
            educatie = "undefined";
            engleza = false;

            parola = "parola";
            parolaConf = "parola";
            username = "None";
            id = contor++;
        }

        public Persoana(string _nume, string _prenume, string _telefon,
            string _email, string _educatie, bool _engleza, string _username,
            string _parola, string _parolaConf)
        {
            nume = _nume;
            prenume = _prenume;
            telefon = _telefon;
            email = _email;
            educatie = _educatie;
            engleza = _engleza;

            username = _username;
            parola = _parola;
            parolaConf = _parolaConf;

            id = contor++;
        }

        public string Nume
        {
            get { return nume; }
            set
            {
                if (value != null)
                    nume = value;
            }
        }

        public string Prenume
        {
            get { return prenume; }
            set
            {
                if (value != null)
                    prenume = value;
            }
        }

        public string Telefon
        {
            get { return telefon; }
            set
            {
                if (value != null)
                    telefon = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (value != null)
                    email = value;
            }
        }

        public string Educatie
        {
            get { return educatie; }
            set
            {
                if (value != null)
                    educatie = value;
            }
        }

        public bool Engleza
        {
            get { return engleza; }
            set
            {
                if (value != null)
                    engleza = value;
            }
        }

        public string Username
        {
            get { return username; }
            set
            {
                if (value != null)
                    username = value;
            }
        }

        public string Parola
        {
            get { return parola; }
            set
            {
                if (value != null)
                    parola = value;
            }
        }

        public string ParolaConf
        {
            get { return parolaConf; }
            set
            {
                if (value != null)
                    parolaConf = value;
            }
        }

        public Persoana getPersoana()
        {
            return new Persoana(nume, prenume, telefon, email, educatie, engleza, username, parola, parolaConf);
        }

        public Object Clone()
        {
            return this.MemberwiseClone();
        }

        public int CompareTo(Object obj)
        {
            Persoana p = (Persoana)obj;
            return String.Compare(username, p.username);
        }

        public override string ToString()
        {
            // nu am dat return la engleza
            return "Nume: " + nume + "\nPrenume: " + prenume + "\nTelefon: " + telefon + "\nEmail: " + email
                + "\nEducatie: " + educatie + "\nUsername: " + username;
        }
    }
}
