using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanProject
{
    class Worker : Human
    {
        public decimal WeekSalary { get; set; }

        public decimal WorkHoursPerDay { get; set; }

        public Worker(string firstName, string lastName, decimal weekSalary, decimal workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal MoneyPerHour(byte workDays =5)
        {
            decimal moneyPerHour = WeekSalary / (WorkHoursPerDay * workDays);
            return moneyPerHour;
        }

        public override string ToString()
        {
            StringBuilder info = new StringBuilder();
            info.Append(base.ToString());
            info.AppendLine(string.Format("Money per hour: {0:##.###} ", this.MoneyPerHour()));
            return info.ToString();
        }
    }
}