using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCorePractice.Entities;

/// <summary>
/// EF core supports 4 wayes to map classes to database [tables | views]
/// 1.By convension (default behavior)
/// 2.Data Annotation (Set of Attributes used for validation)
/// 3.Fluent API (Context -> orerride OnModelCreating) used for 1.(Composed PK , Default value , view)
///                                                             2.Source code not available (you have IL file not cs file)
/// 4.Configuration class per Entity -> organize third way                                                            
/// </summary>


/// Migration
/// Package manager controle
/// 1.Add
///     Add-Migration "name"
///     Update-Database
/// 2.Revert
///     Update-Database -M "name of the previous migration"
///     Update-Database 0
/// 4.Remove
///     Remove-Migration (must be reverted)
/// 



// POCO class (has no functions) made to be maped into table

#region By Convension

//internal class Employee
//{
//    public int Id { get; set; } // public numeric named Id or (EmployeeId) => maped to primary key 
//    public string  Name { get; set; } // reference type allow null (optional)
//    public decimal Salary { get; set; } // value type does not allow null (required) 
//    //public int? Age { get; set; } // nullable ? allow null
//    public int Age { get; set; } // value type not nullable (erquired)
//}

#endregion

#region Data Annotation
//[Table("Employees")]
internal class Employee
{
    [Key] // Key Attribute
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)] // Identity Attribure
    public int EmpId { get; set; }


    [Required] // not null Attribute
    [Column(TypeName = "varchar")]
    [StringLength(50, MinimumLength = 5)]
    [MaxLength(50)]
    public string Name { get; set; }

    [DataType(DataType.Currency)]
    public decimal Salary { get; set; } // value type does not allow null (required) 


    //public int? Age { get; set; } // nullable ? allow null

    [Range(18, 50)]
    public int Age { get; set; } // value type not nullable (erquired)

    [EmailAddress]
    public string Email { get; set; }

    [ForeignKey("Department")]
    public int DepartmentId { get; set; }
    public Department Department { get; set; }
} 
#endregion

