using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication
{
    public class Transactions 
    {
        float acBalance;
        

        List<float> acBalanceSheetadd = new List<float>();
        List<float> acBalanceSheetRemove = new List<float>();
        public Transactions()
        {
            
        }

        public void Deposite()
        {
            reset:
            Console.WriteLine("");
            Console.WriteLine("Enter Ammount to Deposite(Positive values only):");
            float depMoney =float.Parse(Console.ReadLine());
            if (depMoney>=0)
            {
                Console.WriteLine("");
                acBalance = acBalance + depMoney;
                acBalanceSheetadd.Add(depMoney);
                Console.WriteLine("total value added into addList:"+acBalanceSheetadd.Count);
                Console.WriteLine("Account Balance is:" + acBalance);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Enter Positive values only!");
                goto reset;
            }
            
        }

        public void Passbook()
        {
            Console.WriteLine("");
            Console.WriteLine("Total Transactions:-");
            Console.WriteLine("Ammount Deposited Transactions");
            foreach(var x in acBalanceSheetadd)
            {
                
                Console.Write(x+",");
                /*Console.WriteLine("");*/
            }
            Console.WriteLine("");
            Console.WriteLine("Ammount Withdraw Transactions");
            foreach (var y in acBalanceSheetRemove)
            {
                
                Console.Write(y + ",");
                
            }
            Console.WriteLine("");
        }

        public void Withdraw()
        {
            reset1:
            Console.WriteLine("");
            Console.WriteLine("Enter Money to Withdraw from account:");
            float wriMoney = float.Parse(Console.ReadLine());
            if (wriMoney<=acBalance)
            {
                Console.WriteLine("");
                acBalance = acBalance - wriMoney;
                
                acBalanceSheetRemove.Add(wriMoney);

                Console.WriteLine("Total value added into removeList:"+acBalanceSheetRemove.Count);
                Console.WriteLine("Account Balance is:" + acBalance);
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("Not enough Money to withdraw!!");
                goto reset1;
            }

        }
       
    }
}
