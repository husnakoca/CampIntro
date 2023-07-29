using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            string name = "Engin";
            string surname = "Demirog";
            int age = 38;

            course course1 = new course();
            course1.CourseName = "C#";
            course1.CourseInstructor = "Engin";
            course1.WatchingRate = 72;

            course course2 = new course();
            course2.CourseName = "Java";
            course2.CourseInstructor = "Kerem";
            course2.WatchingRate = 50;

            course course3 = new course();
            course3.CourseName = "Python";
            course3.CourseInstructor = "Berkay";
            course3.WatchingRate = 68;

            //Console.WriteLine(course1.CourseName + " : " + course1.CourseInstructor);

            course[] courses = new course[] {course1, course2, course3 };

            foreach (var course in courses)

            {
                Console.WriteLine(course.CourseName);
            }

        } 
    }
    class course
    {
        public string CourseName { get; set; }
        public string CourseInstructor { get; set; }
        public int WatchingRate { get; set; }
    }


}

