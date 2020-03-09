using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s = new Student
            {
                FullName = "Jane Doe",
                DateOfBirth = DateTime.Today,
                GradePointAverage = 3.5
            };

            Student s2 = new Student
            {
                FullName = "John Doe",
                DateOfBirth = DateTime.Today,
                GradePointAverage = 4
            };

            List<Student> roster = new List<Student>()
            {
                s2, s
            };
            roster.Sort(new StudentAgeCompare());

            roster = (from stu in roster
                      orderby stu.DateOfBirth descending
                      select stu).ToList();

            var courses = new List<string>
            {
                "CPW 101",
                "CPW 150",
                "CPW 118"
            };

            RegisterPErson(s, courses);
            Console.ReadKey();
        }

        private static void RegisterPErson(IRegistrable registrable, List<string> courses)
        {
            registrable.Register(courses);
        }
    }
}
