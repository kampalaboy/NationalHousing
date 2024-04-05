using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace HCMISAPI.Models
{
    public partial class HCMISContext : DbContext
    {
        public HCMISContext()
        {
        }

        public HCMISContext(DbContextOptions<HCMISContext> options)
            : base(options)
        {
        }

        public virtual DbSet<AAppraisalReason> AAppraisalReason { get; set; } = null!;
        public virtual DbSet<ABank> ABank { get; set; } = null!;
        public virtual DbSet<ABehavioralCompetencies> ABehavioralCompetencies { get; set; } = null!;
        public virtual DbSet<ABscKpi> ABscKpi { get; set; } = null!;
        public virtual DbSet<ABscPerformanceMeasurement> ABscPerformanceMeasurement { get; set; } = null!;
        public virtual DbSet<ABscPerspectives> ABscPerspectives { get; set; } = null!;
        public virtual DbSet<AContractLengthType> AContractLengthType { get; set; } = null!;
        public virtual DbSet<ACountry> ACountry { get; set; } = null!;
        public virtual DbSet<ACurrency> ACurrency { get; set; } = null!;
        public virtual DbSet<ADepartment> ADepartment { get; set; } = null!;
        public virtual DbSet<ADistrict> ADistrict { get; set; } = null!;
        public virtual DbSet<AEmployeeEvidence> AEmployeeEvidence { get; set; } = null!;
        public virtual DbSet<AFieldOfStudy> AFieldOfStudy { get; set; } = null!;
        public virtual DbSet<AFinancialYear> AFinancialYear { get; set; } = null!;
        public virtual DbSet<AGender> AGender { get; set; } = null!;
        public virtual DbSet<AIdentificationType> AIdentificationType { get; set; } = null!;
        public virtual DbSet<AJobStatus> AJobStatus { get; set; } = null!;
        public virtual DbSet<AJobTitle> AJobTitle { get; set; } = null!;
        public virtual DbSet<AJobType> AJobType { get; set; } = null!;
        public virtual DbSet<ALanguageProlific> ALanguageProlific { get; set; } = null!;
        public virtual DbSet<ALanguages> ALanguages { get; set; } = null!;
        public virtual DbSet<ALevelofEducation> ALevelofEducation { get; set; } = null!;
        public virtual DbSet<AMaritalStatus> AMaritalStatus { get; set; } = null!;
        public virtual DbSet<AMobilePhoneEntitlement> AMobilePhoneEntitlement { get; set; } = null!;
        public virtual DbSet<AParish> AParish { get; set; } = null!;
        public virtual DbSet<APerformanceDescriptor> APerformanceDescriptor { get; set; } = null!;
        public virtual DbSet<APublicHolidayAllowance> APublicHolidayAllowance { get; set; } = null!;
        public virtual DbSet<ARelationship> ARelationship { get; set; } = null!;
        public virtual DbSet<ASafariAllowance> ASafariAllowance { get; set; } = null!;
        public virtual DbSet<ASalaryScale> ASalaryScale { get; set; } = null!;
        public virtual DbSet<ASkillLevel> ASkillLevel { get; set; } = null!;
        public virtual DbSet<ASubCounty> ASubCounty { get; set; } = null!;
        public virtual DbSet<ATravelAbroadAllowance> ATravelAbroadAllowance { get; set; } = null!;
        public virtual DbSet<ATravelClass> ATravelClass { get; set; } = null!;
        public virtual DbSet<AVillage> AVillage { get; set; } = null!;
        public virtual DbSet<AspNetEmailConfirmationCode> AspNetEmailConfirmationCode { get; set; } = null!;
        public virtual DbSet<AspNetRoleClaims> AspNetRoleClaims { get; set; } = null!;
        public virtual DbSet<AspNetRoles> AspNetRoles { get; set; } = null!;
        public virtual DbSet<AspNetUserClaims> AspNetUserClaims { get; set; } = null!;
        public virtual DbSet<AspNetUserLogins> AspNetUserLogins { get; set; } = null!;
        public virtual DbSet<AspNetUserTokens> AspNetUserTokens { get; set; } = null!;
        public virtual DbSet<AspNetUsers> AspNetUsers { get; set; } = null!;
        public virtual DbSet<BalanceScoreCard> BalanceScoreCard { get; set; } = null!;
        public virtual DbSet<BalanceScoreCardBehavioral> BalanceScoreCardBehavioral { get; set; } = null!;
        public virtual DbSet<BalanceScoreCardTargetSetting> BalanceScoreCardTargetSetting { get; set; } = null!;
        public virtual DbSet<Employee> Employee { get; set; } = null!;
        public virtual DbSet<EmployeeLanguagesKnown> EmployeeLanguagesKnown { get; set; } = null!;
        public virtual DbSet<EmployeeNextOfKin> EmployeeNextOfKin { get; set; } = null!;
        public virtual DbSet<EmployeeQualification> EmployeeQualification { get; set; } = null!;
        public virtual DbSet<EmployeeSkills> EmployeeSkills { get; set; } = null!;
        public virtual DbSet<EmployeeWorkExperience> EmployeeWorkExperience { get; set; } = null!;
        public virtual DbSet<Exit> Exit { get; set; } = null!;
        public virtual DbSet<JobDescription> JobDescription { get; set; } = null!;
        public virtual DbSet<JobDescriptionBenefit> JobDescriptionBenefit { get; set; } = null!;
        public virtual DbSet<JobDescriptionKnowledge> JobDescriptionKnowledge { get; set; } = null!;
        public virtual DbSet<JobDescriptionResponsibility> JobDescriptionResponsibility { get; set; } = null!;
        public virtual DbSet<JobDescriptionWorkExperienceRequirement> JobDescriptionWorkExperienceRequirement { get; set; } = null!;
        public virtual DbSet<NonStaff> NonStaff { get; set; } = null!;
        public virtual DbSet<NonStaffLanguagesKnown> NonStaffLanguagesKnown { get; set; } = null!;
        public virtual DbSet<NonStaffNextOfKin> NonStaffNextOfKin { get; set; } = null!;
        public virtual DbSet<NonStaffQualification> NonStaffQualification { get; set; } = null!;
        public virtual DbSet<NonStaffSkills> NonStaffSkills { get; set; } = null!;
        public virtual DbSet<NonStaffWorkExperience> NonStaffWorkExperience { get; set; } = null!;
        public virtual DbSet<TrainingAMethod> TrainingAMethod { get; set; } = null!;
        public virtual DbSet<TrainingAProfessionalAssociation> TrainingAProfessionalAssociation { get; set; } = null!;
        public virtual DbSet<TrainingATargetTeam> TrainingATargetTeam { get; set; } = null!;
        public virtual DbSet<TrainingCpd> TrainingCpd { get; set; } = null!;
        public virtual DbSet<TrainingGeneralInternal> TrainingGeneralInternal { get; set; } = null!;
        public virtual DbSet<TrainingGeneralInternalBudget> TrainingGeneralInternalBudget { get; set; } = null!;
        public virtual DbSet<TrainingSubscription> TrainingSubscription { get; set; } = null!;
        public virtual DbSet<ViewOrgStructureDepartment> ViewOrgStructureDepartment { get; set; } = null!;
        public virtual DbSet<ViewOrgStructureJobTitle> ViewOrgStructureJobTitle { get; set; } = null!;
        public virtual DbSet<ViewUserManagement> ViewUserManagement { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
//#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.;Database=NHCCHumanResourceSystem;User Id=sa;password=root85;Trusted_Connection=False;MultipleActiveResultSets=true;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AAppraisalReason>(entity =>
            {
                entity.HasKey(e => e.AppraisalReasonId);

                entity.ToTable("A_AppraisalReason");

                entity.Property(e => e.AppraisalReasonId).ValueGeneratedNever();

                entity.Property(e => e.AppraisalReason).HasMaxLength(3000);
            });

            modelBuilder.Entity<ABank>(entity =>
            {
                entity.HasKey(e => e.BankId);

                entity.ToTable("A_Bank");

                entity.Property(e => e.BankId).ValueGeneratedNever();

                entity.Property(e => e.BankDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ABehavioralCompetencies>(entity =>
            {
                entity.HasKey(e => e.CompetenceId);

                entity.ToTable("A_BehavioralCompetencies");

                entity.Property(e => e.CompetenceId).ValueGeneratedNever();

                entity.Property(e => e.CompetenceDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ABscKpi>(entity =>
            {
                entity.HasKey(e => e.Bsckpiid)
                    .HasName("PK_A_BSCKPI");

                entity.ToTable("A_BscKPI");

                entity.Property(e => e.Bsckpiid)
                    .ValueGeneratedNever()
                    .HasColumnName("BSCKPIId");

                entity.Property(e => e.Bsckpidescription)
                    .HasMaxLength(3000)
                    .HasColumnName("BSCKPIDescription");
            });

            modelBuilder.Entity<ABscPerformanceMeasurement>(entity =>
            {
                entity.HasKey(e => e.MeasurementMetricId);

                entity.ToTable("A_BscPerformanceMeasurement");

                entity.Property(e => e.MeasurementMetricId).ValueGeneratedNever();

                entity.Property(e => e.MeasurementMetricDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ABscPerspectives>(entity =>
            {
                entity.HasKey(e => e.BscPerspectiveId);

                entity.ToTable("A_BscPerspectives");

                entity.Property(e => e.BscPerspectiveId).ValueGeneratedNever();

                entity.Property(e => e.BscPerspectiveDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AContractLengthType>(entity =>
            {
                entity.HasKey(e => e.ContractLengthTypeId);

                entity.ToTable("A_ContractLengthType");

                entity.Property(e => e.ContractLengthTypeId).ValueGeneratedNever();

                entity.Property(e => e.ContractLengthTypeDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACountry>(entity =>
            {
                entity.HasKey(e => e.CoutryId);

                entity.ToTable("A_Country");

                entity.Property(e => e.CoutryId).ValueGeneratedNever();

                entity.Property(e => e.CountryCode).HasMaxLength(50);

                entity.Property(e => e.CountryDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ACurrency>(entity =>
            {
                entity.HasKey(e => e.IsoCode);

                entity.ToTable("A_Currency");

                entity.Property(e => e.IsoCode)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.Currency).HasMaxLength(250);
            });

            modelBuilder.Entity<ADepartment>(entity =>
            {
                entity.HasKey(e => e.DepartmentId);

                entity.ToTable("A_Department");

                entity.Property(e => e.DepartmentId).ValueGeneratedNever();

                entity.Property(e => e.DepartmentDescription).HasMaxLength(3000);

                entity.Property(e => e.ReportsTo).HasMaxLength(1000);
            });

            modelBuilder.Entity<ADistrict>(entity =>
            {
                entity.HasKey(e => e.DistrictId);

                entity.ToTable("A_District");

                entity.Property(e => e.DistrictId).ValueGeneratedNever();

                entity.Property(e => e.DistrictDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AEmployeeEvidence>(entity =>
            {
                entity.HasKey(e => e.EvidenceId);

                entity.ToTable("A_EmployeeEvidence");

                entity.Property(e => e.EvidenceId).ValueGeneratedNever();

                entity.Property(e => e.EvidenceDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AFieldOfStudy>(entity =>
            {
                entity.HasKey(e => e.FieldOfStudyId);

                entity.ToTable("A_FieldOfStudy");

                entity.Property(e => e.FieldOfStudyId).ValueGeneratedNever();

                entity.Property(e => e.FieldOfStudyDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AFinancialYear>(entity =>
            {
                entity.ToTable("A_FinancialYear");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.FinancialYear).HasMaxLength(50);
            });

            modelBuilder.Entity<AGender>(entity =>
            {
                entity.HasKey(e => e.GenderId);

                entity.ToTable("A_Gender");

                entity.Property(e => e.GenderId).ValueGeneratedNever();

                entity.Property(e => e.GenderDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AIdentificationType>(entity =>
            {
                entity.HasKey(e => e.IdentificationTypeId);

                entity.ToTable("A_IdentificationType");

                entity.Property(e => e.IdentificationTypeId).ValueGeneratedNever();

                entity.Property(e => e.IdentificationTypeDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AJobStatus>(entity =>
            {
                entity.HasKey(e => e.JobStatusId);

                entity.ToTable("A_JobStatus");

                entity.Property(e => e.JobStatusId).ValueGeneratedNever();

                entity.Property(e => e.JobStatusDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AJobTitle>(entity =>
            {
                entity.HasKey(e => e.JobTitleId)
                    .HasName("PK_A_JobPosition");

                entity.ToTable("A_JobTitle");

                entity.Property(e => e.JobTitleId).ValueGeneratedNever();

                entity.Property(e => e.JobTitleDescription).HasMaxLength(3000);

                entity.Property(e => e.ReportsTo).HasMaxLength(1000);

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.AJobTitle)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_A_JobPosition_A_Department");
            });

            modelBuilder.Entity<AJobType>(entity =>
            {
                entity.HasKey(e => e.JobTypeId);

                entity.ToTable("A_JobType");

                entity.Property(e => e.JobTypeId)
                    .ValueGeneratedNever()
                    .HasComment("This Column is the primary key for the job types and it will be auto incremented whenever a new job type is added");

                entity.Property(e => e.TypeDescription)
                    .HasMaxLength(3000)
                    .HasComment("This column will handle the description of the type of job that will be displayed in the dropdowns and other parts in the system");
            });

            modelBuilder.Entity<ALanguageProlific>(entity =>
            {
                entity.HasKey(e => e.LanguageProlificId);

                entity.ToTable("A_LanguageProlific");

                entity.Property(e => e.LanguageProlificId).ValueGeneratedNever();

                entity.Property(e => e.LanguageProlificDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ALanguages>(entity =>
            {
                entity.HasKey(e => e.LanguageId);

                entity.ToTable("A_Languages");

                entity.Property(e => e.LanguageId).ValueGeneratedNever();

                entity.Property(e => e.LanguageDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ALevelofEducation>(entity =>
            {
                entity.HasKey(e => e.LevelofEducationId);

                entity.ToTable("A_LevelofEducation");

                entity.Property(e => e.LevelofEducationId).ValueGeneratedNever();

                entity.Property(e => e.LevelofEducationDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<AMaritalStatus>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusId);

                entity.ToTable("A_MaritalStatus");

                entity.Property(e => e.MaritalStatusId).ValueGeneratedNever();

                entity.Property(e => e.MaritalStatusDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AMobilePhoneEntitlement>(entity =>
            {
                entity.HasKey(e => e.MobilePhoneEntitlementId);

                entity.ToTable("A_MobilePhoneEntitlement");

                entity.Property(e => e.MobilePhoneEntitlementId).ValueGeneratedNever();

                entity.HasOne(d => d.SalaryScale)
                    .WithMany(p => p.AMobilePhoneEntitlement)
                    .HasForeignKey(d => d.SalaryScaleId)
                    .HasConstraintName("FK_A_MobilePhoneEntitlement_A_SalaryScale");
            });

            modelBuilder.Entity<AParish>(entity =>
            {
                entity.HasKey(e => e.ParishId);

                entity.ToTable("A_Parish");

                entity.Property(e => e.ParishId).ValueGeneratedNever();

                entity.Property(e => e.ParishDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<APerformanceDescriptor>(entity =>
            {
                entity.HasKey(e => e.PerformanceDescriptorId);

                entity.ToTable("A_PerformanceDescriptor");

                entity.Property(e => e.PerformanceDescriptorId).ValueGeneratedNever();

                entity.Property(e => e.PerformanceDescriptor).HasMaxLength(3000);
            });

            modelBuilder.Entity<APublicHolidayAllowance>(entity =>
            {
                entity.HasKey(e => e.PublicHolidayAllowanceId);

                entity.ToTable("A_PublicHolidayAllowance");

                entity.Property(e => e.PublicHolidayAllowanceId).ValueGeneratedNever();

                entity.HasOne(d => d.SalaryScale)
                    .WithMany(p => p.APublicHolidayAllowance)
                    .HasForeignKey(d => d.SalaryScaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_A_PublicHolidayAllowance_A_SalaryScale");
            });

            modelBuilder.Entity<ARelationship>(entity =>
            {
                entity.HasKey(e => e.RelationshipId);

                entity.ToTable("A_Relationship");

                entity.Property(e => e.RelationshipId).ValueGeneratedNever();

                entity.Property(e => e.RelationshipName).HasMaxLength(3000);
            });

            modelBuilder.Entity<ASafariAllowance>(entity =>
            {
                entity.HasKey(e => e.SafariAllowanceId);

                entity.ToTable("A_Safari_Allowance");

                entity.Property(e => e.SafariAllowanceId).ValueGeneratedNever();

                entity.HasOne(d => d.SalaryScale)
                    .WithMany(p => p.ASafariAllowance)
                    .HasForeignKey(d => d.SalaryScaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_A_Safari_Allowance_A_SalaryScale");
            });

            modelBuilder.Entity<ASalaryScale>(entity =>
            {
                entity.HasKey(e => e.SalaryScaleId);

                entity.ToTable("A_SalaryScale");

                entity.Property(e => e.SalaryScaleId).ValueGeneratedNever();

                entity.Property(e => e.SalaryScaleDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ASkillLevel>(entity =>
            {
                entity.HasKey(e => e.SkillLevelId);

                entity.ToTable("A_SkillLevel");

                entity.Property(e => e.SkillLevelId).ValueGeneratedNever();

                entity.Property(e => e.SkillLevelDesc).HasMaxLength(3000);
            });

            modelBuilder.Entity<ASubCounty>(entity =>
            {
                entity.HasKey(e => e.SubCountyId);

                entity.ToTable("A_SubCounty");

                entity.Property(e => e.SubCountyId).ValueGeneratedNever();

                entity.Property(e => e.SubCountyDescription).HasMaxLength(500);

                entity.HasOne(d => d.District)
                    .WithMany(p => p.ASubCounty)
                    .HasForeignKey(d => d.DistrictId)
                    .HasConstraintName("FK_A_SubCounty_A_District");
            });

            modelBuilder.Entity<ATravelAbroadAllowance>(entity =>
            {
                entity.HasKey(e => e.TravelAbroadAllowanceId);

                entity.ToTable("A_TravelAbroadAllowance");

                entity.Property(e => e.TravelAbroadAllowanceId).ValueGeneratedNever();

                entity.HasOne(d => d.SalaryScale)
                    .WithMany(p => p.ATravelAbroadAllowance)
                    .HasForeignKey(d => d.SalaryScaleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_A_TravelAbroadAllowance_A_SalaryScale");

                entity.HasOne(d => d.TravelClass)
                    .WithMany(p => p.ATravelAbroadAllowance)
                    .HasForeignKey(d => d.TravelClassId)
                    .HasConstraintName("FK_A_TravelAbroadAllowance_A_TravelClass");
            });

            modelBuilder.Entity<ATravelClass>(entity =>
            {
                entity.HasKey(e => e.TravelClassId);

                entity.ToTable("A_TravelClass");

                entity.Property(e => e.TravelClassId).ValueGeneratedNever();

                entity.Property(e => e.TravelClassDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<AVillage>(entity =>
            {
                entity.HasKey(e => e.VillageId);

                entity.ToTable("A_Village");

                entity.Property(e => e.VillageId).ValueGeneratedNever();

                entity.Property(e => e.ViallgeDescription).HasMaxLength(500);

                entity.HasOne(d => d.Parish)
                    .WithMany(p => p.AVillage)
                    .HasForeignKey(d => d.ParishId)
                    .HasConstraintName("FK_A_Village_A_SubCounty");
            });

            modelBuilder.Entity<AspNetEmailConfirmationCode>(entity =>
            {
                entity.HasKey(e => e.ConfirmationId);

                entity.Property(e => e.ConfirmationCode)
                    .HasMaxLength(3000)
                    .IsUnicode(false);

                entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .HasMaxLength(3000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AspNetRoleClaims>(entity =>
            {
                entity.HasIndex(e => e.RoleId, "IX_AspNetRoleClaims_RoleId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.AspNetRoleClaims)
                    .HasForeignKey(d => d.RoleId);
            });

            modelBuilder.Entity<AspNetRoles>(entity =>
            {
                entity.HasIndex(e => e.NormalizedName, "RoleNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedName] IS NOT NULL)");

                entity.Property(e => e.Name).HasMaxLength(256);

                entity.Property(e => e.NormalizedName).HasMaxLength(256);
            });

            modelBuilder.Entity<AspNetUserClaims>(entity =>
            {
                entity.HasIndex(e => e.UserId, "IX_AspNetUserClaims_UserId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserClaims)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserLogins>(entity =>
            {
                entity.HasKey(e => new { e.LoginProvider, e.ProviderKey });

                entity.HasIndex(e => e.UserId, "IX_AspNetUserLogins_UserId");

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.ProviderKey).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserLogins)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUserTokens>(entity =>
            {
                entity.HasKey(e => new { e.UserId, e.LoginProvider, e.Name });

                entity.Property(e => e.LoginProvider).HasMaxLength(128);

                entity.Property(e => e.Name).HasMaxLength(128);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AspNetUserTokens)
                    .HasForeignKey(d => d.UserId);
            });

            modelBuilder.Entity<AspNetUsers>(entity =>
            {
                entity.HasIndex(e => e.NormalizedEmail, "EmailIndex");

                entity.HasIndex(e => e.NormalizedUserName, "UserNameIndex")
                    .IsUnique()
                    .HasFilter("([NormalizedUserName] IS NOT NULL)");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.Employeeid)
                    .HasConstraintName("FK_AspNetUsers_Employee");

                entity.HasOne(d => d.NonStaff)
                    .WithMany(p => p.AspNetUsers)
                    .HasForeignKey(d => d.NonStaffid)
                    .HasConstraintName("FK_AspNetUsers_NonStaff");

                entity.HasMany(d => d.Role)
                    .WithMany(p => p.User)
                    .UsingEntity<Dictionary<string, object>>(
                        "AspNetUserRoles",
                        l => l.HasOne<AspNetRoles>().WithMany().HasForeignKey("RoleId"),
                        r => r.HasOne<AspNetUsers>().WithMany().HasForeignKey("UserId"),
                        j =>
                        {
                            j.HasKey("UserId", "RoleId");

                            j.ToTable("AspNetUserRoles");

                            j.HasIndex(new[] { "RoleId" }, "IX_AspNetUserRoles_RoleId");
                        });
            });

            modelBuilder.Entity<BalanceScoreCard>(entity =>
            {
                entity.Property(e => e.DateofReview).HasColumnType("date");

                entity.HasOne(d => d.AppraisalReason)
                    .WithMany(p => p.BalanceScoreCard)
                    .HasForeignKey(d => d.AppraisalReasonId)
                    .HasConstraintName("FK_BalanceScoreCard_A_AppraisalReason");

                entity.HasOne(d => d.JobTitle)
                    .WithMany(p => p.BalanceScoreCard)
                    .HasForeignKey(d => d.JobTitleId)
                    .HasConstraintName("FK_BalanceScoreCard_A_JobTitle");
            });

            modelBuilder.Entity<BalanceScoreCardBehavioral>(entity =>
            {
                entity.HasKey(e => e.BehavioralId);

                entity.HasOne(d => d.BalanceScoreCard)
                    .WithMany(p => p.BalanceScoreCardBehavioral)
                    .HasForeignKey(d => d.BalanceScoreCardId)
                    .HasConstraintName("FK_BalanceScoreCardBehavioral_BalanceScoreCard");

                entity.HasOne(d => d.Competence)
                    .WithMany(p => p.BalanceScoreCardBehavioral)
                    .HasForeignKey(d => d.CompetenceId)
                    .HasConstraintName("FK_BalanceScoreCardBehavioral_A_BehavioralCompetencies");

                entity.HasOne(d => d.PerformanceDescriptor)
                    .WithMany(p => p.BalanceScoreCardBehavioral)
                    .HasForeignKey(d => d.PerformanceDescriptorId)
                    .HasConstraintName("FK_BalanceScoreCardBehavioral_A_PerformanceDescriptor");
            });

            modelBuilder.Entity<BalanceScoreCardTargetSetting>(entity =>
            {
                entity.HasKey(e => e.TargetSettingId);

                entity.Property(e => e.Bsckpiid).HasColumnName("BSCKPIId");

                entity.HasOne(d => d.BalanceScoreCard)
                    .WithMany(p => p.BalanceScoreCardTargetSetting)
                    .HasForeignKey(d => d.BalanceScoreCardId)
                    .HasConstraintName("FK_BalanceScoreCardTargetSetting_BalanceScoreCard");

                entity.HasOne(d => d.BscPerspective)
                    .WithMany(p => p.BalanceScoreCardTargetSetting)
                    .HasForeignKey(d => d.BscPerspectiveId)
                    .HasConstraintName("FK_BalanceScoreCardTargetSetting_A_BscPerspectives");

                entity.HasOne(d => d.Bsckpi)
                    .WithMany(p => p.BalanceScoreCardTargetSetting)
                    .HasForeignKey(d => d.Bsckpiid)
                    .HasConstraintName("FK_BalanceScoreCardTargetSetting_A_BscKPI");

                entity.HasOne(d => d.Evidence)
                    .WithMany(p => p.BalanceScoreCardTargetSetting)
                    .HasForeignKey(d => d.EvidenceId)
                    .HasConstraintName("FK_BalanceScoreCardTargetSetting_A_EmployeeEvidence");

                entity.HasOne(d => d.MeasurementMetric)
                    .WithMany(p => p.BalanceScoreCardTargetSetting)
                    .HasForeignKey(d => d.MeasurementMetricId)
                    .HasConstraintName("FK_BalanceScoreCardTargetSetting_A_BscPerformanceMeasurement");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.Property(e => e.Employeeid).ValueGeneratedNever();

                entity.Property(e => e.BankAccountNumber).HasMaxLength(3000);

                entity.Property(e => e.BankBranch).HasMaxLength(3000);

                entity.Property(e => e.CvdocumentExt)
                    .HasMaxLength(10)
                    .HasColumnName("CVDocumentExt")
                    .IsFixedLength();

                entity.Property(e => e.CvdocumentName)
                    .HasMaxLength(3000)
                    .HasColumnName("CVDocumentName");

                entity.Property(e => e.DateJoined).HasColumnType("date");

                entity.Property(e => e.DepartureDate).HasColumnType("date");

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.EmailAddress).HasMaxLength(3000);

                entity.Property(e => e.EmployeeNumber).HasMaxLength(3000);

                entity.Property(e => e.FirstName).HasMaxLength(3000);

                entity.Property(e => e.Github).HasMaxLength(3000);

                entity.Property(e => e.IdentificationNumber).HasMaxLength(3000);

                entity.Property(e => e.LastName).HasMaxLength(3000);

                entity.Property(e => e.LinkedIn).HasMaxLength(3000);

                entity.Property(e => e.MiddleName).HasMaxLength(3000);

                entity.Property(e => e.Nssfno)
                    .HasMaxLength(3000)
                    .HasColumnName("NSSFNo");

                entity.Property(e => e.Photograph).HasMaxLength(3000);

                entity.Property(e => e.PhotographExt)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Twitter).HasMaxLength(3000);

                entity.Property(e => e.UraTinNo)
                    .HasMaxLength(3000)
                    .HasColumnName("URA_TinNo");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_Employee_A_Bank");

                entity.HasOne(d => d.Coutry)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.CoutryId)
                    .HasConstraintName("FK_EmployeeId_A_Country");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Employee_A_Department");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_EmployeeId_A_Gender");

                entity.HasOne(d => d.IdentificationType)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.IdentificationTypeId)
                    .HasConstraintName("FK_EmployeeId_A_IdentificationType");

                entity.HasOne(d => d.JobDescription)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.JobDescriptionId)
                    .HasConstraintName("FK_Employee_JobDescription");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_Employee_A_MaritalStatus");

                entity.HasOne(d => d.PlaceofOriginDistrict)
                    .WithMany(p => p.EmployeePlaceofOriginDistrict)
                    .HasForeignKey(d => d.PlaceofOriginDistrictId)
                    .HasConstraintName("FK_Employee_A_District");

                entity.HasOne(d => d.PlaceofOriginParish)
                    .WithMany(p => p.EmployeePlaceofOriginParish)
                    .HasForeignKey(d => d.PlaceofOriginParishId)
                    .HasConstraintName("FK_Employee_A_Parish");

                entity.HasOne(d => d.PlaceofOriginSubCounty)
                    .WithMany(p => p.EmployeePlaceofOriginSubCounty)
                    .HasForeignKey(d => d.PlaceofOriginSubCountyId)
                    .HasConstraintName("FK_Employee_A_SubCounty");

                entity.HasOne(d => d.PlaceofOriginVillage)
                    .WithMany(p => p.EmployeePlaceofOriginVillage)
                    .HasForeignKey(d => d.PlaceofOriginVillageId)
                    .HasConstraintName("FK_Employee_A_Village");

                entity.HasOne(d => d.PlaceofResidenceDistrict)
                    .WithMany(p => p.EmployeePlaceofResidenceDistrict)
                    .HasForeignKey(d => d.PlaceofResidenceDistrictId)
                    .HasConstraintName("FK_Employee_A_District1");

                entity.HasOne(d => d.PlaceofResidenceParish)
                    .WithMany(p => p.EmployeePlaceofResidenceParish)
                    .HasForeignKey(d => d.PlaceofResidenceParishId)
                    .HasConstraintName("FK_Employee_A_Parish1");

                entity.HasOne(d => d.PlaceofResidenceSubCounty)
                    .WithMany(p => p.EmployeePlaceofResidenceSubCounty)
                    .HasForeignKey(d => d.PlaceofResidenceSubCountyId)
                    .HasConstraintName("FK_Employee_A_SubCounty1");

                entity.HasOne(d => d.PlaceofResidenceVillage)
                    .WithMany(p => p.EmployeePlaceofResidenceVillage)
                    .HasForeignKey(d => d.PlaceofResidenceVillageId)
                    .HasConstraintName("FK_Employee_A_Village1");
            });

            modelBuilder.Entity<EmployeeLanguagesKnown>(entity =>
            {
                entity.HasKey(e => e.LanguagesKnownId)
                    .HasName("PK_Employee_Languages");

                entity.ToTable("Employee_LanguagesKnown");

                entity.Property(e => e.LanguagesKnownId).ValueGeneratedNever();

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeLanguagesKnown)
                    .HasForeignKey(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_Languages_Employee");

                entity.HasOne(d => d.LanguageProlific)
                    .WithMany(p => p.EmployeeLanguagesKnown)
                    .HasForeignKey(d => d.LanguageProlificId)
                    .HasConstraintName("FK_Employee_Languages_A_Languages");

                entity.HasOne(d => d.LanguageProlificNavigation)
                    .WithMany(p => p.EmployeeLanguagesKnown)
                    .HasForeignKey(d => d.LanguageProlificId)
                    .HasConstraintName("FK_Employee_Languages_A_LanguageProlific");
            });

            modelBuilder.Entity<EmployeeNextOfKin>(entity =>
            {
                entity.ToTable("Employee_NextOfKin");

                entity.Property(e => e.EmployeeNextOfKinId).ValueGeneratedNever();

                entity.Property(e => e.EmailAddress).HasMaxLength(3000);

                entity.Property(e => e.FirstName).HasMaxLength(3000);

                entity.Property(e => e.LastName).HasMaxLength(3000);

                entity.Property(e => e.MiddleName).HasMaxLength(3000);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeNextOfKin)
                    .HasForeignKey(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Employee_NextOfKin_EmployeeId");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.EmployeeNextOfKin)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_Employee_NextOfKin_A_Gender");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.EmployeeNextOfKin)
                    .HasForeignKey(d => d.RelationshipId)
                    .HasConstraintName("FK_Employee_NextOfKin_A_Relationship");
            });

            modelBuilder.Entity<EmployeeQualification>(entity =>
            {
                entity.HasKey(e => e.QualificationId)
                    .HasName("PK_EmployeeQualification");

                entity.ToTable("Employee_Qualification");

                entity.Property(e => e.QualificationId).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.InstitutionName).HasMaxLength(3000);

                entity.Property(e => e.OtherFieldOfStudy).HasMaxLength(3000);

                entity.Property(e => e.QualificationDocumentExt)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.QualificationDocumentName).HasMaxLength(3000);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeQualification)
                    .HasForeignKey(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeQualification_EmployeeId");

                entity.HasOne(d => d.FieldOfStudy)
                    .WithMany(p => p.EmployeeQualification)
                    .HasForeignKey(d => d.FieldOfStudyId)
                    .HasConstraintName("FK_EmployeeQualification_A_FieldOfStudy");

                entity.HasOne(d => d.LevelofEducation)
                    .WithMany(p => p.EmployeeQualification)
                    .HasForeignKey(d => d.LevelofEducationId)
                    .HasConstraintName("FK_EmployeeQualification_A_LevelofEducation");
            });

            modelBuilder.Entity<EmployeeSkills>(entity =>
            {
                entity.HasKey(e => e.ExtraSkillsId);

                entity.Property(e => e.ExtraSkillsId).ValueGeneratedNever();

                entity.Property(e => e.SkillDescription).HasMaxLength(3000);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSkills)
                    .HasForeignKey(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeSkills_Employee");

                entity.HasOne(d => d.SkillLevel)
                    .WithMany(p => p.EmployeeSkills)
                    .HasForeignKey(d => d.SkillLevelId)
                    .HasConstraintName("FK_EmployeeSkills_A_SkillLevel");
            });

            modelBuilder.Entity<EmployeeWorkExperience>(entity =>
            {
                entity.HasKey(e => e.WorkExperienceId)
                    .HasName("PK_EmployeeWorkExperience");

                entity.ToTable("Employee_WorkExperience");

                entity.Property(e => e.WorkExperienceId).ValueGeneratedNever();

                entity.Property(e => e.AppointmentLetterExt)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AppointmentLetterUrl).HasMaxLength(3000);

                entity.Property(e => e.EmployerName).HasMaxLength(3000);

                entity.Property(e => e.EmployerOfficialEmail).HasMaxLength(3000);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.JobTitle).HasMaxLength(3000);

                entity.Property(e => e.Organisation).HasMaxLength(3000);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeWorkExperience)
                    .HasForeignKey(d => d.Employeeid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_EmployeeWorkExperience_EmployeeId");
            });

            modelBuilder.Entity<Exit>(entity =>
            {
                entity.Property(e => e.ExitId).ValueGeneratedNever();

                entity.Property(e => e.DateJoined).HasColumnType("date");

                entity.Property(e => e.Experience)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Feedback)
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Logoff).HasColumnType("datetime");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Exit)
                    .HasForeignKey(d => d.Employeeid)
                    .HasConstraintName("FK_Exit_Employee");
            });

            modelBuilder.Entity<JobDescription>(entity =>
            {
                entity.Property(e => e.JobDescriptionId).ValueGeneratedNever();

                entity.Property(e => e.ContractEnddate).HasColumnType("date");

                entity.Property(e => e.ContractStartDate).HasColumnType("date");

                entity.Property(e => e.CreatedBy).HasMaxLength(3000);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.JobDescription1)
                    .HasColumnName("JobDescription")
                    .HasComment("This column will contain extra description of the given job description");

                entity.Property(e => e.JobStatusId).HasComment("This column will store the Jobstatusid of the Jobstatus that will be mapped to this job description and it will reference the A_JobStatus Table");

                entity.Property(e => e.JobTypeId).HasComment("This Column is the primary key for the job types and it will be auto incremented whenever a new job type is added");

                entity.Property(e => e.MinimumYearsofExperience).HasComment("This column will store the minimum Years of experience Required for the specific job description");

                entity.Property(e => e.Vacancies).HasColumnName("vacancies");

                entity.HasOne(d => d.ContractLengthType)
                    .WithMany(p => p.JobDescription)
                    .HasForeignKey(d => d.ContractLengthTypeId)
                    .HasConstraintName("FK_JobDescription_A_ContractLengthType");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.JobDescription)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_JobDescription_A_Department");

                entity.HasOne(d => d.JibTitle)
                    .WithMany(p => p.JobDescription)
                    .HasForeignKey(d => d.JibTitleId)
                    .HasConstraintName("FK_JobDescription_A_JobTitle");

                entity.HasOne(d => d.JobStatus)
                    .WithMany(p => p.JobDescription)
                    .HasForeignKey(d => d.JobStatusId)
                    .HasConstraintName("FK_JobDescription_A_JobStatus");

                entity.HasOne(d => d.JobType)
                    .WithMany(p => p.JobDescription)
                    .HasForeignKey(d => d.JobTypeId)
                    .HasConstraintName("FK_JobDescription_A_JobType");

                entity.HasOne(d => d.MinimumLevelOfEducation)
                    .WithMany(p => p.JobDescription)
                    .HasForeignKey(d => d.MinimumLevelOfEducationId)
                    .HasConstraintName("FK_JobDescription_A_LevelofEducation");

                entity.HasOne(d => d.SalaryScale)
                    .WithMany(p => p.JobDescription)
                    .HasForeignKey(d => d.SalaryScaleId)
                    .HasConstraintName("FK_JobDescription_A_SalaryScale");
            });

            modelBuilder.Entity<JobDescriptionBenefit>(entity =>
            {
                entity.HasKey(e => e.BenefitId);

                entity.Property(e => e.BenefitId).HasComment("This will be the unique identifier for each job Benefit");

                entity.Property(e => e.BenefitDescription)
                    .HasMaxLength(3000)
                    .HasComment("This will Store the description of each benefit");

                entity.Property(e => e.CreatedBy).HasMaxLength(3000);

                entity.Property(e => e.CreationDate).HasColumnType("datetime");

                entity.Property(e => e.JobDescriptionId).HasComment("This column will store the JobDescriptionId from the JobDescription that will be mapped to this specific benefit");

                entity.HasOne(d => d.JobDescription)
                    .WithMany(p => p.JobDescriptionBenefit)
                    .HasForeignKey(d => d.JobDescriptionId)
                    .HasConstraintName("FK_JobDescriptionBenefit_JobDescription");
            });

            modelBuilder.Entity<JobDescriptionKnowledge>(entity =>
            {
                entity.HasKey(e => e.KnowledgeId);

                entity.Property(e => e.AddedBy).HasMaxLength(3000);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.JobDescriptionId).HasComment("This column will store the JobDescriptionId from the JobDescription that will be mapped to this specific work experience");

                entity.Property(e => e.Notes).HasComment("This will Store the description of each Skill or Knowledge");

                entity.HasOne(d => d.FieldofStudy)
                    .WithMany(p => p.JobDescriptionKnowledge)
                    .HasForeignKey(d => d.FieldofStudyId)
                    .HasConstraintName("FK_JobDescriptionKnowledge_A_FieldofStudy");

                entity.HasOne(d => d.JobDescription)
                    .WithMany(p => p.JobDescriptionKnowledge)
                    .HasForeignKey(d => d.JobDescriptionId)
                    .HasConstraintName("FK_JobDescriptionKnowledge_JobDescription");

                entity.HasOne(d => d.LevelofEducation)
                    .WithMany(p => p.JobDescriptionKnowledge)
                    .HasForeignKey(d => d.LevelofEducationId)
                    .HasConstraintName("FK_JobDescriptionKnowledge_A_LevelofEducation");
            });

            modelBuilder.Entity<JobDescriptionResponsibility>(entity =>
            {
                entity.HasKey(e => e.ResponsibiltyId);

                entity.Property(e => e.ResponsibiltyId).HasComment("This will be the unique identifier for each job responsibility");

                entity.Property(e => e.AddedBy).HasMaxLength(3000);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.JobDescriptionId).HasComment("This column will store the JobDescriptionId from the JobDescription that will be mapped to this specific responsibility");

                entity.Property(e => e.ResponsibilityDesc)
                    .HasMaxLength(3000)
                    .HasComment("This will Store the description of each responsibility");

                entity.HasOne(d => d.JobDescription)
                    .WithMany(p => p.JobDescriptionResponsibility)
                    .HasForeignKey(d => d.JobDescriptionId)
                    .HasConstraintName("FK_JobDescriptionResponsibility_JobDescription");
            });

            modelBuilder.Entity<JobDescriptionWorkExperienceRequirement>(entity =>
            {
                entity.HasKey(e => e.ExperienceId);

                entity.Property(e => e.ExperienceId).HasComment("This will Store the description of each work experience");

                entity.Property(e => e.AddedBy).HasMaxLength(2000);

                entity.Property(e => e.AddedDate).HasColumnType("datetime");

                entity.Property(e => e.ExperienceDesc).HasComment("This will Store the description of each Experience");

                entity.Property(e => e.JobDescriptionId).HasComment("This column will store the JobDescriptionId from the JobDescription that will be mapped to this specific work experience");

                entity.HasOne(d => d.JobDescription)
                    .WithMany(p => p.JobDescriptionWorkExperienceRequirement)
                    .HasForeignKey(d => d.JobDescriptionId)
                    .HasConstraintName("FK_JobDescriptionWorkExperienceRequirement_JobDescription");
            });

            modelBuilder.Entity<NonStaff>(entity =>
            {
                entity.Property(e => e.NonStaffid).ValueGeneratedNever();

                entity.Property(e => e.BankAccountNumber).HasMaxLength(3000);

                entity.Property(e => e.BankBranch).HasMaxLength(3000);

                entity.Property(e => e.CvdocumentExt)
                    .HasMaxLength(10)
                    .HasColumnName("CVDocumentExt")
                    .IsFixedLength();

                entity.Property(e => e.CvdocumentName)
                    .HasMaxLength(3000)
                    .HasColumnName("CVDocumentName");

                entity.Property(e => e.DoB).HasColumnType("date");

                entity.Property(e => e.EmailAddress).HasMaxLength(3000);

                entity.Property(e => e.FirstName).HasMaxLength(3000);

                entity.Property(e => e.Github).HasMaxLength(3000);

                entity.Property(e => e.IdentificationNumber).HasMaxLength(3000);

                entity.Property(e => e.LastName).HasMaxLength(3000);

                entity.Property(e => e.LinkedIn).HasMaxLength(3000);

                entity.Property(e => e.MiddleName).HasMaxLength(3000);

                entity.Property(e => e.Nssfno)
                    .HasMaxLength(3000)
                    .HasColumnName("NSSFNo");

                entity.Property(e => e.Photograph).HasMaxLength(3000);

                entity.Property(e => e.PhotographExt)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Twitter).HasMaxLength(3000);

                entity.Property(e => e.UraTinNo)
                    .HasMaxLength(3000)
                    .HasColumnName("URA_TinNo");

                entity.HasOne(d => d.Bank)
                    .WithMany(p => p.NonStaff)
                    .HasForeignKey(d => d.BankId)
                    .HasConstraintName("FK_NonStaff_A_Bank");

                entity.HasOne(d => d.Coutry)
                    .WithMany(p => p.NonStaff)
                    .HasForeignKey(d => d.CoutryId)
                    .HasConstraintName("FK_NonStaffId_A_Country");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.NonStaff)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_NonStaffId_A_Gender");

                entity.HasOne(d => d.IdentificationType)
                    .WithMany(p => p.NonStaff)
                    .HasForeignKey(d => d.IdentificationTypeId)
                    .HasConstraintName("FK_NonStaffId_A_IdentificationType");

                entity.HasOne(d => d.MaritalStatus)
                    .WithMany(p => p.NonStaff)
                    .HasForeignKey(d => d.MaritalStatusId)
                    .HasConstraintName("FK_NonStaff_A_MaritalStatus");

                entity.HasOne(d => d.PlaceofOriginDistrict)
                    .WithMany(p => p.NonStaffPlaceofOriginDistrict)
                    .HasForeignKey(d => d.PlaceofOriginDistrictId)
                    .HasConstraintName("FK_NonStaff_A_District");

                entity.HasOne(d => d.PlaceofOriginParish)
                    .WithMany(p => p.NonStaffPlaceofOriginParish)
                    .HasForeignKey(d => d.PlaceofOriginParishId)
                    .HasConstraintName("FK_NonStaff_A_Parish");

                entity.HasOne(d => d.PlaceofOriginSubCounty)
                    .WithMany(p => p.NonStaffPlaceofOriginSubCounty)
                    .HasForeignKey(d => d.PlaceofOriginSubCountyId)
                    .HasConstraintName("FK_NonStaff_A_SubCounty");

                entity.HasOne(d => d.PlaceofOriginVillage)
                    .WithMany(p => p.NonStaffPlaceofOriginVillage)
                    .HasForeignKey(d => d.PlaceofOriginVillageId)
                    .HasConstraintName("FK_NonStaff_A_Village");

                entity.HasOne(d => d.PlaceofResidenceDistrict)
                    .WithMany(p => p.NonStaffPlaceofResidenceDistrict)
                    .HasForeignKey(d => d.PlaceofResidenceDistrictId)
                    .HasConstraintName("FK_NonStaff_A_District1");

                entity.HasOne(d => d.PlaceofResidenceParish)
                    .WithMany(p => p.NonStaffPlaceofResidenceParish)
                    .HasForeignKey(d => d.PlaceofResidenceParishId)
                    .HasConstraintName("FK_NonStaff_A_Parish1");

                entity.HasOne(d => d.PlaceofResidenceSubCounty)
                    .WithMany(p => p.NonStaffPlaceofResidenceSubCounty)
                    .HasForeignKey(d => d.PlaceofResidenceSubCountyId)
                    .HasConstraintName("FK_NonStaff_A_SubCounty1");

                entity.HasOne(d => d.PlaceofResidenceVillage)
                    .WithMany(p => p.NonStaffPlaceofResidenceVillage)
                    .HasForeignKey(d => d.PlaceofResidenceVillageId)
                    .HasConstraintName("FK_NonStaff_A_Village1");
            });

            modelBuilder.Entity<NonStaffLanguagesKnown>(entity =>
            {
                entity.HasKey(e => e.LanguagesKnownId)
                    .HasName("PK_NonStaff_Languages");

                entity.ToTable("NonStaff_LanguagesKnown");

                entity.Property(e => e.LanguagesKnownId).ValueGeneratedNever();

                entity.HasOne(d => d.LanguageProlific)
                    .WithMany(p => p.NonStaffLanguagesKnown)
                    .HasForeignKey(d => d.LanguageProlificId)
                    .HasConstraintName("FK_NonStaff_Languages_A_Languages");

                entity.HasOne(d => d.LanguageProlificNavigation)
                    .WithMany(p => p.NonStaffLanguagesKnown)
                    .HasForeignKey(d => d.LanguageProlificId)
                    .HasConstraintName("FK_NonStaff_Languages_A_LanguageProlific");

                entity.HasOne(d => d.NonStaff)
                    .WithMany(p => p.NonStaffLanguagesKnown)
                    .HasForeignKey(d => d.NonStaffid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NonStaff_Languages_NonStaff");
            });

            modelBuilder.Entity<NonStaffNextOfKin>(entity =>
            {
                entity.ToTable("NonStaff_NextOfKin");

                entity.Property(e => e.NonStaffNextOfKinId).ValueGeneratedNever();

                entity.Property(e => e.EmailAddress).HasMaxLength(3000);

                entity.Property(e => e.FirstName).HasMaxLength(3000);

                entity.Property(e => e.LastName).HasMaxLength(3000);

                entity.Property(e => e.MiddleName).HasMaxLength(3000);

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.NonStaffNextOfKin)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK_NonStaff_NextOfKin_A_Gender");

                entity.HasOne(d => d.NonStaff)
                    .WithMany(p => p.NonStaffNextOfKin)
                    .HasForeignKey(d => d.NonStaffid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NonStaff_NextOfKin_NonStaffId");

                entity.HasOne(d => d.Relationship)
                    .WithMany(p => p.NonStaffNextOfKin)
                    .HasForeignKey(d => d.RelationshipId)
                    .HasConstraintName("FK_NonStaff_NextOfKin_A_Relationship");
            });

            modelBuilder.Entity<NonStaffQualification>(entity =>
            {
                entity.HasKey(e => e.QualificationId)
                    .HasName("PK_NonStaffQualification");

                entity.ToTable("NonStaff_Qualification");

                entity.Property(e => e.QualificationId).ValueGeneratedNever();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.InstitutionName).HasMaxLength(3000);

                entity.Property(e => e.OtherFieldOfStudy).HasMaxLength(3000);

                entity.Property(e => e.QualificationDocumentExt)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.QualificationDocumentName).HasMaxLength(3000);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.FieldOfStudy)
                    .WithMany(p => p.NonStaffQualification)
                    .HasForeignKey(d => d.FieldOfStudyId)
                    .HasConstraintName("FK_NonStaffQualification_A_FieldOfStudy");

                entity.HasOne(d => d.LevelofEducation)
                    .WithMany(p => p.NonStaffQualification)
                    .HasForeignKey(d => d.LevelofEducationId)
                    .HasConstraintName("FK_NonStaffQualification_A_LevelofEducation");

                entity.HasOne(d => d.NonStaff)
                    .WithMany(p => p.NonStaffQualification)
                    .HasForeignKey(d => d.NonStaffid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NonStaffQualification_NonStaffId");
            });

            modelBuilder.Entity<NonStaffSkills>(entity =>
            {
                entity.HasKey(e => e.ExtraSkillsId);

                entity.Property(e => e.ExtraSkillsId).ValueGeneratedNever();

                entity.Property(e => e.SkillDescription).HasMaxLength(3000);

                entity.HasOne(d => d.NonStaff)
                    .WithMany(p => p.NonStaffSkills)
                    .HasForeignKey(d => d.NonStaffid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NonStaffSkills_NonStaff");

                entity.HasOne(d => d.SkillLevel)
                    .WithMany(p => p.NonStaffSkills)
                    .HasForeignKey(d => d.SkillLevelId)
                    .HasConstraintName("FK_NonStaffSkills_A_SkillLevel");
            });

            modelBuilder.Entity<NonStaffWorkExperience>(entity =>
            {
                entity.HasKey(e => e.WorkExperienceId)
                    .HasName("PK_NonStaffWorkExperience");

                entity.ToTable("NonStaff_WorkExperience");

                entity.Property(e => e.WorkExperienceId).ValueGeneratedNever();

                entity.Property(e => e.AppointmentLetterExt)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.AppointmentLetterUrl).HasMaxLength(3000);

                entity.Property(e => e.EmployerName).HasMaxLength(3000);

                entity.Property(e => e.EmployerOfficialEmail).HasMaxLength(3000);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.JobTitle).HasMaxLength(3000);

                entity.Property(e => e.Organisation).HasMaxLength(3000);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.NonStaff)
                    .WithMany(p => p.NonStaffWorkExperience)
                    .HasForeignKey(d => d.NonStaffid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_NonStaffWorkExperience_NonStaffId");
            });

            modelBuilder.Entity<TrainingAMethod>(entity =>
            {
                entity.ToTable("Training_A_Method");

                entity.Property(e => e.TrainingMethod).HasMaxLength(500);
            });

            modelBuilder.Entity<TrainingAProfessionalAssociation>(entity =>
            {
                entity.ToTable("Training_A_ProfessionalAssociation");

                entity.Property(e => e.ProfessionalAssociation).HasMaxLength(500);
            });

            modelBuilder.Entity<TrainingATargetTeam>(entity =>
            {
                entity.ToTable("Training_A_TargetTeam");

                entity.Property(e => e.TargetTeam).HasMaxLength(50);
            });

            modelBuilder.Entity<TrainingCpd>(entity =>
            {
                entity.ToTable("Training_CPD");

                entity.Property(e => e.Departments).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.Location).HasMaxLength(150);

                entity.Property(e => e.Module).HasMaxLength(500);

                entity.Property(e => e.Officers).HasMaxLength(200);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.Trainer).HasMaxLength(150);
            });

            modelBuilder.Entity<TrainingGeneralInternal>(entity =>
            {
                entity.ToTable("Training_GeneralInternal");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.ExpectedOutcomes).HasMaxLength(3000);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.Property(e => e.TargetTeam).HasMaxLength(50);

                entity.Property(e => e.TrainingDescription).HasMaxLength(500);

                entity.Property(e => e.TrainingMethod).HasMaxLength(50);
            });

            modelBuilder.Entity<TrainingGeneralInternalBudget>(entity =>
            {
                entity.ToTable("Training_GeneralInternalBudget");

                entity.Property(e => e.Comment).HasMaxLength(3000);

                entity.HasOne(d => d.FinancialYearNavigation)
                    .WithMany(p => p.TrainingGeneralInternalBudget)
                    .HasForeignKey(d => d.FinancialYear)
                    .HasConstraintName("FK_Training_GeneralInternalBudget_A_FinancialYear");

                entity.HasOne(d => d.GeneralInternal)
                    .WithMany(p => p.TrainingGeneralInternalBudget)
                    .HasForeignKey(d => d.GeneralInternalId)
                    .HasConstraintName("FK_Training_GeneralInternal_Training_GeneralInternalBudget");
            });

            modelBuilder.Entity<TrainingSubscription>(entity =>
            {
                entity.ToTable("Training_Subscription");

                entity.Property(e => e.CourseDetails).HasMaxLength(3000);

                entity.Property(e => e.Currency)
                    .HasMaxLength(3)
                    .IsFixedLength();

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.CurrencyNavigation)
                    .WithMany(p => p.TrainingSubscription)
                    .HasForeignKey(d => d.Currency)
                    .HasConstraintName("FK_Training_Subscription_A_Currency");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TrainingSubscription)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_Training_Subscription_Employee");

                entity.HasOne(d => d.ProfessionalAssociationNavigation)
                    .WithMany(p => p.TrainingSubscription)
                    .HasForeignKey(d => d.ProfessionalAssociation)
                    .HasConstraintName("FK_Training_Subscription_Training_ProfessionalAssociation");
            });

            modelBuilder.Entity<ViewOrgStructureDepartment>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrgStructure_Department");

                entity.Property(e => e.DepartmentDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewOrgStructureJobTitle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_OrgStructure_JobTitle");

                entity.Property(e => e.DepartmentDescription).HasMaxLength(3000);

                entity.Property(e => e.JobTitleDescription).HasMaxLength(3000);
            });

            modelBuilder.Entity<ViewUserManagement>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("View_UserManagement");

                entity.Property(e => e.Email).HasMaxLength(256);

                entity.Property(e => e.EmailAddress).HasMaxLength(3000);

                entity.Property(e => e.FullName).HasMaxLength(4000);

                entity.Property(e => e.Id).HasMaxLength(450);

                entity.Property(e => e.NormalizedEmail).HasMaxLength(256);

                entity.Property(e => e.NormalizedRoleName).HasMaxLength(256);

                entity.Property(e => e.NormalizedUserName).HasMaxLength(256);

                entity.Property(e => e.RoleId).HasMaxLength(450);

                entity.Property(e => e.RoleName).HasMaxLength(256);

                entity.Property(e => e.UserName).HasMaxLength(256);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
