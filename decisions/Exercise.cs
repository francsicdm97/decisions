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

        public void registerAndSignIn()
        {
            String userName;
            String password;

            register();
            signIn();

            void register()
            {
                Console.Write("Please enter your username: ");
                userName = Console.ReadLine();
                Console.Write("Please enter your password: ");
                password = Console.ReadLine();
                Console.WriteLine("Registration completed");
                Console.WriteLine("---------------------------");

            }

            void signIn()
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

        public void switchExercise(string username)
        {
            switch (username)
            {
                case "Denis":
                    Console.WriteLine("Hi Denis");
                    break;
                case "Frank":
                    Console.WriteLine("Hi Frank");
                    break;
                default:
                    Console.WriteLine("username unknow");
                    break;
            }
        }

        
        public static void highScoreTracker(string playerName, int score)
        {
            int highScore = 500;
            string highScorePlayer = "Dave";

            if (score > highScore)
            {
                highScore = score;
                highScorePlayer = playerName;
                Console.WriteLine("New high score of: " + highScore);
                Console.Write("New highscore holder is " + playerName);
            }
            else
            { 
                Console.WriteLine("The old highscore of " + highScore + " could not be broken and is still held by " + highScorePlayer);
            }
        }
    }
}


