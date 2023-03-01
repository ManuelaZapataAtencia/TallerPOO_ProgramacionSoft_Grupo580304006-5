using System;

public interface IInvoice
{
	public decimal GetTotalAmount();
    public decimal GetValueToPay();
}
