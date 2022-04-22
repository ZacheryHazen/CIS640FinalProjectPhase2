using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Ksu.Cs.Portal.Models;
using Ksu.Cs.Portal.Areas.Maps.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace Ksu.Cs.Portal.Data
{
    public class PortalContext : DbContext
    {
        public PortalContext (DbContextOptions<PortalContext> options)
            : base(options)
        {
        }

        public DbSet<PortalUser> PortalUsers { get; set; }
        public DbSet<Building> Buildings { get; set; }
        public DbSet<Door> Doors { get; set; }
        public DbSet<DoorHours> DoorHours { get; set; }
        public DbSet<Edge> Edges { get; set; }
        public DbSet<Floor> Floors { get; set; }
        public DbSet<Node> Nodes { get; set; }
        public DbSet<Room> Rooms { get; set; }
        public DbSet<RoomTag> RoomTags { get; set; }
        public DbSet<Tag> Tags { get; set; }
        //public DbSet<Ksu.Cs.Portal.Models.Course> Courses { get; set; }
        //public DbSet<Ksu.Cs.Portal.Models.CourseOffering> CourseOfferings { get; set; }
        //public DbSet<Ksu.Cs.Portal.Models.Enrollment> Enrollments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        {
            // Core tables
            modelBuilder.Entity<PortalUser>().ToTable("PortalUser");
            modelBuilder.Entity<Building>().ToTable("Building");
            modelBuilder.Entity<Door>().ToTable("Door");
            modelBuilder.Entity<DoorHours>().ToTable("DoorHours");
            modelBuilder.Entity<Edge>().ToTable("Edge");
            modelBuilder.Entity<Floor>().ToTable("Floor");
            modelBuilder.Entity<Node>().ToTable("Node");
            modelBuilder.Entity<Room>().ToTable("Room");
            modelBuilder.Entity<RoomTag>().ToTable("RoomTag");
            modelBuilder.Entity<Tag>().ToTable("Tag");
            /*
            modelBuilder.Entity<Course>().ToTable("Course");
            modelBuilder.Entity<CourseOffering>().ToTable("CourseOffering");
            modelBuilder.Entity<Enrollment>().ToTable("Enrollment");   */          
            // Core table relationships
            modelBuilder.Entity<Building>()
                .HasMany<Node>(b => b.Nodes)
                .WithOne(n => n.Building);
            modelBuilder.Entity<Building>()
                .HasMany<Edge>(b => b.Edges)
                .WithOne(e => e.Building);
            modelBuilder.Entity<Building>()
                .HasMany<Floor>(b => b.Floors)
                .WithOne(f => f.Building);
            modelBuilder.Entity<Door>()
                .HasMany<DoorHours>(d => d.DoorHours)
                .WithOne(dh => dh.Door);
            modelBuilder.Entity<Floor>()
                .HasMany<Room>(f => f.Rooms)
                .WithOne(r => r.Floor);
            modelBuilder.Entity<Edge>()
                .HasOne<Node>(e => e.StartNode)
                .WithMany(n => n.FromEdges);
            modelBuilder.Entity<Edge>()
                .HasOne<Node>(e => e.DestinationNode) 
                .WithMany(n => n.ToEdges);
            modelBuilder.Entity<RoomTag>()
                .HasKey(rt => new {rt.RoomId, rt.TagId});
            modelBuilder.Entity<RoomTag>()
                .HasOne<Room>(rt => rt.Room)
                .WithMany(r => r.RoomTags)
                .HasForeignKey(rt => rt.RoomId);
            modelBuilder.Entity<RoomTag>()
                .HasOne<Tag>(rt => rt.Tag)
                .WithMany(t => t.RoomTags)
                .HasForeignKey(rt => rt.TagId);
            /*
            modelBuilder.Entity<CourseOffering>()
                .HasOne(a => a.Course)
                .WithMany(b => b.CourseOfferings);
            modelBuilder.Entity<Enrollment>()
                .HasOne(a => a.CourseOffering)
                .WithMany(b => b.Enrollments);
            modelBuilder.Entity<Enrollment>()
                .HasOne(a => a.PortalUser)
                .WithMany(b => b.Enrollments);
            */
            // Core table indices
            modelBuilder.Entity<PortalUser>()
                .HasIndex(u => u.Eid)
                .IsUnique();
            // Core table data
            modelBuilder.Entity<PortalUser>().HasData(
                new PortalUser(){Id=1, Eid="nhbean", FirstName="Nathan", LastName="Bean", Roles = UserRoles.Faculty | UserRoles.Admin},
                new PortalUser(){Id=2, Eid="russfeld", FirstName="Russ", LastName="Feldhausen", Roles = UserRoles.Faculty | UserRoles.Admin},
                new PortalUser(){Id=3, Eid="weeser", FirstName="Josh", LastName="Weese", Roles = UserRoles.Faculty | UserRoles.Admin}
            );
            modelBuilder.Entity<Building>().HasData(
                new Building() {Id=1, BuildingName="Anderson Hall", BuildingAbrev="A", Slug="Anderson", X=100, Y=300, CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Building() {Id=2, BuildingName="Engineering Building", BuildingAbrev="ENGG", Slug="Engineering", X=0, Y=200, CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Building() {Id=3, BuildingName="Business Building", BuildingAbrev="BB", Slug="Business", X=300, Y=400, CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now}
            );
            modelBuilder.Entity<Door>().HasData(
                new Door() {Id=3, Accessible=false, X=400, Y=500, CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now, BuildingId=1}
            );
            modelBuilder.Entity<DoorHours>().HasData(
                new DoorHours() {Id=1, DoorId=3, DayOfWeek=0, OpenTime=new TimeSpan(8, 00, 00), CloseTime=new TimeSpan(17, 15, 00)},
                new DoorHours() {Id=2, DoorId=3, DayOfWeek=1, OpenTime=new TimeSpan(8, 00, 00), CloseTime=new TimeSpan(17, 15, 00)},
                new DoorHours() {Id=3, DoorId=3, DayOfWeek=2, OpenTime=new TimeSpan(8, 00, 00), CloseTime=new TimeSpan(17, 15, 00)},
                new DoorHours() {Id=4, DoorId=3, DayOfWeek=3, OpenTime=new TimeSpan(8, 00, 00), CloseTime=new TimeSpan(17, 15, 00)},
                new DoorHours() {Id=5, DoorId=3, DayOfWeek=4, OpenTime=new TimeSpan(8, 00, 00), CloseTime=new TimeSpan(17, 15, 00)},
                new DoorHours() {Id=6, DoorId=3, DayOfWeek=5, OpenTime=new TimeSpan(8, 00, 00), CloseTime=new TimeSpan(17, 15, 00)},
                new DoorHours() {Id=7, DoorId=3, DayOfWeek=6, OpenTime=new TimeSpan(8, 00, 00), CloseTime=new TimeSpan(17, 15, 00)}
            );
            modelBuilder.Entity<Edge>().HasData(
                new Edge() {Id=1, StartNodeId=1, DestinationNodeId=3, BuildingId=1},
                new Edge() {Id=2, StartNodeId=3, DestinationNodeId=2, BuildingId=1},
                new Edge() {Id=3, StartNodeId=3, DestinationNodeId=1, BuildingId=1},
                new Edge() {Id=4, StartNodeId=2, DestinationNodeId=3, BuildingId=1}
            );
            modelBuilder.Entity<Floor>().HasData(
                new Floor() {Id=4, FloorString="Third", FloorNumber=3, BuildingId=1, FloorMap="Anderson_3.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=3, FloorString="Second", FloorNumber=2, BuildingId=1, FloorMap="Anderson_2.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=2, FloorString="First", FloorNumber=1, BuildingId=1, FloorMap="Anderson_1.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=1, FloorString="Basement", FloorNumber=0, BuildingId=1, FloorMap="Anderson_0.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=5, FloorString="Basement", FloorNumber=0, BuildingId=2, FloorMap="Engineering_0.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=6, FloorString="First", FloorNumber=1, BuildingId=2, FloorMap="Engineering_1.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=7, FloorString="Second", FloorNumber=2, BuildingId=2, FloorMap="Engineering_2.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=8, FloorString="Third", FloorNumber=3, BuildingId=2, FloorMap="Engineering_3.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=9, FloorString="Basement", FloorNumber=0, BuildingId=3, FloorMap="Business_0.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=10, FloorString="First", FloorNumber=1, BuildingId=3, FloorMap="Business_1.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=11, FloorString="Second", FloorNumber=2, BuildingId=3, FloorMap="Business_2.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=12, FloorString="Third", FloorNumber=3, BuildingId=3, FloorMap="Business_3.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now},
                new Floor() {Id=13, FloorString="Fourth", FloorNumber=4, BuildingId=3, FloorMap="Business_4.svg", CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now}
            );
            modelBuilder.Entity<Node>().HasData(
                new Node() {Id=1, X=600, Y=600, CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now, BuildingId=1, Accessible=false}
            );
            modelBuilder.Entity<Room>().HasData(
                new Room() {Id=2, RoomNumber="A308", FloorId=4, X=500, Y=400, CreatedOn=DateTime.Now, UpdatedOn=DateTime.Now, BuildingId=1, Accessible=false}
            ); 
            modelBuilder.Entity<Tag>().HasData(
                new Tag() {Id=1, TagName="Bathroom"},
                new Tag() {Id=2, TagName="Office"},
                new Tag() {Id=3, TagName="Classroom"},
                new Tag() {Id=4, TagName="Study Room"},
                new Tag() {Id=5, TagName="Computer Lab"},
                new Tag() {Id=6, TagName="Conference Room"}
            ); 
            /*
            modelBuilder.Entity<Course>().HasData(
                new Course(){Id=1, Identifier="CIS 015", Title="Undergraduate Seminar"},
                new Course(){Id=2, Identifier="CIS 018", Title="Computer Science Professional Development Seminar"},
                new Course(){Id=3, Identifier="CIS 015", Title="Computer Science Scholars Seminar"},
                new Course(){Id=4, Identifier="CIS 115", Title="Introduction to Computer Science"},
                new Course(){Id=5, Identifier="CIS 118", Title="International Professional Development Experience"},
                new Course(){Id=6, Identifier="CIS 200", Title="Programming Fundamentals"},
                new Course(){Id=7, Identifier="CIS 300", Title="Data and Program Structures"},
                new Course(){Id=8, Identifier="CIS 301", Title="Logical Foundations of Programming"},
                new Course(){Id=9, Identifier="CIS 308", Title="C Language Laboratory"},
                new Course(){Id=10, Identifier="CIS 351", Title="Cyber Defense Basics"},
                new Course(){Id=11, Identifier="CIS 400", Title="Object-Oriented Design, Implementation, and Testing"},
                new Course(){Id=12, Identifier="CIS 415", Title="Ethics and Conduct for Computing Professionals"},
                new Course(){Id=13, Identifier="CIS 450", Title="Computer Architecture and Operations"},
                new Course(){Id=14, Identifier="CIS 501", Title="Software Architecture and Design"},
                new Course(){Id=15, Identifier="CIS 505", Title="Introduction to Programming Languages"},
                new Course(){Id=16, Identifier="CIS 520", Title="Operating Systems I"},
                new Course(){Id=17, Identifier="CIS 521", Title="Real-Time Programming Laboratory"},
                new Course(){Id=18, Identifier="CIS 522", Title="Introduction to Data Structures"},
                new Course(){Id=19, Identifier="CIS 523", Title="Introduction to Concurrent Programming"},
                new Course(){Id=20, Identifier="CIS 525", Title="Introduction to Network Programming"},
                new Course(){Id=21, Identifier="CIS 526", Title="Web Application Development"},
                new Course(){Id=22, Identifier="CIS 527", Title="Enterprise System Administration"},
                new Course(){Id=23, Identifier="CIS 530", Title="Introduction to Artificial Intelligence"},
                new Course(){Id=24, Identifier="CIS 531", Title="Introduction to Programming Techniques for Data Science and Analytics"},
                new Course(){Id=25, Identifier="CIS 536", Title="Introduction to Computer Graphics"},
                new Course(){Id=26, Identifier="CIS 544", Title="Advanced Software Design and Development"},
                new Course(){Id=27, Identifier="CIS 551", Title="Fundamentasl of Computer and Information Security"},
                new Course(){Id=28, Identifier="CIS 553", Title="Fundamentals of Cryptography"},
                new Course(){Id=29, Identifier="CIS 560", Title="Database System Concepts"},
                new Course(){Id=30, Identifier="CIS 570", Title="Introduction to Formal Language Theory"},
                new Course(){Id=31, Identifier="CIS 575", Title="Introduction to Algorithm Analysis"},
                new Course(){Id=32, Identifier="CIS 580", Title="Foundations of Game Programming"},
                new Course(){Id=33, Identifier="CIS 585", Title="Game Engine Design"},
                new Course(){Id=34, Identifier="CIS 596", Title="Entrepreneurial Computer Science Project"},
                new Course(){Id=35, Identifier="CIS 598", Title="Computer Science Project"},
                new Course(){Id=36, Identifier="CIS 599", Title="Cybersecurity Project"},                
                new Course(){Id=37, Identifier="CIS 604", Title="Set Theory and Logic for CS"},                
                new Course(){Id=38, Identifier="CIS 621", Title="Real-Time Programming Fundamentals"},
                new Course(){Id=39, Identifier="CIS 622", Title="Real-Time Operating Systems"},
                new Course(){Id=40, Identifier="CIS 625", Title="Concurrent Operating Systems"},                
                new Course(){Id=41, Identifier="CIS 635", Title="Introduction to Computer-Based Knowledge Systems"},                
                new Course(){Id=42, Identifier="CIS 636", Title="Introduction to Computer Graphics"},
                new Course(){Id=43, Identifier="CIS 638", Title="Multimedia Systems"},
                new Course(){Id=44, Identifier="CIS 640", Title="Software Testing Techniques"},
                new Course(){Id=45, Identifier="CIS 641", Title="Software Engineering Design Project"},
                new Course(){Id=46, Identifier="CIS 642", Title="Software Engineering Design Project I"},
                new Course(){Id=47, Identifier="CIS 643", Title="Software Engineering Design Project II"},
                new Course(){Id=48, Identifier="CIS 645", Title="Software Development Environments"},
                new Course(){Id=49, Identifier="CIS 643", Title="Security and Reliability of Computer Systems"}
            );
            modelBuilder.Entity<Semester>().HasData(
                new Semester(){Id=1, Name="Spring 2021"}
            );
            modelBuilder.Entity<CourseOffering>().HasData(
                new CourseOffering(){Id=1, CourseId=11, SemesterId=1, Section="A"},
                new CourseOffering(){Id=2, CourseId=11, SemesterId=1, Section="B"},
                new CourseOffering(){Id=3, CourseId=11, SemesterId=1, Section="ZA"}
            );
            */
        }
    }
}
