using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSApplication.Models
{
    public class Department
    {
        [Key]
        public int DepartmentId { get; set; }
        [Display(Name = "Code")]
        [Required(ErrorMessage = "Enter the Department Code")]
        [StringLength(30, MinimumLength = 3)]
        [Remote("CheckExistDepartmentCode","Department")]
        public string DepartmentCode { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Enter the Department Name")]
        [Remote("CheckExistDepartmentName","Department")]
        public string DepartmentName { get; set; }
    }
}