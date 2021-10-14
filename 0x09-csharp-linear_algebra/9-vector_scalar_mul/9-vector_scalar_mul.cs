using System;

	/// <summary>
	/// the vectormath
	/// </summary>
    class VectorMath
    {
		/// <summary>
		/// multiply them
		/// </summary>
		/// <param name="vector">the vector</param>
		/// <param name="scalar">the number</param>
		/// <returns>new vector</returns>
        public static double[] Multiply(double[] vector, double scalar)
        {
			if (vector.Length > 3 || vector.Length < 2)
				return (new double[] {-1});
			double[] r = new double[vector.Length];
			for (var i = 0; i < vector.Length; i++)
				r[i] = vector[i] * scalar;
			return (r);
		}
    }
