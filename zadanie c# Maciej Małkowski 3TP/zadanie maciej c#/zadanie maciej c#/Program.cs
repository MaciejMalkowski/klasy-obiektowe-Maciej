using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_maciej_c_
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Osoba grzegorz = new Osoba();
            grzegorz.Kreator("Grzegorz", "Kowalski", 35, 100, "Male", 1);
            grzegorz.GetValues();
            grzegorz.GetId();

            Osoba andrzej = new Osoba();
            andrzej.Kreator("Andrzej", "Nowak", 2000, 5, "Male", 2);
            andrzej.GetValues();
            andrzej.GetId();

            Osoba bartosz = new Osoba();
            bartosz.Kreator("Bartosz", "Kochanowski", 10000, 20, "Male", 3);
            bartosz.GetValues();
            bartosz.GetId();


            Bank PKO = new Bank();
            PKO.Kreator("PKO Bank Polski", "PKO S.A", 35, 100, 1);
            PKO.GetValues();
            PKO.GetId();

            Bank santander = new Bank();
            santander.Kreator("Santander", "Santander Co.", 2000, 5, 2);
            santander.GetValues();
            santander.GetId();

            Bank amberGold = new Bank();
            amberGold.Kreator("AmberGold", "AmberGold Sp.Z.O.O", 10000, 20, 3);
            amberGold.GetValues();
            amberGold.GetId();


            CreditOwner posiadaczKredytu1 = new CreditOwner();
            posiadaczKredytu1.Kreator("Grzegorz", "Kowalski", 12, 1, 1);
            posiadaczKredytu1.GetValues();
            posiadaczKredytu1.GetId();

            CreditOwner posiadaczKredytu2 = new CreditOwner();
            posiadaczKredytu2.Kreator("Andrzej", "Nowak", 12, 1, 2);
            posiadaczKredytu2.GetValues();
            posiadaczKredytu2.GetId();

            CreditOwner posiadaczKredytu3 = new CreditOwner();
            posiadaczKredytu3.Kreator("Bartosz", "Kochanowski", 10000, 20, 3);
            posiadaczKredytu3.GetValues();
            posiadaczKredytu3.GetId();

            Console.ReadKey();

        }


    }
}
