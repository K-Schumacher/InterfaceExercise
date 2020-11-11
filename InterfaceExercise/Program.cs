using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            // -- DONE -- Create 2 Interfaces called IVehicle & ICompany

            // -- DONE -- Create 3 classes called Car , Truck , & SUV

            // -- DONE -- In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            // -- DONE -- In ICompany

            /* -- DONE -- Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /* -- DONE -- Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var GT500 = new Car()
            {
                TrunkSpace = 13.5,
                HasGoodMileage = false,

                Engine = 5.2,
                Make = "Shelby",
                Model = "GT500 Mustang",
                Year = 2020,

                Logo = "Cobra",
                Slogan = "None"
            };

            var shelby = new Truck()
            {
                BedSize = 5.5,
                HasLeafSprings = true,

                Engine = 5.0,
                Make = "Shelby",
                Model = "F-150",
                Year = 2020,

                Logo = "Cobra",
                Slogan = "None"
            };

            var trackhawk = new SUV()
            {
                HasHatchback = true,
                HasThirdRowSeating = false,

                Engine = 6.2,
                Make = "Jeep",
                Model = "Grand Cherokee TrackHawk",
                Year = 2020,

                Logo = "Jeep",
                Slogan = "Go Anywhere, Do Anything"
            };

            var cars = new List<IVehicle>() { GT500, shelby, trackhawk };
            


            foreach (var car in cars)
            {
                Console.WriteLine($"Year: {car.Year}");
                Console.WriteLine($"Make: {car.Make}");
                Console.WriteLine($"Model: {car.Model}");
                Console.WriteLine($"Supercharged {car.Engine}l engine");
                

                if (car == shelby)
                {
                    Console.WriteLine($"Bed Size: {shelby.BedSize}'.");
                    Console.WriteLine($"Leaf Springs: {shelby.HasLeafSprings}");
                    Console.WriteLine($"Logo: {shelby.Logo}");
                    Console.WriteLine($"Slogan: {shelby.Slogan}");
                }
                if (car == GT500)
                {
                    Console.WriteLine($"Trunk Space: {GT500.TrunkSpace} cubic feet.");
                    Console.WriteLine($"Good on gas: {GT500.HasGoodMileage}");
                    Console.WriteLine($"Logo: {GT500.Logo}");
                    Console.WriteLine($"Slogan: {GT500.Slogan}");

                }
                if (car == trackhawk)
                {
                    Console.WriteLine($"Hatchback Available: {trackhawk.HasHatchback}");
                    Console.WriteLine($"Third Row Seating Available: {trackhawk.HasThirdRowSeating}");
                    Console.WriteLine($"Logo: {trackhawk.Logo}");
                    Console.WriteLine($"Slogan: {trackhawk.Slogan}");
                }

                Console.WriteLine("----------------------");
            }
           
           
                

        }

       
    }
}
