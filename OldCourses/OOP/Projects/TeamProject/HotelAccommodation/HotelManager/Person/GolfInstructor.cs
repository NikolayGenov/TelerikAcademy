using System.Text;

namespace HotelManager.Person
{
    class GolfInstructor : Personel
    {
        public GolfInstructor(string name, decimal salary) : base(name, salary)
        {
        }

        public string EducateClient(Client client)
        {
            client.EducationLevel++;
            return string.Format("{0} has educated client {1} to level {2} of golf", this.Name, client.Name, client.EducationLevel);
        }
    }
}