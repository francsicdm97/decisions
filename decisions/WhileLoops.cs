using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace decisions
{
    internal class WhileLoops
    {
        public static void Counter()
        {   

            //get user number to count
            Console.Write("Enter a number to count: ");
            string input = Console.ReadLine();

            int number;
           

            //check if number is entered
            if (Int32.TryParse(input, out number))
            {   
                //true, start for loop and count to number
                Console.WriteLine("The number to count is: " + number);
               
                //for loop starts from 1 not 0
                for (int x = 1; x < number + 1; x++)
                {
                    
                    Console.WriteLine(x);
                }
                
            }
            //false, show error message
            else
            {
                Console.WriteLine("Enter a correct temperature");
            }
            Console.WriteLine("Counting finsihed");
        }

        public static void OddNumbercounter()
        {

            //get user number to count
            Console.Write("Enter a number to count: ");
            string input = Console.ReadLine();

            int number;


            //check if number is entered
            if (Int32.TryParse(input, out number))
            {
                //true, start for loop and count to number
                Console.WriteLine("The number to count is: " + number);

                //for loop starts from 1 not 0
                for (int x = 1; x < number + 1; x++)
                {
                    if (x % 2 != 0)
                    {
                        Console.WriteLine(x + " is and odd number");
                    }

                }

            }
            //false, show error message
            else
            {
                Console.WriteLine("Enter a correct temperature");
            }
            Console.WriteLine("Counting finsihed");
        }

        public static void DoLoop()
        {
            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter++;

            } while (counter < 5);
        }

        public static void WhileLoop()
        {
            int counter = 0;
            while (counter < 10)
            {
                Console.ReadKey();
                Console.WriteLine(counter);
                counter++;
            }
        
        }

        public static void exercise()
        {
            Console.WriteLine("Start");
            for (int i = -3; i < 4; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Finish");

            Console.WriteLine("Start");
            int x = 3;
            while (x > -4)
            {
                Console.WriteLine(x);
                x--;
            }
            Console.WriteLine("Finish");
        }

        public static void BreakLoop()
        {
            for (int i = 0; i < 10; i++)
            { 
                
                if (i %2==0)
                {
                    Console.WriteLine("We skip an even number");
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public static void AverageScore()
        {
            double totalScore = 0;
            int totalExams = 0;

            do
            {
                //get user number to count
                Console.Write("Enter exam score: ");
                string examScore = Console.ReadLine();

                double examScoreInt;
                


                //check if number is entered
                if (double.TryParse(examScore, out examScoreInt))
                {   //check if exit value is entered
                    if (examScoreInt == -1)
                    {
                        double result = totalScore / totalExams;
                        Console.WriteLine("Average score was " + result);
                        break;
                    }
                    //check if score out side of range
                    else if (examScoreInt < -1 || examScoreInt > 21)
                    {
                        Console.WriteLine("Exam score out of range");
                    }
                    else
                    {
                        totalExams++;
                        totalScore += examScoreInt;
                        Console.WriteLine("Exam score recored successfully, total exams recorded " + totalExams);
                    }
                }

                //false, show error message
                else
                {
                    Console.WriteLine("Enter a correct score");
                }
            
            } while(true);

           
            Console.WriteLine("Exam program finished");
        }
    }

    }




