using System.Collections.Generic;
using SMSApplication.Models;

namespace SMSApplication.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<SMSApplication.Models.DBHandle>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(SMSApplication.Models.DBHandle context)
        {
            //var aSemester = new List<Semester>
            //{
            //    new Semester() {SemesterName = "Spring"},
            //    new Semester() {SemesterName = "Summer"},
            //    new Semester() {SemesterName = "Fall"}
            //};
            //aSemester.ForEach(s => context.Semesters.Add(s));
            //context.SaveChanges();

            //var aDesignation = new List<Designation>
            //{
            //    new Designation() {DesignationName = "Associate Professor"},
            //    new Designation() {DesignationName = "Assistant Professor"},
            //    new Designation() {DesignationName = "Lecturer"}
            //};
            //aDesignation.ForEach(s => context.Designations.Add(s));
            //context.SaveChanges();
        }
    }
}
