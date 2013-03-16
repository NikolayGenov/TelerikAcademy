namespace AnimalKingdom
{
    class Frog : Animal
    {
        public Frog(string name, Sex sex, byte age) : base(name, sex, age)
        {
        }

        public override string MakeSound()
        {
            return "Frog said: Croak-Croak";
        }
    }
}