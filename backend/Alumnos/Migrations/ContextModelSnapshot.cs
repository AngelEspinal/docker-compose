﻿// <auto-generated />
using System;
using Alumnos.models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Alumnos.Migrations
{
    [DbContext(typeof(Context))]
    partial class ContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Alumnos.models.Career", b =>
                {
                    b.Property<string>("IdCareer")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("IdProfessionalSchool")
                        .HasColumnType("int");

                    b.Property<string>("NameCareer")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCareer");

                    b.HasIndex("IdProfessionalSchool");

                    b.ToTable("Tcareer");
                });

            modelBuilder.Entity("Alumnos.models.Course", b =>
                {
                    b.Property<string>("IdCourse")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NameCourse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCourse");

                    b.ToTable("Tcourse");
                });

            modelBuilder.Entity("Alumnos.models.CourseAssignment", b =>
                {
                    b.Property<int>("IdCarga")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdCarga"));

                    b.Property<int?>("IdSchedule")
                        .HasColumnType("int");

                    b.Property<string>("IdTeacher")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdCarga");

                    b.HasIndex("IdSchedule")
                        .IsUnique()
                        .HasFilter("[IdSchedule] IS NOT NULL");

                    b.HasIndex("IdTeacher");

                    b.ToTable("TcourseAssignment");
                });

            modelBuilder.Entity("Alumnos.models.CourseStudent", b =>
                {
                    b.Property<string>("IdStudent")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(0);

                    b.Property<string>("IdCourse")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(1);

                    b.Property<string>("IdSemester")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(3);

                    b.Property<string>("IdTeacher")
                        .HasColumnType("nvarchar(450)")
                        .HasColumnOrder(2);

                    b.HasKey("IdStudent", "IdCourse", "IdSemester", "IdTeacher");

                    b.HasIndex("IdSemester", "IdCourse");

                    b.ToTable("TcourseStudents");
                });

            modelBuilder.Entity("Alumnos.models.InfoLimpieza", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Aula")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorEnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HoraInit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdCourse")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdSemester")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdStudent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdTeacher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("TinfoLimpieza");
                });

            modelBuilder.Entity("Alumnos.models.ProfessionalSchool", b =>
                {
                    b.Property<int>("IdProfessionalSchool")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdProfessionalSchool"));

                    b.Property<string>("NameProfessionalSchool")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdProfessionalSchool");

                    b.ToTable("TprofessionalSchool");
                });

            modelBuilder.Entity("Alumnos.models.Schedule", b =>
                {
                    b.Property<int>("IdSchedule")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSchedule"));

                    b.Property<string>("Day")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorEnd")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HorInit")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdCourse")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdSemester")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdSchedule");

                    b.HasIndex("IdSemester", "IdCourse");

                    b.ToTable("Tschedule");
                });

            modelBuilder.Entity("Alumnos.models.Semester", b =>
                {
                    b.Property<string>("IdSemester")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdCourse")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdCareer")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdSemester", "IdCourse");

                    b.HasIndex("IdCareer");

                    b.HasIndex("IdCourse");

                    b.ToTable("Tsemester");
                });

            modelBuilder.Entity("Alumnos.models.Student", b =>
                {
                    b.Property<string>("IdStudent")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NameStudent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdStudent");

                    b.ToTable("Tstudent");
                });

            modelBuilder.Entity("Alumnos.models.Teacher", b =>
                {
                    b.Property<string>("IdTeacher")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NameTeacher")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTeacher");

                    b.ToTable("Tteacher");
                });

            modelBuilder.Entity("Alumnos.models.Career", b =>
                {
                    b.HasOne("Alumnos.models.ProfessionalSchool", "ProfessionalSchool")
                        .WithMany("Carrer")
                        .HasForeignKey("IdProfessionalSchool")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProfessionalSchool");
                });

            modelBuilder.Entity("Alumnos.models.CourseAssignment", b =>
                {
                    b.HasOne("Alumnos.models.Schedule", "Schedule")
                        .WithOne("CourseAssignments")
                        .HasForeignKey("Alumnos.models.CourseAssignment", "IdSchedule")
                        .OnDelete(DeleteBehavior.Restrict);

                    b.HasOne("Alumnos.models.Teacher", "Teacher")
                        .WithMany("CourseAssignment")
                        .HasForeignKey("IdTeacher")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Schedule");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("Alumnos.models.CourseStudent", b =>
                {
                    b.HasOne("Alumnos.models.Student", "Student")
                        .WithMany("CourseStudent")
                        .HasForeignKey("IdStudent")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Alumnos.models.Semester", "Semester")
                        .WithMany()
                        .HasForeignKey("IdSemester", "IdCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semester");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("Alumnos.models.Schedule", b =>
                {
                    b.HasOne("Alumnos.models.Semester", "Semester")
                        .WithMany()
                        .HasForeignKey("IdSemester", "IdCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("Alumnos.models.Semester", b =>
                {
                    b.HasOne("Alumnos.models.Career", "Career")
                        .WithMany("Semester")
                        .HasForeignKey("IdCareer")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Alumnos.models.Course", "Course")
                        .WithMany("Semesters")
                        .HasForeignKey("IdCourse")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Career");

                    b.Navigation("Course");
                });

            modelBuilder.Entity("Alumnos.models.Career", b =>
                {
                    b.Navigation("Semester");
                });

            modelBuilder.Entity("Alumnos.models.Course", b =>
                {
                    b.Navigation("Semesters");
                });

            modelBuilder.Entity("Alumnos.models.ProfessionalSchool", b =>
                {
                    b.Navigation("Carrer");
                });

            modelBuilder.Entity("Alumnos.models.Schedule", b =>
                {
                    b.Navigation("CourseAssignments");
                });

            modelBuilder.Entity("Alumnos.models.Student", b =>
                {
                    b.Navigation("CourseStudent");
                });

            modelBuilder.Entity("Alumnos.models.Teacher", b =>
                {
                    b.Navigation("CourseAssignment");
                });
#pragma warning restore 612, 618
        }
    }
}
