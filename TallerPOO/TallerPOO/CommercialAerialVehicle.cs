using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class CommercialAerialVehicule: AerialVehicle
    {
        #region Properties
        protected decimal _Discount { get; set; }
        #endregion

        public decimal CalculateDiscount(int Model, decimal Price)
        {
            if (Model >= 2010 && Model <= 2015)
            {
                return Price * 0.1m;
            }
            else if (Model >= 2016 && Model <= 2020)
            {
                return Price * 0.05m;
            }
            return 0m;
        }

        public override decimal CalculateFinalPrice(decimal Price, decimal Added)
        {
            return Price - Added;
        }

        public override string ToString()
        {
            return $"\tDiscount: {_Discount}\n";
        }
    }
}
