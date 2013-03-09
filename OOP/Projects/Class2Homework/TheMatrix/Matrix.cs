using System;
using System.Linq;
using System.Text;

namespace TheMatrix
{
    public class Matrix <T>
    {
        //Fields 
        private T[,] elements;
        private int length;
        private int width;

        //Properties
        public int Width
        {
            get
            {
                return width;
            }
            set
            {
                width = value;
            }
        }
        
        public int Length
        {
            get
            {
                return length;
            }
            set
            {
                length = value;
            }
        }

        //Constructor
        public Matrix(int width, int length)
        {
            this.Width = width;
            this.Length = length;
            elements = new T[Width, Length];
        }

        //Access the elements
        public T this[int i,int j]
        {
            get
            {
                return elements[i, j];
            }
            set
            {
                this.elements[i, j] = value;
            }
        }

        //Create one method to reuse the code 
        //Here depending on the case - first chech the sizes and if they match add/sub elements each position
        private static Matrix<T> PlusOrMinus(Matrix<T> matrix1, Matrix<T> matrix2, bool add)
        {
            if ((matrix1.Width == matrix2.Width) && (matrix1.Length == matrix2.Length))
            {
                int sign = add ? 1 : -1;
                Matrix<T> result = new Matrix<T>(matrix1.Width, matrix1.Length);
                for (int i = 0; i < matrix1.Width; i++)
                {
                    for (int j = 0; j < matrix1.Length; j++)
                    {
                        result[i, j] = matrix1[i, j] + sign * (dynamic)(matrix2[i, j]);
                    }
                }
                return result;
            }
            else
            {
                //If the sizes doesn't match - throw exception
                throw new ArgumentException("The size of the two matrixes don't match");
            }
        }

        public static Matrix<T> operator +(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            return PlusOrMinus(matrix1, matrix2, add:true);
        }
  
        public static Matrix<T> operator -(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            return PlusOrMinus(matrix1, matrix2, add: false);
        }

        //For the mult - first check the requared sizes and then using some formulas create the loops
        public static Matrix<T> operator *(Matrix<T> matrix1, Matrix<T> matrix2)
        {
            if (matrix1.Length == matrix2.Width)
            {
                Matrix<T> result = new Matrix<T>(matrix1.Width, matrix2.Length);

                for (int i = 0; i < result.Width; i++)
                {
                    for (int j = 0; j < result.Length; j++)
                    {
                        result[i, j] = default(T);
                        for (int k = 0; k < matrix1.Length; k++) 
                            result[i, j] = result[i, j] + matrix1[i, k] * (dynamic)matrix2[k, j];
                    }
                }
                return result;
            }
            else
            {
                throw new ArgumentException("The first matrix second param should be equal to the second matrix first param");
            }
        }

        //Using those methods to generate random values for the matrixes
        
        public void GenerateDoubleRandomValues(T min, T max)
        {
            Random random = new Random();
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < this.Length; j++)
                {
                    this.elements[i, j] = random.NextDouble() * (max - (dynamic)min) + min;
                }
            }
        }

        public void GenerateRandomValues(T min, T max)
        {
            Random rnd = new Random();
            for (int i = 0; i < Width; i++)
            {
                for (int j = 0; j < this.Length; j++)
                {
                    this.elements[i, j] = rnd.Next((dynamic)min, (dynamic)max);
                }
            }
        }

        //In order to reuse the code  we create this method and check for reach element if it's zero and if is we return the opposite of what we've given
        private static bool BoolOverload(Matrix<T> mat, bool booleanCase)
        {
            for (int i = 0; i < mat.Width; i++)
            {
                for (int j = 0; j < mat.Length; j++)
                {
                    if ((dynamic)mat[i, j] == 0)
                    {
                        return !booleanCase;
                    }
                }
            }
            return booleanCase;
        }
        
        //Implement them using that method
        public static bool operator true(Matrix<T> mat)
        {
            return BoolOverload(mat, true);
        }

        public static bool operator false(Matrix<T> mat)
        {
            return BoolOverload(mat, false);
        }

        //Print the matrix overriding the ToString
        public override string ToString()
        {
            StringBuilder text = new StringBuilder();
            text.AppendLine(new string('-', 20));
            for (int i = 0; i < this.Width; i++)
            {
                for (int j = 0; j < this.Length; j++)
                {
                    text.AppendFormat("{0} ", this.elements[i, j]);
                }
                text.AppendLine();
            }
            text.AppendLine(new string('-', 20));
            return text.ToString();
        }
    }
}