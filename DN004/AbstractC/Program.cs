using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractC
{
    interface ISpecialOffer
    {
        void Offer();
    }
   abstract class Bank
    {
        public void Entry()
        {
            Console.WriteLine("Please enter your name:");
            string name = Console.ReadLine();
            

        }
        public virtual void Registration()
        {
            Console.WriteLine("Registered Successfully");
        }
        public abstract void MinBal(); 

    }

    class SavingsAccount : Bank,ISpecialOffer
    {
        public override void MinBal()
        {
            Console.WriteLine("The minimum balance for saving account must be atleast 3000 Rs.");
        }
        public override void Registration()
        {
            base.Registration();
        }
        public void Offer()
        {
            Console.WriteLine("10,000 Rs additonal credits for new joiners");
        }
    }

    class CurrentAccount : Bank
    {
        public override void MinBal()
        {
            Console.WriteLine("The minimum balance for current account is 0 Rs.");
        }

        public override void Registration()
        {
            base.Registration();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
           
            SavingsAccount savings = new SavingsAccount();
            savings.MinBal();
            savings.Registration();
            savings.Offer();
            Console.WriteLine("--------------------------------------------------------------------------------------");
            CurrentAccount current = new CurrentAccount();
            current.MinBal();
            current.Registration();
            Console.ReadKey();
        }
    }
}
