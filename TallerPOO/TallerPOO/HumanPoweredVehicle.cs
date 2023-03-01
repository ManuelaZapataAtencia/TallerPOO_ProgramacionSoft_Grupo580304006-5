using System;

public class HumanPoweredVehicle: Vehicle 
{
    #region Propieries
    protected decimal EnvironmentalSubsidy;

    #endregion

    public HumanPoweredVehicle()
	{
	}

    #region Methods
    public override decimal CalculateFinalPrice()
    {
        throw new NotImplementedException();
    }

    public override string ToString()
    {
        return $"\tEnvironmentalSubsidy: {EnvironmentalSubsidy}\n";

    }
    #endregion
}
