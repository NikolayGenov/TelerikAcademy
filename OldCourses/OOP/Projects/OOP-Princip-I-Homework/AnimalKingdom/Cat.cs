namespace AnimalKingdom
{
    //Again abstract
    abstract class Cat : Animal
    {
        public Cat(string name, Sex sex, byte age) : base(name, sex, age)
        {
        }
    }
}