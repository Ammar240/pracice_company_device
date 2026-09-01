using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListsAndDictionaries.EmployeeExample;

internal class Employee
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int? ReportTo { get; set; }

    public override string ToString()
    {
        return $"[{Id}] {Name}";
    }

}
