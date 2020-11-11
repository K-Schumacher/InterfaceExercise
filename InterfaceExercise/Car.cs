using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Car : IVehicle, ICompany
    {
        public Car()
        {
        }

        public double TrunkSpace { get; set; }
        public bool HasGoodMileage { get; set; } = true;

        //IVehicle
        public double Engine { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        //ICompany
        public string Logo { get; set; }
        public string Slogan { get; set; }
    }
}
