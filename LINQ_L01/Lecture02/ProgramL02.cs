using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_L01.Lecture02;

internal class ProgramL02
{

    static void Main(string[] args)
    {
        IEnumerable<Course> courses = SampleData.Courses.Filter(c => c.Hours > 30);

        foreach (Course course in courses)
        {
            Console.WriteLine($"Course: {course.Name,-10} | Hours: {course.Hours,-5} | Department: {course.Department.Name}");
        }
    }
}