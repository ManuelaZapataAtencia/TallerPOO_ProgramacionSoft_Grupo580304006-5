using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;


namespace TallerPOO
{
    public class UsedMotorizedLandVehicle : MotorizedLandVehicle
    {
        #region Properties
        private int _Mileage { get; set; }

        #endregion

        #region Methods

        public decimal ChecKDiscountUsedVehicle(int Mileage, decimal Price)
        {
            if (Mileage >= 1 && Mileage <= 4999)
            {
                return Price * 0.125m;

            }
            else if(Mileage >= 5000 && Mileage <= 9999)
            {
                return Price * 0.25m;
            }
            else if (Mileage >= 10000)
            {
                return Price * 0.5m;
            }    
            else
            {
                Console.WriteLine("Mileage range does NOT apply to discount\r\n");
                return 0m;
            }

        }
        public override decimal CalculateFinalPrice(decimal Price,decimal Added)
        {
            return Price - Added;
        }

        public override string ToString()
        {
            return base.ToString() +
            $"\tMileage: {_Mileage}\n\t";

        }

        #endregion
    }

}