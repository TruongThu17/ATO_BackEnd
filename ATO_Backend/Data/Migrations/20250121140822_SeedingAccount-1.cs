using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class SeedingAccount1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    ReplyRequest = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreateDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdateTime = table.Column<DateTime>(type: "datetime2", nullable: false)
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

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "56f4b59d-0367-49c2-99b4-5ed8f05a204d", "AQAAAAIAAYagAAAAEG0tpc+iYMCHPj9Q1gr1SAGMw3pjcSOcPTasiCOQx4dnV8QY61j8OKvcNmUOrQaZXw==", "1f35a76a-366e-4187-a844-7bbb6c3b138c" });

            migrationBuilder.InsertData(
                table: "Account",
                columns: new[] { "Id", "AccessFailedCount", "AvatarURL", "ConcurrencyStamp", "Dob", "Email", "EmailConfirmed", "Fullname", "Gender", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName", "isAccountActive" },
                values: new object[,]
                {
                    { new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), 0, null, "a6154913-345b-49d8-addd-553eacc2485a", null, "truongthu112201@gmail.com", true, "Tourism Companies", null, false, null, "TRUONGTHU112201@GMAIL.COM", "TOURISMCOMPANIES", "AQAAAAIAAYagAAAAEIFraRB7GRC8HOIU2vFpFzp9C/L+qUoFjY5rCs4aPiC0urnUHpPrbhVHec1DmFAr9g==", null, false, "e1031835-a99d-4939-beef-1843a81c51af", false, "TourismCompanies", true },
                    { new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), 0, null, "8d2a84db-3a7f-4dbc-99b0-8da43a6f3e7b", null, "lucianafuste0717@gmail.com", true, "Content Moderators", null, false, null, "LUCIANAFUSTE0717@GMAIL.COM", "CONTENTMODERATORS", "AQAAAAIAAYagAAAAEAIj51qf1veh0YwXdJMYtoiIUiSJhbNLXu1xJEMNWacSthlLHNfrD66rPm4qt8X0dw==", null, false, "0636cb4e-5e02-4462-b49e-c6601362e59a", false, "ContentModerators", true },
                    { new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"), 0, null, "48c876b8-ed13-4c1a-9666-b1923f99997a", null, "thuthuhe2501@gmail.com", true, "TourGuides", null, false, null, "THUTHUHE2501@GMAIL.COM", "TOURGUIDES", "AQAAAAIAAYagAAAAEGGXEK/VsygpcKAJ938BagNr/jdz+BPqG4KYFmZMa2wn2EslJDKITbiMx4ic7kw+tQ==", null, false, "e8a707f2-39a0-45cc-b05d-573e030ebeea", false, "TourGuides", true },
                    { new Guid("a631bb94-66d8-44db-932b-532892d87754"), 0, null, "849bade2-9b89-402f-9529-5c6024144daf", null, "thutt170727@gmail.com", true, "Agricultural Tourism Facility Owners", null, false, null, "THUTT170727@GMAIL.COM", "ATFO", "AQAAAAIAAYagAAAAEEAZ5cs+4n/fg06oThRGhLYXVMKJAGHr6IkJuXWWtD/8imVEoiLvrV1sUhPzIa2HZA==", null, false, "244359de-1e28-439b-b178-dc3356c89c72", false, "ATFO", true },
                    { new Guid("e025738e-4686-4282-abc3-dae9c65907f0"), 0, null, "4ae26256-d382-4cb4-b537-2a0c7ad39541", null, "ThangNVSE151059@fpt.edu.vn", true, "Tourists", null, false, null, "THANGNVSE151059@FPT.EDU.VN", "TOURIST", "AQAAAAIAAYagAAAAELEdBoBmowDloEvRuV7t93Hze4OSFTw/oqeS+4IXTP7c2UUIqf4rTZ/nUoo/iTpWGA==", null, false, "de4cbd11-1f6c-448c-b0cc-b7f18c85cbef", false, "Tourists", true }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("0dae2462-9ebd-452e-a89c-06d4b6025e68"), null, "Content Moderators", "CONTENTMODERATORS" },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), null, "Agricultural Tourism Facility Owners", "ATFO" },
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), null, "Tourism Companies", "TOURISMCOMPANIES" },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), null, "Tour Guides", "TOURGUIDES" },
                    { new Guid("c78a64eb-5190-44c1-9886-ca707854b807"), null, "Tourists", "TOURISTS" }
                });

            migrationBuilder.InsertData(
                table: "UserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d") },
                    { new Guid("0dae2462-9ebd-452e-a89c-06d4b6025e68"), new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab") },
                    { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad") },
                    { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("a631bb94-66d8-44db-932b-532892d87754") },
                    { new Guid("c78a64eb-5190-44c1-9886-ca707854b807"), new Guid("e025738e-4686-4282-abc3-dae9c65907f0") }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Blog_CreateBy",
                table: "Blog",
                column: "CreateBy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Blog");

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"), new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("0dae2462-9ebd-452e-a89c-06d4b6025e68"), new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"), new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"), new Guid("a631bb94-66d8-44db-932b-532892d87754") });

            migrationBuilder.DeleteData(
                table: "UserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("c78a64eb-5190-44c1-9886-ca707854b807"), new Guid("e025738e-4686-4282-abc3-dae9c65907f0") });

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"));

            migrationBuilder.DeleteData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("0dae2462-9ebd-452e-a89c-06d4b6025e68"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("49e15ef3-2d88-4812-955f-d00859b3f7e3"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("6f8cdfbe-2d8f-4b5e-b767-194cba66309a"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("c78a64eb-5190-44c1-9886-ca707854b807"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a266f172-3c03-469b-822d-9e8ed6f31d79", "AQAAAAIAAYagAAAAENS+lnEta/3G6T9o06eoxUlqAMX/W5Sa3j32Le5/1ZNsQsiysrS6kWvljeyoogyTtg==", "16b94a28-a021-46f0-8899-87b4133e1ce3" });
        }
    }
}
