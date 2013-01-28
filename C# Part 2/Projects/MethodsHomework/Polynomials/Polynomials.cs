using System;

class Polynomials
{
    static void Main()
    {
        //Some  polynomials
        int[] pol1 = { 5, 3, 5, 0, 5, 2, 1, 5 };
        int[] pol2 = { 9, 3, 2, 3, 3, 1, 4 };

        //Print them
        Console.Write("Polynomial 1: ");
        PrintPol(pol1);
        Console.Write("Polynomial 2: ");
        PrintPol(pol2);
        //Do the 3 opperations 
        AddPolynomials(pol1, pol2); 
        SubPolynomials(pol1, pol2);
        MultiplyPolynomials(pol1, pol2);
    }
  
    private static void MultiplyPolynomials(int[] pol1, int[] pol2)
    {
        //Use array to hold the coef 
        int[] mulPol = new int[(pol1.Length) + (pol2.Length) - 1];

        for (int i = 0; i < pol1.Length; i++)
        {
            for (int k = 0; k < pol2.Length; k++)
            {
                //take the coef and for each multiplication we add it to the new array on possion where they should be
                mulPol[i + k] += pol1[i] * pol2[k];
            }
        }
        Console.Write("Multiplication: ");
        PrintPol(mulPol);
    }
  
    private static void AddPolynomials(int[] pol1, int[] pol2)
    {
        //User array to hold the coef
        int[] addPol = new int[Math.Max(pol1.Length, pol2.Length)];
        //Foe each array we add the coef to the new array and then print it
        for (int i = 0; i < pol1.Length; i++)
        {
            addPol[i] = pol1[i];
        }
        for (int i = 0; i < pol2.Length; i++)
        {
            addPol[i] += pol2[i];
        }
        Console.Write("Addition: ");
        PrintPol(addPol);
    }

    private static void SubPolynomials(int[] pol1, int[] pol2)
    {
        //The same but we substract from the first and then print
        int[] subPol = new int[Math.Max(pol1.Length, pol2.Length)];

        for (int i = 0; i < pol1.Length; i++)
        {
            subPol[i] = pol1[i];
        }
        for (int i = 0; i < pol2.Length; i++)
        {
            subPol[i] -= pol2[i];
        }
        Console.Write("Subtraction: ");
        PrintPol(subPol);
    }
  
    private static void PrintPol(int[] addPol)
    {
        //Just print the arrays with x on some power 
        for (int i = addPol.Length - 1; i >= 0; i--)
        {
            Console.Write("{0}x^{1} ", addPol[i], i);
            if (i != 0)
            {
                Console.Write("+ ");
            }
        }
        Console.WriteLine();
        Console.WriteLine();
    }
}
    
