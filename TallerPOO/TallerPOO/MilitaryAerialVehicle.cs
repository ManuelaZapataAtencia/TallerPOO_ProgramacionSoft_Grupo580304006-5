using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace TallerPOO
{
    public class MilitaryAerialVehicule: AerialVehicle
    {
        #region Properties
        public decimal _MilitaryTax { get; set; }
        #endregion

        #region Methods

        public override decimal CalculateFinalPrice(decimal Price, decimal Added)
        {
            return Price - Added;
        }

        public decimal CalculateMilitaryTax(decimal Price)
        {
            return Price * 0.18m;
        }
        public override string ToString()
        {
            return $"\tMilitaryTax: {_MilitaryTax}\n";
        }




        #endregion
    }
}
