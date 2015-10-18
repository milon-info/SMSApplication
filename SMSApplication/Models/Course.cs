using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SMSApplication.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }
        [Display(Name = "Code")]
        [Required(ErrorMessage = "Enter the Course Code")]
        [StringLength(255, MinimumLength = 5)]
        [Remote("CheckExistCourseCode", "Course")]
        public string CourseCode { get; set; }
        [Display(Name = "Name")]
        [Required(ErrorMessage = "Enter the Course Name")]
        [Remote("CheckExistCourseName", "Course")]
        public string CourseName { get; set; }
        [Display(Name = "Credit")]
        [Required(ErrorMessage = "Enter the Course Credit")]
        [Range(0.5, 5.0)]
        public string CourseCredit { get; set; }
        [Display(Name = "Description")]
        [DataType(DataType.MultilineText)]
        [Required(ErrorMessage = "Enter the Course Description")]
        public string CourseDescription { get; set; }
        [Display(Name = "Department")]
        //[Required(ErrorMessage = "Select the Department")]
        public int DepartmentId { get; set; }
        [ForeignKey("DepartmentId")]
        public virtual Department Department { get; set; }

        [Display(Name = "Semester")]
        //[Required(ErrorMessage = "Select the Semester")]
        public int SemesterId { get; set; }
        [ForeignKey("SemesterId")]
        public virtual Semester Semester { get; set; }
    }
}