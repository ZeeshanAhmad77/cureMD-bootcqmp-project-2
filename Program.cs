using System;

namespace CarParkingCalculator
{
    class Program
    {   
        static void Main(string[] args)
        {

            Console.WriteLine("------Enter the parking hour------");
            Double hourParked = Convert.ToDouble( Console.ReadLine().Trim());
            Console.WriteLine(" ' Car ' / ' Bus ' / ' Bike '");
            string vehicleType = Console.ReadLine().ToUpper().Trim();

            // initialize the required object
            switch (vehicleType)
            {
                case "CAR":
                    {
                        CarParking car = new Car();
                        car.setVehicleType(vehicleType);
                        car.setHourParked(hourParked);
                        car.CalculateParkingFees(hourParked);
                        car.showParkingFee();
                        
                        break;
                    }

                case "BUS":
                    {
                        CarParking bus = new Bus();
                        bus.setVehicleType(vehicleType);
                        bus.setHourParked(hourParked);
                        bus.CalculateParkingFees(hourParked);
                        bus.showParkingFee();
                        break;
                    }
                case "Bike":
                    {
                        CarParking bike = new Bike();
                        bike.setVehicleType(vehicleType);
                        bike.setHourParked(hourParked);
                        bike.CalculateParkingFees(hourParked);
                        bike.showParkingFee();
                        break;
                    }

            }
        }
    }
}

