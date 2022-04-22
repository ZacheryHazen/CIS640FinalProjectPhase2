﻿// <auto-generated />
using System;
using Ksu.Cs.Portal.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace KSU.CS.Portal.Migrations
{
    [DbContext(typeof(PortalContext))]
    partial class PortalContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Building", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("BuildingAbrev")
                        .HasColumnType("TEXT");

                    b.Property<string>("BuildingName")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("Slug")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("X")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("Y")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Building");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuildingAbrev = "A",
                            BuildingName = "Anderson Hall",
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 500, DateTimeKind.Local).AddTicks(5455),
                            Slug = "Anderson",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 530, DateTimeKind.Local).AddTicks(8991),
                            X = 100ul,
                            Y = 300ul
                        },
                        new
                        {
                            Id = 2,
                            BuildingAbrev = "ENGG",
                            BuildingName = "Engineering Building",
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 531, DateTimeKind.Local).AddTicks(1544),
                            Slug = "Engineering",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 531, DateTimeKind.Local).AddTicks(1619),
                            X = 0ul,
                            Y = 200ul
                        },
                        new
                        {
                            Id = 3,
                            BuildingAbrev = "BB",
                            BuildingName = "Business Building",
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 531, DateTimeKind.Local).AddTicks(1641),
                            Slug = "Business",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 531, DateTimeKind.Local).AddTicks(1653),
                            X = 300ul,
                            Y = 400ul
                        });
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.DoorHours", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("CloseTime")
                        .HasColumnType("TEXT");

                    b.Property<byte>("DayOfWeek")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DoorId")
                        .HasColumnType("INTEGER");

                    b.Property<TimeSpan>("OpenTime")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("DoorId");

                    b.ToTable("DoorHours");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CloseTime = new TimeSpan(0, 17, 15, 0, 0),
                            DayOfWeek = (byte)0,
                            DoorId = 3,
                            OpenTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 2,
                            CloseTime = new TimeSpan(0, 17, 15, 0, 0),
                            DayOfWeek = (byte)1,
                            DoorId = 3,
                            OpenTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 3,
                            CloseTime = new TimeSpan(0, 17, 15, 0, 0),
                            DayOfWeek = (byte)2,
                            DoorId = 3,
                            OpenTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 4,
                            CloseTime = new TimeSpan(0, 17, 15, 0, 0),
                            DayOfWeek = (byte)3,
                            DoorId = 3,
                            OpenTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 5,
                            CloseTime = new TimeSpan(0, 17, 15, 0, 0),
                            DayOfWeek = (byte)4,
                            DoorId = 3,
                            OpenTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 6,
                            CloseTime = new TimeSpan(0, 17, 15, 0, 0),
                            DayOfWeek = (byte)5,
                            DoorId = 3,
                            OpenTime = new TimeSpan(0, 8, 0, 0, 0)
                        },
                        new
                        {
                            Id = 7,
                            CloseTime = new TimeSpan(0, 17, 15, 0, 0),
                            DayOfWeek = (byte)6,
                            DoorId = 3,
                            OpenTime = new TimeSpan(0, 8, 0, 0, 0)
                        });
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Edge", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BuildingId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("DestinationNodeId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StartNodeId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.HasIndex("DestinationNodeId");

                    b.HasIndex("StartNodeId");

                    b.ToTable("Edge");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            BuildingId = 1,
                            DestinationNodeId = 3,
                            StartNodeId = 1
                        },
                        new
                        {
                            Id = 2,
                            BuildingId = 1,
                            DestinationNodeId = 2,
                            StartNodeId = 3
                        },
                        new
                        {
                            Id = 3,
                            BuildingId = 1,
                            DestinationNodeId = 1,
                            StartNodeId = 3
                        },
                        new
                        {
                            Id = 4,
                            BuildingId = 1,
                            DestinationNodeId = 3,
                            StartNodeId = 2
                        });
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Floor", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BuildingId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<string>("FloorMap")
                        .HasColumnType("TEXT");

                    b.Property<int>("FloorNumber")
                        .HasColumnType("INTEGER");

                    b.Property<string>("FloorString")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Floor");

                    b.HasData(
                        new
                        {
                            Id = 4,
                            BuildingId = 1,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 544, DateTimeKind.Local).AddTicks(6357),
                            FloorMap = "Anderson_3.svg",
                            FloorNumber = 3,
                            FloorString = "Third",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 545, DateTimeKind.Local).AddTicks(7505)
                        },
                        new
                        {
                            Id = 3,
                            BuildingId = 1,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4624),
                            FloorMap = "Anderson_2.svg",
                            FloorNumber = 2,
                            FloorString = "Second",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4773)
                        },
                        new
                        {
                            Id = 2,
                            BuildingId = 1,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4795),
                            FloorMap = "Anderson_1.svg",
                            FloorNumber = 1,
                            FloorString = "First",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4811)
                        },
                        new
                        {
                            Id = 1,
                            BuildingId = 1,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4828),
                            FloorMap = "Anderson_0.svg",
                            FloorNumber = 0,
                            FloorString = "Basement",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4841)
                        },
                        new
                        {
                            Id = 5,
                            BuildingId = 2,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4856),
                            FloorMap = "Engineering_0.svg",
                            FloorNumber = 0,
                            FloorString = "Basement",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4873)
                        },
                        new
                        {
                            Id = 6,
                            BuildingId = 2,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4888),
                            FloorMap = "Engineering_1.svg",
                            FloorNumber = 1,
                            FloorString = "First",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4901)
                        },
                        new
                        {
                            Id = 7,
                            BuildingId = 2,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4916),
                            FloorMap = "Engineering_2.svg",
                            FloorNumber = 2,
                            FloorString = "Second",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4928)
                        },
                        new
                        {
                            Id = 8,
                            BuildingId = 2,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4943),
                            FloorMap = "Engineering_3.svg",
                            FloorNumber = 3,
                            FloorString = "Third",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4956)
                        },
                        new
                        {
                            Id = 9,
                            BuildingId = 3,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4971),
                            FloorMap = "Business_0.svg",
                            FloorNumber = 0,
                            FloorString = "Basement",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4984)
                        },
                        new
                        {
                            Id = 10,
                            BuildingId = 3,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(4998),
                            FloorMap = "Business_1.svg",
                            FloorNumber = 1,
                            FloorString = "First",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5011)
                        },
                        new
                        {
                            Id = 11,
                            BuildingId = 3,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5027),
                            FloorMap = "Business_2.svg",
                            FloorNumber = 2,
                            FloorString = "Second",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5039)
                        },
                        new
                        {
                            Id = 12,
                            BuildingId = 3,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5054),
                            FloorMap = "Business_3.svg",
                            FloorNumber = 3,
                            FloorString = "Third",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5068)
                        },
                        new
                        {
                            Id = 13,
                            BuildingId = 3,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5083),
                            FloorMap = "Business_4.svg",
                            FloorNumber = 4,
                            FloorString = "Fourth",
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(5096)
                        });
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Node", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Accessible")
                        .HasColumnType("INTEGER");

                    b.Property<int>("BuildingId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("CreatedOn")
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("UpdatedOn")
                        .HasColumnType("TEXT");

                    b.Property<ulong>("X")
                        .HasColumnType("INTEGER");

                    b.Property<ulong>("Y")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("BuildingId");

                    b.ToTable("Node");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Accessible = false,
                            BuildingId = 1,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(7441),
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 546, DateTimeKind.Local).AddTicks(7480),
                            X = 600ul,
                            Y = 600ul
                        });
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.RoomTag", b =>
                {
                    b.Property<int>("RoomId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TagId")
                        .HasColumnType("INTEGER");

                    b.HasKey("RoomId", "TagId");

                    b.HasIndex("TagId");

                    b.ToTable("RoomTag");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("TagName")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Tag");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            TagName = "Bathroom"
                        },
                        new
                        {
                            Id = 2,
                            TagName = "Office"
                        },
                        new
                        {
                            Id = 3,
                            TagName = "Classroom"
                        },
                        new
                        {
                            Id = 4,
                            TagName = "Study Room"
                        },
                        new
                        {
                            Id = 5,
                            TagName = "Computer Lab"
                        },
                        new
                        {
                            Id = 6,
                            TagName = "Conference Room"
                        });
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Models.PortalUser", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Eid")
                        .HasColumnType("TEXT");

                    b.Property<string>("FirstName")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsAdmin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsFaculty")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsStaff")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsStudent")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsTeachingAssistant")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LastName")
                        .HasColumnType("TEXT");

                    b.Property<int>("Roles")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("Eid")
                        .IsUnique();

                    b.ToTable("PortalUser");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Eid = "nhbean",
                            FirstName = "Nathan",
                            IsAdmin = true,
                            IsFaculty = true,
                            IsStaff = false,
                            IsStudent = false,
                            IsTeachingAssistant = false,
                            LastName = "Bean",
                            Roles = 160
                        },
                        new
                        {
                            Id = 2,
                            Eid = "russfeld",
                            FirstName = "Russ",
                            IsAdmin = true,
                            IsFaculty = true,
                            IsStaff = false,
                            IsStudent = false,
                            IsTeachingAssistant = false,
                            LastName = "Feldhausen",
                            Roles = 160
                        },
                        new
                        {
                            Id = 3,
                            Eid = "weeser",
                            FirstName = "Josh",
                            IsAdmin = true,
                            IsFaculty = true,
                            IsStaff = false,
                            IsStudent = false,
                            IsTeachingAssistant = false,
                            LastName = "Weese",
                            Roles = 160
                        });
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Door", b =>
                {
                    b.HasBaseType("Ksu.Cs.Portal.Areas.Maps.Models.Node");

                    b.ToTable("Door");

                    b.HasData(
                        new
                        {
                            Id = 3,
                            Accessible = false,
                            BuildingId = 1,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 534, DateTimeKind.Local).AddTicks(2492),
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 534, DateTimeKind.Local).AddTicks(5466),
                            X = 400ul,
                            Y = 500ul
                        });
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Room", b =>
                {
                    b.HasBaseType("Ksu.Cs.Portal.Areas.Maps.Models.Node");

                    b.Property<int>("FloorId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RoomNumber")
                        .HasColumnType("TEXT");

                    b.HasIndex("FloorId");

                    b.ToTable("Room");

                    b.HasData(
                        new
                        {
                            Id = 2,
                            Accessible = false,
                            BuildingId = 1,
                            CreatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 548, DateTimeKind.Local).AddTicks(4912),
                            UpdatedOn = new DateTime(2022, 4, 8, 22, 14, 54, 548, DateTimeKind.Local).AddTicks(5083),
                            X = 500ul,
                            Y = 400ul,
                            FloorId = 4,
                            RoomNumber = "A308"
                        });
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.DoorHours", b =>
                {
                    b.HasOne("Ksu.Cs.Portal.Areas.Maps.Models.Door", "Door")
                        .WithMany("DoorHours")
                        .HasForeignKey("DoorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Door");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Edge", b =>
                {
                    b.HasOne("Ksu.Cs.Portal.Areas.Maps.Models.Building", "Building")
                        .WithMany("Edges")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ksu.Cs.Portal.Areas.Maps.Models.Node", "DestinationNode")
                        .WithMany("ToEdges")
                        .HasForeignKey("DestinationNodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ksu.Cs.Portal.Areas.Maps.Models.Node", "StartNode")
                        .WithMany("FromEdges")
                        .HasForeignKey("StartNodeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");

                    b.Navigation("DestinationNode");

                    b.Navigation("StartNode");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Floor", b =>
                {
                    b.HasOne("Ksu.Cs.Portal.Areas.Maps.Models.Building", "Building")
                        .WithMany("Floors")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Node", b =>
                {
                    b.HasOne("Ksu.Cs.Portal.Areas.Maps.Models.Building", "Building")
                        .WithMany("Nodes")
                        .HasForeignKey("BuildingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Building");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.RoomTag", b =>
                {
                    b.HasOne("Ksu.Cs.Portal.Areas.Maps.Models.Room", "Room")
                        .WithMany("RoomTags")
                        .HasForeignKey("RoomId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ksu.Cs.Portal.Areas.Maps.Models.Tag", "Tag")
                        .WithMany("RoomTags")
                        .HasForeignKey("TagId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Room");

                    b.Navigation("Tag");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Door", b =>
                {
                    b.HasOne("Ksu.Cs.Portal.Areas.Maps.Models.Node", null)
                        .WithOne()
                        .HasForeignKey("Ksu.Cs.Portal.Areas.Maps.Models.Door", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Room", b =>
                {
                    b.HasOne("Ksu.Cs.Portal.Areas.Maps.Models.Floor", "Floor")
                        .WithMany("Rooms")
                        .HasForeignKey("FloorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Ksu.Cs.Portal.Areas.Maps.Models.Node", null)
                        .WithOne()
                        .HasForeignKey("Ksu.Cs.Portal.Areas.Maps.Models.Room", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Floor");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Building", b =>
                {
                    b.Navigation("Edges");

                    b.Navigation("Floors");

                    b.Navigation("Nodes");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Floor", b =>
                {
                    b.Navigation("Rooms");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Node", b =>
                {
                    b.Navigation("FromEdges");

                    b.Navigation("ToEdges");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Tag", b =>
                {
                    b.Navigation("RoomTags");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Door", b =>
                {
                    b.Navigation("DoorHours");
                });

            modelBuilder.Entity("Ksu.Cs.Portal.Areas.Maps.Models.Room", b =>
                {
                    b.Navigation("RoomTags");
                });
#pragma warning restore 612, 618
        }
    }
}