using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Entities
{
    // suppose this file is not available => fluent API
    internal class Department
    {
        public int DeptId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfCreation { get; set; }
    }
}
