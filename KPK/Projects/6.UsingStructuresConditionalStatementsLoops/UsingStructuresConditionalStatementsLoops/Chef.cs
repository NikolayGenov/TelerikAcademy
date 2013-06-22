using System;

public class Chef
{
    private Carrot GetCarrot()
    {
        //...
    }

    private Potato GetPotato()
    {
        //...
    }

    private void Peel(Vegetable vegetable)
    {
        //...
    }

    private void Cut(Vegetable vegetable)
    {
        //...
    }
        
    private Bowl GetBowl()
    {
        //... 
    }
        
    public void Cook()
    {
        Carrot carrot = GetCarrot();
        Peel(carrot);
        Cut(carrot);
          
        Potato potato = GetPotato();
        Peel(potato);
        Cut(potato);

        Bowl bowl = GetBowl();
        bowl.Add(carrot);
        bowl.Add(potato);
    }
}
