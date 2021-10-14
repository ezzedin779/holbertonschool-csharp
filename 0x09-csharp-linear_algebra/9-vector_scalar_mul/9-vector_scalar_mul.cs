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
			double[] ok = {-1};
			if (vector.Length == 2)
			{
				double[] r1 = {vector[0] * scalar, vector[1] * scalar};
				return (r1);
			}
			if (vector.Length == 3)
			{
				double[] r2 = {vector[0] * scalar, vector[1] * scalar, vector[2] + * scalar};
				return (r2);
			}
			else
				return (ok);
		}
    }
