using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class CargoAerialVehicule: AerialVehicule
    {
        protected decimal CapacityKilograms { get; set; }
        
        #region Properties
        
        #endregion

        #region Methods
        public override string ToString()
        {
            return $"\tCapacityKilograms: {CapacityKilograms}\n";
        }

        #endregion

    }
}
