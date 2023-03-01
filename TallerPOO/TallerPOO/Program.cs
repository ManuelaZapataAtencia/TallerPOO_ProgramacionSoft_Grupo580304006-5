using Microsoft.VisualBasic;
using System;
using System.Diagnostics;
using System.Reflection;
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


            } while (option != 0);
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
            Console.WriteLine("******************************");
            Console.WriteLine("* Purchase a human-powered vehicle *");
            Console.WriteLine("******************************");

            Console.WriteLine("Enter the brand of the vehicle");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter the model of the vehicle");
            int model = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the reference of the vehicle");
            string reference = Console.ReadLine();

            Console.WriteLine("Enter price");
            decimal price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Has Permission CA?:");
            bool HasPermissionCA = Convert.ToBoolean(Console.ReadLine());

            Console.WriteLine("Enter Registration Certificate:");
            int RegistrationCertificate = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("TypeUse:");
            String TypeUse = Console.ReadLine();


            AerialVehicle aerialVehicle = new AerialVehicle
            {
                _Brand = brand,
                _Model = model,
                _Reference = reference,
                _Price = price,
                HasPermissionCA = HasPermissionCA,
                RegistrationCertificate = RegistrationCertificate,
                TypeUse = TypeUse
                
            };

            aerialVehicle._Price = aerialVehicle.CalculateFinalPrice(price);
            Console.WriteLine(GenerateInvoice(aerialVehicle));

        }


        public void BuyCargoAerialVehicle()
        {
            Console.WriteLine("******************************");
            Console.WriteLine("* Purchase a human-powered vehicle *");
            Console.WriteLine("******************************");

            Console.WriteLine("Enter the brand of the vehicle");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter the model of the vehicle");
            int model = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the reference of the vehicle");
            string reference = Console.ReadLine();

            Console.WriteLine("Enter price");
            decimal price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Capacity Kilograms:");
            float CapacityKilograms = Convert.ToInt32(Console.ReadLine());



            CargoAerialVehicle cargoAerialVehicle = new CargoAerialVehicle
            {
                _Brand = brand,
                _Model = model,
                _Reference = reference,
                _Price = price,
                _CapacityKilograms = CapacityKilograms

            };

            cargoAerialVehicle._Price = cargoAerialVehicle.CalculateFinalPrice((price, cargoAerialVehicle.CalculatedAdded(price));
            Console.WriteLine(GenerateInvoice(cargoAerialVehicle));
        }

        public void BuyHumanPoweredVehicle()
        {


            Console.WriteLine("******************************");
            Console.WriteLine("* Purchase a human-powered vehicle *");
            Console.WriteLine("******************************");

            Console.WriteLine("Enter the brand of the vehicle");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter the model of the vehicle");
            int model = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the reference of the vehicle");
            string reference = Console.ReadLine();

            Console.WriteLine("Enter price");
            decimal price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Environmental Subsidy:");
            decimal environmentalSubsidy = Convert.ToInt32(Console.ReadLine());

            HumanPoweredVehicle humanPoweredVehicle = new HumanPoweredVehicle
            {
                _Brand = brand,
                _Model = model,
                _Reference = reference,
                _Price = price,
                _EnvironmentalSubsidy = environmentalSubsidy


            };

            humanPoweredVehicle._Price = humanPoweredVehicle.CalculateFinalPrice(price, humanPoweredVehicle.CalculateSubsidy(price));
            Console.WriteLine(GenerateInvoice(humanPoweredVehicle));

        }

        public void BuyMilitaryAerialVehicle()
        {

            Console.WriteLine("******************************");
            Console.WriteLine("* Purchase a military aerial vehicle *");
            Console.WriteLine("******************************");

            Console.WriteLine("Enter the brand of the vehicle");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter the model of the vehicle");
            int model = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the reference of the vehicle");
            string reference = Console.ReadLine();

            Console.WriteLine("Enter price");
            decimal price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Military Tax:");
            decimal militaryTax = Convert.ToInt32(Console.ReadLine());

            MilitaryAerialVehicule militaryAerialVehicule = new MilitaryAerialVehicule
            {
                _Brand = brand,
                _Model = model,
                _Reference = reference,
                _Price = price,
                _MilitaryTax = militaryTax

            };
            militaryAerialVehicule._Price = militaryAerialVehicule.CalculateFinalPrice(price, militaryAerialVehicule.CalculateMilitaryTax(price));
            Console.WriteLine(GenerateInvoice(militaryAerialVehicule));
        }

        public void BuyUsedMotorizedVehicle()
        {


            Console.WriteLine("******************************");
            Console.WriteLine("* Purchase a used motorized vehicle *");
            Console.WriteLine("******************************");

            Console.WriteLine("Enter the brand of the vehicle");
            string brand = Console.ReadLine();

            Console.WriteLine("Enter the model of the vehicle");
            int model = Convert.ToInt32(Console.ReadLine());


            Console.WriteLine("Enter the reference of the vehicle");
            string reference = Console.ReadLine();

            Console.WriteLine("Enter price");
            decimal price = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Mileage:");
            int mileage = Convert.ToInt32(Console.ReadLine());

            UsedMotorizedLandVehicle usedMotorizedLandVehicle = new UsedMotorizedLandVehicle
            {
                _Brand = brand,
                _Model = model,
                _Reference = reference,
                _Price = price,
                _Mileage = mileage

            };
            usedMotorizedLandVehicle._Price = usedMotorizedLandVehicle.CalculateFinalPrice(price, usedMotorizedLandVehicle.ChecKDiscountUsedVehicle(mileage, price));
            Console.WriteLine(GenerateInvoice(usedMotorizedLandVehicle));

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
                "\n***********************************" +
                "\n Main Menu:" +
                "\n***********************************" +
                "Select an option:" +
                "\n1. Buy a motorized vehicle" +
                "\n2. Buy an aerial vehicle" +
                "\n3. Buy a cargo aerial vehicle" +
                "\n4. Buy a human-powered vehicle" +
                "\n5. Buy a military aerial vehicle" +
                "\n6. Buy a used motorized vehicle" +
                "\n0. Exit";
        }

    }
}
