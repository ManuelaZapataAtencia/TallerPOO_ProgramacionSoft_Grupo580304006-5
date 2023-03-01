using System;

public class UsedMotorizedLandVehicle:MotorizedLandVehicle
{
	private int _mileage { get; set; }


	public override decimal CalculateFinalPrice()
	{

	}

	public override string ToString()
	{
		return base.ToString()
			$"\tMileage: {_Mileage}Km\n\t***USED***";
	}
}
