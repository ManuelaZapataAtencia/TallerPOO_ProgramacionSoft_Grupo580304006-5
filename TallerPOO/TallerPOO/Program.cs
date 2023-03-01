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
            Console.WriteLine("Not implemented yet");
        }

        public void BuyCargoAerialVehicle()
        {
            Console.WriteLine("Not implemented yet");
        }

        public void BuyHumanPoweredVehicle()
        {
            Console.WriteLine("Not implemented yet");
        }

        public void BuyMilitaryAerialVehicle()
        {
            Console.WriteLine("Not implemented yet");
        }

        public void BuyUsedMotorizedVehicle()
        {
            Console.WriteLine("Not implemented yet");
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
                TotalPrice = vehicle._Price
        };

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
