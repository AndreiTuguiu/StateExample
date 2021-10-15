using Abstractions;
using System;

namespace Models
{
    public class DebitCardNotInsertedState : ATMState
    {
        public void EjectDebitCard()
        {
            Console.WriteLine("You cannot eject a debit card, as no debit card was inserted");
        }

        public void EnterPin()
        {
            Console.WriteLine("You cannot enter any pin, as you don't have a debit card inserted");
        }

        public void InsertDebitCard()
        {
            Console.WriteLine("Debit card Inserted");
        }

        public void WithdrawMoney()
        {
            Console.WriteLine("You can't withdraw money, as no debit card was inserted");
        }
    }
}
