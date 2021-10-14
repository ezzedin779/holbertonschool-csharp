using System;

	/// <summary>
	/// the vectormath class vector
	/// </summary>
    class VectorMath
    {
		/// <summary>
		/// the magnitude of 2d 3d vector
		/// </summary>
		/// <param name="vector">to calculate it's length</param>
		/// <returns></returns>
        public static double Magnitude(double[] vector)
        {
			if (vector.Length < 2)
				return (-1);
			double v0 = vector[0];
			double v1 = vector[1];
			double result = v0 * v0 + v1 * v1;
			if (vector.Length == 3)
				return (Math.Round(Math.Sqrt(result + vector[2] * vector[2]), 2));
			if (vector.Length == 2)
				return(Math.Round(Math.Sqrt(result), 2));
			else
				return (-1);
        }
    }
