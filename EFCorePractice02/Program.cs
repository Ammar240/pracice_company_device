using EFCorePractice.Contexts;
using EFCorePractice.Entities;

namespace EFCorePractice02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using EnterpriseContext context = new EnterpriseContext();

            Employee e01 = new Employee() { Name = "Ammar", Age = 21, Salary = 200000, Email = "ammar@gmail.com" };
            Employee e02 = new Employee() { Name = "Ahmed", Age = 30, Salary = 100000, Email = "ahmed@gmail.com" };
            Employee e03 = new Employee() { Name = "Mahmoud", Age = 40, Salary = 55000, Email = "mahmoud@gmail.com" };
            Employee e04 = new Employee() { Name = "hamada", Age = 30, Salary = 15000, Email = "hamada@gmail.com" };
        }
    }
}
