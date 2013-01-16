using System;


    class FirTree
    {
        static void Main()
        {
            const string star = "*";
            const string dot = ".";
            int n = int.Parse(Console.ReadLine());
          
            int counter = 0;

            for (int i = 0; i < n-1; i++)
            {
                counter = 0;
                for (int j = 0; j<  n-1; j++)
                {
                    if (j +i> n-3)
                    {

                        Console.Write(star); 
                    }
                    else
                    {
                        Console.Write(dot);

                    }
                    
                }
                for (int j = 0; j < n -2; j++)
                {
                    if (j <i)
                    {

                        Console.Write(star);
                    }
                    else
                    {
                        Console.Write(dot);

                    }
                    counter++;
                }
                Console.WriteLine();
                
            }
            
                for (int j = 0; j < counter; j++)
                {
                    Console.Write(dot);
                }
                Console.Write(star);
                for (int j = 0; j < counter; j++)
                {
                    Console.Write(dot);
                }
                Console.WriteLine();
                
            
            //last line 

        }
    }

