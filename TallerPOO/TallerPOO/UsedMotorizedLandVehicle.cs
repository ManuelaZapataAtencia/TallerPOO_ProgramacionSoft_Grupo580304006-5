using System;
using System.Diagnostics;

namespace TallerPOO
{
    public class UsedMotorizedLandVehicle : MotorizedLandVehicle
    {
        #region Properties
        private int _Mileage { get; set; }

        #endregion

        #region Methods

        public decimal UsedVehicle(int Mileage, float Percentaje, decimal Price)
        {
            if (Mileage >= 1 && Mileage <= 4999)
            {
                return Price * Convert.ToDecimal(Percentaje);

            }
            else if(Mileage >= 5000 && Mileage <= 9999)
            {
                return Price * Convert.ToDecimal(Percentaje);
            }
            else if (Mileage >= 10000)
            {
                return Price * Convert.ToDecimal(Percentaje);
            }    
            else
            {
                Console.WriteLine("Mileage range does NOT apply to discount\r\n");
            }

        }
        public override decimal CalculateFinalPrice(float Percentaje, decimal Price)
        {
            return Price - Convert.ToDecimal(Percentaje);
        }

        public override string ToString()
        {
            return base.ToString() +
            $"\tMileage: {_Mileage}\n\t";

        }

        #endregion
    }

}