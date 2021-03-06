using System;

	/// <summary>
	/// the vectormath
	/// </summary>
    class VectorMath
    {
		/// <summary>
		/// add the vectors
		/// </summary>
		/// <param name="vector1">to be added</param>
		/// <param name="vector2">to the added one</param>
		/// <returns>the addition</returns>
        public static double[] Add(double[] vector1, double[] vector2)
        {
			double[] ok = {-1};
			if (vector1.Length != vector2.Length)
				return (ok);
			if (vector2.Length == 2)
			{
				double[] r1 = {vector1[0] + vector2[0], vector1[1] + vector2[1]};
				return (r1);
			}
			if (vector2.Length == 3)
			{
				double[] r2 = {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]};
				return (r2);
			}
			else
				return (ok);
		}
    }
