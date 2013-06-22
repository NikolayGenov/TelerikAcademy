namespace AnimalKingdom
{
    class Tomcat : Cat
    {
        public Tomcat(string name, byte age) : base(name, Sex.Male, age)
        {
        }

        public override string MakeSound()
        {
            return "Tomcat said: MEOWWWWWW Give me food";
        }
    }
}