﻿// <auto-generated />
using System;
using DataBaseManger;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataBaseManger.Migrations
{
    [DbContext(typeof(SERDBContext))]
    partial class SERDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.17");

            modelBuilder.Entity("DataBaseManger.Modules.DataLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Action")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<int?>("MainDataBaseVerisonId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TargetClass")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("MainDataBaseVerisonId");

                    b.HasIndex("UserId");

                    b.ToTable("DataLog");
                });

            modelBuilder.Entity("DataBaseManger.Modules.Division", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("MainDivisionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("MainDivisionId");

                    b.ToTable("Divisions");
                });

            modelBuilder.Entity("DataBaseManger.Modules.EducationalInstitution", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("EducationalInstitutions");
                });

            modelBuilder.Entity("DataBaseManger.Modules.InstitutionDivision", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("DivisionId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("EducationalInstitutionId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("DivisionId");

                    b.HasIndex("EducationalInstitutionId");

                    b.ToTable("InstitutionDivisions");
                });

            modelBuilder.Entity("DataBaseManger.Modules.MainDataBaseVerison", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Verison")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("MainDataBaseVerison");
                });

            modelBuilder.Entity("DataBaseManger.Modules.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Code")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("InstitutionDivisionId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("Stat")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Year")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("InstitutionDivisionId");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("DataBaseManger.Modules.StudentSubjectManged", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("AddDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("AddId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("AddSupportId")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("ConferdDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("ConfermId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ConfermSupportId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectScoreType")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("AddId");

                    b.HasIndex("AddSupportId");

                    b.HasIndex("ConfermId");

                    b.HasIndex("ConfermSupportId");

                    b.ToTable("StudentSubjectMangeds");
                });

            modelBuilder.Entity("DataBaseManger.Modules.StudentSubjectScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Confirmed")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("Score")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScoreType")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StudentId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("StudentSubjectMangedId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("StudentSubjectStat")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("StudentId");

                    b.HasIndex("StudentSubjectMangedId");

                    b.HasIndex("SubjectId");

                    b.ToTable("StudentSubjectScores");
                });

            modelBuilder.Entity("DataBaseManger.Modules.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int?>("SubjectScoreRateId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SubjectScoreRateId");

                    b.ToTable("Subjects");
                });

            modelBuilder.Entity("DataBaseManger.Modules.SubjectScore", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("MaximumScore")
                        .HasColumnType("INTEGER");

                    b.Property<uint>("MinimumScore")
                        .HasColumnType("INTEGER");

                    b.Property<int>("ScoreType")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("SubjectId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("SubjectScores");
                });

            modelBuilder.Entity("DataBaseManger.Modules.SubjectScoreRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Excellent")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Good")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<int>("PassMin")
                        .HasColumnType("INTEGER");

                    b.Property<int>("VeryGood")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("SubjectScoreRates");
                });

            modelBuilder.Entity("DataBaseManger.Modules.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Active")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CanLogin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("IsLogin")
                        .HasColumnType("INTEGER");

                    b.Property<bool>("MustChangePass")
                        .HasColumnType("INTEGER");

                    b.Property<string>("NID")
                        .HasMaxLength(14)
                        .HasColumnType("TEXT");

                    b.Property<string>("Name")
                        .HasColumnType("TEXT");

                    b.Property<string>("Pass")
                        .HasColumnType("TEXT");

                    b.Property<int>("UserAccess")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("DivisionSubject", b =>
                {
                    b.Property<int>("DivisionsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("SubjectsId")
                        .HasColumnType("INTEGER");

                    b.HasKey("DivisionsId", "SubjectsId");

                    b.HasIndex("SubjectsId");

                    b.ToTable("DivisionSubject");
                });

            modelBuilder.Entity("InstitutionDivisionUser", b =>
                {
                    b.Property<int>("InstitutionDivisionsId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UsersId")
                        .HasColumnType("INTEGER");

                    b.HasKey("InstitutionDivisionsId", "UsersId");

                    b.HasIndex("UsersId");

                    b.ToTable("InstitutionDivisionUser");
                });

            modelBuilder.Entity("DataBaseManger.Modules.DataLog", b =>
                {
                    b.HasOne("DataBaseManger.Modules.MainDataBaseVerison", "MainDataBaseVerison")
                        .WithMany("Logs")
                        .HasForeignKey("MainDataBaseVerisonId");

                    b.HasOne("DataBaseManger.Modules.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId");

                    b.Navigation("MainDataBaseVerison");

                    b.Navigation("User");
                });

            modelBuilder.Entity("DataBaseManger.Modules.Division", b =>
                {
                    b.HasOne("DataBaseManger.Modules.Division", "MainDivision")
                        .WithMany("SubDivisions")
                        .HasForeignKey("MainDivisionId");

                    b.Navigation("MainDivision");
                });

            modelBuilder.Entity("DataBaseManger.Modules.InstitutionDivision", b =>
                {
                    b.HasOne("DataBaseManger.Modules.Division", "Division")
                        .WithMany("InstitutionDivisions")
                        .HasForeignKey("DivisionId");

                    b.HasOne("DataBaseManger.Modules.EducationalInstitution", "EducationalInstitution")
                        .WithMany("InstitutionDivisions")
                        .HasForeignKey("EducationalInstitutionId");

                    b.Navigation("Division");

                    b.Navigation("EducationalInstitution");
                });

            modelBuilder.Entity("DataBaseManger.Modules.Student", b =>
                {
                    b.HasOne("DataBaseManger.Modules.InstitutionDivision", "InstitutionDivision")
                        .WithMany("Students")
                        .HasForeignKey("InstitutionDivisionId");

                    b.Navigation("InstitutionDivision");
                });

            modelBuilder.Entity("DataBaseManger.Modules.StudentSubjectManged", b =>
                {
                    b.HasOne("DataBaseManger.Modules.User", "Add")
                        .WithMany()
                        .HasForeignKey("AddId");

                    b.HasOne("DataBaseManger.Modules.User", "AddSupport")
                        .WithMany()
                        .HasForeignKey("AddSupportId");

                    b.HasOne("DataBaseManger.Modules.User", "Conferm")
                        .WithMany()
                        .HasForeignKey("ConfermId");

                    b.HasOne("DataBaseManger.Modules.User", "ConfermSupport")
                        .WithMany()
                        .HasForeignKey("ConfermSupportId");

                    b.Navigation("Add");

                    b.Navigation("AddSupport");

                    b.Navigation("Conferm");

                    b.Navigation("ConfermSupport");
                });

            modelBuilder.Entity("DataBaseManger.Modules.StudentSubjectScore", b =>
                {
                    b.HasOne("DataBaseManger.Modules.Student", "Student")
                        .WithMany("Scores")
                        .HasForeignKey("StudentId");

                    b.HasOne("DataBaseManger.Modules.StudentSubjectManged", "StudentSubjectManged")
                        .WithMany()
                        .HasForeignKey("StudentSubjectMangedId");

                    b.HasOne("DataBaseManger.Modules.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId");

                    b.Navigation("Student");

                    b.Navigation("StudentSubjectManged");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("DataBaseManger.Modules.Subject", b =>
                {
                    b.HasOne("DataBaseManger.Modules.SubjectScoreRate", "SubjectScoreRate")
                        .WithMany("Subjects")
                        .HasForeignKey("SubjectScoreRateId");

                    b.Navigation("SubjectScoreRate");
                });

            modelBuilder.Entity("DataBaseManger.Modules.SubjectScore", b =>
                {
                    b.HasOne("DataBaseManger.Modules.Subject", "Subject")
                        .WithMany("SubjectScores")
                        .HasForeignKey("SubjectId");

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("DivisionSubject", b =>
                {
                    b.HasOne("DataBaseManger.Modules.Division", null)
                        .WithMany()
                        .HasForeignKey("DivisionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBaseManger.Modules.Subject", null)
                        .WithMany()
                        .HasForeignKey("SubjectsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("InstitutionDivisionUser", b =>
                {
                    b.HasOne("DataBaseManger.Modules.InstitutionDivision", null)
                        .WithMany()
                        .HasForeignKey("InstitutionDivisionsId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DataBaseManger.Modules.User", null)
                        .WithMany()
                        .HasForeignKey("UsersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DataBaseManger.Modules.Division", b =>
                {
                    b.Navigation("InstitutionDivisions");

                    b.Navigation("SubDivisions");
                });

            modelBuilder.Entity("DataBaseManger.Modules.EducationalInstitution", b =>
                {
                    b.Navigation("InstitutionDivisions");
                });

            modelBuilder.Entity("DataBaseManger.Modules.InstitutionDivision", b =>
                {
                    b.Navigation("Students");
                });

            modelBuilder.Entity("DataBaseManger.Modules.MainDataBaseVerison", b =>
                {
                    b.Navigation("Logs");
                });

            modelBuilder.Entity("DataBaseManger.Modules.Student", b =>
                {
                    b.Navigation("Scores");
                });

            modelBuilder.Entity("DataBaseManger.Modules.Subject", b =>
                {
                    b.Navigation("SubjectScores");
                });

            modelBuilder.Entity("DataBaseManger.Modules.SubjectScoreRate", b =>
                {
                    b.Navigation("Subjects");
                });
#pragma warning restore 612, 618
        }
    }
}
