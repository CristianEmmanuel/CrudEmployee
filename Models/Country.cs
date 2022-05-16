﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CrudEmployee.Models
{
    public class Country
    {
        [Key]
        public int CountryId { get; set; }

        [StringLength(50)]
        [Column(TypeName = "nvarchar (50)")]
        public string CountryName { get; set; }
 
        [StringLength(2)]
        [Column(TypeName = "nvarchar (2)")]
        public string CountryCode { get; set; }


    }
}
