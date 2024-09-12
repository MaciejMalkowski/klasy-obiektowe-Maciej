using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zadanie_maciej_c_
{
    

        class Bank
        {
            private string nameOfBank;
            private string nameOfCompany;
            private int numberOfWorkers;
            private int numberOfMoney;
            private int bankId;

            public void Kreator(string name, string company, int workers, int money, int id)
            {
                this.nameOfBank = name;
                this.nameOfCompany = company;
                this.numberOfWorkers = workers;
                this.numberOfMoney = money;
                this.bankId = id;
            }

            public int GetId()
            {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine(this.bankId);
            return this.bankId;
            Console.WriteLine("-----------------------------------");
        }

            public void GetValues()
            {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Dane obiektu " + this.nameOfBank + ": \n Nazwa banku:" + this.nameOfBank + "\n Nazwa firmy:" + this.nameOfCompany + "\n Liczba pracowników" + this.numberOfWorkers + "\n Liczba pieniędzy " + this.numberOfMoney);
            Console.WriteLine("-----------------------------------");
        }

        }
    }
