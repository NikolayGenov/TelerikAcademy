using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolModule;

namespace SchoolTest
{
    [TestClass]
    public class SchoolTests
    {
        private string schoolName = "Telerik Academy";

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestSchoolConstructor_NullThrowException()
        {
            School nullSchool = new School(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestSchoolConstructor_WhitespaceThrowException()
        {
            School whitespaceSchool = new School("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestSchoolConstructor_BlankThrowException()
        {
            School blankSchool = new School(string.Empty);
        }

        [TestMethod]
        public void TestSchoolConstructor_Name()
        {
            School testSchool = new School(schoolName);
            Assert.AreEqual(schoolName, testSchool.Name, "School name is not set in a correct way");
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchool_AddCourseNullStudent()
        {
            School testSchoolNull = new School(schoolName);
            testSchoolNull.AddCourse(null);
        }
      
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSchool_AddCourseArgument()
        {
            School testSchool = new School(schoolName);
            Course javascript = new Course("Javascript","Nakov");
            testSchool.AddCourse(javascript);
            testSchool.AddCourse(javascript);
        }

        [TestMethod]
        public void TestSchool_AddCourse()
        {
            School testSchool = new School(schoolName);
            Course javascript = new Course("Javascript", "Nakov");
            testSchool.AddCourse(javascript);
            Assert.IsTrue(testSchool.Courses.Contains(javascript), "Course is not in the school");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestSchool_RemoveCourseNullStudent()
        {
            School testSchoolNull = new School(schoolName);
            testSchoolNull.RemoveCourse(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestSchool_RemoveCourseArgument()
        {
            School testSchool = new School(schoolName);
            Course javascript = new Course("Javascript", "Nakov");
            Course oop = new Course("OOP", "Nakov");
            testSchool.AddCourse(javascript);
            testSchool.RemoveCourse(oop);
        }

        [TestMethod]
        public void TestSchool_RemoveCourse()
        {
            School testSchool = new School(schoolName);
            Course javascript = new Course("Javascript", "Nakov");
            testSchool.AddCourse(javascript);
            testSchool.RemoveCourse(javascript);
            Assert.IsFalse(testSchool.Courses.Contains(javascript), "Course is not in the school");
        }
    }
}