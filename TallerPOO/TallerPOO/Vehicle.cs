using System;

namespace TallerPOO
{
    public abstract class Vehicle
    {
        #region Properties
        protected string _Brand { get; set; }
        protected string _Model { get; set; }
        protected string _Reference { get; set; }

        #endregion



        #region Methods
        public abstract decimal CalculateFinalPrice();

        public override string ToString()
        {
            return $"\tBrand: {_Brand}\n" +
                $"\tModel: {_Model}\n" +
                $"\tReference: {_Reference}\n";
        }

        #endregion
    }
}