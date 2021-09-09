using System;

namespace assignment
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine("Enter number");
            string input = Console.ReadLine();
            
            int year = Convert.ToInt32(input);

            if(program.IsLeapYear(year)){
                Console.WriteLine("yay");
            }else{
                Console.WriteLine("nay");
            }


            }

       public bool IsLeapYear(int year){
           // If a year is multiple of 400,
        // then it is a leap year
        if (year % 400 == 0)
            return true;
     
        // Else If a year is multiple of 100,
        // then it is not a leap year
        if (year % 100 == 0)
            return false;
     
        // Else If a year is multiple of 4,
        // then it is a leap year
        if (year % 4 == 0)
            return true;
        return false;
           
        }
    }
}
