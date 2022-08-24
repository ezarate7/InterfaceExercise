using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
    
        public  int Wheels { get; set; }
        public int NumberOfSeats { get; set; }
        public double EngineSize { get; set; }
        public double Length { get; set; }

    }


}   

