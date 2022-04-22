using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ksu.Cs.Portal.Models
{
    /// <summary>
    /// An enumeration of roles a PortalUser can take on
    /// </summary>
    [Flags]
    public enum UserRoles : int
    {
        None = 0,
        Student = 1,
        TeachingAssistant = 8,
        Staff = 16,
        Faculty = 32,
        Admin = 128
    }

    /// <summary> 
    /// A class representing a user of the portal
    /// </summary>
    public class PortalUser
    {  
        /// <summary>The database primary key</summary>
        public int Id { get; set; }

        /// <summary>The PortalUsers's EID</summary>
        public string Eid { get; set; }

        /// <summary>The PortalUsers's last name</summary>
        public string LastName { get; set; }

        /// <summary>The PortalUsers's first name</summary>
        public string FirstName { get; set; }

        /// <summary>A bitmask indicating the user's roles</summary>
        public UserRoles Roles { get; set; }        

        // /// <summary>The PortalUser's enrollments</summary>
        // public ICollection<Enrollment> Enrollments;

        /// <summary>The PortalUser's email address</summary>
        public string Email => $"{Eid}@ksu.edu";

        /// <summary>The PortalUser's full name</summary>
        public string FullName => $"{FirstName} {LastName}";

        /// <summary>Determines if this user is a student</summary>
        public bool IsStudent { 
            get => Roles.HasFlag(UserRoles.Student);
            set 
            {
                if(value) Roles |= UserRoles.Student;
                else Roles &= ~UserRoles.Student;
            }
        }

        /// <summary>Determines if this user is a teaching assistant</summary>
        public bool IsTeachingAssistant { 
            get => Roles.HasFlag(UserRoles.Student);
            set
            {
                if (value) Roles |= UserRoles.Student;
                else Roles &= ~UserRoles.Student;
            }
        }

        /// <summary>Determines if this user is staff</summary>
        public bool IsStaff { 
            get => Roles.HasFlag(UserRoles.Staff);
            set 
            {
                if(value) Roles |= UserRoles.Staff;
                else Roles &= ~UserRoles.Staff;
            }
        }

        /// <summary>Determines if this user is faculty</summary>
        public bool IsFaculty { 
            get =>Roles.HasFlag(UserRoles.Faculty);
            set 
            {
                if(value) Roles |= UserRoles.Faculty;
                else Roles &= ~UserRoles.Faculty;
            }
        }
        
        /// <summary>Determines if this user is an admin</summary>
        public bool IsAdmin { 
            get => Roles.HasFlag(UserRoles.Admin);
            set 
            {
                if(value) Roles |= UserRoles.Admin;
                else Roles &= ~UserRoles.Admin;
            }
        }
    }
}