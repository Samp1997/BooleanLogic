using System;

namespace BooleanLogic
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your age?");
            int person1Age = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Have you ever had a DUI?");
            bool DUIq1 = false;
            
            Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            int person1St = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("Qualified?");
            

            int age = 18;
            int Q1pass = person1Age;

            bool canDrive = (person1Age >= 16);
            Console.WriteLine(canDrive);


















































            //Console.WriteLine(true && false);
            //Console.WriteLine(true && true);
            //Console.WriteLine(false && false);


            //Console.WriteLine(true || true);
            //Console.WriteLine(true || false);
            //Console.WriteLine(false || false);


            //Console.WriteLine(true == true);
            //Console.WriteLine(true == false);
            //Console.WriteLine(false == false);

            //Console.WriteLine(true != true);
            //Console.WriteLine(true != false);
            //Console.WriteLine(false != false);

            //Console.WriteLine(true ^ true);
            //Console.WriteLine(true ^ false);
            //Console.WriteLine(false ^ false);

            //Console.ReadLine();




        }
    }
}
