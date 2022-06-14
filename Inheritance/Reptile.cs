using System;
namespace Inheritance
{
	public class Reptile : Animal
	{
		public Reptile()
		{
			FourLegs = false;
			TwoEyes = true;
			Adorable = true;
			Furry = false;


		}

		public bool ColdBlooded { get; set; }
		public bool HasScales { get; set; }
		public bool HasVenom { get; set; }
		public bool TwoLegs { get; set; }

		
	}
}

