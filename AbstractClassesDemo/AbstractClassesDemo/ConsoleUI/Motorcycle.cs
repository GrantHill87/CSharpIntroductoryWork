using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI
{
    public class Motorcycle : Vehicle
    {
        public Motorcycle()
        {
            
        }
        public bool HasSideCart { get; set; } = false; //tried to use the override feature here, but it didn't run, I think because it's just improper syntax -- override may only be used for defined methods. HasSideCart is defined as a property here, not as a method.
        public override void DriveAbstract() //overrides the DriveAbstract method crafted in the base class from which this class was derived.
        {
            Console.WriteLine($"This {GetType().Name} is a {GetType().BaseType.Name} that is virtually in drive. Has a side cart? {HasSideCart}."); //GetType is a predefined method, found in one of the systems
            //being implemented up in the top script portion of this class. Apparently, so is BaseType, although BaseType wouldn't necessarily be classified as a method here, and the same for Name.
            //{GetType().Name} is calling for the name of the immediate class, which in this case, is a motorcycle. {GetType().BaseType.Name} is calling for the name of the class for which
            //this derived class, motorcycle, is based from. Was able to get the 'HasSideCart' property printed to the console, without it being derived from the base class, just had to call the property properly.
        }
    }
}
