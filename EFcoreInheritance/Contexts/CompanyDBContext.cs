using EFcoreInheritance.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFcoreInheritance.Contexts;

internal class CompanyDBContext : DbContext
{
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
      => optionsBuilder.UseSqlServer("Server = .; DataBase = CompanyDB; Trusted_Connection = True; TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {

        //TPH: Map FullTime and PartTime to one table [Employee]
        //Add New Column called Discriminator containing the type of Employee [part | full]
        modelBuilder.Entity<FullTimeEmployee>().HasBaseType<Employee>();
        modelBuilder.Entity<PartTimeEmployee>().HasBaseType<Employee>();



        base.OnModelCreating(modelBuilder);
    }

    public DbSet<FullTimeEmployee> FullTimeEmployees { get; set; }
    public DbSet<PartTimeEmployee> PartTimeEmployees { get; set; }
}
