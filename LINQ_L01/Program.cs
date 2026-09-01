namespace LINQ_L01;

internal class Program
{
    static void Main(string[] args)
    {
        var employees = new List<Employee>
        {
            new Employee { Id = 1, Name = "Ahmed", Salary = 8000, Department = "IT" },
            new Employee { Id = 2, Name = "Mona", Salary = 12000, Department = "HR" },
            new Employee { Id = 3, Name = "Omar", Salary = 15000, Department = "IT" },
            new Employee { Id = 4, Name = "Sara", Salary = 7000, Department = "Sales" },
            new Employee { Id = 5, Name = "Ali", Salary = 11000, Department = "IT" }
        };

        Console.WriteLine("========Before foreach========");
        employees.Filter(e => e.Salary > 10000);
        Console.WriteLine("nothing");


        Console.WriteLine("========After foreach========");
        //employees is list -> Enumerable
        var highSalaryEmps = employees.Filter(e => e.Salary > 10000);
        foreach (Employee emp in highSalaryEmps)
        {
            Console.WriteLine(emp);
        }
        Console.WriteLine("======================");
        employees[0].Salary = 20000;
        foreach (Employee emp in highSalaryEmps)
        {
            Console.WriteLine(emp);
        }
    }
}
