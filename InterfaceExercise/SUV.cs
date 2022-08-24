using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : ICompany , IVehicle
    {
        public int Wheels { get; set; } = 4;
        public int NumberOfSeats { get; set; } = 5;
        public double EngineSize { get; set; } = 4.0;
        public double Length { get; set; } = 191.3;
        public string CompanyName { get; set; } = "Toyota";
        public string Logo { get; set; } = "T in a circle";
        public bool AWD { get; set; } = true;
        public bool FamilyVehicle { get; set; } = true;
    }
}
