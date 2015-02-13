using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Variables
            double HSGP; // High School Grade points
            int ATS; // Admission Test Score
            //Codes
            Console.WriteLine("==========================Assignment2 project2=========================");
            Console.WriteLine("College Application ");
            Console.WriteLine("=======================================================");
            Console.Write("\n");
            Console.WriteLine("Insert your High School Grade Point Average:  ");
            HSGP = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Insert your Admission Test Score: ");
            ATS = Convert.ToInt32(Console.ReadLine());
            Console.Write("\n");
            
            if(HSGP >=3.0 && ATS >=60)
            {
                Console.WriteLine("Your Application Has Been Accepted!");
            }
            else if(HSGP <3.0 && ATS >=80)
            {
                Console.WriteLine("Your Application Has Been Accepted!");
            }
            else
            {
                Console.WriteLine("Your Application Has Been Rejected!");
            }
            Console.WriteLine("+++++++++++++++++++++++++++++++++++++++++");
            Console.WriteLine("Press any key to exit ...");
            Console.ReadKey();
        }
    }
}
