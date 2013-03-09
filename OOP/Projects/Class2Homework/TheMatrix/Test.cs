using System;
using System.Linq;

namespace TheMatrix
{
    class Test
    {
        static void Main(string[] args)
        {
            //First create some matrixes
            Matrix<int> mat1 = new Matrix<int>(3,3);
            Matrix<int> mat2 = new Matrix<int>(3,3);
            //Generate some random values between 0 and 8
            mat1.GenerateRandomValues(0, 8);
            mat2.GenerateRandomValues(0, 8);

            //Print them
            Console.WriteLine("Matrix 1:");
            Console.Write(mat1.ToString());
            Console.WriteLine("Matrix 2:");
            Console.Write(mat2.ToString());

            //Add the two  
            Matrix<int> matResult = mat1 + mat2;
            Console.WriteLine("Matrix Result '+' :");
            Console.Write(matResult.ToString());

            //Subtraction   
            matResult = mat1 - mat2;
            Console.WriteLine("Matrix Result '-' :");
            Console.Write(matResult.ToString());

            //Multiplication
            matResult = mat1 * mat2;
            Console.WriteLine("Matrix Result '*' :");
            Console.Write(matResult.ToString());
            
            //Check for zero elements
            if (mat1)
            {
                Console.WriteLine("Contains only non zero elements");
            }
            else
            {
                Console.WriteLine("Contains zero elements");
            }
            Console.WriteLine();
            Console.WriteLine("Doubles: ");

            //Test for double and multiplication for not square matrix
            Matrix<double> mat3 = new Matrix<double>(4,2);
            Matrix<double> mat4 = new Matrix<double>(2, 4);
            //Generate some random values between 0 and 8
            mat3.GenerateDoubleRandomValues(0, 8);
            mat4.GenerateDoubleRandomValues(0, 8);

            //Print them
            Console.WriteLine("Matrix 3:");
            Console.Write(mat3.ToString());
            Console.WriteLine("Matrix 4:");
            Console.Write(mat4.ToString());

            //Multiplication 4x2 * 2x4    --->> 4x4 matrix  
            Matrix<double> matResultFloat = mat3 * mat4;
            Console.WriteLine("Matrix Result '*' for double :");
            Console.Write(matResultFloat.ToString());
        }
    }
}