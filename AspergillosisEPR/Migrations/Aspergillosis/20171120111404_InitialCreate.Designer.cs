﻿// <auto-generated />
using AspergillosisEPR.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.EntityFrameworkCore.Storage.Internal;
using System;

namespace AspergillosisEPR.Migrations.Aspergillosis
{
    [DbContext(typeof(AspergillosisContext))]
    [Migration("20171120111404_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.0.1-rtm-125")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("AspergillosisEPR.Models.DiagnosisCategory", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("CategoryName");

                    b.HasKey("ID");

                    b.ToTable("DiagnosisCategories");
                });

            modelBuilder.Entity("AspergillosisEPR.Models.DiagnosisType", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("DiagnosisTypes");
                });

            modelBuilder.Entity("AspergillosisEPR.Models.Drug", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Name");

                    b.HasKey("ID");

                    b.ToTable("Drugs");
                });

            modelBuilder.Entity("AspergillosisEPR.Models.Patient", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("DOB");

                    b.Property<string>("FirstName")
                        .IsRequired();

                    b.Property<string>("Gender")
                        .IsRequired();

                    b.Property<string>("LastName")
                        .IsRequired();

                    b.Property<string>("RM2Number")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.HasKey("ID");

                    b.ToTable("Patients");
                });

            modelBuilder.Entity("AspergillosisEPR.Models.PatientDiagnosis", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasColumnType("ntext");

                    b.Property<int>("DiagnosisCategoryId");

                    b.Property<int>("DiagnosisTypeId");

                    b.Property<int>("PatientId");

                    b.HasKey("ID");

                    b.HasIndex("DiagnosisCategoryId");

                    b.HasIndex("DiagnosisTypeId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientDiagnosis");
                });

            modelBuilder.Entity("AspergillosisEPR.Models.PatientDrug", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("DrugId");

                    b.Property<DateTime>("EndDate");

                    b.Property<int>("PatientId");

                    b.Property<DateTime>("StartDate");

                    b.HasKey("ID");

                    b.HasIndex("DrugId");

                    b.HasIndex("PatientId");

                    b.ToTable("PatientDrugs");
                });

            modelBuilder.Entity("AspergillosisEPR.Models.PatientDiagnosis", b =>
                {
                    b.HasOne("AspergillosisEPR.Models.DiagnosisCategory", "DiagnosisCategory")
                        .WithMany("PatientDiagnoses")
                        .HasForeignKey("DiagnosisCategoryId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AspergillosisEPR.Models.DiagnosisType", "DiagnosisType")
                        .WithMany("PatientDiagnoses")
                        .HasForeignKey("DiagnosisTypeId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AspergillosisEPR.Models.Patient", "Patient")
                        .WithMany("PatientDiagnoses")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("AspergillosisEPR.Models.PatientDrug", b =>
                {
                    b.HasOne("AspergillosisEPR.Models.Drug", "Drug")
                        .WithMany()
                        .HasForeignKey("DrugId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("AspergillosisEPR.Models.Patient", "Patient")
                        .WithMany("PatientDrugs")
                        .HasForeignKey("PatientId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
