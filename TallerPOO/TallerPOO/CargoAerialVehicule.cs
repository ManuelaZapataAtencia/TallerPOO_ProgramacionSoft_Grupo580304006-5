using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    internal class CargoAerialVehicule: AerialVehicule
    {
        protected decimal CapacityKilograms { get; set; }
        public CargoAerialVehicule(string reference) : base(reference)
        {
        }
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
