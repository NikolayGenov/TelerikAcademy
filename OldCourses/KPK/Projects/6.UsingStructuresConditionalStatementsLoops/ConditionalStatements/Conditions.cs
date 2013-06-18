using System;

class Conditions
{
    static void Main()
    { 
        //Potato condition
        Potato potato;
        //... 
        if (potato != null)
        {
            if (!potato.IsRotten && potato.HasBeenPeeled)
            {
                Cook(potato);
            }
            else
            {
                throw new ArgumentException("Potato is not good to be cooked");
            }
        }
        else
        {
            throw new ArgumentNullException("There is no potato");
        }

        //Range Condition
        bool isInRange = (MIN_X <= x && x <= MAX_X) &&
                         (MIN_Y <= y && y <= MAX_Y);
        if (canVisitCell && isInRange)
        {
            VisitCell();
        }
    }
}