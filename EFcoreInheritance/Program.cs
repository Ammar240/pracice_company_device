using EFcoreInheritance.Contexts;
using EFcoreInheritance.Entities;

namespace EFcoreInheritance;

internal class Program
{
    static void Main(string[] args)
    {
        using CompanyDBContext db = new CompanyDBContext();
        FullTimeEmployee E01 = new FullTimeEmployee()
        {
            Name = "Ammar",
            Age = 21,
            Salary = 15000m,
            StartDate = new DateTime(2026, 7, 1),
            Address = "Fayoum"
        };

        PartTimeEmployee E02 = new PartTimeEmployee()
        {
            Name = "Ahmed",
            Age = 21,
            CountHours = 120,
            HourRate = 50,
            Address = "Cairo"
        };

        //Add
        db.FullTimeEmployees.Add(E01);
        db.PartTimeEmployees.Add(E02);

        db.SaveChanges();
    }
}
