using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMSApplication.Models
{
    public class Semester
    {
        [Key]
        public int SemesterId { get; set; }
        public string SemesterName { get; set; }
    }
}