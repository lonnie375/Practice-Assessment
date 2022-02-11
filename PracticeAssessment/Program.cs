using System;

namespace PracticeAssessment
{
    class Program
    {
        //This is your main code 
        static void Main(string[] args)
        {
            var test1= IsTheSame(5, 5);
            Console.WriteLine(test1);
            var test2 = Subtract(10.10, 20.20);
            Console.WriteLine(test2);
            var test3 = FindBuildingType(32);
            Console.WriteLine(test3);
        }

        //Create a method that returns a bool and takes in two numbers as parameters
        public static bool IsTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else if (num1 != num2)
            {
                return false;
            }
            else
            {
                return false;
            }

            
        }
        //Create a method that subtracts 2 parameters that are doubles
        public static double Subtract(double num1, double num2)
        {
            return num2 - num1; 
        }

        //Create a method named FindBuildingType that takes in a int as a parameter
        public static string FindBuildingType(int num)
        {
            if (num >= 4 && num <= 10)
            {
                return "This is an office building!"; 
            }
            else if (num > 50)
            {
                return "This is a SUPER skyscraper!"; 
            }
            else if (num >= 11 && num <= 49)
            {
                return "This is a skyscraper!"; 
            }
            else if (num < 3)
            {
                return "This is a house!"; 
            }
            else
            {
                return "Love is in the air!"; 
            }
            

            
        }
        
    }
}
