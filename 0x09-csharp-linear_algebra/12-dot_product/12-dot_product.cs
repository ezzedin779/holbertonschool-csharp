using System;

	/// <summary>
	/// the vectormath
	/// </summary>
    class VectorMath
    {
		
        public static double DotProduct(double[] vector1, double[] vector2)
        {
			if (vector1.Length == vector2.Length && (vector1.Length == 3 || vector1.Length == 2))
			{
				double[] r = new double[vector1.Length];
				double dot = 0;
				for (var i = 0; i < vector1.Length; i++)
					r[i] = vector1[i] * vector2[i];
				foreach (var hi in r)
					dot = dot + hi;
				return (dot);
			}
			else
				return (-1);
		}
    }
