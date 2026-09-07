using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ_L01.Lecture02;

internal class ProgramL02
{
    static string GetName(Course course)
    {
        return course.Name;
    }
    static void Main(string[] args)
    {
        #region PipeLine
        //IEnumerable<Course> courses = SampleData.Courses.Filter(c => c.Hours > 30);

        //foreach (Course course in courses)
        //{
        //    Console.WriteLine($"Course: {course.Name,-10} | Hours: {course.Hours,-5} | Department: {course.Department.Name}");
        //}

        //pipe Line
        //IEnumerable<string> names = SampleData.Courses
        //    .Filter(c => c.Hours > 30)
        //    .Chooser(c => c.Department.Name);
        //foreach (string name in names)
        //{
        //    Console.WriteLine(name);
        //}

        //var query = SampleData.Courses
        //  .Filter(c => c.Hours > 30)
        //  .Chooser(c => new { c.Name, c.Hours });

        //foreach (var item in query)
        //{
        //    Console.WriteLine($"{item.Name,-10} {item.Hours}");
        //} 
        #endregion

        var query =
            from sub in SampleData.Subjects
            select new
            {
                sub.Name,
                courses =
                    from crs in SampleData.Courses
                    where sub.Name == crs.Subject.Name
                    select crs
            };

        foreach (var sub in query)
        {
            Console.WriteLine($"Subject: {sub.Name,-20} Total Hours: {sub.courses.Sum(c => c.Hours)}");
            foreach (var course in sub.courses)
            {
                Console.WriteLine($"Course: {course.Name,-20} Hours: {course.Hours}");
            }
            Console.WriteLine("---------------------------------");
        }
    }
}