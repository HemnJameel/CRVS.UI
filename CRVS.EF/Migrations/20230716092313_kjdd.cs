using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace CRVS.EF.Migrations
{
    /// <inheritdoc />
    public partial class kjdd : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BrithCertificates",
                columns: table => new
                {
                    BrithCertificateId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertificateNo = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HealthID = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ChildName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    Governorate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DOH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Nahia = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Village = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BrithType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NumberOfBirth = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BHour = table.Column<TimeSpan>(type: "time", nullable: false),
                    BOD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BODtext = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherMName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FatherBOD = table.Column<int>(type: "int", nullable: false),
                    FatherAge = table.Column<int>(type: "int", nullable: false),
                    FatherJob = table.Column<int>(type: "int", nullable: false),
                    FatherNationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherReligion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FatherMobile = table.Column<int>(type: "int", nullable: false),
                    MotherFName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherMName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherLName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherFullName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MotherBOD = table.Column<int>(type: "int", nullable: false),
                    MotherAge = table.Column<int>(type: "int", nullable: false),
                    MotherJob = table.Column<int>(type: "int", nullable: false),
                    MotherNationality = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherReligion = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MotherMobile = table.Column<int>(type: "int", nullable: false),
                    Relative = table.Column<bool>(type: "bit", nullable: false),
                    Alive = table.Column<int>(type: "int", nullable: false),
                    BornAliveThenDied = table.Column<int>(type: "int", nullable: false),
                    StillBirth = table.Column<int>(type: "int", nullable: false),
                    BornDisable = table.Column<int>(type: "int", nullable: false),
                    NoAbortion = table.Column<int>(type: "int", nullable: false),
                    IsDisabled = table.Column<bool>(type: "bit", nullable: false),
                    IsDisabledType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DisabledType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DurationOfPregnancy = table.Column<int>(type: "int", nullable: false),
                    BabyWeight = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PlaceOfBirth = table.Column<int>(type: "int", nullable: false),
                    BirthOccurredBy = table.Column<int>(type: "int", nullable: false),
                    LicenseNo = table.Column<int>(type: "int", nullable: false),
                    LicenseYear = table.Column<int>(type: "int", nullable: false),
                    FamilyGovernorate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyDistrict = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyNahiah = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyMahala = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyDOH = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilySector = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyPHC = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyZigag = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FamilyHomeNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocumentType = table.Column<int>(type: "int", nullable: false),
                    RecordNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PageNumbertor = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CivilStatusDirectorate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    GovernorateCivilStatusDirectorate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalIdFor = table.Column<int>(type: "int", nullable: false),
                    NationalID = table.Column<int>(type: "int", nullable: false),
                    PassportNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    InformerJobTitle = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KinshipOfTheNewborn = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthPerformerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthPerformerWorkingAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalManagerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospitalManagerSig = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RationCard = table.Column<int>(type: "int", nullable: false),
                    ImgBirthCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgMarriageCertificate = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgFatherUnifiedNationalIdFront = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgFatherUnifiedNationalIdBack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgMotherUnifiedNationalIdFront = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgMotherUnifiedNationalIdBack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgResidencyCardFront = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ImgResidencyCardBack = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AllPDFs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    QrCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstStage = table.Column<bool>(type: "bit", nullable: false),
                    SecondStage = table.Column<bool>(type: "bit", nullable: false),
                    Approval = table.Column<bool>(type: "bit", nullable: false),
                    Creator = table.Column<bool>(type: "bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    IsActive = table.Column<bool>(type: "bit", nullable: false),
                    CreationData = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BrithCertificates", x => x.BrithCertificateId);
                });

            migrationBuilder.CreateTable(
                name: "Disables",
                columns: table => new
                {
                    DisableId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DisableName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Disables", x => x.DisableId);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistrictName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernoriteId = table.Column<int>(type: "int", nullable: false),
                    DohId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.DistrictId);
                });

            migrationBuilder.CreateTable(
                name: "facilityTypes",
                columns: table => new
                {
                    FacilityTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FacilityTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_facilityTypes", x => x.FacilityTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Governorites",
                columns: table => new
                {
                    GovernoriteId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GovernoriteName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Governorites", x => x.GovernoriteId);
                });

            migrationBuilder.CreateTable(
                name: "HealthInstitutions",
                columns: table => new
                {
                    HealthInstitutionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HealthInstitutionName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernoriteId = table.Column<int>(type: "int", nullable: false),
                    DohId = table.Column<int>(type: "int", nullable: false),
                    FacilityTypeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HealthInstitutions", x => x.HealthInstitutionId);
                });

            migrationBuilder.CreateTable(
                name: "jobs",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_jobs", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "Nahias",
                columns: table => new
                {
                    NahiaId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NahiaName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernoriteId = table.Column<int>(type: "int", nullable: false),
                    DohId = table.Column<int>(type: "int", nullable: false),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nahias", x => x.NahiaId);
                });

            migrationBuilder.CreateTable(
                name: "Nationalities",
                columns: table => new
                {
                    NationalityId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NationalityName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Nationalities", x => x.NationalityId);
                });

            migrationBuilder.CreateTable(
                name: "Religions",
                columns: table => new
                {
                    ReligionId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ReligionName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Religions", x => x.ReligionId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Dohs",
                columns: table => new
                {
                    DohId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DohName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GovernoriteId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Dohs", x => x.DohId);
                    table.ForeignKey(
                        name: "FK_Dohs_Governorites_GovernoriteId",
                        column: x => x.GovernoriteId,
                        principalTable: "Governorites",
                        principalColumn: "GovernoriteId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Dohs_GovernoriteId",
                table: "Dohs",
                column: "GovernoriteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "BrithCertificates");

            migrationBuilder.DropTable(
                name: "Disables");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Dohs");

            migrationBuilder.DropTable(
                name: "facilityTypes");

            migrationBuilder.DropTable(
                name: "HealthInstitutions");

            migrationBuilder.DropTable(
                name: "jobs");

            migrationBuilder.DropTable(
                name: "Nahias");

            migrationBuilder.DropTable(
                name: "Nationalities");

            migrationBuilder.DropTable(
                name: "Religions");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Governorites");
        }
    }
}
