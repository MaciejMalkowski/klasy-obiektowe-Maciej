using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_maciej_c_
{
    class Osoba
    {
        private string nameOfPerson;
        private string surnameOfPerson;
        private int ageOfPerson;
        private int netWorthOfPerson;
        private string sexOfPerson;
        private int id;

        public void Kreator(string name, string surname, int netWorth, int age, string sex, int id)
        {
            this.nameOfPerson = name;
            this.surnameOfPerson = surname;
            this.ageOfPerson = age;
            this.sexOfPerson = sex;
            this.netWorthOfPerson = netWorth;
            this.id = id;
        }

        public int GetId()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(this.id);
            return this.id;
            Console.WriteLine("-----------------------------------");
        }

        public void GetValues()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Dane obiektu " + this.nameOfPerson + ": \n Imie osoby:" + this.nameOfPerson + "\n Nazwisko osoby:" + this.surnameOfPerson + "\n Majątek osoby:" + this.netWorthOfPerson + "\n Płeć osoby " + this.sexOfPerson);
            Console.WriteLine("-----------------------------------");
        }

    }
}
