using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfacesExample
{
    interface IRegistrable
    {
        void Register(IEnumerable<String> courseCodes);
    }

    [DebuggerDisplay("{FullName,nq} {GradePointAverage}")]
    public class Student : IRegistrable, IComparable<Student>
    {
        public string FullName { get; set; }

        public DateTime DateOfBirth { get; set; }

        public double GradePointAverage { get; set; }

        public int CompareTo(Student other)
        {
            if (other == null)
            {
                return 1;
            }
            return GradePointAverage.CompareTo(other.GradePointAverage);
            //if (this.GradePointAverage < other.GradePointAverage)
            //{
            //    return -1;
            //}
            //else if (GradePointAverage == other.GradePointAverage)
            //{
            //    return 0;
            //}
            //else
            //{
            //    return 1;
            //}
        }

        public void Register(IEnumerable<string> codes)
        {
            foreach (string code in codes)
            {
                Console.WriteLine("Registered for " + code);
            }
        }
    }

    public class StudentAgeCompare : IComparer<Student>
    {
        public int Compare(Student x, Student y) => x.DateOfBirth.CompareTo(y.DateOfBirth);
    }
}
