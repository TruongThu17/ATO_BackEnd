using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Migrations : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "About",
                columns: table => new
                {
                    AboutId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_About", x => x.AboutId);
                });

            migrationBuilder.CreateTable(
                name: "Account",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<bool>(type: "bit", nullable: true),
                    AvatarURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Dob = table.Column<DateTime>(type: "datetime2", nullable: true),
                    isAccountActive = table.Column<bool>(type: "bit", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    table.PrimaryKey("PK_Account", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "BankAccount",
                columns: table => new
                {
                    BankAccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OwnerType = table.Column<int>(type: "int", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    BranchName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IsPrimary = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BankAccount", x => x.BankAccountId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SystemConfigurations",
                columns: table => new
                {
                    ConfigId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ConfigType = table.Column<int>(type: "int", nullable: false),
                    ConfigKey = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ConfigValue = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SystemConfigurations", x => x.ConfigId);
                });

            migrationBuilder.CreateTable(
                name: "UserIssue",
                columns: table => new
                {
                    IssueId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueType = table.Column<int>(type: "int", nullable: false),
                    IssueDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SolutionContent = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserIssue", x => x.IssueId);
                });

            migrationBuilder.CreateTable(
                name: "Blog",
                columns: table => new
                {
                    BlogId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LinkImg = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateBy = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BlogType = table.Column<int>(type: "int", nullable: false),
                    BlogStatus = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Blog", x => x.BlogId);
                    table.ForeignKey(
                        name: "FK_Blog_Account_CreateBy",
                        column: x => x.CreateBy,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_RoleClaims_Account_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ShipAddress",
                columns: table => new
                {
                    ShipAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DefaultAddress = table.Column<bool>(type: "bit", nullable: false),
                    ToName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToPhone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToProvinceId = table.Column<int>(type: "int", nullable: false),
                    ToProvinceName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToWardCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToWardName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ToDistrictId = table.Column<int>(type: "int", nullable: false),
                    ToDistrictName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ShipAddress", x => x.ShipAddressId);
                    table.ForeignKey(
                        name: "FK_ShipAddress_Account_AccountId",
                        column: x => x.AccountId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourCompany",
                columns: table => new
                {
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CompanynName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailCompany = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourCompany", x => x.TourCompanyId);
                    table.ForeignKey(
                        name: "FK_TourCompany_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TouristFacility",
                columns: table => new
                {
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TouristFacilityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    phone = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ward_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    district_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    province_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ward_code = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    district_id = table.Column<int>(type: "int", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactInfor = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    EmailTouristFacility = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Website = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LogoURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TouristFacility", x => x.TouristFacilityId);
                    table.ForeignKey(
                        name: "FK_TouristFacility_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserClaims_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserLogins", x => new { x.UserId, x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_UserLogins_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "UserTokens",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_UserTokens_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "WithdrawalRequest",
                columns: table => new
                {
                    RequestId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccountName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ProcessedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    AdminResponse = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawalRequest", x => x.RequestId);
                    table.ForeignKey(
                        name: "FK_WithdrawalRequest_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_UserRoles_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Accommodation",
                columns: table => new
                {
                    AccommodationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AccommodationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    AccommodationDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Star = table.Column<int>(type: "int", nullable: true),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Accommodation", x => x.AccommodationId);
                    table.ForeignKey(
                        name: "FK_Accommodation_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AgriculturalTourPackage",
                columns: table => new
                {
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Slot = table.Column<int>(type: "int", nullable: false),
                    PriceOfAdults = table.Column<double>(type: "float", nullable: false),
                    PriceOfChildren = table.Column<double>(type: "float", nullable: false),
                    ChildTicketAge = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Durations = table.Column<double>(type: "float", nullable: false),
                    DurationsType = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    StatusActive = table.Column<int>(type: "int", nullable: false),
                    GatheringLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgriculturalTourPackage", x => x.TourId);
                    table.ForeignKey(
                        name: "FK_AgriculturalTourPackage_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Driver",
                columns: table => new
                {
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DriverName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VehicleType = table.Column<int>(type: "int", nullable: false),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Driver", x => x.DriverId);
                    table.ForeignKey(
                        name: "FK_Driver_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourGuide",
                columns: table => new
                {
                    GuideId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Bio = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Languages = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ExpertiseArea = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<double>(type: "float", nullable: false),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourGuide", x => x.GuideId);
                    table.ForeignKey(
                        name: "FK_TourGuide_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_TourGuide_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Contract",
                columns: table => new
                {
                    ContractId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ContractContent = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DiscountRate = table.Column<decimal>(type: "decimal(18,2)", nullable: true),
                    StartDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    EndDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    SignedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: true),
                    RequestReSignContract = table.Column<bool>(type: "bit", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    SigningStatus = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contract", x => x.ContractId);
                    table.ForeignKey(
                        name: "FK_Contract_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId");
                    table.ForeignKey(
                        name: "FK_Contract_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId");
                });

            migrationBuilder.CreateTable(
                name: "FacilityCertification",
                columns: table => new
                {
                    CertificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertificationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CertificationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusApproval = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FacilityCertification", x => x.CertificationId);
                    table.ForeignKey(
                        name: "FK_FacilityCertification_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Product",
                columns: table => new
                {
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Additional = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    NutritionType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Age = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Ingredient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Volume = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Origin = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Manufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddressManufacturer = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UnitProduct = table.Column<int>(type: "int", nullable: true),
                    ProductCategory = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusApproval = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Product", x => x.ProductId);
                    table.ForeignKey(
                        name: "FK_Product_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourismPackage",
                columns: table => new
                {
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PackageName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Price = table.Column<double>(type: "float", nullable: false),
                    Durations = table.Column<double>(type: "float", nullable: false),
                    DurationsType = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusApproval = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusOperating = table.Column<int>(type: "int", nullable: false),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourismPackage", x => x.PackageId);
                    table.ForeignKey(
                        name: "FK_TourismPackage_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId");
                    table.ForeignKey(
                        name: "FK_TourismPackage_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserSupport",
                columns: table => new
                {
                    SupportId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IssueType = table.Column<int>(type: "int", nullable: false),
                    Fullname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SupportMessage = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RequestDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponeBy = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ResponseDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ResponseMessage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsResolved = table.Column<bool>(type: "bit", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserSupport", x => x.SupportId);
                    table.ForeignKey(
                        name: "FK_UserSupport_Account_ResponeBy",
                        column: x => x.ResponeBy,
                        principalTable: "Account",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_UserSupport_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId");
                });

            migrationBuilder.CreateTable(
                name: "WithdrawalHistory",
                columns: table => new
                {
                    WithdrawalId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    TransactionReference = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ProcessedDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Note = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TransactionImage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    WithdrawalStatus = table.Column<int>(type: "int", nullable: false),
                    TourCompanyId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WithdrawalHistory", x => x.WithdrawalId);
                    table.ForeignKey(
                        name: "FK_WithdrawalHistory_TourCompany_TourCompanyId",
                        column: x => x.TourCompanyId,
                        principalTable: "TourCompany",
                        principalColumn: "TourCompanyId");
                    table.ForeignKey(
                        name: "FK_WithdrawalHistory_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId");
                });

            migrationBuilder.CreateTable(
                name: "BookingAgriculturalTour",
                columns: table => new
                {
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NumberOfAdults = table.Column<int>(type: "int", nullable: false),
                    NumberOfChildren = table.Column<int>(type: "int", nullable: true),
                    TotalAmmount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    StatusBooking = table.Column<int>(type: "int", nullable: false),
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingAgriculturalTour", x => x.BookingId);
                    table.ForeignKey(
                        name: "FK_BookingAgriculturalTour_Account_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_BookingAgriculturalTour_AgriculturalTourPackage_TourId",
                        column: x => x.TourId,
                        principalTable: "AgriculturalTourPackage",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "AgriculturalTourPackageTourGuide",
                columns: table => new
                {
                    AgriculturalTourPackagesTourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourGuidesGuideId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AgriculturalTourPackageTourGuide", x => new { x.AgriculturalTourPackagesTourId, x.TourGuidesGuideId });
                    table.ForeignKey(
                        name: "FK_AgriculturalTourPackageTourGuide_AgriculturalTourPackage_AgriculturalTourPackagesTourId",
                        column: x => x.AgriculturalTourPackagesTourId,
                        principalTable: "AgriculturalTourPackage",
                        principalColumn: "TourId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AgriculturalTourPackageTourGuide_TourGuide_TourGuidesGuideId",
                        column: x => x.TourGuidesGuideId,
                        principalTable: "TourGuide",
                        principalColumn: "GuideId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Certification",
                columns: table => new
                {
                    CertificationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CertificationName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IssuingOrganization = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CertificationDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusApproval = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TouristFacilityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Certification", x => x.CertificationId);
                    table.ForeignKey(
                        name: "FK_Certification_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId");
                    table.ForeignKey(
                        name: "FK_Certification_TouristFacility_TouristFacilityId",
                        column: x => x.TouristFacilityId,
                        principalTable: "TouristFacility",
                        principalColumn: "TouristFacilityId");
                });

            migrationBuilder.CreateTable(
                name: "Feedback",
                columns: table => new
                {
                    FeedbackId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Content = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rating = table.Column<int>(type: "int", nullable: false),
                    CreateTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Feedback", x => x.FeedbackId);
                    table.ForeignKey(
                        name: "FK_Feedback_Account_UserId",
                        column: x => x.UserId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Feedback_AgriculturalTourPackage_TourId",
                        column: x => x.TourId,
                        principalTable: "AgriculturalTourPackage",
                        principalColumn: "TourId");
                    table.ForeignKey(
                        name: "FK_Feedback_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "OCOPSell",
                columns: table => new
                {
                    OCOPSellId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    SellVolume = table.Column<double>(type: "float", nullable: false),
                    SalePrice = table.Column<double>(type: "float", nullable: false),
                    ManufacturingDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ExpiryDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActiveStatus = table.Column<bool>(type: "bit", nullable: true),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OCOPSell", x => x.OCOPSellId);
                    table.ForeignKey(
                        name: "FK_OCOPSell_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Activity",
                columns: table => new
                {
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActivityName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DurationInHours = table.Column<double>(type: "float", nullable: false),
                    DurationInHoursType = table.Column<int>(type: "int", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Imgs = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BreakTimeInMinutes = table.Column<double>(type: "float", nullable: false),
                    BreakTimeInMinutesType = table.Column<int>(type: "int", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StatusApproval = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaxCapacity = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Activity", x => x.ActivityId);
                    table.ForeignKey(
                        name: "FK_Activity_TourismPackage_PackageId",
                        column: x => x.PackageId,
                        principalTable: "TourismPackage",
                        principalColumn: "PackageId");
                });

            migrationBuilder.CreateTable(
                name: "Order",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CustomerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    OrderType = table.Column<int>(type: "int", nullable: false),
                    StatusOrder = table.Column<int>(type: "int", nullable: false),
                    PaymentType = table.Column<int>(type: "int", nullable: false),
                    PaymentStatus = table.Column<int>(type: "int", nullable: false),
                    ShipAddressId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CancelDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TotalAmount = table.Column<double>(type: "float", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ShippingCode = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ShipCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Order", x => x.OrderId);
                    table.ForeignKey(
                        name: "FK_Order_Account_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "Account",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Order_BookingAgriculturalTour_BookingId",
                        column: x => x.BookingId,
                        principalTable: "BookingAgriculturalTour",
                        principalColumn: "BookingId");
                });

            migrationBuilder.CreateTable(
                name: "ActivityProduct",
                columns: table => new
                {
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ActivityProduct", x => new { x.ActivityId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_ActivityProduct_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "ActivityId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ActivityProduct_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "TourDestination",
                columns: table => new
                {
                    TourDestinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    StartTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    EndTime = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CheckInDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CheckOutDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    VisitOrder = table.Column<int>(type: "int", nullable: false),
                    TypeActivity = table.Column<int>(type: "int", nullable: false),
                    StatusApproval = table.Column<int>(type: "int", nullable: false),
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourismPackageId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    DriverId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    AccommodationId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ActivityId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDestination", x => x.TourDestinationId);
                    table.ForeignKey(
                        name: "FK_TourDestination_Accommodation_AccommodationId",
                        column: x => x.AccommodationId,
                        principalTable: "Accommodation",
                        principalColumn: "AccommodationId");
                    table.ForeignKey(
                        name: "FK_TourDestination_Activity_ActivityId",
                        column: x => x.ActivityId,
                        principalTable: "Activity",
                        principalColumn: "ActivityId");
                    table.ForeignKey(
                        name: "FK_TourDestination_AgriculturalTourPackage_TourId",
                        column: x => x.TourId,
                        principalTable: "AgriculturalTourPackage",
                        principalColumn: "TourId");
                    table.ForeignKey(
                        name: "FK_TourDestination_Driver_DriverId",
                        column: x => x.DriverId,
                        principalTable: "Driver",
                        principalColumn: "DriverId");
                    table.ForeignKey(
                        name: "FK_TourDestination_TourismPackage_TourismPackageId",
                        column: x => x.TourismPackageId,
                        principalTable: "TourismPackage",
                        principalColumn: "PackageId");
                });

            migrationBuilder.CreateTable(
                name: "AdminBalance",
                columns: table => new
                {
                    TransactionId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionType = table.Column<int>(type: "int", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TransactionDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AdminBalance", x => x.TransactionId);
                    table.ForeignKey(
                        name: "FK_AdminBalance_BookingAgriculturalTour_BookingId",
                        column: x => x.BookingId,
                        principalTable: "BookingAgriculturalTour",
                        principalColumn: "BookingId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_AdminBalance_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OrderDetail",
                columns: table => new
                {
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ProductId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    UnitPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OrderDetail", x => new { x.OrderId, x.ProductId });
                    table.ForeignKey(
                        name: "FK_OrderDetail_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_OrderDetail_Product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Product",
                        principalColumn: "ProductId");
                });

            migrationBuilder.CreateTable(
                name: "VNPayPaymentResponse",
                columns: table => new
                {
                    ResponseId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    OrderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    BookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TxnRef = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BankCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BankTranNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CardType = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OrderInfo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PayDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ResponseCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TmnCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionNo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TransactionStatus = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SecureHash = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TypePayment = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VNPayPaymentResponse", x => x.ResponseId);
                    table.ForeignKey(
                        name: "FK_VNPayPaymentResponse_BookingAgriculturalTour_BookingId",
                        column: x => x.BookingId,
                        principalTable: "BookingAgriculturalTour",
                        principalColumn: "BookingId");
                    table.ForeignKey(
                        name: "FK_VNPayPaymentResponse_Order_OrderId",
                        column: x => x.OrderId,
                        principalTable: "Order",
                        principalColumn: "OrderId");
                });

            migrationBuilder.CreateTable(
                name: "BookingTourDestination",
                columns: table => new
                {
                    BookingDestinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourDestinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ActualStartTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    ActualEndTime = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<int>(type: "int", nullable: false),
                    BookingAgriculturalTourBookingId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BookingTourDestination", x => x.BookingDestinationId);
                    table.ForeignKey(
                        name: "FK_BookingTourDestination_BookingAgriculturalTour_BookingAgriculturalTourBookingId",
                        column: x => x.BookingAgriculturalTourBookingId,
                        principalTable: "BookingAgriculturalTour",
                        principalColumn: "BookingId");
                    table.ForeignKey(
                        name: "FK_BookingTourDestination_TourDestination_TourDestinationId",
                        column: x => x.TourDestinationId,
                        principalTable: "TourDestination",
                        principalColumn: "TourDestinationId");
                });

            migrationBuilder.CreateTable(
                name: "TourDestinationTourGuide",
                columns: table => new
                {
                    TourDestinationsTourDestinationId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    TourGuidesGuideId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TourDestinationTourGuide", x => new { x.TourDestinationsTourDestinationId, x.TourGuidesGuideId });
                    table.ForeignKey(
                        name: "FK_TourDestinationTourGuide_TourDestination_TourDestinationsTourDestinationId",
                        column: x => x.TourDestinationsTourDestinationId,
                        principalTable: "TourDestination",
                        principalColumn: "TourDestinationId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_TourDestinationTourGuide_TourGuide_TourGuidesGuideId",
                        column: x => x.TourGuidesGuideId,
                        principalTable: "TourGuide",
                        principalColumn: "GuideId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "About",
                columns: new[] { "AboutId", "Content" },
                values: new object[] { 1, "<p>Du lịch nông nghiệp kết hợp với sản phẩm OCOP tại Việt Nam thường được triển khai một cách riêng biệt, thiếu sự liên kết chặt chẽ giữa các điểm đến du lịch, các cơ sở sản xuất nông sản và các công ty du lịch. Sự thiếu kết nối này dẫn đến khó khăn cho khách hàng trong việc tìm kiếm thông tin về sản phẩm OCOP và các điểm đến du lịch nông nghiệp. Các cơ sở sản xuất nông sản không có một hệ thống chung để giới thiệu sản phẩm của mình, trong khi các công ty du lịch thiếu thông tin cụ thể về các sản phẩm địa phương đặc trưng mà họ có thể đưa vào các tour du lịch của mình. Điều này khiến khách hàng khó khăn trong việc tìm hiểu và lựa chọn điểm đến, từ đó làm giảm sức hấp dẫn của các tour du lịch nông nghiệp và hạn chế khả năng quảng bá sản phẩm OCOP.</p>\r\n\r\n        <p>Thêm vào đó, mặc dù sản phẩm OCOP đã đạt tiêu chuẩn chất lượng, nhưng hệ thống phân phối các sản phẩm này, đặc biệt trên các nền tảng kỹ thuật số, vẫn còn nhiều hạn chế. Sản phẩm OCOP chủ yếu được phân phối qua các kênh truyền thống hoặc chợ địa phương, trong khi các nền tảng thương mại điện tử chưa thực sự phát triển mạnh mẽ đối với các sản phẩm này. Điều này không chỉ gây khó khăn trong việc tiếp cận thị trường trong nước mà còn hạn chế khả năng tiếp cận thị trường quốc tế, nơi mà người tiêu dùng ngày càng ưa chuộng mua sắm trực tuyến. Việc thiếu các kênh phân phối kỹ thuật số và chiến lược marketing hiệu quả khiến sản phẩm OCOP không phát triển mạnh mẽ, đồng thời giảm cơ hội mở rộng ra các thị trường tiềm năng, đặc biệt là khách quốc tế.</p>\r\n\r\n        <p>Để giải quyết những khó khăn này, một hệ thống nền tảng tích hợp giữa quản lý du lịch nông nghiệp và kinh doanh sản phẩm OCOP đã được đề xuất. Nền tảng này được thiết kế dưới dạng ứng dụng web và di động, tập trung vào việc tạo ra sự kết nối chặt chẽ giữa các liên kết nội bộ: các công ty du lịch, chủ sở hữu cơ sở sản xuất nông sản, du khách và các cơ quan quản lý địa phương. Với việc ra mắt nền tảng kỹ thuật số này, những khó khăn hiện tại sẽ được giải quyết một cách hiệu quả. Sự kết nối giữa các bên không chỉ tạo điều kiện để nâng cao trải nghiệm du lịch mà còn cung cấp tiêu thụ sản phẩm OCOP, tăng thu nhập cho người dân địa phương. Đồng thời, hệ thống sẽ đóng góp vào sự phát triển bền vững của các công ty du lịch nông nghiệp, giúp tăng giá trị sản phẩm OCOP và cải thiện nền kinh tế nông thôn tại Việt Nam.</p>\r\n    " });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "AccessFailedCount", "AvatarURL", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "Fullname", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isAccountActive" },
                values: new object[,]
                {
                    { new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), 0, null, "15267098-32a5-49f0-822a-e7580fe1b42b", null, "truongthu112201@gmail.com", true, "Tourism Companies", null, false, null, "TRUONGTHU112201@GMAIL.COM", "TOURISMCOMPANIES", "AQAAAAIAAYagAAAAECEhQPg5CNmHEZzvXY67LIX88WDelRNmQsG6mKAFdcP/DohEpCfoeTQ7YffHbplwsw==", null, false, "50c37385-71c8-4e79-8bd8-21b43f716748", false, "TourismCompanies", true },
                    { new Guid("10000000-0000-0000-0000-000000000001"), 0, null, "44ed6a64-2099-42f6-acf5-68798f2061bf", null, "bangiocfarmtour@gmail.com", true, "Du Lịch Sinh Thái Thác Bản Giốc", null, false, null, "bangiocfarmtour@GMAIL.COM", "bangiocfarmtour", "AQAAAAIAAYagAAAAELmDkOBatQy5vy+/d9ix8/M/SLTvCUeYXh+DKKinvvBCf/BkaAph8L2ZirtzFsii6A==", null, false, "da1b81ab-537e-41d4-b810-1b4b4aec2870", false, "bangiocfarmtour", true },
                    { new Guid("10000000-0000-0000-0000-000000000002"), 0, null, "22d10e52-1bc3-4863-87b0-1f4bf117c1ef", null, "sapa@gmail.com", true, "Sa Pa Eco Farm Tour", null, false, null, "sapa@GMAIL.COM", "sapa", "AQAAAAIAAYagAAAAEBmCtM7Xyy99RaJC0jgaIkkHrKR51G7/dJNVEurPShfe/yBZUI8fGVzDTHWoCNTx7w==", null, false, "c76034dd-99dd-4603-a7a5-cb950253df84", false, "sapa", true },
                    { new Guid("10000000-0000-0000-0000-000000000003"), 0, null, "b8455758-b070-41fe-8468-efd3cba68dd1", null, "grapevalley@gmail.com", true, "Farm Du Lịch Grape Valley", null, false, null, "grapevalley@GMAIL.COM", "grapevalley", "AQAAAAIAAYagAAAAEEVlMUKcTpZZmfPzh/h/OFKHfQHly9tVCpVK9RYiPfSQP45UGUNlq3Xjt6g4ZQuJMg==", null, false, "6d358646-b1aa-479d-8a2e-b072092efcd2", false, "grapevalley", true },
                    { new Guid("10000000-0000-0000-0000-000000000004"), 0, null, "d7d2bf98-b496-4122-8a46-ccc360f3d5f4", null, "daitu@gmail.com", true, "Nông Trại Chè Trải Nghiệm Đại Từ", null, false, null, "daitu@GMAIL.COM", "daitu", "AQAAAAIAAYagAAAAEI/lzCxVUArX6+fR2l0cSXqXV1oueGu8L6MJwIKf/zWdUvAXhZGtDC3p4CRLhLM5PQ==", null, false, "95eb2de1-4306-48b4-b7fd-8ea82f43fb18", false, "daitu", true },
                    { new Guid("10000000-0000-0000-0000-000000000005"), 0, null, "13447878-953d-432c-ac74-263b3d513477", null, "buondoncoffee@gmail.com", true, "Buôn Đôn Coffee Farm Tour", null, false, null, "buondoncoffee@GMAIL.COM", "buondoncoffee", "AQAAAAIAAYagAAAAEPNAr3M1eQTOywhFR4bU9lC8DXiLSSDIv/DxttaGX3C1o2CJBim9X2j9MaK8S0TQNg==", null, false, "2a62da72-13fe-49ce-b22d-69eda03331f1", false, "buondoncoffee", true },
                    { new Guid("10000000-0000-0000-0000-000000000006"), 0, null, "c7553fa1-e4b4-4c28-b623-89372f3e2888", null, "hagiang@gmail.com", true, "Hà Giang Farmstay & Trek", null, false, null, "hagiang@GMAIL.COM", "hagiang", "AQAAAAIAAYagAAAAEMsF6M2LpwT7iPxKR88/7JIW8RQh9RlxkyWW0V0qVtp0NzKumnHJahqNwQYgSBxLvQ==", null, false, "81dfa178-7773-4fda-8d8c-8f8e288d9dff", false, "hagiang", true },
                    { new Guid("10000000-0000-0000-0000-000000000007"), 0, null, "9bbba6d9-90d9-4016-87b9-90d654202ff5", null, "tramyfarmtour@gmail.com", true, "Trà My Sâm Ngọc Linh Tour", null, false, null, "tramyfarmtour@GMAIL.COM", "tramyfarmtour", "AQAAAAIAAYagAAAAENGkSaYi3uVsfB67EnQqQ6/ZAZwQGqyc5wPv6gqMDwAbPSovUENu7tCf8u99n1GAdQ==", null, false, "3e329d80-2d85-4adc-984e-b7cfb4176125", false, "tramyfarmtour", true },
                    { new Guid("10000000-0000-0000-0000-000000000008"), 0, null, "60e1394a-e431-4a4e-bc9c-ee993e1bf0e9", null, "dalatorganic@gmail.com", true, "Đà Lạt Organic Farm Tour", null, false, null, "dalatorganic@GMAIL.COM", "dalatorganic", "AQAAAAIAAYagAAAAEM+UcvzzgqBbx7oznKDYCBQJn0yLS7IGjNvxdADVABhvLKZnRzY6m3sxZYrs6gRj9g==", null, false, "eacf77d8-5b33-4471-8a54-98d686631056", false, "dalatorganic", true },
                    { new Guid("10000000-0000-0000-0000-000000000009"), 0, null, "44df4ea7-bf06-4b95-9fb8-06badb867471", null, "binhthuanfarm@gmail.com", true, "Farmstay Nho & Thanh Long Bắc Bình", null, false, null, "binhthuanfarm@GMAIL.COM", "binhthuanfarm", "AQAAAAIAAYagAAAAEIWLWYcTwwVgETU+6jgMUnNvKB2jDcyCE592/hERGm1srSRmN6H12eUa2nrnEXKA2g==", null, false, "b4f9a40d-ba11-4838-b07f-fa3106e015cc", false, "binhthuanfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000010"), 0, null, "8e3f6f49-cf33-4bfb-a313-a156d4e69e95", null, "babeecotour@gmail.com", true, "Ba Bể Lake Ecofarm Tour", null, false, null, "babeecotour@GMAIL.COM", "babeecotour", "AQAAAAIAAYagAAAAEBgYE6RWqOHTU6CjKAFfYv82KAV0aqpBoI5JKlJI11A/6gPLkhGUXtiVQwAMIBQZKg==", null, false, "26396446-c7fc-4c36-9ad1-a1ec72dbbc06", false, "babeecotour", true },
                    { new Guid("10000000-0000-0000-0000-000000000011"), 0, null, "aeb58177-96d2-46b0-a791-49f24e7d59d9", null, "tayninhfarm@gmail.com", true, "Trang Trại Nông Sản Sạch Tân Châu", null, false, null, "tayninhfarm@GMAIL.COM", "tayninhfarm", "AQAAAAIAAYagAAAAEF4oGQ4xOA82qFA4Jq0ImmhJeWjRxH4n13T2kjt1U19J9jyo+f3YU7SyGyC+QZLsYw==", null, false, "d3ec2221-d7c4-4ef6-9f08-d2ebe6f3f482", false, "tayninhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000012"), 0, null, "60d1dd95-49ff-49f5-8d4e-c00a7a3d470e", null, "phuyentour@gmail.com", true, "Trải nghiệm Nông trại Biển & Rau Tuy An", null, false, null, "phuyentour@GMAIL.COM", "phuyentour", "AQAAAAIAAYagAAAAEDQ1lNUpEjLlBXwuQQzxyrzKZNZlhBuYbAFFwzjqD4yC6CnyqF/P6YtLexyHZwVNTA==", null, false, "fdd5f286-32f7-4def-9afa-11e887fbf8a9", false, "phuyentour", true },
                    { new Guid("10000000-0000-0000-0000-000000000013"), 0, null, "d02f1c2d-bb2d-4e22-996d-6da2e3d2bb30", null, "travinhfarm@gmail.com", true, "Trang Trại Nông Sản Sạch Càng Long", null, false, null, "travinhfarm@GMAIL.COM", "travinhfarm", "AQAAAAIAAYagAAAAEH6VYY0ibqkSo+3OvQ8Z1t6UfTumVoZgDZi4v7kC4a7XfaRFq9QZrzoTvg58ouYPcQ==", null, false, "8e30d8ae-51f4-4588-bd7f-b719bda2c756", false, "travinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000014"), 0, null, "86e592f8-c105-47ef-9186-0d6ee6e800fd", null, "soctrangfarm@gmail.com", true, "Mỹ Xuyên Farmstay", null, false, null, "soctrangfarm@GMAIL.COM", "soctrangfarm", "AQAAAAIAAYagAAAAELV90rOsMRmy9dLryx0gF23rR7VC6wLdVJH8FPJPVNGluykrQBudWEuN/UDz2pUeXQ==", null, false, "851eb97c-4f1e-42b6-a4be-9bf8cab5a7f4", false, "soctrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000015"), 0, null, "f3b649f4-7483-45db-9126-45fcbc24a043", null, "angiangfarm@gmail.com", true, "Trang Trại Châu Đốc", null, false, null, "angiangfarm@GMAIL.COM", "angiangfarm", "AQAAAAIAAYagAAAAEH14WsKtadXrxtPrdQrwxC+RfSfuggdNLpweayLZrqVuXcq4NJV0Ujf8gIIBgrPWcA==", null, false, "d90b2e88-1b85-4fc1-a0a3-5889b1c19aac", false, "angiangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000016"), 0, null, "67a7300a-d91c-4eab-8ba1-582b6e164efc", null, "canthoexplore@gmail.com", true, "Cần Thơ Farmstay", null, false, null, "canthoexplore@GMAIL.COM", "canthoexplore", "AQAAAAIAAYagAAAAENkRlLYICTZO/J46AZmxZ3Jpqope1+fKqy1hxdNw5Qjnrxkv8ctYHMdXfjl6beFWKw==", null, false, "3b7716d5-5b7a-47b2-88c4-059c106b3582", false, "canthoexplore", true },
                    { new Guid("10000000-0000-0000-0000-000000000017"), 0, null, "0d279821-3406-40d0-9095-f2310f73bcac", null, "phuquocfarm@gmail.com", true, "Phú Quốc Nông Trại Sản Xuất Hữu Cơ", null, false, null, "phuquocfarm@GMAIL.COM", "phuquocfarm", "AQAAAAIAAYagAAAAED94Hkob9fjANyuBX4e987FSF2gChZc3DiM2EHOyFKykHQUSc1ecXsZWM3fv+UN24Q==", null, false, "473fb8bf-2bc1-4c25-92e9-1bb1d6ba4e82", false, "phuquocfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000018"), 0, null, "a6560b79-00e8-4604-8504-875056fb86c3", null, "halongfarm@gmail.com", true, "Trại Nông Sản Hạ Long", null, false, null, "halongfarm@GMAIL.COM", "halongfarm", "AQAAAAIAAYagAAAAEOAAunwgPQ2UTXVuxpWVGUxuOhASTAGR7io7Y7bMfquzkqLwARnm3XkMkuAFjj7VDA==", null, false, "62dccd0d-c59c-47a4-bf72-e8a5a5eecca0", false, "halongfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000019"), 0, null, "48d0f906-d7fb-48bc-bdc4-9109298eacc2", null, "anlaofarm@gmail.com", true, "Trang Trại Nông Sản An Lão", null, false, null, "anlaofarm@GMAIL.COM", "anlaofarm", "AQAAAAIAAYagAAAAEBfxVnHCo/wNZkli/RbtFvUy+PbjK3mSMMvtuh7HTzc5PVlrwIi4l/6204PxVmgWDA==", null, false, "2a12ee93-df67-4dc0-b62b-7f869449daeb", false, "anlaofarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000020"), 0, null, "7e435a86-863b-4f2c-aba3-c770830167a8", null, "daitufarm@gmail.com", true, "Nông Trại Đại Từ", null, false, null, "daitufarm@GMAIL.COM", "daitufarm", "AQAAAAIAAYagAAAAEBCKZO7c5NrEUJ86n4gyxD3/bIJRXwk/w+XZuVa+Xu8g9Lojw7rxzVceHC5qPYSFqQ==", null, false, "88aead3d-92a6-481a-8b0b-649aa36e5456", false, "daitufarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000021"), 0, null, "d10c5cdd-6020-4b42-b64e-2e49cf2ad6da", null, "vinhfarm@gmail.com", true, "Trại Nông Sản Vinh", null, false, null, "vinhfarm@GMAIL.COM", "vinhfarm", "AQAAAAIAAYagAAAAEGl8XYcg+hEngblex9cCdBDD19UgoTQEUFSAlY+KLgp+60+WRvvAgQNBVtbC8onUyQ==", null, false, "bbb156bb-e8bc-4d24-a7c7-9c52e6e991f5", false, "vinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000022"), 0, null, "6c5088f6-9619-4831-99c1-cf9fbe50ca04", null, "trieusonfarm@gmail.com", true, "Trang Trại Nông Sản Triệu Sơn", null, false, null, "trieusonfarm@GMAIL.COM", "trieusonfarm", "AQAAAAIAAYagAAAAEJKRjLSZ9btYnnWhhxi6y0kIcCD1QMfkaY2CIpKZVfcwdRwyDl7Uok99CtNMpUh/Pg==", null, false, "699385a5-83e0-4030-ab11-e88c8731028b", false, "trieusonfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000023"), 0, null, "d029f983-55fa-4be1-a6d8-8ff1baae0593", null, "hatinhfarm@gmail.com", true, "Trại Nông Sản Hà Tĩnh", null, false, null, "hatinhfarm@GMAIL.COM", "hatinhfarm", "AQAAAAIAAYagAAAAEHAqA13M4MJjn33vBzO9kEzObJzalUgFvMcWJuIx9NhCPGNqNahNqUBktE2waRu97A==", null, false, "3fc73575-78a1-40bb-ad46-d8e6d6fab295", false, "hatinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000024"), 0, null, "fd1e1a6c-8115-4bdc-92e5-781067a64285", null, "donghoifarm@gmail.com", true, "Trang Trại Đồng Hới", null, false, null, "donghoifarm@GMAIL.COM", "donghoifarm", "AQAAAAIAAYagAAAAEHYK1oV7MV0LwdbvzMFwsZxTkB+1OcPVjZHwGqnPM4WpY9qLgqaqkig7vQBUd+aWXQ==", null, false, "42c352c0-8bb3-4666-9600-621c84656e38", false, "donghoifarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000025"), 0, null, "0e3cd622-468a-4718-8751-17cedd310d7d", null, "donghafarm@gmail.com", true, "Trang Trại Nông Sản Đông Hà", null, false, null, "donghafarm@GMAIL.COM", "donghafarm", "AQAAAAIAAYagAAAAEHTwUGF9PcH4HF2QQZ4RT38Y29SZZa2yLOHwO1k9BiuIM+EvgzXJKgKmNy16zXHvZw==", null, false, "d2e4be40-c0f5-47a2-946f-bbcc85b11306", false, "donghafarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000026"), 0, null, "d92c8799-e3d3-445d-9576-3907a0fb2265", null, "quynhonfarm@gmail.com", true, "Trại Nông Sản Quy Nhơn", null, false, null, "quynhonfarm@GMAIL.COM", "quynhonfarm", "AQAAAAIAAYagAAAAEB0eEGMezh/fslMfCdaV2Lx3W6k5KO809MpDqbshP+U35nO7Pyaa57YHxZoOBwD0Ag==", null, false, "d091567b-1b12-430e-a8b9-e6b192126030", false, "quynhonfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000027"), 0, null, "6f1fd0f3-3b38-4660-8833-9e18f7577208", null, "tuyhoafarm@gmail.com", true, "Trang Trại Nông Sản Tuy Hòa", null, false, null, "tuyhoafarm@GMAIL.COM", "tuyhoafarm", "AQAAAAIAAYagAAAAEGE0taJvUtH0JBDwqwjMD7xtU6cdVVnVBqOSHcNVeivBaD2O2iujOBeesFXtR+0WsA==", null, false, "e0a0a232-2315-456c-ac89-d1cdc81eac34", false, "tuyhoafarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000028"), 0, null, "99881e65-0b4c-4736-93fd-b9430ed2a1e7", null, "nhatrangfarm@gmail.com", true, "Trại Nông Sản Nha Trang", null, false, null, "nhatrangfarm@GMAIL.COM", "nhatrangfarm", "AQAAAAIAAYagAAAAED7+OpnHdcFKQkEEpkoXF/0+3s7U0OCjoIp7f06gwe4VGobJUxBQGiVjgCgOn8FJEA==", null, false, "2a82c4e1-3837-4c6e-9d24-cecdb10876fe", false, "nhatrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000029"), 0, null, "e085bc0b-ae01-499f-bb3d-870b7a9b1fde", null, "phanrangfarm@gmail.com", true, "Trại Nông Sản Phan Rang", null, false, null, "phanrangfarm@GMAIL.COM", "phanrangfarm", "AQAAAAIAAYagAAAAEJ/FKKE2UzyVc3xi9ADfUqjrSxH2EfkkWsy8J/mGZ73gIWTpRGiFbTpad23llb1Qbw==", null, false, "cc3732e7-b188-42f3-bfef-de10298bcb68", false, "phanrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000030"), 0, null, "d1e76980-bdbd-46b7-aeb7-43534d582cc5", null, "phanthietfarm@gmail.com", true, "Trang Trại Nông Sản Phan Thiết", null, false, null, "phanthietfarm@GMAIL.COM", "phanthietfarm", "AQAAAAIAAYagAAAAEEmXGFk1Y4/XtmEmgOz8eb2dbMFucVQbOxdg+xIHGUW7EC7epOPFwarWOs23+2tqqA==", null, false, "daa85766-66ff-4b98-b8f7-33cd745833c3", false, "phanthietfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000031"), 0, null, "cc377f1c-8c5c-4af5-9dd1-4de840ddb47f", null, "tananfarm@gmail.com", true, "Trại Nông Sản Tân An", null, false, null, "tananfarm@GMAIL.COM", "tananfarm", "AQAAAAIAAYagAAAAELzHvUxwMGsArq7tf0YTm6a53C193Z2bfKgICN+EVFJFaDdRkhJCzL6Q8kS9ZcrizQ==", null, false, "a065ba45-94d3-480a-9590-d22fc70d0934", false, "tananfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000032"), 0, null, "f56cbe59-7faf-45a5-9db2-578199cf31da", null, "vinhlongfarm@gmail.com", true, "Trại Nông Sản Vĩnh Long", null, false, null, "vinhlongfarm@GMAIL.COM", "nhavinhlongfarmtrangfarm", "AQAAAAIAAYagAAAAEGcGWFn8ndkOAtRnsQeXtFojs3Na7Bulik3Y6KKrJILhDx+DbyEVyBXccqOFTeVfSA==", null, false, "98005a94-6620-4600-96bc-c7275196f8cd", false, "vinhlongfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000033"), 0, null, "3dba63ff-acff-44e0-b2f2-6bc8821b6ef3", null, "contact@vinpearlresort.com", true, "CÔNG TY TNHH VINPEARL RESORT & SPA", null, false, null, "CONTACT@VINPEARLRESORT.COM", "VINPEARLRESORT", "AQAAAAIAAYagAAAAEBiYC9G6qvAgqEqpcfj0H2MD95G26oTZdFFBfd8ADPUB/M+fQJ+k1XlmX8BvWyD1RA==", null, false, "b56e60bf-fb45-484d-86ad-b53ba4c16f7e", false, "VinpearlResort", true },
                    { new Guid("10000000-0000-0000-0000-000000000034"), 0, null, "efaa63eb-f204-496c-ad2d-1b36463b2d22", null, "info@muongthanhhotel.com", true, "TẬP ĐOÀN KHÁCH SẠN MƯỜNG THANH", null, false, null, "INFO@MUONGTHANHHOTEL.COM", "MUONGTHANHHOTEL", "AQAAAAIAAYagAAAAEGxCuAHz7FiqdVQ43PV7JAWBjYx8bSIwirBk6z2A02/ze5YVr6BWIsRK38E7vAarXw==", null, false, "457bda7a-7163-409a-84e6-b259390482cb", false, "MuongThanhHotel", true },
                    { new Guid("10000000-0000-0000-0000-000000000035"), 0, null, "a3b3859b-f4be-4ff6-b6ae-aa11e6b65ff5", null, "reservation@intercontinental.com", true, "KHÁCH SẠN INTERCONTINENTAL HANOI WESTLAKE", null, false, null, "RESERVATION@INTERCONTINENTAL.COM", "INTERCONHANOI", "AQAAAAIAAYagAAAAEF82Nl8TRP1Wg7FjYxd4nXO5KCfOJoCwtyVJglLciLWEijyTi3gfyjrVXt3Ro9kKww==", null, false, "a3c21007-90ba-4849-b7c9-4f01338db9d1", false, "InterConHanoi", true },
                    { new Guid("10000000-0000-0000-0000-000000000036"), 0, null, "bdd77708-916b-41da-8364-c5d089086920", null, "info@sofitellegend.com", true, "KHÁCH SẠN SOFITEL LEGEND METROPOLE HÀ NỘI", null, false, null, "INFO@SOFITELLEGEND.COM", "SOFITELLEGEND", "AQAAAAIAAYagAAAAEGANR+kLRH1/Oojj94eaQveGG5BwM3ZUzIHkuaxsIMSwSOc/Yc1bl+z9IPRuZb8Iqw==", null, false, "7b1a0c00-5990-49d2-96c3-3bb9e45a91ca", false, "SofitelLegend", true },
                    { new Guid("10000000-0000-0000-0000-000000000037"), 0, null, "bac076ce-25cf-4c00-8759-49d48792db39", null, "reservation@furamadanang.com", true, "CÔNG TY TNHH FURAMA RESORT ĐÀ NẴNG", null, false, null, "RESERVATION@FURAMADANANG.COM", "FURAMADANANG", "AQAAAAIAAYagAAAAEBoQf2xQPSZPWcSL97/KH2ojgKg/QviHFBqfBmgudyhjVZXXO6IayQ8p6o0/RSiXOg==", null, false, "cdc2b3a1-2c8e-4cc9-a0d1-c217adcbc742", false, "FuramaDanang", true },
                    { new Guid("10000000-0000-0000-0000-000000000038"), 0, null, "bc103b55-f46e-4dff-8b51-5fd94da9b167", null, "spa@anantara.com", true, "CÔNG TY TNHH ANANTARA QUY NHƠN VILLAS", null, false, null, "SPA@ANANTARA.COM", "ANANTARASPA", "AQAAAAIAAYagAAAAELp/XpiSbVWseOrEVTIDBaQobHuMACjZvnNMLUB7a/hkF0soVLwYDqV3XfD0kk7GUw==", null, false, "40f1a956-4381-4b1b-a2a4-51585e3ddd96", false, "AnantaraSpa", true },
                    { new Guid("10000000-0000-0000-0000-000000000039"), 0, null, "34105668-4aa5-46ba-83ea-000880ce1daf", null, "resort@amanoi.com", true, "CÔNG TY TNHH AMANOI RESORT NINH THUẬN", null, false, null, "RESORT@AMANOI.COM", "AMANOISPA", "AQAAAAIAAYagAAAAEM4KPbkZBqbTuXwm+VVHBJDJgaduvfNDbRrLYOKlxj7I4oSSEhU1uvLjW4pIcj/7xA==", null, false, "34a67541-2c2a-42cb-8561-a3931d99c019", false, "Amanoispa", true },
                    { new Guid("10000000-0000-0000-0000-000000000040"), 0, null, "01c975c6-5fd9-451b-9f67-42ad63a21c90", null, "contact@sixsenses.com", true, "CÔNG TY TNHH SIX SENSES CÔN ĐẢO", null, false, null, "CONTACT@SIXSENSES.COM", "SIXSENSESCON", "AQAAAAIAAYagAAAAELvHtryxt72XxmLjKnAGDDA2Z/LZTlm8CBnb34CwO1rq0NxZgAMJNenxoVcdqPA0Iw==", null, false, "633852bb-af22-4d33-8c23-7db81120799d", false, "SixSensesCon", true },
                    { new Guid("10000000-0000-0000-0000-000000000041"), 0, null, "95552b4b-9a3a-4cc2-925f-3723eddba28f", null, "langco@banyantree.com", true, "CÔNG TY TNHH BANYAN TREE LĂNG CÔ", null, false, null, "LANGCO@BANYANTREE.COM", "BANYANTREE", "AQAAAAIAAYagAAAAEKwTrk2NbV5NJeMC5dCFzU+2RPhoxyorqu930UZFZMTOXtWw2S9PTo7vcuvivqAclw==", null, false, "e982fa5c-c2f3-4e98-aca2-e41c160249bd", false, "BanyanTree", true },
                    { new Guid("10000000-0000-0000-0000-000000000042"), 0, null, "a6e31c2f-ecb0-4e71-ade5-9f0d4e62ca8c", null, "saigon@hyatt.com", true, "CÔNG TY TNHH PARK HYATT SÀI GÒN", null, false, null, "SAIGON@HYATT.COM", "PARKHYATT", "AQAAAAIAAYagAAAAEBbcqO+cuckQwIOR4z1rFRgi7OeCHbi5HY8YJfAYbxqayiFiWjhGhC/R3tnDtB5w3A==", null, false, "4b8fc5e4-526d-4ab5-9c32-7f38d3cf6334", false, "ParkHyatt", true },
                    { new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), 0, null, "7a5bed0e-6bae-4678-ae37-3b845c07674a", null, "lucianafuste0717@gmail.com", true, "Content Moderators", null, false, null, "LUCIANAFUSTE0717@GMAIL.COM", "CONTENTMODERATORS", "AQAAAAIAAYagAAAAEJVeE+14gryvv7S3eRRfOE7DhP1NNXZoavkvWQYYu7889TExrY+QhhDnMdMciqYemQ==", null, false, "f0414779-3867-41da-88f7-2c0964657817", false, "ContentModerators", true },
                    { new Guid("20000000-0000-0000-0000-000000000018"), 0, null, "8468f0d3-ad42-4604-84d7-4dd9af22363b", null, "contact@gmail.com", true, "Quy Nhơn Explorer", null, false, null, "CONTACT@GMAIL.COM", "QUYNHONEXPLORER", "AQAAAAIAAYagAAAAEE3MTfQdNqX6MnJKCxugTj6jZT/4doIWubgU/Qa/mn9sGCioQXw7unlbwEhehd7Aug==", null, false, "ca60937f-45bc-4397-b493-4f875596e22d", false, "quynhonexplorer", true },
                    { new Guid("20000000-0000-0000-0000-000000000019"), 0, null, "b2d26521-fd4b-4fae-b367-8e02d7e80f16", null, "contact@hoianheritage.com", true, "Hoi An Heritage Tours", null, false, null, "CONTACT@HOIANHERITAGE.COM", "HOIANHERITAGEACCOUNT", "AQAAAAIAAYagAAAAEPtOOC8tjuoNsMEsqrpxXzaaKiZFmhDSHCBNVXdE3m/PPbl90SRFPLw8csN5nLGjZA==", null, false, "db63d25b-aa68-4c3c-974a-12ada526b5b3", false, "hoianheritage", true },
                    { new Guid("20000000-0000-0000-0000-000000000020"), 0, null, "59a8e5bb-1676-4b7a-b3c5-cb876a12945e", null, "info@danangdiscovery.com", true, "Da Nang Discovery Travel", null, false, null, "INFO@DANANGDISCOVERY.COM", "DANANGDISCOVERYACCOUNT", "AQAAAAIAAYagAAAAEPaVZRg/O2YKWMi2EuCTm2TisPanM2UOXbIhQlvPyUKJNHeCFBYDcoU1JP9vxfN5sQ==", null, false, "5d5beb0d-3b92-4263-b06c-cbbab7a7eeff", false, "DaNangDiscoveryAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000021"), 0, null, "f1bca712-94d6-4c3a-b385-741b5e0a8fb7", null, "contact@hueimperial.com", true, "Hue Imperial Adventures", null, false, null, "CONTACT@HUEIMPERIAL.COM", "HUEIMPERIALACCOUNT", "AQAAAAIAAYagAAAAEN6iBmSkqg7CFJOWO0xZ7bJQ0Vkjgc1YUSmTxJkxyM2723iB49CqxK75renPV2EcJw==", null, false, "2d3b285d-1966-4bc7-98a4-1125a81dff04", false, "HueImperialAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000022"), 0, null, "00ebee58-6fee-4849-b6f0-e78fc24bb3b5", null, "info@nhatrangbay.com", true, "Nha Trang Bay Tours", null, false, null, "INFO@NHATRANGBAY.COM", "NHATRANGBAYACCOUNT", "AQAAAAIAAYagAAAAEIZk8VBHJJ0Y6in+iIk6+b40hPG57HtCNHPvxqOQRGrmhbWHUFPjNc2T1MiE1jizog==", null, false, "1de3a56b-b3de-45d5-9a1b-8cad48c6e0f4", false, "NhaTrangBayAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000023"), 0, null, "fcb57389-c384-422b-bd87-40118fc0c84a", null, "booking@halongcruise.com", true, "Ha Long Cruise Experience", null, false, null, "BOOKING@HALONGCRUISE.COM", "HALONGCRUISEACCOUNT", "AQAAAAIAAYagAAAAEJ2PLN62xQCdlSt78y8N8GT0gkws3dkGpXUR3Ya3lpLcAMuJzM/Iz5aWEvecrU2fIg==", null, false, "793b705c-ef80-4c10-80af-ad6a1a7c0fb8", false, "HaLongCruiseAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000024"), 0, null, "4585f5a7-2138-477c-b04b-edcf3d3b8783", null, "contact@sapahighland.com", true, "Sapa Highland Adventures", null, false, null, "CONTACT@SAPAHIGHLAND.COM", "SAPAHIGHLANDACCOUNT", "AQAAAAIAAYagAAAAEG9t4FWAWa/WPMpzAuSsmDdBKOCCkP11UrUp0HCHGopoSNlbqHpSBwHdFm2g6z5zgA==", null, false, "5cf0f97a-81c8-468f-8a24-00177261eecc", false, "SapaHighlandAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000025"), 0, null, "e8de3dd6-392c-492b-89b9-423195f5be0d", null, "info@mekongdelta.com", true, "Mekong Delta Explorers", null, false, null, "INFO@MEKONGDELTA.COM", "MEKONGDELTAACCOUNT", "AQAAAAIAAYagAAAAEMmei6Iw3LjCKyptJgDlkPOb8SIYK+JwCIxssqpC1fUHf+xNOANWy1GDNmyOvD6ZXQ==", null, false, "b76ca1e8-e415-4a0a-bf90-f126f8480fb7", false, "MekongDeltaAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000026"), 0, null, "62ebaed6-d939-457f-a517-833590b2abab", null, "contact@phuquocisland.com", true, "Phu Quoc Island Tours", null, false, null, "CONTACT@PHUQUOCISLAND.COM", "PHUQUOCISLANDACCOUNT", "AQAAAAIAAYagAAAAEE+l3RsOOOu54PYtWYqtX/25VnpSlVf6GgnqJrToiQ+DKWa6gZCjKV9YFH9HgqavRw==", null, false, "ea368093-2b4a-41de-9752-f828a3229233", false, "PhuQuocIslandAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000027"), 0, null, "b27702b1-265c-4673-9322-020c2e8ccfe3", null, "info@dalateco.com", true, "Da Lat Eco Tourism", null, false, null, "INFO@DALATECO.COM", "DALATECOACCOUNT", "AQAAAAIAAYagAAAAEG/zxDDarNGyAhP/9gNaV/ICf1TN3Lg6UsspduN0D3+AnN6X1ypqQHcJ3Fmh2ITG1g==", null, false, "55f34306-48eb-413a-9154-1473bafc01d9", false, "DaLatEcoAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000028"), 0, null, "7880597d-fd93-41b8-9526-d47cc58a9760", null, "booking@condaotours.com", true, "Con Dao Heritage Tours", null, false, null, "BOOKING@CONDAOTOURS.COM", "CONDAOACCOUNT", "AQAAAAIAAYagAAAAEARzmjxGTSacBCvVck4BbdyCJC92wskzJHGILCtdjo/UlnJmgBDli+yk6nZ8Nhmkrg==", null, false, "62246968-e8a2-493f-9d00-354b8a378a0a", false, "ConDaoAccount", true },
                    { new Guid("22222222-2222-2222-2222-222222222222"), 0, "https://example.com/avatar1.jpg", "a981d015-878a-4983-8c83-ac7288325bc0", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", true, "John Doe", true, false, null, "JOHNDOE@EXAMPLE.COM", "JOHNDOE", "AQAAAAIAAYagAAAAEAeUKxQLj/uDsgGpsTWuYo/QeQqf7yL62DUeAj8pNLrda2f4g6/+wpYaNpA8Gu3bcw==", "0355881013", false, "8561ec74-1180-45a0-aa8b-5e50518caebc", false, "JohnDoe", true },
                    { new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"), 0, null, "fa2d75be-5c00-429d-9bb8-0462aacccd98", null, "contact@bambotravel.com", true, "Bamboo Travel", null, false, null, "CONTACT@BAMBOOTRAVEL.COM", "BAMBOOTRAVELACCOUNT", "AQAAAAIAAYagAAAAEObfuRQ/iUK3bZf0fmIKQK/pQlfZsaMrYtROMuJ56dFFjppju6aNyYgTeIYnKVPjDQ==", null, false, "2008af1d-9a9a-4839-8d20-2b231289618b", false, "BambooTravelAccount", true },
                    { new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"), 0, null, "87fb353c-ef6e-4cd5-a15d-7d10a884f597", null, "info@phuongnamtravel.com", true, "Phương Nam Travel", null, false, null, "INFO@PHUONGNAMTRAVEL.COM", "PHUONGNAMTRAVELACCOUNT", "AQAAAAIAAYagAAAAEIufNx4H84h3ucpsWVdsWJ4xgBsZTIwdW88TdtuSvEtI0TKH66XoD4dEXuEHjBt2KQ==", null, false, "33cf1946-fc62-4e43-a7ff-3cbcb64a98dd", false, "PhuongNamTravelAccount", true },
                    { new Guid("44444444-4444-4444-4444-444444444444"), 0, "https://example.com/avatar2.jpg", "1ab226a9-d2f2-4096-bb7a-13996e153ca3", new DateTime(1988, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "emmawatson@example.com4", true, "Emma Watson", false, false, null, "EMMAWATSON@EXAMPLE.COM", "EMMAWATSON", "AQAAAAIAAYagAAAAEJOFOVqe6NJC7rJQ0EPDm++u9f9MRACyeapOsAgFyDWb7d9DZMINzIoveCER5FkCTw==", "0355881014", false, "fa29af13-e8aa-47fe-9689-e939dc23dda8", false, "EmmaWatson", true },
                    { new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"), 0, null, "cd75114b-83ec-4fb4-999d-0967d7e570eb", null, "support@nhatrangholiday.com", true, "Nha Trang Holiday", null, false, null, "SUPPORT@NHATRANGHOLIDAY.COM", "NHATRANGHOLIDAYACCOUNT", "AQAAAAIAAYagAAAAEK1JLw/Lamx42bbzhnvfzooMtQ+ta7i+QRpuX0s2MbVQpVxFP+oEtRjlYjabU8TGUw==", null, false, "aa27355d-316e-4165-9332-4853ec8edf78", false, "NhaTrangHolidayAccount", true },
                    { new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"), 0, null, "7a87f8db-3340-4de8-b1e0-70724cc9bd47", null, "thuthuhe2501@gmail.com", true, "TourGuides", null, false, null, "THUTHUHE2501@GMAIL.COM", "TOURGUIDES", "AQAAAAIAAYagAAAAEFCMuhHAnzE/swYNRrrhoazRe/gTKjJbB4rnZzfO5GNl1w20DwC1xZUdwAx6gwyZUw==", "0355881012", false, "b2b6e8f7-58e8-40e9-84be-4e08eaf879b7", false, "TourGuides", true },
                    { new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"), 0, null, "99504f9c-70a0-4773-b44d-3c4ed7bbb278", null, "support@hanoitourist.com", true, "Hanoitourist", null, false, null, "SUPPORT@HANOITOURIST.COM", "HANOITOURISTACCOUNT", "AQAAAAIAAYagAAAAECsgmXwAlOgpsg0u9ZJ0jjHlyhLjoOMn4QeyGIGTzlPZiYnHNHzx+EN7PaKlnmF+sA==", null, false, "24343e4f-9052-4907-bda3-b791a2308030", false, "HanoitouristAccount", true },
                    { new Guid("66666666-6666-6666-6666-666666666666"), 0, "https://example.com/avatar3.jpg", "87a2556d-b050-409a-a234-de30ab268f8a", new DateTime(1985, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "michaelbrown@example.com", true, "Michael Brown", true, false, null, "MICHAELBROWN@EXAMPLE.COM", "MICHAELBROWN", "AQAAAAIAAYagAAAAEBpaIITpmIPReX4Mi2WTgt2zJYfKkOpAMeatfRvjH9AI7eXHkR0b1S0FWkK17HrqAQ==", "0355881015", false, "e3ac8298-bca7-4436-a86b-c6f9c0ff263c", false, "MichaelBrown", true },
                    { new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"), 0, null, "93d04e04-4de0-407d-b781-ccd281e4b8e7", null, "contact@phanthiettours.com", true, "Phan Thiết Tours", null, false, null, "CONTACT@PHANTHIETTOURS.COM", "PHANTHIETTOURSACCOUNT", "AQAAAAIAAYagAAAAEDoUvClcTotXmrJORG9qBcqFDERkdywgw33T37SbHhNBzpts/V0s2qbX8HvYaoo9qw==", null, false, "5180d35a-593d-4661-a71e-d723fd0d836c", false, "PhanThietToursAccount", true },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), 0, "https://example.com/avatar8.jpg", "8deaa765-919c-47e6-8654-667b9906858c", new DateTime(1989, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel.martinez@example.com", true, "Daniel Martinez", true, false, null, "DANIEL.MARTINEZ@EXAMPLE.COM", "DANIELMARTINEZ", "AQAAAAIAAYagAAAAEN8w4QxoeAxWCafesOa87tT/4ct9pvS+vw8Z/0LOWPPWzSJt8Nprt7lJpAEc8zG8/w==", "0355881020", false, "14b5db9c-a272-40ac-b308-d6f5d199b795", false, "DanielMartinez", true },
                    { new Guid("88888888-8888-8888-8888-888888888888"), 0, "https://example.com/avatar4.jpg", "fbc27c13-2d85-4104-97fb-5c5768eddc1a", new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophialee@example.com", true, "Sophia Lee", false, false, null, "SOPHIALEE@EXAMPLE.COM", "SOPHIALEE", "AQAAAAIAAYagAAAAEPLLssMrPtDahBwROxVDn7svrgrDWb3b0fk0svBiGz237nu9K7Q2EsPE4bU2q01Ang==", "0355881016", false, "6b4c8d6e-dddd-456b-bf35-2e5c170c535a", false, "SophiaLee", true },
                    { new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"), 0, null, "e51689a1-4ac2-4cbc-8e07-751637371521", null, "info@redtour.com.vn", true, "Redtour", null, false, null, "INFO@REDTOUR.COM.VN", "REDTOURACCOUNT", "AQAAAAIAAYagAAAAEDHILnQld+mWIu/7Khl5ciy1bkjV5MXS4K8sHOW2GPHlyKuTfXBL3WBdFfT4tYI/0g==", null, false, "e4ef9ab1-e071-47e4-bada-d0e7e3f442e6", false, "RedtourAccount", true },
                    { new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"), 0, "https://example.com/avatar9.jpg", "19a341f4-2b8c-402c-96fb-5d5e1876f3e3", new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "emilyclark@example.com", true, "Emily Clark", false, false, null, "EMILYCLARK@EXAMPLE.COM", "EMILYCLARK", "AQAAAAIAAYagAAAAEEwnzWlxR4FLp+ZNvQghYKOPSJLeXRly1fk8UQ+mXuJooZhGoG8oSERfO+Iz50WIqQ==", "0355881021", false, "7ce195fe-0679-49bb-aafd-64cd6897ad0f", false, "EmilyClark", true },
                    { new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"), 0, null, "7b413a10-53a8-47e7-9ce6-5bd33edb236a", null, "contact@quynhonexplorer.com", true, "Quy Nhơn Explorer", null, false, null, "CONTACT@QUYNHONEXPLORER.COM", "QUYNHONEXPLORERACCOUNT", "AQAAAAIAAYagAAAAEGnC9I6uP0cHSFlyRaJVeY8cTPUGf048OM5uxi03EM6vU4uuOenbyOvzmBI1yvFrQA==", null, false, "06b04e18-ed97-44ac-803c-1465d5245908", false, "QuyNhonExplorerAccount", true },
                    { new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"), 0, null, "a81bd83e-09c8-4d7b-a817-c07b79fb1f02", null, "contact@datviettour.com", true, "Đất Việt Tour", null, false, null, "CONTACT@DATVIETTOUR.COM", "DATVIETTOURACCOUNT", "AQAAAAIAAYagAAAAEOFK5pLhfbiITJF1lbKZhMy6JY/t9k59jdr8iQZnO5xoZlsCZPdzkblwrgJZl6xtAQ==", null, false, "121c309b-8872-4562-992e-dcebd34fbb98", false, "DatVietTourAccount", true },
                    { new Guid("a631bb94-66d8-44db-932b-532892d87754"), 0, null, "ba24ef48-7faa-45b1-95f5-8633c4db36dd", null, "thutt170727@gmail.com", true, "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", null, false, null, "THUTT170727@GMAIL.COM", "ATFO", "AQAAAAIAAYagAAAAEJG6mKQ28Se+IyKS0sdOwBf2Q81G6G/xQ/iw7WNhLxn0PHvkCh9P5nR0ucVimulGCQ==", null, false, "a21c2ed4-922d-46cc-9e73-0e0c74aa54bc", false, "ATFO", true },
                    { new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"), 0, null, "57c0d5fd-f14c-4976-b706-40ac869e162a", null, "contact@vietsuntravel.com", true, "VietSun Travel", null, false, null, "CONTACT@VIETSUNTRAVEL.COM", "VIETSUNTRAVELACCOUNT", "AQAAAAIAAYagAAAAEEcfJnscOC4OtsxoDxemk61So5FktDtVSZP6VWzdyKR5omDqQCef4+3TcCAs55ax3Q==", null, false, "792666b9-b448-45c2-a6cf-208f2d66f317", false, "VietSunTravelAccount", true },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 0, "https://example.com/avatar5.jpg", "19709355-ed35-401b-86b7-73dc0195f5d2", new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "davidjohnson@example.com", true, "David Johnson", true, false, null, "DAVIDJOHNSON@EXAMPLE.COM", "DAVIDJOHNSON", "AQAAAAIAAYagAAAAECJiKuz80jvQ8+nxc3YELvfozEc85yhlqgCe1GEc9ktnKJYXlSW3kW28aDUtsQmnEg==", "0355881017", false, "177d7c5c-d6f2-4c39-90bc-bd32579ebf2e", false, "DavidJohnson", true },
                    { new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"), 0, null, "c4d123c0-2542-42ab-8a34-0787904a2690", null, "contact@havatravel.com", true, "Havatravel", null, false, null, "CONTACT@HAVATRAVEL.COM", "HAVATRAVELACCOUNT", "AQAAAAIAAYagAAAAEAb7r2Z+FQW/8Xw5/Zyh9CgpJ6KwO9NfL8vxa2cwka5xCC6UEfxhbwX3Yn6A9yDZzw==", null, false, "8608195c-41f0-4bb2-8e73-463d2d02e990", false, "HavatravelAccount", true },
                    { new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), 0, null, "65cbf24c-1489-4310-8019-38dd4cbd9ea9", null, "thutt170727@gmail.com", true, "Administrator", null, false, null, "THUTT170727@GMAIL.COM", "ADMINISTRATOR", "AQAAAAIAAYagAAAAEJhkEtgXa+2GCwevdmUEZZaOn0qe5BeFp5Y4eMnANDOnCo+kIcR8CsCYcHoQ0eApAw==", "0355881010", false, "8aceb2c3-f297-4de4-aecd-bea5abaeb4c7", false, "Administrator", true },
                    { new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"), 0, null, "d8798a01-ebcd-4c61-89ff-39b60b0e0a3b", null, "info@vungtautravel.com", true, "Vũng Tàu Travel", null, false, null, "INFO@VUNGTAUTRAVEL.COM", "VUNGTAUTRAVELACCOUNT", "AQAAAAIAAYagAAAAEOBaNTSw3akUA3OHLXaxHoOif3zRAXEMtcrVCD/vSGYhC4ftKwWebgfxwBYbu36WGw==", null, false, "f9124221-78a0-446d-a9db-77ba146b0c2f", false, "VungTauTravelAccount", true },
                    { new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"), 0, null, "c1d2acf6-5894-4958-9592-b9514af5fec8", null, "info@dalattour.com", true, "Đà Lạt Tour", null, false, null, "INFO@DALATOUR.COM", "DALATTOURACCOUNT", "AQAAAAIAAYagAAAAEII9tOexxYBDxejOaCtGuiAzq+KCJB3sJI2JRgGf6+R+BUZBGOC/HRlytEk4JlxELg==", null, false, "18c71540-f15e-47dc-a393-aca255b5fcab", false, "DalatTourAccount", true },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), 0, "https://example.com/avatar6.jpg", "07dc4c29-bace-4176-9c19-ab386c1b753f", new DateTime(1987, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "liamnguyen@example.com", true, "Liam Nguyen", true, false, null, "LIAMNGUYEN@EXAMPLE.COM", "LIAMNGUYEN", "AQAAAAIAAYagAAAAEAQqM9qjkmlHMtsQVnt1rMO27Oo1QdmETfjSlvmU2YwMQ9y7fAaI46HcLIXvKG/MVg==", "0355881018", false, "09a9977f-7cf3-4fee-a67e-c92161b6720c", false, "LiamNguyen", true },
                    { new Guid("d0e45bee-a768-4555-bfeb-788728a53751"), 0, null, "dbd6f21d-8197-4013-a340-93a935fd6069", null, "info@danangtravel.com", true, "Danang Travel", null, false, null, "INFO@DANANGTRAVEL.COM", "DANANGTRAVELACCOUNT", "AQAAAAIAAYagAAAAEO2GJHmLV0Ct3O0SKWRCC5GlPjFi4pvlw+l9TzB3xRS6KeNpY6bsb+JWyF/XTf7d5w==", null, false, "08ffcf6b-eba8-4f04-be6c-2f1c2f7a5c84", false, "DanangTravelAccount", true },
                    { new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"), 0, null, "15d0d692-e17b-4d4a-9e89-979fc3e72ba0", null, "contact@saigontourist.net", true, "Saigontourist", null, false, null, "CONTACT@SAIGONTOURIST.NET", "SAIGONTOURISTACCOUNT", "AQAAAAIAAYagAAAAEEp7eUOAKXG0NOfbilq7vMRM7ueWZRJtR1q/jWotw8mmYnESgXE0NpwDgNpTnxx0Tw==", null, false, "8790e666-2d07-47d3-81e6-b93e74f03b93", false, "SaigontouristAccount", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), 0, null, "781b8379-6275-4503-902c-5c13573c8bcb", null, "ThangNVSE151059@fpt.edu.vn", true, "Tourists", null, false, null, "THANGNVSE151059@FPT.EDU.VN", "TOURIST", "AQAAAAIAAYagAAAAEEsETGK+vyy0NxzpPAEAG5EEW6xVuheW+Nd+kB/IA33MP+M8EL/HZ38rtwceyY1HMg==", "0355881010", false, "1da2bbab-a032-41bd-893c-2d482b80fd77", false, "Tourists", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f1"), 0, null, "e71942a3-9b56-49dd-b1e9-18dd166da3f3", null, "thuylinh@fpt.edu.vn", true, "Thùy Linh", null, false, null, "THUYLINH@FPT.EDU.VN", "THUYLINH", "AQAAAAIAAYagAAAAEApZyQd85tFQc4MNjFYTrW3K7QzdAW6vSDIt+g+aGIrx4ejbHTQ5EmY51Hi7mLU5nQ==", null, false, "0bf2c9f5-3305-4f02-843a-2df5ea72db8b", false, "thuylinh", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f2"), 0, null, "76350716-25cb-42cc-8925-7ca1c31ed8d6", null, "hoaithu@fpt.edu.vn", true, "Hoài Thu", null, false, null, "HOAITHU@FPT.EDU.VN", "HOAITHU", "AQAAAAIAAYagAAAAEE2oisYvy02QLM8AFnwlsuFnLpXBIoTExBQuhMXtm/xxWXGfROrtczFKJFBQ97TU1A==", "0355881011", false, "0f8df4ac-8fe7-45cf-8de2-466a26266f18", false, "hoaithu", true },
                    { new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"), 0, null, "bc7ea5e0-3b88-43f9-8ce5-f8c76a669ea7", null, "support@dulichtoday.com", true, "Dulich Today", null, false, null, "SUPPORT@DULICHTODAY.COM", "DULICHTODAYACCOUNT", "AQAAAAIAAYagAAAAEOp7XXB7nRNhcr2vVA/0zc2ybHE8Zdqv+Ed0TCobmGc7mwQt9Rh6WcOMjrROOT0RdA==", null, false, "aa6219c0-b00b-48a7-830b-f129f4ce6d75", false, "DulichTodayAccount", true },
                    { new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"), 0, null, "f5fa71e0-8abe-4b36-949d-b4fc5810fb0d", null, "info@fiditour.com", true, "Fiditour", null, false, null, "INFO@FIDITOUR.COM", "FIDITOURACCOUNT", "AQAAAAIAAYagAAAAEDzM0W7JsNjM6D7x+/AwXgW0FH/cba2r8EHjN6aSu7cFjOnO5d8I1WjgAYTUyKQYJw==", null, false, "cf415f21-6bf7-43d9-96b8-d2d700208e25", false, "FiditourAccount", true },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), 0, "https://example.com/avatar7.jpg", "92753a08-71b2-4a06-9f0b-47793bb76b44", new DateTime(1993, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "oliviakim@example.com", true, "Olivia Kim", false, false, null, "OLIVIAKIM@EXAMPLE.COM", "OLIVIAKIM", "AQAAAAIAAYagAAAAEC4Aouoj/oogeJjGrSzOH1O/ujpcYzfjeQsQYFZkY24MW1j113RrSLVQU+wUepf8Pg==", "0355881019", false, "102a35c4-0f7c-40d8-bebf-5897fc14df16", false, "OliviaKim", true }
                });

            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "BankAccountId", "AccountName", "AccountNumber", "BankName", "BranchName", "CreatedDate", "IsPrimary", "OwnerId", "OwnerType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("00258f7e-d660-457b-90e7-8646ce2bebd3"), "Redtour", "0011009643348", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5506), true, new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), 0, null },
                    { new Guid("0644fb6e-d270-420e-91ee-34a5bc3891fe"), "Trang Trại Nông Sản Sạch Càng Long", "0011003686220", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5381), true, new Guid("10000000-0000-0000-0000-000000000013"), 1, null },
                    { new Guid("23ff98c2-cfa4-4ee3-b82e-96e7fb79962c"), "Trà My Sâm Ngọc Linh Tour", "0011001868180", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5356), true, new Guid("10000000-0000-0000-0000-000000000007"), 1, null },
                    { new Guid("4494ff69-3672-45dd-be20-5a298444ad86"), "Công ty Cổ phần Vietravel", "0011003080806", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5441), true, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0, null },
                    { new Guid("501d8062-d925-445f-8faa-7abaefc44970"), "Bamboo Travel", "0011009830778", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5460), true, new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), 0, null },
                    { new Guid("54536744-5b44-442e-8635-7b1f9bf3f23f"), "Havatravel", "0011002449108", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5513), true, new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), 0, null },
                    { new Guid("5951c2aa-5b3f-452b-8031-cfb179a9cb6e"), "Phan Thiết Tours", "0011006840727", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5569), true, new Guid("22275542-0625-47be-a503-2f13b7576e9b"), 0, null },
                    { new Guid("5f971369-b1ba-4a16-8cf6-65b7d7564c72"), "Ba Bể Lake Ecofarm Tour", "0011008139093", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5371), true, new Guid("10000000-0000-0000-0000-000000000010"), 1, null },
                    { new Guid("7acfe023-05a7-4a3b-b867-95c1e2c042b6"), "Fiditour", "0011001223427", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5451), true, new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), 0, null },
                    { new Guid("859dd155-67f6-4d78-b4db-cdb63842e89c"), "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", "0011006747823", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5198), true, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null },
                    { new Guid("8ce4cca8-1567-4fc7-906d-fa265b6bbe3e"), "Hanoitourist", "0011002694766", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5447), true, new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), 0, null },
                    { new Guid("8f89477f-a6bf-400f-aa6b-6bfbce445b06"), "Farm Du Lịch Grape Valley", "0011006824187", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5327), true, new Guid("10000000-0000-0000-0000-000000000003"), 1, null },
                    { new Guid("a3d5b009-990e-437c-a0bb-79e492aa03ce"), "Danang Travel", "0011001385427", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5454), true, new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), 0, null },
                    { new Guid("a72a78e3-3cce-4ae5-a5ae-e6fc28e93c6c"), "Sa Pa Eco Farm Tour", "0011006266936", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5321), true, new Guid("10000000-0000-0000-0000-000000000002"), 1, null },
                    { new Guid("a75148d3-818e-4b50-8c2a-6e189c54e3e0"), "Farmstay Nho & Thanh Long Bắc Bình", "0011001036906", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5368), true, new Guid("10000000-0000-0000-0000-000000000009"), 1, null },
                    { new Guid("ac689aa4-281d-454b-a803-096b2e4cbb50"), "Trang Trại Châu Đốc", "0011009215516", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5388), true, new Guid("10000000-0000-0000-0000-000000000015"), 1, null },
                    { new Guid("b201b8dc-86e1-4687-a51b-014acc8f5a4e"), "Phương Nam Travel", "0011009064032", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5499), true, new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), 0, null },
                    { new Guid("b7acc076-d677-43ba-beeb-0267b3d53151"), "Nha Trang Holiday", "0011002170497", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5564), true, new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), 0, null },
                    { new Guid("bb6ae28b-410e-4a86-a1de-ae1ca1ab9ccc"), "Trang Trại Nông Sản Sạch Tân Châu", "0011007663332", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5376), true, new Guid("10000000-0000-0000-0000-000000000011"), 1, null },
                    { new Guid("c4598a0d-0f1f-4a64-a244-31d4357c3206"), "Dulichtoday", "0011003342798", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5509), true, new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), 0, null },
                    { new Guid("c760926b-02b0-447b-9f5f-3d3fe57f2eb7"), "Hà Giang Farmstay & Trek", "0011006137356", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5354), true, new Guid("10000000-0000-0000-0000-000000000006"), 1, null },
                    { new Guid("cabcb111-998d-4953-bccf-706e0efdaf4b"), "Đất Việt Tour", "0011005906347", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5504), true, new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), 0, null },
                    { new Guid("d6864cee-2385-4457-9463-6092278ae7aa"), "Nông Trại Chè Trải Nghiệm Đại Từ", "0011004139644", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5330), true, new Guid("10000000-0000-0000-0000-000000000004"), 1, null },
                    { new Guid("d6bfd2e6-bffe-41c5-b841-e0a212ee7390"), "VietSun Travel", "0011003583154", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5456), true, new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), 0, null },
                    { new Guid("db913665-8362-41e1-afa6-3a8d55c48548"), "Buôn Đôn Coffee Farm Tour", "0011004192418", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5333), true, new Guid("10000000-0000-0000-0000-000000000005"), 1, null },
                    { new Guid("e3cf8ad8-b16c-4757-b908-92d7767f6035"), "Đà Lạt Organic Farm Tour", "0011001450742", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5361), true, new Guid("10000000-0000-0000-0000-000000000008"), 1, null },
                    { new Guid("edf14dfe-f139-4f4c-8ba5-2c4032251d62"), "Du Lịch Sinh Thái Thác Bản Giốc", "0011008481893", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5316), true, new Guid("10000000-0000-0000-0000-000000000001"), 1, null },
                    { new Guid("f3c5c8e7-2db2-4f40-b2c3-df31bd19a9dc"), "Trải nghiệm Nông trại Biển & Rau Tuy An", "0011001749797", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5378), true, new Guid("10000000-0000-0000-0000-000000000012"), 1, null },
                    { new Guid("f5ad9608-58ff-43bf-81c0-a6ac90a11720"), "Saigontourist", "0011008040093", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5445), true, new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), 0, null },
                    { new Guid("f757d219-dfa5-4349-964f-ad6e9ad9e901"), "Mỹ Xuyên Farmstay", "0011009724934", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5385), true, new Guid("10000000-0000-0000-0000-000000000014"), 1, null },
                    { new Guid("fdfd7335-3c85-471a-8af0-e145d72a2019"), "Vũng Tàu Travel", "0011008856979", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5528), true, new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), 0, null }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0dae2462-9ebd-452e-a89c-06d4b6025e68"), null, "ContentModerators", "CONTENTMODERATORS" },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), null, "AgriculturalTourismFacilityOwners", "AGRICULTURALTOURISMFACILITYOWNERS" },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), null, "TourismCompanies", "TOURISMCOMPANIES" },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), null, "TourGuides", "TOURGUIDES" },
                    { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), null, "Admin", "ADMIN" },
                    { new Guid("c78a64eb-5190-44c1-9886-ca707854b807"), null, "Tourists", "TOURISTS" }
                });

            migrationBuilder.InsertData(
                table: "SystemConfigurations",
                columns: new[] { "ConfigId", "ConfigKey", "ConfigType", "ConfigValue", "CreateDate", "UpdateTime" },
                values: new object[,]
                {
                    { 1, "SmtpServer", 0, "smtp.gmail.com", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3432), null },
                    { 2, "Port", 0, "587", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3437), null },
                    { 3, "Email", 0, "thangnvse151059@fpt.edu.vn", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3438), null },
                    { 4, "AppPassword", 0, "sllgcjfbkpgcwnmp", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3439), null },
                    { 5, "TmnCode", 1, "KC8MB258", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3441), null },
                    { 6, "HashSecret", 1, "02Y8EHIO9SPTGHUHOAMPUUISF3P4H2S2", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3442), null },
                    { 7, "Url", 1, "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3443), null },
                    { 8, "Command", 1, "pay", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3444), null },
                    { 9, "CurrCode", 1, "VND", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3445), null },
                    { 10, "Version", 1, "2.1.0", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3446), null },
                    { 11, "Locale", 1, "vn", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3447), null },
                    { 12, "PaymentBackReturnUrl", 1, "https://localhost:5001/api/tourist/order/return_order", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3449), null },
                    { 13, "BookingUrl", 1, "https://localhost:5001/api/tourist/book-tour/return_book", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3450), null },
                    { 14, "OrderUrl", 1, "https://localhost:5001/api/tourist/order/return_order", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3451), null }
                });

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("001dc673-46f2-4346-bca0-1ed89e1cf3be"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5001), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("1679cc24-d96e-4ed7-8403-ce504bd058d6"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5007), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("38b80c69-7a19-49dd-98e5-e30f6b91312c"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5006), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("3f8c398d-f93b-40f3-bf37-73778bf93d25"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5024), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("41fec6f5-9860-49a6-976a-b501d9db12f5"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5004), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("4bb2a459-ed3a-4fbe-96fc-44c2dc6f3065"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5022), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("56b4a508-4a0f-4892-88ba-66521b804209"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5012), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("bd23a747-2519-48ab-8777-8632e092e2cc"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5009), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("c7855620-74d4-436f-96af-4f7142879bcc"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5011), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("cf7e4fc0-de5f-45de-9068-565057fd2371"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5014), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("d3a0ca51-46a0-454e-ae93-268b2a4cf23d"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5017), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("de2926d6-c9e1-43e8-bdf0-f6f6b8ba017a"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(5020), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null }
                });

            migrationBuilder.InsertData(
                table: "UserSupport",
                columns: new[] { "SupportId", "Email", "Fullname", "IsResolved", "IssueType", "RequestDate", "ResponeBy", "ResponseDate", "ResponseMessage", "SupportMessage", "TouristFacilityId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4949), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4947), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("d549690a-59da-4c91-8179-7ba2102800e2"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4942), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("1d0cedaa-7d05-4856-b0d3-67c44075919b"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fbemacatf_2929-(1).jpg?alt=media&token=cccce681-3652-4a07-a2ff-b972392c84da", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("466eabb8-2bc4-4512-adf5-b8de4f41a0c8"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F185215_1-dongnai02.jpg?alt=media&token=6641c733-758a-4e47-a816-f18757f3d646", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("5e7ebc9c-73c0-4303-af97-b43247f6820e"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Ftet-2.jpg?alt=media&token=6d28efb3-2ed9-4ca9-907e-de6b6c190a5f", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("6892ae09-7700-4257-8e44-a45fea7ad918"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fz4892392984516_d64f19ae34659675050a19405d2f2f06_20231118151316.jpg?alt=media&token=88ce1721-d11a-4f70-975f-8159879d38af", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("87e49f12-47a4-4c1a-a6b2-8f54fd85f0c0"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F0-2346.webp?alt=media&token=60da574f-ccd0-4e3d-9bf6-74a1c6a64728", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("9182528d-c3c4-4c50-9047-733fe11dc470"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F114885_LTT_4830.jpg?alt=media&token=50e303f4-7cc3-42c1-a79e-f5041a1d4389", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("ac63acf0-a5db-4b70-8476-90f80aba57f3"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fdsc4926-1737442964915949022440.webp?alt=media&token=f4a50238-d2f3-4032-ba89-65c47093ac0a", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("c6f40b49-b531-408f-a4a8-0375b9a769c7"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2273623_quang_canh_khong_gian_chinh_to_chuc_le_hoi_14003627.jpg?alt=media&token=4023df7a-8efc-4de0-b6dd-b5cdfa0af4d0", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("d2f6b60d-55cf-4e98-b6cb-e0c35162ee36"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2101.hoabinh.jpg?alt=media&token=9da1280b-fca0-48a3-aacb-a8598212f33c", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("d5662b9c-e45f-4f5e-b471-ae47d14aefa3"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F1110.binh-lieu.jpg?alt=media&token=98060066-e58f-4a1d-929f-76c2f4017475", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("df3fa7ae-fce7-4fb3-8871-9b655e000678"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2007lamdong1-1689837807306-16898378088711727831861.jpg?alt=media&token=17bcc062-4fb7-4996-8108-5b6f6ff9809a", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("dff91e40-f19b-477d-b25d-71b746613c1a"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2.jpeg?alt=media&token=8dc70894-e01b-4caf-83dd-68dad34318c2", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null }
                });

            migrationBuilder.InsertData(
                table: "ShipAddress",
                columns: new[] { "ShipAddressId", "AccountId", "DefaultAddress", "ToAddress", "ToDistrictId", "ToDistrictName", "ToName", "ToPhone", "ToProvinceId", "ToProvinceName", "ToWardCode", "ToWardName" },
                values: new object[,]
                {
                    { new Guid("a3e2dd63-c5b3-4e6e-94d5-6cefea2c6b8f"), new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), true, "789 Điện Biên Phủ, Phường Đa Kao", 1444, "Quận 3", "Lê Hoàng Cường", "0923456789", 202, "Hồ Chí Minh", "20314", "Phường 14" },
                    { new Guid("b2e1cc65-b21b-4e6e-94d5-6cefea2c6b8f"), new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), false, "45 Nguyễn Huệ, Phường Bến Thành", 1443, "Quận 2", "Trần Thị Bình", "0912345678", 202, "Hồ Chí Minh", "20211", "Phường Thủ Thiêm" },
                    { new Guid("d4e1dd61-a5b3-4e6e-94d5-6cefea2c6b8f"), new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), false, "123 Lê Lợi, Phường Bến Nghé", 1442, "Quận 1", "Nguyễn Văn An", "0901234567", 202, "Hồ Chí Minh", "20109", "Phường Phạm Ngũ Lão" }
                });

            migrationBuilder.InsertData(
                table: "TourCompany",
                columns: new[] { "TourCompanyId", "AddressCompany", "CompanyDescription", "CompanynName", "CreateDate", "EmailCompany", "LogoURL", "UpdateTime", "UserId", "Website" },
                values: new object[,]
                {
                    { new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), "120 Phan Chu Trinh, TP.Huế", "Công ty du lịch chuyên nghiệp tại Huế.", "Havatravel", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3548), "contact@havatravel.com", "https://img.freepik.com/premium-vector/tours-travel-logo-with-airplane-passing-blue-world_101890-71.jpg?w=2000", null, new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"), "https://havatravel.com/" },
                    { new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), "45 Điện Biên Phủ, Quận 3, TP.HCM", "Chuyên tour du lịch nội địa và quốc tế.", "VietSun Travel", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3526), "contact@vietsuntravel.com", "https://th.bing.com/th/id/OIP.nwXDxpVx9hsOdW9efOtlRAHaDq?w=334&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"), "https://vietsuntravel.com/" },
                    { new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), "15 Phạm Ngũ Lão, Quận 1, TP.HCM", "Dịch vụ du lịch cao cấp.", "Bamboo Travel", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3529), "contact@bambotravel.com", "https://th.bing.com/th/id/OIP.8nxVZ-RcEPQMdis_Yg4TWAHaHa?w=180&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"), "https://bambotravel.com/" },
                    { new Guid("22275542-0625-47be-a503-2f13b7576e9b"), "23 Lê Lợi, TP. Phan Thiết", "Chuyên tour khám phá biển và cát trắng.", "Phan Thiết Tours", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3558), "contact@phanthiettours.com", "https://th.bing.com/th/id/OIP.KBj43NwwtJw5Ht71M6ts8gHaF7?rs=1&pid=ImgDetMain", null, new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"), "https://phanthiettours.com/" },
                    { new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), "50 Nguyễn Trãi, TP. Vũng Tàu", "Tour du lịch biển chất lượng cao.", "Vũng Tàu Travel", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3551), "info@vungtautravel.com", "https://mir-s3-cdn-cf.behance.net/project_modules/1400/2cf01f84467867.5d5da886617be.jpg", null, new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"), "https://vungtautravel.com/" },
                    { new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), "90 Nguyễn Văn Linh, Đà Nẵng", "Thông tin và tổ chức tour du lịch.", "Dulichtoday", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3545), "support@dulichtoday.com", "https://png.pngtree.com/png-clipart/20200722/original/pngtree-travel-and-tour-logo-png-image_5051851.jpg", null, new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"), "https://dulichtoday.com/" },
                    { new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), "75 Hùng Vương, TP. Nha Trang", "Dịch vụ đặt tour du lịch biển chuyên nghiệp.", "Nha Trang Holiday", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3554), "support@nhatrangholiday.com", "https://th.bing.com/th/id/OIP.inoQUXN-Y4DfWTpe5-ec-gHaFJ?w=241&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"), "https://nhatrangholiday.com/" },
                    { new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), "15 Lê Lợi, Quận 1, TP.HCM", "Tour trọn gói, uy tín.", "Fiditour", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3519), "info@fiditour.com", "https://th.bing.com/th/id/OIP.kzYdv7-VmS2zRF7qZaOyvwAAAA?w=212&h=212&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"), "https://fiditour.com/" },
                    { new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), "99 Hoàng Diệu, Ba Đình, Hà Nội", "Du lịch chất lượng, giá rẻ.", "Phương Nam Travel", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3533), "info@phuongnamtravel.com", "https://th.bing.com/th/id/OIP.p6Shq1r_4g--m-4Q8nIUfgHaHa?rs=1&pid=ImgDetMain", null, new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"), "https://phuongnamtravel.com/" },
                    { new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), "10 Lê Thánh Tôn, Quận 1, TP.HCM", "Chuyên tổ chức tour du lịch trong và ngoài nước.", "Đất Việt Tour", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3538), "contact@datviettour.com", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSMJbyGoIQYOyNFDh34TrlaOOozlKmiTefzoQ&s", null, new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"), "https://datviettour.com/" },
                    { new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), "20 Trần Hưng Đạo, Hà Nội", "Dịch vụ du lịch chất lượng cao.", "Redtour", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3541), "info@redtour.com.vn", "https://th.bing.com/th/id/OIP.zD605q-X7zzIpJAgyfVvwQHaHa?pid=ImgDet&w=184&h=184&c=7&dpr=1.3", null, new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"), "https://redtour.com.vn/" },
                    { new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), "90 Nguyễn Thị Minh Khai, Đà Nẵng", "Chuyên tour biển đảo Đà Nẵng.", "Danang Travel", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3523), "info@danangtravel.com", "https://th.bing.com/th/id/OIP.vj2L0nLe0ocGi4pxbLwnowHaHa?w=200&h=199&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("d0e45bee-a768-4555-bfeb-788728a53751"), "https://danangtravel.com/" },
                    { new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), "25 Nguyễn Huệ, Quận 1, TP.HCM", "Lữ hành hàng đầu Việt Nam.", "Saigontourist", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3513), "contact@saigontourist.net", "https://icolor.vn/wp-content/uploads/2021/01/Tham-kh%E1%BA%A3o-Logo-c%C3%B4ng-ty-du-l%E1%BB%8Bch-Saigontourist-3.jpg", null, new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"), "https://saigontourist.net/" },
                    { new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"), "66 Trần Phú, TP. Quy Nhơn", "Tour du lịch biển và văn hóa Quy Nhơn.", "Quy Nhơn Explorer", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3576), "contact@quynhonexplorer.com", "https://th.bing.com/th/id/OIP.lVVxjoYVel7RgNeu1hH2RgHaFr?rs=1&pid=ImgDetMain", null, new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"), "https://quynhonexplorer.com/" },
                    { new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"), "14 Nguyễn Huệ, TP. Đà Lạt", "Tour du lịch khám phá Đà Lạt.", "Đà Lạt Tour", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3564), "info@dalattour.com", "https://images-platform.99static.com/OowUwWHMa4KA7v_azo1Bq_7ByCs=/6x0:1001x995/500x500/top/smart/99designs-contests-attachments/86/86578/attachment_86578583", null, new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"), "https://dalattour.com/" },
                    { new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), "101 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội", "Tour du lịch nội địa và quốc tế.", "Hanoitourist", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(3516), "support@hanoitourist.com", "https://th.bing.com/th/id/OIP.DQh7E8nzGNx-fipB0stcygHaGf?w=190&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"), "https://hanoitourist.com/" },
                    { new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), "03 Hai Bà Trưng, Hoàn Kiếm, Hà Nội.", "", "Công ty Cổ phần Vietravel", new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "vtv.cholon@vietravel.com", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWyblRzW2ET2uC9wdJBm6_PUq1zCiSi6SGJw&s", null, new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), "https://travel.com.vn/" }
                });

            migrationBuilder.InsertData(
                table: "TouristFacility",
                columns: new[] { "TouristFacilityId", "Address", "ContactInfor", "CreateDate", "Description", "EmailTouristFacility", "LogoURL", "TouristFacilityName", "UpdateTime", "UserId", "Website", "district_id", "district_name", "phone", "province_name", "ward_code", "ward_name" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Xã Đàm Thủy, Huyện Trùng Khánh, Cao Bằng", "0206 388 8888", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3692), "Khu du lịch sinh thái kết hợp nông nghiệp tại vùng biên giới Thác Bản Giốc.", "contact@bangiocfarmtour.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F-8824-1745223484_860x0.jpg?alt=media&token=fb1bda90-6cdd-4217-a7b0-4a4d37a31bbb", "Du Lịch Sinh Thái Thác Bản Giốc", null, new Guid("10000000-0000-0000-0000-000000000001"), "www.bangiocfarmtour.vn", 1976, "Huyện Mộc Châu", "0988888999", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Thôn Cát Cát, Xã San Sả Hồ, Sa Pa", "0214 666 7777", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3714), "Tour trải nghiệm nông nghiệp và văn hóa H'Mông tại bản Cát Cát.", "eco@sapa.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fthac-cat-cat-tho-mong3.jpg?alt=media&token=29507071-2069-4ca3-b3b3-1665e293a282", "Sa Pa Eco Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000002"), "www.sapaecotour.vn", 1976, "Huyện Mộc Châu", "0911777555", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Thôn Thái An, Xã Vĩnh Hải, Huyện Ninh Hải", "0259 333 4567", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3719), "Trải nghiệm hái nho, làm rượu vang và nghỉ dưỡng tại thung lũng nho.", "info@grapevalley.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fvuon-nho-thai-an-2-1-1024x614.webp?alt=media&token=e7af45e4-d132-45e8-aca3-07787d22528b", "Farm Du Lịch Grape Valley", null, new Guid("10000000-0000-0000-0000-000000000003"), "www.grapevalley.vn", 1976, "Huyện Mộc Châu", "0909000011", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Xóm Cầu Tre, Xã La Bằng, Huyện Đại Từ", "0208 123 4567", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3722), "Du lịch nông nghiệp kết hợp trải nghiệm hái chè, sao chè và thưởng thức tại chỗ.", "farm@daitu.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fthai-nguyen-17435107247911118713237.jpg?alt=media&token=c3f1ab76-1e22-4e54-a2b8-f9085b18d47c", "Nông Trại Chè Trải Nghiệm Đại Từ", null, new Guid("10000000-0000-0000-0000-000000000004"), "www.daitu-teafarm.vn", 1976, "Huyện Mộc Châu", "0977000111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Xã Ea M’nang, Huyện Cư M’gar, Đắk Lắk", "0262 888 8899", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3726), "Tour trải nghiệm vườn cà phê, tham quan quy trình rang xay và cưỡi voi Buôn Đôn.", "visit@buondoncoffee.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F20220314-161611-QzoiJN59.webp?alt=media&token=a5eb0314-334f-4769-bde3-b06e2d609274", "Buôn Đôn Coffee Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000005"), "www.buondoncoffee.vn", 1976, "Huyện Mộc Châu", "0918888777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "Xã Sà Phìn, Huyện Đồng Văn", "0219 366 6888", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3729), "Trải nghiệm cuộc sống vùng cao, làm nông, làm bánh truyền thống và trekking đèo đá.", "trek@hagiang.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ftam-gia-c-ma-ch-ha-giang-vnexpress-3-1571666979.webp?alt=media&token=70e2dc65-1f50-4a28-a48f-62b42ddcc235", "Hà Giang Farmstay & Trek", null, new Guid("10000000-0000-0000-0000-000000000006"), "www.hagiangfarmstay.vn", 1976, "Huyện Mộc Châu", "0988999111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Xã Trà Linh, Huyện Nam Trà My", "0235 322 3222", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3732), "Khám phá vườn sâm Ngọc Linh, trải nghiệm trồng sâm, thưởng thức dược liệu.", "info@tramyfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2FHHKD2333-900x600.jpg?alt=media&token=169fa448-c537-46dd-895c-381865ffb514", "Trà My Sâm Ngọc Linh Tour", null, new Guid("10000000-0000-0000-0000-000000000007"), "www.tramyfarmtour.vn", 1976, "Huyện Mộc Châu", "0966555777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Phường 7, Thành phố Đà Lạt", "0263 355 8888", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3735), "Du lịch trải nghiệm trồng dâu, làm rau thủy canh, check-in nông trại xanh.", "info@dalatorganic.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fmaxresdefault.jpg?alt=media&token=21b101b4-89c4-42cb-bb2b-65b0cd229be6", "Đà Lạt Organic Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000008"), "www.dalatorganic.vn", 1976, "Huyện Mộc Châu", "0933222111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Xã Phan Thanh, Huyện Bắc Bình", "0252 355 9000", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3738), "Trải nghiệm hái nho, tham quan vườn thanh long sạch và picnic giữa đồng nắng gió Bình Thuận.", "hello@binhthuanfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F18fcefcc98cb5d9504da.jpg?alt=media&token=f8859fe5-b77e-476e-bfea-25c22cadf72a", "Farmstay Nho & Thanh Long Bắc Bình", null, new Guid("10000000-0000-0000-0000-000000000009"), "www.binhthuanfarm.vn", 1976, "Huyện Mộc Châu", "0933444555", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Xã Nam Mẫu, Huyện Ba Bể", "0209 366 2333", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3741), "Trải nghiệm chèo thuyền, nông nghiệp sinh thái, ở nhà sàn truyền thống người Tày.", "contact@babeecotour.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fz4273865435811_cb279364c608be7f093bda58a64acfd3-nongnghiep-170638.jpg?alt=media&token=952a2a5d-0d1f-44d9-8332-cc4659752bd8", "Ba Bể Lake Ecofarm Tour", null, new Guid("10000000-0000-0000-0000-000000000010"), "www.babeecotour.vn", 1976, "Huyện Mộc Châu", "0966001122", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "Xã Tân Hưng, Huyện Tân Châu", "0276 366 7788", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3745), "Khám phá quy trình trồng rau hữu cơ, nuôi bò sữa, làm sữa chua và trồng nấm sạch.", "info@tayninhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F835b7b66.jpg?alt=media&token=259978a6-a141-40d8-b3a0-42b7d5a67947", "Trang Trại Nông Sản Sạch Tân Châu", null, new Guid("10000000-0000-0000-0000-000000000011"), "www.tayninhfarm.vn", 1976, "Huyện Mộc Châu", "0944111222", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000012"), "Xã An Chấn, Huyện Tuy An", "0257 388 8888", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3749), "Trải nghiệm canh tác rau ven biển, tắm biển, đốt lửa trại và học làm nước mắm truyền thống.", "tour@phuyentour.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F4-1708062548800.webp?alt=media&token=dcbe2825-b390-49fa-b21b-14f53ee19f5b", "Trải nghiệm Nông trại Biển & Rau Tuy An", null, new Guid("10000000-0000-0000-0000-000000000012"), "www.phuyentour.vn", 1976, "Huyện Mộc Châu", "0977222333", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000013"), "Xã Mỹ Long Bắc, Huyện Càng Long", "0294 355 1122", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3752), "Khám phá quy trình sản xuất mắm, trồng cây ăn trái và sản phẩm nông sản sạch.", "contact@travinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F11%20(42).jpg?alt=media&token=9dfb8626-bc21-4d09-a374-a91ec8e3b319", "Trang Trại Nông Sản Sạch Càng Long", null, new Guid("10000000-0000-0000-0000-000000000013"), "www.travinhfarm.vn", 1976, "Huyện Mộc Châu", "0908222333", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000014"), "Xã Mỹ Xuyên, Huyện Mỹ Xuyên", "0299 555 2333", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3755), "Trải nghiệm mô hình nông nghiệp hữu cơ, tham quan các cánh đồng lúa, vườn cây ăn trái.", "tour@soctrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F23.12.-DL-Sinh-thai-My-Hoa-Hung-1-1024x576%20(1).jpg?alt=media&token=d1487100-cca6-4bbd-880f-b7824a266507", "Mỹ Xuyên Farmstay", null, new Guid("10000000-0000-0000-0000-000000000014"), "www.soctrangfarm.vn", 1976, "Huyện Mộc Châu", "0933112233", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000015"), "Xã Vĩnh Tế, Huyện Châu Đốc", "0296 388 1133", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3759), "Trải nghiệm canh tác nông nghiệp tại đồng bưng, tham quan vườn trái cây đặc sản miền Tây.", "contact@angiangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fdu-lich-miet-vuon-7_1631758474.jpg?alt=media&token=c8ad0b62-50d1-4625-81f6-c418467da795", "Trang Trại Châu Đốc", null, new Guid("10000000-0000-0000-0000-000000000015"), "www.angiangfarm.vn", 1976, "Huyện Mộc Châu", "0977445566", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000016"), "Xã Nhơn Ái, Huyện Phong Điền", "0292 388 1222", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3761), "Trải nghiệm mô hình trồng cây trái, tham quan các vườn rau hữu cơ và chợ nổi Cần Thơ.", "info@canthoexplore.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fimg_1732330219066_o_1idbeqphmbm29dj1ubq1jl81474d.jpg?alt=media&token=f96b59da-0276-4805-b58f-bcbbdb37bad0", "Cần Thơ Farmstay", null, new Guid("10000000-0000-0000-0000-000000000016"), "www.canthoexplore.vn", 1976, "Huyện Mộc Châu", "0939332111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000017"), "Xã Cửa Dương, Huyện Phú Quốc", "0297 223 4455", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3768), "Tham quan mô hình nông nghiệp hữu cơ, vườn dưa lưới, vườn trái cây nhiệt đới.", "tour@phuquocfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fdua-luoi-7-061822_327-062713.jpg?alt=media&token=3cbc44a6-67a9-49dd-b28f-5403391b186b", "Phú Quốc Nông Trại Sản Xuất Hữu Cơ", null, new Guid("10000000-0000-0000-0000-000000000017"), "www.phuquocfarm.vn", 1976, "Huyện Mộc Châu", "0909888777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000018"), "Xã Đồng Mai, TP. Hạ Long", "0203 356 7890", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3773), "Trải nghiệm mô hình trồng rau hữu cơ và nuôi trồng thủy sản, tham quan khu vườn cây ăn trái đặc sản.", "info@halongfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fvung(1).jpg?alt=media&token=39115e9e-dec1-4982-9638-899d54f7a488", "Trại Nông Sản Hạ Long", null, new Guid("10000000-0000-0000-0000-000000000018"), "www.halongfarm.vn", 1976, "Huyện Mộc Châu", "0912345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000019"), "Xã An Thắng, Huyện An Lão", "0225 350 1000", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3778), "Khám phá mô hình trồng trọt và chăn nuôi, học hỏi cách trồng rau sạch và gia cầm.", "contact@anlaofarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fmuc-so-thi-vuon-rau-huu-co-tho-canh-va-thuy-canh-1833_20230315_542-154329.jpeg?alt=media&token=ce7b46e6-7256-4a0f-8706-dc77675f512d", "Trang Trại Nông Sản An Lão", null, new Guid("10000000-0000-0000-0000-000000000019"), "www.anlaofarm.vn", 1976, "Huyện Mộc Châu", "0932556789", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000020"), "Xã Phú Lạc, Huyện Đại Từ", "0208 382 5000", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3783), "Trải nghiệm các hoạt động nông nghiệp như trồng lúa, chăm sóc vườn rau và tham gia các hoạt động nông dân.", "tour@daitufarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fdu-lich-nong-nghiep-3.jpg?alt=media&token=de31295c-a66b-445d-8182-9055639cc598", "Nông Trại Đại Từ", null, new Guid("10000000-0000-0000-0000-000000000020"), "www.daitufarm.vn", 1976, "Huyện Mộc Châu", "0988776655", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000021"), "Xã Nghi Phú, TP. Vinh", "0238 379 1111", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3790), "Khám phá các vườn cây ăn trái, trồng rau hữu cơ và tìm hiểu về sản phẩm nông sản của vùng đất xứ Nghệ.", "contact@vinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fbase64-1723456186444345111180.webp?alt=media&token=7e8bd8c2-28e4-43b2-aece-09355b55bd61", "Trại Nông Sản Vinh", null, new Guid("10000000-0000-0000-0000-000000000021"), "www.vinhfarm.vn", 1976, "Huyện Mộc Châu", "0912233445", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000022"), "Xã Sơn Lâm, Huyện Triệu Sơn", "0237 375 6789", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3793), "Tham gia vào các hoạt động nông nghiệp như thu hoạch rau, chăm sóc cây ăn trái, tham quan vườn thuốc nam.", "contact@trieusonfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fkhu-vuon-trong-nong-san-sach-0-1641207763997.webp?alt=media&token=33a5a74c-8d0b-4bfb-b0dd-1f9dc9e3607b", "Trang Trại Nông Sản Triệu Sơn", null, new Guid("10000000-0000-0000-0000-000000000022"), "www.trieusonfarm.vn", 1976, "Huyện Mộc Châu", "0988112233", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000023"), "Xã Thạch Hưng, TP. Hà Tĩnh", "0239 354 5678", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3796), "Khám phá nông sản hữu cơ, tham gia các hoạt động làm vườn và trồng cây ăn quả.", "contact@hatinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ft3a_20240425210851.jpg?alt=media&token=b77127b1-30b3-45c5-b547-c8324de43606", "Trại Nông Sản Hà Tĩnh", null, new Guid("10000000-0000-0000-0000-000000000023"), "www.hatinhfarm.vn", 1976, "Huyện Mộc Châu", "0916889900", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000024"), "Xã Quảng Phú, TP. Đồng Hới", "0232 382 7890", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3798), "Trải nghiệm nông nghiệp sinh thái với các mô hình trồng cây, chăm sóc động vật và tham quan các khu vườn.", "contact@donghoifarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F11-1611829270-mo-hinh-trong-dau-tay-da-lat-3.jpg?alt=media&token=d4626806-3666-4331-a7df-53cd52eb18c2", "Trang Trại Đồng Hới", null, new Guid("10000000-0000-0000-0000-000000000024"), "www.donghoifarm.vn", 1976, "Huyện Mộc Châu", "0977223344", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000025"), "Xã Hải Lệ, TP. Đông Hà", "0233 350 5678", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3802), "Khám phá các mô hình trồng cây dược liệu và rau hữu cơ, tham gia các hoạt động chăm sóc động vật.", "contact@donghafarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa1.png?alt=media&token=8397bb0a-f130-4be6-abbe-aeceac5bc8e1", "Trang Trại Nông Sản Đông Hà", null, new Guid("10000000-0000-0000-0000-000000000025"), "www.donghafarm.vn", 1976, "Huyện Mộc Châu", "0912345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000026"), "Xã Phước Sơn, TP. Quy Nhơn", "0256 382 7890", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3805), "Tham gia vào các hoạt động trồng rau hữu cơ và chăm sóc vườn trái cây, tìm hiểu sản phẩm nông sản đặc trưng của Bình Định.", "contact@quynhonfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fhanoimoi.com.vn-uploads-images-tuandiep-2020-03-02-_ba-dang-thi-cuoi-xa-dan-phuong-.jpg?alt=media&token=5d50e486-d791-4dcb-bfb2-87b9d7af8011", "Trại Nông Sản Quy Nhơn", null, new Guid("10000000-0000-0000-0000-000000000026"), "www.quynhonfarm.vn", 1976, "Huyện Mộc Châu", "0988776655", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000027"), "Xã Hòa Thịnh, TP. Tuy Hòa", "0257 355 6789", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3808), "Trải nghiệm các hoạt động trồng trọt, chăm sóc vườn cây ăn quả, tìm hiểu về các sản phẩm nông sản đặc biệt của Phú Yên.", "contact@tuyhoafarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F0603.phuyen2.jpg?alt=media&token=b90710db-3fee-47d4-ba7a-a4054ff6d83f", "Trang Trại Nông Sản Tuy Hòa", null, new Guid("10000000-0000-0000-0000-000000000027"), "www.tuyhoafarm.vn", 1976, "Huyện Mộc Châu", "0972345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000028"), "Xã Vĩnh Thạnh, TP. Nha Trang", "0258 382 9000", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3811), "Khám phá các mô hình trồng cây ăn quả, rau hữu cơ, và các hoạt động du lịch nông nghiệp kết hợp nghỉ dưỡng.", "contact@nhatrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fz4462200782496_874af9e67ff41504f733f389a740cb34.jpg?alt=media&token=e9324dd1-f67a-4b97-932f-321ce44f952f", "Trại Nông Sản Nha Trang", null, new Guid("10000000-0000-0000-0000-000000000028"), "www.nhatrangfarm.vn", 1976, "Huyện Mộc Châu", "0916345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000029"), "Xã Phước Hải, TP. Phan Rang-Tháp Chàm", "0259 382 1111", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3814), "Trải nghiệm du lịch nông nghiệp, tham quan các vườn cây ăn quả, mô hình trồng nho và sản xuất nông sản.", "contact@phanrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F1609.tham_quan_nong_trai_ho_vang_-_mo_hinh_du_lich_sach2.jpg?alt=media&token=178d2881-82bc-43dd-a0cc-650703da54dd", "Trại Nông Sản Phan Rang", null, new Guid("10000000-0000-0000-0000-000000000029"), "www.phanrangfarm.vn", 1976, "Huyện Mộc Châu", "0934567890", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000030"), "Xã Phú Hài, TP. Phan Thiết", "0252 382 5678", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3821), "Trải nghiệm các mô hình trồng cây nông sản và khám phá các sản phẩm đặc trưng của Bình Thuận như thanh long, dừa.", "contact@phanthietfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F114293275_161596928798230_7012125940469886738_o(1).jpg?alt=media&token=2106d196-7206-4cc3-9940-54cbb12d7e6c", "Trang Trại Nông Sản Phan Thiết", null, new Guid("10000000-0000-0000-0000-000000000030"), "www.phanthietfarm.vn", 1976, "Huyện Mộc Châu", "0982334455", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000031"), "Xã An Thạnh, TP. Tân An", "0272 384 5000", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3836), "Khám phá các mô hình trồng cây, chăm sóc cây ăn trái, và tìm hiểu về sản phẩm nông sản của Long An.", "contact@tananfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F631f711e5c833f7e0b2af244_vinhthuan7_high.jpg?alt=media&token=ddb786b7-89f7-4b53-871a-8c32d168dbd5", "Trại Nông Sản Tân An", null, new Guid("10000000-0000-0000-0000-000000000031"), "www.tananfarm.vn", 1976, "Huyện Mộc Châu", "0932456789", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000032"), "Xã Phước Hòa, TP. Vĩnh Long", "0270 382 8888", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3839), "Trải nghiệm du lịch nông nghiệp tại vườn cây ăn trái, học hỏi kỹ thuật trồng rau sạch và các hoạt động sinh thái.", "contact@vinhlongfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F2-phat-trien-du-lich-con-nhieu-kho-khan-FILEminimizer.jpg_636705230132460445.jpg?alt=media&token=75d4bffb-4bb2-4aa7-8a0f-179e003f45c9", "Trại Nông Sản Vĩnh Long", null, new Guid("10000000-0000-0000-0000-000000000032"), "www.vinhlongfarm.vn", 1976, "Huyện Mộc Châu", "0913445566", "Sơn La", "91295", "Phường 14" },
                    { new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), "Số 117 đường Hoàng Quốc Việt – TTNT Mộc Châu ( Ngã tư Vườn Đào )", "0946 166 538", new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Là công ty trẻ tại Mộc Châu, tiên phong cung cấp những dịch vụ du lịch gắn liền với thiên nhiên, văn hóa các dân tộc Mộc Châu, Vân Hồ.\r\nHiện đang khai thác những tour du lịch khám phá nông nghiệp Mộc Châu, khám phá văn hóa đời sống các dân tộc và các chương trình du lịch thiện nguyện, cắm trại, teambuilding, thể thao, MICE…", "dulichmocchaumoc@gmail.com", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fdoi-che-trai-tim-moc-chau-68-1.jpg?alt=media&token=c217f596-e09e-4d34-b21b-84d11eaaa103", "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", null, new Guid("a631bb94-66d8-44db-932b-532892d87754"), "www.mocchaumoc.com", 1976, "Huyện Mộc Châu", "0987654321", "Sơn La", "91295", "Phường 14" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000001") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000002") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000032") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000033") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000034") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000035") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000036") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000037") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000038") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000039") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000040") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000041") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("10000000-0000-0000-0000-000000000042") },
                    { new Guid("0dae2462-9ebd-452e-a89c-06d4b6025e68"), new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000018") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000019") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000020") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000021") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000022") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000023") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000024") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000025") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000026") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000027") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("20000000-0000-0000-0000-000000000028") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("46a916db-f0e3-4855-9171-eff063b5cc90") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("88888888-8888-8888-8888-888888888888") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("a631bb94-66d8-44db-932b-532892d87754") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77") },
                    { new Guid("b8fd818f-63f1-49ee-bec5-f7b66cafbfca"), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("d0e45bee-a768-4555-bfeb-788728a53751") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123") },
                    { new Guid("c78a64eb-5190-44c1-9886-ca707854b807"), new Guid("e025738e-4686-4282-abc3-dae9c65907f0") },
                    { new Guid("c78a64eb-5190-44c1-9886-ca707854b807"), new Guid("e025738e-4686-4282-abc3-dae9c65907f1") },
                    { new Guid("c78a64eb-5190-44c1-9886-ca707854b807"), new Guid("e025738e-4686-4282-abc3-dae9c65907f2") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b") },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") }
                });

            migrationBuilder.InsertData(
                table: "UserSupport",
                columns: new[] { "SupportId", "Email", "Fullname", "IsResolved", "IssueType", "RequestDate", "ResponeBy", "ResponseDate", "ResponseMessage", "SupportMessage", "TouristFacilityId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4959), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4960), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"), "anhNv@gmail.com", "Nguyễn Văn Anh", true, 3, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4951), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4952), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4965), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4966), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4962), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4963), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"), "BinhLeV@gmail.com", "Lê Văn Bình", true, 3, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4956), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4957), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null }
                });

            migrationBuilder.InsertData(
                table: "Accommodation",
                columns: new[] { "AccommodationId", "AccommodationDescription", "AccommodationName", "Address", "Imgs", "PhoneNumber", "Star", "TourCompanyId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Khách sạn 5 sao với dịch vụ cao cấp.", "Khách sạn Hoàng Gia", "Số 123, Đường Trần Phú, Hà Nội", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/516733727.jpg?alt=media\\u0026token=0b789349-cba9-4e9d-b988-5bce07d457c2\"]", "0987654321", 5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Resort ven biển với view đẹp và hồ bơi lớn.", "Resort Biển Xanh", "Số 456, Đường Biển Đông, Đà Nẵng", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/du-lich-phan-thiet-mui-ne-khong-gian-resort-song-bien-xanh.webp?alt=media\\u0026token=b6f4bca3-b5aa-4c86-bf5f-f58c358b1477\"]", "0978543210", 4, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Nhà nghỉ bình dân, giá rẻ, sạch sẽ.", "Nhà nghỉ Hoa Hồng", "Số 789, Đường Nguyễn Trãi, TP Hồ Chí Minh", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/images.jpg?alt=media\\u0026token=ee02614f-fc3b-4b11-a092-fd0be838362f\"]", "0967452103", 3, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Khách sạn có view toàn cảnh thành phố.", "Khách sạn Thiên Đường", "Số 101, Đường Lê Lợi, Huế", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/images%20(1).jpg?alt=media\\u0026token=38f10da2-3dc2-4bfc-bbc6-347729ca583a\"]", "0956328745", 4, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Villa yên tĩnh, phù hợp nghỉ dưỡng.", "Villa Sông Hồng", "Số 202, Đường Bờ Sông, Hải Phòng", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]", "0945216987", 5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "Homestay thiên nhiên với vườn cây xanh mát.", "Homestay Vườn Xanh", "Số 303, Đường Lâm Đồng, Đà Lạt", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/images%20(2).jpg?alt=media\\u0026token=586806c2-bc7f-453d-8646-652d5edf6772\"]", "0934125698", 3, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Khách sạn gần biển, có hồ bơi riêng.", "Khách sạn Mặt Trời", "Số 404, Đường Võ Nguyên Giáp, Nha Trang", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/khach-san-mat-troi-nha-trang-top.jpg?alt=media\\u0026token=aa18f97e-2c52-4981-80b6-943366ee150c\"]", "0923546987", 4, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Nhà nghỉ giá rẻ, gần trung tâm.", "Nhà nghỉ An Bình", "Số 505, Đường Nguyễn Văn Cừ, Cần Thơ", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/nha-khach-an-binh.jpg?alt=media\\u0026token=ffed214a-b404-4354-a61d-05c1201a6eff\"]", "0912564873", 2, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Resort giữa thiên nhiên, hòa mình với cây cỏ.", "Resort Thiên Nhiên", "Số 606, Đường Xanh, Phú Quốc", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/1490857443-chen%20sea%20phu%20quoc65_resort%20phu%20quoc.jpg?alt=media\\u0026token=78b1604e-3dff-40a7-8136-336f1d731838\"]", "0901254789", 5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Khách sạn trung tâm, giá hợp lý.", "Khách sạn Thành Đạt", "Số 707, Đường Lý Thường Kiệt, Quảng Ninh", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/278c80de4ccef04ea12ccfd4a3e15aad.jpg?alt=media\\u0026token=54dd0bf7-514f-4daf-b40c-bb861476d91b\"]", "0896541237", 3, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "Khách sạn trung tâm, giá hợp lý.", "Khách sạn TherHouse", "38 Phan Đình Giót, TT. Mộc Châu, Mộc Châu, Sơn La", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/e7ba17f6_z.webp?alt=media\\u0026token=dbb8ffe7-bf92-4fcd-88ff-51757c0d86f8\"]", "0966 124 194", 5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74") }
                });

            migrationBuilder.InsertData(
                table: "AgriculturalTourPackage",
                columns: new[] { "TourId", "ChildTicketAge", "CreateDate", "Description", "Durations", "DurationsType", "EndTime", "GatheringLocation", "GroupId", "Imgs", "PackageName", "PriceOfAdults", "PriceOfChildren", "Slot", "StartTime", "StatusActive", "TourCompanyId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), "3 tuổi", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4289), "Trải nghiệm cuộc sống nông dân tại vùng biên giới, từ gieo trồng, chăm sóc gia súc đến thu hoạch nông sản cùng người dân địa phương.", 1.0, 3, new DateTime(2025, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fe1.jpg?alt=media\\u0026token=f05fa6e1-5083-45d9-a750-7ee06162c520\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fe2.jpg?alt=media\\u0026token=53afdfbf-5507-47ee-85d1-ec8442304f7e\"]", "Một Ngày Làm Nông Dân Vùng Biên", 11700000.0, 11900000.0, 15, new DateTime(2025, 4, 15, 7, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), "3 tuổi", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4294), "Tham gia vào hoạt động thu hoạch mùa vụ cùng người dân địa phương, từ thu hoạch đến sơ chế và thưởng thức sản phẩm tươi ngon tại chỗ.", 1.0, 3, new DateTime(2025, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ff1.jpg?alt=media\\u0026token=37caad37-477d-4e55-873f-2440551d954a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ff2.webp?alt=media\\u0026token=a23fd593-3c32-4b72-9ab8-c74e86fa3368\"]", "Trải Nghiệm Thu Hoạch Mùa Vụ", 10800000.0, 11600000.0, 20, new DateTime(2025, 5, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), "3 tuổi", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4301), "Hành trình khám phá nét văn hóa độc đáo và hoạt động nông nghiệp truyền thống của đồng bào dân tộc Tày - Nùng, từ trải nghiệm trồng trọt đến thưởng thức ẩm thực và nghệ thuật dân gian.", 1.0, 3, new DateTime(2025, 5, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fg1.jpg?alt=media\\u0026token=40bc8d8a-10a4-4a6b-a852-bd1ab79ae219\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fg2.jpg?alt=media\\u0026token=7d24a17f-5853-4bea-9aa3-488b283393ee\"]", "Khám Phá Nông Nghiệp và Văn Hóa Địa Phương", 17500000.0, 10100000.0, 20, new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), "3 tuổi", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4307), "Trải nghiệm độc đáo kết hợp giữa học tập phương pháp canh tác hữu cơ và nghỉ dưỡng tại homestay sinh thái. Du khách được tham gia vào quy trình trồng trọt sạch và tận hưởng không gian yên bình của thiên nhiên.", 1.0, 3, new DateTime(2025, 5, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fh1.jpg?alt=media\\u0026token=835dc28e-4ea6-4e76-83e4-36591a577988\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fh2.png?alt=media\\u0026token=162ac610-9f4f-4b8e-b8b7-c16c83f500e1\"]", "Du Lịch Canh Tác Hữu Cơ Kết Hợp Nghỉ Dưỡng", 14500000.0, 10100000.0, 15, new DateTime(2025, 5, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("30000000-0000-0000-0000-000000000001"), "3 tuổi", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4312), "Trải nghiệm độc đáo về văn hóa nông nghiệp truyền thống của người H'Mông tại Cát Cát, từ canh tác trên ruộng bậc thang đến thu hái thuốc nam và nấu ăn truyền thống.", 1.0, 3, new DateTime(2025, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fi1.webp?alt=media\\u0026token=d6f2d4c0-4439-4e9e-afd8-ef36d378a6c4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fi2.jpg?alt=media\\u0026token=76d6c2e9-fe9d-4f4a-abed-55e622effe0a\"]", "Một Ngày Làm Nông Dân H'Mông", 13000000.0, 12000000.0, 12, new DateTime(2025, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("30000000-0000-0000-0000-000000000002"), "3 tuổi", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4316), "Khám phá đời sống văn hóa độc đáo của người H'Mông tại bản Cát Cát, tìm hiểu về nông nghiệp hữu cơ và trải nghiệm làm nghề thủ công truyền thống.", 1.0, 3, new DateTime(2025, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fk1.jpg?alt=media\\u0026token=8a1b82a5-d372-49c8-9437-ba1d221ebe90\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fk2.jpg?alt=media\\u0026token=1c08d579-60fe-4071-89fd-b58683ee5388\"]", "Hành Trình Khám Phá Bản Làng và Nông Nghiệp Hữu Cơ", 11200000.0, 11800000.0, 15, new DateTime(2025, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), "3 tuổi", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4260), "Hành trình trải nghiệm nông nghiệp độc đáo tại Mộc Châu, từ tham quan nông trại dâu tây, vắt sữa bò đến thu hoạch rau hữu cơ. Du khách sẽ được trực tiếp tham gia vào các hoạt động nông nghiệp và thưởng thức đặc sản địa phương.", 1.0, 3, new DateTime(2025, 2, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa1.png?alt=media\\u0026token=0e6e621f-912a-4639-a51a-e94e183b95e8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa2.jpeg?alt=media\\u0026token=8159822e-9515-4532-9531-10c21c397218\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa3.webp?alt=media\\u0026token=d7b91ee8-ad6c-4ffa-a979-bcf01709d2c1\"]", "Khám Phá Nông Nghiệp Mộc Châu", 13100000.0, 11200000.0, 20, new DateTime(2025, 2, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), "3 tuổi", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4276), "Trải nghiệm một ngày làm việc thực tế tại nông trại OCOP, từ chăm sóc vườn rau đến thu hoạch và đóng gói sản phẩm theo tiêu chuẩn.", 1.0, 3, new DateTime(2025, 3, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc1.jpg?alt=media\\u0026token=e320026b-8c15-4ca0-9570-1c7f641c3b44\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc2.webp?alt=media\\u0026token=52f3e890-c777-421b-ba33-640a7c6b21b4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc4.jpg?alt=media\\u0026token=73e89a47-6420-43cd-8bd9-6cc18e3771c5\"]", "Một Ngày Làm Nông Dân OCOP", 11600000.0, 11500000.0, 12, new DateTime(2025, 3, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), "3 tuổi", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4269), "Trải nghiệm văn hóa trà truyền thống tại Mộc Châu, từ tham quan đồi chè, học cách hái và chế biến chè, đến thưởng thức các loại trà OCOP đặc sản.", 1.0, 3, new DateTime(2025, 3, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fb1.jpg?alt=media\\u0026token=0baec450-2c25-49fe-b319-360b3f146c89\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fb2.jpg?alt=media\\u0026token=c93ad47c-b5fd-4864-ac53-6bf579f2e5ef\"]", "Tour Hái Chè và Thưởng Trà OCOP", 18000000.0, 10200000.0, 15, new DateTime(2025, 3, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), "3 tuổi", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4284), "Kết hợp du lịch với hoạt động thiện nguyện và bảo vệ môi trường, từ trồng cây xanh đến tham gia các hoạt động cộng đồng tại bản làng.", 1.0, 3, new DateTime(2025, 4, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd1.jpg?alt=media\\u0026token=de1ecc18-0ac0-424c-93e9-5fb18a05cbc4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd2.jpg?alt=media\\u0026token=1bb550da-3a3b-4742-b23c-4075a45c7c0b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd3.png?alt=media\\u0026token=067466e8-32b9-427a-a2c6-739358f95017\"]", "Du Lịch Thiện Nguyện & Nông Nghiệp Xanh", 14200000.0, 10800000.0, 25, new DateTime(2025, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("dc43d553-05f7-43af-9e2b-0ef568982b19"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4857), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4857), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4856), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("f5ab6d38-c52d-48fd-9092-b4daaf255240"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4887), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4885), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4884), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "Contract",
                columns: new[] { "ContractId", "ContractContent", "CreateDate", "DiscountRate", "EndDate", "RequestReSignContract", "SignedDate", "SigningStatus", "StartDate", "Status", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("177c2485-91f8-4553-ba6e-4493fb65d6bb"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5801), 0.02m, new DateTime(2028, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5798), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5798), null, new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), null, null },
                    { new Guid("1abb97ad-5b1e-4375-a816-f7e7fa3a5416"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5889), 0.01m, new DateTime(2030, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5888), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5888), null, null, new Guid("10000000-0000-0000-0000-000000000012"), null },
                    { new Guid("1edd9595-9ebe-4760-a1d5-ecf73bc86d06"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5839), 0.04m, new DateTime(2030, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5838), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5837), null, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("232d2dbf-34cc-46a4-8d74-38e0c8ce2a97"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5789), 0.05m, new DateTime(2027, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5788), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5788), null, new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), null, null },
                    { new Guid("2665eca6-e496-494e-9972-8da61249df35"), "Hợp đồng cung cấp dịch vụ hướng dẫn viên", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5823), 0.02m, new DateTime(2030, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5822), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5822), null, new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), null, null },
                    { new Guid("289dc4ef-46e0-4748-8d6a-6e3f44b4fdc6"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5853), 0.03m, new DateTime(2030, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5852), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5852), null, null, new Guid("10000000-0000-0000-0000-000000000007"), null },
                    { new Guid("2a78e554-d7b9-4465-b018-d210e7012d8e"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5851), 0.05m, new DateTime(2030, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5850), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5849), null, null, new Guid("10000000-0000-0000-0000-000000000006"), null },
                    { new Guid("3c803f7c-4d5b-4d21-b382-b6f3e785b6f7"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5832), 0.05m, new DateTime(2027, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5830), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5829), null, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("3f8afd90-90b5-4cfa-98b5-de12573ddab3"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5885), 0.03m, new DateTime(2028, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5884), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5883), null, null, new Guid("10000000-0000-0000-0000-000000000011"), null },
                    { new Guid("4193fd0c-001a-4130-acbb-bc959419e5ab"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5836), 0.04m, new DateTime(2026, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5834), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5834), null, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("4652c10c-5971-4e6a-ae87-8b3ff92737ab"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5794), 0.02m, new DateTime(2027, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5793), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5792), null, new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), null, null },
                    { new Guid("4de7b020-15c6-463c-9bd7-c0ac4fcfc8d9"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5842), 0.05m, new DateTime(2028, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5840), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5840), null, null, new Guid("10000000-0000-0000-0000-000000000003"), null },
                    { new Guid("4ff028e8-f19e-4283-bc0a-2ee70bc87fdc"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5803), 0.05m, new DateTime(2030, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5802), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5802), null, new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), null, null },
                    { new Guid("556de5f3-4d9c-40f4-8f1a-149f8b7f00ab"), "Hợp đồng cung cấp dịch vụ hướng dẫn viên", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5818), 0.02m, new DateTime(2026, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5817), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5817), null, new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), null, null },
                    { new Guid("7b018150-3d87-4007-a2a4-cd6a2f333454"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5892), 0.02m, new DateTime(2030, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5891), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5890), null, null, new Guid("10000000-0000-0000-0000-000000000013"), null },
                    { new Guid("7e487a79-4967-402e-b217-2e82e140a8f6"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5796), 0.01m, new DateTime(2026, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5795), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5795), null, new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), null, null },
                    { new Guid("85a5e062-20b3-491a-83ad-fc374219c06b"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5848), 0.03m, new DateTime(2030, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5847), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5847), null, null, new Guid("10000000-0000-0000-0000-000000000005"), null },
                    { new Guid("886c1b96-ab1c-47d3-95e3-01dcf56c0d67"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5814), 0.01m, new DateTime(2026, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5813), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5813), null, new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), null, null },
                    { new Guid("9e2d9bfe-5f2a-4cc0-92c7-b87e513910e3"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5811), 0.04m, new DateTime(2027, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5810), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5810), null, new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), null, null },
                    { new Guid("a900384b-13f9-4209-9574-335119308234"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5786), 0.02m, new DateTime(2027, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5785), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5785), null, new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), null, null },
                    { new Guid("abdffb0d-547a-4236-9f7b-7fa9b1a366e5"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5856), 0.03m, new DateTime(2030, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5855), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5854), null, null, new Guid("10000000-0000-0000-0000-000000000008"), null },
                    { new Guid("b360038c-dcdd-4467-b38f-28eedcec1b32"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5948), 0.04m, new DateTime(2028, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5946), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5946), null, null, new Guid("10000000-0000-0000-0000-000000000015"), null },
                    { new Guid("bbc1b197-17f3-4fca-9e47-a2785c9507b2"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5772), 0.03m, new DateTime(2030, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5733), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5731), null, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, null },
                    { new Guid("c0fecad1-94f1-444a-baac-b0ac2f01b566"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5809), 0.03m, new DateTime(2026, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5808), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5807), null, new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), null, null },
                    { new Guid("c7786c88-2a9d-4218-a626-88d28ceab048"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5820), 0.05m, new DateTime(2028, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5819), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5819), null, new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), null, null },
                    { new Guid("e4f0cc17-0110-4940-be78-0fcfd8d464f7"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5941), 0.03m, new DateTime(2026, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5893), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5893), null, null, new Guid("10000000-0000-0000-0000-000000000014"), null },
                    { new Guid("ea0e9b29-acde-4bc9-b7b4-c3238c390792"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5858), 0.04m, new DateTime(2029, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5857), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5857), null, null, new Guid("10000000-0000-0000-0000-000000000009"), null },
                    { new Guid("ee7f1017-32fa-4962-afb3-525c5463eb63"), "Hợp đồng cung cấp dịch vụ hướng dẫn viên", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5806), 0.01m, new DateTime(2026, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5805), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5805), null, new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), null, null },
                    { new Guid("f6e50b60-aded-4054-8b0d-27425f937fb2"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5882), 0.01m, new DateTime(2029, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5881), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5880), null, null, new Guid("10000000-0000-0000-0000-000000000010"), null },
                    { new Guid("f78617bb-57db-4938-8965-10021faf6e66"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5846), 0.03m, new DateTime(2026, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5845), null, null, 0, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5844), null, null, new Guid("10000000-0000-0000-0000-000000000004"), null },
                    { new Guid("fb3b7493-af54-4cb0-af0a-953a058c1eb3"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5825), 0.01m, new DateTime(2028, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5824), null, null, 1, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(5824), null, new Guid("22275542-0625-47be-a503-2f13b7576e9b"), null, null }
                });

            migrationBuilder.InsertData(
                table: "Driver",
                columns: new[] { "DriverId", "DriverName", "Imgs", "IsAvailable", "PhoneNumber", "TourCompanyId", "VehicleType" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Nguyễn Văn A", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0987654321", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0 },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Trần Văn B", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0978543210", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 1 },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Phạm Văn C", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0967452103", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 2 },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Lê Thị D", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0956328745", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 3 },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Hoàng Văn E", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0945216987", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 4 },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "Đỗ Thị F", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0934125698", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 5 },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Ngô Văn G", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0923546987", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 6 },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Bùi Văn H", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0912564873", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 7 },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Vũ Thị I", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0901254789", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0 },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Dương Văn J", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0896541237", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 1 },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "Phan Thị K", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0889652314", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 2 },
                    { new Guid("10000000-0000-0000-0000-000000000012"), "Lý Văn L", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0871236549", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 3 },
                    { new Guid("10000000-0000-0000-0000-000000000013"), "Trịnh Văn M", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0867412365", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 4 },
                    { new Guid("10000000-0000-0000-0000-000000000014"), "Nguyễn Thị N", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0859632147", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 5 },
                    { new Guid("10000000-0000-0000-0000-000000000015"), "Lê Văn O", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0847125639", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 6 },
                    { new Guid("10000000-0000-0000-0000-000000000016"), "Võ Văn P", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0836547891", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 7 },
                    { new Guid("10000000-0000-0000-0000-000000000017"), "Trần Văn Q", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]", null, "0825478963", new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0 }
                });

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Additional", "AddressManufacturer", "Age", "CreateDate", "Description", "Imgs", "Ingredient", "Manufacturer", "NutritionType", "Origin", "Price", "ProductCategory", "ProductName", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UnitProduct", "UpdateDate", "Volume" },
                values: new object[,]
                {
                    { new Guid("20000000-4444-0000-3333-000000000001"), null, "Sóc Trăng", null, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4094), "Gạo ST25 đạt chuẩn hữu cơ, gạo ngon nhất thế giới 2019", "[\"https://bizweb.dktcdn.net/thumb/1024x1024/100/399/910/products/gao-trang-st25-huu-co.jpg?v=1656410170790\",\"https://gaophuongnam.vn/upload/ckfinder/images/g%E1%BA%A1o%20st24%2025/gao-thom-st25-huu-co-chinh-hang.jpg\"]", null, "HTX Gạo ST25", null, "Việt Nam", 200000.0, 0, "[OCOP] Gạo ST25 Hữu Cơ 5kg", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, null },
                    { new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), "Không đường, không chất bảo quản, giữ lạnh ở 4°C.", "Dairy Farm, Mộc Châu", "Từ 1 tuổi trở lên", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4065), "Sữa tươi nguyên chất, thu hoạch và chế biến trực tiếp từ trang trại bò sữa Mộc Châu.", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fsua_moc_chau.webp?alt=media\\u0026token=0bee6dea-0373-4832-a59b-75385e0bf2a6\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fsua_moc_chau_2.webp?alt=media\\u0026token=64822296-e84f-4e59-b2fe-fabe2df2e6b7\"]", "100% sữa bò tươi", "Trang trại bò sữa Mộc Châu", "Canxi, Vitamin D, Protein", "Mộc Châu, Sơn La", 45000.0, 6, "Sữa tươi thanh trùng Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, "1L" },
                    { new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3984), "Tinh Bột Sắn Dây Nguyên Chất Vị Chanh Leo Đồng Tâm 500g - Hỗ Trợ Thanh Nhiệt, Giải Độc, Mát Gan\r\n\r\nI. THÔNG TIN SẢN PHẨM: \r\n- Xuất xứ: Việt Nam\r\n- Quy cách đóng gói: Hộp 500 gram\r\n- Hạn sử dụng: 18 tháng kể từ NSX\r\n- Thành phần: 100 % Nguyên chất bột sắn dây\r\n\r\nII. CÔNG DỤNG: \r\n- Đồ uống thanh nhiệt giải độc do nóng gan, làm trắng da sáng da từ bên trong. Giải nhiệt, rôm sảy, nóng trong người. Giảu rượu giúp cơ thể tỉnh táo, nhanh hồi phục.              \r\n- Chất làm đặc thực phẩm: Tinh bột sắn dây thường được sử dụng như một chất làm đặc trong các món tráng miệng, nước ép, nước uống và các món canh sệt. Nó giúp tăng độ đặc và nhờn cho các món ăn mà không thay đổi hương vị hay màu sắc của chúng.\r\n- Thành phần trong sản phẩm làm đẹp: Tinh bột sắn dây có khả năng hấp thụ dầu và làm dịu da, nên nó thường được sử dụng trong các sản phẩm chăm sóc da. \r\n- Thức ăn bổ sung: Tinh bột sắn dây có chứa chất xơ và chất dinh dưỡng có lợi như kali, canxi và vitamin C. Việc tiêu thụ tinh bột sắn dây có thể giúp cải thiện tiêu hóa, hỗ trợ sự chuyển hóa chất béo, giảm cholesterol và duy trì sự ổn định của đường huyết.\r\n- Sản phẩm không chứa gluten: Tinh bột sắn dây không chứa gluten, là một lựa chọn tuyệt vời cho những người có chứng dị ứng hoặc nhạy cảm với gluten. Nó có thể được sử dụng để thay thế tinh bột từ các nguồn ngũ cốc khác trong nấu ăn và nướng bánh.\r\n- Tạo mặt nạ tự nhiên: Tinh bột sắn dây có thể được kết hợp với các nguyên liệu tự nhiên khác như mật ong, sữa chua, bột trà xanh để tạo mặt nạ tự nhiên.\r\n\r\nIII. CÁCH SỬ DỤNG:\r\nTheo Đông Y, bột sắn dây có vị ngọt, mát, tính bình nên cây thường được sử dụng trong việc thanh nhiệt và giải độc. Còn theo y học hiện đại thành phần hoạt chất có trong bột sắn dây góp phần ngăn ngừa một số b.ệ.n.h. Sau đây là một số cách sử dụng bột sắn dây.\r\n- Cảm nắng, nhức đầu, sốt nóng: Sử dụng khoảng 12g bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Đau bụng đi ngoài giống kiết lỵ: Sử dụng bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Loại bỏ và ngăn ngừa cảm, nôn, đau đầu ở trẻ nhỏ do bị cảm, gió: Nấu chín bột sắn dây cùng gạo tẻ thành cháo, thêm gừng giã nát và mật ong, cho trẻ ăn từ 3 - 5 ngày.\r\n- Chống ngứa do mồ hôi gây nên: 5g bột sắn dây, 5g thiên hoa phấn, 20g hoạt thạch. Trộn đều hỗn hợp rồi rắc lên những khu vực bị ngứa.\r\n- Vùng ngực và bụng cảm thấy nóng cồn cào, khát nước: lấy 120g sắn dây trộn đều với 15g gạo tẻ, sử dụng để nấu cháo, ăn từ 3 - 5 ngày sẽ làm thuyên giảm tình trạng trên.\r\n- Loại bỏ kiết lỵ do nhiệt: Để loại bỏ đau bụng, nóng rát vùng hậu môn, phải rặn khi đại tiện, pha bột sắn dây với nước và đường, sau đó nấu chín đặc và ăn trong 2 - 3 lần/ngày.\r\n- Ngăn ngừa viêm họng: bột sắn dây giúp cơ thể ức chế một số v.i k.huẩn có h.ại. Vì thế, nếu bị viêm họng, bạn có thể lấy từ 10-15g bột pha nước nóng để uống. Sau vài ngày triệu chứng viêm họng sẽ chấm dứt hoàn toàn.\r\n- Hết n.gộ đ.ộc r.ượu: Hòa tan bột sắn dây với một chút đường có thể thêm nước cốt chanh. Có thể sử dụng muối thay cho đường ", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-1.webp?alt=media\\u0026token=4d8cfdbb-9f89-4e0b-9026-eeb3b551ea0c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-2.webp?alt=media\\u0026token=bad36b93-8f59-4463-8622-b0a7ea89821e\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-3.webp?alt=media\\u0026token=d111fa72-4b38-4bfc-9c7b-9b5111eadb07\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-4.webp?alt=media\\u0026token=7c347385-45bd-474f-9930-77dca305655c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-5.webp?alt=media\\u0026token=b6b5ea5e-dee5-4c3f-ac83-231fe6bd4a68\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-6.webp?alt=media\\u0026token=d3542914-5791-4d36-95a6-071e554aa407\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-7.webp?alt=media\\u0026token=4126eb69-2b91-4c39-a8dc-f548b1b9bbd6\"]", null, "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 0, "[OCOP] Tinh Bột Sắn Ta Dây Nguyên Chất 100% Vị Chanh Leo 500g - Thanh Nhiệt, Giải Độc, Mát Gan, Đẹp Da - Làm Thủ Công", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null },
                    { new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4042), "Bột lá tía tô nguyên chất được bào chế từ lá tía tô tươi, phơi khô, tán mịn để tạo thành sản phẩm bột nguyên chất, giữ được thành phần dưỡng chất bên trong \r\nPhân tích thành phần lá tía tô ta sẽ thấy : 0,3 - 0,5% tinh dầu (khối lượng khô), citral chiếm 20% khối lượng khô. Trong đó thành phần  tinh dầu chủ yếu là perillaldehyd, limonen, L-perrilla alcohol, α-pinen… \r\nLá tía tô có chứa thêm thành phần tanin và glucosid chống v.êm hiệu quả \r\n💗💗 Công dụng dưỡng da của bột lá tía tô nguyên chất Từ xưa, lá tía tô đã được biết đến với các hiệu quả làm đẹp, chăm sóc da mặt. \r\nSử dụng bột lá tía tô nguyên chất sẽ mang đến hiệu quả dưỡng da tuyệt vời mà chị em không thể qua \r\n- Hỗ trợ mụn trứng cá, mụn bọc, mụn sưng đỏ \r\n- Làm sạch da, mịn da, điều tiết dầu nhờn \r\n- Cân bằng độ ẩm cho da khô, nhờn\r\n- Khá.n.gg khuẩn, khá.n.gg v.iê.mm tốt cho làn da mẫn cảm dễ nổi mụn, da dị ứng \r\n- Da sáng dần, đều màu, trắng hồng nếu kiên trì sử dụng \r\n- Hỗ trợ trị Gout\r\n– Cảmho, đau bụng \r\n- Giảm béo, làm đẹp da \r\n- Tốt cho sức khỏe bà bầu và nhiều công dụng khác \r\n🍓🍓 Với thành phần tanin và glucosid hạn chế sự phát triển của vi khuẩn hiệu quả, ngăn ngừa các tác nhân gây mụn, giảm sưng hiệu quả \r\n➡ Lá tía tô có các hoạt chất đặc biệt hiệu quả làm tiêu các bã nhờn trên da, tích tụ gây mụn trứng cá, mụn bọc.\r\n Làm mát từ bên ngoài giúp giảm mụn tối ưu\r\n #bottiato #tiatonguyenchat #botlatiato \r\n• HSD 12 tháng sau khi mở bao bì sản phẩm \r\n• Bảo quản nơi khô ráo, thoáng mát\r\n#bot_tia_to #la_tia_to #bot_tia_to_nguyen_chat", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F72.webp?alt=media\\u0026token=b0fa1e0c-85fb-455e-99c2-66578c832e4b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F72.webp?alt=media\\u0026token=b0fa1e0c-85fb-455e-99c2-66578c832e4b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F74.webp?alt=media\\u0026token=01e37117-b3c5-47eb-8fdd-956c7b8cfa6e\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F75.webp?alt=media\\u0026token=13fdd758-187b-44b8-9b9f-e9fb47148524\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F76.webp?alt=media\\u0026token=be498a71-dc12-42a0-bebd-844b732aa1c8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F77.webp?alt=media\\u0026token=41f13948-a8de-49ff-88d4-a37b46dd87b8\"]", "Tía tô, cỏ ngọt", "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 2, "[OCOP QUẢNG TRỊ] Bột tía tô sấy lạnh Trần Lan [Hộp 150gr]", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "150g" },
                    { new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4051), "THÔNG TIN SẢN PHẨM NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n• Thành phần: 95% bột trầm hương tự nhiên Việt Nam, tăm tre Đài Loan cao cấp, bột vỏ cây bời lời Tây Nguyên\r\n\r\n• Trầm phổ thông: tuổi trầm khoảng từ 8-10 năm\r\n\r\n• Trầm cao cấp: tuổi trầm khoảng từ 12-15 năm\r\n\r\n• Trầm đặc biệt: tuổi trầm từ 25 năm trở lên\r\n\r\n• Số lượng cây trong 1kg: loại 40cm có khoảng 650 cây | loại 30cm có khoảng 800 cây\r\n\r\n• Độ nhang dài: 30cm | 40cm (cả cây nhang, tính từ chân đến ngọn)\r\n\r\n• Thời gian cháy: 40-50 phút với loại 30cm | 70-80 phút với loại 40cm, tuỳ vào không gian sử dụng.\r\n\r\n• Xuất xứ: Việt Nam\r\n\r\n• Cách dùng: Thắp ở bàn thờ gia tiên, bàn thờ thần tài ông địa, cúng chùa,...\r\n\r\n• Sản phẩm nhang trầm hương cao cấp được sản xuất thủ công, nguyên liệu thuần tự nhiên, mùi thơm dịu nhẹ, thơm ngọt mùi trầm. Sản phẩm để nơi khô ráo càng lâu càng thơm.\r\n\r\n\r\n\r\nHƯỚNG DẪN SỬ DỤNG NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n1/ Trong thờ cúng, gia tiên:\r\n\r\n• Nhang trầm hương sạch dùng trong không gian thờ cúng, tạo sự tưởng nhớ biết ơn và cầu nguyện cho con cháu bình an, gia đình hòa thuận.\r\n\r\n• Nhang trầm hương sạch giúp thanh lọc không gian sống, tiêu trừ các loại mùi hương xấu, thu hút tài lộc.\r\n\r\n• Nhang trầm hương sạch giúp chiêu tài dẫn lộc dịp khai trương, tân gia, tất niên,..\r\n\r\n2/ Trong không gian sống và sức khoẻ:\r\n\r\n• Mùi hương trầm sạch  tạo cảm giác thư giãn, giảm áp lực, căng thẳng, cải thiện sự tập trung.\r\n\r\n• Làm thơm không gian làm việc, làm dịu nhẹ thần kinh và kích thích khả năng tư duy sáng tạo.\r\n\r\n• Nhang trầm hương sạch để xông nhà, trà đạo hoặc yoga giúp tinh thần thông thoáng, cải thiện sức khỏe.\r\n\r\n• Nhang trầm hương sạch, nguyên chất giúp cho giấc ngủ được sâu hơn, cải thiện các chứng đau đầu.\r\n\r\n\r\n\r\nCHÍNH SÁCH ĐỔI TRẢ - BẢO HÀNH\r\n\r\n1/ Đổi trả theo đúng quy định của SHOPEE:\r\n\r\n• Chỉ đổi trả khi hàng hoá còn mới, chưa qua sử dụng.\r\n\r\n• Chấp nhận đổi trả khi hàng hoá bị hỏng hoặc do lỗi của nhà sản xuất.\r\n\r\n2/ Trường hợp được chấp nhận:\r\n\r\n• Hàng không đúng phân loại, mẫu mã như quý khách đặt hàng\r\n\r\n• Không đủ số lượng, không đủ bộ như trong đơn hàng\r\n\r\n3/ Trường hợp không đủ điều kiện áp dụng chính sách:\r\n\r\n• Gửi lại hàng không đúng mẫu mã, không phải hàng của XƯỞNG MỘC VIỆT\r\n\r\n• Do màn hình và điều kiện ánh sáng khác nhau, màu sắc thực tế của sản phẩm có thể chênh lệch khoảng 3-5%.\r\n\r\n\r\n\r\nTHÔNG TIN SẢN XUẤT TRẦM HƯƠNG XƯỞNG MỘC VIỆT\r\n\r\n• Xưởng Mộc Việt là thương hiệu hàng đầu Việt Nam chuyển thu mua, sản xuất và phân phối sản phẩm vòng tay trầm hương, trang sức trầm hương, nhang trầm hương và trầm hương sạch, chuẩn tự nhiên\r\n\r\n• Sản phẩm Xưởng Mộc Việt tự hào nhận các chứng nhận như: OCOP và chuẩn sản phẩm công nghiệp nông thôn tiêu biểu tỉnh Quảng Trị\r\n\r\n• Tất cả sản phẩm được Xưởng Mộc Việt đưa ra thị trường là sản phẩm chính hãng Công ty và cam kết là hàng chuẩn trầm sạch, chuẩn tự nhiên. Được cơ quan chức năng cấp các chứng nhận: OCOP, ISO 9001:2015, VN-TEST", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F82.webp?alt=media\\u0026token=b855f4ab-4b51-43ea-af26-e0deb629f97c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F83.webp?alt=media\\u0026token=15012cad-7f6f-4cae-842c-c1e8e35d0c89\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F84.webp?alt=media\\u0026token=0576465d-964e-4ffc-93fa-54f410c761e7\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F85.webp?alt=media\\u0026token=ef5f7fbf-bf80-43d6-a4fa-ebda116b5dc1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F86.webp?alt=media\\u0026token=521f7498-9a95-424e-884b-72b611b6f0ee\"]", "Trầm hương, Bột Trầm Hương", "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 6, "Nhang trầm hương cao cấp [1Kg] sạch chuẩn sản phẩm OCOP, ISO 9001 - Xưởng Mộc Việt", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 0, null, "1kg" },
                    { new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Trà túi lọc & lá trà", "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4018), "🌱Sản phẩm đạt tiêu chuẩn OCOP 4 SAO theo Quyết định 919/QĐ-Ttg năm 2018 của Chính phủ\r\n\r\n\r\n\r\n✅THÔNG TIN SẢN PHẨM:\r\n\r\n• Trà Sen Bách Diệp là sự hòa quyện tuyệt vời giữa hương thơm ngan ngát của sen Bách Diệp Hồ Tây và vị đậm đà của trà Tân Cương Thái Nguyên.\r\n\r\n• 100% Trà Sen Bách Diệp Tây Hồ Hà Nội được thu hái thủ công, tuyển chọn những búp chè tươi ngon. Trà được gói trọn trong bông Sen giúp cho lá trà thẩm thấu toàn bộ hương sen, sau đó được sấy thăng hoa theo công nghệ hiện đại của Đức để giữ được trong hương vị và bảo quản được lâu, khi pha tạo nên cảm giác khoan khoái và thư giãn.\r\n\r\n• Hải Linh tự hào là thương hiệu Trà sen Bách Diệp uy tín, có sản lượng tiêu thụ lớn nhất hiện nay.\r\n\r\n\r\n\r\n✅ Set quà sang trọng: Một set bao gồm: Trà Sen, hộp trà và túi xách đẹp mắt, thích hợp làm quà tặng cao cấp.\r\n\r\n- Trọng lượng: Set 10 bông trà (tổng trọng lượng 1.000g). Mỗi bông trà sen sau khi đã được sấy thăng hoa (mất hơi nước) có trọng lượng 26gram, đủ tiêu chuẩn cho 6 người uống (4gram trà / 1 người).\r\n\r\n- Trà đã được ướp bông sen sau đó sấy thăng hoa cả búp nên chỉ cần bảo quản ở nhiệt độ thường\r\n\r\n- HSD 12 tháng kể từ ngày sản xuất, NSX và HSD được in trên bao bì từng bông.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHI TIẾT SẢN PHẨM:\r\n\r\n• Thành phần: 100% trà xanh chất lượng được bọc bên trong búp sen tươi.\r\n\r\n• Hướng dẫn sử dụng: \r\n\r\n- Rót nước sôi để tráng ấm, chén pha trà: Giúp tiệt trùng dụng cụ pha trà và làm nóng ấm, chén pha trà.\r\n\r\n- Cho khoảng 10g trà và phần gạo sen vào trong ấm.\r\n\r\n- Châm 200ml nước sôi có nhiệt độ 75 đến 80 độ C vào ấm, rồi hãm 20-25 giây.\r\n\r\n-  Rót trà từ ấm: Hãm đủ thời gian, bạn hãy rót hết lượng trà trong ấm ra chén Tống qua chiếc lọc trà và tránh để lại nước trong ấm (Lọc trà giúp giữ lại những xác trà nhỏ giúp nước trà trong và tinh khiết hơn)\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CÔNG DỤNG CỦA TRÀ SEN: \r\n\r\n• Trà sen Bách Diệp giúp giảm lượng cholesterol trong máu, giúp ngăn ngừa bệnh tim mạch, đặc biệt tốt cho sức khỏe của người già, người mắc bệnh tim mạch. Hạn chế nguy cơ mắc các bệnh về gan, hạn chế sự hấp thu các chất béo vào cơ thể.\r\n\r\n• Tăng cường hệ miễn dịch giúp cho cơ thể giúp cơ thể chống lại những hiện tượng nhiễm virus và nhiễm khuẩn.\r\n\r\n\r\n\r\n✅ QUY CÁCH ĐÓNG GÓI: Trà và búp sen được sấy khô và hút chân không giúp giữ hương vị trà được lâu, thân thiện với môi trường.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHÍNH SÁCH ĐỔI TRẢ CỦA TRÀ SEN HÀ NỘI OFFICIAL : \r\n\r\n👉 1 đổi 1 trong trường hợp lỗi do nhà sản xuất, sai sản phẩm và theo quy định của Shopee. \r\n\r\n👉 Trường hợp gửi thiếu, các bạn liên hệ shop để được đổi lại, gửi bù MIỄN PHÍ. (Các bạn nhớ QUAY CLIP BÓC HÀNG để được giải quyết nhé).\r\n\r\n\r\n\r\n#tràbúpsen #tràbôngsen #tràngon #tràcaocấp #chèbúpsen #tràsen #tràướphoasen #tràsentâyhồ #tràhoasen #trà #tràbiếu #sentrà #tràướpsentâyhồ #chèướpsen #tràướpbôngsen #chèsen #chèsentâyhồ #tràsenhànội #chèhoasen", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F51.webp?alt=media\\u0026token=5218426e-19ff-4feb-b968-93e08e7f6c92\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F52.webp?alt=media\\u0026token=65af2dec-b460-4f5c-8c4b-8c76b6581a83\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F53.webp?alt=media\\u0026token=a5f9bc6d-d647-4b36-9c9e-bf86eead7692\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F54.webp?alt=media\\u0026token=94412ff3-d1eb-427a-8114-3290d62edd31\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F55.webp?alt=media\\u0026token=1cade255-31ff-4248-ac2f-0f2f8513b33c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F56.webp?alt=media\\u0026token=7df9da7d-de96-49bc-a5e5-15113e8bb8e0\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F57.webp?alt=media\\u0026token=d9ab3abb-2461-45e6-a22b-3cf0f2a2060f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F58.webp?alt=media\\u0026token=8a4bda8c-0e6c-4154-8dc0-6c3c23ea8f53\"]", "Trà xanh, Khác", "Xưởng Mộc Việt", "Truyền thống", "Việt Nam", 80000.0, 1, "Trà Sen Tây Hồ Thượng Hạng [OCOP 4⭐] - Hương Thơm Tự Nhiên, Đậm Đà Truyền Thống, Hộp 10 Bông", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null, null, "10 bông" },
                    { new Guid("69006cfe-5233-7776-b181-d81a485873e3"), null, "Mộc Châu, Sơn La", null, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4086), "Mật ong rừng nguyên chất, thu hoạch từ các khu rừng nguyên sinh", "[\"https://www.google.com/url?sa=i\\u0026url=https%3A%2F%2Fvi-vn.facebook.com%2Fmatongnguyenchatbaoloc123%2F\\u0026psig=AOvVaw0psQ_ofRkq3xidpma68DF4\\u0026ust=1745923051724000\\u0026source=images\\u0026cd=vfe\\u0026opi=89978449\\u0026ved=0CBQQjRxqFwoTCIiT7qnE-owDFQAAAAAdAAAAABAZ\",\"https://topaz.vn/wp-content/uploads/2022/11/dia-chi-ban-mat-ong-rung-nguyen-chat-tai-tphcm-1.jpg\"]", null, "HTX Mật Ong Rừng", null, "Việt Nam", 150000.0, 0, "[OCOP] Mật Ong Rừng Nguyên Chất 500ml", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, null },
                    { new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3997), "✅ Thông tin sản phẩm cơm cố đô ruốc đậm đà 300g- 600g:\r\n    1 gói 05 miếng to đùng.\r\n    Shop đóng gói thùng giấy catton chắc chắn hạn chế bể vỡ khi vận chuyển.\r\n    Trọng lượng mỗi gói cơm cháy cố đô ruốc đậm  Khoảng 600 gram/Túi\r\n\r\n✅ Cơm cháy bên mình để khô ráo dầu mới bỏ vào bịch, và chiên dầu mới để không bị gắt dầu nha các bạn.\r\n     sản phẩm đóng trong túi zips kín, sử dụng rất tiện ích\r\n     Hạn sử dụng: 6 Tháng\r\n     Nguồn gốc xuất xứ : Thành phố Ninh Bình - tỉnh Ninh Bình\r\n\r\n✅ HƯỚNG DẪN SỬ DỤNG VÀ BÀO QUẢN :\r\n- Dùng ngay khi mở miệng túi không cần chế biến.\r\n- Bảo quản nơi khô ráo, thoáng mát và tránh ánh nắng trực tiếp.\r\n \r\n✅ Shop mình tự tin là chuẩn bị hàng nhanh, sáng các bạn đặt đơn thì chiều mình gởi hàng. Tuy nhiên thời gian giao hàng còn phụ thuộc vào đơn vị giao hàng nữa, đôi khi có những trường hợp giao chậm hơn so với dự kiến. Shop mong các bạn hiểu và thông cảm ạ !\r\n\r\n✅ Thời gian giao hàng đối với các tỉnh miền bắc, miền trung: 1-3 ngày. Tỉnh phía Nam : 3-5 ngày.\r\n\r\n1 Túi 05 MIẾNG TO ĐÙNG CƠM CHÁY RUỐC HÀNH ỚT | SHOP CƠM CHÁY CỐ ĐÔ - TINH HOA NÔNG SẢN VIÊT\r\n\r\n#cơm_cháy #cơm_cháy_chà_bông #cơm_cháy_rụm #cơm_cháy_mỡ_hành #cơm_cháy_khô_gà #cơm_cháy_chiên #nước_mắm #cơm_cháy_chiên_mắm #cơm_cháy_lắc_khô_gà #cơm_cháy_mắm_hành #com_cháy_chà_bông #cơm_cháy_ngon #cơm_cháy_chà_bông_ngon #cơm_cháy_khô #cơm_cháy_mắm_ớt #cơm_cháy_chà_bông_mỡ_hành #cơm_cháy_mắm #cơm_cháy_tỏi #cơm_cháy_giá_sỉ", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F32.webp?alt=media\\u0026token=1b2c7198-56da-46dc-bef8-c1371e4bbd16\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F33.webp?alt=media\\u0026token=feac05a6-f278-4bae-85ab-4a9453decd2a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F34.webp?alt=media\\u0026token=153f06d6-d1ee-4781-a17a-b43c0028fbea\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F35.webp?alt=media\\u0026token=0cf39ab3-b794-4d99-90a6-4d4026b690d8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F36.webp?alt=media\\u0026token=0f2875bb-7146-4a3d-8774-d449d78a925a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F37.webp?alt=media\\u0026token=4ef86b59-4468-4e52-af69-5084c99281c8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F38.webp?alt=media\\u0026token=f332cd0d-fc6f-45e4-87cf-5ad8c1dfc749\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F310.webp?alt=media\\u0026token=1c52bcc3-1800-4c86-a874-842c62dca2af\"]", "GẠO NẾP THƠM, RUỐC, ỚT, TIÊU", "Xưởng Mộc Việt", "Đặc sản địa phương", "Việt Nam", 80000.0, 0, "[BÁN SỈ] Cơm cháy 300g- 600g siêu ruốc chà bông ròn ngon Cố Đô, ocop 4 sao đặc sản Ninh Bình", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "750g" },
                    { new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4031), "1. R.ư.ợ.u ống tre Việt 1 ống dung tích 750ml. Bộ sản phẩm đi kèm thêm búa rõ R.ư.ợ.u  và hộp đựng.\r\n2. R.ư.ợ.u  ống Tre Việt có 2 vị: 1 là vị nếp cái hoa vàng kết hợp với thảo mộc. 2 là vị R.ư.ợ.u  truyền thống\r\n3. Độ R.ư.ợ.u  lúc bơm vào cây tre là 50 độ, sau thời gian tre hấp thụ đến khi thu hoạch độ R.ư.ợ.u  còn khoảng 32 độ.\r\n4.R.ư.ợ.u  có mùi thơm do kết hợp của Tre, thảo mộc … và Vị ngọt thanh nhẹ, dễ uống.\r\n5. Cách làm R.ư.ợ.u  ống tre: R.ư.ợ.u  nếp sau khi nấu xong, cho qua máy khử các độc tố trong R.ư.ợ.u  như Metanol; Andehit. Rồi hạ thổ 1 năm với các loại hoa quả, thảo mộc hoặc dùng R.ư.ợ.u  nếp cái hoa vàng hạ thổ với các loại thảo mộc. Sau đó bơm vào cây tre đang sinh trưởng. Sau 6 tháng mới cho thu hoạch được.\r\n6. R.ư.ợ.u  dùng men bắc truyền thống, hay còn gọi là Men Trấu của các cụ ngày xưa hay nấu R.ư.ợ.u .\r\n7. Sản phẩm đã được cho đi kiểm nghiệm chuẩn chỉnh về chất lượng sản phẩm nên cực kỳ an toàn. Ngoài ra sản Phẩm R.ư.ợ.u  ống Tre Việt  đạt chứng chỉ Ocop 3 sao. Đây là sản phẩm R.ư.ợ.u  ống Tre đầu tiên ở Việt Nam đạt chứng chỉ Ocop.\r\n8. Bảo quản R.ư.ợ.u  ống Tre: Để nơi khô ráo, thoáng mát, Lúc uống muốn ngon hơn có thể để vào ngăn mát tủ lạnh.\r\n9. R.ư.ợ.u  uống ngon nhất trong 6 tháng đầu. Về sau độ R.ư.ợ.u  sẽ giảm dần, và R.ư.ợ.u  sẽ ngọt hơn", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F62.webp?alt=media\\u0026token=5e7d93e8-e10e-47e1-be82-573a9436bdca\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F63.webp?alt=media\\u0026token=7b8fd32b-486b-4fec-bb89-ec59959708d0\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F64.webp?alt=media\\u0026token=d7b0593b-a8a7-44de-917a-35e3699f5cd1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F65.webp?alt=media\\u0026token=daa304f2-2707-486e-862e-e39f5aff3c25\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F66.webp?alt=media\\u0026token=e9b4469d-a2c9-458a-ba20-e2968a4db706\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F67.webp?alt=media\\u0026token=67fb95cf-5e3b-4dbe-afa7-80dd4c85b7ce\"]", null, "Xưởng Mộc Việt", "Đặc sản địa phương", "Việt Nam", 80000.0, 1, "Ống rượu tre Việt Nam - Sản phẩm đạt chứng nhận Ocop 3 Sao [ Quà Tết Hot 2024 ]", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, "750ml" },
                    { new Guid("98e14da8-4445-4e50-bd9b-eb74112f6625"), null, "Yên Bái", null, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4090), "Trà Shan Tuyết từ cây chè cổ thụ trên 100 năm tuổi", "[\"https://vietcotra.vn/media/product/1726818655_tra-shan-tuyet-suoi-giang-cc.jpg\",\"https://bizweb.dktcdn.net/100/201/525/files/unnamed.jpg?v=1720524034006\"]", null, "HTX Trà Shan Tuyết", null, "Việt Nam", 250000.0, 1, "[OCOP] Trà Shan Tuyết Cổ Thụ 200g", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null },
                    { new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), "Không thuốc trừ sâu, không hóa chất, thu hoạch trong ngày.", "Mộc Châu Xanh, Mộc Châu", "Tất cả mọi người", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4074), "Rau cải ngọt được trồng theo phương pháp hữu cơ chuẩn OCOP tại trang trại rau Mộc Châu Xanh.", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Frau_cai_moc_chau.jpg?alt=media\\u0026token=7806aa89-1434-4973-a4c4-f75157dc263f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Frau_cai_moc_chau_2.jpg?alt=media\\u0026token=9d619514-84e3-427a-ba7c-6b56cafb24ba\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Frau_cai_moc_chau_3.jpg?alt=media\\u0026token=01deb8a8-a991-4ec5-bc40-818fa56f80b2\"]", "100% rau cải ngọt hữu cơ", "Trang trại rau hữu cơ Mộc Châu Xanh", "Vitamin A, Vitamin C, Sắt", "Mộc Châu, Sơn La", 25000.0, 6, "Rau cải ngọt hữu cơ Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "500g" },
                    { new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Tiêu hóa & gan, Tim mạch & huyết áp, Khả năng miễn dịch, Khớp, cơ bắp & Xương, Căng thẳng, giấc ngủ, và nlo lắng", "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", "Người lớn", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(3964), "Viên Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da\r\n\r\n1. Thông tin sản phẩm:\r\n- Quy cách đóng gói: 500gr\r\n- Hạn sử dụng: 18 tháng \r\n- Xuất xứ: Việt Nam\r\n-  Hoàng Mai, tỉnh Nghệ An\r\n- Chứng chỉ: Chứng nhận OCOP 3 sao\r\n- Thương hiệu: HTX Đồng Tâm\r\n\r\n2. Ưu điểm nổi bật\r\n- Sản phẩm đạt chuẩn chất lượng tiêu chuẩn OCOP.\r\n- Áp dụng công nghệ bào chế tinh bột nghệ Nano Curcumin.\r\n- Thành phần: tinh bột nghệ, mật ong tự nhiên nguyên chất không pha tạp.\r\n- Tinh chế từ 100% nguyên liêu tự nhiên không hóa chất bảo quản.\r\n\r\n3. Công dụng sản phẩm\r\n- Hỗ trợ đường tiêu hoá: phòng các chứng viêm va giảm đau dạ dày ( bao tử), đại tràng, bệnh đường ruột.\r\n- Giảm mụn, nám, tàng nhang, thâm sạm, ngăn ngừa lão hoá từ bên trong giúp dưỡng nhan, làm hồng hào da, nhuận sắc\r\n- Lưu thông m.á.u, hỗ trợ các bệnh viêm khớp, tim mạch, tiểu đường\r\n- Làm hạ huyết áp, giảm cholesterol\r\n- Giúp an thần, ngủ ngon \r\n- Tăng cường sinh lực cho phái mạnh\r\n- Cải thiện sức khoẻ, sắc đẹp đẹp cho phụ nữ sau sinh\r\n\r\n4. Hướng dẫn sử dụng:\r\n- Viên nghê mật ong Hoàng Mai thơm ngon, khá mềm nên có thể nhai trực tiếp hoặc kết hợp uống với nước.\r\n- Nếu đau dạ dày nặng ngày dùng 3 lần, 5-7 viên/ lần sau khi ăn, khoảng 1 tháng đã cải thiện nên giảm tần suất dùng xuống ngày 2 lần \r\n- Uống tốt sức khỏe & tái tạo – trẻ hóa da ngày dùng 2 lần, 3-5 viên/ lần.\r\n- Các mẹ ở cử, sau sanh khoảng 7 ngày-10 ngày khi xuống sạch dịch và huyết thì dùng ngày dùng 3 lần, 5 viên/ lần.\r\n- Trẻ em trên 2 đến 6 tuổi ngày dùng 2 lần, 2-3 viên/ lần.\r\n*** Lưu ý: Phụ nữ mang thai, người bị sỏi thận, sỏi mật, người chuẩn bị phẩu thuật, trẻ em dưới 2 tuổi không nên dùng.\r\n\r\n5. Hướng dẫn bảo quản viên tinh bột nghệ mật ong Hoàng Mai\r\n- Để nơi thoáng mát, tránh tiếp xúc ánh nắng mặt trời.\r\n- Không nên đặt dưới nền đất lạnh, sẽ ảnh hưởng đến chất lượng.\r\n- Tránh để nước hoặc không khí tiếp xúc với sản phẩm, sẽ gây ẩm mốc.\r\n- Đậy nắp kín trước và sau khi sử dụng. \r\n\r\n6. Quy trình đổi trả sản phẩm nếu có lỗi từ nhà sản xuất theo quy định của Shopee.\r\n Điều kiện áp dụng (trong vòng 03 ngày kể từ khi nhận sản phẩm):\r\n- Vui lòng quay video mở hàng (shop chỉ giải quyết đơn hàng khi có video mở hàng)\r\n- Hàng hóa hư hỏng do vận chuyển hoặc do nhà sản xuất.\r\n- Không đủ số lượng như trong đơn hàng.\r\n\r\nSẢN PHẨM NÀY KHÔNG PHẢI LÀ THUỐC VÀ KHÔNG CÓ TÁC DỤNG THAY THẾ THUỐC CHỮA BỆNH.\r\n#Viennghe #Vientinhnghe #Viennghematong #Vientinhnghematong #Matong  #Suaongchua #tinhbotnghe #tinhbot #botnghevang #nghe #tinhbotnghevang #tinhbotnghethiennhien #tinhbotnghehuuco #tinhbotnghetunhien #tinhbotnghexuatkhau #sanxuattinhbotnghe #vientinhbotnghe #vientinhbot #nghevang #shopmall #Shopuytin #ocop", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lmyybsw1u1274a%40resize_w900_nl.webp?alt=media\\u0026token=8df7ec0c-528c-4420-b9d8-1aa642cf458b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-ln887g33oi54f0%40resize_w900_nl.webp?alt=media\\u0026token=e4a624c3-296d-4553-812e-c17832510225\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lnq49wxk2v7ea0%40resize_w900_nl.webp?alt=media\\u0026token=b6600b96-94ef-473e-ba86-72a4f5568635\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqd729rck56%40resize_w900_nl.webp?alt=media\\u0026token=2df35c4e-8b69-4210-80f3-58f6dee45ac5\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqlwlhj90fe%40resize_w900_nl.webp?alt=media\\u0026token=bddafaae-310a-421f-ac7d-ba10a052b63a\"]", "Tinh bột nghệ, Mật ong nguyên chất", "Xưởng Mộc Việt", "Nghệ", "Việt Nam", 80000.0, 2, "[OCOP - 500 gr] Viên Tinh Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da, Lưu Thông Máu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "500ml" },
                    { new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), "Các món ăn đều sử dụng nguyên liệu từ Mộc Châu, mang lại hương vị tươi ngon và đậm đà.", "Bản Áng, Mộc Châu", "Từ 12 tuổi trở lên", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4079), "Bữa trưa gồm các món ăn đặc sản như bê chao, cá suối, rau rừng, và sữa chua Mộc Châu, tất cả đều làm từ nguyên liệu tươi ngon và sạch.", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdac_san_moc_chau.png?alt=media\\u0026token=dd60c37e-bee9-45ad-bf3a-49d3ac0a8064\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdac_san_moc_chau_2.png?alt=media\\u0026token=0e22ac4f-c71b-4eac-a69d-8dda23b53608\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdac_san_moc_chau_3.png?alt=media\\u0026token=26fd6f31-d166-412e-abb2-034150f3d37b\"]", "Bê chao, cá suối, rau rừng, sữa chua Mộc Châu", "Nhà hàng Truyền thống Bản Áng", "Protein, Vitamin C, Vitamin A", "Mộc Châu, Sơn La", 200000.0, 0, "Món ăn đặc sản Mộc Châu", null, 0, new Guid("10000000-0000-0000-0000-000000000001"), 1, null, "Một suất ăn" },
                    { new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), "Không chất bảo quản, đóng lọ thủy tinh cao cấp.", "Bản Áng, Mộc Châu, Sơn La", "Từ 3 tuổi trở lên", new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4059), "Mứt dâu tây thủ công được làm từ những quả dâu tươi được hái tại nông trại trong tour tham quan.", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fmut_dau_moc_chau.jpg?alt=media\\u0026token=5cbd4a36-f066-4014-b922-0bce4c578272\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fmut_dau_moc_chau_2.jpg?alt=media\\u0026token=f172742b-2518-4c49-bc2c-ec96aa161dc7\",\"https://https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdau-tay-moc-chau-3.jpg?alt=media\\u0026token=7cd28015-7dcd-43c4-b579-8468b7e9a6e6\"]", "Dâu tây tươi, đường mía, nước cốt chanh", "Hợp tác xã Nông sản Dâu Mộc Châu", "Vitamin C, Chất xơ", "Mộc Châu, Sơn La", 95000.0, 0, "Mứt dâu tây Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "250g" },
                    { new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4006), "Chào mừng bạn ghé thăm gian hàng chính hãng của PHAN NAM FOOD - cửa hàng nông sản sạch an toàn!\r\nPHAN NAM FOOD là hệ thống cửa hàng nông sản sạch chuyên cung cấp các sản phẩm đạt chuẩn OCOP, VietGap cùng những đặc sản tiêu biểu của địa phương nhằm phục vụ nhu cầu tiêu dùng của người dân được tiếp cận với những thực phẩm sạch, tươi ngon. Mong muốn giới thiệu những đặc sản địa phương tới người dân cả nước PHAN NAM FOOD chính thức có mặt trên sàn thương mại điện tử để khách hàng dễ dàng mua hàng, lựa chọn sản phẩm chất lượng cao với giá tốt nhất và được giao hàng tận nơi.\r\n\r\nTheo dõi gian hàng để nhận ngay voucher giảm giá và cập nhật nhiều chương trình khuyến mãi hấp dẫn từ PHAN NAM FOOD các bạn nhé!\r\n----------------------------\r\nTHÔNG TIN SẢN PHẨM: Dầu gội dược liệu Glow THỦY TÙNG 400ml\r\n- Thương hiệu: Thủy Tùng, sản phẩm ocop 3 sao.\r\n- Trọng lượng: 400ml\r\n- Thành phần: Nước, Bồ kết, hương nhu tía, mần trầu, chanh, vỏ bưởi, sả chanh, gừng, tinh dầu vỏ bưởi, tinh dầu sả chanh, dầu dừa.\r\n- Dầu gội chiết xuất từ những dược liệu thiên nhiên giúp chăm sóc và nuôi dưỡng tóc từ gốc đến ngọn, bảo vệ tóc khỏi các tác nhân có hại từ bên ngoài, giúp tóc sạch gàu, suôn mềm, thoáng mát da đầu.\r\n- HSD: 3 năm kể từ ngày sản xuất (NSX xem trên bao bì)\r\n- Hướng Dẫn Sử Dụng: Làm ướt tóc và da đầu, lấy khoảng 3 - 5ml dầu gội sau đó thoa đều và gội từ 3 - 5 phút rồi xả kỹ bằng nước sạch, nên gội thêm lần 2 để có hiệu quả tốt hơn.\r\n- Cách bảo quản: Nơi khô ráo, tránh ánh sáng trực tiếp.\r\n\r\n#daugoiduoclieu #daugọithaoduoc #daugoiboket #daugoikichthichmoctoc #daugoithaoduocantoan", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F42.webp?alt=media\\u0026token=fb9ba94c-fdec-47fb-b782-f145d2b611e7\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F43.webp?alt=media\\u0026token=4b849fd1-6be9-4fa5-846c-c1865071899d\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F44.webp?alt=media\\u0026token=d50897e6-af7d-47bd-bc4b-e8e196dd65af\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F45.webp?alt=media\\u0026token=facf05b2-93fb-4519-b412-b73961492d1f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F46.webp?alt=media\\u0026token=4b7b2e0c-8882-4c0f-86b2-e362dcccabec\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F47.webp?alt=media\\u0026token=47195d9c-a6f1-4416-a67b-cae2ba719f10\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F48.webp?alt=media\\u0026token=5a284068-ab8c-486e-a50a-407e1ed4489d\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F49.webp?alt=media\\u0026token=a0c04528-e4db-427c-984d-f1ef780fd838\"]", null, "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 2, "Dầu gội dược liệu Glow THỦY TÙNG 400ml, dầu gội thảo dược, dầu gội bồ kết OCOP 4 sao | Phan Nam FOOD", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "TourGuide",
                columns: new[] { "GuideId", "Bio", "CreateDate", "ExpertiseArea", "IsAvailable", "Languages", "Rating", "TourCompanyId", "UpdateDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Expert in eco-tourism with 5 years of experience.", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4385), "Eco-farming, fruit orchards", null, "English, French", 4.7999999999999998, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Specialist in sustainable agriculture tours.", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4391), "Tea plantations, organic farming", null, "English, Spanish", 4.5999999999999996, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4391), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Guided over 200 eco-tours with top reviews.", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4399), "Mountain trekking, herbal farming", null, "English, Vietnamese", 4.9000000000000004, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Passionate about agritourism and cultural exchange.", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4403), "Coffee plantations, farm stays", null, "English, German", 4.7000000000000002, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("88888888-8888-8888-8888-888888888888") },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "10 years of experience in eco-tourism industry.", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4407), "Rice farming, eco-tourism", null, "English, Chinese", 4.5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "An expert in organic farming and sustainable tourism.", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4411), "Tea plantations, eco-farms", null, "English, Korean", 4.7999999999999998, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4411), new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc") },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Combining tourism and local culture for unique experiences.", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4415), "Cultural farming, organic coffee", null, "English, Japanese", 4.5999999999999996, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Bringing sustainable travel to the next level.", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4418), "Tropical fruit farms, eco-friendly tours", null, "English, Thai", 4.7000000000000002, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4419), new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd") },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Guiding farm tours with an educational approach.", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4422), "Dairy farming, vineyard tours", null, "English, Portuguese", 4.5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff") },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Committed to authentic rural tourism experiences.", new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4426), "Olive farming, agritourism", null, "English, Italian", 4.9000000000000004, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4426), new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad") }
                });

            migrationBuilder.InsertData(
                table: "TourismPackage",
                columns: new[] { "PackageId", "CreateDate", "Description", "Durations", "DurationsType", "PackageName", "Price", "ReplyRequest", "StatusApproval", "StatusOperating", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5083), "Tham gia gieo trồng rau hữu cơ, thu hoạch nông sản, học cách chăm sóc trâu bò, và dùng cơm trưa với người dân bản địa.", 1.0, 3, "Một ngày làm nông dân vùng biên", 1200000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5085), "Tham gia thu hoạch lúa, ngô, khoai hoặc rau theo mùa; tìm hiểu quy trình chế biến thực phẩm sạch tại trang trại.", 6.0, 2, "Trải nghiệm thu hoạch mùa vụ", 950000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5088), "Kết hợp hoạt động nông nghiệp với giao lưu văn hóa dân tộc Tày - Nùng, thưởng thức các món ăn truyền thống và xem múa hát dân gian.", 2.0, 3, "Khám phá nông nghiệp và văn hóa địa phương", 1800000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5093), "Tham gia làm vườn, chăm sóc cây trồng không hóa chất, nghỉ dưỡng tại homestay chuẩn sinh thái ngay chân núi.", 2.0, 3, "Du lịch canh tác hữu cơ kết hợp nghỉ dưỡng", 2500000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("30000000-0000-0000-0000-000000000001"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5096), "Tham gia trồng rau trên ruộng bậc thang, hái thuốc nam, nấu ăn cùng người bản địa H’Mông tại bản Cát Cát.", 1.0, 3, "Một ngày làm nông dân H'Mông", 1450000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000002"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5099), "Đi bộ xuyên bản Cát Cát, tham quan mô hình trồng dược liệu và rau sạch, trải nghiệm làm giấy thủ công truyền thống.", 8.0, 2, "Hành trình khám phá bản làng và nông nghiệp hữu cơ", 1650000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000003"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5101), "Nghỉ dưỡng tại homestay trong thung lũng Mường Hoa, tham gia thu hoạch rau, chế biến món ăn dân tộc và giao lưu văn nghệ.", 2.0, 3, "Farmstay Sa Pa 2N1Đ", 2700000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000004"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5103), "Kết hợp tham quan chợ phiên Sa Pa với trải nghiệm gieo trồng, hái rau và học chế biến món ăn đặc sản.", 1.0, 3, "Chợ phiên & nông nghiệp vùng cao", 1100000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5072), "Trải nghiệm làm nông dân tại nông trại: hái dâu, vắt sữa bò, tham quan vườn rau hữu cơ, dùng bữa trưa đặc sản.", 6.0, 2, "Khám phá nông nghiệp Mộc Châu", 3500000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5079), "Trải nghiệm canh tác nông nghiệp sạch: chăm vườn rau, thu hoạch cà chua, nấm và tìm hiểu quy trình đóng gói sản phẩm OCOP.", 1.0, 3, "Một ngày làm nông dân OCOP", 3200000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5076), "Tham quan đồi chè xanh mướt, trải nghiệm hái chè, quy trình chế biến chè thủ công và thưởng thức trà OCOP Mộc Châu.", 4.0, 2, "Tour hái chè và thưởng trà OCOP", 2800000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5081), "Kết hợp hoạt động từ thiện tại bản làng với trải nghiệm trồng cây xanh, chăm sóc vườn hoa và chế biến thực phẩm từ nông sản địa phương.", 2.0, 3, "Du lịch thiện nguyện & nông nghiệp xanh", 4000000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "ActivityId", "ActivityName", "BreakTimeInMinutes", "BreakTimeInMinutesType", "CreateDate", "Description", "DurationInHours", "DurationInHoursType", "Imgs", "Location", "MaxCapacity", "PackageId", "ReplyRequest", "StatusApproval", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"), "Chăm sóc vườn hoa và cây cảnh", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5295), "Du khách sẽ tham gia chăm sóc vườn hoa, cắt tỉa và trang trí cây cảnh, tạo không gian xanh cho khu vực du lịch.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media\\u0026token=d34657e1-2aae-4b60-a825-a7319b98235b\"]", "Vườn hoa du lịch – Mộc Châu", null, new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"), "Tham quan đồi chè Mộc Châu", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5215), "Hướng dẫn viên dẫn du khách khám phá vẻ đẹp đồi chè xanh mướt, giới thiệu về lịch sử và đặc sản chè của vùng đất Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche1.jpg?alt=media\\u0026token=e454fa0e-1e95-4b66-9d28-d9de2bf107d0\"]", "Đồi chè trái tim – Mộc Châu", null, new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"), "Hoạt động từ thiện tại bản làng", 30.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5287), "Du khách tham gia các hoạt động thiện nguyện tại bản làng, giúp đỡ bà con địa phương với các công việc như sửa chữa nhà cửa, tặng quà cho trẻ em, hoặc tổ chức các hoạt động vui chơi.", 4.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdulich1.jpg?alt=media\\u0026token=d95f8ea1-e72d-4d74-ace7-defb632ef2a8\"]", "Bản làng vùng cao Mộc Châu", null, new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), "Tham quan nông trại dâu tây", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5174), "Du khách được hướng dẫn tham quan nông trại dâu, tìm hiểu quy trình trồng dâu và tự tay hái dâu chín.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdau%201.jpg?alt=media\\u0026token=37e256ac-3428-4dde-9923-a4ab34d79416\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdau2.webp?alt=media\\u0026token=60ffaa7a-600a-41f6-9997-b01f487965a3\"]", "Nông trại Dâu Mộc Châu – Bản Áng", null, new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"), "Chế biến thực phẩm từ nông sản địa phương", 20.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5299), "Du khách sẽ học cách chế biến các món ăn đặc sản từ nông sản địa phương như rau, quả, thịt tươi và các sản phẩm OCOP.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media\\u0026token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96\"]", "Xưởng chế biến thực phẩm – Mộc Châu", null, new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"), "Chăm sóc vườn rau hữu cơ", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5263), "Du khách sẽ được hướng dẫn cách chăm sóc các loại rau sạch như cải, xà lách, rau mùi... trong vườn hữu cơ của trang trại.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media\\u0026token=d34657e1-2aae-4b60-a825-a7319b98235b\"]", "Vườn rau hữu cơ – Mộc Châu", null, new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"), "Tham gia chế biến chè thủ công", 5.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5249), "Học cách sao chè, vò chè và sấy khô theo phương pháp truyền thống cùng nghệ nhân địa phương.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media\\u0026token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96\"]", "Xưởng chè OCOP Mộc Châu", null, new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"), "Trồng cây xanh tại khu vực du lịch", 20.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5292), "Du khách sẽ tham gia vào các hoạt động trồng cây xanh, giúp bảo vệ môi trường và tạo cảnh quan xanh cho khu vực du lịch.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftrongcay1.webp?alt=media\\u0026token=cbaae9c7-aa33-4943-a297-b1e3d2f95d58\"]", "Khu du lịch Mộc Châu", null, new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"), "Vắt sữa bò tại trang trại", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5202), "Trải nghiệm vắt sữa bò, cho bò ăn và tìm hiểu quy trình sản xuất sữa tươi đặc sản Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua1.jpg?alt=media\\u0026token=680679bc-ae88-495c-b39b-35205cdca5c1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua2.jpg?alt=media\\u0026token=29672e8d-f9af-4be5-aa8c-9e7922fa3a9f\"]", "Trang trại bò sữa Dairy Farm", null, new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000001"), "Gieo trồng rau hữu cơ", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5304), "Hướng dẫn kỹ thuật gieo hạt, làm đất và chăm sóc rau theo phương pháp hữu cơ tại nông trại vùng cao.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media\\u0026token=26a27576-3ee8-45e5-b4bd-0dfbac591c77\"]", "Nông trại hữu cơ – xã biên giới", null, new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000002"), "Thu hoạch nông sản", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5311), "Trải nghiệm thu hoạch rau củ quả đúng vụ, phân loại và sơ chế tại chỗ theo hướng dẫn của người dân bản địa.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcachua1.jpg?alt=media\\u0026token=13165082-87a3-46d1-bc9c-8d08acebc905\"]", "Ruộng nông sản – xã biên giới", null, new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000003"), "Chăm sóc trâu bò", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5315), "Học cách tắm rửa, cho ăn và dắt trâu ra đồng cùng người dân – trải nghiệm đời sống chăn nuôi thực tế.", 0.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua1.jpg?alt=media\\u0026token=680679bc-ae88-495c-b39b-35205cdca5c1\"]", "Chuồng trại địa phương", null, new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000004"), "Dùng cơm trưa với người dân bản địa", 0.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5318), "Thưởng thức bữa cơm dân dã tại nhà người dân với các món đặc sản vùng cao: măng xào, cá suối nướng, cơm lam...", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media\\u0026token=9500933b-9b09-4e07-a3b7-8d3899347fe7\"]", "Nhà sàn truyền thống", null, new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000001"), "Thu hoạch mùa vụ", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5322), "Tham gia thu hoạch lúa, ngô, khoai hoặc rau theo mùa cùng với nông dân địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Flua.webp?alt=media\\u0026token=2c6a3258-acda-42d4-8a5a-9122a700047a\"]", "Cánh đồng hợp tác xã biên giới", null, new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000002"), "Sơ chế và bảo quản thực phẩm", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5326), "Học cách phân loại, sơ chế và bảo quản thực phẩm thu hoạch được bằng phương pháp thủ công và tự nhiên.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche1.jpg?alt=media\\u0026token=e454fa0e-1e95-4b66-9d28-d9de2bf107d0\"]", "Nhà sơ chế tại trang trại", null, new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000003"), "Thưởng thức sản phẩm sạch tại chỗ", 5.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5330), "Dùng thử các món ăn chế biến từ chính nông sản vừa thu hoạch như ngô luộc, khoai nướng, rau luộc chấm muối vừng.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftra1.jpg?alt=media\\u0026token=d4fa66e3-818a-4641-a3d8-95f75b586fa5\"]", "Khu vực ăn uống ngoài trời", null, new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000004"), "Giao lưu văn nghệ và chia sẻ", 0.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5335), "Giao lưu với người dân bản địa, nghe chia sẻ về đời sống sản xuất nông nghiệp và văn hóa vùng cao.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media\\u0026token=c9a1233d-7fd4-485b-92af-2d662e830cae\"]", "Sân cộng đồng xã", null, new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000001"), "Trồng rau trên ruộng bậc thang", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5377), "Trải nghiệm làm nông cùng người H'Mông: cuốc đất, gieo hạt và chăm sóc rau trên ruộng bậc thang.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fbacthang.webp?alt=media\\u0026token=1090ca2a-4ec4-4de7-99cf-316da2719b9d\"]", "Ruộng bậc thang bản Cát Cát", null, new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000002"), "Hái và phân loại thuốc nam", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5396), "Cùng người bản địa đi hái các loại cây thuốc nam đặc trưng vùng cao, học cách phân loại và sử dụng.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam1.jpg?alt=media\\u0026token=0c350e96-b627-4792-87e7-45d0502309e4\"]", "Khu rừng ven bản", null, new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000003"), "Nấu ăn cùng người H'Mông", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5401), "Tham gia chuẩn bị bữa trưa với các món ăn truyền thống của người H'Mông, sử dụng nguyên liệu địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media\\u0026token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af\"]", "Nhà truyền thống H'Mông, bản Cát Cát", null, new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000004"), "Đi bộ khám phá bản Cát Cát", 20.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5405), "Hành trình đi bộ qua các con đường lát đá, tìm hiểu kiến trúc nhà truyền thống và đời sống người H'Mông.", 2.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdibo1.png?alt=media\\u0026token=85dab42a-d4de-4155-b10f-dcb86020ddbd\"]", "Bản Cát Cát", null, new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000005"), "Tham quan mô hình nông nghiệp hữu cơ", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5409), "Tìm hiểu quy trình trồng rau sạch, dược liệu không hóa chất và chăm sóc vườn theo tiêu chuẩn hữu cơ.", 2.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvuon1.jpg?alt=media\\u0026token=bca13e04-6ddc-4abc-aeea-ceb3544c67c4\"]", "Vườn hữu cơ bản Cát Cát", null, new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000006"), "Trải nghiệm làm giấy thủ công", 20.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5416), "Tự tay chế tác giấy dó từ nguyên liệu tự nhiên, học cách in họa tiết dân tộc truyền thống.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fgiay1.webp?alt=media\\u0026token=8d97fe12-81fb-4baf-bca6-2310db5d10a6\"]", "Xưởng giấy thủ công trong bản", null, new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000007"), "Nghỉ dưỡng tại homestay Mường Hoa", 30.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5420), "Thư giãn tại homestay trong thung lũng Mường Hoa với view ruộng bậc thang, tận hưởng không khí trong lành và yên tĩnh.", 6.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fsinhthai.jpg?alt=media\\u0026token=e9eca292-9a58-49e7-851a-985a7c2fcc99\"]", "Homestay Mường Hoa", null, new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000008"), "Trải nghiệm thu hoạch và nấu ăn", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5425), "Tham gia thu hoạch rau củ tại vườn và cùng người bản địa nấu các món ăn truyền thống như thắng cố, lợn cắp nách, cá suối nướng.", 4.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media\\u0026token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af\"]", "Vườn rau & gian bếp homestay", null, new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000009"), "Giao lưu văn nghệ bản địa", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5429), "Thưởng thức các tiết mục múa hát dân tộc, tham gia múa sạp, múa chuông và uống rượu ngô cùng người dân địa phương.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media\\u0026token=c9a1233d-7fd4-485b-92af-2d662e830cae\"]", "Sân sinh hoạt cộng đồng tại bản", null, new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000010"), "Tham quan chợ phiên Sa Pa", 30.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5434), "Khám phá chợ phiên truyền thống với các gian hàng thổ cẩm, dược liệu, đặc sản vùng cao và giao lưu với người dân bản địa.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcho-vung-cao.jpg?alt=media\\u0026token=fb63de66-558d-4ab7-8aae-829750571863\"]", "Chợ trung tâm Sa Pa", null, new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000011"), "Trải nghiệm gieo trồng và thu hoạch", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5437), "Tham gia gieo hạt, chăm sóc rau theo phương pháp truyền thống của người dân tộc thiểu số và tự tay thu hoạch nông sản.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau2.jpg?alt=media\\u0026token=146de905-406d-4ef8-8ddd-8aa978e38123\"]", "Vườn rau bản Tả Phìn", null, new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000012"), "Học nấu món ăn đặc sản vùng cao", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5445), "Hướng dẫn chế biến các món ăn đặc trưng của người H’Mông như thắng cố, cải mèo luộc chấm chẩm chéo và thịt trâu gác bếp.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media\\u0026token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af\"]", "Bếp cộng đồng trong bản", null, new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000001"), "Trải nghiệm trồng trọt địa phương", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5341), "Tham gia các công việc nông nghiệp truyền thống như trồng rau, làm đất, tưới tiêu cùng người dân.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media\\u0026token=c9a1233d-7fd4-485b-92af-2d662e830cae\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdulich1.jpg?alt=media\\u0026token=d95f8ea1-e72d-4d74-ace7-defb632ef2a8\"]", "Cánh đồng bản Tày", null, new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000002"), "Thưởng thức món ăn truyền thống", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5345), "Dùng bữa với các món ăn dân tộc như khẩu sli, thắng cố, lạp xưởng, và rượu ngô bản địa.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media\\u0026token=9500933b-9b09-4e07-a3b7-8d3899347fe7\"]", "Nhà sàn truyền thống", null, new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000003"), "Giao lưu văn hóa dân gian", 5.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5349), "Tham gia đêm giao lưu văn nghệ với các tiết mục múa khèn, hát then, hát lượn đặc trưng dân tộc Tày - Nùng.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdangian.jpg?alt=media\\u0026token=7df3d302-ee8c-454b-a2b6-36951632720a\"]", "Sân nhà văn hóa bản", null, new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000004"), "Thăm quan làng nghề truyền thống", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5355), "Khám phá làng nghề làm hương, dệt thổ cẩm và thủ công mỹ nghệ bản địa.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdet.jpg?alt=media\\u0026token=648cbac8-add0-4056-a2a3-44d5241ed9ed\"]", "Làng nghề Tày - Nùng", null, new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000001"), "Hướng dẫn canh tác hữu cơ", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5359), "Tham gia buổi giới thiệu quy trình trồng rau, hoa quả theo hướng hữu cơ không sử dụng thuốc trừ sâu hóa học.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media\\u0026token=d34657e1-2aae-4b60-a825-a7319b98235b\"]", "Trang trại sinh thái hữu cơ", null, new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000002"), "Trải nghiệm làm vườn hữu cơ", 15.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5363), "Tự tay gieo hạt, chăm sóc rau và thu hoạch sản phẩm sạch theo hướng dẫn của người dân địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media\\u0026token=26a27576-3ee8-45e5-b4bd-0dfbac591c77\"]", "Vườn rau hữu cơ", null, new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000003"), "Nghỉ dưỡng tại homestay sinh thái", 30.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5366), "Thư giãn tại homestay thân thiện với môi trường, sử dụng năng lượng tái tạo, có view rừng và núi.", 6.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fsinhthai.jpg?alt=media\\u0026token=e9eca292-9a58-49e7-851a-985a7c2fcc99\"]", "Homestay chân núi Pù Luông", null, new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000004"), "Chế biến món ăn từ nông sản hữu cơ", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5369), "Học nấu các món ăn truyền thống từ nguyên liệu hữu cơ tự tay thu hoạch.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media\\u0026token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96\"]", "Khu bếp homestay", null, new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"), "Tham quan và thu hoạch rau hữu cơ", 5.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5207), "Hướng dẫn chăm sóc, thu hoạch rau sạch, tìm hiểu kỹ thuật canh tác hữu cơ chuẩn OCOP.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media\\u0026token=26a27576-3ee8-45e5-b4bd-0dfbac591c77\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau2.jpg?alt=media\\u0026token=146de905-406d-4ef8-8ddd-8aa978e38123\"]", "Trang trại rau hữu cơ Mộc Châu Xanh", null, new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"), "Trải nghiệm hái chè", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5242), "Du khách mặc trang phục truyền thống, tự tay hái những lá chè non, tìm hiểu về cách chọn lựa lá chè ngon.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche2.webp?alt=media\\u0026token=0275c711-2581-48c0-9e13-bcc383b8cfe2\"]", "Đồi chè Thanh Bình – Mộc Châu", null, new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"), "Thưởng thức trà OCOP", 0.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5259), "Tham gia buổi thưởng trà, trải nghiệm các loại trà đạt chuẩn OCOP cùng bánh ngọt địa phương.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftra1.jpg?alt=media\\u0026token=d4fa66e3-818a-4641-a3d8-95f75b586fa5\"]", "Không gian trà đạo Mộc Châu", null, new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"), "Tìm hiểu quy trình đóng gói sản phẩm OCOP", 5.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5282), "Hướng dẫn du khách quy trình đóng gói sản phẩm OCOP, từ khâu vệ sinh, đóng gói đến dán nhãn và vận chuyển sản phẩm.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhop1.jpg?alt=media\\u0026token=9dd3a3ac-52cb-4632-81aa-91a90dec35d0\"]", "Xưởng sản xuất nông sản OCOP Mộc Châu", null, new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"), "Thu hoạch và chế biến nấm", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5271), "Du khách sẽ được tham gia thu hoạch nấm và tìm hiểu quy trình chế biến nấm thành các sản phẩm tươi ngon.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam1.jpg?alt=media\\u0026token=0c350e96-b627-4792-87e7-45d0502309e4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam2.jpg?alt=media\\u0026token=04893537-abb2-4936-ba89-6e26b4b54aea\"]", "Trang trại nấm – Mộc Châu", null, new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"), "Thu hoạch cà chua", 10.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5267), "Du khách tham gia thu hoạch cà chua từ vườn, học cách lựa chọn quả chín và chuẩn bị sản phẩm cho việc đóng gói.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcachua1.jpg?alt=media\\u0026token=13165082-87a3-46d1-bc9c-8d08acebc905\"]", "Vườn cà chua – Mộc Châu", null, new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"), "Dùng bữa trưa đặc sản Mộc Châu", 0.0, 1, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(5211), "Thưởng thức các món ăn chế biến từ nguyên liệu sạch địa phương như bê chao, cá suối, rau rừng, sữa chua Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media\\u0026token=9500933b-9b09-4e07-a3b7-8d3899347fe7\"]", "Nhà hàng Truyền thống Bản Áng", null, new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("14a30005-40f6-43f5-b046-a0c5c04e5a4f"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4853), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4852), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4852), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("2ed549d7-0446-4a10-9913-09c124f74e88"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4848), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4847), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4847), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("36ed6e69-fd96-45df-9d63-1aee2f1697e6"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4833), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4833), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4832), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("5140c9bd-4d96-4c8a-84b5-608ae43cee11"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4821), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4820), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4820), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("697301e9-11bb-4bc3-86c2-79d5be5d61fc"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4843), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4843), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4842), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8f27d3b4-6073-4e70-ac89-94b3bb2d39d3"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4814), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4812), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4811), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c143c86f-d7d6-4add-89ef-138af767cfba"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4828), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4828), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4827), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ed1e9728-11cf-43ab-9e5a-58f927a3911d"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4838), new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4838), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 17, 12, 56, 34, 474, DateTimeKind.Local).AddTicks(4837), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "ActiveStatus", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("10f0ddc7-fbbc-4d4c-af55-36b9c0d99d91"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4341), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 87000.0, 1000.0, null },
                    { new Guid("11baef63-4123-40fe-bb09-ab46a13fcf8c"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4504), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 90000.0, 1000.0, null },
                    { new Guid("23774c46-5b12-4cfa-a83e-e1ad61c840cc"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4411), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 92000.0, 1000.0, null },
                    { new Guid("258af993-2b20-4863-8b7d-94488dfdab63"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4588), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 90000.0, 1000.0, null },
                    { new Guid("2753397f-371a-445a-99f1-820bf5867e63"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4653), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 130000.0, 1000.0, null },
                    { new Guid("2bfd39ab-321f-4389-b53d-a345091aca50"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4639), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 10000.0, 1000.0, null },
                    { new Guid("35713987-4cfa-4a20-b622-b3bf5f5dd902"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4596), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 40000.0, 1000.0, null },
                    { new Guid("363068d8-a3f1-4ca5-a91e-8d93ae919dad"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4355), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 87000.0, 1000.0, null },
                    { new Guid("3c3fd91e-8f86-4425-8bae-10364617720b"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4498), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 120000.0, 1000.0, null },
                    { new Guid("48331137-66a5-46bf-97eb-cc96d96d65fb"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4348), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 85000.0, 1000.0, null },
                    { new Guid("50bc6337-7c92-4d8e-9f98-f16971f81a26"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4660), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 70000.0, 1000.0, null },
                    { new Guid("54fdddfd-a19f-409c-8ef0-2f2020602e57"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4717), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 10000.0, 1000.0, null },
                    { new Guid("570c1764-9ec6-45cd-a8e8-7a639cd84c1a"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4668), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 130000.0, 1000.0, null },
                    { new Guid("5a48f7fb-22a9-40f1-818d-230e11bb0e86"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4579), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 80000.0, 1000.0, null },
                    { new Guid("5cc130d3-2358-4ac6-a8f2-d5a398319445"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4630), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 90000.0, 1000.0, null },
                    { new Guid("5e9062d4-6813-4ee0-bce9-a8d7c976254c"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4681), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 80000.0, 1000.0, null },
                    { new Guid("6f773a13-610f-4bf4-9779-1a0f99eef2c5"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4622), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 130000.0, 1000.0, null },
                    { new Guid("7f80564a-7856-4711-b771-dde16846e538"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4602), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 60000.0, 1000.0, null },
                    { new Guid("82496b7e-a47f-4923-b9ea-0dc278585ac9"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4403), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 92000.0, 1000.0, null },
                    { new Guid("82c4357f-471b-4ded-aedf-0b3269d0965a"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4484), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 40000.0, 1000.0, null },
                    { new Guid("86bfaf8e-fe69-4ec0-9e5b-755d1dd6651f"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4729), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 110000.0, 1000.0, null },
                    { new Guid("a1c9f8cc-d31b-4ff7-b587-fcd65ec936cf"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4456), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 120000.0, 1000.0, null },
                    { new Guid("aa59549a-d00b-40d5-bbd3-498e2dbc663c"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4615), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 10000.0, 1000.0, null },
                    { new Guid("ae501b61-89be-46ab-a341-c6d43b273174"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4723), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 110000.0, 1000.0, null },
                    { new Guid("aed11647-df53-44aa-902e-095d5f0ca33b"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4704), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 110000.0, 1000.0, null },
                    { new Guid("bdb8fdbe-72eb-4b4d-b793-a4a16279bc5c"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4609), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 60000.0, 1000.0, null },
                    { new Guid("be0b683c-218b-4896-b397-3d3b72208969"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4469), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 120000.0, 1000.0, null },
                    { new Guid("dd0664f3-6e85-4143-8ba1-70df96cb1b45"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4689), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 80000.0, 1000.0, null },
                    { new Guid("ea5ea182-ebac-4457-8c4c-dfa96314bb2a"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4463), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 10000.0, 1000.0, null },
                    { new Guid("eaa48693-2cf6-4e1a-8662-7bd6dccef60a"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4646), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 10000.0, 1000.0, null },
                    { new Guid("eac31522-3c6a-4bec-bbf5-0706bea6d96b"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4329), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 85000.0, 1000.0, null },
                    { new Guid("ec92f341-e391-46b9-b471-317a1af7b09c"), true, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4422), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 92000.0, 1000.0, null },
                    { new Guid("ee47573a-5fe2-4f50-b274-2c796215e728"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4491), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 40000.0, 1000.0, null },
                    { new Guid("f0ac17e6-b5a8-4097-a446-7c5a1f75be16"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4674), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 70000.0, 1000.0, null },
                    { new Guid("f823c0da-6f58-4707-87fb-c17efdf3e044"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4710), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 70000.0, 1000.0, null },
                    { new Guid("fc7b19d7-2723-473d-b064-47afec0339fe"), null, new DateTime(2025, 5, 17, 5, 56, 34, 474, DateTimeKind.Utc).AddTicks(4697), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 10000.0, 1000.0, null }
                });

            migrationBuilder.InsertData(
                table: "TourDestination",
                columns: new[] { "TourDestinationId", "AccommodationId", "ActivityId", "CheckInDate", "CheckOutDate", "CreateDate", "Description", "DriverId", "EndTime", "ReplyRequest", "StartTime", "StatusApproval", "Title", "TourId", "TourismPackageId", "TypeActivity", "UpdateDate", "VisitOrder" },
                values: new object[,]
                {
                    { new Guid("64000000-0000-0000-0000-000000000002"), null, null, null, null, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4518), "Tham quan và trải nghiệm tại trang trại bò sữa Dairy Farm", null, new DateTime(2025, 5, 10, 11, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, "Trải nghiệm tại trang trại bò sữa", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 2, null, 3 },
                    { new Guid("64000000-0000-0000-0000-000000000003"), null, null, null, null, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4521), "Tham quan và trải nghiệm tại trang trại rau hữu cơ Mộc Châu Xanh", null, new DateTime(2025, 5, 10, 12, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), 0, "Khám phá vườn rau hữu cơ", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 2, null, 4 },
                    { new Guid("64000000-0000-0000-0000-000000000004"), null, null, null, null, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4500), "Xe 45 chỗ đón khách tại điểm hẹn và di chuyển đến Mộc Châu", new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 6, 0, 0, 0, DateTimeKind.Unspecified), 0, "Di chuyển đến Mộc Châu", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 1, null, 1 },
                    { new Guid("64000000-0000-0000-0000-000000000005"), null, null, null, null, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4533), "Di chuyển giữa các điểm tham quan trong khu vực Mộc Châu", new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, "Di chuyển giữa các điểm tham quan", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 1, null, 6 },
                    { new Guid("64000000-0000-0000-0000-000000000006"), new Guid("10000000-0000-0000-0000-000000000011"), null, null, null, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4524), "Nghỉ ngơi và dùng bữa trưa tại khách sạn 5 sao TherHouse, trung tâm Mộc Châu", null, new DateTime(2025, 5, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, "Nghỉ trưa tại khách sạn TherHouse", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null, 5 }
                });

            migrationBuilder.InsertData(
                table: "ActivityProduct",
                columns: new[] { "ActivityId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55") },
                    { new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17") },
                    { new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18") },
                    { new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988") }
                });

            migrationBuilder.InsertData(
                table: "TourDestination",
                columns: new[] { "TourDestinationId", "AccommodationId", "ActivityId", "CheckInDate", "CheckOutDate", "CreateDate", "Description", "DriverId", "EndTime", "ReplyRequest", "StartTime", "StatusApproval", "Title", "TourId", "TourismPackageId", "TypeActivity", "UpdateDate", "VisitOrder" },
                values: new object[] { new Guid("64000000-0000-0000-0000-000000000001"), null, new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), null, null, new DateTime(2025, 5, 17, 5, 56, 34, 478, DateTimeKind.Utc).AddTicks(4514), "Tham quan và trải nghiệm tại nông trại dâu tây Bản Áng", null, new DateTime(2025, 5, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 8, 15, 0, 0, DateTimeKind.Unspecified), 0, "Tham quan nông trại dâu tây", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), 2, null, 2 });

            migrationBuilder.CreateIndex(
                name: "IX_Accommodation_TourCompanyId",
                table: "Accommodation",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Activity_PackageId",
                table: "Activity",
                column: "PackageId");

            migrationBuilder.CreateIndex(
                name: "IX_ActivityProduct_ProductId",
                table: "ActivityProduct",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminBalance_BookingId",
                table: "AdminBalance",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_AdminBalance_OrderId",
                table: "AdminBalance",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_AgriculturalTourPackage_TourCompanyId",
                table: "AgriculturalTourPackage",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_AgriculturalTourPackageTourGuide_TourGuidesGuideId",
                table: "AgriculturalTourPackageTourGuide",
                column: "TourGuidesGuideId");

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CreateBy",
                table: "Blog",
                column: "CreateBy");

            migrationBuilder.CreateIndex(
                name: "IX_BookingAgriculturalTour_CustomerId",
                table: "BookingAgriculturalTour",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingAgriculturalTour_TourId",
                table: "BookingAgriculturalTour",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTourDestination_BookingAgriculturalTourBookingId",
                table: "BookingTourDestination",
                column: "BookingAgriculturalTourBookingId");

            migrationBuilder.CreateIndex(
                name: "IX_BookingTourDestination_TourDestinationId",
                table: "BookingTourDestination",
                column: "TourDestinationId");

            migrationBuilder.CreateIndex(
                name: "IX_Certification_ProductId",
                table: "Certification",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Certification_TouristFacilityId",
                table: "Certification",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_TourCompanyId",
                table: "Contract",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_Contract_TouristFacilityId",
                table: "Contract",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Driver_TourCompanyId",
                table: "Driver",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_FacilityCertification_TouristFacilityId",
                table: "FacilityCertification",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_ProductId",
                table: "Feedback",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_TourId",
                table: "Feedback",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_Feedback_UserId",
                table: "Feedback",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_OCOPSell_ProductId",
                table: "OCOPSell",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_BookingId",
                table: "Order",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_Order_CustomerId",
                table: "Order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_OrderDetail_ProductId",
                table: "OrderDetail",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Product_TouristFacilityId",
                table: "Product",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleClaims_RoleId",
                table: "RoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_ShipAddress_AccountId",
                table: "ShipAddress",
                column: "AccountId");

            migrationBuilder.CreateIndex(
                name: "IX_TourCompany_UserId",
                table: "TourCompany",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TourDestination_AccommodationId",
                table: "TourDestination",
                column: "AccommodationId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDestination_ActivityId",
                table: "TourDestination",
                column: "ActivityId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDestination_DriverId",
                table: "TourDestination",
                column: "DriverId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDestination_TourId",
                table: "TourDestination",
                column: "TourId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDestination_TourismPackageId",
                table: "TourDestination",
                column: "TourismPackageId");

            migrationBuilder.CreateIndex(
                name: "IX_TourDestinationTourGuide_TourGuidesGuideId",
                table: "TourDestinationTourGuide",
                column: "TourGuidesGuideId");

            migrationBuilder.CreateIndex(
                name: "IX_TourGuide_TourCompanyId",
                table: "TourGuide",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TourGuide_UserId",
                table: "TourGuide",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_TourismPackage_TourCompanyId",
                table: "TourismPackage",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_TourismPackage_TouristFacilityId",
                table: "TourismPackage",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_TouristFacility_UserId",
                table: "TouristFacility",
                column: "UserId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserClaims_UserId",
                table: "UserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_RoleId",
                table: "UserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_UserSupport_ResponeBy",
                table: "UserSupport",
                column: "ResponeBy");

            migrationBuilder.CreateIndex(
                name: "IX_UserSupport_TouristFacilityId",
                table: "UserSupport",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_VNPayPaymentResponse_BookingId",
                table: "VNPayPaymentResponse",
                column: "BookingId");

            migrationBuilder.CreateIndex(
                name: "IX_VNPayPaymentResponse_OrderId",
                table: "VNPayPaymentResponse",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawalHistory_TourCompanyId",
                table: "WithdrawalHistory",
                column: "TourCompanyId");

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawalHistory_TouristFacilityId",
                table: "WithdrawalHistory",
                column: "TouristFacilityId");

            migrationBuilder.CreateIndex(
                name: "IX_WithdrawalRequest_UserId",
                table: "WithdrawalRequest",
                column: "UserId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "About");

            migrationBuilder.DropTable(
                name: "ActivityProduct");

            migrationBuilder.DropTable(
                name: "AdminBalance");

            migrationBuilder.DropTable(
                name: "AgriculturalTourPackageTourGuide");

            migrationBuilder.DropTable(
                name: "BankAccount");

            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DropTable(
                name: "BookingTourDestination");

            migrationBuilder.DropTable(
                name: "Certification");

            migrationBuilder.DropTable(
                name: "Contract");

            migrationBuilder.DropTable(
                name: "FacilityCertification");

            migrationBuilder.DropTable(
                name: "Feedback");

            migrationBuilder.DropTable(
                name: "OCOPSell");

            migrationBuilder.DropTable(
                name: "OrderDetail");

            migrationBuilder.DropTable(
                name: "RoleClaims");

            migrationBuilder.DropTable(
                name: "ShipAddress");

            migrationBuilder.DropTable(
                name: "SystemConfigurations");

            migrationBuilder.DropTable(
                name: "TourDestinationTourGuide");

            migrationBuilder.DropTable(
                name: "UserClaims");

            migrationBuilder.DropTable(
                name: "UserIssue");

            migrationBuilder.DropTable(
                name: "UserLogins");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "UserSupport");

            migrationBuilder.DropTable(
                name: "UserTokens");

            migrationBuilder.DropTable(
                name: "VNPayPaymentResponse");

            migrationBuilder.DropTable(
                name: "WithdrawalHistory");

            migrationBuilder.DropTable(
                name: "WithdrawalRequest");

            migrationBuilder.DropTable(
                name: "Product");

            migrationBuilder.DropTable(
                name: "TourDestination");

            migrationBuilder.DropTable(
                name: "TourGuide");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Order");

            migrationBuilder.DropTable(
                name: "Accommodation");

            migrationBuilder.DropTable(
                name: "Activity");

            migrationBuilder.DropTable(
                name: "Driver");

            migrationBuilder.DropTable(
                name: "BookingAgriculturalTour");

            migrationBuilder.DropTable(
                name: "TourismPackage");

            migrationBuilder.DropTable(
                name: "AgriculturalTourPackage");

            migrationBuilder.DropTable(
                name: "TouristFacility");

            migrationBuilder.DropTable(
                name: "TourCompany");

            migrationBuilder.DropTable(
                name: "Account");
        }
    }
}
