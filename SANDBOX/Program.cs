using System;

namespace SANDBOX
{
    class Program
    {
        static void Main(string[] args)
        {
            //I really tried my best on this lab but I honestly have no idea what I'm doing.
            // I did reach out for help and the concepts are still not clicking.
            //It is my hopes that this weekend I am able to teach myself the concepts reviwed this week as I have not grasped the concets introduced begginning on Tuesday.
            // I am submitting two unfinished programs for this lab.
            
            Console.WriteLine("Hello User : )");

            string[] passWords = {GetInput()};

            string[] userNames = { "Calyn0123, Baylee1203" };


            foreach (string passWord in passWords)
            {
                bool checkValid = ValidatePassword(passWord);
                Console.WriteLine("'{0}' is{1} a valid password", passWord, checkValid ? "" : "n't");
            }
            Console.ReadKey();
        }
        static bool ValidatePassword(string passWord)
        {
            int passwordValidCounter = 0;
            foreach (char characters in passWord)
            {
                if (characters>= 'a' && characters <= 'z')
                {
                    passwordValidCounter++;
                    break;
                }
                else
                {
                    Console.WriteLine("This password does not meet lowecase requirements");
                    break;
                }
            }
            foreach (char characters in passWord)
            {
                if (characters >= 'A' && characters <= 'Z')
                {
                    passwordValidCounter++;
                    break;
                }
                else
                {
                    Console.WriteLine("This password does not meet uppercase requirements");
                    break;
                }
            }
            if (passwordValidCounter == 0) return false;
            foreach (char characters in passWord)
            {
                if (characters >= 7 && characters <= 12)
                {
                    passwordValidCounter++;
                    break;
                }
                else
                {
                    Console.WriteLine("This password does not meet length requirements");
                    break;
                }
            }
            if (passwordValidCounter == 1) return false;
            if (passwordValidCounter == 2)
            {
                char[] special = { '@', '#', '$', '%', '^', '&', '!', '*' }; 
                if (passWord.IndexOfAny(special) == -1) return false;
            }
            else
            {

                Console.WriteLine("This password does not contain special characters");
                

            }
            return true;
        }

        public static string GetInput()
        {
            Console.WriteLine("Lets create a password.");
            Console.Write("The password must contain: \no At least one lowercase letter\no At least one uppercase letter\no At least one number\no A minimun of 7 characters\no A maximum of 12 characters\no Can include any of the following special characters(! @ # $ % ^ & *): ");
            string password = Console.ReadLine();

            return password;
        }
    }
}
