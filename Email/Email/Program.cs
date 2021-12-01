using System;
namespace Email
{
    class Program
    {
        static void Main(string[] args)
        {
            string login = "cavid@code.edu.az";
            string password = "12345";
            if (login == "cavid@code.edu.az" && password == "12345")
            {
                Console.WriteLine("Signed in succesfully.");
            }
            else
            {
                Console.WriteLine("Login or password is wrong.");
            }        
        }
    }
}