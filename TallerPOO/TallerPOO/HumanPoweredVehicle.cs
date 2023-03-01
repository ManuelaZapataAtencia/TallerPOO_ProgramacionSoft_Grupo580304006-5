using System;

namespace TallerPOO
{
    public class HumanPoweredVehicle : Vehicle
    {
        #region Properties
        protected decimal _EnvironmentalSubsidy { get; set; }

        #endregion

        #region Methods
        public override decimal CalculateFinalPrice(decimal Price, decimal Added)
        {
            return Price - Added;
        }

        public decimal CalculateSubsidy(decimal Price)
        {
            return Price * 0.25m;
        }

        public override string ToString()
        {
            return "Human Powered Vehicle:"+
                base.ToString()+
                $"\tEnvironmentalSubsidy: {_EnvironmentalSubsidy}\n";

        }
        #endregion
    }
}
