using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {

           

            var FourRunner = new SUV() { AWD = true, FamilyVehicle = true};          
            var FOneFifty = new Truck() { BedSize = 8, FourByFour = true};
            var stinger = new Car() { CargoType = "trunk", SportEdition = "turbo charged" };

            Console.WriteLine($"Number of Wheels= {FourRunner.Wheels}\n" +
                $"Number of Seats= {FourRunner.NumberOfSeats}\n" +
                $"Engine size= {FourRunner.EngineSize} litre \n" +
                $"Length= {FourRunner.Length} inches \n" +
                $"Company Name= {FourRunner.CompanyName} \n" +
                $"Logo= {FourRunner.Logo} \n" +
                $"AWD= {FourRunner.AWD} \n" +
                $"Family Vehicle= {FourRunner.FamilyVehicle} \n");
            
            Console.WriteLine($"Number of Wheels= {FOneFifty.Wheels}\n" +
                $"Number of Seats= {FOneFifty.NumberOfSeats}\n" +
                $"Engine size= {FOneFifty.EngineSize} litre \n" +
                $"Length= {FOneFifty.Length} inches \n" +
                $"Company Name= {FOneFifty.CompanyName} \n" +
                $"Logo= {FOneFifty.Logo} \n" +
                $"Bed Size= {FOneFifty.BedSize} ft \n" +
                $"4x4= {FOneFifty.FourByFour} \n");

            Console.WriteLine($"Number of Wheels= {stinger.Wheels}\n" +
                $"Number of Seats= {stinger.NumberOfSeats}\n" +
                $"Engine size= {stinger.EngineSize} litre \n" +
                $"Length= {stinger.Length} inches \n" +
                $"Company Name= {stinger.CompanyName} \n" +
                $"Logo= {stinger.Logo} \n" +
                $"Cargo type= {stinger.CargoType}\n" +
                $"Sports Edition= {stinger.SportEdition} \n");
            Console.WriteLine();
            
            List<IVehicle> vehicles = new List<IVehicle>();
            vehicles.Add(FourRunner);
            vehicles.Add(FOneFifty);
            vehicles.Add(stinger);

            foreach (var v in vehicles)
            {
                Console.WriteLine(
                    $"Engine Size: {v.EngineSize}\n" +
                    $"Number of Seats: {v.NumberOfSeats}\n" +
                    $"length: {v.Length}\n" +
                    $"Wheels: {v.Wheels}");
                Console.WriteLine();
            }

          
            
        }
    }
}
