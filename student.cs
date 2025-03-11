using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{
   
        internal class Student
        {
            public int StudentID;
            public string Name;
            public List<int> Grades;

            public Student(int id, string name, List<int> grades)
            {
                StudentID = id;
                Name = name;
                Grades = grades;
            }
            public double CalculateAverageGrade()
            {
                double avg = 0;
                if (Grades.Count > 0)
                {
                    avg = (double)Grades.Sum() / Grades.Count;
                }
                return avg;
            }
            public void DisplayStudentInfo()
            {
                Console.WriteLine("Student Name: {0}", Name);
                Console.WriteLine("Student ID: {0}", StudentID);
                Console.WriteLine("Grades Obtained:");
                foreach (var grade in Grades)
                {
                    Console.WriteLine(grade);
                }
                Console.WriteLine("Calculated Average: {0}", CalculateAverageGrade());
            }
        }
    }


