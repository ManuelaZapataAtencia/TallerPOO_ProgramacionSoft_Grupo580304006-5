using System;


namespace TallerPOO.Interfaces
{
    public interface IInvoice
    {
        public decimal GetTotalAmount();
        public decimal GetValueToPay();
    }
}
