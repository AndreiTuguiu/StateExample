using Abstractions;
using System;

namespace Models
{
    public class ATMMachine: IATMState
    {
        public IATMState atmMachineState { get; set; }

        public ATMMachine()
        {
            atmMachineState = new DebitCardNotInsertedState();
        }

        public void InsertDebitCard()
        {
            atmMachineState.InsertDebitCard();

            if(atmMachineState is DebitCardNotInsertedState)
            {
                atmMachineState = new DebitCardNotInsertedState();
                Console.WriteLine($"ATM changed state to {atmMachineState.GetType().Name}");
            }
        }

        public void EjectDebitCard()
        {
            atmMachineState.EjectDebitCard();
            if (atmMachineState is DebitCardNotInsertedState)
            {
                atmMachineState = new DebitCardInsertedState();
                Console.WriteLine($"ATM changed state to {atmMachineState.GetType().Name}");
            }
        }

        public void EnterPin()
        {
            atmMachineState.EnterPin();
        }

        public void WithdrawMoney()
        {
            atmMachineState.WithdrawMoney();
        }
    }
}
