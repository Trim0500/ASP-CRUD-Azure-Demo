using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDemo.Models
{
    [Table("Employees")]
    public class Employee
    {
        [Key]
        public int id { get; set; }
        [ForeignKey("Department")]
        public int FKDepId { get; set; }
        public string EmpName { get; set; }
        public decimal Salary { get; set; }
        public bool isActive { get; set; }
        public Department department { get; set; }
    }
}
