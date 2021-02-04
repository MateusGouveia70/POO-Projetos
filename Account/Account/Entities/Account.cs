using System;

namespace AccountExercicio.Entities
{
    class Account
    {
        public int Number { get; private set; }
        public string Holder { get; set; }
        public double Balance { get; private set; }
        public double WithDrawLimit { get; private set; }

        public Account()
        {

        }

        public Account(int number, string holder, double balance, double withDrawLimit)
        {
            Number = number;
            Holder = holder;
            Balance = balance;
            WithDrawLimit = withDrawLimit;
        }

        public void Deposite(double amount)
        {
             Balance += amount;
        }

        public void WithDraw(double amount)
        {
            if (amount > WithDrawLimit)
            {
                throw new Exception("The amount exceeds withdraw limit");
            }
            if (Balance < amount) 
            {
                throw new Exception("Not enough balance");
            }
           

             Balance -= amount;
        }
    }
}
