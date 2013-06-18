
namespace AnimalKingdom
{
    class Dog : Animal
    {
        public Dog(string name, Sex sex, byte age) : base(name, sex, age)
        {
        }

        public override string MakeSound()
        {
            return "Dog said: Bau-Bau";
        }
    }
}