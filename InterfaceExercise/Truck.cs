using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class Truck : IVehicle , ICompany
    {
        public int Wheels { get; set; } = 4;
        public int NumberOfSeats { get; set; } = 5;
        public double EngineSize { get; set; } = 3.3;
        public double Length { get; set; } = 250.3;
        public string CompanyName { get; set; } = "Ford";
        public string Logo { get; set; } = "Ford";
        public double BedSize { get; set; } = 8.0;
        public bool FourByFour { get; set; } = true;


    }
}
