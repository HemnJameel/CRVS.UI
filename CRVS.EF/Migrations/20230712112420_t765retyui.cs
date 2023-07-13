using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class t765retyui : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ChildName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Alive",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "AllPDFs",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<bool>(
                name: "Approval",
                table: "BrithCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<TimeSpan>(
                name: "BHour",
                table: "BrithCertificates",
                type: "time",
                nullable: false,
                defaultValue: new TimeSpan(0, 0, 0, 0, 0));

            migrationBuilder.AddColumn<DateTime>(
                name: "BOD",
                table: "BrithCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<string>(
                name: "BODtext",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<decimal>(
                name: "BabyWeight",
                table: "BrithCertificates",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<int>(
                name: "BirthOccurredBy",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BirthPerformerName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "BirthPerformerWorkingAddress",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "BornAliveThenDied",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BornDisable",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BrithType",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CivilStatusDirectorate",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "CreationData",
                table: "BrithCertificates",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<bool>(
                name: "Creator",
                table: "BrithCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "DOH",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "DisabledType",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "District",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "DocumentType",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "DurationOfPregnancy",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FamilyDOH",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyDistrict",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyGovernorate",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyHomeNo",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyMahala",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyNahiah",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyPHC",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilySector",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FamilyZigag",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FatherAge",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "FatherBOD",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FatherFName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FatherFullName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "FatherJob",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FatherLName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FatherMName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "FatherMobile",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "FatherNationality",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FatherReligion",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "FirstStage",
                table: "BrithCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "Gender",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Governorate",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "GovernorateCivilStatusDirectorate",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HospitalManagerName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "HospitalManagerSig",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgBirthCertificate",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgFatherUnifiedNationalIdBack",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgFatherUnifiedNationalIdFront",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgMarriageCertificate",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgMotherUnifiedNationalIdBack",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgMotherUnifiedNationalIdFront",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgResidencyCardBack",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "ImgResidencyCardFront",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InformerJobTitle",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "InformerName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "IsActive",
                table: "BrithCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDeleted",
                table: "BrithCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "IsDisabled",
                table: "BrithCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<string>(
                name: "IsDisabledType",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "KinshipOfTheNewborn",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "LicenseNo",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "LicenseYear",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MotherAge",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "MotherBOD",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MotherFName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MotherFullName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "MotherJob",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MotherLName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MotherMName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "MotherMobile",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "MotherNationality",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "MotherReligion",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Nahia",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "NationalID",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NationalIdFor",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "NoAbortion",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<decimal>(
                name: "NumberOfBirth",
                table: "BrithCertificates",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "PageNumbertor",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "PassportNo",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "PlaceOfBirth",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "QrCode",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "RationCard",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "RecordNumber",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<bool>(
                name: "Relative",
                table: "BrithCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<bool>(
                name: "SecondStage",
                table: "BrithCertificates",
                type: "bit",
                nullable: false,
                defaultValue: false);

            migrationBuilder.AddColumn<int>(
                name: "StillBirth",
                table: "BrithCertificates",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Village",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Alive",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "AllPDFs",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "Approval",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "BHour",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "BOD",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "BODtext",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "BabyWeight",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "BirthOccurredBy",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "BirthPerformerName",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "BirthPerformerWorkingAddress",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "BornAliveThenDied",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "BornDisable",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "BrithType",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "CivilStatusDirectorate",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "CreationData",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "Creator",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "DOH",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "DisabledType",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "District",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "DocumentType",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "DurationOfPregnancy",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyDOH",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyDistrict",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyGovernorate",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyHomeNo",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyMahala",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyNahiah",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyPHC",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FamilySector",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FamilyZigag",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FatherAge",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FatherBOD",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FatherFName",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FatherFullName",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FatherJob",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FatherLName",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FatherMName",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FatherMobile",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FatherNationality",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FatherReligion",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "FirstStage",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "Gender",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "Governorate",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "GovernorateCivilStatusDirectorate",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "HospitalManagerName",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "HospitalManagerSig",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "ImgBirthCertificate",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "ImgFatherUnifiedNationalIdBack",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "ImgFatherUnifiedNationalIdFront",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "ImgMarriageCertificate",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "ImgMotherUnifiedNationalIdBack",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "ImgMotherUnifiedNationalIdFront",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "ImgResidencyCardBack",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "ImgResidencyCardFront",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "InformerJobTitle",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "InformerName",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "IsActive",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "IsDisabled",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "IsDisabledType",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "KinshipOfTheNewborn",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "LicenseNo",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "LicenseYear",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "MotherAge",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "MotherBOD",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "MotherFName",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "MotherFullName",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "MotherJob",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "MotherLName",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "MotherMName",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "MotherMobile",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "MotherNationality",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "MotherReligion",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "Nahia",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "NationalID",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "NationalIdFor",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "NoAbortion",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "NumberOfBirth",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "PageNumbertor",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "PassportNo",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "PlaceOfBirth",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "QrCode",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "RationCard",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "RecordNumber",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "Relative",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "SecondStage",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "StillBirth",
                table: "BrithCertificates");

            migrationBuilder.DropColumn(
                name: "Village",
                table: "BrithCertificates");

            migrationBuilder.AlterColumn<string>(
                name: "ChildName",
                table: "BrithCertificates",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");
        }
    }
}
