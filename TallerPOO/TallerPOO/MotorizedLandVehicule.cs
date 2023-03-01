using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class MotorizedLandVehicule : Vehicle
    {
        private decimal _Percentaje;
        #region Properties
        protected decimal _CarTax { get; set; }
        protected string _CarType { get; set; }
        protected string _Plate { get; set; }
        protected string _TractionType { get; set; }

        #endregion



        #region Methods
        public override decimal CalculateFinalPrice( decimal Price, float Percentaje)
        {
            return Price - Convert.ToDecimal(Percentaje);
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



