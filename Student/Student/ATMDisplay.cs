using System;

namespace Student
{
    internal class ATMDisplay
    {
        private decimal accountBalance;

        public ATMDisplay(decimal initialBalance)
        {
            accountBalance = initialBalance;
        }

        public void DisplayOptions()
        {
            Console.WriteLine("1. Check Balance");
            Console.WriteLine("2. Cash Deposit");
            Console.WriteLine("3. Cash Withdraw");
            Console.WriteLine("4. Exit");
        }

        public void CheckBalance()
        {
            Console.WriteLine($"Your current balance is: {accountBalance}");
        }

        public void CashDeposit(decimal amount)
        {
            accountBalance += amount;
            Console.WriteLine($"Successfully deposited {amount}. Your new balance is: {accountBalance}");
        }

        public void CashWithdraw(decimal amount)
        {
            if (amount > accountBalance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                accountBalance -= amount;
                Console.WriteLine($"Successfully withdrew {amount}. Your new balance is: {accountBalance}");
            }
        }
    }

    
}
