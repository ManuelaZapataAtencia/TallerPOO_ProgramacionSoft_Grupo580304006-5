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
                        objPro.BuyMotorizedVehicle();
                        break;
                    case 2:
                        objPro.BuyAerialVehicle();
                        break;
                    case 3:
                        objPro.BuyCargoAerialVehicle();
                        break;
                    case 4:
                        objPro.BuyHumanPoweredVehicle();
                        break;
                    case 5:
                        objPro.BuyMilitaryAerialVehicle();
                        break;
                    case 6:
                        objPro.BuyUsedMotorizedVehicle();
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

        public void BuyMotorizedVehicle()
        {


            Console.WriteLine("Enter the brand:");
            string Brand = Console.ReadLine();

            Console.WriteLine("Enter the model:");
            int Model = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the reference:");
            string Reference = Console.ReadLine();

            Console.WriteLine("Enter the percentage of newness (0-100):");
            decimal Percentaje = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the car tax (decimal value):");
            decimal CarTax = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the car type:");
            string CarType = Console.ReadLine();

            Console.WriteLine("Enter the plate:");
            string Plate = Console.ReadLine();

            Console.WriteLine("Enter the traction type:");
            string TractionType = Console.ReadLine();

            Vehicle vehicle = new MotorizedLandVehicle()
            {
                _Brand = Brand,
                _Model = Model,
                _Reference = Reference,
                _Percentaje = Percentaje,
                _CarTax = CarTax,
                _CarType = CarType,
                _Plate = Plate,
                _TractionType = TractionType
            };

            // Code to finalize the purchase of the motorized vehicle
            // ...

        }

        public void BuyAerialVehicle()
        {
            // Code to allow the user to purchase an aerial vehicle
            // ...
        }

        public void BuyCargoAerialVehicle()
        {
            // Code to allow the user to purchase a cargo aerial vehicle
            // ...
        }

        public void BuyHumanPoweredVehicle()
        {
            // Code to allow the user to purchase a human-powered vehicle
            // ...
        }

        public void BuyMilitaryAerialVehicle()
        {
            // Code to allow the user to purchase a military aerial vehicle
            // ...
        }

        public void BuyUsedMotorizedVehicle()
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
