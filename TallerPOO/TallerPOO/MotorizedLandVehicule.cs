using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class MotorizedLandVehicule : Vehicle
    {
        #region Properties
        protected decimal _CarTax { get; set; }
        protected string _CarType { get; set; }
        protected string _Plate { get; set; }
        protected string _TractionType { get; set; }

        #endregion



        #region Methods
        public override decimal CalculateFinalPrice(string CarType, decimal Price)
        {
            return 0
        }

        public float CheckPercenage(string CarType)
        {
            return 0
        }

        public override string ToString()
        {

            return"Motorized vehicle:"+
                base.ToString() 
                $"\tCarTax: {CarTax}\n" +
                $"\tCarTypel: {CarType}\n" +
                $"\tPlate: {Plate}\n" +
                $"\tTractionType: {TractionType}\n";
            
        }

        
        
        #endregion
    }
}
