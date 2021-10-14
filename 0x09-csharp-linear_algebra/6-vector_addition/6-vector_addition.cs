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
			if (vector1.Length != vector2)
				return (-1);
			if (vector2 == 2)
			{
				double[] result = {vector1[0] + vector2[0], vector1[1] + vector2[1]};
				return (result);
			}
			if (vector2 == 3)
			{
				double[] result = {vector1[0] + vector2[0], vector1[1] + vector2[1], vector1[2] + vector2[2]};
				return (result);
			}
		}
    }
