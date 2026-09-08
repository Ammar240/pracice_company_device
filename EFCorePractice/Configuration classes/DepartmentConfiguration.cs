//using EFCorePractice.Entities;
//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Metadata.Builders;
//using Microsoft.Extensions.Configuration;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Reflection.Emit;
//using System.Text;
//using System.Threading.Tasks;

//namespace EFCorePractice.Configuration_classes;

//internal class DepartmentConfiguration : IEntityTypeConfiguration<Department>
//{
//    public void Configure(EntityTypeBuilder<Department> builder)
//    {
//        //Fluent API
//        builder.ToTable("Departments");
//        builder.HasKey(D => D.DeptId); //primary key
//                                       //modelBuilder.Entity<Department>().HasKey(nameof(Department.DeptId)); //primary key
//        builder.Property(D => D.DeptId).UseIdentityColumn(); // identity 1++

//        builder.Property(D => D.Name)
//            .IsRequired(true)
//            .HasDefaultValue("Dept")
//            .HasMaxLength(100)
//            .HasColumnType("varchar")
//            .HasColumnName("Dept_Name");

//        builder.Property(nameof(Department.DateOfCreation))
//            .HasColumnType("DateTime")
//            .HasDefaultValue(new DateTime(2026,1,1));
//    }
//}
