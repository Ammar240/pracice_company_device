using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice02.Entities;

internal class CourseStudent
{
    // to make composed pk (StudentId + CourseId) -> fluent api

    [ForeignKey("Student")]
    public int StudentId { get; set; }
    [ForeignKey("Course")]

    public int CourseId { get; set; }
    public int Grade { get; set; }

    public Course Course { get; set; }
    public Student Student { get; set; }
}
