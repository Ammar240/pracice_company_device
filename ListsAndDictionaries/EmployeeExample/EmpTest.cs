using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndDictionaries.EmployeeExample;

internal class EmpTest
{
    static void Main(string[] args)
    {
        var emps = new List<Employee>
        {
            new Employee { Id = 100, Name = "Reem S.", ReportTo = null },
            new Employee { Id = 101, Name = "Raed M.", ReportTo = 100 },
            new Employee { Id = 102, Name = "Ali B.", ReportTo = 100 },
            new Employee { Id = 103, Name = "Abeer S.", ReportTo = 102 },
            new Employee { Id = 104, Name = "Radwan N.", ReportTo = 102 },
            new Employee { Id = 105, Name = "Nancy R.", ReportTo = 101 },
            new Employee { Id = 106, Name = "Saleh A.", ReportTo = 104 }
        };

        var managers = emps.ToLookup(x => x.ReportTo).ToDictionary(x => x.Key ?? -1, x => x.ToList());

        foreach (var entry in managers)
        {
            if (entry.Key == -1)
                continue;
            var manager = emps.FirstOrDefault(x => x.Id  == entry.Key);
            Console.WriteLine($"{manager}");
            foreach (var emp in entry.Value)
            {
                Console.WriteLine($"\t\t {emp}");
            }

        }
    }
}
