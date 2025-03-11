using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
             Student student1 = new Student(1, "", new List<int>());
                Console.WriteLine("Please enter the student's information");
                School school = new School("Al-Huda Academy", "Karachi");
                school.AddStudent(student1);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Please enter the student's information");
                Student student2 = new Student(2, "", new List<int>());
                school.AddStudent(student2);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("Please enter the student's information");
                Student student3 = new Student(3, "", new List<int>());
                school.AddStudent(student3);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("--------------------------------------------------");
                Teacher teacher1 = new Teacher(1, " Hassan Ali", "Maths");
                Teacher teacher2 = new Teacher(2, " Ayesha Khan", "Physics");
                teacher1.AssignGrade(student1, 85);
                teacher1.AssignGrade(student2, 75);
                teacher1.AssignGrade(student3, 60);

                teacher2.AssignGrade(student2, 70);
                teacher2.AssignGrade(student1, 55);
                teacher2.AssignGrade(student3, 90);
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("--------------------------------------------------");
                school.DisplaySchoolInfo();
                Console.WriteLine("--------------------------------------------------");
                student1.DisplayStudentInfo();
                Console.WriteLine("--------------------------------------------------");
                student2.DisplayStudentInfo();
                Console.WriteLine("--------------------------------------------------");
                student3.DisplayStudentInfo();
                Console.WriteLine("--------------------------------------------------");
                Console.WriteLine("--------------------------------------------------");
            }
        }
    }
