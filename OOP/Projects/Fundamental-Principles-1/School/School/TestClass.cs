using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School
{
    class TestClass
    {
        static void Main()
        {
            School telerikAcademy = new School("Telerik Academy");
            Class OOP = new Class("OOP & Stuff");
            telerikAcademy.AddClass(OOP);
            Student student1 = new Student("Pesho", "Peshov", 1001);
            
        }
    }
}