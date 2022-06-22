using System;

namespace decisions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //create an object of my class
            //an instance of Human

            {
                Human denis = new Human("Denis", "Panjuta", "green", 29);
                denis.IntroduceMyself();

                Human amalia = new Human("Amalia", "Panjuta", "blue");
                amalia.IntroduceMyself();

                Human basicHuman = new Human();
                basicHuman.IntroduceMyself();

                Human natalie = new Human("Natalie");
                natalie.IntroduceMyself();

                Human michael = new Human("Michael", "Miller");
                michael.IntroduceMyself();

                Human frank = new Human("Frank", "Walter", 25);
                frank.IntroduceMyself();

                Console.ReadKey();
            }
        }
    }
}
