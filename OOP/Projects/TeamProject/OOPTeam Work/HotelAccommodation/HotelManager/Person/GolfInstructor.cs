using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
