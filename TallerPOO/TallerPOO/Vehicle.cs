using System;

namespace TallerPOO
{
    public abstract class Vehicle
    {
        #region Properties
        public string _Brand { get; set; }
        public int _Model { get; set; }
        public string _Reference { get; set; }

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