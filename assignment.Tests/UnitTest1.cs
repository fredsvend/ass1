using System;
using Xunit;
using System.IO;


namespace assignment.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Divisible_By_Four_Leap_Year()
        {   
                var number = 40;
                var program = new Program();

                bool actual = program.IsLeapYear(number);

                Assert.Equal(true, actual);
        }

        [Fact]
        public void Divisible_By_FourHundred_Leap_Year()
        {   
                var number = 800;
                var program = new Program();

                bool actual = program.IsLeapYear(number);

                Assert.Equal(true, actual);
        }

        [Fact]
        public void Not_Divisible_By_100_Leap_Year()
        {   
                var number = 1000;
                var program = new Program();

                bool actual = program.IsLeapYear(number);

                Assert.Equal(false, actual);
        }

        [Fact]  
        public void Input_LeapYear()
        {
                
        
        }

        [Fact]  
        public void Input_NotLeapYear()
        {
            
        }

      /*  [Fact] 
        [ExpectedException(typeof(FormatException))]
        public void Input_NotInteger()
        {

            var junk = "sk";
            var program = new Program();
            program.IsLeapYear(junk);


        }
*/

    }
}
