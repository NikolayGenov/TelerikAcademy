namespace AnimalKingdom
{
    class Kitten : Cat
    {
        public Kitten(string name, byte age) : base(name, Sex.Male, age)
        {
        }

        public override string MakeSound()
        {
            return "Kitten: Meow-meow meow";
        }
    }
}