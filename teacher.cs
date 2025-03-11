using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{
   
        internal class Teacher
        {
            public int TeacherID;
            public string Name;
            public string Subject;

            public Teacher(int id, string name, string subject)
            {
                TeacherID = id;
                Name = name;
                Subject = subject;
            }
            public void AssignGrade(Student student, int grade)
            {
                student.Grades.Add(grade);
            }
        }
    }


