using System;

namespace TallerPOO
{
    public abstract class Vehicle
    {
        #region Properties
        protected string _Brand { get; set; }
        protected int _Model { get; set; }
        protected string _Reference { get; set; }

        #endregion



        #region Methods
        public abstract decimal CalculateFinalPrice(decimal Price, decimal Added);

        public override string ToString()
        {
            return $"\tBrand: {_Brand}\n" +
                $"\tModel: {_Model}\n" +
                $"\tReference: {_Reference}\n";
        }

        #endregion
    }
}