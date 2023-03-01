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
            MotorizedLandVehicle vehicle;
            Console.WriteLine("***************************");
            Console.WriteLine("Purchase Motorized Vehicle:");
            Console.WriteLine("***************************");

            Console.WriteLine("Enter the brand:");
            string Brand = Console.ReadLine();

            Console.WriteLine("Enter the model:");
            int Model = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the reference:");
            string Reference = Console.ReadLine();

            Console.WriteLine("Enter the Price (decimal value):");
            decimal Price = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the car tax (decimal value):");
            decimal CarTax = decimal.Parse(Console.ReadLine());

            Console.WriteLine("Enter the car type:");
            string CarType = Console.ReadLine();

            Console.WriteLine("Enter the plate:");
            string Plate = Console.ReadLine();

            Console.WriteLine("Enter the traction type:");
            string TractionType = Console.ReadLine();

            
            Console.WriteLine("***************************");
            Console.WriteLine("         INVOICE:          ");
            Console.WriteLine("***************************");

            vehicle = new MotorizedLandVehicle()
            {
                _Brand = Brand,
                _Model = Model,
                _Reference = Reference,
                _Price = Price,
                _Percentaje = 0m,
                _CarTax = CarTax,
                _CarType = CarType,
                _Plate = Plate,
                _TractionType = TractionType
            };
            vehicle._Percentaje = vehicle.CheckPercentage(Price, CarType);
            vehicle._Price = vehicle.CalculateFinalPrice(Price, vehicle._Percentaje);

            Console.WriteLine(GenerateInvoice(vehicle));

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

        public void BuyMilitaryAerialVehicle()
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

        public void BuyUsedMotorizedVehicle()
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

        public string GenerateInvoice(Vehicle vehicle)
        {
            Console.WriteLine("Enter the invoice ID:");
            string id = Console.ReadLine();

            Console.WriteLine("Enter the government tax (decimal value):");
            decimal governmentTax = decimal.Parse(Console.ReadLine());

            string description = vehicle.ToString();

            decimal unitPrice = vehicle._Price;

            Console.WriteLine("Enter the quantity:");
            int quantity = int.Parse(Console.ReadLine());

            

            Invoice objInvoice = new Invoice()
            {
                Id = id,
                Description = description,
                GovermentTax = governmentTax,
                UnitPrice = unitPrice,
                Quantity = quantity,
                TotalPrice = 0m
        };

            objInvoice.TotalPrice = objInvoice.GetTotalAmount(unitPrice, quantity);
            objInvoice.TotalPrice = objInvoice.GetValueToPay(objInvoice.TotalPrice, governmentTax);

            return objInvoice.ToString();
        }

        public string MainMenu()
        {

            return 
                "\n***********************************"+
                "\n Main Menu:"+
                "\n***********************************"+
                "Select an option:"+
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
