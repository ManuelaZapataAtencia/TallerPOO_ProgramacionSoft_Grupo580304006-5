using System;
using System.Collections.Generic;
using System.Reflection.PortableExecutable;
using System.Text;

namespace TallerPOO
{
    public class MilitaryAerialVehicule: AerialVehicule
    {
        #region Properties
        protected decimal MilitaryTax { get; set; }
        #endregion

        #region Methods
       
        public override string ToString()
        {
            return $"\tMilitaryTax: {MilitaryTax}\n";
        }




        #endregion
    }
}
