namespace ATM_Simulator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string choice = "";
            Account account = new Account();

            while (choice!="4")
            {
                Console.WriteLine("---------Menu--------");
                Console.WriteLine("1- Deposit");
                Console.WriteLine("2- Withdraw");
                Console.WriteLine("3- CheckBalance");
                Console.WriteLine("4- Exit");
                Console.WriteLine("---------------------");
                choice =Console.ReadLine();
                switch (choice)
                {
                     
                    case "1":
                       
                        account.Deposit();
                        break;
                    case "2":
                        account.Withdraw();
                        break;
                    case "3":
                        account.CheckBalance();
                        break;
                    case "4":
                        Console.WriteLine("Exit");
                        break;
                    default:
                        Console.WriteLine("The Choice Not Found! Plase Select From Menu");
                        break;


                }
            }
        }
    }
}
