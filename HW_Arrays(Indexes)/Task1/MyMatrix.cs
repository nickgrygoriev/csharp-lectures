using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class MyMatrix
    {
        int[,] matrix;

        public MyMatrix(int rows, int cols)
        {
            matrix = new int[rows, cols];
            InitMatrix(rows, cols);
        }

        public int this[int i, int j]
        {
            get { return matrix[i, j]; }
            set { matrix[i, j] = value; }
        }

        public void ChangeSize(int rows, int cols)
        {
            int[,] oldMatrix = matrix;
            matrix = new int[rows, cols];
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (i >= oldMatrix.GetLength(0) || j >= oldMatrix.GetLength(1))
                        matrix[i, j] = 0;
                    else
                        matrix[i, j] = oldMatrix[i, j];
                }
            }
        }

        public void Output()
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        void InitMatrix(int rows, int cols){
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    matrix[i, j] = 1;
                }
            }
        }
    }
}
