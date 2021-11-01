using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CRUDDemo.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        public int id { get; set; }
        public string depName { get; set; }
        public bool isActive { get; set; }
        public ICollection<Employee> employees { get; set; }
    }
}
