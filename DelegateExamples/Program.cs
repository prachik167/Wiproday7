namespace DelegateExamples
{
    class Program
    {
        public static void Main(string[] args)
        {
            List<Student> students = new List<Student>()
            {
                new Student() {Id = 1, Name ="ABC", Marks = 80 },
                new Student() {Id = 2, Name ="DEF", Marks =70 },
                new Student() {Id = 3, Name = "GHI", Marks =90 }
            };

            StudentDelegate studentDelegate = new StudentDelegate(IsEligible);
            Student.PromoteStudents(students, studentDelegate);

        }

        static bool IsEligible(Student student)
        {
            return student.Marks > 75;
        }
    }
}
