namespace HotelManager.Person
{
    class GolfInstructor : Personel
    {
        public GolfInstructor(string name, decimal salary) : base(name, salary)
        {
        }

        public void EducateClient(Client cl)
        {
            cl.EducationLevel++;
        }
    }
}