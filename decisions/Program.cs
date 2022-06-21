using System;

namespace decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            Exercise exercise = new Exercise();
            exercise.register();
            exercise.signIn();

            Console.ReadKey();
        }
    }
}
