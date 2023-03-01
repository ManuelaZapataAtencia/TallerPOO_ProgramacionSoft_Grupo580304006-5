using System;

namespace TallerPOO
{
    public class HumanPoweredVehicle : Vehicle
    {
        #region Properties
        protected decimal _EnvironmentalSubsidy { get; set; }

        #endregion

        #region Methods
        public decimal CalculateFinalPrice(decimal EnvironmentalSubsidy,decimal Price)
        {
            return Price - EnvironmentalSubsidy;
        }

        public decimal CalculateDiscount(float Percentaje,decimal Price)
        {
            return Price * Convert.ToDecimal(Percentaje) ;
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
