using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleAppProject.App03;

namespace ConsoleApp.Tests
{
    [TestClass]
    public class StudentGradesTest
    {
        private readonly StudentGrades studentGrades = new StudentGrades();
       
        private readonly int[] StatsMarks = new int[]
        {
           10, 20, 30, 40, 50, 60, 70, 80, 90, 100
        };
        ///<Summary>
        ///This Test is used to check the Grade 
        ///for the studentGrades app
        ///<summary>
        [TestMethod]
        public void TestCovert0ToGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;
            //Act
            Grades actualGrade = studentGrades.ConvertToGrade(0);
            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        ///<Summary>
        ///This Test is used to check the Grade 
        ///for the studentGrades app
        ///<summary>
        [TestMethod]
        public void TestCovert39ToGradeF()
        {
            //Arrange
            Grades expectedGrade = Grades.F;
            //Act
            Grades actualGrade = studentGrades.ConvertToGrade(39);
            //Assert
            Assert.AreEqual(expectedGrade, actualGrade);
        }

        ///<Summary>
        ///This Test is used to check the average marks 
        ///for the studentGrades app
        ///<summary>
        [TestMethod]
        public void TestCalculateMean()
        {   
            //Arrange
            studentGrades.Marks = StatsMarks;
            //Act
            double expectedMean = 55.0;
            studentGrades.CalculateStats();
            //Assert
            Assert.AreEqual(expectedMean, studentGrades.Mean);
        }

        ///<Summary>
        ///This Test is used to check the minimum marks
        ///for the studentGrades app
        ///<summary>
        [TestMethod]
        public void TestCalculateMin()
        {
            //Arrange
            studentGrades.Marks = StatsMarks;
            int expectedMin = 10;
            //Act
            studentGrades.CalculateStats();
            //Assert
            Assert.AreEqual(expectedMin, studentGrades.Minimum);
        }

        ///<Summary>
        ///This Test is used to check the Gradeprofile
        ///for the studentGrades app
        ///<summary>
        [TestMethod]
        public void TestGradeProfile()
        {
            //Arrange
            studentGrades.Marks = StatsMarks;
            //Act
            studentGrades.CalculateGradeProfile();
            bool expectedProfile;
            expectedProfile = ((studentGrades.GradeProfile[0] == 3) &&
                               (studentGrades.GradeProfile[1] == 1) &&
                               (studentGrades.GradeProfile[2] == 1) &&
                               (studentGrades.GradeProfile[3] == 1) &&
                               (studentGrades.GradeProfile[4] == 4));
           //Assert
            Assert.IsTrue(expectedProfile);
        }

    }
}
