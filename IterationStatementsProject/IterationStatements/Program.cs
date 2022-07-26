using System;
using System.Collections.Generic;

namespace IterationStatements
{
    class Program
    {
        static void Main(string[] args)
        {
                //TODO - Read each comment and complete its instruction
                // like the example below

                //Create a List called "numbers" - DONE!
                var numbers = new List<int>();
            
            //-----START HERE------------------------------------------
            //Create a variable of type int and name it num
            //initialize the variable with a value of 0
            var specNum = 0;



            // Create a do-while loop and use the template below:
            do
            {
                specNum++;
                numbers.Add(specNum);

            } while (specNum < 100 );


            while (specNum < 200)
            {
                specNum++;
                numbers.Add(specNum);

            }
            Console.WriteLine("Iteration Statements Project.");
            Console.WriteLine("");

            // This is to show the user that the numbers will start increasing on the console
            Console.WriteLine("Increase:");


            // Create a foreach loop using the collection - numbers
                //In the scope of the foreach loop, print each number in numbers

            foreach(var specItem in numbers)
            {
                Console.WriteLine(specItem);
            }
             


            Console.WriteLine("");
            Console.WriteLine("Decrease:");


            // Create a for loop - this will print the numbers in reverse order - from 200 to 1
                // in your initializer set the value of i to 199
                // in your conditional, as long as i is less than or equal to the amount of items in "numbers" - use (numbers.Count)
                // AND as long as i is greater than or equal to 0
                // Decrement i by 1

            //start for loop here
            for(int i = 199; i >= 0; i--)
            {
                // place numbers[i] inside of the Console.WriteLine() method
                Console.WriteLine($"{numbers[i]}");
            }

            //------------End of exercise
        }
    }
}
