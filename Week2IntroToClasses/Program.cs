namespace Week2IntroToClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Product p1 = new Product();
            Product p2 = new Product(101, "Lapto", 1200);


            p1.Quantity = 20;


            //AccountWithMethods myAcc = new AccountWithMethods(500);

            //Console.WriteLine("Balance = " + myAcc.GetBalance().ToString("C"));

            //myAcc.Deposit(100);
            //Console.WriteLine("\nBalance = " + myAcc.GetBalance().ToString("C"));

            //try
            //{
            //    myAcc.Withdraw(3000);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(ex.Message);
            //}

            //Console.WriteLine("\nBalance = " + myAcc.GetBalance().ToString("C"));



            AccountWithProperties myAcc = new AccountWithProperties(500);

            Console.WriteLine("Balance = " + myAcc.Balance.ToString("C"));

            myAcc.Deposit(100);
            Console.WriteLine("\nBalance = " + myAcc.Balance.ToString("C"));

            try
            {
                myAcc.Withdraw(300);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            Console.WriteLine("\nBalance = " + myAcc.Balance.ToString("C"));
        }
    }
}
