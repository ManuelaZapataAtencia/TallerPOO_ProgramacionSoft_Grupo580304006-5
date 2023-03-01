using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class MotorizedLandVehicule : Vehicle
    {
        #region Properties
        protected decimal CarTax;
        protected decimal CarType;
        protected string Plate;
        protected string TractionType;

        public MotorizedLandVehicule(string reference) : base(reference)
        {
        }

        #endregion



        #region Methods
        public override decimal CalculateFinalPrice()
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {

            return $"\tCarTax: {CarTax}\n" +
                $"\tCarTypel: {CarType}\n" +
            $"\tPlate: {Plate}\n" +
             $"\tTractionType: {TractionType}\n";
            
        }

        
        #endregion
    }
}
