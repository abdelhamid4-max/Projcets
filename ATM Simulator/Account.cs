using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM_Simulator
{
    internal class Account
    {
        decimal balance=0;
        internal void Deposit()
        {
            Console.WriteLine("Enter The Amount To Deposit");
            bool deposit = decimal.TryParse(Console.ReadLine(), out decimal result_deposit);
            
                balance += result_deposit;
                Console.WriteLine("The Deposit secceded");
            
        }
        internal void Withdraw()
        {
            Console.WriteLine("Enter The Amount Want To Withdraw");
            bool withdraw = decimal.TryParse(Console.ReadLine(), out decimal result_Withdraw);
            if (result_Withdraw > balance)
            {
                Console.WriteLine("The Amount Less Than Of Withdraw");
            }
            else
            {

                balance = balance - result_Withdraw;
                Console.WriteLine("The Withdraw secceded");

            }
            }
        
        internal void CheckBalance()
        {
            Console.WriteLine($"Your Balance = {balance}");
        }
    }
}
