using System;
using System.Linq;

namespace HotelManager.Person
{
    public class Manager : Personel
    {
        public Manager(string name, decimal salary) : base(name, salary)
        {
        }

        public void HirePersonel(Personel person)
        {
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            this.WorkPlace.HirePersonel(person);
        }

        public void ReleasePersonel(uint id)
        {
            if (this.WorkPlace == null)
            {
                throw new PersonException("I'm unemployed! Please hire me!");
            }
            this.WorkPlace.ReleasePersonel(id);
        }
    }
}