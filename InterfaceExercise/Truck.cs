using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class Truck : IVehicle, ICompany
    {
        public Truck()
        {
        }


        public double BedSize { get; set; }
        public bool HasLeafSprings { get; set; }

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
