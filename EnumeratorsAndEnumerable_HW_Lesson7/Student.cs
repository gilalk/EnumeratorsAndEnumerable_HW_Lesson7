using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerable_HW_Lesson7
{
    class Student
    {
        public string Name { get; set; }
        public int Grade { get; set; }

        public Student(string name, int grade)
        {
            Name = name;
            Grade = grade;
        }
    }
}
