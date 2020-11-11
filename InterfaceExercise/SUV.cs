using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    class SUV : IVehicle, ICompany
    {
        public SUV()
        {
        }


        public bool HasHatchback { get; set; }
        public bool HasThirdRowSeating { get; set; }

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
