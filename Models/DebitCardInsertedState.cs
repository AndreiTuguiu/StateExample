using Abstractions;
using System;

namespace Models
{
    public class DebitCardInsertedState : ATMState
    {
        public void EjectDebitCard()
        {
            Console.WriteLine("Debit card ejected");
        }

        public void EnterPin()
        {
            Console.WriteLine("Pin number typed in successfully");
        }

        public void InsertDebitCard()
        {
            Console.WriteLine("You cannot insert a debit card, as it is already inserted");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("Money withdrawn");
        }
    }
}
