using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class CommercialAerialVehicule: AerialVehicule
    {
        #region Properties

        protected decimal Discount { get; set; }



        #endregion

        public CommercialAerialVehicule()
        {

        }
        public override string ToString()
        {
            return $"\tDiscount: {Discount}\n";
        }
    }
}
