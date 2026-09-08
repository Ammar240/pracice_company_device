using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EFCorePractice.Entities;

namespace EFCorePractice.Contexts;

internal class EnterpriseContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("Server = .; Database = Enterprise; Integrated Security = True; TrustServerCertificate=True;");

    //protected override void OnModelCreating(ModelBuilder modelBuilder)
    //{
    //    #region Fluent API
    //    ////Fluent API
    //    //modelBuilder.Entity<Department>().ToTable("Departments");
    //    //modelBuilder.Entity<Department>().HasKey(D => D.DeptId); //primary key
    //    ////modelBuilder.Entity<Department>().HasKey(nameof(Department.DeptId)); //primary key
    //    //modelBuilder.Entity<Department>().Property(D => D.DeptId).UseIdentityColumn(); // identity 1++

    //    //modelBuilder.Entity<Department>().Property(D => D.Name)
    //    //    .IsRequired(true)
    //    //    .HasDefaultValue("Dept")
    //    //    .HasMaxLength(100)
    //    //    .HasColumnType("varchar")
    //    //    .HasColumnName("Dept_Name");

    //    //modelBuilder.Entity<Department>().Property(nameof(Department.DateOfCreation))
    //    //    .HasColumnType("DateTime")
    //    //    .HasDefaultValue(DateTime.Now);

    //    // another syntax EF core 3.1 feature
    //    //modelBuilder.Entity<Department>(E =>
    //    //{
    //    //    E.ToTable("Departments");
    //    //    E.HasKey(D => D.DeptId); //primary key
    //    //                             //modelBuilder.Entity<Department>().HasKey(nameof(Department.DeptId)); //primary key
    //    //    E.Property(D => D.DeptId).UseIdentityColumn(); // identity 1++

    //    //    E.Property(D => D.Name)
    //    //          .IsRequired(true)
    //    //          .HasDefaultValue("Dept")
    //    //          .HasMaxLength(100)
    //    //          .HasColumnType("varchar")
    //    //          .HasColumnName("Dept_Name");

    //    //    E.Property(nameof(Department.DateOfCreation))
    //    //         .HasColumnType("DateTime")
    //    //         .HasDefaultValue(DateTime.Now);

    //    //});

    //    #endregion

    //    #region configuration class per Entity

    //    //modelBuilder.ApplyConfiguration<Department>(new DepartmentConfiguration());

    //    #endregion

    //    base.OnModelCreating(modelBuilder);
    //}

    public DbSet<Employee> Employees { get; set; }
    public DbSet<Department> Departments { get; set; }


}
