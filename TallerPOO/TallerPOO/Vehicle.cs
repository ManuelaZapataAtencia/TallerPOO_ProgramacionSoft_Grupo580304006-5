using System;

namespace TallerPOO
{
	public abstract class Vehicle
	{
		protected string Brand;
		protected string Model;
		private string reference;

		protected string Reference { get => reference; set => reference = value; }

		public abstract decimal CalculateFinalPrice();
		public override string ToString()
		{
			return $"\tBrand: {Brand}\n" +
				$"\tModel: {Model}\n" +
				$"\tReference: {Reference}\n";
		}


	}
}
