using System;

namespace Task_2
{
    class Program   //Task 2 --- Sample 2
    {
        private static string[] Ids;
        private static string[] Passes;
        private static int size;
        static bool Login(string id, string pass)   //Function to check if user exists
        {
            int itr = 0;    //iterator
            while (itr < 50)    //while loop
            {
                if (id == Ids[itr] && pass == Passes[itr])  //match id and pass
                {
                    return true;    //return true if matches
                }
                itr++;
            }
            return false;   //return false if none matches
        }
        static void Signup(string id, string pass)  //create new user
        {
            //save id and pass in array
            Ids[size] = id;
            Passes[size] = pass;
            size++;
        }
        static void Main(string[] args)
        {
            Ids = new string[50];
            Passes = new string[50];
            size = 0;
            //Create Menu and display until user wants to exit
            while (true)
            {
                Console.WriteLine("Enter 1 to Login");
                Console.WriteLine("Enter 2 to Register");
                Console.WriteLine("Enter 3 to Exit");
                string input = Console.ReadLine();
                if (input == "1")   // if user wants to login
                {
                    //take input id and password
                    Console.WriteLine("Enter Account: ");
                    string id = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string pass = Console.ReadLine();
                    if (Login(id, pass))    //check if user exists
                    {
                        Console.WriteLine("Login Success");
                    }
                    else
                    {
                        Console.WriteLine("Login Failed");
                    }
                }
                else if (input == "2")  //if user wants to signup
                {
                    //take information
                    Console.WriteLine("Enter Account: ");
                    string id = Console.ReadLine();
                    Console.WriteLine("Enter Password: ");
                    string pass = Console.ReadLine();
                    //save in array
                    Signup(id, pass);
                    Console.WriteLine("Account Created");
                }
                else if (input == "3")  //if user wants to exit
                {
                    break;
                }
                else //if user selects invalid options
                {
                    Console.WriteLine("Invalid Option");
                    Console.WriteLine();
                    Console.WriteLine();
                }
            }
        }
    }
}
