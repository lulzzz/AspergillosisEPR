﻿using Microsoft.EntityFrameworkCore;
using AspergillosisEPR.Models;
using AspergillosisEPR.Extensions;

namespace AspergillosisEPR.Data
{
    public class AspergillosisContext : DbContext
    {
        public AspergillosisContext(DbContextOptions<AspergillosisContext> options) : base(options)
        {
        }

        public DbSet<Patient> Patients { get; set; }
        public DbSet<DiagnosisType> DiagnosisTypes { get; set; }
        public DbSet<PatientDiagnosis> PatientDiagnoses { get; set; }
        public DbSet<DiagnosisCategory> DiagnosisCategories { get; set; }
        public DbSet<Drug> Drugs { get; set; }
        public DbSet<PatientDrug> PatientDrugs { get; set; }
        public DbSet<SideEffect> SideEffects { get; set; }
        public DbSet<PatientDrugSideEffect> PatientDrugSideEffects { get; set; }
        public DbSet<PatientStatus> PatientStatuses { get; set; }
        public DbSet<DbImport> DbImports { get; set; }
        public DbSet<PatientSTGQuestionnaire> PatientSTGQuestionnaires { get; set; }
        public DbSet<DbImportType> DBImportTypes { get; set; }
        public DbSet<ImmunoglobulinType> ImmunoglobulinTypes { get; set; }
        public DbSet<PatientImmunoglobulin> PatientImmunoglobulins { get; set; }
        public DbSet<Finding> Findings { get; set; }
        public DbSet<ChestLocation> ChestLocations { get; set; }
        public DbSet<ChestDistribution> ChestDistributions { get; set; }
        public DbSet<Grade> Grades { get; set; }
        public DbSet<TreatmentResponse> TreatmentResponses { get; set; }
        public DbSet<RadiologyType> RadiologyTypes { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Patient>().ToTable("Patients");
            modelBuilder.Entity<PatientDiagnosis>().ToTable("PatientDiagnosis");
            modelBuilder.Entity<DiagnosisType>().ToTable("DiagnosisTypes");
            modelBuilder.Entity<DiagnosisCategory>().ToTable("DiagnosisCategories");
            modelBuilder.Entity<Drug>().ToTable("Drugs");
            modelBuilder.Entity<PatientDrug>().ToTable("PatientDrugs");
            modelBuilder.Entity<SideEffect>().ToTable("SideEffects");
            modelBuilder.Entity<PatientDrugSideEffect>().ToTable("PatientDrugSideEffects");
            modelBuilder.Entity<PatientStatus>().ToTable("PatientStatuses");
            modelBuilder.Entity<DbImport>().ToTable("DbImports");
            modelBuilder.Entity<PatientSTGQuestionnaire>().ToTable("PatientSTGQuestionnaires");
            modelBuilder.Entity<PatientSTGQuestionnaire>().Property(x => x.ImpactScore).HasPrecision(10, 2);
            modelBuilder.Entity<PatientSTGQuestionnaire>().Property(x => x.ActivityScore).HasPrecision(10, 2);
            modelBuilder.Entity<PatientSTGQuestionnaire>().Property(x => x.TotalScore).HasPrecision(10, 2);
            modelBuilder.Entity<PatientSTGQuestionnaire>().Property(x => x.SymptomScore).HasPrecision(10, 2);
            modelBuilder.Entity<DbImportType>().ToTable("DbImportTypes");
            modelBuilder.Entity<ImmunoglobulinType>().ToTable("ImmunoglobulinTypes");
            modelBuilder.Entity<PatientImmunoglobulin>().ToTable("PatientImmunoglobulins");
            modelBuilder.Entity<Finding>().ToTable("Findings");
            modelBuilder.Entity<ChestLocation>().ToTable("ChestLocations");
            modelBuilder.Entity<ChestDistribution>().ToTable("ChestDistributions");
            modelBuilder.Entity<Grade>().ToTable("Grades");
            modelBuilder.Entity<TreatmentResponse>().ToTable("TreatmentResponses");
            modelBuilder.Entity<RadiologyType>().ToTable("RadiologyTypes");
        }
    }


}