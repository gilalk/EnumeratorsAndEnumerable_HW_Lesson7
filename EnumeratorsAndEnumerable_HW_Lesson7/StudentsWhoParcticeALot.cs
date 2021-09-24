using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumeratorsAndEnumerable_HW_Lesson7
{
    class StudentsWhoParcticeALot : IEnumerable<Student>
    {
        List<Student> students = new List<Student>();

        public void AddStudentToList(Student student)
        {
            this.students.Add(student);
        }

        public IEnumerator<Student> GetEnumerator()
        {
            for (int i = 0; i < students.Count; i++)
            {
                if(students[i].Grade >= 100)
                {
                    yield return students[i];
                }
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
