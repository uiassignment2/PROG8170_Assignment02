using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PROG8170_Assignment02;
using NUnit.Framework;
namespace PROG8170_Assignment02.Test
{
    [TestFixture]
    public class TriangleSolverTest
    {
        [Test]
        public void AnalyzeTest_input_10_10_10_Expect_Equilateral()
        {
            // Arrange 
            int s1 = 10;
            int s2 = 10;
            int s3 = 10;
            // Act
            string response = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(response, "Equilateral");
        }

        [Test]
        public void AnalyzeTest_input_100_100_100_Expect_Equilateral()
        {
            // Arrange 
            int s1 = 100;
            int s2 = 100;
            int s3 = 100;
            // Act
            string response = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(response, "Equilateral");
        }


        [Test]
        public void AnalyzeTest_input_10_10_20_Expect_Isosceles()
        {
            // Arrange 
            int s1 = 10;
            int s2 = 10;
            int s3 = 20;
            // Act
            string response = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(response, "Isosceles");
        }

        [Test]
        public void AnalyzeTest_input_150_150_20_Expect_Isosceles()
        {
            // Arrange 
            int s1 = 150;
            int s2 = 150;
            int s3 = 20;
            // Act
            string response = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(response, "Isosceles");
        }

        [Test]
        public void AnalyzeTest_input_10_20_30_Expect_Scalene()
        {
            // Arrange 
            int s1 = 10;
            int s2 = 20;
            int s3 = 30;
            // Act
            string response = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(response, "Scalene");
        }

        [Test]
        public void AnalyzeTest_input_1500_2000_2500_Expect_Scalene()
        {
            // Arrange 
            int s1 = 1500;
            int s2 = 2000;
            int s3 = 2500;
            // Act
            string response = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(response, "Scalene");
        }


        [Test]
        public void AnalyzeTest_input_0_10_10_Expect_Not_a_triangle()
        {
            // Arrange 
            int s1 = 0;
            int s2 = 10;
            int s3 = 10;
            // Act
            string response = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(response, "Not a triangle");
        }

        [Test]
        public void AnalyzeTest_input_0_0_0_Expect_Not_a_triangle()
        {
            // Arrange 
            int s1 = 0;
            int s2 = 0;
            int s3 = 0;
            // Act
            string response = TriangleSolver.Analyze(s1, s2, s3);
            //Assert
            Assert.AreEqual(response, "Not a triangle");
        }

    }
}
