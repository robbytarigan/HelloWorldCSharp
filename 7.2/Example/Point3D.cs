namespace Example {
    public struct Point3D {
	/*
	 * It's likely that the library using Point3D would often use the origin throughout the code. 
	 * Every instance creates a new object on the stack. It may be advantageous to create a constant and return it by reference. 
	 * But, if you return a reference to internal storage, you may want to enforce that the caller cannot modify the referenced storage.
	 */
	private static Point3D origin = new Point3D();
	public static ref readonly Point3D Origin => ref origin;

        public double X;
        public double Y;
        public double Z;

        public Point3D(double x, double y, double z) {
            X = x;
            Y = y;
            Z = z;
        }
    }
}
