using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEmployee.Models
{
    public class Employee
    {
        [Key]
        public int EmpId { get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string EmpName { get; set; }
 
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string EmpTitle { get; set; }
 
        [EmailAddress]
        [StringLength(50)]
        [Column(TypeName = "nvarchar(50)")]
        public string EmpEmail { get; set; }

      
        public int CountryId { get; set; }
        public Country Country { get; set; }
    }
}
