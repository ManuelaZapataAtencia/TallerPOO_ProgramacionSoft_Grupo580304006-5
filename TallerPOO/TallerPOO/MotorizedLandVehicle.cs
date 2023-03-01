using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class MotorizedLandVehicle : Vehicle
    {
        public decimal _Percentaje { get; set; }
        #region Properties
        public decimal _CarTax { get; set; }
        public string _CarType { get; set; }
        public string _Plate { get; set; }
        public string _TractionType { get; set; }

        #endregion



        #region Methods
        public override decimal CalculateFinalPrice( decimal Price, decimal Added)
        {
            return Price + Added;
        }

        public decimal CheckPercenage(decimal Price, float Percentaje, string CarType)
        {
            int discountSUV = 20;
            int discountP = 30;
            
            if (CarType == "SUV")
            {
                return (decimal)(Percentaje = (discountSUV / 100));
            }
            else if (CarType == "Pickup")
            {
                return (decimal)(Percentaje = (discountP / 100));
            }
             else
            {
                Console.WriteLine("Discount does NOT apply");
                return 0;
            }
        }

        public override string ToString()
        {

            return "Motorized vehicle:" +
                $"{base.ToString()}\n" +
            $"\tCar Tax: {_CarTax}\n" +
                $"\tCar Type: {_CarType}\n" +
            $"\tPlate: {_Plate}\n" +
             $"\tTraction Type: {_TractionType}\n";
        }


        #endregion
    }
}



