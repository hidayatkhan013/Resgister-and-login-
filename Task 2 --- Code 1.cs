using System;

namespace Task2
{
    class Program
    {
        private static string[] accounts = new string[50];  //array to store id
        private static string[] passwords = new string[50]; //array to store passwords
        private static int accountsSaved = 0;   //counter
        static string Menu()
        {
            //Displaying menu
            Console.WriteLine("\n\n\t\t\tLogin Applicaiton");
            Console.WriteLine("a. Login");
            Console.WriteLine("b. Register");
            Console.Write("Select: ");
            return Console.ReadLine();  //returns option selected by user
        }
        static void Main(string[] args)
        {
            string option = Menu(); 
            if (option == "a")  //if user selects Login
            {
                //Take id pass from user 
                Console.Write("Enter Account: ");
                string acc = Console.ReadLine();
                Console.Write("Enter Password: ");
                string pass = Console.ReadLine();
                int flag = 0;
                //check if id pass exists in array
                for (int i = 0; i < 50; i++)
                {
                    if (accounts[i] == acc && passwords[i] == pass)
                    {
                        flag = 1;
                        Console.WriteLine("Account Logged in Successfully");
                        break;
                    }
                }
                if(flag == 0)   //if it doesnot exists display message
                {
                    Console.WriteLine("Wrong Account or Password");
                }
            }
            else if (option == "b") //if user wants to register
            {
                //Ask user to provide login information
                Console.WriteLine("Create An Account");
                Console.Write("Enter Account: ");
                string acc = Console.ReadLine();
                Console.Write("Enter Password: ");
                string pass = Console.ReadLine();
                //Save it in array
                accounts[accountsSaved] = acc;
                passwords[accountsSaved++] = pass;
                Console.WriteLine("Account Created");
                string[] temp = { };
                Main(temp);
            }
            else    //if selected option doesnot match any
            {
                Console.WriteLine("Enter a Valid Option");
            }
        }
    }
}
