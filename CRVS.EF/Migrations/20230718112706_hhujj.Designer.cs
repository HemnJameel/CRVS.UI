﻿// <auto-generated />
using System;
using CRVS.EF;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CRVS.EF.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20230718112706_hhujj")]
    partial class hhujj
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CRVS.Core.Models.BrithCertificate", b =>
                {
                    b.Property<Guid>("BrithCertificateId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Alive")
                        .HasColumnType("int");

                    b.Property<string>("AllPDFs")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Approval")
                        .HasColumnType("bit");

                    b.Property<TimeSpan>("BHour")
                        .HasColumnType("time");

                    b.Property<DateTime>("BOD")
                        .HasColumnType("datetime2");

                    b.Property<string>("BODtext")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("BabyWeight")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("BirthOccurredBy")
                        .HasColumnType("int");

                    b.Property<string>("BirthPerformerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("BirthPerformerWorkingAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("BornAliveThenDied")
                        .HasColumnType("int");

                    b.Property<int>("BornDisable")
                        .HasColumnType("int");

                    b.Property<string>("BrithType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CertificateNo")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ChildName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CivilStatusDirectorate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("CreationData")
                        .HasColumnType("datetime2");

                    b.Property<bool>("Creator")
                        .HasColumnType("bit");

                    b.Property<string>("DOH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DisabledType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DocumentType")
                        .HasColumnType("int");

                    b.Property<int>("DurationOfPregnancy")
                        .HasColumnType("int");

                    b.Property<string>("FamilyDOH")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyDistrict")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyGovernorate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyHomeNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyMahala")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyNahiah")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyPHC")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilySector")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FamilyZigag")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatherAge")
                        .HasColumnType("int");

                    b.Property<int>("FatherBOD")
                        .HasColumnType("int");

                    b.Property<string>("FatherFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatherJob")
                        .HasColumnType("int");

                    b.Property<string>("FatherLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherMName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FatherMobile")
                        .HasColumnType("int");

                    b.Property<string>("FatherNationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FatherReligion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FirstStage")
                        .HasColumnType("bit");

                    b.Property<int>("Gender")
                        .HasColumnType("int");

                    b.Property<string>("Governorate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GovernorateCivilStatusDirectorate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HealthID")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalManagerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HospitalManagerSig")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgBirthCertificate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgFatherUnifiedNationalIdBack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgFatherUnifiedNationalIdFront")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgMarriageCertificate")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgMotherUnifiedNationalIdBack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgMotherUnifiedNationalIdFront")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgResidencyCardBack")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ImgResidencyCardFront")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InformerJobTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("InformerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.Property<bool>("IsDisabled")
                        .HasColumnType("bit");

                    b.Property<string>("IsDisabledType")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("KinshipOfTheNewborn")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("LicenseNo")
                        .HasColumnType("int");

                    b.Property<int>("LicenseYear")
                        .HasColumnType("int");

                    b.Property<int>("MotherAge")
                        .HasColumnType("int");

                    b.Property<int>("MotherBOD")
                        .HasColumnType("int");

                    b.Property<string>("MotherFName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherFullName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotherJob")
                        .HasColumnType("int");

                    b.Property<string>("MotherLName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherMName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MotherMobile")
                        .HasColumnType("int");

                    b.Property<string>("MotherNationality")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MotherReligion")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nahia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("NationalID")
                        .HasColumnType("int");

                    b.Property<int>("NationalIdFor")
                        .HasColumnType("int");

                    b.Property<int>("NoAbortion")
                        .HasColumnType("int");

                    b.Property<decimal>("NumberOfBirth")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("PageNumbertor")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PassportNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlaceOfBirth")
                        .HasColumnType("int");

                    b.Property<string>("QrCode")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RationCard")
                        .HasColumnType("int");

                    b.Property<string>("RecordNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("Relative")
                        .HasColumnType("bit");

                    b.Property<bool>("SecondStage")
                        .HasColumnType("bit");

                    b.Property<int>("StillBirth")
                        .HasColumnType("int");

                    b.Property<string>("Village")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrithCertificateId");

                    b.ToTable("BrithCertificates");
                });

            modelBuilder.Entity("CRVS.Core.Models.Disable", b =>
                {
                    b.Property<int>("DisableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DisableId"));

                    b.Property<string>("DisableName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DisableId");

                    b.ToTable("Disables");
                });

            modelBuilder.Entity("CRVS.Core.Models.District", b =>
                {
                    b.Property<int>("DistrictId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictId"));

                    b.Property<string>("DistrictName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DohId")
                        .HasColumnType("int");

                    b.Property<int>("GovernoriteId")
                        .HasColumnType("int");

                    b.HasKey("DistrictId");

                    b.ToTable("Districts");
                });

            modelBuilder.Entity("CRVS.Core.Models.DistrictHistory", b =>
                {
                    b.Property<int>("DistrictHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DistrictHistoryId"));

                    b.Property<int>("DistrictCode")
                        .HasColumnType("int");

                    b.Property<string>("DistrictHistoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DistrictHistorydate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DistrictType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DistrictHistoryId");

                    b.ToTable("DistrictHistories");
                });

            modelBuilder.Entity("CRVS.Core.Models.Doh", b =>
                {
                    b.Property<int>("DohId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DohId"));

                    b.Property<DateTime>("CreationData")
                        .HasColumnType("datetime2");

                    b.Property<string>("DohName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("GovernoriteId")
                        .HasColumnType("int");

                    b.Property<bool>("IsActive")
                        .HasColumnType("bit");

                    b.HasKey("DohId");

                    b.HasIndex("GovernoriteId");

                    b.ToTable("Dohs");
                });

            modelBuilder.Entity("CRVS.Core.Models.DohHistory", b =>
                {
                    b.Property<int>("DohHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DohHistoryId"));

                    b.Property<int>("DohCode")
                        .HasColumnType("int");

                    b.Property<string>("DohHistoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DohHistorydate")
                        .HasColumnType("datetime2");

                    b.Property<string>("DohType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("DohHistoryId");

                    b.ToTable("DohHistories");
                });

            modelBuilder.Entity("CRVS.Core.Models.FacilityType", b =>
                {
                    b.Property<int>("FacilityTypeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("FacilityTypeId"));

                    b.Property<string>("FacilityTypeName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("FacilityTypeId");

                    b.ToTable("facilityTypes");
                });

            modelBuilder.Entity("CRVS.Core.Models.Governorite", b =>
                {
                    b.Property<int>("GovernoriteId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GovernoriteId"));

                    b.Property<string>("GovernoriteName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GovernoriteId");

                    b.ToTable("Governorites");
                });

            modelBuilder.Entity("CRVS.Core.Models.GovernoriteHistory", b =>
                {
                    b.Property<int>("GovernoriteHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("GovernoriteHistoryId"));

                    b.Property<int>("GovernoriteCode")
                        .HasColumnType("int");

                    b.Property<string>("GovernoriteHistoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("GovernoriteHistorydate")
                        .HasColumnType("datetime2");

                    b.Property<string>("GovernoriteType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("GovernoriteHistoryId");

                    b.ToTable("GovernoriteHistories");
                });

            modelBuilder.Entity("CRVS.Core.Models.HealthInstitution", b =>
                {
                    b.Property<int>("HealthInstitutionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("HealthInstitutionId"));

                    b.Property<int>("DohId")
                        .HasColumnType("int");

                    b.Property<int>("FacilityTypeId")
                        .HasColumnType("int");

                    b.Property<int>("GovernoriteId")
                        .HasColumnType("int");

                    b.Property<string>("HealthInstitutionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("HealthInstitutionId");

                    b.ToTable("HealthInstitutions");
                });

            modelBuilder.Entity("CRVS.Core.Models.Job", b =>
                {
                    b.Property<int>("JobId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("JobId"));

                    b.Property<string>("JobName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("JobId");

                    b.ToTable("jobs");
                });

            modelBuilder.Entity("CRVS.Core.Models.Nahia", b =>
                {
                    b.Property<int>("NahiaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NahiaId"));

                    b.Property<int>("DistrictId")
                        .HasColumnType("int");

                    b.Property<int>("DohId")
                        .HasColumnType("int");

                    b.Property<int>("GovernoriteId")
                        .HasColumnType("int");

                    b.Property<string>("NahiaName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NahiaId");

                    b.ToTable("Nahias");
                });

            modelBuilder.Entity("CRVS.Core.Models.NahiaHistory", b =>
                {
                    b.Property<int>("NahiaHistoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NahiaHistoryId"));

                    b.Property<int>("NahiaCode")
                        .HasColumnType("int");

                    b.Property<string>("NahiaHistoryName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NahiaHistorydate")
                        .HasColumnType("datetime2");

                    b.Property<string>("NahiaType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NahiaHistoryId");

                    b.ToTable("nahiaHistories");
                });

            modelBuilder.Entity("CRVS.Core.Models.Nationality", b =>
                {
                    b.Property<int>("NationalityId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("NationalityId"));

                    b.Property<string>("NationalityName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("NationalityId");

                    b.ToTable("Nationalities");
                });

            modelBuilder.Entity("CRVS.Core.Models.Religion", b =>
                {
                    b.Property<int>("ReligionId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReligionId"));

                    b.Property<string>("ReligionName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ReligionId");

                    b.ToTable("Religions");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("CRVS.Core.Models.Doh", b =>
                {
                    b.HasOne("CRVS.Core.Models.Governorite", "Governorite")
                        .WithMany()
                        .HasForeignKey("GovernoriteId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Governorite");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
