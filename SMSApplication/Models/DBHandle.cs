using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SMSApplication.Models
{
    public class DBHandle : DbContext
    {
        public DBHandle() : base("DBConStrings")
        {
            
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Semester> Semesters { get; set; }

        public DbSet<Course> Courses { get; set; }
        public DbSet<Designation> Designations { get; set; }
        public DbSet<Teacher> Teachers { get; set; } 
    }
}