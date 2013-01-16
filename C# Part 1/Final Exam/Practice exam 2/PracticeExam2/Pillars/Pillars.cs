using System;



    class Pillars
    {
        static void Main()
        {            
            byte[] matrix = new byte[8];
            byte[] countMat = new byte[8];
            for (int i = 0; i < matrix.Length; i++)
            {

                byte temp = byte.Parse(Console.ReadLine());
                matrix[i] = temp;
            }
            //collecting the info   
            for (int i = 0; i < matrix.Length; i++)
            {
                byte temp = matrix[i];
                for (int j = 0; j < matrix.Length; j++)
                {
                    if ((temp & 1) == 1)
                    {
                        countMat[j]++;

                    }
                    temp >>= 1;

                }
            }
           
           
            int result = 0;
            int resultNum = 0;
            int counter= 0;
            bool found = false ;
            for (int i = countMat.Length - 1; i >= 0; i--)
            {//the i is where we put the pillar that isn't included
               
                int leftSide = 0;

                for (int left = 0; left < counter; left++)
                {
                    leftSide += countMat[countMat.Length-1 - left];
                }

                int rightSide = 0;
                for (int right = countMat.Length -counter-1-1; right >= 0 ; right--)
                {
                    rightSide += countMat[right];
                }
                counter++; // number of moves
                if (leftSide == rightSide)
                {
                    result = i;
                    resultNum = rightSide;
                    found = true;
                    break;

                }

            }
            if (found)
            {
                Console.WriteLine(result);
                Console.WriteLine(resultNum);
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }

