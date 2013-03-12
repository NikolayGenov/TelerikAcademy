using System.Collections.Generic;

namespace School
{
    class Teacher : Person
    {
        private List<Discipline> listDisciplines = new List<Discipline>();

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void AddDiscipline(Discipline discipline)
        {
            this.listDisciplines.Add(discipline);        
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.listDisciplines.Remove(discipline);
        }
    }
}