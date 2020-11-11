using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    interface IVehicle
    {
        public double Engine { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year{ get; set; }

    }
}
