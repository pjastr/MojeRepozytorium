using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Osoba
    {
        internal string imie;
        internal string nazwisko;
        internal int rokUrodzenia;
        public int waga;
        public int wzrost;
        public bool okulary;
        public string plec;
        public int ObliczWiek()
        {
            return DateTime.Now.Year - rokUrodzenia;
        }

        public string Info()
        {
            if (plec == "K")
            {
                return "Dyrektorem jest Pani " + imie + " " + nazwisko;
            }
            else
            {
                return "Dyrektorem jest Pan " + imie + " " + nazwisko;
            }
        }
    }
}
