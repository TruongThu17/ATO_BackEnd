using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class UpdateAccountSeeding : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a266f172-3c03-469b-822d-9e8ed6f31d79", "thutt170727@gmail.com", "THUTT170727@GMAIL.COM", "AQAAAAIAAYagAAAAENS+lnEta/3G6T9o06eoxUlqAMX/W5Sa3j32Le5/1ZNsQsiysrS6kWvljeyoogyTtg==", "16b94a28-a021-46f0-8899-87b4133e1ce3" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "Email", "NormalizedEmail", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5805b521-c3f1-48aa-98f2-b18540dae3a0", "Admin@gmail.com", "ADMIN@GMAIL.COM", "AQAAAAIAAYagAAAAEIC5P5TglMv1CE+Bg8M8eUQHsFh6a20xUj9kQhJlJ6QE8sNPfDH1+W5C+yFkmF1s2w==", "0b51db49-1e9e-4197-81ca-f7b724b15a76" });
        }
    }
}
