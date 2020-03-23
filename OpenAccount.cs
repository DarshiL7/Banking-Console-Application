using System;
using System.Collections.Generic;
using System.Text;

namespace BankingApplication
{
    public class OpenAccount 
    {
        string userName, passWord;
        Dictionary<string, string> Users = new Dictionary<string, string>();
        public OpenAccount(string userName, string passWord)
        {
            this.userName = userName;
            this.passWord = passWord;
            //Console.WriteLine("Your UserName is " + userName + " and PassWord is " + passWord);
        }

        public void AddNewUser()
        {
            //Dictionary<string, string> Users = new Dictionary<string, string>();
            Console.WriteLine("How many users want to add?:");
            int n = Int32.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine("Enter UserName:");
                userName = Console.ReadLine();
                Console.WriteLine("Enter PassWord:");
                passWord = Console.ReadLine();

                Users.Add(userName, passWord);
                Console.WriteLine("Your UserName is " + userName + " and PassWord is " + passWord);

            }
            Console.WriteLine(Users.Count);
            //Auth auth = new Auth();

            /*void Auth()
            {
                
            }*/
            


        }

        public void Validate()
        {
            //Auth auth = new Auth();
            //auth.AuthUser();

            /*string tempUsername= AddNewUser().Keys.ToString();
            Console.WriteLine(tempUsername);*/

            repeate:
            Console.WriteLine("Enter UserName & Password to Login");
            string authUsername = Console.ReadLine();
            string authPassword = Console.ReadLine();



            /*if (Users.Comparer.Equals(authUsername) && Users.Comparer.Equals(authPassword))
            {
                Console.WriteLine("SuccessFully LogedIn");
            }*/
            /*foreach (var i in Users)
            {
                if (Users.Keys.Equals(authUsername) && Users.Values.Equals(authPassword))
                {
                    Console.WriteLine("SuccessFully LogedIn"+i);
                }
                else
                {
                    Console.WriteLine("Enterd wrong username or password");
                    goto repeate;
                }

            }*/

            if (Users.ContainsKey("" + authUsername))
            {

                if (Users.ContainsValue("" + authPassword))
                {
                    Console.WriteLine("SuccessFully LogedIn");

                }
                else
                {
                    Console.WriteLine("Enterd wrong username or password");
                    goto repeate;
                }

            }

            else
            {
                Console.WriteLine("Enterd wrong username or password");
                goto repeate;
            }



        }

        public void Update()
        {
            Console.WriteLine("Enter UserName to Update Your PAssword:");
            string olduserName = Console.ReadLine();

            if (Users.ContainsKey(""+olduserName))
            {
                Console.WriteLine("Enter new Password:");
                string newPassword = Console.ReadLine();
                Users.Remove(olduserName);
                Users.Add(olduserName,newPassword);
                Console.WriteLine("PassWord updated");
                
            }
            else
            {
                Console.WriteLine("Enter right username to update your password!!!");
            }
        }

    }
}
