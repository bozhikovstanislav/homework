using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace _3DPoints
{
   [Custm_Atribut(2,11)]
   public class Matrix<T> 
  
    {
        private T[,] array;
        private int col;
        private int row;
       
        public Matrix(int coll,int row)
        {
            array = new T[coll,row];
            this.row = row;
            this.col = coll;
        }
        public Matrix()
        {
            
        }
        public int Col
        {
            get { return col; }
            set { col = value; }
        }
        public int Row
        {
            get { return row; }
            set { row = value; }
        }
        public T this[int row, int coll]
        {
            get
            {

                if (row >= 0 && row < array.Length && coll>= 0 && coll < array.Length)
                {
                    return array[row, coll];
                }
                else
                {
                    throw new IndexOutOfRangeException(
                             String.Format("Invalid index {0},{1}", row,coll));
                }
            }
            set
            {
                setItem(coll,row,value);
            }
        }
        public T getItem(int coll, int row)
        {
            return array[coll,row];
        }
        public void setItem(int coll,int row, T value)
        {
            array[coll,row] = value;
        }
       
        public  T Min<T>()
        where T :IComparable<T>
        {
         object min=getItem(0,0);
            T miin1=(T)min;
            for (int i = 0; i < Row; i++)
            {
                for (int k = 0; k <Col ; k++)
                {
                    object value=getItem(i,k);
                    T value1=(T)value;
                    if(value1.CompareTo(miin1)<0)
                    {
                        miin1 = value1;
                    }
                }
            }
            return (T)miin1;
        }
        public  T Max<T>()
             where T : IComparable<T>
        {
            object min = getItem(0, 0);
            T miin1 = (T)min;
            for (int i = 0; i < Row; i++)
            {
                for (int k = 0; k < Col; k++)
                {
                    object value = getItem(i, k);
                    T value1 = (T)value;
                    if (value1.CompareTo(miin1) > 0)
                    {
                        miin1 = value1;
                    }
                }
            }
            return (T)miin1;
        }
        public void add(Matrix<T> matr)
        {
            
        }
       [Custm_Atribut(1,2)]
        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
           
        {

            try
            {
                int row = matrix1.Row;
                int coll = matrix1.Col;
                Matrix<T> newmatrix = new Matrix<T>(coll, row);

                for (int i = 0; i < coll; i++)
                {
                    for (int k = 0; k < row; k++)
                    {
                        dynamic matr1 = matrix1[k, i];
                        dynamic matr2 = matrix2[k, i];
                        newmatrix[i, k] = matr2 + matr1;
                    }
                }
                return newmatrix;
            }
            catch (ApplicationException e)
            {

                throw new IndexOutOfRangeException(
                            String.Format("Error massage {0}", e.Message));
            }
            
           
        }
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            try
            {
                int row = matrix1.Row;
                int coll = matrix1.Col;
                Matrix<T> newmatrix = new Matrix<T>(coll, row);

                for (int i = 0; i < coll; i++)
                {
                    for (int k = 0; k < row; k++)
                    {
                        dynamic matr1 = matrix1[k, i];
                        dynamic matr2 = matrix2[k, i];
                        newmatrix[i, k] = matr2 - matr1;
                    }
                }
                return newmatrix;
            }
            catch (ApplicationException e)
            {

                throw new IndexOutOfRangeException(
                            String.Format("Error massage {0}", e.Message));
            }
            
        }
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            try
            {
                int row = matrix1.Row;
                int coll = matrix1.Col;
                Matrix<T> newmatrix = new Matrix<T>(coll, row);

                for (int i = 0; i < coll; i++)
                {
                    for (int k = 0; k < row; k++)
                    {
                        dynamic matr1 = matrix1[k, i];
                        dynamic matr2 = matrix2[k, i];
                        newmatrix[i, k] = matr2 * matr1;
                    }
                }
                return newmatrix;
            }
            catch (ApplicationException e)
            {

                throw new IndexOutOfRangeException(
                            String.Format("Error massage {0}", e.Message));
            }
            
            
        }
       [Custm_Atribut(1, 9)]
        public static bool operator true(Matrix<T> matrix1)
        {
            int row = matrix1.Row;
            int coll = matrix1.Col;
            return matrix1[coll,row]!=null;
        }
        public static bool operator false(Matrix<T> matrix1)
        {
            int row = matrix1.Row;
            int coll = matrix1.Col;
            return matrix1[coll, row] == null;
        }
    }
}
