using System;
using System.Xml.Schema;

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

        public Vehicle BuyMotorizedVehicle()
        {


            return new MotorizedLandVehicle()
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

            return new HumanPoweredVehicle()
            {

                humanPoweredVehicle.Brand = "BMW",
                humanPoweredVehicle.Model = 2019,
                humanPoweredVehicle.Reference = "Blanco",
                EnvironmentalSubsidy = environmentalSubsidy,

            };


        Console.WriteLine("******************************");
            Console.WriteLine("* Purchase a human-powered vehicle *");
            Console.WriteLine("******************************");

            Console.WriteLine("Enter the brand of the vehicle");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter the model of the vehicle");
            int moldel = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the reference of the vehicle");
            string reference= Console.ReadLine();

            Console.WriteLine("Enter price");
            string price = Console.ReadLine();

            Console.WriteLine("Enter Environmental Subsidy:");
            decimal environmentalSubsidy = Convert.ToInt32(Console.ReadLine());

           
        }

        public void BuyMilitaryAerialVehicle(Vehicle vehicle)
        {
            // Code to allow the user to purchase a military aerial vehicle
            // ...
            Console.WriteLine("******************************");
            Console.WriteLine("* Purchase a military aerial vehicle *");
            Console.WriteLine("******************************");

            Console.WriteLine("Enter the brand of the vehicle");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter the model of the vehicle");
            int moldel = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the reference of the vehicle");
            string reference = Console.ReadLine();


            Console.WriteLine("Enter Military Tax:");
            decimal militaryTax = Convert.ToInt32(Console.ReadLine());

        }

        public void BuyUsedMotorizedVehicle(Vehicle vehicle)
        {
            // Code to allow the user to purchase a used motorized vehicle
            // ...

            Console.WriteLine("******************************");
            Console.WriteLine("* Purchase a used motorized vehicle *");
            Console.WriteLine("******************************");

            Console.WriteLine("Enter the brand of the vehicle");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter the model of the vehicle");
            int moldel = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the reference of the vehicle");
            string reference = Console.ReadLine();


            Console.WriteLine("Enter Mileage:");
            decimal mileage = Convert.ToInt32(Console.ReadLine());

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
