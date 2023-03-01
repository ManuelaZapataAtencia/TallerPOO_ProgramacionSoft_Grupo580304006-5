using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class MotorizedLandVehicule : Vehicle
    {
        #region Properties
        protected decimal CarTax { get; set; }
        protected decimal CarType { get; set; }
        protected string Plate { get; set; }
        protected string TractionType { get; set; }

        #endregion



        #region Methods
        public override decimal CalculateFinalPrice()
        {
            throw new NotImplementedException();
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
