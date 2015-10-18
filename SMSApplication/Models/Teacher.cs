using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Services.Description;

namespace SMSApplication.Models
{
    public class Teacher
    {
        [Key]
        public int TeacherId { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Enter the Teacher Name")]
        public string TeacherName { get; set; }
        [Display(Name = "Address")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Enter the Teacher Address")]
        public string TeacherAddress { get; set; }
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Enter the Teacher Email")]
        [Remote("CheckExistTeacherEmail", "Teacher")]
        public string TeacherEmail { get; set; }
        [Display(Name = "Contact Number")]
        [Required(ErrorMessage = "Enter the Teacher Contact Number")]
        public string ContactNumber { get; set; }
        [Display(Name = "Designation")]
        [Required(ErrorMessage = "Select the Designation")]
        public int DesignationId { get; set; }
        [ForeignKey("DesignationId")]
        public virtual Designation Designation { get; set; }

        [Display(Name = "Department")]
        [Required(ErrorMessage = "Select the Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        [Display(Name = "Credit to be taken")]
        [Required(ErrorMessage = "Enter the Credit")]
        [Range(0,double.MaxValue,ErrorMessage = "Credit to be taken must contain a non-negative value")]
        public double Credit  { get; set; }
    }
}