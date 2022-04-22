using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

// TODO: Replace with Navigate connection
/*
namespace Ksu.Cs.Portal.Models
{
    /// <summary>
    /// A single semester offering of a course 
    /// </summary>
    public class CourseOffering
    {       
        /// <summary>
        /// The database primary key
        /// </summary>
        public int Id { get; set; }

        /// <summary>The foreign key for the semester</summary>
        public int SemesterId {get; set; }
        /// <summary> The semester in which this course offering was held</summary>
        public Semester Semester { get; set; }

        /// <summary>The course section(s) this course offering represents</summary>
        /// <value>Multiple sections can be indicated as a comma-separated list</value>
        public string Section { get; set; }

        /// <summary>The foreign key for the course</summary>
        public int CourseId { get; set; }
        /// <summary>The course of which this is an offering</summary>
        public Course Course { get; set; }

        /// <summary>The PortalUsers enrolled in the course</summary>
        /// <value>This includes instructors and teaching assistants</value>
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}
*/