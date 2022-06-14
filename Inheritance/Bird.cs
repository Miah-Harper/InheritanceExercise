using System;
namespace Inheritance
{
	public class Bird : Animal
	{
		public Bird()
		{
			FourLegs = false;
			TwoEyes = true;
			Adorable = true;
			Furry = true;

		}

		public bool Wings { get; set; }
		public bool Beaks { get; set; }
		public bool Colorful { get; set; }
		public bool Nests { get; set; }
	}
}

