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
                    GroupId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    TourGuidIds = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DriverIds = table.Column<string>(type: "nvarchar(max)", nullable: true)
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
                    { new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), 0, null, "62a18241-1a69-4b2b-ac1a-3260b5592d99", null, "truongthu112201@gmail.com", true, "Tourism Companies", null, false, null, "TRUONGTHU112201@GMAIL.COM", "TOURISMCOMPANIES", "AQAAAAIAAYagAAAAEE2O2BkjDUhyFwwvXC5avDin+8cLxYiKajVpIi09j+0BfAgjlHAifteCK3aErK/vdg==", null, false, "f3a393b2-0c77-42f0-b314-e5bf68be0230", false, "TourismCompanies", true },
                    { new Guid("10000000-0000-0000-0000-000000000001"), 0, null, "073524f9-e878-4d71-b905-22a5a1cad812", null, "bangiocfarmtour@gmail.com", true, "Du Lịch Sinh Thái Thác Bản Giốc", null, false, null, "bangiocfarmtour@GMAIL.COM", "bangiocfarmtour", "AQAAAAIAAYagAAAAEAxU5Tm8TV3ePNhjFjt8VyGwZVRY6QRjVTPlgF1IqpozE3MXErKVBucEpkcYv46x3Q==", null, false, "a819361d-5483-4cff-a085-819aca096089", false, "bangiocfarmtour", true },
                    { new Guid("10000000-0000-0000-0000-000000000002"), 0, null, "7e67f9b3-f586-48ab-aedb-321fc4cb693e", null, "sapa@gmail.com", true, "Sa Pa Eco Farm Tour", null, false, null, "sapa@GMAIL.COM", "sapa", "AQAAAAIAAYagAAAAECH3CozKzVbpOiJCOc1VxtQmoy/lDf5TlsUBH8nI1LIlUdKXrQYm95L4ILMbcoOFjw==", null, false, "96ef528b-e8a0-4edb-8c76-0df8e224a4e2", false, "sapa", true },
                    { new Guid("10000000-0000-0000-0000-000000000003"), 0, null, "5548c897-270d-4c15-8a77-0dbcdfc43510", null, "grapevalley@gmail.com", true, "Farm Du Lịch Grape Valley", null, false, null, "grapevalley@GMAIL.COM", "grapevalley", "AQAAAAIAAYagAAAAEG56E+Db6IOxQwTE/cV8fgwhtn7hl7L2a/cqzp0SGtlcQTUpK6cDdTo9tiabzkpXhw==", null, false, "dc0c9ae1-2aac-4b16-80e2-bbb8dc7c5077", false, "grapevalley", true },
                    { new Guid("10000000-0000-0000-0000-000000000004"), 0, null, "dc905034-ddc0-437d-97c2-1c4bc185310d", null, "daitu@gmail.com", true, "Nông Trại Chè Trải Nghiệm Đại Từ", null, false, null, "daitu@GMAIL.COM", "daitu", "AQAAAAIAAYagAAAAEKE1zLx5snFjq8U5F/phOu33uvdAnaOihWjpGzckzzishaigCz6sK0gr+9mKg5wOvA==", null, false, "31d44e00-abb5-46b1-9cae-092f92be34c4", false, "daitu", true },
                    { new Guid("10000000-0000-0000-0000-000000000005"), 0, null, "22cbae87-0b7d-4c42-bdd3-96f55530b948", null, "buondoncoffee@gmail.com", true, "Buôn Đôn Coffee Farm Tour", null, false, null, "buondoncoffee@GMAIL.COM", "buondoncoffee", "AQAAAAIAAYagAAAAEGXiQdhLVG5StdOpqJB0df6hQ0yeiamIsyYiCeoywVxOcwRTMvAu0yBNygScF4skzg==", null, false, "5bcdfe46-f918-48b8-870d-42219fa0523a", false, "buondoncoffee", true },
                    { new Guid("10000000-0000-0000-0000-000000000006"), 0, null, "56215d78-2fad-4071-92fe-a9dd6b89df0c", null, "hagiang@gmail.com", true, "Hà Giang Farmstay & Trek", null, false, null, "hagiang@GMAIL.COM", "hagiang", "AQAAAAIAAYagAAAAEMuSKFMzKxkVCPkXLPTIuzWDr1ZUoG3rKhhKISMgNfggU03MopDYBbtUrXJ+jclJLg==", null, false, "9e18d9a7-a345-47fd-89af-8e8c2eee7e78", false, "hagiang", true },
                    { new Guid("10000000-0000-0000-0000-000000000007"), 0, null, "9e6241fe-59cd-47b3-8c74-6ae7ed69ed1f", null, "tramyfarmtour@gmail.com", true, "Trà My Sâm Ngọc Linh Tour", null, false, null, "tramyfarmtour@GMAIL.COM", "tramyfarmtour", "AQAAAAIAAYagAAAAENwu9g1wOZwH0Sy6ebGe3DWx4E6GJTxJR999puWQBBidWZ2vYfPF4atKCQ7RaNTRtg==", null, false, "8f1321ed-b6ef-4b4d-b6fd-e95b4b43dd62", false, "tramyfarmtour", true },
                    { new Guid("10000000-0000-0000-0000-000000000008"), 0, null, "34f2f0d0-e385-4a6e-93f8-40a2728f8b79", null, "dalatorganic@gmail.com", true, "Đà Lạt Organic Farm Tour", null, false, null, "dalatorganic@GMAIL.COM", "dalatorganic", "AQAAAAIAAYagAAAAEIeocKUpnA34eHHsrZ/gI6jbOdJ+VFkKme7Z/RuLv3Ssex28de8rid2keVjuVvG3gQ==", null, false, "276a6656-7168-4f2d-aebb-d24550b39030", false, "dalatorganic", true },
                    { new Guid("10000000-0000-0000-0000-000000000009"), 0, null, "74292e2a-be35-4126-a871-a7e3f7eec62b", null, "binhthuanfarm@gmail.com", true, "Farmstay Nho & Thanh Long Bắc Bình", null, false, null, "binhthuanfarm@GMAIL.COM", "binhthuanfarm", "AQAAAAIAAYagAAAAEAdMSBiRJ865wi1gX7hr/NNIk/quyMopxxnfNW4CHClJTykEfB+dd+tqGvTFTTi0xg==", null, false, "ab2071ca-b5b8-4cbb-ab8d-deba831e4584", false, "binhthuanfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000010"), 0, null, "c2adf87d-1d65-4066-b30f-5e2f59019c7e", null, "babeecotour@gmail.com", true, "Ba Bể Lake Ecofarm Tour", null, false, null, "babeecotour@GMAIL.COM", "babeecotour", "AQAAAAIAAYagAAAAEFzICeg9osU1wmJrMhCwBQ+Rpg9hbWzIQ54W7ZvJH9uKBNjhbc1RAgQ32F1RoPUEZQ==", null, false, "b81fb2f3-7a34-4bfd-b000-56137db333f9", false, "babeecotour", true },
                    { new Guid("10000000-0000-0000-0000-000000000011"), 0, null, "d8db8fd0-25d3-4156-b41f-7585821c6bf2", null, "tayninhfarm@gmail.com", true, "Trang Trại Nông Sản Sạch Tân Châu", null, false, null, "tayninhfarm@GMAIL.COM", "tayninhfarm", "AQAAAAIAAYagAAAAEIX2x1cVzQEF8rUyr3YfJSAbVZt1aJQ885qyTUN3obgPUu5UK5AvdUtwpIjX+JpoOA==", null, false, "8d217692-6d87-4c61-ac00-7ad362b64a70", false, "tayninhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000012"), 0, null, "599575c4-c7a8-4363-bbe9-be40ec48962e", null, "phuyentour@gmail.com", true, "Trải nghiệm Nông trại Biển & Rau Tuy An", null, false, null, "phuyentour@GMAIL.COM", "phuyentour", "AQAAAAIAAYagAAAAENiGs7P1ayJ3FBCwRgFL9F95QupXmQieVZw2a7Q8i9owiUWqvvSYoxJ3aW7DKh7/6A==", null, false, "20a834e3-e3f3-453b-9d36-39022794edab", false, "phuyentour", true },
                    { new Guid("10000000-0000-0000-0000-000000000013"), 0, null, "2fe39e80-165f-4bc0-95a6-93bf27abb319", null, "travinhfarm@gmail.com", true, "Trang Trại Nông Sản Sạch Càng Long", null, false, null, "travinhfarm@GMAIL.COM", "travinhfarm", "AQAAAAIAAYagAAAAEIPSJHO7Wm8QVXty41vQS1DmbxT9QxYK2NBh1MAX9U2qJ9MOTeOMlJxCy8fS5uFr3A==", null, false, "3d5f2167-8dda-4c3a-b215-edb55275fc16", false, "travinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000014"), 0, null, "fe604ab2-b501-434a-9428-9e3dc3780cbd", null, "soctrangfarm@gmail.com", true, "Mỹ Xuyên Farmstay", null, false, null, "soctrangfarm@GMAIL.COM", "soctrangfarm", "AQAAAAIAAYagAAAAEPPWdvMKWQn+Z1WUz6qObLog3XwB61wWdxs1iCzAgOXeR9yNrh8PPsFN9eOOpUvGRw==", null, false, "f4f40ec2-2cfe-4445-99e9-b45ce6603eff", false, "soctrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000015"), 0, null, "4a9dadd8-3eb7-4eb6-9747-8847c629ae5c", null, "angiangfarm@gmail.com", true, "Trang Trại Châu Đốc", null, false, null, "angiangfarm@GMAIL.COM", "angiangfarm", "AQAAAAIAAYagAAAAEG4WbKbEA7hsoutprW/Ei/3PEOSLaUGE9M1Gd7TimRyt6TXlu8n07zNlb4o6E+r+lQ==", null, false, "8c04eec2-db18-44b6-9aff-90a219bd9594", false, "angiangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000016"), 0, null, "9a0006f7-1efc-49b2-bd5c-d3f1958a7921", null, "canthoexplore@gmail.com", true, "Cần Thơ Farmstay", null, false, null, "canthoexplore@GMAIL.COM", "canthoexplore", "AQAAAAIAAYagAAAAEMegdQFucFynBErhVK8Uy3HqDdnxTd3rWEhr4bIzR6qLRISyoebBzDDyhhnub2Wq2Q==", null, false, "500b9abc-d299-40a8-a243-c43eff61a56d", false, "canthoexplore", true },
                    { new Guid("10000000-0000-0000-0000-000000000017"), 0, null, "fdd91049-4564-4f2e-b69b-082665a5e2d1", null, "phuquocfarm@gmail.com", true, "Phú Quốc Nông Trại Sản Xuất Hữu Cơ", null, false, null, "phuquocfarm@GMAIL.COM", "phuquocfarm", "AQAAAAIAAYagAAAAEPSjiNRfpAX9d2b2TDNKnkALBbhs/+iZyIBSmGhcFgliUCM6m/O5IjadmHQ/QOr1Sw==", null, false, "2506f11a-1a92-40d2-8f40-0ce09211aa40", false, "phuquocfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000018"), 0, null, "ccd05c62-1cc2-4955-95bc-15c10981f4e7", null, "halongfarm@gmail.com", true, "Trại Nông Sản Hạ Long", null, false, null, "halongfarm@GMAIL.COM", "halongfarm", "AQAAAAIAAYagAAAAEBGIAasm99B/1/NdOlZbB7eWmYEevCnO+OvoWKn0uXtv3UHMpuLHb/eop08KsF2t/Q==", null, false, "d56aa3d9-022a-46dc-80a1-3167df086db9", false, "halongfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000019"), 0, null, "ded77137-d831-4366-88d1-6551e9b5edaf", null, "anlaofarm@gmail.com", true, "Trang Trại Nông Sản An Lão", null, false, null, "anlaofarm@GMAIL.COM", "anlaofarm", "AQAAAAIAAYagAAAAEOkWcq0qvsIR0UXEpRqov7FONBA6tg0WXoLcxe9Qc+qMc3RpD+vOfChnETQJgcKsZw==", null, false, "66cd9861-f284-4b60-b70f-f99e93e4a973", false, "anlaofarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000020"), 0, null, "2f677b5e-56e3-47cb-9b1e-86c19775d9d8", null, "daitufarm@gmail.com", true, "Nông Trại Đại Từ", null, false, null, "daitufarm@GMAIL.COM", "daitufarm", "AQAAAAIAAYagAAAAEBXvHhroAL6oP2n0anTyicoEn8JmNwli1avUUZpLQnOb+GblhHbOmJSImMoLnJd5Fg==", null, false, "d02bf0ce-5c04-47d0-ad66-88eb7f09bd01", false, "daitufarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000021"), 0, null, "8b6af8c8-cb56-48f7-9e08-8d940667611e", null, "vinhfarm@gmail.com", true, "Trại Nông Sản Vinh", null, false, null, "vinhfarm@GMAIL.COM", "vinhfarm", "AQAAAAIAAYagAAAAEL6um2JSDxlyZGGJrRzRNY3rWgf0cF5PsBD4/VaoJxeDIoFJR5SQ4bcU/qnAsl0iyQ==", null, false, "fa3cd1ff-8d58-4d94-b2e2-7022bdbf0d77", false, "vinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000022"), 0, null, "7ca63f92-3275-4a34-8967-30ff6002bad5", null, "trieusonfarm@gmail.com", true, "Trang Trại Nông Sản Triệu Sơn", null, false, null, "trieusonfarm@GMAIL.COM", "trieusonfarm", "AQAAAAIAAYagAAAAEMiPmqWVgA8vNH/dQeAMQOAFWGB8JavKRys0cBLkzf7nj2HBmE5TsBi8s5fEEE54PQ==", null, false, "f4d6a533-2287-4932-baee-c711cdf56507", false, "trieusonfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000023"), 0, null, "d4d88e82-db26-41e3-af9e-283ed206363c", null, "hatinhfarm@gmail.com", true, "Trại Nông Sản Hà Tĩnh", null, false, null, "hatinhfarm@GMAIL.COM", "hatinhfarm", "AQAAAAIAAYagAAAAEHkK0q1Diw1hLSeXDdFtMBLzytovcY3HFGF76an23E9WG0iGXHOuT4OhX3IhPM0+gA==", null, false, "925fd4a1-ea72-4f0d-b38b-34b24c6f1968", false, "hatinhfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000024"), 0, null, "8d310bde-8274-4de7-9857-165c668122da", null, "donghoifarm@gmail.com", true, "Trang Trại Đồng Hới", null, false, null, "donghoifarm@GMAIL.COM", "donghoifarm", "AQAAAAIAAYagAAAAEE0Ok/6jf2nHwkITd4FfvZqVhnPNbP7n3fssXp8H5SgrBN7bNgzUzcPJ8VA9h7W3lw==", null, false, "8198c9d6-a1b9-4a0c-9f10-276c06a18c9e", false, "donghoifarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000025"), 0, null, "74a64cad-cbc0-4c6f-9f3b-da5e436a5dae", null, "donghafarm@gmail.com", true, "Trang Trại Nông Sản Đông Hà", null, false, null, "donghafarm@GMAIL.COM", "donghafarm", "AQAAAAIAAYagAAAAEN5PNQDJTV5BFxLVmYAWeXhx9b+fFp3C1WfRqKG/5NG8KtMnyKtDdpdz+KX2D7WK1Q==", null, false, "61706c45-bf9f-467c-8bd3-905ef1ad4d05", false, "donghafarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000026"), 0, null, "1d53f463-6f83-4c7c-afd1-a7ffef18f754", null, "quynhonfarm@gmail.com", true, "Trại Nông Sản Quy Nhơn", null, false, null, "quynhonfarm@GMAIL.COM", "quynhonfarm", "AQAAAAIAAYagAAAAEHzb0620FhzlBpKY15ZMG4PAqMIgvJOKLrAI1umbZG0mSQcqFtIL93kQwT2NnZwR/A==", null, false, "e858b0dd-f5e0-4f42-89cf-e0f1e5d64c2f", false, "quynhonfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000027"), 0, null, "49788063-80aa-45b3-8ef1-1daf3a01816d", null, "tuyhoafarm@gmail.com", true, "Trang Trại Nông Sản Tuy Hòa", null, false, null, "tuyhoafarm@GMAIL.COM", "tuyhoafarm", "AQAAAAIAAYagAAAAEKrF0RZPehljeRN9Ki6hd+f+mMPqAkLe/VMaISP37X6fIveWvPIIMmJ7t4P5GQ7Lyw==", null, false, "6bd291a6-1dfd-486f-94ae-d6ad82dacc6e", false, "tuyhoafarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000028"), 0, null, "ca47bb92-fa18-4e30-a476-858ca7c5f89b", null, "nhatrangfarm@gmail.com", true, "Trại Nông Sản Nha Trang", null, false, null, "nhatrangfarm@GMAIL.COM", "nhatrangfarm", "AQAAAAIAAYagAAAAEPMxq5+tzXTGCxiqkcV9hwtKnIk7TELt+baag9VuYmmGK8Tld10ZVlwqCZ9RoOW/kQ==", null, false, "26cf02d7-3daf-491d-a779-9cf2e4d42b1a", false, "nhatrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000029"), 0, null, "c93249a5-dbfe-4de3-88d9-ba3b066edade", null, "phanrangfarm@gmail.com", true, "Trại Nông Sản Phan Rang", null, false, null, "phanrangfarm@GMAIL.COM", "phanrangfarm", "AQAAAAIAAYagAAAAEO7/3vKEVcMwDb3M76kB0xycPjK+IgyQWZg0EfHReYB6OH6uJFuYphDNQvUl3iqLYA==", null, false, "5fb674ad-af47-424b-9d04-9076ade8e553", false, "phanrangfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000030"), 0, null, "4b736e29-4c20-495e-9430-06f8500776a0", null, "phanthietfarm@gmail.com", true, "Trang Trại Nông Sản Phan Thiết", null, false, null, "phanthietfarm@GMAIL.COM", "phanthietfarm", "AQAAAAIAAYagAAAAEAFqOtDBlYyE5lMlV0jWrcu+r1hHKFccGphA0sW8a7slBt/wGDiAFXIH6v4nDUWxAA==", null, false, "52725201-191a-43e6-abc8-de0d61386b56", false, "phanthietfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000031"), 0, null, "7a482e99-1a8c-474c-8a3d-6fd6c579d9b4", null, "tananfarm@gmail.com", true, "Trại Nông Sản Tân An", null, false, null, "tananfarm@GMAIL.COM", "tananfarm", "AQAAAAIAAYagAAAAEEEkSQWWOf27G2NlFt2fY0gwALjsmhFnT6vh6+r2dN77cpVmB0u8Fuf+qMTwjpL8OA==", null, false, "b3f2294f-eb96-48ed-8ac5-63682a2a9e55", false, "tananfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000032"), 0, null, "ef55f025-74c6-4f8f-ae89-1fcd447c0db3", null, "vinhlongfarm@gmail.com", true, "Trại Nông Sản Vĩnh Long", null, false, null, "vinhlongfarm@GMAIL.COM", "nhavinhlongfarmtrangfarm", "AQAAAAIAAYagAAAAEOP2FVqSTEiznT1VH8XrzkQxANq0mLcUPkFJPisSWkyQJws4eCOJAapugy4PeXw9ww==", null, false, "8ab72a93-601e-4759-be22-9a50a2f8273a", false, "vinhlongfarm", true },
                    { new Guid("10000000-0000-0000-0000-000000000033"), 0, null, "d4757465-da91-4936-9e4f-c1a17cb27d0e", null, "contact@vinpearlresort.com", true, "CÔNG TY TNHH VINPEARL RESORT & SPA", null, false, null, "CONTACT@VINPEARLRESORT.COM", "VINPEARLRESORT", "AQAAAAIAAYagAAAAEFgCAM5qkXt5WmHz3xePGtZjN1IwkFdZ1QM3SLNvyCePFp5vxffilfVlm2XXiK3KWg==", null, false, "1a521c8b-0a7f-4c94-9892-d1afeb462808", false, "VinpearlResort", true },
                    { new Guid("10000000-0000-0000-0000-000000000034"), 0, null, "3804d453-ac80-4d52-a041-14ad947d9dfb", null, "info@muongthanhhotel.com", true, "TẬP ĐOÀN KHÁCH SẠN MƯỜNG THANH", null, false, null, "INFO@MUONGTHANHHOTEL.COM", "MUONGTHANHHOTEL", "AQAAAAIAAYagAAAAEHt+Ce7K78eunMaxtD6DcE0FSzQfW5OBkuoW24ZXI4j74od840TBlZdnCKgUa9v8Kw==", null, false, "8cc287e5-9468-4396-a34a-4b6e83632ee9", false, "MuongThanhHotel", true },
                    { new Guid("10000000-0000-0000-0000-000000000035"), 0, null, "1eb3badb-d852-4a28-bbf7-8c5f5a26a019", null, "reservation@intercontinental.com", true, "KHÁCH SẠN INTERCONTINENTAL HANOI WESTLAKE", null, false, null, "RESERVATION@INTERCONTINENTAL.COM", "INTERCONHANOI", "AQAAAAIAAYagAAAAEFfBaozCl06rXG3UoXNU7srPCnqI2vZJAfFlhgR22mVNJhXeytU/h4XHA4XhrRq2wQ==", null, false, "29d0f11b-27dc-4ab9-b29d-e27551e71c48", false, "InterConHanoi", true },
                    { new Guid("10000000-0000-0000-0000-000000000036"), 0, null, "840ace41-1e9e-4ae0-8a46-1f192a9271b8", null, "info@sofitellegend.com", true, "KHÁCH SẠN SOFITEL LEGEND METROPOLE HÀ NỘI", null, false, null, "INFO@SOFITELLEGEND.COM", "SOFITELLEGEND", "AQAAAAIAAYagAAAAEN5bDRCZfjzR6teivStv9UE36xker7/0l0ci7UoUBMbR3M7wAbl4zgbln4sSxw74qw==", null, false, "c41b9239-f579-49ce-b8d4-a4ecce716deb", false, "SofitelLegend", true },
                    { new Guid("10000000-0000-0000-0000-000000000037"), 0, null, "ca7e4fcf-f00d-4337-b0c4-fd24b82bb853", null, "reservation@furamadanang.com", true, "CÔNG TY TNHH FURAMA RESORT ĐÀ NẴNG", null, false, null, "RESERVATION@FURAMADANANG.COM", "FURAMADANANG", "AQAAAAIAAYagAAAAEBQNVuQRWx5xqFDBmbs9wIz8pHLGsRjh2aaZp659ggHpJyndziVJIvf/HlDVMaiNlQ==", null, false, "0ea43699-1f8f-45d7-8428-d0dd95200a7d", false, "FuramaDanang", true },
                    { new Guid("10000000-0000-0000-0000-000000000038"), 0, null, "9eebafd8-d74e-4286-bd24-ee9b7e0323b8", null, "spa@anantara.com", true, "CÔNG TY TNHH ANANTARA QUY NHƠN VILLAS", null, false, null, "SPA@ANANTARA.COM", "ANANTARASPA", "AQAAAAIAAYagAAAAELoOfDHaIhI7CjN5lWch1Zr/W5Zl1MDcIYbDz5VazcMqzdmYEBZ6p24anvG0+vg6JQ==", null, false, "36bb1c44-cb58-4043-bad3-5d0bfc4a21d4", false, "AnantaraSpa", true },
                    { new Guid("10000000-0000-0000-0000-000000000039"), 0, null, "f4abaee4-410e-41be-a1c6-49dfbbf62998", null, "resort@amanoi.com", true, "CÔNG TY TNHH AMANOI RESORT NINH THUẬN", null, false, null, "RESORT@AMANOI.COM", "AMANOISPA", "AQAAAAIAAYagAAAAEKLhsfJHV7F8RUZLHv9DPKAm01qqx5DfZwPjpnDGUGk/aPT6xL7C2e2cqgE+vD4i5w==", null, false, "18e5815f-bdd7-4a10-a6d4-ba2ebcc5faae", false, "Amanoispa", true },
                    { new Guid("10000000-0000-0000-0000-000000000040"), 0, null, "eee7764e-c9f1-4fc4-9d4a-371f0c8bdd58", null, "contact@sixsenses.com", true, "CÔNG TY TNHH SIX SENSES CÔN ĐẢO", null, false, null, "CONTACT@SIXSENSES.COM", "SIXSENSESCON", "AQAAAAIAAYagAAAAED5mVJojgNKURrb+nIuG3WIi+ZUc8VTnKb25lQcRm0w8jaREAgIWEhYBURgMR71f8w==", null, false, "9022ad86-36d0-4746-a801-f248c6172239", false, "SixSensesCon", true },
                    { new Guid("10000000-0000-0000-0000-000000000041"), 0, null, "fdfedddf-c7f7-4337-9832-94907c3b7371", null, "langco@banyantree.com", true, "CÔNG TY TNHH BANYAN TREE LĂNG CÔ", null, false, null, "LANGCO@BANYANTREE.COM", "BANYANTREE", "AQAAAAIAAYagAAAAEJxtcL94xOaPSVDYzWqRUs2tzpVVRpqONa6K8JqkDGMuTgi1/ooIi51jnSfvNVatOA==", null, false, "a10ff363-2f30-4b79-8485-bdeba9baa7ec", false, "BanyanTree", true },
                    { new Guid("10000000-0000-0000-0000-000000000042"), 0, null, "140b9291-5e06-4b02-b95e-0978739f65cf", null, "saigon@hyatt.com", true, "CÔNG TY TNHH PARK HYATT SÀI GÒN", null, false, null, "SAIGON@HYATT.COM", "PARKHYATT", "AQAAAAIAAYagAAAAEOHjD/3XZRE2F1ezXgysyvQAAmoxw34VqoaEgUqFVEnkyVg3y0ALDmlOrwO1DnsYqw==", null, false, "5e1772bf-c595-4be1-8f33-f8a06bedf5e2", false, "ParkHyatt", true },
                    { new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), 0, null, "9947a863-13b4-44de-a714-f3bb061cea82", null, "lucianafuste0717@gmail.com", true, "Content Moderators", null, false, null, "LUCIANAFUSTE0717@GMAIL.COM", "CONTENTMODERATORS", "AQAAAAIAAYagAAAAEK6nJwPBVjFjFdmalm5XYN5b/sHed+z+8uyjfTkEktzWrJgh8FytavI9X2Yc7Q3jog==", null, false, "019924f2-d268-45ec-bccf-21e26d8fc778", false, "ContentModerators", true },
                    { new Guid("20000000-0000-0000-0000-000000000018"), 0, null, "acfa4ad1-a475-4b7c-9f70-5e9611d0d475", null, "contact@gmail.com", true, "Quy Nhơn Explorer", null, false, null, "CONTACT@GMAIL.COM", "QUYNHONEXPLORER", "AQAAAAIAAYagAAAAEDFTbLPGe9kF7dp0+HgAgQistHnUzvkfLh+YRNFWNs/aWXnQNUHbmMBDgBGoAw1cKg==", null, false, "d466622a-9c29-40d2-a1d9-919322416270", false, "quynhonexplorer", true },
                    { new Guid("20000000-0000-0000-0000-000000000019"), 0, null, "e6bfde98-312d-4cac-a1e6-d258e7085a0e", null, "contact@hoianheritage.com", true, "Hoi An Heritage Tours", null, false, null, "CONTACT@HOIANHERITAGE.COM", "HOIANHERITAGEACCOUNT", "AQAAAAIAAYagAAAAEOagv8QzvtKS+k/Obxekg/p5B/VSJBcsfC//XZTaBoPoYg0uFzTEIW2VbMwFcyQO7A==", null, false, "380921e7-11dd-44c9-bc85-41e09e4d29c1", false, "hoianheritage", true },
                    { new Guid("20000000-0000-0000-0000-000000000020"), 0, null, "70ba1e11-fc8f-45e0-8ab0-5a05d91579c5", null, "info@danangdiscovery.com", true, "Da Nang Discovery Travel", null, false, null, "INFO@DANANGDISCOVERY.COM", "DANANGDISCOVERYACCOUNT", "AQAAAAIAAYagAAAAEFHKt99RNOGggsHHjskJhkFmx2hbs39Zm5ofO7x6ieWcx4hmXXB7qgJVC3L2yBYj1g==", null, false, "b7a0e4f2-89bc-430f-94fe-bd01562fef00", false, "DaNangDiscoveryAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000021"), 0, null, "7c9ba16d-deef-4fb5-a433-3ba0a3d97b87", null, "contact@hueimperial.com", true, "Hue Imperial Adventures", null, false, null, "CONTACT@HUEIMPERIAL.COM", "HUEIMPERIALACCOUNT", "AQAAAAIAAYagAAAAECSXne7ZM9nJ+0SeMSJZHr9OUOH+3HYWQgNqTjDm7doT+UYnYxdVo1zTEajosSNt5w==", null, false, "202c3237-e6ad-4770-bfac-5679e025ae59", false, "HueImperialAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000022"), 0, null, "953dc253-9a16-4c8f-9b34-200aec4163c0", null, "info@nhatrangbay.com", true, "Nha Trang Bay Tours", null, false, null, "INFO@NHATRANGBAY.COM", "NHATRANGBAYACCOUNT", "AQAAAAIAAYagAAAAEGTcUeK5dISFPgZzI3tJSMJ0ORgxa8vrb/s3v7RmgoQ+C/vXdtb7GvJHRzsAE1g6EA==", null, false, "bc173be8-07b6-4be5-9db7-04ce1eaad1ff", false, "NhaTrangBayAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000023"), 0, null, "8f8d1e2c-35aa-418c-a883-a332819ef37b", null, "booking@halongcruise.com", true, "Ha Long Cruise Experience", null, false, null, "BOOKING@HALONGCRUISE.COM", "HALONGCRUISEACCOUNT", "AQAAAAIAAYagAAAAEHC4v5rmbYu5+2EGCUnqFOW6fSXT9n3qHri2egAsCsusZrzuJMa2keq/svcLzKuZ0Q==", null, false, "a628cb31-70d1-47c2-b23d-f14d77b7037e", false, "HaLongCruiseAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000024"), 0, null, "996cde39-1383-413b-95e4-209ac3e46719", null, "contact@sapahighland.com", true, "Sapa Highland Adventures", null, false, null, "CONTACT@SAPAHIGHLAND.COM", "SAPAHIGHLANDACCOUNT", "AQAAAAIAAYagAAAAEO0BrS7OH9DB4XBVrVxim48OEavqfcIzGxlk3NbxyLiDqptvwp24okK6vJgXEo+O5Q==", null, false, "a44a24b5-1f96-40cd-bb73-5f656562bd53", false, "SapaHighlandAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000025"), 0, null, "0a88c87f-f1dd-4c5e-822b-60ece315f9d3", null, "info@mekongdelta.com", true, "Mekong Delta Explorers", null, false, null, "INFO@MEKONGDELTA.COM", "MEKONGDELTAACCOUNT", "AQAAAAIAAYagAAAAEPKpoOnYczCK8oTAQ/v2eki9MS6JOJ6SwuMbiBRr38Oq+IEg0mpDF7OqWprrgghGwA==", null, false, "ad662154-d0a6-483a-b81a-1534c690e733", false, "MekongDeltaAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000026"), 0, null, "04b48842-d1b7-4064-a6ad-105bb354895e", null, "contact@phuquocisland.com", true, "Phu Quoc Island Tours", null, false, null, "CONTACT@PHUQUOCISLAND.COM", "PHUQUOCISLANDACCOUNT", "AQAAAAIAAYagAAAAECnRWEf0OzNp0kLilzMgnC4NfAZU9wT4T8R/lXHO02075QVNurn2msuu2NepTdMwsg==", null, false, "cb517a58-5279-4fb2-b023-29793dc4a7bf", false, "PhuQuocIslandAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000027"), 0, null, "ca43cb46-9bad-4b1c-a80c-5e02d198753d", null, "info@dalateco.com", true, "Da Lat Eco Tourism", null, false, null, "INFO@DALATECO.COM", "DALATECOACCOUNT", "AQAAAAIAAYagAAAAEC1wVYl8/B7AxayTTn8PZtGc9dZhvruZhIlf3qY8ctGeQxq/hO2MV+uc1asf7+84uQ==", null, false, "119e3a8e-1232-4fc0-8741-ea7678ff5bba", false, "DaLatEcoAccount", true },
                    { new Guid("20000000-0000-0000-0000-000000000028"), 0, null, "a86987a4-b6e9-4b94-8dc1-3030248a50a7", null, "booking@condaotours.com", true, "Con Dao Heritage Tours", null, false, null, "BOOKING@CONDAOTOURS.COM", "CONDAOACCOUNT", "AQAAAAIAAYagAAAAEL1QF91RaD1zEbjotB6aPYsUtCgdA9lxg6BDOqFnmeA8h43y8ySqdOWlp7GdICxbSg==", null, false, "c52d163a-63cb-4e12-ac09-df6dd553752f", false, "ConDaoAccount", true },
                    { new Guid("22222222-2222-2222-2222-222222222222"), 0, "https://example.com/avatar1.jpg", "1edf3cf1-73c9-44ce-819f-db27162029eb", new DateTime(1990, 5, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "johndoe@example.com", true, "John Doe", true, false, null, "JOHNDOE@EXAMPLE.COM", "JOHNDOE", "AQAAAAIAAYagAAAAEI7VzzbLFbpqtPVIfZUtUcObr/mhzbfOcmS7GhMQZVl7Bjq6viOsVxixqSVjg8WKsw==", "0355881013", false, "14a4c8ad-5e1e-4f6e-96f6-7e3ef3de0b52", false, "JohnDoe", true },
                    { new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"), 0, null, "b26ffddd-bbb0-4395-a344-413b704556bc", null, "contact@bambotravel.com", true, "Bamboo Travel", null, false, null, "CONTACT@BAMBOOTRAVEL.COM", "BAMBOOTRAVELACCOUNT", "AQAAAAIAAYagAAAAEGZbM5kP5dy+OFTdI4MtFw0LlaUkyGEkXhGBmATw3ayB6z0KLNDJGrQauf4dD3N/VQ==", null, false, "1796fe0c-687d-4cc6-b802-b81f23b4169a", false, "BambooTravelAccount", true },
                    { new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"), 0, null, "668bfecb-9d6c-4c08-85ba-5a077861cacc", null, "info@phuongnamtravel.com", true, "Phương Nam Travel", null, false, null, "INFO@PHUONGNAMTRAVEL.COM", "PHUONGNAMTRAVELACCOUNT", "AQAAAAIAAYagAAAAEB6D10JkS7z/FGqt0Cj3TY6U5PM45gxZQmggbyLNpTFVzjvg1AT1lhaALp4zkVo73w==", null, false, "4bc5d758-d0cc-4b31-ab66-f8413d52ec5b", false, "PhuongNamTravelAccount", true },
                    { new Guid("44444444-4444-4444-4444-444444444444"), 0, "https://example.com/avatar2.jpg", "ec72481e-80bc-46a8-9dfc-a2aa62b71d67", new DateTime(1988, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "emmawatson@example.com4", true, "Emma Watson", false, false, null, "EMMAWATSON@EXAMPLE.COM", "EMMAWATSON", "AQAAAAIAAYagAAAAEJC8Q6Sl2ghpFxBqmS05+2ATt+j+Qd1sLV0nAFVz22fkCS1hhH362VHcY1ug/DJCXg==", "0355881014", false, "71fb0f1c-6bf5-4f18-b1e9-1e9554e7338e", false, "EmmaWatson", true },
                    { new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"), 0, null, "45fc2096-9542-4e01-a698-bdc0febfa54b", null, "support@nhatrangholiday.com", true, "Nha Trang Holiday", null, false, null, "SUPPORT@NHATRANGHOLIDAY.COM", "NHATRANGHOLIDAYACCOUNT", "AQAAAAIAAYagAAAAEGoR7GK+mM1joIqsMoQDHkTHomAtvo6BaydvwaEL+8nee96oCylPVGAjqsY9OLEsRQ==", null, false, "cd66dd7d-cb22-4b62-bd1d-90bad8c1f84e", false, "NhaTrangHolidayAccount", true },
                    { new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"), 0, null, "add88d1f-474a-442a-855c-9bac14f505b1", null, "thuthuhe2501@gmail.com", true, "TourGuides", null, false, null, "THUTHUHE2501@GMAIL.COM", "TOURGUIDES", "AQAAAAIAAYagAAAAECLyIpjBLXgg+Qpef1IgK7t8G6FfpgkJYtgXjgu77W4xDULk/w+0aX2lTdVwvHNhTw==", "0355881012", false, "84240d8e-0f0a-4c44-939f-2682a3da4838", false, "TourGuides", true },
                    { new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"), 0, null, "45c18eb5-da29-42c7-bc70-548ae6f7ad85", null, "support@hanoitourist.com", true, "Hanoitourist", null, false, null, "SUPPORT@HANOITOURIST.COM", "HANOITOURISTACCOUNT", "AQAAAAIAAYagAAAAEFK6FyyHy4L8mKE3Y8OlpPSOEt4e9hInPkYw2mxuYFkpoieXWA96tEu1oZlbI7ChpQ==", null, false, "d6d4e737-5e54-4882-a4d5-ee7e5a35e0d8", false, "HanoitouristAccount", true },
                    { new Guid("66666666-6666-6666-6666-666666666666"), 0, "https://example.com/avatar3.jpg", "27aa45fd-a141-4e24-8b69-8f5a6bc1aaa1", new DateTime(1985, 11, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "michaelbrown@example.com", true, "Michael Brown", true, false, null, "MICHAELBROWN@EXAMPLE.COM", "MICHAELBROWN", "AQAAAAIAAYagAAAAEL/AltCgEHzFlijkbuoJTaxllcJV20n9Gq6rXIzC8BWBP4LR2ezdUTIn/jRPydYXyA==", "0355881015", false, "468c1243-3876-499e-955d-22032d33dfa7", false, "MichaelBrown", true },
                    { new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"), 0, null, "89c396c6-b427-4a8c-b04b-059602879861", null, "contact@phanthiettours.com", true, "Phan Thiết Tours", null, false, null, "CONTACT@PHANTHIETTOURS.COM", "PHANTHIETTOURSACCOUNT", "AQAAAAIAAYagAAAAEEtnLRmgeBNeRQQ5PqLaqGaUzJNdgfXcV2B1nrn/+6Dk3oGTl/zONSalRECWMtKQ/g==", null, false, "148e870a-61f9-4e3f-932b-17bc337b70e2", false, "PhanThietToursAccount", true },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), 0, "https://example.com/avatar8.jpg", "fc23360b-80c2-498b-8aa6-9eef0aeec55e", new DateTime(1989, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "daniel.martinez@example.com", true, "Daniel Martinez", true, false, null, "DANIEL.MARTINEZ@EXAMPLE.COM", "DANIELMARTINEZ", "AQAAAAIAAYagAAAAEOeWFQPRJIisbJtpLZV4YQc2f4qftWMO86IPQVl5mMKdjqRLBqGqtgIvVdbY9MXYlg==", "0355881020", false, "9df8185e-14c7-46fe-a3d7-bf8bf6e07568", false, "DanielMartinez", true },
                    { new Guid("88888888-8888-8888-8888-888888888888"), 0, "https://example.com/avatar4.jpg", "86de5f9f-236d-41ee-8ae5-42373b6e2e67", new DateTime(1992, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "sophialee@example.com", true, "Sophia Lee", false, false, null, "SOPHIALEE@EXAMPLE.COM", "SOPHIALEE", "AQAAAAIAAYagAAAAEIAymanbp7I+5NDVCUcNTMszu83wXd3zwXg9JCONk6+wh23Ya37wxZK8F98b3sH/UA==", "0355881016", false, "c8d8bebc-0707-41db-afa9-cb3af30c2127", false, "SophiaLee", true },
                    { new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"), 0, null, "6c8efb43-cdc8-42f8-9594-2dc7906f9fef", null, "info@redtour.com.vn", true, "Redtour", null, false, null, "INFO@REDTOUR.COM.VN", "REDTOURACCOUNT", "AQAAAAIAAYagAAAAEBGDuR70qK76zplxHfFnJ8BOZM/+R+KhRYE1LYFEKvTq4BnkFRWnZECSHcLt1tHMrA==", null, false, "75fe9443-6299-4f64-93fc-dfa40a9be05a", false, "RedtourAccount", true },
                    { new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"), 0, "https://example.com/avatar9.jpg", "dff7b8cb-4315-43d0-bd98-5b6706247183", new DateTime(1994, 9, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "emilyclark@example.com", true, "Emily Clark", false, false, null, "EMILYCLARK@EXAMPLE.COM", "EMILYCLARK", "AQAAAAIAAYagAAAAEDcM7Kw1pO89XPOaAJbrerZtlYzFFKty0J/Lnr3CgFDhtj8SAQUHRb9YV113hjgzSA==", "0355881021", false, "5703fa85-67c3-4332-8d9a-86d908c632fd", false, "EmilyClark", true },
                    { new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"), 0, null, "d39fe38d-cd70-4690-99de-2801c7eeb058", null, "contact@quynhonexplorer.com", true, "Quy Nhơn Explorer", null, false, null, "CONTACT@QUYNHONEXPLORER.COM", "QUYNHONEXPLORERACCOUNT", "AQAAAAIAAYagAAAAEByr4dEu7SRVrLc/p27ytQt3yHb9VGT3yQIYrJmIdezJOwHqFFYqeiCcLaP8m44PHA==", null, false, "a056531a-f709-4186-a350-561bfbf2c8e8", false, "QuyNhonExplorerAccount", true },
                    { new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"), 0, null, "aa9333b1-0fa8-473f-b4ef-d58a7c438093", null, "contact@datviettour.com", true, "Đất Việt Tour", null, false, null, "CONTACT@DATVIETTOUR.COM", "DATVIETTOURACCOUNT", "AQAAAAIAAYagAAAAEEXIIz0ln+RRu97gYVyQODKSTlyXxhTxlFsPydufavExX3KWFgGiHYvLB4hwWAuuIQ==", null, false, "2165e941-3aed-4f5e-b869-2d00b36c31ac", false, "DatVietTourAccount", true },
                    { new Guid("a631bb94-66d8-44db-932b-532892d87754"), 0, null, "c295ca33-d6ae-4228-85ff-be5d7506e01f", null, "thutt170727@gmail.com", true, "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", null, false, null, "THUTT170727@GMAIL.COM", "ATFO", "AQAAAAIAAYagAAAAEEDVCLMR9dMEig42IwQg2w5RhKEgNuT8eso5okhAWH0kxbJEIxweDIhrBmwVtdrBUA==", null, false, "068d6714-a8b3-49c1-afb6-accdea9df4e4", false, "ATFO", true },
                    { new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"), 0, null, "05fec3af-e95c-4bd0-a42e-fdb2d697b810", null, "contact@vietsuntravel.com", true, "VietSun Travel", null, false, null, "CONTACT@VIETSUNTRAVEL.COM", "VIETSUNTRAVELACCOUNT", "AQAAAAIAAYagAAAAEJc5zdfMaiR1Nwde+sExkkDckOQ2UBmK1OFarXsaIB6E0isiTTOntvAhhG2r2bxFLQ==", null, false, "088a863c-aee0-4142-9c84-8b18fc3d53eb", false, "VietSunTravelAccount", true },
                    { new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"), 0, "https://example.com/avatar5.jpg", "5c87c82b-6dc5-4d26-a7bd-d5f25532e5be", new DateTime(1995, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "davidjohnson@example.com", true, "David Johnson", true, false, null, "DAVIDJOHNSON@EXAMPLE.COM", "DAVIDJOHNSON", "AQAAAAIAAYagAAAAEOvumacHxcG7nnHzYk7NwWjUmMU2Z3hCwVwrsrIktw1y/umgN9OC78+I1nDtZolZpQ==", "0355881017", false, "3031028a-08e2-406b-9318-b37f9b92cf82", false, "DavidJohnson", true },
                    { new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"), 0, null, "0774e1c2-b76a-4cd0-9c93-536f8d7269fe", null, "contact@havatravel.com", true, "Havatravel", null, false, null, "CONTACT@HAVATRAVEL.COM", "HAVATRAVELACCOUNT", "AQAAAAIAAYagAAAAECJmG1rdrEwuGO/IwjD2XXOf2AXvQB/yxTZIC1oJpLuuq8kD2qQQMoZDMFSTSHeXpg==", null, false, "3ef866ec-9800-47a9-9246-46c62e2891f5", false, "HavatravelAccount", true },
                    { new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), 0, null, "edc07e8b-5361-4cc2-ba9c-b810e64e5c62", null, "thutt170727@gmail.com", true, "Administrator", null, false, null, "THUTT170727@GMAIL.COM", "ADMINISTRATOR", "AQAAAAIAAYagAAAAEPUUl9y0Ac1c9b6s0XJHmIWoxwWrkxvxYobLQaogFdCpH/JU23dh9i64ELQES+x9jw==", "0355881010", false, "06b04354-f827-4c23-baec-1be4014f4e50", false, "Administrator", true },
                    { new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"), 0, null, "7d531c68-1aef-4fce-abde-553c108c683a", null, "info@vungtautravel.com", true, "Vũng Tàu Travel", null, false, null, "INFO@VUNGTAUTRAVEL.COM", "VUNGTAUTRAVELACCOUNT", "AQAAAAIAAYagAAAAEPIFqSriO8U7UcQX9deQzrewb5q48Fvn4RoTjCuRyy1CX120FQEN9xUBZg4KGK50kg==", null, false, "a91b5028-d06f-4405-a484-b21108c5af74", false, "VungTauTravelAccount", true },
                    { new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"), 0, null, "906195cd-d5f8-4474-b4b5-9409cd9b3b89", null, "info@dalattour.com", true, "Đà Lạt Tour", null, false, null, "INFO@DALATOUR.COM", "DALATTOURACCOUNT", "AQAAAAIAAYagAAAAEFnJIsHqTLit5BOKJfM2Yzk41xgyXi39OG+dRwlnaJrmC5e5dgN0vHGaFTHnyrG2vw==", null, false, "ca7f919c-4d42-4515-88ed-518c5a72fc4d", false, "DalatTourAccount", true },
                    { new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"), 0, "https://example.com/avatar6.jpg", "9cdde53f-a588-46b7-a4f7-68ba6acee3b4", new DateTime(1987, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "liamnguyen@example.com", true, "Liam Nguyen", true, false, null, "LIAMNGUYEN@EXAMPLE.COM", "LIAMNGUYEN", "AQAAAAIAAYagAAAAECNYTGe7bvxXrPy7a4pt/4a2YTofz7OLXkGcMbcWJ+XVrRlLXuJpoN4xzHDfN8M2oA==", "0355881018", false, "ed543094-983b-4281-a4e8-20120c1a3d4d", false, "LiamNguyen", true },
                    { new Guid("d0e45bee-a768-4555-bfeb-788728a53751"), 0, null, "abffddb5-c226-4c31-be93-16a883cfa4f4", null, "info@danangtravel.com", true, "Danang Travel", null, false, null, "INFO@DANANGTRAVEL.COM", "DANANGTRAVELACCOUNT", "AQAAAAIAAYagAAAAEM/e8Y92XPNxazAZFuPM9dOiGxPNqxhySElZ4z+A1/gpiF+2Vzd23w8y3/O7YexeRQ==", null, false, "6e5d1330-a8ef-40e6-86f5-d702867664d4", false, "DanangTravelAccount", true },
                    { new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"), 0, null, "c8118577-8f1b-4aa9-a084-5575d24fc029", null, "contact@saigontourist.net", true, "Saigontourist", null, false, null, "CONTACT@SAIGONTOURIST.NET", "SAIGONTOURISTACCOUNT", "AQAAAAIAAYagAAAAEB0TSrzNEPXfUCCGuQjiQy2JbnuhdFIfQI5o8Uvh6aq/2nts8+e4tEosE5UvZdJ44Q==", null, false, "c42be6c4-12d7-4748-9cad-1523e6037c01", false, "SaigontouristAccount", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), 0, null, "291ada1a-2948-412b-b962-deb27daf534f", null, "ThangNVSE151059@fpt.edu.vn", true, "Tourists", null, false, null, "THANGNVSE151059@FPT.EDU.VN", "TOURIST", "AQAAAAIAAYagAAAAEFRsBzwa5KOtEvISn0VU/ETMCKpvfVx9/x3OT9xCY+p74HtcNCJ0IjHVcV7gMr1sVA==", "0355881010", false, "40cd4097-bed3-409f-a8a6-677cc0f13476", false, "Tourists", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f1"), 0, null, "0db0a9d1-ff56-4463-80b9-27e8e95ee907", null, "thuylinh@fpt.edu.vn", true, "Thùy Linh", null, false, null, "THUYLINH@FPT.EDU.VN", "THUYLINH", "AQAAAAIAAYagAAAAED9dU2XhG/+Rvh/utRST8RqKZ9EX4NQCta3eDZnJhmTGHqitPAZSfHu/Cw6Jgs3fhg==", null, false, "dfa13c28-fc4d-419b-a1e5-2cde89e47056", false, "thuylinh", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f2"), 0, null, "515a356d-a9c3-45fb-aa90-9453b186421d", null, "hoaithu@fpt.edu.vn", true, "Hoài Thu", null, false, null, "HOAITHU@FPT.EDU.VN", "HOAITHU", "AQAAAAIAAYagAAAAEGZLTwcepfEq1GMrkGRl9Jbv2i0hdODWSx3xPAQBAALdpolmzYYcKXRBH85IEMwAOA==", "0355881011", false, "6378a2e4-8f93-4b7f-af3a-3232628abe3f", false, "hoaithu", true },
                    { new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"), 0, null, "ee9efd1a-6208-40a9-bd26-e8bc1b0ed31e", null, "support@dulichtoday.com", true, "Dulich Today", null, false, null, "SUPPORT@DULICHTODAY.COM", "DULICHTODAYACCOUNT", "AQAAAAIAAYagAAAAEA+Fq7UBPBgIvmQHqOfWiZ16fbeKYeS52/Nui0/kLpFDC1BjuUDMQE5y100M6lwY+Q==", null, false, "0d89857b-4625-42bd-ad82-4f83f99684de", false, "DulichTodayAccount", true },
                    { new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"), 0, null, "5dc912b7-f66f-4940-b234-38c6d29a39d9", null, "info@fiditour.com", true, "Fiditour", null, false, null, "INFO@FIDITOUR.COM", "FIDITOURACCOUNT", "AQAAAAIAAYagAAAAEO3ToVuDFh39g77I/KontOdL8yDF59VmMIDhc1uDMkD+v0mcNtI/8pZL4wTCvWeejQ==", null, false, "212a36e7-9c9b-4a3b-9562-fa80ee5a4413", false, "FiditourAccount", true },
                    { new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"), 0, "https://example.com/avatar7.jpg", "c3744fb7-7512-4fba-b8ce-0d7ca7e5247d", new DateTime(1993, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "oliviakim@example.com", true, "Olivia Kim", false, false, null, "OLIVIAKIM@EXAMPLE.COM", "OLIVIAKIM", "AQAAAAIAAYagAAAAEJAlo8OIR6y3XcT4kRhzQetQGG70rHkp+a2NlpGnRsEGMipCxYcmvx5uui/hAK2phQ==", "0355881019", false, "9c4c2716-8d97-4986-a7d8-ae66a2b5a7bc", false, "OliviaKim", true }
                });

            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "BankAccountId", "AccountName", "AccountNumber", "BankName", "BranchName", "CreatedDate", "IsPrimary", "OwnerId", "OwnerType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("050d034f-4686-4ea7-9c35-e9deb2c9cac9"), "Vũng Tàu Travel", "0011009557357", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7665), true, new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), 0, null },
                    { new Guid("088a2f38-d954-4010-8c32-f82f8c1b43c5"), "Hanoitourist", "0011003886738", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7515), true, new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), 0, null },
                    { new Guid("0e827bb2-923a-4976-838b-a89c59966f66"), "Hà Giang Farmstay & Trek", "0011001586839", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7342), true, new Guid("10000000-0000-0000-0000-000000000006"), 1, null },
                    { new Guid("1c8020d8-7d51-4c44-a6fe-c4f9927d8897"), "Farmstay Nho & Thanh Long Bắc Bình", "0011003802667", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7369), true, new Guid("10000000-0000-0000-0000-000000000009"), 1, null },
                    { new Guid("2728b208-bff4-4a96-8962-07cd0488034e"), "Trang Trại Châu Đốc", "0011002092345", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7412), true, new Guid("10000000-0000-0000-0000-000000000015"), 1, null },
                    { new Guid("29624ca5-48ed-4b0e-8354-915f257e3979"), "Đà Lạt Organic Farm Tour", "0011003524949", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7349), true, new Guid("10000000-0000-0000-0000-000000000008"), 1, null },
                    { new Guid("42d74e27-52cc-4cf5-a9e2-d9e9b3587a12"), "Sa Pa Eco Farm Tour", "0011004837337", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7327), true, new Guid("10000000-0000-0000-0000-000000000002"), 1, null },
                    { new Guid("448cb60b-7399-4d68-880c-7614cd506684"), "Công ty Cổ phần Vietravel", "0011007303004", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7477), true, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0, null },
                    { new Guid("453cffe9-8f64-483d-8de6-dbf52018a291"), "Trà My Sâm Ngọc Linh Tour", "0011009644120", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7345), true, new Guid("10000000-0000-0000-0000-000000000007"), 1, null },
                    { new Guid("5eec82e2-5b91-4e92-8a58-6a3b724ad816"), "Saigontourist", "0011009275354", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7481), true, new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), 0, null },
                    { new Guid("63159b26-fe6d-484f-80c1-9326e488647d"), "Dulichtoday", "0011002415541", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7620), true, new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), 0, null },
                    { new Guid("63214db8-d5ff-4077-a637-fa58a5de5aa2"), "Redtour", "0011007323028", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7616), true, new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), 0, null },
                    { new Guid("653b15d8-8d1a-4888-8250-e2eee672eb1b"), "Du Lịch Sinh Thái Thác Bản Giốc", "0011009634102", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7319), true, new Guid("10000000-0000-0000-0000-000000000001"), 1, null },
                    { new Guid("6b224989-4243-4e75-8e8c-47a0fcfdfdf0"), "Buôn Đôn Coffee Farm Tour", "0011007884128", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7339), true, new Guid("10000000-0000-0000-0000-000000000005"), 1, null },
                    { new Guid("6d965802-0b36-4183-af98-846afee8e057"), "Trang Trại Nông Sản Sạch Càng Long", "0011009831485", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7407), true, new Guid("10000000-0000-0000-0000-000000000013"), 1, null },
                    { new Guid("714f6762-3471-4432-aa91-e12631b91220"), "Bamboo Travel", "0011007713759", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7605), true, new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), 0, null },
                    { new Guid("7e3fc7fe-8fad-4240-bd24-c5fa9e64f7be"), "Nha Trang Holiday", "0011002853694", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7730), true, new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), 0, null },
                    { new Guid("7fe454c1-80af-4e7c-8752-799c0dead268"), "Nông Trại Chè Trải Nghiệm Đại Từ", "0011001564444", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7333), true, new Guid("10000000-0000-0000-0000-000000000004"), 1, null },
                    { new Guid("89638dd9-16c3-4f88-a60e-f4ecc10f54b2"), "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", "0011009937808", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7175), true, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null },
                    { new Guid("89bca247-453f-4069-be7a-5db1ae170036"), "Phan Thiết Tours", "0011003935867", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7734), true, new Guid("22275542-0625-47be-a503-2f13b7576e9b"), 0, null },
                    { new Guid("8a4f8b65-8fff-4116-abf3-d7bc1434a68a"), "Trang Trại Nông Sản Sạch Tân Châu", "0011009856120", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7376), true, new Guid("10000000-0000-0000-0000-000000000011"), 1, null },
                    { new Guid("ade44f49-4a64-434e-8111-89e443ea7608"), "Farm Du Lịch Grape Valley", "0011006338669", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7330), true, new Guid("10000000-0000-0000-0000-000000000003"), 1, null },
                    { new Guid("b8b6b7f1-b1b1-4d98-97d2-e2bb0c340659"), "Fiditour", "0011002378928", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7518), true, new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), 0, null },
                    { new Guid("baa7be31-87b1-4fdb-a056-4b80febc770d"), "Trải nghiệm Nông trại Biển & Rau Tuy An", "0011004182579", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7379), true, new Guid("10000000-0000-0000-0000-000000000012"), 1, null },
                    { new Guid("be77ffe0-93ba-4832-b941-2bcbe7d5e6d0"), "Phương Nam Travel", "0011009222948", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7608), true, new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), 0, null },
                    { new Guid("d2b61134-410d-46aa-ac3a-8c4c334370fb"), "Danang Travel", "0011004495523", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7521), true, new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), 0, null },
                    { new Guid("d31bc9bd-dcaa-4dcf-8ea0-2ce246513f89"), "Mỹ Xuyên Farmstay", "0011006745900", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7410), true, new Guid("10000000-0000-0000-0000-000000000014"), 1, null },
                    { new Guid("e66c0c05-7f4b-4267-a87d-108c5a85e8ef"), "VietSun Travel", "0011008259236", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7603), true, new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), 0, null },
                    { new Guid("ed88e3bb-0633-4eb2-8ac3-4eacaf41d85b"), "Đất Việt Tour", "0011005256630", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7612), true, new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), 0, null },
                    { new Guid("f7951de0-f1d8-4a59-ac04-b605b216ccd6"), "Havatravel", "0011005978166", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7624), true, new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), 0, null },
                    { new Guid("fd469398-a0d3-4c27-99aa-64d1b3820f5c"), "Ba Bể Lake Ecofarm Tour", "0011006783004", "Vietcombank", "Hanoi Branch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7374), true, new Guid("10000000-0000-0000-0000-000000000010"), 1, null }
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
                    { 1, "SmtpServer", 0, "smtp.gmail.com", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3770), null },
                    { 2, "Port", 0, "587", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3776), null },
                    { 3, "Email", 0, "thangnvse151059@fpt.edu.vn", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3778), null },
                    { 4, "AppPassword", 0, "sllgcjfbkpgcwnmp", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3779), null },
                    { 5, "TmnCode", 1, "KC8MB258", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3780), null },
                    { 6, "HashSecret", 1, "02Y8EHIO9SPTGHUHOAMPUUISF3P4H2S2", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3781), null },
                    { 7, "Url", 1, "https://sandbox.vnpayment.vn/paymentv2/vpcpay.html", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3783), null },
                    { 8, "Command", 1, "pay", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3784), null },
                    { 9, "CurrCode", 1, "VND", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3785), null },
                    { 10, "Version", 1, "2.1.0", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3786), null },
                    { 11, "Locale", 1, "vn", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3787), null },
                    { 12, "PaymentBackReturnUrl", 1, "https://localhost:5001/api/tourist/order/return_order", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3788), null },
                    { 13, "BookingUrl", 1, "https://localhost:5001/api/tourist/book-tour/return_book", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3789), null },
                    { 14, "OrderUrl", 1, "https://localhost:5001/api/tourist/order/return_order", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3790), null }
                });

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0a92bf87-7c1f-4787-a22a-a1468de16b5e"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6402), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("15f51840-743b-4d56-930e-8f82565c9410"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6417), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("3979a325-a06d-45e8-be68-27e958fa5ba0"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6394), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("5e5b45b5-6d03-43a9-b9c5-e44ec3c10c75"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6399), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("7dade63b-fb15-4a73-bb48-23bc5205adfc"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6415), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("82dbd508-b1e1-4ea6-b618-26014215ee20"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6414), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("b40d6f20-cefe-4862-9d2f-ceead9dc7902"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6406), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("cea725d7-550e-4ba9-b062-a571a1119e28"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6400), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("ddd99071-3a40-4de2-b5df-55f582d98629"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6396), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("ee352b38-50f5-4a64-a877-5065e94574aa"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6404), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("ef048ca4-a317-4ce5-aadf-70d55fc70045"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6412), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("f45bf3ea-17f9-443d-9294-8b794d2044f8"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(6410), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null }
                });

            migrationBuilder.InsertData(
                table: "UserSupport",
                columns: new[] { "SupportId", "Email", "Fullname", "IsResolved", "IssueType", "RequestDate", "ResponeBy", "ResponseDate", "ResponseMessage", "SupportMessage", "TouristFacilityId", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5883), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5881), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("d549690a-59da-4c91-8179-7ba2102800e2"), "thangnvse151000@fpt.edu.vn", "Nguyễn Việt Thắng", false, 3, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5875), null, null, null, "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("2fe3ae82-5295-4584-a455-d4a4078042ad"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2101.hoabinh.jpg?alt=media&token=9da1280b-fca0-48a3-aacb-a8598212f33c", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("449a4f12-6804-4cd6-b446-3ef9af23d933"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F185215_1-dongnai02.jpg?alt=media&token=6641c733-758a-4e47-a816-f18757f3d646", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("45c51f1e-0819-4fc9-9924-09f791cbe656"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fbemacatf_2929-(1).jpg?alt=media&token=cccce681-3652-4a07-a2ff-b972392c84da", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("5e117c61-8659-4552-b923-fceada5e0ba3"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2007lamdong1-1689837807306-16898378088711727831861.jpg?alt=media&token=17bcc062-4fb7-4996-8108-5b6f6ff9809a", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("650c5cb7-7901-4d7c-8d18-f7f935abb6ba"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F1110.binh-lieu.jpg?alt=media&token=98060066-e58f-4a1d-929f-76c2f4017475", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("690ff5e8-84e3-4074-8cf4-4488ebbe2d3a"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2.jpeg?alt=media&token=8dc70894-e01b-4caf-83dd-68dad34318c2", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("71a18fbd-a79e-4bec-bc96-b7752c082f80"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F114885_LTT_4830.jpg?alt=media&token=50e303f4-7cc3-42c1-a79e-f5041a1d4389", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("94b9b8e5-127f-436a-89e0-df87c21aa9b3"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Ftet-2.jpg?alt=media&token=6d28efb3-2ed9-4ca9-907e-de6b6c190a5f", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("95ee0c5e-adaa-445f-bf51-4b7e95eaacd3"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2273623_quang_canh_khong_gian_chinh_to_chuc_le_hoi_14003627.jpg?alt=media&token=4023df7a-8efc-4de0-b6dd-b5cdfa0af4d0", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("a716d9c2-d3b0-4536-889e-19af8d1ed39a"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fz4892392984516_d64f19ae34659675050a19405d2f2f06_20231118151316.jpg?alt=media&token=88ce1721-d11a-4f70-975f-8159879d38af", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("b1e5d49b-5856-49e4-8100-3bfd226cd889"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F0-2346.webp?alt=media&token=60da574f-ccd0-4e3d-9bf6-74a1c6a64728", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("d60bea65-fbaf-4efb-89b4-2af698156432"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fdsc4926-1737442964915949022440.webp?alt=media&token=f4a50238-d2f3-4032-ba89-65c47093ac0a", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null }
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
                    { new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), "120 Phan Chu Trinh, TP.Huế", "Công ty du lịch chuyên nghiệp tại Huế.", "Havatravel", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3906), "contact@havatravel.com", "https://img.freepik.com/premium-vector/tours-travel-logo-with-airplane-passing-blue-world_101890-71.jpg?w=2000", null, new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"), "https://havatravel.com/" },
                    { new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), "45 Điện Biên Phủ, Quận 3, TP.HCM", "Chuyên tour du lịch nội địa và quốc tế.", "VietSun Travel", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3882), "contact@vietsuntravel.com", "https://th.bing.com/th/id/OIP.nwXDxpVx9hsOdW9efOtlRAHaDq?w=334&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"), "https://vietsuntravel.com/" },
                    { new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), "15 Phạm Ngũ Lão, Quận 1, TP.HCM", "Dịch vụ du lịch cao cấp.", "Bamboo Travel", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3886), "contact@bambotravel.com", "https://th.bing.com/th/id/OIP.8nxVZ-RcEPQMdis_Yg4TWAHaHa?w=180&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"), "https://bambotravel.com/" },
                    { new Guid("22275542-0625-47be-a503-2f13b7576e9b"), "23 Lê Lợi, TP. Phan Thiết", "Chuyên tour khám phá biển và cát trắng.", "Phan Thiết Tours", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3916), "contact@phanthiettours.com", "https://th.bing.com/th/id/OIP.KBj43NwwtJw5Ht71M6ts8gHaF7?rs=1&pid=ImgDetMain", null, new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"), "https://phanthiettours.com/" },
                    { new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), "50 Nguyễn Trãi, TP. Vũng Tàu", "Tour du lịch biển chất lượng cao.", "Vũng Tàu Travel", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3909), "info@vungtautravel.com", "https://mir-s3-cdn-cf.behance.net/project_modules/1400/2cf01f84467867.5d5da886617be.jpg", null, new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"), "https://vungtautravel.com/" },
                    { new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), "90 Nguyễn Văn Linh, Đà Nẵng", "Thông tin và tổ chức tour du lịch.", "Dulichtoday", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3900), "support@dulichtoday.com", "https://png.pngtree.com/png-clipart/20200722/original/pngtree-travel-and-tour-logo-png-image_5051851.jpg", null, new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"), "https://dulichtoday.com/" },
                    { new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), "75 Hùng Vương, TP. Nha Trang", "Dịch vụ đặt tour du lịch biển chuyên nghiệp.", "Nha Trang Holiday", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3912), "support@nhatrangholiday.com", "https://th.bing.com/th/id/OIP.inoQUXN-Y4DfWTpe5-ec-gHaFJ?w=241&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"), "https://nhatrangholiday.com/" },
                    { new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), "15 Lê Lợi, Quận 1, TP.HCM", "Tour trọn gói, uy tín.", "Fiditour", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3877), "info@fiditour.com", "https://th.bing.com/th/id/OIP.kzYdv7-VmS2zRF7qZaOyvwAAAA?w=212&h=212&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"), "https://fiditour.com/" },
                    { new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), "99 Hoàng Diệu, Ba Đình, Hà Nội", "Du lịch chất lượng, giá rẻ.", "Phương Nam Travel", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3890), "info@phuongnamtravel.com", "https://th.bing.com/th/id/OIP.p6Shq1r_4g--m-4Q8nIUfgHaHa?rs=1&pid=ImgDetMain", null, new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"), "https://phuongnamtravel.com/" },
                    { new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), "10 Lê Thánh Tôn, Quận 1, TP.HCM", "Chuyên tổ chức tour du lịch trong và ngoài nước.", "Đất Việt Tour", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3893), "contact@datviettour.com", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSMJbyGoIQYOyNFDh34TrlaOOozlKmiTefzoQ&s", null, new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"), "https://datviettour.com/" },
                    { new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), "20 Trần Hưng Đạo, Hà Nội", "Dịch vụ du lịch chất lượng cao.", "Redtour", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3896), "info@redtour.com.vn", "https://th.bing.com/th/id/OIP.zD605q-X7zzIpJAgyfVvwQHaHa?pid=ImgDet&w=184&h=184&c=7&dpr=1.3", null, new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"), "https://redtour.com.vn/" },
                    { new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), "90 Nguyễn Thị Minh Khai, Đà Nẵng", "Chuyên tour biển đảo Đà Nẵng.", "Danang Travel", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3879), "info@danangtravel.com", "https://th.bing.com/th/id/OIP.vj2L0nLe0ocGi4pxbLwnowHaHa?w=200&h=199&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("d0e45bee-a768-4555-bfeb-788728a53751"), "https://danangtravel.com/" },
                    { new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), "25 Nguyễn Huệ, Quận 1, TP.HCM", "Lữ hành hàng đầu Việt Nam.", "Saigontourist", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3866), "contact@saigontourist.net", "https://icolor.vn/wp-content/uploads/2021/01/Tham-kh%E1%BA%A3o-Logo-c%C3%B4ng-ty-du-l%E1%BB%8Bch-Saigontourist-3.jpg", null, new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"), "https://saigontourist.net/" },
                    { new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"), "66 Trần Phú, TP. Quy Nhơn", "Tour du lịch biển và văn hóa Quy Nhơn.", "Quy Nhơn Explorer", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3931), "contact@quynhonexplorer.com", "https://th.bing.com/th/id/OIP.lVVxjoYVel7RgNeu1hH2RgHaFr?rs=1&pid=ImgDetMain", null, new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"), "https://quynhonexplorer.com/" },
                    { new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"), "14 Nguyễn Huệ, TP. Đà Lạt", "Tour du lịch khám phá Đà Lạt.", "Đà Lạt Tour", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3919), "info@dalattour.com", "https://images-platform.99static.com/OowUwWHMa4KA7v_azo1Bq_7ByCs=/6x0:1001x995/500x500/top/smart/99designs-contests-attachments/86/86578/attachment_86578583", null, new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"), "https://dalattour.com/" },
                    { new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), "101 Trần Hưng Đạo, Hoàn Kiếm, Hà Nội", "Tour du lịch nội địa và quốc tế.", "Hanoitourist", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(3870), "support@hanoitourist.com", "https://th.bing.com/th/id/OIP.DQh7E8nzGNx-fipB0stcygHaGf?w=190&h=180&c=7&r=0&o=5&dpr=1.3&pid=1.7", null, new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"), "https://hanoitourist.com/" },
                    { new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), "03 Hai Bà Trưng, Hoàn Kiếm, Hà Nội.", "", "Công ty Cổ phần Vietravel", new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "vtv.cholon@vietravel.com", "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcQWyblRzW2ET2uC9wdJBm6_PUq1zCiSi6SGJw&s", null, new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), "https://travel.com.vn/" }
                });

            migrationBuilder.InsertData(
                table: "TouristFacility",
                columns: new[] { "TouristFacilityId", "Address", "ContactInfor", "CreateDate", "Description", "EmailTouristFacility", "LogoURL", "TouristFacilityName", "UpdateTime", "UserId", "Website", "district_id", "district_name", "phone", "province_name", "ward_code", "ward_name" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Xã Đàm Thủy, Huyện Trùng Khánh, Cao Bằng", "0206 388 8888", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4051), "Khu du lịch sinh thái kết hợp nông nghiệp tại vùng biên giới Thác Bản Giốc.", "contact@bangiocfarmtour.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F-8824-1745223484_860x0.jpg?alt=media&token=fb1bda90-6cdd-4217-a7b0-4a4d37a31bbb", "Du Lịch Sinh Thái Thác Bản Giốc", null, new Guid("10000000-0000-0000-0000-000000000001"), "www.bangiocfarmtour.vn", 1976, "Huyện Mộc Châu", "0988888999", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Thôn Cát Cát, Xã San Sả Hồ, Sa Pa", "0214 666 7777", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4077), "Tour trải nghiệm nông nghiệp và văn hóa H'Mông tại bản Cát Cát.", "eco@sapa.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fthac-cat-cat-tho-mong3.jpg?alt=media&token=29507071-2069-4ca3-b3b3-1665e293a282", "Sa Pa Eco Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000002"), "www.sapaecotour.vn", 1976, "Huyện Mộc Châu", "0911777555", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Thôn Thái An, Xã Vĩnh Hải, Huyện Ninh Hải", "0259 333 4567", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4081), "Trải nghiệm hái nho, làm rượu vang và nghỉ dưỡng tại thung lũng nho.", "info@grapevalley.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fvuon-nho-thai-an-2-1-1024x614.webp?alt=media&token=e7af45e4-d132-45e8-aca3-07787d22528b", "Farm Du Lịch Grape Valley", null, new Guid("10000000-0000-0000-0000-000000000003"), "www.grapevalley.vn", 1976, "Huyện Mộc Châu", "0909000011", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Xóm Cầu Tre, Xã La Bằng, Huyện Đại Từ", "0208 123 4567", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4085), "Du lịch nông nghiệp kết hợp trải nghiệm hái chè, sao chè và thưởng thức tại chỗ.", "farm@daitu.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fthai-nguyen-17435107247911118713237.jpg?alt=media&token=c3f1ab76-1e22-4e54-a2b8-f9085b18d47c", "Nông Trại Chè Trải Nghiệm Đại Từ", null, new Guid("10000000-0000-0000-0000-000000000004"), "www.daitu-teafarm.vn", 1976, "Huyện Mộc Châu", "0977000111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "Xã Ea M’nang, Huyện Cư M’gar, Đắk Lắk", "0262 888 8899", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4090), "Tour trải nghiệm vườn cà phê, tham quan quy trình rang xay và cưỡi voi Buôn Đôn.", "visit@buondoncoffee.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F20220314-161611-QzoiJN59.webp?alt=media&token=a5eb0314-334f-4769-bde3-b06e2d609274", "Buôn Đôn Coffee Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000005"), "www.buondoncoffee.vn", 1976, "Huyện Mộc Châu", "0918888777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "Xã Sà Phìn, Huyện Đồng Văn", "0219 366 6888", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4099), "Trải nghiệm cuộc sống vùng cao, làm nông, làm bánh truyền thống và trekking đèo đá.", "trek@hagiang.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ftam-gia-c-ma-ch-ha-giang-vnexpress-3-1571666979.webp?alt=media&token=70e2dc65-1f50-4a28-a48f-62b42ddcc235", "Hà Giang Farmstay & Trek", null, new Guid("10000000-0000-0000-0000-000000000006"), "www.hagiangfarmstay.vn", 1976, "Huyện Mộc Châu", "0988999111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Xã Trà Linh, Huyện Nam Trà My", "0235 322 3222", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4103), "Khám phá vườn sâm Ngọc Linh, trải nghiệm trồng sâm, thưởng thức dược liệu.", "info@tramyfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2FHHKD2333-900x600.jpg?alt=media&token=169fa448-c537-46dd-895c-381865ffb514", "Trà My Sâm Ngọc Linh Tour", null, new Guid("10000000-0000-0000-0000-000000000007"), "www.tramyfarmtour.vn", 1976, "Huyện Mộc Châu", "0966555777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Phường 7, Thành phố Đà Lạt", "0263 355 8888", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4105), "Du lịch trải nghiệm trồng dâu, làm rau thủy canh, check-in nông trại xanh.", "info@dalatorganic.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fmaxresdefault.jpg?alt=media&token=21b101b4-89c4-42cb-bb2b-65b0cd229be6", "Đà Lạt Organic Farm Tour", null, new Guid("10000000-0000-0000-0000-000000000008"), "www.dalatorganic.vn", 1976, "Huyện Mộc Châu", "0933222111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Xã Phan Thanh, Huyện Bắc Bình", "0252 355 9000", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4109), "Trải nghiệm hái nho, tham quan vườn thanh long sạch và picnic giữa đồng nắng gió Bình Thuận.", "hello@binhthuanfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F18fcefcc98cb5d9504da.jpg?alt=media&token=f8859fe5-b77e-476e-bfea-25c22cadf72a", "Farmstay Nho & Thanh Long Bắc Bình", null, new Guid("10000000-0000-0000-0000-000000000009"), "www.binhthuanfarm.vn", 1976, "Huyện Mộc Châu", "0933444555", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Xã Nam Mẫu, Huyện Ba Bể", "0209 366 2333", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4134), "Trải nghiệm chèo thuyền, nông nghiệp sinh thái, ở nhà sàn truyền thống người Tày.", "contact@babeecotour.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fz4273865435811_cb279364c608be7f093bda58a64acfd3-nongnghiep-170638.jpg?alt=media&token=952a2a5d-0d1f-44d9-8332-cc4659752bd8", "Ba Bể Lake Ecofarm Tour", null, new Guid("10000000-0000-0000-0000-000000000010"), "www.babeecotour.vn", 1976, "Huyện Mộc Châu", "0966001122", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000011"), "Xã Tân Hưng, Huyện Tân Châu", "0276 366 7788", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4137), "Khám phá quy trình trồng rau hữu cơ, nuôi bò sữa, làm sữa chua và trồng nấm sạch.", "info@tayninhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F835b7b66.jpg?alt=media&token=259978a6-a141-40d8-b3a0-42b7d5a67947", "Trang Trại Nông Sản Sạch Tân Châu", null, new Guid("10000000-0000-0000-0000-000000000011"), "www.tayninhfarm.vn", 1976, "Huyện Mộc Châu", "0944111222", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000012"), "Xã An Chấn, Huyện Tuy An", "0257 388 8888", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4140), "Trải nghiệm canh tác rau ven biển, tắm biển, đốt lửa trại và học làm nước mắm truyền thống.", "tour@phuyentour.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F4-1708062548800.webp?alt=media&token=dcbe2825-b390-49fa-b21b-14f53ee19f5b", "Trải nghiệm Nông trại Biển & Rau Tuy An", null, new Guid("10000000-0000-0000-0000-000000000012"), "www.phuyentour.vn", 1976, "Huyện Mộc Châu", "0977222333", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000013"), "Xã Mỹ Long Bắc, Huyện Càng Long", "0294 355 1122", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4145), "Khám phá quy trình sản xuất mắm, trồng cây ăn trái và sản phẩm nông sản sạch.", "contact@travinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F11%20(42).jpg?alt=media&token=9dfb8626-bc21-4d09-a374-a91ec8e3b319", "Trang Trại Nông Sản Sạch Càng Long", null, new Guid("10000000-0000-0000-0000-000000000013"), "www.travinhfarm.vn", 1976, "Huyện Mộc Châu", "0908222333", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000014"), "Xã Mỹ Xuyên, Huyện Mỹ Xuyên", "0299 555 2333", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4148), "Trải nghiệm mô hình nông nghiệp hữu cơ, tham quan các cánh đồng lúa, vườn cây ăn trái.", "tour@soctrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F23.12.-DL-Sinh-thai-My-Hoa-Hung-1-1024x576%20(1).jpg?alt=media&token=d1487100-cca6-4bbd-880f-b7824a266507", "Mỹ Xuyên Farmstay", null, new Guid("10000000-0000-0000-0000-000000000014"), "www.soctrangfarm.vn", 1976, "Huyện Mộc Châu", "0933112233", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000015"), "Xã Vĩnh Tế, Huyện Châu Đốc", "0296 388 1133", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4152), "Trải nghiệm canh tác nông nghiệp tại đồng bưng, tham quan vườn trái cây đặc sản miền Tây.", "contact@angiangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fdu-lich-miet-vuon-7_1631758474.jpg?alt=media&token=c8ad0b62-50d1-4625-81f6-c418467da795", "Trang Trại Châu Đốc", null, new Guid("10000000-0000-0000-0000-000000000015"), "www.angiangfarm.vn", 1976, "Huyện Mộc Châu", "0977445566", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000016"), "Xã Nhơn Ái, Huyện Phong Điền", "0292 388 1222", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4155), "Trải nghiệm mô hình trồng cây trái, tham quan các vườn rau hữu cơ và chợ nổi Cần Thơ.", "info@canthoexplore.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fimg_1732330219066_o_1idbeqphmbm29dj1ubq1jl81474d.jpg?alt=media&token=f96b59da-0276-4805-b58f-bcbbdb37bad0", "Cần Thơ Farmstay", null, new Guid("10000000-0000-0000-0000-000000000016"), "www.canthoexplore.vn", 1976, "Huyện Mộc Châu", "0939332111", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000017"), "Xã Cửa Dương, Huyện Phú Quốc", "0297 223 4455", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4158), "Tham quan mô hình nông nghiệp hữu cơ, vườn dưa lưới, vườn trái cây nhiệt đới.", "tour@phuquocfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fdua-luoi-7-061822_327-062713.jpg?alt=media&token=3cbc44a6-67a9-49dd-b28f-5403391b186b", "Phú Quốc Nông Trại Sản Xuất Hữu Cơ", null, new Guid("10000000-0000-0000-0000-000000000017"), "www.phuquocfarm.vn", 1976, "Huyện Mộc Châu", "0909888777", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000018"), "Xã Đồng Mai, TP. Hạ Long", "0203 356 7890", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4161), "Trải nghiệm mô hình trồng rau hữu cơ và nuôi trồng thủy sản, tham quan khu vườn cây ăn trái đặc sản.", "info@halongfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fvung(1).jpg?alt=media&token=39115e9e-dec1-4982-9638-899d54f7a488", "Trại Nông Sản Hạ Long", null, new Guid("10000000-0000-0000-0000-000000000018"), "www.halongfarm.vn", 1976, "Huyện Mộc Châu", "0912345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000019"), "Xã An Thắng, Huyện An Lão", "0225 350 1000", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4164), "Khám phá mô hình trồng trọt và chăn nuôi, học hỏi cách trồng rau sạch và gia cầm.", "contact@anlaofarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fmuc-so-thi-vuon-rau-huu-co-tho-canh-va-thuy-canh-1833_20230315_542-154329.jpeg?alt=media&token=ce7b46e6-7256-4a0f-8706-dc77675f512d", "Trang Trại Nông Sản An Lão", null, new Guid("10000000-0000-0000-0000-000000000019"), "www.anlaofarm.vn", 1976, "Huyện Mộc Châu", "0932556789", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000020"), "Xã Phú Lạc, Huyện Đại Từ", "0208 382 5000", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4168), "Trải nghiệm các hoạt động nông nghiệp như trồng lúa, chăm sóc vườn rau và tham gia các hoạt động nông dân.", "tour@daitufarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fdu-lich-nong-nghiep-3.jpg?alt=media&token=de31295c-a66b-445d-8182-9055639cc598", "Nông Trại Đại Từ", null, new Guid("10000000-0000-0000-0000-000000000020"), "www.daitufarm.vn", 1976, "Huyện Mộc Châu", "0988776655", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000021"), "Xã Nghi Phú, TP. Vinh", "0238 379 1111", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4171), "Khám phá các vườn cây ăn trái, trồng rau hữu cơ và tìm hiểu về sản phẩm nông sản của vùng đất xứ Nghệ.", "contact@vinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fbase64-1723456186444345111180.webp?alt=media&token=7e8bd8c2-28e4-43b2-aece-09355b55bd61", "Trại Nông Sản Vinh", null, new Guid("10000000-0000-0000-0000-000000000021"), "www.vinhfarm.vn", 1976, "Huyện Mộc Châu", "0912233445", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000022"), "Xã Sơn Lâm, Huyện Triệu Sơn", "0237 375 6789", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4176), "Tham gia vào các hoạt động nông nghiệp như thu hoạch rau, chăm sóc cây ăn trái, tham quan vườn thuốc nam.", "contact@trieusonfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fkhu-vuon-trong-nong-san-sach-0-1641207763997.webp?alt=media&token=33a5a74c-8d0b-4bfb-b0dd-1f9dc9e3607b", "Trang Trại Nông Sản Triệu Sơn", null, new Guid("10000000-0000-0000-0000-000000000022"), "www.trieusonfarm.vn", 1976, "Huyện Mộc Châu", "0988112233", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000023"), "Xã Thạch Hưng, TP. Hà Tĩnh", "0239 354 5678", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4179), "Khám phá nông sản hữu cơ, tham gia các hoạt động làm vườn và trồng cây ăn quả.", "contact@hatinhfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ft3a_20240425210851.jpg?alt=media&token=b77127b1-30b3-45c5-b547-c8324de43606", "Trại Nông Sản Hà Tĩnh", null, new Guid("10000000-0000-0000-0000-000000000023"), "www.hatinhfarm.vn", 1976, "Huyện Mộc Châu", "0916889900", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000024"), "Xã Quảng Phú, TP. Đồng Hới", "0232 382 7890", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4182), "Trải nghiệm nông nghiệp sinh thái với các mô hình trồng cây, chăm sóc động vật và tham quan các khu vườn.", "contact@donghoifarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F11-1611829270-mo-hinh-trong-dau-tay-da-lat-3.jpg?alt=media&token=d4626806-3666-4331-a7df-53cd52eb18c2", "Trang Trại Đồng Hới", null, new Guid("10000000-0000-0000-0000-000000000024"), "www.donghoifarm.vn", 1976, "Huyện Mộc Châu", "0977223344", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000025"), "Xã Hải Lệ, TP. Đông Hà", "0233 350 5678", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4185), "Khám phá các mô hình trồng cây dược liệu và rau hữu cơ, tham gia các hoạt động chăm sóc động vật.", "contact@donghafarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa1.png?alt=media&token=8397bb0a-f130-4be6-abbe-aeceac5bc8e1", "Trang Trại Nông Sản Đông Hà", null, new Guid("10000000-0000-0000-0000-000000000025"), "www.donghafarm.vn", 1976, "Huyện Mộc Châu", "0912345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000026"), "Xã Phước Sơn, TP. Quy Nhơn", "0256 382 7890", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4189), "Tham gia vào các hoạt động trồng rau hữu cơ và chăm sóc vườn trái cây, tìm hiểu sản phẩm nông sản đặc trưng của Bình Định.", "contact@quynhonfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fhanoimoi.com.vn-uploads-images-tuandiep-2020-03-02-_ba-dang-thi-cuoi-xa-dan-phuong-.jpg?alt=media&token=5d50e486-d791-4dcb-bfb2-87b9d7af8011", "Trại Nông Sản Quy Nhơn", null, new Guid("10000000-0000-0000-0000-000000000026"), "www.quynhonfarm.vn", 1976, "Huyện Mộc Châu", "0988776655", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000027"), "Xã Hòa Thịnh, TP. Tuy Hòa", "0257 355 6789", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4193), "Trải nghiệm các hoạt động trồng trọt, chăm sóc vườn cây ăn quả, tìm hiểu về các sản phẩm nông sản đặc biệt của Phú Yên.", "contact@tuyhoafarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F0603.phuyen2.jpg?alt=media&token=b90710db-3fee-47d4-ba7a-a4054ff6d83f", "Trang Trại Nông Sản Tuy Hòa", null, new Guid("10000000-0000-0000-0000-000000000027"), "www.tuyhoafarm.vn", 1976, "Huyện Mộc Châu", "0972345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000028"), "Xã Vĩnh Thạnh, TP. Nha Trang", "0258 382 9000", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4196), "Khám phá các mô hình trồng cây ăn quả, rau hữu cơ, và các hoạt động du lịch nông nghiệp kết hợp nghỉ dưỡng.", "contact@nhatrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fz4462200782496_874af9e67ff41504f733f389a740cb34.jpg?alt=media&token=e9324dd1-f67a-4b97-932f-321ce44f952f", "Trại Nông Sản Nha Trang", null, new Guid("10000000-0000-0000-0000-000000000028"), "www.nhatrangfarm.vn", 1976, "Huyện Mộc Châu", "0916345678", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000029"), "Xã Phước Hải, TP. Phan Rang-Tháp Chàm", "0259 382 1111", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4199), "Trải nghiệm du lịch nông nghiệp, tham quan các vườn cây ăn quả, mô hình trồng nho và sản xuất nông sản.", "contact@phanrangfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F1609.tham_quan_nong_trai_ho_vang_-_mo_hinh_du_lich_sach2.jpg?alt=media&token=178d2881-82bc-43dd-a0cc-650703da54dd", "Trại Nông Sản Phan Rang", null, new Guid("10000000-0000-0000-0000-000000000029"), "www.phanrangfarm.vn", 1976, "Huyện Mộc Châu", "0934567890", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000030"), "Xã Phú Hài, TP. Phan Thiết", "0252 382 5678", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4214), "Trải nghiệm các mô hình trồng cây nông sản và khám phá các sản phẩm đặc trưng của Bình Thuận như thanh long, dừa.", "contact@phanthietfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F114293275_161596928798230_7012125940469886738_o(1).jpg?alt=media&token=2106d196-7206-4cc3-9940-54cbb12d7e6c", "Trang Trại Nông Sản Phan Thiết", null, new Guid("10000000-0000-0000-0000-000000000030"), "www.phanthietfarm.vn", 1976, "Huyện Mộc Châu", "0982334455", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000031"), "Xã An Thạnh, TP. Tân An", "0272 384 5000", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4231), "Khám phá các mô hình trồng cây, chăm sóc cây ăn trái, và tìm hiểu về sản phẩm nông sản của Long An.", "contact@tananfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F631f711e5c833f7e0b2af244_vinhthuan7_high.jpg?alt=media&token=ddb786b7-89f7-4b53-871a-8c32d168dbd5", "Trại Nông Sản Tân An", null, new Guid("10000000-0000-0000-0000-000000000031"), "www.tananfarm.vn", 1976, "Huyện Mộc Châu", "0932456789", "Sơn La", "91295", "Phường 14" },
                    { new Guid("10000000-0000-0000-0000-000000000032"), "Xã Phước Hòa, TP. Vĩnh Long", "0270 382 8888", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4234), "Trải nghiệm du lịch nông nghiệp tại vườn cây ăn trái, học hỏi kỹ thuật trồng rau sạch và các hoạt động sinh thái.", "contact@vinhlongfarm.vn", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2F2-phat-trien-du-lich-con-nhieu-kho-khan-FILEminimizer.jpg_636705230132460445.jpg?alt=media&token=75d4bffb-4bb2-4aa7-8a0f-179e003f45c9", "Trại Nông Sản Vĩnh Long", null, new Guid("10000000-0000-0000-0000-000000000032"), "www.vinhlongfarm.vn", 1976, "Huyện Mộc Châu", "0913445566", "Sơn La", "91295", "Phường 14" },
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
                    { new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5898), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5899), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"), "anhNv@gmail.com", "Nguyễn Văn Anh", true, 3, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5885), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5889), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5904), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5906), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"), "AnhNLV1203@gmail.com", "Nguyễn Thị Lan Anh", true, 3, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5901), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5902), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null },
                    { new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"), "BinhLeV@gmail.com", "Lê Văn Bình", true, 3, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5894), new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5895), "Bạn thực hiện đăng nhập lại vào hệ thống tài khoản đã được kích hoạt lại.", "Tài khoản của em đăng nhập vào hệ thống không được do tài khoản đã bị khóa! Anh chị hỗ trợ e mở lại tài khoản ạ!", null, null }
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
                    { new Guid("20000000-0000-0000-0000-000000000001"), "3 tuổi", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(5983), "Trải nghiệm cuộc sống nông dân tại vùng biên giới, từ gieo trồng, chăm sóc gia súc đến thu hoạch nông sản cùng người dân địa phương.", 1.0, 3, new DateTime(2025, 4, 15, 16, 30, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fe1.jpg?alt=media\\u0026token=f05fa6e1-5083-45d9-a750-7ee06162c520\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fe2.jpg?alt=media\\u0026token=53afdfbf-5507-47ee-85d1-ec8442304f7e\"]", "Một Ngày Làm Nông Dân Vùng Biên", 19500000.0, 10700000.0, 15, new DateTime(2025, 4, 15, 7, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), "3 tuổi", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(5987), "Tham gia vào hoạt động thu hoạch mùa vụ cùng người dân địa phương, từ thu hoạch đến sơ chế và thưởng thức sản phẩm tươi ngon tại chỗ.", 1.0, 3, new DateTime(2025, 5, 1, 16, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ff1.jpg?alt=media\\u0026token=37caad37-477d-4e55-873f-2440551d954a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ff2.webp?alt=media\\u0026token=a23fd593-3c32-4b72-9ab8-c74e86fa3368\"]", "Trải Nghiệm Thu Hoạch Mùa Vụ", 16300000.0, 10800000.0, 20, new DateTime(2025, 5, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), "3 tuổi", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(5991), "Hành trình khám phá nét văn hóa độc đáo và hoạt động nông nghiệp truyền thống của đồng bào dân tộc Tày - Nùng, từ trải nghiệm trồng trọt đến thưởng thức ẩm thực và nghệ thuật dân gian.", 1.0, 3, new DateTime(2025, 5, 10, 17, 30, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fg1.jpg?alt=media\\u0026token=40bc8d8a-10a4-4a6b-a852-bd1ab79ae219\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fg2.jpg?alt=media\\u0026token=7d24a17f-5853-4bea-9aa3-488b283393ee\"]", "Khám Phá Nông Nghiệp và Văn Hóa Địa Phương", 19100000.0, 11700000.0, 20, new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), "3 tuổi", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(5995), "Trải nghiệm độc đáo kết hợp giữa học tập phương pháp canh tác hữu cơ và nghỉ dưỡng tại homestay sinh thái. Du khách được tham gia vào quy trình trồng trọt sạch và tận hưởng không gian yên bình của thiên nhiên.", 1.0, 3, new DateTime(2025, 5, 15, 19, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fh1.jpg?alt=media\\u0026token=835dc28e-4ea6-4e76-83e4-36591a577988\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fh2.png?alt=media\\u0026token=162ac610-9f4f-4b8e-b8b7-c16c83f500e1\"]", "Du Lịch Canh Tác Hữu Cơ Kết Hợp Nghỉ Dưỡng", 10900000.0, 11000000.0, 15, new DateTime(2025, 5, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("30000000-0000-0000-0000-000000000001"), "3 tuổi", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6003), "Trải nghiệm độc đáo về văn hóa nông nghiệp truyền thống của người H'Mông tại Cát Cát, từ canh tác trên ruộng bậc thang đến thu hái thuốc nam và nấu ăn truyền thống.", 1.0, 3, new DateTime(2025, 5, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fi1.webp?alt=media\\u0026token=d6f2d4c0-4439-4e9e-afd8-ef36d378a6c4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fi2.jpg?alt=media\\u0026token=76d6c2e9-fe9d-4f4a-abed-55e622effe0a\"]", "Một Ngày Làm Nông Dân H'Mông", 19600000.0, 11600000.0, 12, new DateTime(2025, 5, 20, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("30000000-0000-0000-0000-000000000002"), "3 tuổi", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6007), "Khám phá đời sống văn hóa độc đáo của người H'Mông tại bản Cát Cát, tìm hiểu về nông nghiệp hữu cơ và trải nghiệm làm nghề thủ công truyền thống.", 1.0, 3, new DateTime(2025, 5, 25, 17, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fk1.jpg?alt=media\\u0026token=8a1b82a5-d372-49c8-9437-ba1d221ebe90\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fk2.jpg?alt=media\\u0026token=1c08d579-60fe-4071-89fd-b58683ee5388\"]", "Hành Trình Khám Phá Bản Làng và Nông Nghiệp Hữu Cơ", 10300000.0, 11800000.0, 15, new DateTime(2025, 5, 25, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), "3 tuổi", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(5954), "Hành trình trải nghiệm nông nghiệp độc đáo tại Mộc Châu, từ tham quan nông trại dâu tây, vắt sữa bò đến thu hoạch rau hữu cơ. Du khách sẽ được trực tiếp tham gia vào các hoạt động nông nghiệp và thưởng thức đặc sản địa phương.", 1.0, 3, new DateTime(2025, 2, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa1.png?alt=media\\u0026token=0e6e621f-912a-4639-a51a-e94e183b95e8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa2.jpeg?alt=media\\u0026token=8159822e-9515-4532-9531-10c21c397218\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa3.webp?alt=media\\u0026token=d7b91ee8-ad6c-4ffa-a979-bcf01709d2c1\"]", "Khám Phá Nông Nghiệp Mộc Châu", 17100000.0, 10700000.0, 20, new DateTime(2025, 2, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), "3 tuổi", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(5971), "Trải nghiệm một ngày làm việc thực tế tại nông trại OCOP, từ chăm sóc vườn rau đến thu hoạch và đóng gói sản phẩm theo tiêu chuẩn.", 1.0, 3, new DateTime(2025, 3, 15, 17, 0, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc1.jpg?alt=media\\u0026token=e320026b-8c15-4ca0-9570-1c7f641c3b44\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc2.webp?alt=media\\u0026token=52f3e890-c777-421b-ba33-640a7c6b21b4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc4.jpg?alt=media\\u0026token=73e89a47-6420-43cd-8bd9-6cc18e3771c5\"]", "Một Ngày Làm Nông Dân OCOP", 12900000.0, 10800000.0, 12, new DateTime(2025, 3, 15, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), "3 tuổi", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(5965), "Trải nghiệm văn hóa trà truyền thống tại Mộc Châu, từ tham quan đồi chè, học cách hái và chế biến chè, đến thưởng thức các loại trà OCOP đặc sản.", 1.0, 3, new DateTime(2025, 3, 1, 16, 30, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fb1.jpg?alt=media\\u0026token=0baec450-2c25-49fe-b319-360b3f146c89\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fb2.jpg?alt=media\\u0026token=c93ad47c-b5fd-4864-ac53-6bf579f2e5ef\"]", "Tour Hái Chè và Thưởng Trà OCOP", 19800000.0, 11300000.0, 15, new DateTime(2025, 3, 1, 8, 30, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), "3 tuổi", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(5976), "Kết hợp du lịch với hoạt động thiện nguyện và bảo vệ môi trường, từ trồng cây xanh đến tham gia các hoạt động cộng đồng tại bản làng.", 1.0, 3, new DateTime(2025, 4, 1, 17, 30, 0, 0, DateTimeKind.Unspecified), null, null, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd1.jpg?alt=media\\u0026token=de1ecc18-0ac0-424c-93e9-5fb18a05cbc4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd2.jpg?alt=media\\u0026token=1bb550da-3a3b-4742-b23c-4075a45c7c0b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd3.png?alt=media\\u0026token=067466e8-32b9-427a-a2c6-739358f95017\"]", "Du Lịch Thiện Nguyện & Nông Nghiệp Xanh", 12300000.0, 10200000.0, 25, new DateTime(2025, 4, 1, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("476db871-81cc-4ad3-ad40-ad841d8ba1f1"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5791), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5790), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5790), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("841a508d-f54c-4a7b-89d8-c2e62153ff61"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5797), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5796), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5795), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "Contract",
                columns: new[] { "ContractId", "ContractContent", "CreateDate", "DiscountRate", "EndDate", "RequestReSignContract", "SignedDate", "SigningStatus", "StartDate", "Status", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0b2b06b2-c13d-4fa9-8c95-95594e21f094"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7972), 0.03m, new DateTime(2030, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7971), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7971), null, new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), null, null },
                    { new Guid("103c4cd5-f2d0-44c2-99ca-c2c5c5002819"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7969), 0.01m, new DateTime(2026, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7968), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7968), null, new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), null, null },
                    { new Guid("1bed4f96-2f0b-491d-ae64-2405f3e21e70"), "Hợp đồng đại lý du lịch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8062), 0.04m, new DateTime(2027, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8062), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8061), null, null, new Guid("10000000-0000-0000-0000-000000000013"), null },
                    { new Guid("214bc9e9-f1b0-4d82-a3d8-77efded7e425"), "Hợp đồng đại lý du lịch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7927), 0.05m, new DateTime(2028, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7890), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7885), null, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, null },
                    { new Guid("2b7880c4-71a8-432e-9056-df01cf30f30d"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8049), 0.05m, new DateTime(2027, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8048), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8048), null, null, new Guid("10000000-0000-0000-0000-000000000008"), null },
                    { new Guid("45e69df9-cc62-4e81-8768-92d105c90ac7"), "Thỏa thuận hợp tác phát triển sản phẩm du lịch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8003), 0.02m, new DateTime(2028, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8002), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8002), null, new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), null, null },
                    { new Guid("482d1f63-00be-447d-98bf-572c2ebee60f"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7995), 0.04m, new DateTime(2028, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7994), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7994), null, new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), null, null },
                    { new Guid("55c2e8ac-f5af-4bce-91fd-3490692ac344"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8037), 0.02m, new DateTime(2026, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8036), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8036), null, null, new Guid("10000000-0000-0000-0000-000000000003"), null },
                    { new Guid("5831370b-b6e4-4bd4-ba1f-c4ffd8da37cf"), "Hợp đồng đại lý du lịch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8035), 0.01m, new DateTime(2029, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8034), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8033), null, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("5968b704-8515-43a9-ac19-e250f3d65d04"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8030), 0.03m, new DateTime(2030, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8029), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8028), null, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("5edaead9-eddc-4a15-9aaa-aba4e86cdbb8"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8043), 0.04m, new DateTime(2030, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8042), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8041), null, null, new Guid("10000000-0000-0000-0000-000000000005"), null },
                    { new Guid("6b4bab10-e8be-48e0-bcca-315425dfc966"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7975), 0.04m, new DateTime(2030, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7974), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7974), null, new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), null, null },
                    { new Guid("6df0f887-5dd4-4826-b41b-595a8106d0bc"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8104), 0.05m, new DateTime(2030, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8064), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8063), null, null, new Guid("10000000-0000-0000-0000-000000000014"), null },
                    { new Guid("8181df75-8d59-44fb-8071-f17d50f53eb7"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7992), 0.02m, new DateTime(2029, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7991), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7991), null, new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), null, null },
                    { new Guid("81d7f133-e1d9-43a1-9995-b831c4f510df"), "Hợp đồng cung cấp dịch vụ hướng dẫn viên", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8060), 0.03m, new DateTime(2028, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8059), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8059), null, null, new Guid("10000000-0000-0000-0000-000000000012"), null },
                    { new Guid("893812d1-2691-4328-9bc6-0ce54eb4e4ba"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7982), 0.02m, new DateTime(2027, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7980), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7980), null, new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), null, null },
                    { new Guid("8fb4e323-e5c3-4b26-a566-acb5393ecc84"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8047), 0.05m, new DateTime(2029, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8046), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8046), null, null, new Guid("10000000-0000-0000-0000-000000000007"), null },
                    { new Guid("92643b6b-6281-44d1-a8d7-7a6f8d9721d8"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8040), 0.05m, new DateTime(2027, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8039), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8039), null, null, new Guid("10000000-0000-0000-0000-000000000004"), null },
                    { new Guid("968fe4fa-50f2-41c1-bc30-889c449a3bb7"), "Hợp đồng cung cấp dịch vụ hướng dẫn viên", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8051), 0.03m, new DateTime(2026, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8051), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8050), null, null, new Guid("10000000-0000-0000-0000-000000000009"), null },
                    { new Guid("a12043e5-a295-4e80-9697-f57810258f9b"), "Thỏa thuận hợp tác phát triển sản phẩm du lịch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7998), 0.03m, new DateTime(2028, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7997), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7996), null, new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), null, null },
                    { new Guid("ab558e01-ea64-4db4-8045-5a7543284041"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7987), 0.05m, new DateTime(2029, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7986), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7986), null, new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), null, null },
                    { new Guid("aebdee2c-5ec3-423f-939f-a96fb363d724"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7985), 0.05m, new DateTime(2028, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7983), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7983), null, new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), null, null },
                    { new Guid("ca8a73f8-cb5d-456e-b2e5-840d9e801b6a"), "Hợp đồng đại lý du lịch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8045), 0.02m, new DateTime(2026, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8044), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8044), null, null, new Guid("10000000-0000-0000-0000-000000000006"), null },
                    { new Guid("d963585d-dacc-45ec-971c-61157518b644"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8056), 0.01m, new DateTime(2027, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8055), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8054), null, null, new Guid("10000000-0000-0000-0000-000000000010"), null },
                    { new Guid("da2e6905-f05e-4214-b7d2-b350779b640e"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7979), 0.05m, new DateTime(2028, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7977), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7977), null, new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), null, null },
                    { new Guid("da7f24bd-5222-46f2-ae69-b262d6783ea9"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8006), 0.02m, new DateTime(2026, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8005), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8005), null, new Guid("22275542-0625-47be-a503-2f13b7576e9b"), null, null },
                    { new Guid("e290c426-7937-4a90-a88c-e5dc147e972a"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8058), 0.05m, new DateTime(2028, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8057), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8057), null, null, new Guid("10000000-0000-0000-0000-000000000011"), null },
                    { new Guid("e3257c6b-3e1a-41c3-827e-ee681364328a"), "Thỏa thuận hợp tác phát triển sản phẩm du lịch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8000), 0.01m, new DateTime(2028, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7999), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7999), null, new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), null, null },
                    { new Guid("e8bca475-a373-47eb-b41d-80aba4cf9f63"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7966), 0.04m, new DateTime(2029, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7965), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(7965), null, new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), null, null },
                    { new Guid("ed7b72b1-b57c-4100-82f5-f8444d4448a7"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8026), 0.04m, new DateTime(2030, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8024), null, null, 1, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8023), null, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("fe5be486-f211-4b4a-b679-35dc7fa37073"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8109), 0.05m, new DateTime(2027, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8108), null, null, 0, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(8107), null, null, new Guid("10000000-0000-0000-0000-000000000015"), null }
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
                    { new Guid("20000000-4444-0000-3333-000000000001"), null, "Sóc Trăng", null, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4487), "Gạo ST25 đạt chuẩn hữu cơ, gạo ngon nhất thế giới 2019", "[\"https://bizweb.dktcdn.net/thumb/1024x1024/100/399/910/products/gao-trang-st25-huu-co.jpg?v=1656410170790\",\"https://gaophuongnam.vn/upload/ckfinder/images/g%E1%BA%A1o%20st24%2025/gao-thom-st25-huu-co-chinh-hang.jpg\"]", null, "HTX Gạo ST25", null, "Việt Nam", 200000.0, 0, "[OCOP] Gạo ST25 Hữu Cơ 5kg", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, null },
                    { new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), "Không đường, không chất bảo quản, giữ lạnh ở 4°C.", "Dairy Farm, Mộc Châu", "Từ 1 tuổi trở lên", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(4454), "Sữa tươi nguyên chất, thu hoạch và chế biến trực tiếp từ trang trại bò sữa Mộc Châu.", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fsua_moc_chau.webp?alt=media\\u0026token=0bee6dea-0373-4832-a59b-75385e0bf2a6\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fsua_moc_chau_2.webp?alt=media\\u0026token=64822296-e84f-4e59-b2fe-fabe2df2e6b7\"]", "100% sữa bò tươi", "Trang trại bò sữa Mộc Châu", "Canxi, Vitamin D, Protein", "Mộc Châu, Sơn La", 45000.0, 6, "Sữa tươi thanh trùng Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, "1L" },
                    { new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4344), "Tinh Bột Sắn Dây Nguyên Chất Vị Chanh Leo Đồng Tâm 500g - Hỗ Trợ Thanh Nhiệt, Giải Độc, Mát Gan\r\n\r\nI. THÔNG TIN SẢN PHẨM: \r\n- Xuất xứ: Việt Nam\r\n- Quy cách đóng gói: Hộp 500 gram\r\n- Hạn sử dụng: 18 tháng kể từ NSX\r\n- Thành phần: 100 % Nguyên chất bột sắn dây\r\n\r\nII. CÔNG DỤNG: \r\n- Đồ uống thanh nhiệt giải độc do nóng gan, làm trắng da sáng da từ bên trong. Giải nhiệt, rôm sảy, nóng trong người. Giảu rượu giúp cơ thể tỉnh táo, nhanh hồi phục.              \r\n- Chất làm đặc thực phẩm: Tinh bột sắn dây thường được sử dụng như một chất làm đặc trong các món tráng miệng, nước ép, nước uống và các món canh sệt. Nó giúp tăng độ đặc và nhờn cho các món ăn mà không thay đổi hương vị hay màu sắc của chúng.\r\n- Thành phần trong sản phẩm làm đẹp: Tinh bột sắn dây có khả năng hấp thụ dầu và làm dịu da, nên nó thường được sử dụng trong các sản phẩm chăm sóc da. \r\n- Thức ăn bổ sung: Tinh bột sắn dây có chứa chất xơ và chất dinh dưỡng có lợi như kali, canxi và vitamin C. Việc tiêu thụ tinh bột sắn dây có thể giúp cải thiện tiêu hóa, hỗ trợ sự chuyển hóa chất béo, giảm cholesterol và duy trì sự ổn định của đường huyết.\r\n- Sản phẩm không chứa gluten: Tinh bột sắn dây không chứa gluten, là một lựa chọn tuyệt vời cho những người có chứng dị ứng hoặc nhạy cảm với gluten. Nó có thể được sử dụng để thay thế tinh bột từ các nguồn ngũ cốc khác trong nấu ăn và nướng bánh.\r\n- Tạo mặt nạ tự nhiên: Tinh bột sắn dây có thể được kết hợp với các nguyên liệu tự nhiên khác như mật ong, sữa chua, bột trà xanh để tạo mặt nạ tự nhiên.\r\n\r\nIII. CÁCH SỬ DỤNG:\r\nTheo Đông Y, bột sắn dây có vị ngọt, mát, tính bình nên cây thường được sử dụng trong việc thanh nhiệt và giải độc. Còn theo y học hiện đại thành phần hoạt chất có trong bột sắn dây góp phần ngăn ngừa một số b.ệ.n.h. Sau đây là một số cách sử dụng bột sắn dây.\r\n- Cảm nắng, nhức đầu, sốt nóng: Sử dụng khoảng 12g bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Đau bụng đi ngoài giống kiết lỵ: Sử dụng bột sắn dây hòa vào nước cùng với một chút đường để uống.\r\n- Loại bỏ và ngăn ngừa cảm, nôn, đau đầu ở trẻ nhỏ do bị cảm, gió: Nấu chín bột sắn dây cùng gạo tẻ thành cháo, thêm gừng giã nát và mật ong, cho trẻ ăn từ 3 - 5 ngày.\r\n- Chống ngứa do mồ hôi gây nên: 5g bột sắn dây, 5g thiên hoa phấn, 20g hoạt thạch. Trộn đều hỗn hợp rồi rắc lên những khu vực bị ngứa.\r\n- Vùng ngực và bụng cảm thấy nóng cồn cào, khát nước: lấy 120g sắn dây trộn đều với 15g gạo tẻ, sử dụng để nấu cháo, ăn từ 3 - 5 ngày sẽ làm thuyên giảm tình trạng trên.\r\n- Loại bỏ kiết lỵ do nhiệt: Để loại bỏ đau bụng, nóng rát vùng hậu môn, phải rặn khi đại tiện, pha bột sắn dây với nước và đường, sau đó nấu chín đặc và ăn trong 2 - 3 lần/ngày.\r\n- Ngăn ngừa viêm họng: bột sắn dây giúp cơ thể ức chế một số v.i k.huẩn có h.ại. Vì thế, nếu bị viêm họng, bạn có thể lấy từ 10-15g bột pha nước nóng để uống. Sau vài ngày triệu chứng viêm họng sẽ chấm dứt hoàn toàn.\r\n- Hết n.gộ đ.ộc r.ượu: Hòa tan bột sắn dây với một chút đường có thể thêm nước cốt chanh. Có thể sử dụng muối thay cho đường ", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-1.webp?alt=media\\u0026token=4d8cfdbb-9f89-4e0b-9026-eeb3b551ea0c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-2.webp?alt=media\\u0026token=bad36b93-8f59-4463-8622-b0a7ea89821e\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-3.webp?alt=media\\u0026token=d111fa72-4b38-4bfc-9c7b-9b5111eadb07\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-4.webp?alt=media\\u0026token=7c347385-45bd-474f-9930-77dca305655c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-5.webp?alt=media\\u0026token=b6b5ea5e-dee5-4c3f-ac83-231fe6bd4a68\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-6.webp?alt=media\\u0026token=d3542914-5791-4d36-95a6-071e554aa407\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F2-7.webp?alt=media\\u0026token=4126eb69-2b91-4c39-a8dc-f548b1b9bbd6\"]", null, "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 0, "[OCOP] Tinh Bột Sắn Ta Dây Nguyên Chất 100% Vị Chanh Leo 500g - Thanh Nhiệt, Giải Độc, Mát Gan, Đẹp Da - Làm Thủ Công", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null },
                    { new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4426), "Bột lá tía tô nguyên chất được bào chế từ lá tía tô tươi, phơi khô, tán mịn để tạo thành sản phẩm bột nguyên chất, giữ được thành phần dưỡng chất bên trong \r\nPhân tích thành phần lá tía tô ta sẽ thấy : 0,3 - 0,5% tinh dầu (khối lượng khô), citral chiếm 20% khối lượng khô. Trong đó thành phần  tinh dầu chủ yếu là perillaldehyd, limonen, L-perrilla alcohol, α-pinen… \r\nLá tía tô có chứa thêm thành phần tanin và glucosid chống v.êm hiệu quả \r\n💗💗 Công dụng dưỡng da của bột lá tía tô nguyên chất Từ xưa, lá tía tô đã được biết đến với các hiệu quả làm đẹp, chăm sóc da mặt. \r\nSử dụng bột lá tía tô nguyên chất sẽ mang đến hiệu quả dưỡng da tuyệt vời mà chị em không thể qua \r\n- Hỗ trợ mụn trứng cá, mụn bọc, mụn sưng đỏ \r\n- Làm sạch da, mịn da, điều tiết dầu nhờn \r\n- Cân bằng độ ẩm cho da khô, nhờn\r\n- Khá.n.gg khuẩn, khá.n.gg v.iê.mm tốt cho làn da mẫn cảm dễ nổi mụn, da dị ứng \r\n- Da sáng dần, đều màu, trắng hồng nếu kiên trì sử dụng \r\n- Hỗ trợ trị Gout\r\n– Cảmho, đau bụng \r\n- Giảm béo, làm đẹp da \r\n- Tốt cho sức khỏe bà bầu và nhiều công dụng khác \r\n🍓🍓 Với thành phần tanin và glucosid hạn chế sự phát triển của vi khuẩn hiệu quả, ngăn ngừa các tác nhân gây mụn, giảm sưng hiệu quả \r\n➡ Lá tía tô có các hoạt chất đặc biệt hiệu quả làm tiêu các bã nhờn trên da, tích tụ gây mụn trứng cá, mụn bọc.\r\n Làm mát từ bên ngoài giúp giảm mụn tối ưu\r\n #bottiato #tiatonguyenchat #botlatiato \r\n• HSD 12 tháng sau khi mở bao bì sản phẩm \r\n• Bảo quản nơi khô ráo, thoáng mát\r\n#bot_tia_to #la_tia_to #bot_tia_to_nguyen_chat", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F72.webp?alt=media\\u0026token=b0fa1e0c-85fb-455e-99c2-66578c832e4b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F72.webp?alt=media\\u0026token=b0fa1e0c-85fb-455e-99c2-66578c832e4b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F74.webp?alt=media\\u0026token=01e37117-b3c5-47eb-8fdd-956c7b8cfa6e\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F75.webp?alt=media\\u0026token=13fdd758-187b-44b8-9b9f-e9fb47148524\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F76.webp?alt=media\\u0026token=be498a71-dc12-42a0-bebd-844b732aa1c8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F77.webp?alt=media\\u0026token=41f13948-a8de-49ff-88d4-a37b46dd87b8\"]", "Tía tô, cỏ ngọt", "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 2, "[OCOP QUẢNG TRỊ] Bột tía tô sấy lạnh Trần Lan [Hộp 150gr]", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "150g" },
                    { new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4439), "THÔNG TIN SẢN PHẨM NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n• Thành phần: 95% bột trầm hương tự nhiên Việt Nam, tăm tre Đài Loan cao cấp, bột vỏ cây bời lời Tây Nguyên\r\n\r\n• Trầm phổ thông: tuổi trầm khoảng từ 8-10 năm\r\n\r\n• Trầm cao cấp: tuổi trầm khoảng từ 12-15 năm\r\n\r\n• Trầm đặc biệt: tuổi trầm từ 25 năm trở lên\r\n\r\n• Số lượng cây trong 1kg: loại 40cm có khoảng 650 cây | loại 30cm có khoảng 800 cây\r\n\r\n• Độ nhang dài: 30cm | 40cm (cả cây nhang, tính từ chân đến ngọn)\r\n\r\n• Thời gian cháy: 40-50 phút với loại 30cm | 70-80 phút với loại 40cm, tuỳ vào không gian sử dụng.\r\n\r\n• Xuất xứ: Việt Nam\r\n\r\n• Cách dùng: Thắp ở bàn thờ gia tiên, bàn thờ thần tài ông địa, cúng chùa,...\r\n\r\n• Sản phẩm nhang trầm hương cao cấp được sản xuất thủ công, nguyên liệu thuần tự nhiên, mùi thơm dịu nhẹ, thơm ngọt mùi trầm. Sản phẩm để nơi khô ráo càng lâu càng thơm.\r\n\r\n\r\n\r\nHƯỚNG DẪN SỬ DỤNG NHANG TRẦM SẠCH XƯỞNG MỘC VIỆT\r\n\r\n1/ Trong thờ cúng, gia tiên:\r\n\r\n• Nhang trầm hương sạch dùng trong không gian thờ cúng, tạo sự tưởng nhớ biết ơn và cầu nguyện cho con cháu bình an, gia đình hòa thuận.\r\n\r\n• Nhang trầm hương sạch giúp thanh lọc không gian sống, tiêu trừ các loại mùi hương xấu, thu hút tài lộc.\r\n\r\n• Nhang trầm hương sạch giúp chiêu tài dẫn lộc dịp khai trương, tân gia, tất niên,..\r\n\r\n2/ Trong không gian sống và sức khoẻ:\r\n\r\n• Mùi hương trầm sạch  tạo cảm giác thư giãn, giảm áp lực, căng thẳng, cải thiện sự tập trung.\r\n\r\n• Làm thơm không gian làm việc, làm dịu nhẹ thần kinh và kích thích khả năng tư duy sáng tạo.\r\n\r\n• Nhang trầm hương sạch để xông nhà, trà đạo hoặc yoga giúp tinh thần thông thoáng, cải thiện sức khỏe.\r\n\r\n• Nhang trầm hương sạch, nguyên chất giúp cho giấc ngủ được sâu hơn, cải thiện các chứng đau đầu.\r\n\r\n\r\n\r\nCHÍNH SÁCH ĐỔI TRẢ - BẢO HÀNH\r\n\r\n1/ Đổi trả theo đúng quy định của SHOPEE:\r\n\r\n• Chỉ đổi trả khi hàng hoá còn mới, chưa qua sử dụng.\r\n\r\n• Chấp nhận đổi trả khi hàng hoá bị hỏng hoặc do lỗi của nhà sản xuất.\r\n\r\n2/ Trường hợp được chấp nhận:\r\n\r\n• Hàng không đúng phân loại, mẫu mã như quý khách đặt hàng\r\n\r\n• Không đủ số lượng, không đủ bộ như trong đơn hàng\r\n\r\n3/ Trường hợp không đủ điều kiện áp dụng chính sách:\r\n\r\n• Gửi lại hàng không đúng mẫu mã, không phải hàng của XƯỞNG MỘC VIỆT\r\n\r\n• Do màn hình và điều kiện ánh sáng khác nhau, màu sắc thực tế của sản phẩm có thể chênh lệch khoảng 3-5%.\r\n\r\n\r\n\r\nTHÔNG TIN SẢN XUẤT TRẦM HƯƠNG XƯỞNG MỘC VIỆT\r\n\r\n• Xưởng Mộc Việt là thương hiệu hàng đầu Việt Nam chuyển thu mua, sản xuất và phân phối sản phẩm vòng tay trầm hương, trang sức trầm hương, nhang trầm hương và trầm hương sạch, chuẩn tự nhiên\r\n\r\n• Sản phẩm Xưởng Mộc Việt tự hào nhận các chứng nhận như: OCOP và chuẩn sản phẩm công nghiệp nông thôn tiêu biểu tỉnh Quảng Trị\r\n\r\n• Tất cả sản phẩm được Xưởng Mộc Việt đưa ra thị trường là sản phẩm chính hãng Công ty và cam kết là hàng chuẩn trầm sạch, chuẩn tự nhiên. Được cơ quan chức năng cấp các chứng nhận: OCOP, ISO 9001:2015, VN-TEST", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F82.webp?alt=media\\u0026token=b855f4ab-4b51-43ea-af26-e0deb629f97c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F83.webp?alt=media\\u0026token=15012cad-7f6f-4cae-842c-c1e8e35d0c89\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F84.webp?alt=media\\u0026token=0576465d-964e-4ffc-93fa-54f410c761e7\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F85.webp?alt=media\\u0026token=ef5f7fbf-bf80-43d6-a4fa-ebda116b5dc1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F86.webp?alt=media\\u0026token=521f7498-9a95-424e-884b-72b611b6f0ee\"]", "Trầm hương, Bột Trầm Hương", "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 6, "Nhang trầm hương cao cấp [1Kg] sạch chuẩn sản phẩm OCOP, ISO 9001 - Xưởng Mộc Việt", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 0, null, "1kg" },
                    { new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Trà túi lọc & lá trà", "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4408), "🌱Sản phẩm đạt tiêu chuẩn OCOP 4 SAO theo Quyết định 919/QĐ-Ttg năm 2018 của Chính phủ\r\n\r\n\r\n\r\n✅THÔNG TIN SẢN PHẨM:\r\n\r\n• Trà Sen Bách Diệp là sự hòa quyện tuyệt vời giữa hương thơm ngan ngát của sen Bách Diệp Hồ Tây và vị đậm đà của trà Tân Cương Thái Nguyên.\r\n\r\n• 100% Trà Sen Bách Diệp Tây Hồ Hà Nội được thu hái thủ công, tuyển chọn những búp chè tươi ngon. Trà được gói trọn trong bông Sen giúp cho lá trà thẩm thấu toàn bộ hương sen, sau đó được sấy thăng hoa theo công nghệ hiện đại của Đức để giữ được trong hương vị và bảo quản được lâu, khi pha tạo nên cảm giác khoan khoái và thư giãn.\r\n\r\n• Hải Linh tự hào là thương hiệu Trà sen Bách Diệp uy tín, có sản lượng tiêu thụ lớn nhất hiện nay.\r\n\r\n\r\n\r\n✅ Set quà sang trọng: Một set bao gồm: Trà Sen, hộp trà và túi xách đẹp mắt, thích hợp làm quà tặng cao cấp.\r\n\r\n- Trọng lượng: Set 10 bông trà (tổng trọng lượng 1.000g). Mỗi bông trà sen sau khi đã được sấy thăng hoa (mất hơi nước) có trọng lượng 26gram, đủ tiêu chuẩn cho 6 người uống (4gram trà / 1 người).\r\n\r\n- Trà đã được ướp bông sen sau đó sấy thăng hoa cả búp nên chỉ cần bảo quản ở nhiệt độ thường\r\n\r\n- HSD 12 tháng kể từ ngày sản xuất, NSX và HSD được in trên bao bì từng bông.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHI TIẾT SẢN PHẨM:\r\n\r\n• Thành phần: 100% trà xanh chất lượng được bọc bên trong búp sen tươi.\r\n\r\n• Hướng dẫn sử dụng: \r\n\r\n- Rót nước sôi để tráng ấm, chén pha trà: Giúp tiệt trùng dụng cụ pha trà và làm nóng ấm, chén pha trà.\r\n\r\n- Cho khoảng 10g trà và phần gạo sen vào trong ấm.\r\n\r\n- Châm 200ml nước sôi có nhiệt độ 75 đến 80 độ C vào ấm, rồi hãm 20-25 giây.\r\n\r\n-  Rót trà từ ấm: Hãm đủ thời gian, bạn hãy rót hết lượng trà trong ấm ra chén Tống qua chiếc lọc trà và tránh để lại nước trong ấm (Lọc trà giúp giữ lại những xác trà nhỏ giúp nước trà trong và tinh khiết hơn)\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CÔNG DỤNG CỦA TRÀ SEN: \r\n\r\n• Trà sen Bách Diệp giúp giảm lượng cholesterol trong máu, giúp ngăn ngừa bệnh tim mạch, đặc biệt tốt cho sức khỏe của người già, người mắc bệnh tim mạch. Hạn chế nguy cơ mắc các bệnh về gan, hạn chế sự hấp thu các chất béo vào cơ thể.\r\n\r\n• Tăng cường hệ miễn dịch giúp cho cơ thể giúp cơ thể chống lại những hiện tượng nhiễm virus và nhiễm khuẩn.\r\n\r\n\r\n\r\n✅ QUY CÁCH ĐÓNG GÓI: Trà và búp sen được sấy khô và hút chân không giúp giữ hương vị trà được lâu, thân thiện với môi trường.\r\n\r\n\r\n\r\n\r\n\r\n\r\n✅ CHÍNH SÁCH ĐỔI TRẢ CỦA TRÀ SEN HÀ NỘI OFFICIAL : \r\n\r\n👉 1 đổi 1 trong trường hợp lỗi do nhà sản xuất, sai sản phẩm và theo quy định của Shopee. \r\n\r\n👉 Trường hợp gửi thiếu, các bạn liên hệ shop để được đổi lại, gửi bù MIỄN PHÍ. (Các bạn nhớ QUAY CLIP BÓC HÀNG để được giải quyết nhé).\r\n\r\n\r\n\r\n#tràbúpsen #tràbôngsen #tràngon #tràcaocấp #chèbúpsen #tràsen #tràướphoasen #tràsentâyhồ #tràhoasen #trà #tràbiếu #sentrà #tràướpsentâyhồ #chèướpsen #tràướpbôngsen #chèsen #chèsentâyhồ #tràsenhànội #chèhoasen", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F51.webp?alt=media\\u0026token=5218426e-19ff-4feb-b968-93e08e7f6c92\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F52.webp?alt=media\\u0026token=65af2dec-b460-4f5c-8c4b-8c76b6581a83\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F53.webp?alt=media\\u0026token=a5f9bc6d-d647-4b36-9c9e-bf86eead7692\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F54.webp?alt=media\\u0026token=94412ff3-d1eb-427a-8114-3290d62edd31\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F55.webp?alt=media\\u0026token=1cade255-31ff-4248-ac2f-0f2f8513b33c\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F56.webp?alt=media\\u0026token=7df9da7d-de96-49bc-a5e5-15113e8bb8e0\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F57.webp?alt=media\\u0026token=d9ab3abb-2461-45e6-a22b-3cf0f2a2060f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F58.webp?alt=media\\u0026token=8a4bda8c-0e6c-4154-8dc0-6c3c23ea8f53\"]", "Trà xanh, Khác", "Xưởng Mộc Việt", "Truyền thống", "Việt Nam", 80000.0, 1, "Trà Sen Tây Hồ Thượng Hạng [OCOP 4⭐] - Hương Thơm Tự Nhiên, Đậm Đà Truyền Thống, Hộp 10 Bông", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null, null, "10 bông" },
                    { new Guid("69006cfe-5233-7776-b181-d81a485873e3"), null, "Mộc Châu, Sơn La", null, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4474), "Mật ong rừng nguyên chất, thu hoạch từ các khu rừng nguyên sinh", "[\"https://www.google.com/url?sa=i\\u0026url=https%3A%2F%2Fvi-vn.facebook.com%2Fmatongnguyenchatbaoloc123%2F\\u0026psig=AOvVaw0psQ_ofRkq3xidpma68DF4\\u0026ust=1745923051724000\\u0026source=images\\u0026cd=vfe\\u0026opi=89978449\\u0026ved=0CBQQjRxqFwoTCIiT7qnE-owDFQAAAAAdAAAAABAZ\",\"https://topaz.vn/wp-content/uploads/2022/11/dia-chi-ban-mat-ong-rung-nguyen-chat-tai-tphcm-1.jpg\"]", null, "HTX Mật Ong Rừng", null, "Việt Nam", 150000.0, 0, "[OCOP] Mật Ong Rừng Nguyên Chất 500ml", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, null },
                    { new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4354), "✅ Thông tin sản phẩm cơm cố đô ruốc đậm đà 300g- 600g:\r\n    1 gói 05 miếng to đùng.\r\n    Shop đóng gói thùng giấy catton chắc chắn hạn chế bể vỡ khi vận chuyển.\r\n    Trọng lượng mỗi gói cơm cháy cố đô ruốc đậm  Khoảng 600 gram/Túi\r\n\r\n✅ Cơm cháy bên mình để khô ráo dầu mới bỏ vào bịch, và chiên dầu mới để không bị gắt dầu nha các bạn.\r\n     sản phẩm đóng trong túi zips kín, sử dụng rất tiện ích\r\n     Hạn sử dụng: 6 Tháng\r\n     Nguồn gốc xuất xứ : Thành phố Ninh Bình - tỉnh Ninh Bình\r\n\r\n✅ HƯỚNG DẪN SỬ DỤNG VÀ BÀO QUẢN :\r\n- Dùng ngay khi mở miệng túi không cần chế biến.\r\n- Bảo quản nơi khô ráo, thoáng mát và tránh ánh nắng trực tiếp.\r\n \r\n✅ Shop mình tự tin là chuẩn bị hàng nhanh, sáng các bạn đặt đơn thì chiều mình gởi hàng. Tuy nhiên thời gian giao hàng còn phụ thuộc vào đơn vị giao hàng nữa, đôi khi có những trường hợp giao chậm hơn so với dự kiến. Shop mong các bạn hiểu và thông cảm ạ !\r\n\r\n✅ Thời gian giao hàng đối với các tỉnh miền bắc, miền trung: 1-3 ngày. Tỉnh phía Nam : 3-5 ngày.\r\n\r\n1 Túi 05 MIẾNG TO ĐÙNG CƠM CHÁY RUỐC HÀNH ỚT | SHOP CƠM CHÁY CỐ ĐÔ - TINH HOA NÔNG SẢN VIÊT\r\n\r\n#cơm_cháy #cơm_cháy_chà_bông #cơm_cháy_rụm #cơm_cháy_mỡ_hành #cơm_cháy_khô_gà #cơm_cháy_chiên #nước_mắm #cơm_cháy_chiên_mắm #cơm_cháy_lắc_khô_gà #cơm_cháy_mắm_hành #com_cháy_chà_bông #cơm_cháy_ngon #cơm_cháy_chà_bông_ngon #cơm_cháy_khô #cơm_cháy_mắm_ớt #cơm_cháy_chà_bông_mỡ_hành #cơm_cháy_mắm #cơm_cháy_tỏi #cơm_cháy_giá_sỉ", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F32.webp?alt=media\\u0026token=1b2c7198-56da-46dc-bef8-c1371e4bbd16\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F33.webp?alt=media\\u0026token=feac05a6-f278-4bae-85ab-4a9453decd2a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F34.webp?alt=media\\u0026token=153f06d6-d1ee-4781-a17a-b43c0028fbea\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F35.webp?alt=media\\u0026token=0cf39ab3-b794-4d99-90a6-4d4026b690d8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F36.webp?alt=media\\u0026token=0f2875bb-7146-4a3d-8774-d449d78a925a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F37.webp?alt=media\\u0026token=4ef86b59-4468-4e52-af69-5084c99281c8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F38.webp?alt=media\\u0026token=f332cd0d-fc6f-45e4-87cf-5ad8c1dfc749\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F310.webp?alt=media\\u0026token=1c52bcc3-1800-4c86-a874-842c62dca2af\"]", "GẠO NẾP THƠM, RUỐC, ỚT, TIÊU", "Xưởng Mộc Việt", "Đặc sản địa phương", "Việt Nam", 80000.0, 0, "[BÁN SỈ] Cơm cháy 300g- 600g siêu ruốc chà bông ròn ngon Cố Đô, ocop 4 sao đặc sản Ninh Bình", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "750g" },
                    { new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4418), "1. R.ư.ợ.u ống tre Việt 1 ống dung tích 750ml. Bộ sản phẩm đi kèm thêm búa rõ R.ư.ợ.u  và hộp đựng.\r\n2. R.ư.ợ.u  ống Tre Việt có 2 vị: 1 là vị nếp cái hoa vàng kết hợp với thảo mộc. 2 là vị R.ư.ợ.u  truyền thống\r\n3. Độ R.ư.ợ.u  lúc bơm vào cây tre là 50 độ, sau thời gian tre hấp thụ đến khi thu hoạch độ R.ư.ợ.u  còn khoảng 32 độ.\r\n4.R.ư.ợ.u  có mùi thơm do kết hợp của Tre, thảo mộc … và Vị ngọt thanh nhẹ, dễ uống.\r\n5. Cách làm R.ư.ợ.u  ống tre: R.ư.ợ.u  nếp sau khi nấu xong, cho qua máy khử các độc tố trong R.ư.ợ.u  như Metanol; Andehit. Rồi hạ thổ 1 năm với các loại hoa quả, thảo mộc hoặc dùng R.ư.ợ.u  nếp cái hoa vàng hạ thổ với các loại thảo mộc. Sau đó bơm vào cây tre đang sinh trưởng. Sau 6 tháng mới cho thu hoạch được.\r\n6. R.ư.ợ.u  dùng men bắc truyền thống, hay còn gọi là Men Trấu của các cụ ngày xưa hay nấu R.ư.ợ.u .\r\n7. Sản phẩm đã được cho đi kiểm nghiệm chuẩn chỉnh về chất lượng sản phẩm nên cực kỳ an toàn. Ngoài ra sản Phẩm R.ư.ợ.u  ống Tre Việt  đạt chứng chỉ Ocop 3 sao. Đây là sản phẩm R.ư.ợ.u  ống Tre đầu tiên ở Việt Nam đạt chứng chỉ Ocop.\r\n8. Bảo quản R.ư.ợ.u  ống Tre: Để nơi khô ráo, thoáng mát, Lúc uống muốn ngon hơn có thể để vào ngăn mát tủ lạnh.\r\n9. R.ư.ợ.u  uống ngon nhất trong 6 tháng đầu. Về sau độ R.ư.ợ.u  sẽ giảm dần, và R.ư.ợ.u  sẽ ngọt hơn", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F62.webp?alt=media\\u0026token=5e7d93e8-e10e-47e1-be82-573a9436bdca\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F63.webp?alt=media\\u0026token=7b8fd32b-486b-4fec-bb89-ec59959708d0\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F64.webp?alt=media\\u0026token=d7b0593b-a8a7-44de-917a-35e3699f5cd1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F65.webp?alt=media\\u0026token=daa304f2-2707-486e-862e-e39f5aff3c25\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F66.webp?alt=media\\u0026token=e9b4469d-a2c9-458a-ba20-e2968a4db706\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F67.webp?alt=media\\u0026token=67fb95cf-5e3b-4dbe-afa7-80dd4c85b7ce\"]", null, "Xưởng Mộc Việt", "Đặc sản địa phương", "Việt Nam", 80000.0, 1, "Ống rượu tre Việt Nam - Sản phẩm đạt chứng nhận Ocop 3 Sao [ Quà Tết Hot 2024 ]", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 4, null, "750ml" },
                    { new Guid("98e14da8-4445-4e50-bd9b-eb74112f6625"), null, "Yên Bái", null, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4478), "Trà Shan Tuyết từ cây chè cổ thụ trên 100 năm tuổi", "[\"https://vietcotra.vn/media/product/1726818655_tra-shan-tuyet-suoi-giang-cc.jpg\",\"https://bizweb.dktcdn.net/100/201/525/files/unnamed.jpg?v=1720524034006\"]", null, "HTX Trà Shan Tuyết", null, "Việt Nam", 250000.0, 1, "[OCOP] Trà Shan Tuyết Cổ Thụ 200g", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null },
                    { new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), "Không thuốc trừ sâu, không hóa chất, thu hoạch trong ngày.", "Mộc Châu Xanh, Mộc Châu", "Tất cả mọi người", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(4461), "Rau cải ngọt được trồng theo phương pháp hữu cơ chuẩn OCOP tại trang trại rau Mộc Châu Xanh.", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Frau_cai_moc_chau.jpg?alt=media\\u0026token=7806aa89-1434-4973-a4c4-f75157dc263f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Frau_cai_moc_chau_2.jpg?alt=media\\u0026token=9d619514-84e3-427a-ba7c-6b56cafb24ba\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Frau_cai_moc_chau_3.jpg?alt=media\\u0026token=01deb8a8-a991-4ec5-bc40-818fa56f80b2\"]", "100% rau cải ngọt hữu cơ", "Trang trại rau hữu cơ Mộc Châu Xanh", "Vitamin A, Vitamin C, Sắt", "Mộc Châu, Sơn La", 25000.0, 6, "Rau cải ngọt hữu cơ Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "500g" },
                    { new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Tiêu hóa & gan, Tim mạch & huyết áp, Khả năng miễn dịch, Khớp, cơ bắp & Xương, Căng thẳng, giấc ngủ, và nlo lắng", "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", "Người lớn", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4324), "Viên Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da\r\n\r\n1. Thông tin sản phẩm:\r\n- Quy cách đóng gói: 500gr\r\n- Hạn sử dụng: 18 tháng \r\n- Xuất xứ: Việt Nam\r\n-  Hoàng Mai, tỉnh Nghệ An\r\n- Chứng chỉ: Chứng nhận OCOP 3 sao\r\n- Thương hiệu: HTX Đồng Tâm\r\n\r\n2. Ưu điểm nổi bật\r\n- Sản phẩm đạt chuẩn chất lượng tiêu chuẩn OCOP.\r\n- Áp dụng công nghệ bào chế tinh bột nghệ Nano Curcumin.\r\n- Thành phần: tinh bột nghệ, mật ong tự nhiên nguyên chất không pha tạp.\r\n- Tinh chế từ 100% nguyên liêu tự nhiên không hóa chất bảo quản.\r\n\r\n3. Công dụng sản phẩm\r\n- Hỗ trợ đường tiêu hoá: phòng các chứng viêm va giảm đau dạ dày ( bao tử), đại tràng, bệnh đường ruột.\r\n- Giảm mụn, nám, tàng nhang, thâm sạm, ngăn ngừa lão hoá từ bên trong giúp dưỡng nhan, làm hồng hào da, nhuận sắc\r\n- Lưu thông m.á.u, hỗ trợ các bệnh viêm khớp, tim mạch, tiểu đường\r\n- Làm hạ huyết áp, giảm cholesterol\r\n- Giúp an thần, ngủ ngon \r\n- Tăng cường sinh lực cho phái mạnh\r\n- Cải thiện sức khoẻ, sắc đẹp đẹp cho phụ nữ sau sinh\r\n\r\n4. Hướng dẫn sử dụng:\r\n- Viên nghê mật ong Hoàng Mai thơm ngon, khá mềm nên có thể nhai trực tiếp hoặc kết hợp uống với nước.\r\n- Nếu đau dạ dày nặng ngày dùng 3 lần, 5-7 viên/ lần sau khi ăn, khoảng 1 tháng đã cải thiện nên giảm tần suất dùng xuống ngày 2 lần \r\n- Uống tốt sức khỏe & tái tạo – trẻ hóa da ngày dùng 2 lần, 3-5 viên/ lần.\r\n- Các mẹ ở cử, sau sanh khoảng 7 ngày-10 ngày khi xuống sạch dịch và huyết thì dùng ngày dùng 3 lần, 5 viên/ lần.\r\n- Trẻ em trên 2 đến 6 tuổi ngày dùng 2 lần, 2-3 viên/ lần.\r\n*** Lưu ý: Phụ nữ mang thai, người bị sỏi thận, sỏi mật, người chuẩn bị phẩu thuật, trẻ em dưới 2 tuổi không nên dùng.\r\n\r\n5. Hướng dẫn bảo quản viên tinh bột nghệ mật ong Hoàng Mai\r\n- Để nơi thoáng mát, tránh tiếp xúc ánh nắng mặt trời.\r\n- Không nên đặt dưới nền đất lạnh, sẽ ảnh hưởng đến chất lượng.\r\n- Tránh để nước hoặc không khí tiếp xúc với sản phẩm, sẽ gây ẩm mốc.\r\n- Đậy nắp kín trước và sau khi sử dụng. \r\n\r\n6. Quy trình đổi trả sản phẩm nếu có lỗi từ nhà sản xuất theo quy định của Shopee.\r\n Điều kiện áp dụng (trong vòng 03 ngày kể từ khi nhận sản phẩm):\r\n- Vui lòng quay video mở hàng (shop chỉ giải quyết đơn hàng khi có video mở hàng)\r\n- Hàng hóa hư hỏng do vận chuyển hoặc do nhà sản xuất.\r\n- Không đủ số lượng như trong đơn hàng.\r\n\r\nSẢN PHẨM NÀY KHÔNG PHẢI LÀ THUỐC VÀ KHÔNG CÓ TÁC DỤNG THAY THẾ THUỐC CHỮA BỆNH.\r\n#Viennghe #Vientinhnghe #Viennghematong #Vientinhnghematong #Matong  #Suaongchua #tinhbotnghe #tinhbot #botnghevang #nghe #tinhbotnghevang #tinhbotnghethiennhien #tinhbotnghehuuco #tinhbotnghetunhien #tinhbotnghexuatkhau #sanxuattinhbotnghe #vientinhbotnghe #vientinhbot #nghevang #shopmall #Shopuytin #ocop", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lmyybsw1u1274a%40resize_w900_nl.webp?alt=media\\u0026token=8df7ec0c-528c-4420-b9d8-1aa642cf458b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-ln887g33oi54f0%40resize_w900_nl.webp?alt=media\\u0026token=e4a624c3-296d-4553-812e-c17832510225\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7r98o-lnq49wxk2v7ea0%40resize_w900_nl.webp?alt=media\\u0026token=b6600b96-94ef-473e-ba86-72a4f5568635\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqd729rck56%40resize_w900_nl.webp?alt=media\\u0026token=2df35c4e-8b69-4210-80f3-58f6dee45ac5\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fvn-11134207-7ras8-m2faqlwlhj90fe%40resize_w900_nl.webp?alt=media\\u0026token=bddafaae-310a-421f-ac7d-ba10a052b63a\"]", "Tinh bột nghệ, Mật ong nguyên chất", "Xưởng Mộc Việt", "Nghệ", "Việt Nam", 80000.0, 2, "[OCOP - 500 gr] Viên Tinh Nghệ Mật Ong Hoàng Mai Nguyên Chất - Hỗ Trợ Giảm Đau Dạ Dày, Làm Đẹp Da, Lưu Thông Máu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "500ml" },
                    { new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), "Các món ăn đều sử dụng nguyên liệu từ Mộc Châu, mang lại hương vị tươi ngon và đậm đà.", "Bản Áng, Mộc Châu", "Từ 12 tuổi trở lên", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(4469), "Bữa trưa gồm các món ăn đặc sản như bê chao, cá suối, rau rừng, và sữa chua Mộc Châu, tất cả đều làm từ nguyên liệu tươi ngon và sạch.", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdac_san_moc_chau.png?alt=media\\u0026token=dd60c37e-bee9-45ad-bf3a-49d3ac0a8064\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdac_san_moc_chau_2.png?alt=media\\u0026token=0e22ac4f-c71b-4eac-a69d-8dda23b53608\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdac_san_moc_chau_3.png?alt=media\\u0026token=26fd6f31-d166-412e-abb2-034150f3d37b\"]", "Bê chao, cá suối, rau rừng, sữa chua Mộc Châu", "Nhà hàng Truyền thống Bản Áng", "Protein, Vitamin C, Vitamin A", "Mộc Châu, Sơn La", 200000.0, 0, "Món ăn đặc sản Mộc Châu", null, 0, new Guid("10000000-0000-0000-0000-000000000001"), 1, null, "Một suất ăn" },
                    { new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), "Không chất bảo quản, đóng lọ thủy tinh cao cấp.", "Bản Áng, Mộc Châu, Sơn La", "Từ 3 tuổi trở lên", new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(4447), "Mứt dâu tây thủ công được làm từ những quả dâu tươi được hái tại nông trại trong tour tham quan.", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fmut_dau_moc_chau.jpg?alt=media\\u0026token=5cbd4a36-f066-4014-b922-0bce4c578272\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fmut_dau_moc_chau_2.jpg?alt=media\\u0026token=f172742b-2518-4c49-bc2c-ec96aa161dc7\",\"https://https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdau-tay-moc-chau-3.jpg?alt=media\\u0026token=7cd28015-7dcd-43c4-b579-8468b7e9a6e6\"]", "Dâu tây tươi, đường mía, nước cốt chanh", "Hợp tác xã Nông sản Dâu Mộc Châu", "Vitamin C, Chất xơ", "Mộc Châu, Sơn La", 95000.0, 0, "Mứt dâu tây Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "250g" },
                    { new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), null, "Hà Xá - Triệu Ái - Triệu Phong - Quảng Trị", null, new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(4396), "Chào mừng bạn ghé thăm gian hàng chính hãng của PHAN NAM FOOD - cửa hàng nông sản sạch an toàn!\r\nPHAN NAM FOOD là hệ thống cửa hàng nông sản sạch chuyên cung cấp các sản phẩm đạt chuẩn OCOP, VietGap cùng những đặc sản tiêu biểu của địa phương nhằm phục vụ nhu cầu tiêu dùng của người dân được tiếp cận với những thực phẩm sạch, tươi ngon. Mong muốn giới thiệu những đặc sản địa phương tới người dân cả nước PHAN NAM FOOD chính thức có mặt trên sàn thương mại điện tử để khách hàng dễ dàng mua hàng, lựa chọn sản phẩm chất lượng cao với giá tốt nhất và được giao hàng tận nơi.\r\n\r\nTheo dõi gian hàng để nhận ngay voucher giảm giá và cập nhật nhiều chương trình khuyến mãi hấp dẫn từ PHAN NAM FOOD các bạn nhé!\r\n----------------------------\r\nTHÔNG TIN SẢN PHẨM: Dầu gội dược liệu Glow THỦY TÙNG 400ml\r\n- Thương hiệu: Thủy Tùng, sản phẩm ocop 3 sao.\r\n- Trọng lượng: 400ml\r\n- Thành phần: Nước, Bồ kết, hương nhu tía, mần trầu, chanh, vỏ bưởi, sả chanh, gừng, tinh dầu vỏ bưởi, tinh dầu sả chanh, dầu dừa.\r\n- Dầu gội chiết xuất từ những dược liệu thiên nhiên giúp chăm sóc và nuôi dưỡng tóc từ gốc đến ngọn, bảo vệ tóc khỏi các tác nhân có hại từ bên ngoài, giúp tóc sạch gàu, suôn mềm, thoáng mát da đầu.\r\n- HSD: 3 năm kể từ ngày sản xuất (NSX xem trên bao bì)\r\n- Hướng Dẫn Sử Dụng: Làm ướt tóc và da đầu, lấy khoảng 3 - 5ml dầu gội sau đó thoa đều và gội từ 3 - 5 phút rồi xả kỹ bằng nước sạch, nên gội thêm lần 2 để có hiệu quả tốt hơn.\r\n- Cách bảo quản: Nơi khô ráo, tránh ánh sáng trực tiếp.\r\n\r\n#daugoiduoclieu #daugọithaoduoc #daugoiboket #daugoikichthichmoctoc #daugoithaoduocantoan", "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F42.webp?alt=media\\u0026token=fb9ba94c-fdec-47fb-b782-f145d2b611e7\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F43.webp?alt=media\\u0026token=4b849fd1-6be9-4fa5-846c-c1865071899d\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F44.webp?alt=media\\u0026token=d50897e6-af7d-47bd-bc4b-e8e196dd65af\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F45.webp?alt=media\\u0026token=facf05b2-93fb-4519-b412-b73961492d1f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F46.webp?alt=media\\u0026token=4b7b2e0c-8882-4c0f-86b2-e362dcccabec\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F47.webp?alt=media\\u0026token=47195d9c-a6f1-4416-a67b-cae2ba719f10\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F48.webp?alt=media\\u0026token=5a284068-ab8c-486e-a50a-407e1ed4489d\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2F49.webp?alt=media\\u0026token=a0c04528-e4db-427c-984d-f1ef780fd838\"]", null, "Xưởng Mộc Việt", null, "Việt Nam", 80000.0, 2, "Dầu gội dược liệu Glow THỦY TÙNG 400ml, dầu gội thảo dược, dầu gội bồ kết OCOP 4 sao | Phan Nam FOOD", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, null }
                });

            migrationBuilder.InsertData(
                table: "TourGuide",
                columns: new[] { "GuideId", "Bio", "CreateDate", "ExpertiseArea", "IsAvailable", "Languages", "Rating", "TourCompanyId", "UpdateDate", "UserId" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000001"), "Expert in eco-tourism with 5 years of experience.", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6268), "Eco-farming, fruit orchards", null, "English, French", 4.7999999999999998, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("22222222-2222-2222-2222-222222222222") },
                    { new Guid("10000000-0000-0000-0000-000000000002"), "Specialist in sustainable agriculture tours.", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6273), "Tea plantations, organic farming", null, "English, Spanish", 4.5999999999999996, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6274), new Guid("44444444-4444-4444-4444-444444444444") },
                    { new Guid("10000000-0000-0000-0000-000000000003"), "Guided over 200 eco-tours with top reviews.", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6278), "Mountain trekking, herbal farming", null, "English, Vietnamese", 4.9000000000000004, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("66666666-6666-6666-6666-666666666666") },
                    { new Guid("10000000-0000-0000-0000-000000000004"), "Passionate about agritourism and cultural exchange.", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6282), "Coffee plantations, farm stays", null, "English, German", 4.7000000000000002, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("88888888-8888-8888-8888-888888888888") },
                    { new Guid("10000000-0000-0000-0000-000000000005"), "10 years of experience in eco-tourism industry.", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6290), "Rice farming, eco-tourism", null, "English, Chinese", 4.5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa") },
                    { new Guid("10000000-0000-0000-0000-000000000006"), "An expert in organic farming and sustainable tourism.", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6293), "Tea plantations, eco-farms", null, "English, Korean", 4.7999999999999998, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6294), new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc") },
                    { new Guid("10000000-0000-0000-0000-000000000007"), "Combining tourism and local culture for unique experiences.", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6297), "Cultural farming, organic coffee", null, "English, Japanese", 4.5999999999999996, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee") },
                    { new Guid("10000000-0000-0000-0000-000000000008"), "Bringing sustainable travel to the next level.", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6300), "Tropical fruit farms, eco-friendly tours", null, "English, Thai", 4.7000000000000002, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6301), new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd") },
                    { new Guid("10000000-0000-0000-0000-000000000009"), "Guiding farm tours with an educational approach.", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6303), "Dairy farming, vineyard tours", null, "English, Portuguese", 4.5, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff") },
                    { new Guid("10000000-0000-0000-0000-000000000010"), "Committed to authentic rural tourism experiences.", new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6310), "Olive farming, agritourism", null, "English, Italian", 4.9000000000000004, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6310), new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad") }
                });

            migrationBuilder.InsertData(
                table: "TourismPackage",
                columns: new[] { "PackageId", "CreateDate", "Description", "Durations", "DurationsType", "PackageName", "Price", "ReplyRequest", "StatusApproval", "StatusOperating", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("20000000-0000-0000-0000-000000000001"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6492), "Tham gia gieo trồng rau hữu cơ, thu hoạch nông sản, học cách chăm sóc trâu bò, và dùng cơm trưa với người dân bản địa.", 1.0, 3, "Một ngày làm nông dân vùng biên", 1200000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000002"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6495), "Tham gia thu hoạch lúa, ngô, khoai hoặc rau theo mùa; tìm hiểu quy trình chế biến thực phẩm sạch tại trang trại.", 6.0, 2, "Trải nghiệm thu hoạch mùa vụ", 950000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000003"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6497), "Kết hợp hoạt động nông nghiệp với giao lưu văn hóa dân tộc Tày - Nùng, thưởng thức các món ăn truyền thống và xem múa hát dân gian.", 2.0, 3, "Khám phá nông nghiệp và văn hóa địa phương", 1800000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("20000000-0000-0000-0000-000000000004"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6501), "Tham gia làm vườn, chăm sóc cây trồng không hóa chất, nghỉ dưỡng tại homestay chuẩn sinh thái ngay chân núi.", 2.0, 3, "Du lịch canh tác hữu cơ kết hợp nghỉ dưỡng", 2500000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("30000000-0000-0000-0000-000000000001"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6503), "Tham gia trồng rau trên ruộng bậc thang, hái thuốc nam, nấu ăn cùng người bản địa H’Mông tại bản Cát Cát.", 1.0, 3, "Một ngày làm nông dân H'Mông", 1450000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000002"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6506), "Đi bộ xuyên bản Cát Cát, tham quan mô hình trồng dược liệu và rau sạch, trải nghiệm làm giấy thủ công truyền thống.", 8.0, 2, "Hành trình khám phá bản làng và nông nghiệp hữu cơ", 1650000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000003"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6512), "Nghỉ dưỡng tại homestay trong thung lũng Mường Hoa, tham gia thu hoạch rau, chế biến món ăn dân tộc và giao lưu văn nghệ.", 2.0, 3, "Farmstay Sa Pa 2N1Đ", 2700000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000004"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6514), "Kết hợp tham quan chợ phiên Sa Pa với trải nghiệm gieo trồng, hái rau và học chế biến món ăn đặc sản.", 1.0, 3, "Chợ phiên & nông nghiệp vùng cao", 1100000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6476), "Trải nghiệm làm nông dân tại nông trại: hái dâu, vắt sữa bò, tham quan vườn rau hữu cơ, dùng bữa trưa đặc sản.", 6.0, 2, "Khám phá nông nghiệp Mộc Châu", 3500000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6485), "Trải nghiệm canh tác nông nghiệp sạch: chăm vườn rau, thu hoạch cà chua, nấm và tìm hiểu quy trình đóng gói sản phẩm OCOP.", 1.0, 3, "Một ngày làm nông dân OCOP", 3200000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6483), "Tham quan đồi chè xanh mướt, trải nghiệm hái chè, quy trình chế biến chè thủ công và thưởng thức trà OCOP Mộc Châu.", 4.0, 2, "Tour hái chè và thưởng trà OCOP", 2800000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6489), "Kết hợp hoạt động từ thiện tại bản làng với trải nghiệm trồng cây xanh, chăm sóc vườn hoa và chế biến thực phẩm từ nông sản địa phương.", 2.0, 3, "Du lịch thiện nguyện & nông nghiệp xanh", 4000000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "ActivityId", "ActivityName", "BreakTimeInMinutes", "BreakTimeInMinutesType", "CreateDate", "Description", "DurationInHours", "DurationInHoursType", "Imgs", "Location", "MaxCapacity", "PackageId", "ReplyRequest", "StatusApproval", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"), "Chăm sóc vườn hoa và cây cảnh", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6844), "Du khách sẽ tham gia chăm sóc vườn hoa, cắt tỉa và trang trí cây cảnh, tạo không gian xanh cho khu vực du lịch.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media\\u0026token=d34657e1-2aae-4b60-a825-a7319b98235b\"]", "Vườn hoa du lịch – Mộc Châu", null, new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"), "Tham quan đồi chè Mộc Châu", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6755), "Hướng dẫn viên dẫn du khách khám phá vẻ đẹp đồi chè xanh mướt, giới thiệu về lịch sử và đặc sản chè của vùng đất Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche1.jpg?alt=media\\u0026token=e454fa0e-1e95-4b66-9d28-d9de2bf107d0\"]", "Đồi chè trái tim – Mộc Châu", null, new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"), "Hoạt động từ thiện tại bản làng", 30.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6796), "Du khách tham gia các hoạt động thiện nguyện tại bản làng, giúp đỡ bà con địa phương với các công việc như sửa chữa nhà cửa, tặng quà cho trẻ em, hoặc tổ chức các hoạt động vui chơi.", 4.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdulich1.jpg?alt=media\\u0026token=d95f8ea1-e72d-4d74-ace7-defb632ef2a8\"]", "Bản làng vùng cao Mộc Châu", null, new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), "Tham quan nông trại dâu tây", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6603), "Du khách được hướng dẫn tham quan nông trại dâu, tìm hiểu quy trình trồng dâu và tự tay hái dâu chín.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdau%201.jpg?alt=media\\u0026token=37e256ac-3428-4dde-9923-a4ab34d79416\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdau2.webp?alt=media\\u0026token=60ffaa7a-600a-41f6-9997-b01f487965a3\"]", "Nông trại Dâu Mộc Châu – Bản Áng", null, new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"), "Chế biến thực phẩm từ nông sản địa phương", 20.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6849), "Du khách sẽ học cách chế biến các món ăn đặc sản từ nông sản địa phương như rau, quả, thịt tươi và các sản phẩm OCOP.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media\\u0026token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96\"]", "Xưởng chế biến thực phẩm – Mộc Châu", null, new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"), "Chăm sóc vườn rau hữu cơ", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6779), "Du khách sẽ được hướng dẫn cách chăm sóc các loại rau sạch như cải, xà lách, rau mùi... trong vườn hữu cơ của trang trại.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media\\u0026token=d34657e1-2aae-4b60-a825-a7319b98235b\"]", "Vườn rau hữu cơ – Mộc Châu", null, new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"), "Tham gia chế biến chè thủ công", 5.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6763), "Học cách sao chè, vò chè và sấy khô theo phương pháp truyền thống cùng nghệ nhân địa phương.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media\\u0026token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96\"]", "Xưởng chè OCOP Mộc Châu", null, new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"), "Trồng cây xanh tại khu vực du lịch", 20.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6839), "Du khách sẽ tham gia vào các hoạt động trồng cây xanh, giúp bảo vệ môi trường và tạo cảnh quan xanh cho khu vực du lịch.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftrongcay1.webp?alt=media\\u0026token=cbaae9c7-aa33-4943-a297-b1e3d2f95d58\"]", "Khu du lịch Mộc Châu", null, new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"), "Vắt sữa bò tại trang trại", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6739), "Trải nghiệm vắt sữa bò, cho bò ăn và tìm hiểu quy trình sản xuất sữa tươi đặc sản Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua1.jpg?alt=media\\u0026token=680679bc-ae88-495c-b39b-35205cdca5c1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua2.jpg?alt=media\\u0026token=29672e8d-f9af-4be5-aa8c-9e7922fa3a9f\"]", "Trang trại bò sữa Dairy Farm", null, new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000001"), "Gieo trồng rau hữu cơ", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6853), "Hướng dẫn kỹ thuật gieo hạt, làm đất và chăm sóc rau theo phương pháp hữu cơ tại nông trại vùng cao.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media\\u0026token=26a27576-3ee8-45e5-b4bd-0dfbac591c77\"]", "Nông trại hữu cơ – xã biên giới", null, new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000002"), "Thu hoạch nông sản", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6859), "Trải nghiệm thu hoạch rau củ quả đúng vụ, phân loại và sơ chế tại chỗ theo hướng dẫn của người dân bản địa.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcachua1.jpg?alt=media\\u0026token=13165082-87a3-46d1-bc9c-8d08acebc905\"]", "Ruộng nông sản – xã biên giới", null, new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000003"), "Chăm sóc trâu bò", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6862), "Học cách tắm rửa, cho ăn và dắt trâu ra đồng cùng người dân – trải nghiệm đời sống chăn nuôi thực tế.", 0.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua1.jpg?alt=media\\u0026token=680679bc-ae88-495c-b39b-35205cdca5c1\"]", "Chuồng trại địa phương", null, new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a1110000-0000-0000-0000-000000000004"), "Dùng cơm trưa với người dân bản địa", 0.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6866), "Thưởng thức bữa cơm dân dã tại nhà người dân với các món đặc sản vùng cao: măng xào, cá suối nướng, cơm lam...", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media\\u0026token=9500933b-9b09-4e07-a3b7-8d3899347fe7\"]", "Nhà sàn truyền thống", null, new Guid("20000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000001"), "Thu hoạch mùa vụ", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6872), "Tham gia thu hoạch lúa, ngô, khoai hoặc rau theo mùa cùng với nông dân địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Flua.webp?alt=media\\u0026token=2c6a3258-acda-42d4-8a5a-9122a700047a\"]", "Cánh đồng hợp tác xã biên giới", null, new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000002"), "Sơ chế và bảo quản thực phẩm", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6877), "Học cách phân loại, sơ chế và bảo quản thực phẩm thu hoạch được bằng phương pháp thủ công và tự nhiên.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche1.jpg?alt=media\\u0026token=e454fa0e-1e95-4b66-9d28-d9de2bf107d0\"]", "Nhà sơ chế tại trang trại", null, new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000003"), "Thưởng thức sản phẩm sạch tại chỗ", 5.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6884), "Dùng thử các món ăn chế biến từ chính nông sản vừa thu hoạch như ngô luộc, khoai nướng, rau luộc chấm muối vừng.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftra1.jpg?alt=media\\u0026token=d4fa66e3-818a-4641-a3d8-95f75b586fa5\"]", "Khu vực ăn uống ngoài trời", null, new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a2220000-0000-0000-0000-000000000004"), "Giao lưu văn nghệ và chia sẻ", 0.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6889), "Giao lưu với người dân bản địa, nghe chia sẻ về đời sống sản xuất nông nghiệp và văn hóa vùng cao.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media\\u0026token=c9a1233d-7fd4-485b-92af-2d662e830cae\"]", "Sân cộng đồng xã", null, new Guid("20000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000001"), "Trồng rau trên ruộng bậc thang", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6930), "Trải nghiệm làm nông cùng người H'Mông: cuốc đất, gieo hạt và chăm sóc rau trên ruộng bậc thang.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fbacthang.webp?alt=media\\u0026token=1090ca2a-4ec4-4de7-99cf-316da2719b9d\"]", "Ruộng bậc thang bản Cát Cát", null, new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000002"), "Hái và phân loại thuốc nam", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6934), "Cùng người bản địa đi hái các loại cây thuốc nam đặc trưng vùng cao, học cách phân loại và sử dụng.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam1.jpg?alt=media\\u0026token=0c350e96-b627-4792-87e7-45d0502309e4\"]", "Khu rừng ven bản", null, new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000003"), "Nấu ăn cùng người H'Mông", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6941), "Tham gia chuẩn bị bữa trưa với các món ăn truyền thống của người H'Mông, sử dụng nguyên liệu địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media\\u0026token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af\"]", "Nhà truyền thống H'Mông, bản Cát Cát", null, new Guid("30000000-0000-0000-0000-000000000001"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000004"), "Đi bộ khám phá bản Cát Cát", 20.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6948), "Hành trình đi bộ qua các con đường lát đá, tìm hiểu kiến trúc nhà truyền thống và đời sống người H'Mông.", 2.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdibo1.png?alt=media\\u0026token=85dab42a-d4de-4155-b10f-dcb86020ddbd\"]", "Bản Cát Cát", null, new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000005"), "Tham quan mô hình nông nghiệp hữu cơ", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6952), "Tìm hiểu quy trình trồng rau sạch, dược liệu không hóa chất và chăm sóc vườn theo tiêu chuẩn hữu cơ.", 2.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvuon1.jpg?alt=media\\u0026token=bca13e04-6ddc-4abc-aeea-ceb3544c67c4\"]", "Vườn hữu cơ bản Cát Cát", null, new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000006"), "Trải nghiệm làm giấy thủ công", 20.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6955), "Tự tay chế tác giấy dó từ nguyên liệu tự nhiên, học cách in họa tiết dân tộc truyền thống.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fgiay1.webp?alt=media\\u0026token=8d97fe12-81fb-4baf-bca6-2310db5d10a6\"]", "Xưởng giấy thủ công trong bản", null, new Guid("30000000-0000-0000-0000-000000000002"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000007"), "Nghỉ dưỡng tại homestay Mường Hoa", 30.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6958), "Thư giãn tại homestay trong thung lũng Mường Hoa với view ruộng bậc thang, tận hưởng không khí trong lành và yên tĩnh.", 6.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fsinhthai.jpg?alt=media\\u0026token=e9eca292-9a58-49e7-851a-985a7c2fcc99\"]", "Homestay Mường Hoa", null, new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000008"), "Trải nghiệm thu hoạch và nấu ăn", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6964), "Tham gia thu hoạch rau củ tại vườn và cùng người bản địa nấu các món ăn truyền thống như thắng cố, lợn cắp nách, cá suối nướng.", 4.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media\\u0026token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af\"]", "Vườn rau & gian bếp homestay", null, new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000009"), "Giao lưu văn nghệ bản địa", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6992), "Thưởng thức các tiết mục múa hát dân tộc, tham gia múa sạp, múa chuông và uống rượu ngô cùng người dân địa phương.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media\\u0026token=c9a1233d-7fd4-485b-92af-2d662e830cae\"]", "Sân sinh hoạt cộng đồng tại bản", null, new Guid("30000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000010"), "Tham quan chợ phiên Sa Pa", 30.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6998), "Khám phá chợ phiên truyền thống với các gian hàng thổ cẩm, dược liệu, đặc sản vùng cao và giao lưu với người dân bản địa.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcho-vung-cao.jpg?alt=media\\u0026token=fb63de66-558d-4ab7-8aae-829750571863\"]", "Chợ trung tâm Sa Pa", null, new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000011"), "Trải nghiệm gieo trồng và thu hoạch", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(7002), "Tham gia gieo hạt, chăm sóc rau theo phương pháp truyền thống của người dân tộc thiểu số và tự tay thu hoạch nông sản.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau2.jpg?alt=media\\u0026token=146de905-406d-4ef8-8ddd-8aa978e38123\"]", "Vườn rau bản Tả Phìn", null, new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3000000-0000-0000-0000-000000000012"), "Học nấu món ăn đặc sản vùng cao", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(7007), "Hướng dẫn chế biến các món ăn đặc trưng của người H’Mông như thắng cố, cải mèo luộc chấm chẩm chéo và thịt trâu gác bếp.", 3.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media\\u0026token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af\"]", "Bếp cộng đồng trong bản", null, new Guid("30000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000001"), "Trải nghiệm trồng trọt địa phương", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6892), "Tham gia các công việc nông nghiệp truyền thống như trồng rau, làm đất, tưới tiêu cùng người dân.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media\\u0026token=c9a1233d-7fd4-485b-92af-2d662e830cae\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdulich1.jpg?alt=media\\u0026token=d95f8ea1-e72d-4d74-ace7-defb632ef2a8\"]", "Cánh đồng bản Tày", null, new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000002"), "Thưởng thức món ăn truyền thống", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6898), "Dùng bữa với các món ăn dân tộc như khẩu sli, thắng cố, lạp xưởng, và rượu ngô bản địa.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media\\u0026token=9500933b-9b09-4e07-a3b7-8d3899347fe7\"]", "Nhà sàn truyền thống", null, new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000003"), "Giao lưu văn hóa dân gian", 5.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6901), "Tham gia đêm giao lưu văn nghệ với các tiết mục múa khèn, hát then, hát lượn đặc trưng dân tộc Tày - Nùng.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdangian.jpg?alt=media\\u0026token=7df3d302-ee8c-454b-a2b6-36951632720a\"]", "Sân nhà văn hóa bản", null, new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a3330000-0000-0000-0000-000000000004"), "Thăm quan làng nghề truyền thống", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6912), "Khám phá làng nghề làm hương, dệt thổ cẩm và thủ công mỹ nghệ bản địa.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdet.jpg?alt=media\\u0026token=648cbac8-add0-4056-a2a3-44d5241ed9ed\"]", "Làng nghề Tày - Nùng", null, new Guid("20000000-0000-0000-0000-000000000003"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000001"), "Hướng dẫn canh tác hữu cơ", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6916), "Tham gia buổi giới thiệu quy trình trồng rau, hoa quả theo hướng hữu cơ không sử dụng thuốc trừ sâu hóa học.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media\\u0026token=d34657e1-2aae-4b60-a825-a7319b98235b\"]", "Trang trại sinh thái hữu cơ", null, new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000002"), "Trải nghiệm làm vườn hữu cơ", 15.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6920), "Tự tay gieo hạt, chăm sóc rau và thu hoạch sản phẩm sạch theo hướng dẫn của người dân địa phương.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media\\u0026token=26a27576-3ee8-45e5-b4bd-0dfbac591c77\"]", "Vườn rau hữu cơ", null, new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000003"), "Nghỉ dưỡng tại homestay sinh thái", 30.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6924), "Thư giãn tại homestay thân thiện với môi trường, sử dụng năng lượng tái tạo, có view rừng và núi.", 6.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fsinhthai.jpg?alt=media\\u0026token=e9eca292-9a58-49e7-851a-985a7c2fcc99\"]", "Homestay chân núi Pù Luông", null, new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("a4440000-0000-0000-0000-000000000004"), "Chế biến món ăn từ nông sản hữu cơ", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6927), "Học nấu các món ăn truyền thống từ nguyên liệu hữu cơ tự tay thu hoạch.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media\\u0026token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96\"]", "Khu bếp homestay", null, new Guid("20000000-0000-0000-0000-000000000004"), null, 0, null },
                    { new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"), "Tham quan và thu hoạch rau hữu cơ", 5.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6744), "Hướng dẫn chăm sóc, thu hoạch rau sạch, tìm hiểu kỹ thuật canh tác hữu cơ chuẩn OCOP.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media\\u0026token=26a27576-3ee8-45e5-b4bd-0dfbac591c77\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau2.jpg?alt=media\\u0026token=146de905-406d-4ef8-8ddd-8aa978e38123\"]", "Trang trại rau hữu cơ Mộc Châu Xanh", null, new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"), "Trải nghiệm hái chè", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6759), "Du khách mặc trang phục truyền thống, tự tay hái những lá chè non, tìm hiểu về cách chọn lựa lá chè ngon.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche2.webp?alt=media\\u0026token=0275c711-2581-48c0-9e13-bcc383b8cfe2\"]", "Đồi chè Thanh Bình – Mộc Châu", null, new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"), "Thưởng thức trà OCOP", 0.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6771), "Tham gia buổi thưởng trà, trải nghiệm các loại trà đạt chuẩn OCOP cùng bánh ngọt địa phương.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftra1.jpg?alt=media\\u0026token=d4fa66e3-818a-4641-a3d8-95f75b586fa5\"]", "Không gian trà đạo Mộc Châu", null, new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"), "Tìm hiểu quy trình đóng gói sản phẩm OCOP", 5.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6792), "Hướng dẫn du khách quy trình đóng gói sản phẩm OCOP, từ khâu vệ sinh, đóng gói đến dán nhãn và vận chuyển sản phẩm.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhop1.jpg?alt=media\\u0026token=9dd3a3ac-52cb-4632-81aa-91a90dec35d0\"]", "Xưởng sản xuất nông sản OCOP Mộc Châu", null, new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"), "Thu hoạch và chế biến nấm", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6787), "Du khách sẽ được tham gia thu hoạch nấm và tìm hiểu quy trình chế biến nấm thành các sản phẩm tươi ngon.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam1.jpg?alt=media\\u0026token=0c350e96-b627-4792-87e7-45d0502309e4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam2.jpg?alt=media\\u0026token=04893537-abb2-4936-ba89-6e26b4b54aea\"]", "Trang trại nấm – Mộc Châu", null, new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"), "Thu hoạch cà chua", 10.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6783), "Du khách tham gia thu hoạch cà chua từ vườn, học cách lựa chọn quả chín và chuẩn bị sản phẩm cho việc đóng gói.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcachua1.jpg?alt=media\\u0026token=13165082-87a3-46d1-bc9c-8d08acebc905\"]", "Vườn cà chua – Mộc Châu", null, new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"), "Dùng bữa trưa đặc sản Mộc Châu", 0.0, 1, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(6751), "Thưởng thức các món ăn chế biến từ nguyên liệu sạch địa phương như bê chao, cá suối, rau rừng, sữa chua Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media\\u0026token=9500933b-9b09-4e07-a3b7-8d3899347fe7\"]", "Nhà hàng Truyền thống Bản Áng", null, new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("698a999b-e6ab-4050-9ede-837a2fe79c9b"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5777), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5776), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5775), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8406f6b1-b5b3-4ad0-aaf2-a8bf4e584b4e"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5755), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5754), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5754), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8efbaac2-464a-42e6-94f7-09c00043b04e"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5771), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5770), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5770), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("9ef16263-2bec-44f8-9097-0bfd096bb01e"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5761), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5760), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5759), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ac107408-4e69-4872-8efd-1fe0855e4741"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5744), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5742), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5741), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b7c525ba-8c16-4bea-8d71-d76a32b66030"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5766), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5765), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5765), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("bb68c0a7-b3d6-407b-a762-9398d401e2c5"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5787), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5786), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5785), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("dcece945-fa89-4b34-8e02-95ec03fb09e5"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5782), new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5781), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 6, 3, 16, 25, 36, 24, DateTimeKind.Local).AddTicks(5780), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "ActiveStatus", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("01dc34af-f4da-4bbe-b747-2c9892b76398"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5481), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 80000.0, 1000.0, null },
                    { new Guid("0518dc4a-5537-4a37-8b22-9b62621307e6"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5232), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 120000.0, 1000.0, null },
                    { new Guid("0a71afc7-880a-4942-85ad-b1505d5e561a"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5523), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 130000.0, 1000.0, null },
                    { new Guid("23ee9ffc-3134-4b2c-bc3c-1249a947220d"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5218), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 120000.0, 1000.0, null },
                    { new Guid("2527cbd5-15c4-4485-a5c2-700194efcacc"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5583), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 130000.0, 1000.0, null },
                    { new Guid("2cbea47c-5d83-4b4c-a1c1-d7a2d899d104"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5555), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 10000.0, 1000.0, null },
                    { new Guid("3774140b-32dc-4409-b2ea-b7081a72e2ea"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5562), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 10000.0, 1000.0, null },
                    { new Guid("3f7d3d06-b843-419a-a5b8-5a9c35049391"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5496), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 40000.0, 1000.0, null },
                    { new Guid("4008ccdc-7b04-4ec0-aa90-d4003e07bd74"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5589), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 70000.0, 1000.0, null },
                    { new Guid("4c958d7d-2520-48d8-97b9-7c107507a9c7"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5510), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 60000.0, 1000.0, null },
                    { new Guid("4fb7f4ab-9145-443f-a160-25e64313794b"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5268), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 90000.0, 1000.0, null },
                    { new Guid("596df2df-df32-4f33-a2f6-cf9f07c0172e"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5489), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 90000.0, 1000.0, null },
                    { new Guid("5e34b774-cdb2-41d5-a899-f9e52e446586"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5644), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 110000.0, 1000.0, null },
                    { new Guid("5e9ac920-e89f-4337-bebe-ad68ebca502f"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5259), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 120000.0, 1000.0, null },
                    { new Guid("5ebcf345-eb32-48a7-974d-e83c211ae9ce"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5181), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 92000.0, 1000.0, null },
                    { new Guid("638cca61-a606-4a01-808c-6cbf18887b65"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5128), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 87000.0, 1000.0, null },
                    { new Guid("6ec19994-b754-4eb9-8b45-a1eb672cb427"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5517), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 10000.0, 1000.0, null },
                    { new Guid("6ee38d87-1a1d-4ea6-8601-52738df55cb1"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5631), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 10000.0, 1000.0, null },
                    { new Guid("770bfc90-b08e-46f0-8c1c-ffd44d60189a"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5142), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 87000.0, 1000.0, null },
                    { new Guid("7825959b-cfab-4130-a16b-50aef2af1d80"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5135), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 85000.0, 1000.0, null },
                    { new Guid("7994fa87-cc01-4150-9d7e-3c12c4d41bd0"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5617), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 110000.0, 1000.0, null },
                    { new Guid("89ab082b-307a-497a-9da8-51cd01e89120"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5624), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 70000.0, 1000.0, null },
                    { new Guid("ab206a97-24b2-4e8f-b85f-91219d0758a2"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5252), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 40000.0, 1000.0, null },
                    { new Guid("b24101e2-5650-4830-8a2f-213b9ab602e9"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5596), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 80000.0, 1000.0, null },
                    { new Guid("b7b89ed9-952f-4f4f-972d-c4984a86ab24"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5116), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 85000.0, 1000.0, null },
                    { new Guid("bb3943b4-2bf6-4bba-956e-e376d8f0071b"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5245), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 40000.0, 1000.0, null },
                    { new Guid("bbccca29-b4fe-4a8c-a0bd-353c82191e16"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5225), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 10000.0, 1000.0, null },
                    { new Guid("bfd72ee9-a85d-41a8-b1dd-9212a9bc8e3b"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5532), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 90000.0, 1000.0, null },
                    { new Guid("c1e4fbcb-e8c3-40fd-befb-70e2b9256b22"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5637), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 110000.0, 1000.0, null },
                    { new Guid("e0f496da-8ffd-4ee6-b12b-ddbb56fdf330"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5604), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 80000.0, 1000.0, null },
                    { new Guid("e3ef0276-3419-41ee-973b-ddf4b6312125"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5174), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 92000.0, 1000.0, null },
                    { new Guid("e79b3efd-70b9-4909-91bf-3999ce9900a8"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5503), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 60000.0, 1000.0, null },
                    { new Guid("ea218731-8a03-4508-aa98-f5c4bdd5a491"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5611), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 10000.0, 1000.0, null },
                    { new Guid("ec2ad377-3ba2-4e58-a3b7-2874d9238810"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5569), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 130000.0, 1000.0, null },
                    { new Guid("f426a69c-ed35-414d-9d23-cb5dcf5d287f"), true, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5576), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 70000.0, 1000.0, null },
                    { new Guid("fc562145-fce7-46b0-afff-170769d341a0"), null, new DateTime(2025, 6, 3, 9, 25, 36, 24, DateTimeKind.Utc).AddTicks(5164), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 92000.0, 1000.0, null }
                });

            migrationBuilder.InsertData(
                table: "TourDestination",
                columns: new[] { "TourDestinationId", "AccommodationId", "ActivityId", "CheckInDate", "CheckOutDate", "CreateDate", "Description", "DriverId", "EndTime", "ReplyRequest", "StartTime", "StatusApproval", "Title", "TourId", "TourismPackageId", "TypeActivity", "UpdateDate", "VisitOrder" },
                values: new object[,]
                {
                    { new Guid("64000000-0000-0000-0000-000000000002"), null, null, null, null, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6382), "Tham quan và trải nghiệm tại trang trại bò sữa Dairy Farm", null, new DateTime(2025, 5, 10, 11, 15, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, "Trải nghiệm tại trang trại bò sữa", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 2, null, 3 },
                    { new Guid("64000000-0000-0000-0000-000000000003"), null, null, null, null, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6385), "Tham quan và trải nghiệm tại trang trại rau hữu cơ Mộc Châu Xanh", null, new DateTime(2025, 5, 10, 12, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), 0, "Khám phá vườn rau hữu cơ", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 2, null, 4 },
                    { new Guid("64000000-0000-0000-0000-000000000004"), null, null, null, null, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6363), "Xe 45 chỗ đón khách tại điểm hẹn và di chuyển đến Mộc Châu", new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 6, 0, 0, 0, DateTimeKind.Unspecified), 0, "Di chuyển đến Mộc Châu", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 1, null, 1 },
                    { new Guid("64000000-0000-0000-0000-000000000005"), null, null, null, null, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6402), "Di chuyển giữa các điểm tham quan trong khu vực Mộc Châu", new Guid("10000000-0000-0000-0000-000000000005"), new DateTime(2025, 5, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 8, 0, 0, 0, DateTimeKind.Unspecified), 0, "Di chuyển giữa các điểm tham quan", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 1, null, 6 },
                    { new Guid("64000000-0000-0000-0000-000000000006"), new Guid("10000000-0000-0000-0000-000000000011"), null, null, null, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6388), "Nghỉ ngơi và dùng bữa trưa tại khách sạn 5 sao TherHouse, trung tâm Mộc Châu", null, new DateTime(2025, 5, 10, 14, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, "Nghỉ trưa tại khách sạn TherHouse", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null, 5 }
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
                values: new object[] { new Guid("64000000-0000-0000-0000-000000000001"), null, new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), null, null, new DateTime(2025, 6, 3, 9, 25, 36, 29, DateTimeKind.Utc).AddTicks(6376), "Tham quan và trải nghiệm tại nông trại dâu tây Bản Áng", null, new DateTime(2025, 5, 10, 9, 45, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 5, 10, 8, 15, 0, 0, DateTimeKind.Unspecified), 0, "Tham quan nông trại dâu tây", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), 2, null, 2 });

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
