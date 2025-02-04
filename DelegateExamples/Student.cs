using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateExamples
{
    public delegate bool StudentDelegate(Student s);
    public class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Marks { get; set; }

        public static void PromoteStudents(List<Student> students, StudentDelegate isPromotable)
        {
            foreach (var student in students)
            {
                if (isPromotable(student))
                {
                    Console.WriteLine(student.Name + "is Promoted");
                }

            }

        }
    }
}
