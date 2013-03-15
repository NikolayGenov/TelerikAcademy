using System.Collections.Generic;
using System.Text;

namespace School
{
    class Teacher : Person
    {
        //Every teacher have set of disciplines that can teach
        private readonly List<Discipline> listDisciplines = new List<Discipline>();

        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        //Some methods
        public void AddDiscipline(Discipline discipline)
        {
            this.listDisciplines.Add(discipline);        
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            this.listDisciplines.Remove(discipline);
        }

        //Print all the information about the teacher
        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.AppendLine(string.Format("Teacher names: {0} {1}", this.FirstName, this.LastName));
            if (this.listDisciplines.Count != 0)
            {
                info.AppendLine("Disciplines:");
                foreach (Discipline discipline in this.listDisciplines)
                {
                    info.AppendLine(string.Format("Topic: {0}, Lectures: {1}, Exercises:{2}", discipline.Name, discipline.NumberOfLectures, discipline.NumberOfExercises));
                }
            }
            if (this.Comment != null)
            {
                info.AppendLine("Comment about the teacher: " + this.Comment);
            }
            return info.ToString();
        }
    }
}