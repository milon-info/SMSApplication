using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SMSApplication.Models
{
    public class Designation
    {
        [Key]
        public int DesignationId { get; set; }

        public string DesignationName { get; set; }
    }
}