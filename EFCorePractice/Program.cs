using EFCorePractice.Contexts;
using EFCorePractice.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;


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

        #region Insert

        //Console.WriteLine(context.Entry(e01).State);// Deattached

        //// 4 wayes to add row in a table
        //// added to local program not database
        //context.Employees.Add(e01);

        //context.Set<Employee>().Add(e02);

        //context.Add(e03); // syntax sugar

        //context.Entry(e04).State = EntityState.Added;

        //Console.WriteLine(context.Entry(e01).State);//added

        //// Add to database
        //context.SaveChanges();
        //Console.WriteLine(context.Entry(e01).State);// Unchanged

        //Console.WriteLine(e01.EmpId);
        //Console.WriteLine(e02.EmpId);
        //Console.WriteLine(e03.EmpId);
        //Console.WriteLine(e04.EmpId);
        #endregion

        #region Select

        //var query = (from E in context.Employees
        //             where E.EmpId == 3 || E.EmpId == 5
        //             select E);
        //foreach (var e in query)
        //{
        //    Console.WriteLine(e.Name);
        //}


        #endregion

        #region Update

        //var query2 = (from E in context.Employees
        //              where  E.EmpId >= 5
        //              select E).FirstOrDefault();

        //Console.WriteLine(query2?.Name ?? "not found");

        //Console.WriteLine(context.Entry(query2).State);// unchanged
        //query2.Name = "Ammar Emad";
        //Console.WriteLine(context.Entry(query2).State); // modified (in local)

        //// update in database
        //context.SaveChanges();
        //Console.WriteLine(context.Entry(query2).State);// unchanged

        #endregion

        #region Delete


        //context.Remove(query2);
        //Console.WriteLine(context.Entry(query2).State);// deleted (local)


        //context.SaveChanges();
        //Console.WriteLine(context.Entry(query2).State);// Deattached

        #endregion

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
