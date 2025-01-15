namespace Week2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product(101, "Lapto", 1200);


            AccountWithMethods myAcc = new AccountWithMethods(500);

            Console.WriteLine("Balance = " + myAcc.GetBalance().ToString("C"));

            myAcc.Deposit(100);
            Console.WriteLine("\nBalance = " + myAcc.GetBalance().ToString("C"));

            myAcc.Withdraw(300);
            Console.WriteLine("\nBalance = " + myAcc.GetBalance().ToString("C"));
        }
    }
}
