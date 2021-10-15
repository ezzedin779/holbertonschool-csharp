using System;

	/// <summary>
	/// the matrix calculations
	/// </summary>
    class MatrixMath
    {
		/// <summary>
		/// scalar * matrix
		/// </summary>
		/// <param name="matrix">the matrix to</param>
		/// <param name="scalar">the scalar of</param>
		/// <returns>the multiply</returns>
        public static double[,] MultiplyScalar(double[,] matrix, double scalar)
        {
			int len0 = matrix.GetLength(0);
			int len1 = matrix.GetLength(1);
			if (len != len1 || len > 3 || len < 2)
				return (new double[,] {{-1}});
			double[,] r = new double [len0, len1];
			for (int i = 0; i < len0; i++)
				for (int j = 0; j < len1; j++)
					r[i,j] = matrix[i,j] * scalar;
			return (r);
    	}
	}
