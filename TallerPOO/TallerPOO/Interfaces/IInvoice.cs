using System;


namespace TallerPOO.Interfaces
{
    public interface IInvoice
    {
        public decimal GetTotalAmount(decimal UnitPrice, int Quantity);
        public decimal GetValueToPay(decimal TotalPrice, decimal GovermentTax);
    }
}
