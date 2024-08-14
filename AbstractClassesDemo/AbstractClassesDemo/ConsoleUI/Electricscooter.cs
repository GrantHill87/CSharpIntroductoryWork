using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Electricscooter : Vehicle //remeber an abstract class is really just a template for how other classes should behave (its derived classes).
    {
        public Electricscooter()
        {

        }
        public bool HasManualBrakes { get; set; } = false; //I feel like the base class, vehicle, acts like an interfaced class, even though it's an abstract class, because it forces its derived classes to conform to it, even
        // if they have added properties. Trying to get those added properties, defined in the derivative classes, printed to the console is a mystery. Nevermind, figured out a way to do it! refer to motorcycle and this class, below.
        public override void DriveAbstract() //couldn't find a way to have this method not overridden. Weird. Same for DriveVirtual, which actually has a scope already made. Lol, just found out DriveVirtual is an optional method to be called in derived classes from the base class that created it.
        {
            Console.WriteLine();
            Console.WriteLine($"{GetType().BaseType.Name}s are manufactured on such a wide spectrum these days; take for instance, this {GetType().Name}.");
            Console.WriteLine($"The {GetType().Name} has manual brakes? {HasManualBrakes}"); //tried to have it print to the console from here too, but wasn't able to assign or initialize a variable.
        } //properties actually can be expressed in the curly brackets by themselves, if they're defined properly, and consequently don't require to be called by a method, as I had originally thought. I totally forgot.

    }
}