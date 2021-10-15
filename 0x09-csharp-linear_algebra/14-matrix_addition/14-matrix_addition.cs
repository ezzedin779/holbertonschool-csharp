using System;

	/// <summary>
	/// the matrix calculations
	/// </summary>
    class MatrixMath
    {
		
        public static double[,] Add(double[,] matrix1, double[,] matrix2)
        {
			if (matrix1.Length == matrix2.Length && (matrix1.Length == 3 || matrix1.Length == 2))
			{
				double[] r = new double[matrix1.Length];
				for (var i = 0; i < matrix1.Length; i++)
					r[i] = matrix1[i] + matrix2[i];
				return (r);
			}
			else
				return (new double[] {-1});
		}
    }
