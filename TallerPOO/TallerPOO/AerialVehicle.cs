using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class AerialVehicle: Vehicle
    {
        
        #region Properties
        public bool HasPermissionCA { get; set; }
        public int RegistrationCertificate { get; set; }
        public string TypeUse { get; set; }
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
