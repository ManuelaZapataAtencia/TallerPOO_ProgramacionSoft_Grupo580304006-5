using System;

namespace TallerPOO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Program objPro = new Program();
            int option;
            do
            {
                Console.WriteLine(objPro.MainMenu());
                option = Convert.ToInt32(Console.ReadLine());
                Vehicle vehicle;
                switch (option)
                {
                    case 1:
                        objPro.BuyMotorizedVehicle(vehicle);
                        break;
                    case 2:
                        objPro.BuyAerialVehicle(vehicle);
                        break;
                    case 3:
                        objPro.BuyCargoAerialVehicle(vehicle);
                        break;
                    case 4:
                        objPro.BuyHumanPoweredVehicle(vehicle);
                        break;
                    case 5:
                        objPro.BuyMilitaryAerialVehicle(vehicle);
                        break;
                    case 6:
                        objPro.BuyUsedMotorizedVehicle(vehicle);
                        break;
                    case 0:
                        Console.WriteLine("Goodbye!");
                        break;
                    default:
                        Console.WriteLine("Invalid option. Please select again.");
                        break;
                }
            

            } while(option!=0);
        }

        public void BuyMotorizedVehicle(Vehicle vehicle)
        {


            vehicle = new MotorizedLandVehicle()
            {

            }
        }

        public void BuyAerialVehicle(Vehicle vehicle)
        {
            // Code to allow the user to purchase an aerial vehicle
            // ...
        }

        public void BuyCargoAerialVehicle(Vehicle vehicle)
        {
            // Code to allow the user to purchase a cargo aerial vehicle
            // ...
        }

        public void BuyHumanPoweredVehicle(Vehicle vehicle)
        {
            // Code to allow the user to purchase a human-powered vehicle
            // ...
        }

        public void BuyMilitaryAerialVehicle(Vehicle vehicle)
        {
            // Code to allow the user to purchase a military aerial vehicle
            // ...
        }

        public void BuyUsedMotorizedVehicle(Vehicle vehicle)
        {
            // Code to allow the user to purchase a used motorized vehicle
            // ...
        }



        public string MainMenu()
        {

            return "Select an option:"+
                "\n1. Buy a motorized vehicle"+
                "\n2. Buy an aerial vehicle"+
                "\n3. Buy a cargo aerial vehicle"+
                "\n4. Buy a human-powered vehicle"+
                "\n5. Buy a military aerial vehicle"+
                "\n6. Buy a used motorized vehicle"+
                "\n0. Exit";
        }


    }
}
