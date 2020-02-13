using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName ="nvarchar(250)")]
        [DisplayName("Full Name")]
        public string FullName { get; set; }
        [Column(TypeName = "varchar(10)")]
        [DisplayName("Employee Code")]
        public int EmpCode { get; set; }
        [Column(TypeName = "varchar(100)")]

        public string Position { get; set; }
        [Column(TypeName = "varchar(100)")]
        public string Location { get; set; }
    }
}
