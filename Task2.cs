using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace Operators_reload
{
    public class Matrix
    {
        private int[,] data;

        public int Rows
        {
            get { return data.GetLength(0); }
        }

        public int Columns
        {
            get { return data.GetLength(1); }
        }

        public Matrix(int rows, int columns)
        {
            data = new int[rows, columns];
        }

        public int this[int row, int column]
        {
            get { return data[row, column]; }
            set { data[row, column] = value; }
        }
                
        public static Matrix operator +(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)                
                    result[i, j] = matrix1[i, j] + matrix2[i, j];               
            }
            return result;
        }

        public static Matrix operator -(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new Matrix(matrix1.Rows, matrix1.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)                
                    result[i, j] = matrix1[i, j] - matrix2[i, j];                
            }
            return result;
        }

        public static Matrix operator *(Matrix matrix, int scalar)
        {
            Matrix result = new Matrix(matrix.Rows, matrix.Columns);

            for (int i = 0; i < matrix.Rows; i++)
            {
                for (int j = 0; j < matrix.Columns; j++)
                {
                    result[i, j] = matrix[i, j] * scalar;
                }
            }
            return result;
        }

        public static Matrix operator *(Matrix matrix1, Matrix matrix2)
        {
            Matrix result = new Matrix(matrix1.Rows, matrix2.Columns);

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix2.Columns; j++)
                {
                    for (int k = 0; k < matrix1.Columns; k++)                    
                        result[i, j] += matrix1[i, k] * matrix2[k, j];                    
                }
            }
            return result;
        }
        public static bool operator ==(Matrix matrix1, Matrix matrix2)
        {
            if (matrix1.Rows != matrix2.Rows || matrix1.Columns != matrix2.Columns)            
                return false;            

            for (int i = 0; i < matrix1.Rows; i++)
            {
                for (int j = 0; j < matrix1.Columns; j++)
                {
                    if (matrix1[i, j] != matrix2[i, j])                    
                        return false;                    
                }
            }
            return true;
        }

        public static bool operator !=(Matrix matrix1, Matrix matrix2)
        {
            return !(matrix1 == matrix2);
        }

        public override bool Equals(object obj)
        {
            if (obj == null || !(obj is Matrix))            
                return false;            

            Matrix other = (Matrix)obj;
            return this == other;
        }
        public override int GetHashCode()
        {
            int hash = 0;

            for (int i = 0; i < Rows; i ++)
            {
                for (int j = 0; j < Columns; j++)                
                    hash ^= data[i, j];                
            }
            return hash;
        }
    }

}
