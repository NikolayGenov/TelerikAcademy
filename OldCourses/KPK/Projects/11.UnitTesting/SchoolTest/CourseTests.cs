using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SchoolModule;
using System.Text;

namespace SchoolTest
{
    [TestClass]
    public class CourseTests
    {
        private readonly string teacherName = "Nakov";
        private readonly string courseName = "Javascript";

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestCourseConstructor_NullNameThrowException()
        {
            Course nullCourse = new Course(null, teacherName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestCourseConstructor_NullTeacherThrowException()
        {
            Course jsCourse = new Course(courseName, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestCourseConstructor_NullThrowException()
        {
            Course nullCourse = new Course(null, null);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestCourseConstructor_WhitespaceNameThrowException()
        {
            Course whitespaceCourse = new Course("   ", teacherName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestCourseConstructor_WhitespaceTeacherThrowException()
        {
            Course whitespaceTeacherCourse = new Course(courseName, "   ");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestCourseConstructor_BlankNameThrowException()
        {
            Course blankCourse = new Course(string.Empty, teacherName);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]

        public void TestCourseConstructor_BlankTeacherThrowException()
        {
            Course blankTeacherCourse = new Course(courseName, string.Empty);
        }

        [TestMethod]
        public void TestCourseConstructor_Name()
        {
            Course testCourse = new Course(courseName,teacherName);
            Assert.AreEqual(courseName, testCourse.Name, "Course with that name has not been created correctly");
        }

        [TestMethod]
        public void TestCourseConstructor_Teacher()
        {
            Course testCourse = new Course(courseName, teacherName);
            Assert.AreEqual(teacherName, testCourse.TeacherName, "Course with that teacher has not been created correctly");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourse_AddStudentNullStudent()
        {
            Course testCourseNull = new Course(courseName, teacherName);
            testCourseNull.AddStudent(null);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidOperationException))]
        public void TestCourse_AddStudentInvalidOperation()
        {
            Course testCourseInvalid = new Course(courseName, teacherName);
            for (int i = 0; i < Course.MaxStudentsInClass + 1; i++)
            {
                Student student = new Student("Gosho");
                testCourseInvalid.AddStudent(student);
            }
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourse_AddStudentArgument()
        {
            Course testCourse = new Course(courseName, teacherName);
            Student studentGosho = new Student("Gosho");
            testCourse.AddStudent(studentGosho);
            testCourse.AddStudent(studentGosho);
        }

        [TestMethod]
        public void TestCourse_AddStudent()
        {
            Course course = new Course(courseName, teacherName);
            Student pesho = new Student("Pesho");
            course.AddStudent(pesho);
            Assert.IsTrue(course.Students.Contains(pesho), "Student is not in the course");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void TestCourse_RemoveStudentNullStudent()
        {
            Course testCourseNull = new Course(courseName, teacherName);
            testCourseNull.RemoveStudent(null);
        }
     
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourse_RemoveStudentArgumentNone()
        {
            Course testCourse = new Course(courseName, teacherName);
            Student gosho = new Student("Gosho");
            testCourse.RemoveStudent(gosho);
        }
        
        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestCourse_RemoveStudentArgument()
        {
            Course testCourse = new Course(courseName, teacherName);
            Student gosho = new Student("Gosho");
            Student pesho = new Student("Gosho");
            testCourse.AddStudent(gosho);
            testCourse.RemoveStudent(pesho);
        }

        [TestMethod]
        public void TestCourse_RemoveStudent()
        {
            Course course = new Course(courseName, teacherName);
            Student pesho = new Student("Pesho");
            course.AddStudent(pesho);
            course.RemoveStudent(pesho);
            Assert.IsFalse(course.Students.Contains(pesho), "Student is still in the course");
        }

        [TestMethod]
        public void TesttCourse_ToString()
        {
            Course course = new Course(courseName, teacherName);
            Student pesho = new Student("Pesho");
            course.AddStudent(pesho);
            //Student StringBuilder
            StringBuilder studentStr = new StringBuilder();
            studentStr.AppendFormat("Name: Pesho, Id: {0}", pesho.Id).AppendLine();
            //Course StringBUilder
            StringBuilder message = new StringBuilder();
            message.AppendLine("------COURSE-INFO-------");
            message.AppendLine("Name = Javascript, Teacher = Nakov ");
            message.AppendFormat("Students: \n{0}", studentStr.ToString());
            message.AppendLine("------END-COURSE-INFO-------");
            Assert.AreEqual(message.ToString(), course.ToString(), "Strings don't match");
        }
    }
}