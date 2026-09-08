using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice02.Entities;

internal class Course
{
    public int Id { get; set; }
    public string Title { get; set; }

    //Many to Many with no extra properties
    //public ICollection<Student> Students { get; set; } = new HashSet<Student>();

    //Many to Many with extra properties [Grade]

    public ICollection<CourseStudent> Students { get; set; } = new HashSet<CourseStudent>();
}
