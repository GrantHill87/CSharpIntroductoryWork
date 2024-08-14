using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Car : Vehicle //car is the derived class, and vehicle is the base class.
    {
        public Car() //for perspective; the primary difference between an abstract class and an interface is how tightly or loosely 'coupled' their functionalities are. For instance, with a an abstract
        { //class, changing something within an already established script may very likely require you to make the same changes elsewhere in other parts of the script, or else it won't run.
          //if we take this same context towards an interface, we learn that its scritping is more 'loosely' coupled as it doesn't necessarily care what you do with its script (behavior), as long as it gets implemented.
        }
        public bool HasTrunk { get; set; } = false; //this never printed to the console as intended, when called in the main script (program.cs). It also doesn't override the same
        // property from the base class. Ah, I found ou ththis is because like the other two derived classes I created from the base abstract class, you must print the 'HasTrunk' property to the console
        //within the scope of the method, from within the derived class itself -- not in the main script that's using a 'froeach' function to print the properties of each class to the console, and that's also because
        //those properties are ones strictly specified in the abstract class only, not any additional ones created in the derived classes, so it would make sense that printing those added properties of these derived classes
        //to the console from within the scope of the class itself would work, because the 'DriveAbstract' method is going to run anyway, so just tell it what you want it to do, especially whilst you have the property of the derived class defined in the same scope.
        public override void DriveAbstract() //why do we have to override stubbed out methods from abstract classes? Lecture suggested this was a requirement, but didn't specify why.
        {
            Console.WriteLine("This car is in drive."); //this script doesn't call for a method to be used to assist with the written description of the car being in drive (no $ sign).
        }
    }
}
