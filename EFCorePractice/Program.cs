using EFCorePractice.Contexts;
using EFCorePractice.Entities;
using Microsoft.EntityFrameworkCore;

namespace EFCorePractice;

internal class Program
{
    static void Main(string[] args)
    {
        //using (EnterpriseContext context = new EnterpriseContext())
        //{

        //}

        //syntax sugar
        using EnterpriseContext context = new EnterpriseContext();

        Employee e01 = new Employee() { Name = "Ammar", Age = 21, Salary = 200000, Email = "ammar@gmail.com" };
        Employee e02 = new Employee() { Name = "Ahmed", Age = 30, Salary = 100000, Email = "ahmed@gmail.com" };
        Employee e03 = new Employee() { Name = "Mahmoud", Age = 40, Salary = 55000, Email = "mahmoud@gmail.com" };
        Employee e04 = new Employee() { Name = "hamada", Age = 30, Salary = 15000, Email = "hamada@gmail.com" };

        Console.WriteLine(context.Entry(e01).State);// Deattached

        // 4 wayes to add row in a table
        // added to local program not database
        context.Employees.Add(e01);

        context.Set<Employee>().Add(e02);

        context.Add(e03); // syntax sugar

        context.Entry(e04).State = EntityState.Added;

        Console.WriteLine(context.Entry(e01).State);//added

        // Add to database
        context.SaveChanges();
        Console.WriteLine(context.Entry(e01).State);// Deattached

        Console.WriteLine(e01.EmpId);
        Console.WriteLine(e02.EmpId);
        Console.WriteLine(e03.EmpId);
        Console.WriteLine(e04.EmpId);

        // using statement is converted to the following code
        //try
        //{
        //    //context.add ....
        //}
        //finally
        //{
        //    context.Dispose(); // close or release or free Database connection
        //}
    }
}
