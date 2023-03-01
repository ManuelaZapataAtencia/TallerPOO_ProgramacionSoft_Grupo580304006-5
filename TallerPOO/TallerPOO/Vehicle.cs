using System;

public abstract class Vehicle
{
    #region Properties
    protected string Brand;
	protected string Model;
    private string reference;

    protected Vehicle(string reference)
    {
        Reference = reference;
    }
    #endregion
    protected string Reference { get => reference; set => reference = value; }


    #region Methods
    public abstract decimal CalculateFinalPrice();
	public override string ToString()
	{
		return $"\tBrand: {Brand}\n" +
			$"\tModel: {Model}\n" +
			$"\tReference: {Reference}\n";
    }

    #endregion
}
