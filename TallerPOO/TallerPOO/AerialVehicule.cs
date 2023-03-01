using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Text;

namespace TallerPOO
{
    public class AerialVehicule: Vehicle
    {
        public AerialVehicule(string reference) : base(reference)
        {
        }
        #region Properties
        protected bool HasPermissionCA { get; set; }
        protected int RegistrationCertificate { get; set; }
        protected string TypeUse { get; set; }
        #endregion

        #region Methods
        public override decimal CalculateFinalPrice()
        {
            throw new NotImplementedException();
        }
        public override string ToString()
        {
            return $"\tHasPermissionCA: {HasPermissionCA}\n" +
               $"\tRegistrationCertificate: {RegistrationCertificate}\n" +
           $"\tTypeUse: {TypeUse}\n";
        }

        #endregion
    }

}
