namespace Encapsulation
{
    class Program
    {
        public static void Main(string[] args) 
        { 
            BankAccount account = new BankAccount();
            account.Diposit(1000);
            account.Withdraw(500);
            Console.ReadLine();
        }

        class BankAccount
        {
            private double Balance { get; set; }

            public void Diposit(double amount)
            {
                if (amount > 0)
                {
                    Balance += amount;
                    Console.WriteLine($"Diposited : {amount} , New Balance : {Balance}");
                }
                else
                {
                    Console.WriteLine("Invalid deposit amount.");
                }
            }

            public void Withdraw(double amount)
            {
                if (amount > 0 && amount <= Balance)
                {
                    Balance -= amount;
                    Console.WriteLine($"Withdraw : {amount} , New Balance : {Balance}");
                }
                else 
                {
                    Console.WriteLine("Insufficient balance or invalid amount.");
                }
            }
        }
    }
}