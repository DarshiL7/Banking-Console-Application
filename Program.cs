using System;

namespace BankingApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            
            OpenAccount openAccount = new OpenAccount("user1", "pass1");
            Transactions transactions = new Transactions();
            openAccount.AddNewUser();
            openAccount.Validate();
        repeate:
            
            Console.WriteLine("Enter Choice From Bellow");
            Console.WriteLine("1-Deposit Money");
            Console.WriteLine("2-Withdraw Money");
            Console.WriteLine("3-PassBook");
            Console.WriteLine("4-Update password");
            Console.WriteLine("5-Exit");
            int choice = Int32.Parse(Console.ReadLine());
            
            switch (choice)
            {
                case 1:
                    transactions.Deposite();
                    goto repeate;
                    //break;

                case 2:
                    transactions.Withdraw();
                    goto repeate;
                    //break;

                case 3:
                    transactions.Passbook();
                    goto repeate;
                    //break;

                case 4:
                    openAccount.Update();
                    openAccount.Validate();
                    goto repeate;
                    //break;
                case 5:
                    break;

                default:
                    Console.WriteLine("Choose From the above only");
                    break;
            }

            

            
            



            Console.ReadLine();
        
        }
    }
}
