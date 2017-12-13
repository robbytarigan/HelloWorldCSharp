using System;

namespace Example
{
    class Program
    {

        static void Main(string[] args)
        {
            var point1 = new Point3D(2, 3, 5);
            var point2 = new Point3D(10, 7, 21);

            var distance = CalculateDistance(point1, point2);

            Console.WriteLine($"Distance point 1 to 2 is {distance}");

	    distance = CalculateDistance(point1, new Point3D());
	    Console.WriteLine($"Distance point 1 to origin is {distance}");

	    var readPoint1 = new ReadonlyPoint3D(2, 3, 5);
	    var readPoint2 = new ReadonlyPoint3D(10, 7, 21);

	    distance = CalculateDistance(readPoint1, readPoint2);
	    Console.WriteLine("Distance between readonly point 1 to 2 is {0}", distance);
        }

        // Feature in parameters
        private static double CalculateDistance(in Point3D point1, in Point3D point2 = default) {
	    var originValue = Point3D.Origin; // Copy the constant and assign it into variable originValue
	    ref readonly var originReference = ref Point3D.Origin;	   // Reference 
		
            double xDifference = point1.X - point2.X;
            double yDifference = point1.Y - point2.Y;
            double zDifference = point1.Z - point2.Z;

            return Math.Sqrt(xDifference * xDifference + yDifference * yDifference + zDifference * zDifference);
        }

         private static double CalculateDistance(in ReadonlyPoint3D point1, in ReadonlyPoint3D point2 = default) {
            double xDifference = point1.X - point2.X;
            double yDifference = point1.Y - point2.Y;
            double zDifference = point1.Z - point2.Z;

            return Math.Sqrt(xDifference * xDifference + yDifference * yDifference + zDifference * zDifference);
        }
   }
}
