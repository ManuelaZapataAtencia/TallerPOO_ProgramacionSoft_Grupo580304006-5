using System;
using TallerPOO.Interfaces;

namespace TallerPOO {
    public class Invoice : IInvoice
    {
        private string _Id;
        private string _Description;
        private decimal _GovermentTax;
        private decimal _UnitPrice;
        private int _Quantity;
        private decimal _TotalPrice;

        public Vehicle AddVehicle(Vehicle vehicle)
        {
            return vehicle;
        }

        public decimal GetTotalAmount(decimal UnitPrice, int Quantity)
        {
            return UnitPrice * decimal.parse(Quantity);
        }

        public decimal GetValueToPay(decimal TotalPrice, decimal GovermentTax)
        {
            return TotalPrice + GovermentTax;
        }

        public override string ToString()
        {
            return $"Invoice {Id} Description: {Description}\n" +
                   $"Government tax: {GovermentTax:C}\n" +
                   $"Unit price: {UnitPrice:C}\n" +
                   $"Quantity: {Quantity}\n" +
                   $"Total price: {TotalPrice:C}\n" +
                   $"Value to pay: {GetValueToPay(TotalPrice, GovermentTax):C}";
        }


        public string Id { get => _Id; set => _Id = value; }
        public string Description { get => _Description; set => _Description = value; }
        public decimal GovermentTax { get => _GovermentTax; set => _GovermentTax = value; }
        public decimal UnitPrice { get => _UnitPrice; set => _UnitPrice = value; }
        public int Quantity { get => _Quantity; set => _Quantity = value; }
        public decimal TotalPrice { get => _TotalPrice; set => _TotalPrice = value; }
    }
}
