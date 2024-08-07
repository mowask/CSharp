using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace CS_L7
{
    internal class BankAccount
    {
        public int AccauntNumber { get; set; }
        public decimal Balance { get; set; }
        public string Name { get; set; }

        public decimal Withdraw (decimal amount)
        {
            try
            {
                if (amount <= 0)
                    throw new Exception("Сумма < 0");
                if (amount > Balance)
                    throw new Exception("Сумма > 0");
                Balance -= amount;
            }
            catch (Exception ex) {
            Console.WriteLine ("Error");
            }
            return Balance;
        }

        public decimal Deposit(decimal amount) 
        {
            try
            {
                if (amount <= 0)
                    throw new Exception("Сумма < 0");
              
                Balance += amount;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error");
            }
            return Balance;
        }

        public override string ToString()
        {
            return ( $"Name: {Name} \nAccauntNumber: {AccauntNumber} \nBalance: {Balance}");
        }
    }
}
