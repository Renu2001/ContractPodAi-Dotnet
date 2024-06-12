using NUnit.Framework;

namespace StudentGrades.nUnitTests
{
    public class GradeCalculatorTests
    {

        private GradeCalculator _gradeCalculate { get; set; } = null;
        [SetUp]
        public void Setup()
        {
            _gradeCalculate = new GradeCalculator();
        }

        [Test]
        public void GetGrade_EqualTest()
        {
            var grade = _gradeCalculate.GetGrade(percent);
            Assert.Pass("A" , grade);
        }
    }

    
}