using System;

namespace EnumeratorsAndEnumerable_HW_Lesson7
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Q1 - Series from 10 to 100 with for loop

            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(i * 10);
            }

            #endregion

            #region Q2 - Series from 10 to 100 with foreach loop

            int[] arrInt = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            foreach (var item in arrInt)
            {
                Console.WriteLine(item * 10);
            }

            #endregion

            #region Q3 - Series of first 10 powers using IEnumerable

            var powers = new First10Powers(10);
            foreach (var item in powers)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region Q4 - Series of excellent studens (grade more than 100)

            Student s1 = new Student("Gil", 123);
            Student s2 = new Student("Avia", 131);
            Student s3 = new Student("Ziv", 102);
            Student s4 = new Student("Dani", 98);
            Student s5 = new Student("Eli", 80);

            StudentsWhoParcticeALot students = new StudentsWhoParcticeALot();
            students.AddStudentToList(s1);
            students.AddStudentToList(s2);
            students.AddStudentToList(s3);
            students.AddStudentToList(s4);
            students.AddStudentToList(s5);

            foreach (var student in students)
            {
                Console.WriteLine(student.Name + " " + student.Grade);
            }

            #endregion

        }
    }
}
