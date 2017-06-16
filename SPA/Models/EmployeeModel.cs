﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace SPA.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get;set;}
        public string FirstMidName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }        
        public  int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }
     }
}
