using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Car : IVehicle , ICompany
    {
        public Car()
        {
        }
        public int Wheels { get; set; } = 4;
        public int NumberOfSeats { get; set; } = 4;
        public double EngineSize { get; set; } = 2.5;
        public double Length { get; set; } = 190.2;
        public string CompanyName { get; set; } = "KIA";
        public string Logo { get; set; } = "KIA";
        public string CargoType { get; set; } = "Trunk";
        public string SportEdition { get; set; } = "4 Cylinder turborcharged, 300HP";
    }





}
