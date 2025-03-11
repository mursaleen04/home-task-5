using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace question_2
{
    internal class School
    {
       
            public string SchoolName;
            public string Location;
            public List<Student> Students;

            public School(string name, string location)
            {
                SchoolName = name;
                Location = location;
                Students = new List<Student>();
            }
            public void DisplaySchoolInfo()
            {
                Console.WriteLine("Academy Name: {0}", SchoolName);
                Console.WriteLine("Located in: {0}", Location);
                Console.WriteLine("List of Enrolled Students:");
                foreach (var student in Students)
                {
                    Console.WriteLine(student.Name);
                }
            }
            public void AddStudent(Student student)
            {
                Console.WriteLine("Please enter the student's full name");
                student.Name = Console.ReadLine();
                Students.Add(student);
            }
        }
    }

