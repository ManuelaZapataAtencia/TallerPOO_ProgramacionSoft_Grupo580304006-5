using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class CargoAerialVehicle: AerialVehicle
    {
        public float _CapacityKilograms { get; set; }

        #region Properties

        #endregion

        #region Methods

        public override decimal CalculateFinalPrice(decimal Price, decimal Added)
        {
            return Price + Added;
        }

        public decimal CalculatedAdded(float Price)
        {
            return (decimal)_CapacityKilograms*5000.0m;
        }

        public override string ToString()
        {
            return $"\tCapacityKilograms: {_CapacityKilograms}\n";
        }

        #endregion

    }
}
