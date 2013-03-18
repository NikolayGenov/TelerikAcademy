using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelManager.Person
{
    class GolfInstructor : Personel
    {
        public GolfInstructor(uint id, string name, decimal salary) 
            : base(id, name, salary)
        {
        }

        public void EducateClient(Client cl)
        {
            cl.EducationLevel++;
        }
    }
}
