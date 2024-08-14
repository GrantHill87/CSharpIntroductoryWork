using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo follow all comments!! 
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */

            // Create a list of Vehicle called vehicles
            var vehicles = new List<Vehicle>(); //this line of code simply states that our new list will be called 'vehicles' and its list will consist of objects defined by the base class we named, 'Vehicle'.
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * - new it up as one of each derived class
             * Set the properties with object initializer syntax
             */
            Vehicle E500 = new Electricscooter() { HasTrunk = false, Make = "Unagi"}; //properties Model, Year, and Mileage all revert to the default values expressed in vehicle for this one.
            var focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2013, Mileage = 1200.22m, }; //HasTrunk never gets printed to the console, because it isn't expressed in the Vehicle
            var motorcycle = new Motorcycle() { HasSideCart = true, Make = "Harley Davidson", Model = "Chopper", Year = 1985 };//class as a property. The same goes for 'HasSideCart'.
            Vehicle hatchback = new Car() { HasTrunk = true, Make = "Honda", Model = "HRV", Year = 2021 };//Tried making 'HasTrunk' printable to the console, by writing it into the scope of
            Vehicle sportutilityvehicle = new Car() { HasTrunk = true, Make = "Hummer", Model = "H3", Year = 2012 };//the Vehicle class, so that it could be implemented into the 'foreach'
            /* //function, but it didn't work. Perhaps because when trying to express 'HasTrunk' as a boolean property within the class, the '{get; set;}' aspect doesn't register for a boolean
             * Add the 4 vehicles to the list //property. I was able to write it out as a bool property within the Vehicle class, but could only set it to true false -- not as a variable
             * Using a foreach loop iterate over each of the properties //which could be used to store information of newly constructed objects (such as the vehicles down below).
             */
            vehicles.Add(focus);
            vehicles.Add(E500);
            vehicles.Add(motorcycle);
            vehicles.Add(sportutilityvehicle);
            vehicles.Add(hatchback); //these will all print to the console in the order for which they are written here; the chronological order for which they are being added to the vehicles list up above.
            //despite being instantiated in a different order, or being crafted as objects.
            foreach (var vehicle in vehicles)
            {
                if (vehicle is Motorcycle)
                {
                    var m = (Motorcycle)vehicle; //this was an attempt to have the motorcycle class print its 'HasSideCar' feature to the console, but remains unfinished -- found another way to do it.

                }
                Console.WriteLine($"Make {vehicle.Make}. Model {vehicle.Model}. Year {vehicle.Year}. Mileage is estimated at around {vehicle.Mileage} miles currently. Does it have a trunk? {vehicle.HasTrunk}.");
                Console.WriteLine(); //the 'HasSideCart' property for the motorcycle was able to print ot the console without it being called for by being added to the 'vehicle' list -- efficient way to 
                vehicle.DriveAbstract(); //display specific derived class only type properties to the console. The applies to the 'HasManualBrake' from the Electricscooter class. Otherwise, I was debating having to
                Console.WriteLine(); //create newly defined lists, in addiiton to the 'vehicles' list, that would only contain those derived classes in them, and making another 'foreach' function, which would be super inefficient here.
            } //mileage defaults to whatever was written in for the base class, as it wasn't specified for all derived classes.
            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}
