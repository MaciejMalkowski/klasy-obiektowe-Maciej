using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_maciej_c_
{


    class CreditOwner
    {
        private string nameOfCreditOwner;
        private string surnameOfCreditOwner;
        private int worthOfCredit;
        private int idOfBank;
        private int idOfPerson;

        public void Kreator(string name, string surname, int creditWorth, int idOfBank, int idOfPerson)
        {
            this.nameOfCreditOwner = name;
            this.surnameOfCreditOwner = surname;
            this.worthOfCredit = creditWorth;
            this.idOfBank = idOfBank;
            this.idOfPerson = idOfPerson;

        }

        public int GetId()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(this.idOfPerson);
            return this.idOfPerson;
            Console.WriteLine("-----------------------------------");
        }

        public void GetValues()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Dane obiektu " + this.nameOfCreditOwner + ": \n Imie posiadacza kredytu:" + this.nameOfCreditOwner + "\n Nazwisko posiadacza kredytu:" + this.surnameOfCreditOwner + "\n Wartość kredytów" + this.worthOfCredit + "\n Id banku " + this.idOfBank);
            Console.WriteLine("-----------------------------------");
        }

    }
}
