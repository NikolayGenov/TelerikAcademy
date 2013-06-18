using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolModule;

namespace SchoolTest
{
    [TestClass]
    public class StudentTests
    {
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestStudentConstructor_NullThrowException()
        {
            Student nullStudent = new Student(null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestStudentConstructor_WhitespaceThrowException()
        {
            Student whitespaceStudent = new Student("   ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestStudentConstructor_BlankThrowException()
        {
            Student blankStudent = new Student(string.Empty);
        }

        [TestMethod]
        public void TestStudentConstructor_Name()
        {
            Student testStudent = new Student("Gosho Peshov");
            Assert.AreEqual("Gosho Peshov", testStudent.Name, "Student name is not set in a correct way");
        }

        [TestMethod]
        public void TestStudentConstructor_Id()
        {
            Student testStudentId = new Student("Pesho");
            Assert.IsTrue((Student.MinIdNumber < testStudentId.Id && Student.MaxIdNumber > testStudentId.Id), "Id is not set in a correct way");
        }
      
        [TestMethod]
        public void TestStudentConstructor_CompareId()
        {
            Student testStudentOne = new Student("Pesho");
            Student testStudentTwo = new Student("Gosho");
            Assert.IsTrue((testStudentOne.Id == (testStudentTwo.Id - 1)), "Id of the two students is not set in a correct way");
        }

        [TestMethod]
        public void TestStudent_JoinCourse()
        {
            Student testStudentOne = new Student("Pesho");
            Course javascript = new Course("Javascript Course", "Nakov");
            testStudentOne.JoinCourse(javascript);
            Assert.IsTrue(javascript.Students.Contains(testStudentOne), "Student has not been included in the course");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudent_JoinCourseNull()
        {
            Student testStudentOne = new Student("Pesho");
            testStudentOne.JoinCourse(null);
        }

        [TestMethod]
        public void TestStudent_LeaveCourse()
        {
            Student testStudentOne = new Student("Pesho");
            Course javascript = new Course("Javascript Course", "Nakov");
            testStudentOne.JoinCourse(javascript);
            testStudentOne.LeaveCourse(javascript);
            Assert.IsFalse(javascript.Students.Contains(testStudentOne), "Student has not been removed in the course");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestStudent_LeaveCourseNull()
        {
            Student testStudentOne = new Student("Pesho");
            Course javascript = new Course("Javascript Course", "Nakov");
            testStudentOne.JoinCourse(javascript);
            testStudentOne.LeaveCourse(null);
        }

        [TestMethod]
        public void TestStudent_ToString()
        {
            Student testStudentString = new Student("Pesho");
            Assert.AreEqual(string.Format("Name: {0}, Id: {1}", testStudentString.Name, testStudentString.Id), testStudentString.ToString());
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestStudentConstructor_IdOutOfRange()
        {
            //The last student that is created in the loop have ID bigger than the maxID and the proprty throws an exception
            for (int i = Student.MinIdNumber; i < Student.MaxIdNumber; i++)
            {
                Student testStudentIdOutOfRange = new Student("Pesho");
            }
           
        }
    }
}