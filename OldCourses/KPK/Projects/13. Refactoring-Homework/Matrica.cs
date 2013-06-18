using System;
using System.Text;

namespace GameFifteen
{
    class WalkInMatrica
    {
        static void change(ref int dx, ref int dy)
        {
            int[] directionsX = { 1, 1, 1, 0, -1, -1, -1, 0 };
			
            int[] directionsY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            int cd = 0;
            for (int count = 0; count < 8; count++)
                if (directionsX[count] == dx && directionsY[count] == dy)
                {
                    cd = count;
                    break;
                }
            if (cd == 7)
            {
                dx = directionsX[0];
                dy = directionsY[0];
                return;
            }
            dx = directionsX[cd + 1];

            dy = directionsY[cd + 1];
        }

        static bool proverka(int[,] arr, int posX, int posY)
        {
            int[] directionX = { 1, 1, 1, 0, -1, -1, -1, 0 };
            int[] directionY = { 1, 0, -1, -1, -1, 0, 1, 1 };
            for (int i = 0; i < 8; i++)
            {
                bool isOutOfRangeX = posX + directionX[i] >= arr.GetLength(0);

                if (isOutOfRangeX || posX + directionX[i] < 0)
                {
                    directionX[i] = 0;
                }
                bool isOutOfRangeY = posY + directionY[i] >= arr.GetLength(0);
                if (isOutOfRangeY || posY + directionY[i] < 0)
                {
                    directionY[i] = 0;
                }
            }
            for (int i = 0; i < 8; i++)
                if (arr[posX + directionX[i], posY + directionY[i]] == 0)
                    return true;

            return false;
        }

        static void FindZeroCell(int[,] arr, out int x, out int y)
        {
            x = 0;
            y = 0;
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(0); j++)
                {
                    if (arr[i, j] == 0)
                    {
                        x = i;
                        y = j;
                        return;
                    }
                }
            }
        }

         void Main(string[] args)
        {
            //Console.WriteLine( "Enter a positive number " );
            //string input = Console.ReadLine(  );
            //int n = 0;
            //while ( !int.TryParse( input, out n ) || n < 0 || n > 100 )
            //{
            //    Console.WriteLine( "You haven't entered a correct positive number" );
            //    input = Console.ReadLine(  );
            //} \
            int n = 6;
            Matrix matrix = new Matrix(n);
           
         
            int step = n, numberToPut = 1, row = 0, col = 0, directionX = 1, directionY = 1;
            LoopEnd(matrix, n, ref directionX, ref directionY, ref row, ref col, ref numberToPut);
            Console.WriteLine(PrintMatrix(n, matrix)); 
            FindZeroCell(matrix, out row, out col);
            if (row != 0 && col != 0)
            { // taka go napravih, zashtoto funkciqta ne mi davashe da ne si definiram out parametrite
                directionX = 1;
                directionY = 1;

                LoopEnd(matrix, n, ref directionX, ref directionY, ref row, ref col, ref numberToPut);
            }
            Console.WriteLine(PrintMatrix(n, matrix)); 
        }
  
        private static void LoopEnd(Matrix matrix, int n, ref int directionX, ref int directionY, ref int row, ref int col, ref int numberToPut)
        {
            while (true)
            { //malko e kofti tova uslovie, no break-a raboti 100% : )
                matrix.Position = numberToPut;
                if (!proverka(matrix, row, col))
                {
                    break;
                }// prekusvame ako sme se zadunili
                bool outOfMatrix = row + directionX >= n || row + directionX < 0 || col + directionY >= n || col + directionY < 0;
                bool nextStepIsZero = matrix[row + directionX, col + directionY] == 0;
                if (outOfMatrix || !nextStepIsZero)

                    while (outOfMatrix || !nextStepIsZero)
                    {
                        change(ref directionX, ref directionY);
                    }
                row += directionX;
                col += directionY;
                numberToPut++;
            }
        }
  
        private static string PrintMatrix(int n, int[,] matrix)
        {
            StringBuilder output = new StringBuilder();
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    output.AppendFormat("{0,3}", matrix[i, j]);
                }
                output.AppendLine();
            }
            return output.ToString();
        }
    }
}