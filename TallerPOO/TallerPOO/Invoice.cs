using System;
using TallerPOO.Interfaces;

namespace TallerPOO {
    public class Invoice : IInvoice
    {
        public string Id { get; set; }
        public string Description { get; set; }
        public decimal GovermentTax { get; set; }
        public decimal UnitPrice { get; set; }
        public int Quantity { get; set; }
        public decimal TotalPrice { get; set; }

        public Vehicle AddVehicle(Vehicle vehicle)
        {
            return vehicle;
        }

        public decimal GetTotalAmount(decimal UnitPrice, int Quantity)
        {
            TotalPrice = UnitPrice * Convert.ToDecimal(Quantity);
            return TotalPrice;
        }

        public decimal GetValueToPay(decimal TotalPrice, decimal GovermentTax)
        {
            TotalPrice = TotalPrice + TotalPrice * GovermentTax / 100;
            return TotalPrice;
        }

        public override string ToString()
        {
            return $"Invoice {Id} Description: {Description}\n" +
                   $"Government tax: {TotalPrice*GovermentTax/100:C}\n" +
                   $"Unit price: {UnitPrice:C}\n" +
                   $"Quantity: {Quantity}\n" +
                   $"Total price: {GetTotalAmount(TotalPrice,Quantity):C}\n" +
                   $"Value to pay: {GetValueToPay(TotalPrice, GovermentTax):C}";
        }
    }
}
