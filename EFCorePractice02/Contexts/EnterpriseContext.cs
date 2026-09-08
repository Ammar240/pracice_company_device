using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCorePractice.Entities;
using EFCorePractice02.Entities;

namespace EFCorePractice.Contexts;

internal class EnterpriseContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server = .; Database = EnterpriseDB; Trusted_Connection = True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        //when you need to configure the relation 
        modelBuilder.Entity<Employee>()
            .HasOne(E => E.Department)
            .WithMany(D => D.Employees)
            .HasForeignKey(E => E.DepartmentId)
            .OnDelete(DeleteBehavior.Cascade); // configure relation

        ////Or
        //modelBuilder.Entity<Department>()
        //    .HasMany(D => D.Employees)
        //    .WithOne(E => E.Department)
        //    .HasForeignKey(D => D.DepartmentId)
        //    .OnDelete(DeleteBehavior.Cascade);

        modelBuilder.Entity<CourseStudent>()
            .HasKey(cs => new { cs.StudentId, cs.CourseId }); // composed primary key


        modelBuilder.Entity<Course>()
            .HasMany(C => C.Students)
            .WithOne(SC => SC.Course)
            .OnDelete(DeleteBehavior.Cascade);// configure relation

        modelBuilder.Entity<Student>()
            .HasMany(S => S.StudentCourses)
            .WithOne(SC => SC.Student)
            .OnDelete(DeleteBehavior.Cascade);// configure relation

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Student> Students { get; set; }
    public DbSet<Course> Courses { get; set; }

}
