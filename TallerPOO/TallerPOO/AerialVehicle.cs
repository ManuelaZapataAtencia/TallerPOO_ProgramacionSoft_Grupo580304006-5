using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class AerialVehicle: Vehicle
    {
        
        #region Properties
        protected bool HasPermissionCA { get; set; }
        protected int RegistrationCertificate { get; set; }
        protected string TypeUse { get; set; }
        #endregion

        #region Methods
        public override decimal CalculateFinalPrice(decimal Price, decimal Added)
        {
            return Price;
        }

        

        public override string ToString()
        {
            return "Aerial Vehicle:"+
                base.ToString()+
                $"\tHasPermissionCA: {HasPermissionCA}\n" +
                $"\tRegistrationCertificate: {RegistrationCertificate}\n" +
                $"\tTypeUse: {TypeUse}\n";
        }

        #endregion
    }

}
