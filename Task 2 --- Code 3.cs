using System;

namespace Task_2
{
    class Account   //Class to store Accounts
    {
        //auto implemented properties
        public string Identity { get; set; }
        public string Password { get; set; }
    }
    class Program   //Task 2 --- Code 1
    {
        private const string stars = "************************";

        static void Main(string[] args)
        {
            Account[] accounts = new Account[10]; //Store Accounts in array of Account
            for (int i = 0; i < accounts.Length; i++)
            {
                accounts[i] = new Account();
            }
            accounts[0].Identity = "account";   //1 hardcoded sample account
            accounts[0].Password = "12345";
            int storedAccounts = 1;
            string opt = String.Empty;
            do
            {
                //Displaying Menu
                Console.WriteLine("{0,50} Welcome {0}", stars);
                Console.WriteLine("1. Register");
                Console.WriteLine("2. Login");
                Console.WriteLine("3. Exit");
                Console.Write("Choice: ");
                opt = Console.ReadLine();   //Read Choice from user
                Console.WriteLine();
                Console.WriteLine();
                if (opt == "1") //if user wants to register
                {
                    //Ask user to enter id and password
                    Console.WriteLine("Register An Account");
                    Console.WriteLine("Create Credentials");
                    Console.Write("Identity: ");
                    string id = Console.ReadLine();
                    Console.Write("Password: ");
                    string pass = Console.ReadLine();
                    //Save Credentials
                    accounts[storedAccounts].Identity = id;
                    accounts[storedAccounts].Password = pass;
                    Console.WriteLine("Account Created Successfully");
                }
                else if (opt == "2")    //if user wants to login
                {
                    //Ask user for Credentials
                    Console.WriteLine("Enter Your Credentials");
                    Console.Write("Identity: ");
                    string id = Console.ReadLine();
                    Console.Write("Password: ");
                    string pass = Console.ReadLine();
                    bool found = false;
                    //Check if any id pass match entered Credentials
                    foreach (Account temp in accounts)
                    {
                        if (temp.Identity == id && temp.Password == pass)
                        {
                            found = true;
                            Console.WriteLine("Login Successful!");
                            Console.WriteLine("Going Back to Menu...");
                            break;
                        }
                    }
                    if (!found) //if no Credentials match the given display message
                    {
                        Console.WriteLine("Wrong Credentials!");
                        Console.WriteLine("Going Back to Menu...");
                    }
                }
                else if (opt == "3")    //if user wants to exit
                {
                    Console.WriteLine("Exiting...");
                }
                else    //if choice doesnot match any option
                {
                    Console.WriteLine("Enter a Valid Option");
                }
            } while (opt != "3");
        }
    }
}
