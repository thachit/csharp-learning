using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INterfaceApplication
{
    public interface ITransactions
    {
        void ShowTransaction();
        double getAmount();
    }

    public class Transactions : ITransactions
    {
        private string tCode;
        private string date;
        private double amount;

        public Transactions()
        {
            tCode = " ";
            date = " ";
            amount = 0.0;
        }

        public Transactions(string c, string d, double a)
        {
            tCode = c;
            date = d;
            amount = a;
        }

        public double getAmount()
        {
            return amount;
        }

        public void ShowTransaction()
        {
            Console.WriteLine("Transaction: {0}", tCode);
            Console.WriteLine("Date: {0}", date);
            Console.WriteLine("Amount: {0}", getAmount());
        }

        
    }

    class Program
    {
        static void Main(string[] args)
        {
            Transactions t1 = new Transactions("001", "8/10/2012", 78900.00);
            Transactions t2 = new Transactions("002", "9/10/2012", 451900.00);
            t1.ShowTransaction();
            t2.ShowTransaction();
            Console.ReadKey();
        }
    }
}
