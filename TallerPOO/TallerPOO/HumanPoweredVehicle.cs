using System;

namespace TallerPOO
{
    public class HumanPoweredVehicle : Vehicle
    {
        #region Properties
        protected decimal EnvironmentalSubsidy { get; set; }

        #endregion

        #region Methods
        public override decimal CalculateFinalPrice()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return $"\tEnvironmentalSubsidy: {EnvironmentalSubsidy}\n";

        }
        #endregion
    }
}
