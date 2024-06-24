﻿// <auto-generated />
using System;
using LinqExample.Console;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace LinqExample.Console.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("LinqExample.Console.Asistant", b =>
                {
                    b.Property<Guid>("Id")
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Asistants");
                });

            modelBuilder.Entity("LinqExample.Console.Course", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = new Guid("26f204d6-8060-4c4f-8ef8-cfe5ba2624f7"),
                            Title = "Math"
                        });
                });

            modelBuilder.Entity("LinqExample.Console.Student", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = new Guid("1d75e46a-401d-4f10-9d1d-82376b5187cf"),
                            FirstName = "John Doe",
                            LastName = "Öztürk"
                        },
                        new
                        {
                            Id = new Guid("f9d45b7b-039e-4976-93fa-6025b0c8f3f1"),
                            FirstName = "Jane Doe",
                            LastName = "Öztürk"
                        });
                });

            modelBuilder.Entity("LinqExample.Console.StudentCourse", b =>
                {
                    b.Property<Guid>("StudentId")
                        .HasColumnType("uuid");

                    b.Property<Guid>("CourseId")
                        .HasColumnType("uuid");

                    b.HasKey("StudentId", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourse");

                    b.HasData(
                        new
                        {
                            StudentId = new Guid("1d75e46a-401d-4f10-9d1d-82376b5187cf"),
                            CourseId = new Guid("26f204d6-8060-4c4f-8ef8-cfe5ba2624f7")
                        },
                        new
                        {
                            StudentId = new Guid("f9d45b7b-039e-4976-93fa-6025b0c8f3f1"),
                            CourseId = new Guid("26f204d6-8060-4c4f-8ef8-cfe5ba2624f7")
                        });
                });

            modelBuilder.Entity("LinqExample.Console.Teacher", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<Guid?>("CourseId")
                        .HasColumnType("uuid");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("LinqExample.Console.Asistant", b =>
                {
                    b.HasOne("LinqExample.Console.Course", "Course")
                        .WithOne("Asistant")
                        .HasForeignKey("LinqExample.Console.Asistant", "Id")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");
                });

            modelBuilder.Entity("LinqExample.Console.StudentCourse", b =>
                {
                    b.HasOne("LinqExample.Console.Course", "Course")
                        .WithMany("StudentCourses")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LinqExample.Console.Student", "Student")
                        .WithMany("StudentCourses")
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("LinqExample.Console.Teacher", b =>
                {
                    b.HasOne("LinqExample.Console.Course", null)
                        .WithMany("Teachers")
                        .HasForeignKey("CourseId");
                });

            modelBuilder.Entity("LinqExample.Console.Course", b =>
                {
                    b.Navigation("Asistant")
                        .IsRequired();

                    b.Navigation("StudentCourses");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("LinqExample.Console.Student", b =>
                {
                    b.Navigation("StudentCourses");
                });
#pragma warning restore 612, 618
        }
    }
}
