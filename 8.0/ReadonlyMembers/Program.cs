using System;

namespace ReadonlyMembers
{
	public struct Point
	{
	    public double X { get; set; }
	    public double Y { get; set; }
	    public readonly double Distance => Math.Sqrt(X * X + Y * Y);

	    public readonly override string ToString() =>
		$"({X}, {Y}) is {Distance} from the origin";


		// The following method will not compile unless you remove the readonly modifier:
		/* 
		public readonly void Translate(int xOffset, int yOffset)
		{
			X += xOffset;
			Y += yOffset;
		}
		*/
	}

    class Program
    {
        public static void Main(string[] args)
        {
			var p = new Point { X = 2, Y = 3};
			Console.WriteLine(p);
        }
    }
}
