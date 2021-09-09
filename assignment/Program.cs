using System;

namespace assignment
{
    public class Program
    {
       public static void Main(string[] args)
        {
            var program = new Program();
            Console.WriteLine("Enter a number followed by a press of the button 'Enter' on your keyboard");
            try{
                
            string input = Console.ReadLine();
            
            int year = Convert.ToInt32(input);

            if(year>1581){
            if(program.IsLeapYear(year)){
                Console.WriteLine("yay");
            }else{
                Console.WriteLine("nay");
            }
            }else{
                Console.WriteLine("Year has to be more recent than 1581.");
                }
            }
            
            catch(FormatException E){
                
                Console.WriteLine("Hey there! Uhm.. this is to check for Leap Years! Hint - Only write a year (which consists of numbers)");
            }

            

        }

       public bool IsLeapYear(int year){
        if (year % 400 == 0)
            return true;
    
        if (year % 100 == 0)
            return false;
     
        if (year % 4 == 0)
            return true;

            return false;
        }
    }
}
