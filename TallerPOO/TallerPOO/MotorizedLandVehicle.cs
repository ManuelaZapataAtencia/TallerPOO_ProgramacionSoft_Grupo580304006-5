using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class MotorizedLandVehicle : Vehicle
    {

        #region Properties
        public decimal _Percentaje { get; set; }
        public decimal _CarTax { get; set; }
        public string _CarType { get; set; }
        public string _Plate { get; set; }
        public string _TractionType { get; set; }

        #endregion



        #region Methods
        public override decimal CalculateFinalPrice( decimal Price, decimal Added)
        {
            return Price + Added + _CarTax;
        }

        public decimal CheckPercentage(decimal Price, string CarType)
        {
            
            if (CarType == "SUV")
            {
                return (decimal)(Price*0.2m);
            }
            else if (CarType == "Pickup")
            {
                return (decimal)Price*0.3m;
            }
             else
            {
                Console.WriteLine("Discount does NOT apply");
                return 0;
            }
        }

        public override string ToString()
        {

            return "\nMotorized vehicle:\n" +
                $"{base.ToString()}" +
            $"\tCar Tax: {_CarTax}\n" +
                $"\tCar Type: {_CarType}\n" +
            $"\tPlate: {_Plate}\n" +
             $"\tTraction Type: {_TractionType}\n";
        }


        #endregion
    }
}



