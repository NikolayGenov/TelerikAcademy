namespace School
{
    class Discipline : Comments
    {
        //We have a name,lectures and exercises and we can't make a new discipline before we pass everything about it
        public string Name { get; set; }

        public int NumberOfLectures { get; set; }

        public int NumberOfExercises { get; set; }

        public Discipline(string name, int numberOfLectures, int numberOfExercises)
        {
            this.Name = name;
            this.NumberOfLectures = numberOfLectures;
            this.NumberOfExercises = numberOfExercises;
        }
    }
}