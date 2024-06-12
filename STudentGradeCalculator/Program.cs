namespace STudentGradeCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var gradeCalc =new GradeCalculator();

            Console.WriteLine("Enter Percent");
            var percent =Convert.ToInt32(Console.ReadLine());

            var grade = gradeCalc.GetGrade(percent);

            Console.WriteLine("Student Grade" + grade);
        }
    }
}
