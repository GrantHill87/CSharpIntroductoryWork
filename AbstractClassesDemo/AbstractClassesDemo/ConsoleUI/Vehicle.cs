using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleUI //if an abstract class contains an incomplete method; there's no means of being able call the method, is there? Because the method doesn't have a definition of what it does, we cannot
{ //make an instance of this class and call this method. This yields a strong notion of what an interface essentially is; incomplete, an incomplete behavior.
    //you wouldn't be able to write; Vehicle newVehicle = new Vehicle();.
    public abstract class Vehicle //a very important feature I learned recently about abstract classes, and interfaces, is that they lack something; they lack scope. what do they have instead? Behaviors.
    { //this expalins why we cannot call upon an abstract class or an interface directly; instead, we must create derived classes of them, which consequently implement their behaviors. They have incomplete methods, and properties.
        public string Make { get; set; } = "default make."; //so, I just noticed that "default make" is merely a string that gets passed into the main script of the program class, but only if no other string has been specified for this property.
        public string Model { get; set; } = "default model."; //it doesn't necessarily matter what's written here, it's just a default string that will be passed in case no other string are defined in the derived classes of this base class, or the main script.
        public int Year { get; set; } = 1; //if you don't specify what the 'year' of the object crafted from the vehicle class is, it will default to whatever value is specified in the base class.
        public decimal Mileage { get; set; } = 2; //the same goes for the 'mileage' property here, for the same reason. This will happen because we haven't yet specified anything different
        // in the derived classes, car, and motorcyle, nor when we actually call all of these in the program class (main script). You can put whatever decimal or integer you want here, it doesn't matter.
        // get and set literally act as the 'read' and 'write' functions of these properties. Get will store the input into the 'Mileage' property. Set will 'write' it out to the console, when expressed in the scope (for example, looking at what's invoked in the main script).
        public bool HasTrunk { get; set; } = true; //if we leave this boolean based property without the equals sign, it still will run, but it will default to 'false', whenever it is called.
        public abstract void DriveAbstract(); //stubbed out method. Has no implementation. Why? because that's the nature of the script when writing 'behaviors' for abstract classes. You can create methods
        //in them, that have no scope, and are essentially stubbed out methods -- they haven't yet been defined; they don't know what to do because you haven't given them instruction, no scope.
        public virtual void DriveVirtual() //method has a void expressed for its return, because it doesn't need to expect a return, in its scope.
        { //something else I discovered about abstrract methods; if we write a 'virtual' method within the abstract class; it's considered to be an optional method -- derived classes aren't forced to implement it. This is something interfaces cannot do.
            Console.WriteLine($"This {GetType().Name} is virtually in drive."); //not sure where 'Name' comes from, doesn't appear to have been defined in any of the classes.
            //nevermind, figured it out -- this DriveVirtual method never actually gets called, by the main script, written in the program class. This is because both the car, and motorcycle
            //classes override this method. We'll make a new class that attempts not override this method, but implements it.
            //we also get a 'naming rule violation' if we don't capitalize the first letter of each property in a class.
        }
    }
}
