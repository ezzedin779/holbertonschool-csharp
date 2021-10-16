using System;

	/// <summary>
	/// the matrix calculations
	/// </summary>
    class MatrixMath
    {
		
        public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
        {
			int len = matrix1.GetLength(0);
			if (len != matrix1.GetLength(1) || len > 3 || len < 2 || len != matrix2.GetLength(0))
				return (new double[,] {{-1}});
			double[,] r = new double [len, len];
			for (int i = 0; i < len; i++)
				for (int j = 0; j < len; j++)
					r[i,j] = matrix1[i,j] * matrix2[i,j];
			return (r);
    	}
	}
