using System;

namespace Others
{
    class Program
    {
        static void Main(string[] args)
        {
		// Leading underscores in numeric values
		int binaryValue = 0b_0101_0101;
		int hexValue = 0x___ffff;
		int decValue = 343_435;
		Console.WriteLine("Value is {0}, {1}, {2}", binaryValue, hexValue, decValue);

		var ads = new JobAds();
		ads.Display();

        }

    	/* A new compound access modifier: private protected indicates that a member may be accessed cy containing class
     	 * or derived class that are declared in the same assembly
         */
 	private protected class Ads {
		protected virtual void Display() {
			Console.WriteLine("Ads.Display");
		}
	}

	private protected class JobAds : Ads {
		public void Display() {
			Console.WriteLine("JobAds.Display");
			base.Display();
		}
	}

    }

}
