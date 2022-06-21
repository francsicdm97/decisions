using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisions
{
    public class Exercise
    {   
        public void NestedCheck(int number)
        {

            if (number % 3 == 0)
            {
                Console.WriteLine("Divisible by 3");
            }
            else if (number % 7 == 0)
            {
                Console.WriteLine("Divisible by 7");
            }
            else if (number % 2 == 0)
            {
                Console.WriteLine("The number is even");
            }
            else
            { 
                Console.WriteLine("The number is odd");
            }
        }

        String userName;
        String password;

        public void register()
        {
            Console.Write("Please enter your username: ");
            userName = Console.ReadLine();
            Console.Write("Please enter your password: ");
            password = Console.ReadLine();
            Console.WriteLine("Registration completed");
            Console.WriteLine("---------------------------");

        }

        public void signIn()
        {
            Console.Write("Please enter your username: ");
            if (userName == Console.ReadLine())
            {
                Console.Write("Please enter your password: ");
                if (password == Console.ReadLine())
                {
                    Console.WriteLine("Welcome! Sign in successfully complete!");
                }
                else
                {
                    Console.WriteLine("Sign in failed. Incorrect password");    
                }
            }
            else
            {
                Console.WriteLine("You are not a user");    
            }


            


            
            password = Console.ReadLine();
        }
    }
}
