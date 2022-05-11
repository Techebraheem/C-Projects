using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student
    {
        // using methods to illustrate

        public string name;
        public string major;
        public double gpa;

        public Student(string aName, string aMajor, double aGpa)
        {
            name = aName;
            major = aMajor;
            gpa = aGpa;
        }

        //method HasHonors
        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }
    }
    class programs
    {
        public static void Main(string[] args)
        {
            Student student1 = new Student("Jim", "Business", 2.8);

            Student student2 = new Student("Pam", "Art", 3.6);
            
            // checks the gpa of a student and determines if they are honors student
            Console.WriteLine(student1.HasHonors());
            Console.WriteLine(student2.HasHonors());
        }
    }
}
