using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication15
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba dyrektor = new Osoba();
            dyrektor.imie = "Adam";
            dyrektor.nazwisko = "kowalski";
            dyrektor.rokUrodzenia = 1970;
            dyrektor.waga = 90;
            dyrektor.wzrost = 175;
            dyrektor.okulary = true;
            dyrektor.plec = "M";

            Console.WriteLine(dyrektor.imie + "\n"+ dyrektor.nazwisko 
                + "\n");
            Console.WriteLine(dyrektor.ObliczWiek());

            Console.WriteLine(dyrektor.Info());
            Console.ReadKey();

        }
    }
}
