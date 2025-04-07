using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Updatedb7 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") });

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("0ffc026f-7d22-4270-861a-0b8a8090e073"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("346a84ba-d4ed-429f-aa55-449248e45ddc"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("40648f95-8509-4c19-8526-3562659a45eb"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("747e1fcc-85ba-4882-aa90-4ceef4c008cd"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("8791aaf1-ef73-4715-bffa-bbdae28a8eb3"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("90be7e35-a368-4953-9414-76f3ce40bc2e"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("a6823f00-13e2-430f-bc42-8aa4176a8982"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("bec89f41-2c0f-4181-89eb-b0f6ef74adbe"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d5c12974-b7f8-4360-89ad-6f54342e86e3"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("e5c0d451-df35-4608-9967-6761b0a78622"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("ed9025d1-c379-4ef6-925f-224cf056c1de"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("f04d0908-577f-4504-930a-73baa9c565ca"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("11e088b4-8f50-42b6-b8f9-f5b3bc40698c"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("3a3ebde3-229e-4106-9de2-d8828a7ff803"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("5edf3f0a-210b-49f1-99c6-942e6cf11436"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("71cd6afe-75ae-4b54-af41-45baabeea085"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("8917f211-106b-49f6-b158-bf60b2566f8b"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("8cef3316-918c-48b5-aa11-2d6e9b084566"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("aa7609c8-cf05-47dc-a1ec-cd140782f74b"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("abbc5dcd-fab3-4769-91c7-d1157836e4e3"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("f560373a-cf0e-403e-aa1e-97c92c9b1feb"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("fdf82f41-f4bd-4322-a290-3e9563334b60"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0bd542f7-f4c2-433a-bd97-be0729f6c818"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("13829be6-bdea-4628-8df0-b8899522c476"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1bafe2d9-8a0c-47ae-98ae-e1b01102d79e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("32771c58-0334-411e-b927-97c7cf0b874a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("36fc83f6-685c-4037-a009-29d530d0777e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3a3cd782-18d0-4d60-a007-568ccddcfc61"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("506de673-dade-4930-93b5-39c47114a57f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("533462cb-7c14-4511-9070-b419b6149415"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("66e32d7d-90e4-4499-9826-bf0f13a9a532"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("673367c7-d081-436d-9840-9361a22e0016"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7024ff62-7c84-426d-9793-e200b29db35e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7397fdaa-3eaa-4e9c-946b-4ebe00f051c2"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7f51d3eb-848e-46d7-a548-18ed6d39a123"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("86867c98-8080-4a9c-8f0f-5d7d2ba5b9ee"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("87833595-75a5-46e2-8c35-8294fc00b7da"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("898a85ad-5f9c-403a-810d-f3a1ff244679"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("96131853-0dc5-4256-952b-ac249fcf4cbf"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("966745e4-6ea6-4a0d-8098-a58d882951cd"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b9cd6cd6-a5b0-43df-aad0-226e61c54b3a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("bb6629c7-6e64-494d-98c2-295991235207"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c924068f-dc69-4974-b18d-f36de2cd9e05"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("de4b25da-7648-4899-bac2-39f68744a6a4"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ec56d02d-2764-4b72-9179-76254bc4967d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f996bf46-9f33-4b69-adae-c6200ec4c3b7"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("031a3929-ca36-4687-9263-a39832a74035"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("0366c77e-8e73-46fc-a461-5cd69ff9165a"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("053eddbb-aad6-4797-adae-9ff4eab3f8dd"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("1ac69dc2-49be-450a-9ce6-c161d4d8adbe"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("869578fb-60b6-477f-8519-bbc4307382ce"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("937ca06e-3fb6-43b4-87cc-bfc95adeeb2b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("ace579ba-8290-4bbd-8716-3f47c3d190bc"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("be2101e9-2fa8-408b-9fa6-9cce566dbe82"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("c381cba2-2dba-4c4b-9dc0-cfaaa0c279c4"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("cfa58783-41c9-45fd-9036-ec1a1aaefe84"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("e0ba67ed-b234-4dfd-ac3c-0997316f96d1"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f663a9ab-8f93-4908-bb77-12cb4470d53a"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb51812b-4c39-4cfd-8338-911b7d455f7c", "AQAAAAIAAYagAAAAEJCY8jjk5UkX6qOg0Fz1p83XM/gTakopFXFrJdfKGwwJiImnQ8iIUOPTghYtca4P3g==", "792e6374-e14d-433b-a643-4080886d7553" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2776e153-a786-4382-b534-81f9110b8ec9", "AQAAAAIAAYagAAAAEExP36BQg8lk1HmFivJEHFIYb79t3wbYHd8udIuswDuOQLZdrUivX7p2xFJcBatpaQ==", "bd3f6634-11b0-4f7a-a805-a9b485805d85" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0482dda2-641f-4b53-9197-224ea9b2ae33", "AQAAAAIAAYagAAAAELh+IY0ABvrDG9QG7fd4fWt7syMcdF8aUr4h9sF4hEwsgTdj9qMe1/M3h4hySS1XfA==", "8f3177fb-c073-4b78-9862-dcc4de745ec8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9cd4401-44d5-4f76-93de-5e16a3766b72", "AQAAAAIAAYagAAAAEJziR5LTnN6aO8jy0aLbsVxvr01KMiK4QJZ6uSYrnKsMYRy1+H3yqTxM1qkrSgrEEw==", "5049551f-7f0b-46a3-8800-ffa05e240080" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88aa37a6-385e-4a10-9a74-51e7968d6171", "AQAAAAIAAYagAAAAEPpRmCMlM+fAk311coyweHDol79WVPf1pcslvbgeuxujNVoVGOA4M9m8vMIdp/oGtw==", "34a42a8a-59f0-4e73-9017-5ac790a2679e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9376c2d-97f4-46d6-baac-94469cb9cf40", "AQAAAAIAAYagAAAAEGDurmoc0J3T+Ad50XhJCfjtyfa70ClhO5etWhLKxGo3mNsIH0epaOXsK575eNamOQ==", "d4f72021-0c87-41e0-b357-68aa29d8782d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29ecd24f-11da-4f99-91c6-b9d876cd6552", "AQAAAAIAAYagAAAAEDK8gu3vS1kDfcFXYhCVEE66C2wHyQfZJtVk0tSyDAmrotHPqbrsf+NnR8UfpIsnvw==", "0b36797b-4798-44a4-b9c5-3096d71599c8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe581da3-921b-4e3a-b6b4-36f71b3022b7", "AQAAAAIAAYagAAAAEL9MhZpd5bYEU3ocjOOEdmi9m7qY/tHsOuprDx/mVQwTkpcb1U+SbKYvdg4c6IBcOw==", "0857128c-9da1-48d1-8c43-93d5782d2c09" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "14826574-b321-4624-95f6-0541785bf8ed", "AQAAAAIAAYagAAAAEGVcoAfm23BJOPMyrQ4sX0q4cNlFOAJkNyHYtNHkohw5W4bR4SfC9P4XjU4rNRCCLg==", "1b4204a2-9ad3-4aef-b159-97e71f099c95" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1969d767-501b-4db2-a371-6933c209b412", "AQAAAAIAAYagAAAAEBw5/bBXer4m8XKj2rFbCGLPRoKkrkXfZ+3bzPurbCcRgIZJjNWSf5ch/qJhSdAnqA==", "31467df8-4b7f-4ca5-89e0-145ff42c128c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c556aa31-614a-4d91-a439-b9597019d268", "AQAAAAIAAYagAAAAEERwlhjYiQYEIZ9lx9vD79GE2zN0gvYS7cpUW83VyYZGZa730w7S+FdwdvxBtBdFLQ==", "1bf8834c-852e-44fc-bf62-ab27d14cf844" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5ab4cc6-7616-4e2c-8190-826b9ea433ed", "AQAAAAIAAYagAAAAEGIHSB3t2V+yXLHnPvDnRLkfMuQ7/3J6Z47tZE8JKGS8yo89muXXfIC8PdRXTVdWRw==", "428bb373-66d9-4c84-9af4-f83f7b5437e5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e2747c6b-da9a-4f0d-91af-c5badb5892d8", "AQAAAAIAAYagAAAAEHkqRg7XIwNOM5SL0osLK7DCA1Qs8WyfspCBZ2QpHMPvrYAvJRMxNubYzhScMjl5Xw==", "2ecf6ce9-f0a5-4e62-8611-0463d3fc182d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8f32d529-58c8-4c21-b8e6-440cd21e6a6c", "AQAAAAIAAYagAAAAEI70KFYLD0nDa2RiRPhsPLkTJAmGgm3ChFNZvDbrAGZVotn3ucTOfsQB+Mg8EkRIyw==", "f58588c3-f8c2-4ccb-9bdf-b8b80549af16" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e38230a9-0cf6-4399-b514-df867462cff7", "AQAAAAIAAYagAAAAEHDp+TkjKc+yoE3/x8AyTabdjOwKHToLD7ZeXYk1Y828QUQehzac1YeNSSSIAnS9RQ==", "8db19b9b-5e98-498f-a999-02c98a8acd38" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fc112a3-40b1-4ca9-bd6a-d364469ee81b", "AQAAAAIAAYagAAAAEBxuHyw72FNr0GYI6KGtFZpbQhh1UQWgWi4IZHNC/MF9mkAG4oypCORfUyvVuNY81A==", "0ffac1a2-ea9d-45cb-873f-491e3411b9f4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "93321ed3-7581-4b93-a0f3-ef8d09502b70", "AQAAAAIAAYagAAAAEFXCxPV2hdcMlY6ulsWmG92QIYwenHKQ8UdwkTPN6IS/3pB6XHVXIvyxlP6hJMn4gQ==", "bc9a98b2-b32a-4d5a-97d7-f5910e90c42b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fe916f56-31d6-4a91-84d2-abafbfc88c9f", "AQAAAAIAAYagAAAAEOtwCMBawvhMnAYuDAV5+B0yNz95MEpKZSUrBPYtCWVLAN0f5NlpCY3sAqUG3e1zAA==", "7d348fb6-b357-4a36-8815-8214521b92fe" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4f1340f3-17a2-47cc-b101-0f00f61383f9", "AQAAAAIAAYagAAAAEM2vwF0dUi7CZqmyulmnDpOdTba2Un6d/lbqtj6I97iBKcJDbRkudjLGAN48yS6GpA==", "e87cd78c-9adb-4a23-b038-3b5c74b19b31" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61357efc-2aa6-4cc2-9cef-dcb603188ce5", "AQAAAAIAAYagAAAAEMNyP+TDSw8F3EHz0PmTkNZe1hzRhA6admElSTw41iQKpDUs18zricx5o63pOMEgWg==", "2e24a9ab-2e1f-4ad4-9ef8-e3de49e95b6d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d4415646-52dc-4185-b18d-240cfd63ae13", "AQAAAAIAAYagAAAAEEXj2T6ElqGIwyGYE4umuJjF9wNoWkX+0qkhhvzac/HpChM2YnSRKreaIYE3kS5Mqg==", "6913005d-c6c8-42df-9f6e-95dab8cd8a91" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95c4737a-86df-4bfe-b8e1-e688114ea89d", "AQAAAAIAAYagAAAAEL0tkx2Gg4tCn0OOLDBgDuHwct/d0Sa3rB7dbx6kvGFM9gRXlpHwLA6ApeQst2hjNg==", "991d867c-aebe-4df5-a7f9-273fac3c6ac2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7a8cbe9e-c807-413e-9cef-ebc3db0688ff", "AQAAAAIAAYagAAAAENMgWhpUe81EEp82DK1LT+xre08wEFeO/QoilAFP1SF4n0rs5K+0JM4OLQvEGvCoIw==", "71c8313b-5a32-4960-94a0-7e3a7017c0b6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1a6b23c2-8e34-4811-8d67-8585391521d4", "AQAAAAIAAYagAAAAEFZgzL5mdV7JPdn0baaD3Nn2YVMIvB+f9Iu/f99KbNjBoeL29Xg0P5+EANRviPxqSA==", "84651a20-bb65-42dd-9c9d-db2050b06c42" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "39573d0c-4e9e-4033-9b55-cf00f730cf4e", "AQAAAAIAAYagAAAAEIhTCNTZvNpNBzvLxwWxcU2jSqB/ZSXzRxa+ysXwJ+0hiIAm/BJCBBO2xt1tHMuj7Q==", "0c27ea40-090d-4e9a-b40e-dc8bf9627e43" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cb033e6-82ee-4042-86bc-78faa88cb959", "AQAAAAIAAYagAAAAEM+9PK9IDrifpinYk8fWSrCsldzVWJLt7hfZZlLxAYK9NgbrKHhnx9lL0PfkNXJFrQ==", "bd5512b4-ae32-42a6-a3a7-a4c5a5323c4e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a139e5a-0194-452a-9928-932d0fa3b325", "AQAAAAIAAYagAAAAEAm/HTQJ74czni29waqSImuxtSjDAD2gTwvWZmWCzO1wVsVRMhxa7SasE36E8GLSYw==", "107811c4-47c5-4853-860e-01b359a63a6f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a3be8f1-c6bd-490f-b40f-52b736d1b074", "AQAAAAIAAYagAAAAEO4dYkygUZbkqi+2KgSplTbYqDkBAAgoozssTktPoVsz58YZX9gN/IWaYXzaYwVlFA==", "2d84165c-0ec9-46ac-b0a2-088e80b311f5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac629a23-2580-4bbb-a9d9-b27aa720105b", "AQAAAAIAAYagAAAAEDmvv4GbtA3DfltgES+H/WnNvaMK/cymd0oq5B2qh8cYGVntQqlgn1uzDPTtfR0v7Q==", "4683218f-a873-4112-8dbd-50e8ee15f15e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2552e57-5a44-48ac-b30c-7e8c96e3b229", "AQAAAAIAAYagAAAAEBtpfsc3qOcugRluL5qQyTJtUclYGxlU6pfCByf3GRawF93il64i4RGk181f94Iftw==", "781add73-b7b4-4654-bb38-1fe99f3d43ad" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "add110b8-baa8-4a38-8ebc-e97069cd90ed", "AQAAAAIAAYagAAAAEI9/Uyl8lDQmkcKpJ9QWGgDFGtF3/W6nn8jlpuR8gE4TaKN6ZeOaf0LsR8Zdn32DaQ==", "9124cdda-b885-44c2-91da-7de0c3bc92e2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edf6e87e-c912-459f-99bf-0e42950e00f3", "AQAAAAIAAYagAAAAEAMwEDYUF3rQkkDvooBYzFXAcOnc9VApb8fIj2eyAQsmDW8Ks1g+LTJqATBGZt40oA==", "f98b7a38-4804-4c19-8b16-b61218ba4d09" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b9496353-e7e1-46fb-8e68-cc10ddbcc597", "AQAAAAIAAYagAAAAEEHuI8ZdB3m1gK6WEFd4V8ZsPRuEHKAkIAjCxwTVwz5GTjpH73zMl4l4OJf5J4Ormg==", "a54c0b2b-f3ba-435e-920d-9c484dd6cf35" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5050f7ac-2aa3-46cf-9620-974f2568a37c", "AQAAAAIAAYagAAAAEM4UPhT4g7XwSMBIVtkOTwaHzdR+1sXsdfHdVevfyfhuM4dFbJgpvMT7/ZFlcVHxJA==", "10debc03-899a-47eb-af1e-1d56a88e6906" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a1274dc9-a0e3-4c69-ab9f-eba5cdda6ab0", "AQAAAAIAAYagAAAAEJyxgTSs4a60kggkvaS0hTGJEL53BWcHBmOr0H3FFjI+pnv1qm1Vg79REmLN+fbrrg==", "583a60a2-ad07-4aef-993a-14bfc5c19ee9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "222b7632-78cb-421d-9199-2983f1b22de6", "AQAAAAIAAYagAAAAEPP3Y/wYL5rOAy87gfNDk7kdhk5x50WPgO4GeZYKcJ5s9d6Gj7ftkStQVpGgw9bc+w==", "0173af91-ad8a-4c19-94eb-194b21ac3e05" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3e81ba8-bf59-406b-adde-cfcf234b1808", "AQAAAAIAAYagAAAAEI2aem1CSqyhLHnORQdZtUg7Av2GqNIagmpxqPasEKOdI5R+aONHjUcQEXKyZBruuw==", "43c1777a-390d-45dc-9361-c9816b8ad3a8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "62306853-f5ec-457c-9ee4-7718b8898391", "AQAAAAIAAYagAAAAEGHm13RHlXUdRdJ5w3owF9m6/dtSnD9yvil/GIHk56qr48ccpu9urJZlCxMt5n9bjA==", "599b4a0f-fbab-40ae-86fc-c78ee60586f0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb2d86c8-0b5c-4df5-83a4-d1f82bda6df1", "AQAAAAIAAYagAAAAEJYsVFl3R2JjHCXaNp7qEtNB5y3Bm6+FNOAx19yXjryR3ogn3PiFmcw5LAncULQ3/Q==", "84f92e9a-30bf-4af0-89cd-64e91d88f814" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "084d6c04-2a9a-41e9-a4c5-b8207d4a397d", "AQAAAAIAAYagAAAAEC7cAX4091V/Dk//6Oj/yLXbO7e9xoiyaxf7LyZAgCH09m96hmg6o9u672Rz52Zq9w==", "90f7afe4-4cff-481b-9bb7-fd9bd8565916" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fcfe1499-58c2-45ea-9793-2f6d87dc0759", "AQAAAAIAAYagAAAAEMs29ZCVYBrUVmvlnhfHaqXJRSdz9yKjOjYhkZQiuMlhlSd1cuXYIB6t7FwhFR5ooA==", "9f8ffff8-824a-4dbe-8096-035eb32970d3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0dfccc7f-0706-4dcb-ba4f-f09687d47e0f", "AQAAAAIAAYagAAAAEKd8ONFPLmD6uYRsW1yzTYZ8GH0JKJEtHWujvNrwpyIrELtgKx8JBdC1mqooiR/TUQ==", "cc4cb6f7-694f-47b9-8e39-1911c3b470e6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1ef79bf5-22d1-4986-8aff-28b714df1d9b", "AQAAAAIAAYagAAAAEEukhS4DGEncvzhpLnZ9wiAqnAGsLJZ2tU3/yfTIKTe+XAnuby2tQYVfFbE4N/1aBw==", "9efb4732-e132-447c-9f3a-69eb82639ba8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70db2dff-1ac2-4ffe-81b0-efc90431e037", "AQAAAAIAAYagAAAAEHSHdAvkvJK8A2ZweaglUsz2WtkdFIVDF5TF6MJD14CxEHKX1mSDAcSSSczmksGaBw==", "28311dc0-aadb-4803-a6b4-86bbdf5b846f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95261afb-6f5d-40a5-bcda-8c318fb10b9f", "AQAAAAIAAYagAAAAEHmPfhnvXGNg4ah6x9Y80UJJcWa/hlaNIvP6NVGcd6SdeQ1/Hosoi5GchmaytfKdEw==", "d675dd66-3e56-46b2-bd14-bd9c651b39b0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b3c1eae9-d6d9-47da-81fe-7a7f85c1d2c9", "AQAAAAIAAYagAAAAEHvM9e/q02/b01c5BadKvd4K+yvoTX4P6SI1h3qySEb79Ltpb4GvRyxRV5Vxqu2OHQ==", "ce0c3443-26c7-481a-b4b9-193a187e3e07" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "575c42d7-deea-4094-b89d-c29a3fce0a62", "AQAAAAIAAYagAAAAEIvthvTxewJai50MRmZMC6z1UES3+kqdNeZYT3k2d31yjyqh+uoF5/aylDmPT4k1xw==", "7efae6ae-b344-4409-a460-5ab61d66fb30" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "372626ce-b3e2-49d5-b71e-5d65e049c76f", "AQAAAAIAAYagAAAAEBfunf45WgvYNHGELHC4prlGxZLNyN23ltPzraH5at/c6MPMhnkYunYzFT0vYyC68A==", "86f60499-dbf1-4ecb-a3dd-ee823edf8121" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74c9befe-ce7c-4e40-b03f-4bd5bd03dffa", "AQAAAAIAAYagAAAAEGXxeaa9/L74fQSPhNoTp2fag+46rXzRBy32XhCoUmFhzwIp06oPsAxaEoB8KpP6kg==", "b1bef69d-fdba-4faa-85a4-aaad6300653b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69207301-ce0a-4d5c-add1-f36654ddc0e0", "AQAAAAIAAYagAAAAEDxfpesgkDUKg7VCIk/EZmIxYu5HPg33VxDWQA16IJ7frdzRRn8Mi9kDoskSBHB2cA==", "e06e047f-98b0-42fc-822e-701703b7c1d9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c49ba1e2-acce-4f4a-afae-626d938f270e", "AQAAAAIAAYagAAAAECut3dxwZWRrDMQbh4nRBS5EE2GOLESlXDyTphLrnL2v+VQ4vskwzGIyvqOdxBkzMw==", "27958edb-870c-4fb0-9e54-83e453416894" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "95129af9-6388-44b2-9d36-613969d0357f", "AQAAAAIAAYagAAAAELSVMkCzxM8+3/9SDVzhF6qQ5ewZyZN/1gKTsjEQBAozMvsO9hqu4Zi2l2sez1pgcA==", "832e04bf-9547-432b-8361-7548804ba4aa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "957f5009-905d-40dd-9e06-021930ccf851", "AQAAAAIAAYagAAAAEHqgHlyNP+PAx8i/x1lMtCHsHxY0dlMArBFY9mbjvgNirEcq8IEAiSFHI2F1baqPtQ==", "5aee5391-8636-4a77-ac68-bcafeb7fc08e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2b8363e3-ed70-471b-845d-9119e61d6fa3", "AQAAAAIAAYagAAAAEIUuA3j/U+Rw4eXlXMAkM9ZVAa1VTv3FAxFjpdtHo/7YFeAFL8rOeEgF1IEZh5aKQw==", "ef836328-2eed-4c5f-a463-54b8241ec738" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e790dc9e-8a4e-4e72-a44e-4cb201424252", "AQAAAAIAAYagAAAAEC10krADFUg7Rkm7nUO6ZP5UacJTRqXpCmFBKLp85OmIdK4BXk7GUTvWIa3FBOC3yA==", "d69b2269-fcee-482d-bc1a-3d06a24ebd9a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d74bd40d-9544-4943-a387-e2164ee3feda", "AQAAAAIAAYagAAAAEMbFFC8j1IaIwU/Rqzi+jwhyPQp1kLemcqniJ92NN69Plelsg4PHhL/AqBzmMQDfDQ==", "a016f9dc-6ca5-4367-8998-2e97f58ebff3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92ec8e31-b85a-44cb-8dda-5f4796a93154", "AQAAAAIAAYagAAAAEER+64ZMDKCy9notoH+q58mgRL2Kl3bHmzF7X/pzALau/TxEoDyixo1+IcDPGCu/Qg==", "4a881b85-6e00-4ccb-bd51-975bf876f7c3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d39a10b1-eeda-46be-a120-6187d3d3b030", "AQAAAAIAAYagAAAAEA0z6JXZjryr8truppfrOW3hsLR1JV8ns1DtPaag5zbweqtWEpPfM0qSYGy0WWRyQg==", "02104f60-c98f-4276-b157-7f5adf9c3174" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1127084-51fc-43b8-836b-1ee051105236", "AQAAAAIAAYagAAAAEMDaU9u942Ht4NBEBRiEJ2leezr+1HQTmbPJDwaLN18slpR1SoXKEBC0CuLiRfYifw==", "0f052be6-5d19-4ba4-9801-e85d07aed389" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6750165-021a-46a2-a51a-bdf31b59c2be", "AQAAAAIAAYagAAAAEG//HkmoIVLEsw7YnhTmZoJdLmJ8+i97qLrA60pKbtzmw50Y5I0mdlIY/V8kCyP2sg==", "a364aad5-7a02-4ec8-a61c-4950c26a059f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c8644dc-1072-4d10-8f62-b1d331af24c0", "AQAAAAIAAYagAAAAEFpt3VhaYe7Hd/oteOtfDQLVol0IDHTodUNQ6k0ilL4mmXh1P/D2XV+hs8UB6GYq7g==", "c56ee591-39d4-4823-82cc-28827f3ff7a8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3711cc78-28a5-40e2-b0ca-25ba99ea650b", "AQAAAAIAAYagAAAAENbwhyM4ClGQ7AasMteNGlQ+zpWTbHrTYtfITHcaebpIc+uq83q8UCzosKXU6J2Y4w==", "d2cf07c9-8f0f-470d-80d8-0fa7ac1011ff" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f2005ea-5613-4de9-88f0-92d53c57d994", "AQAAAAIAAYagAAAAEKtIr1g+NwIahKQ8NNC17ZwHIf+J69hObm7VTrEx1/wXGcP3CQg5Nyvf4dPTZWF0cg==", "58138c6f-90c2-4727-aa0c-824e0f3b9722" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1988));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1915));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1969));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1865));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1996));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1944));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1974));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1875));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2001));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2009));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2013));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2019));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2025));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2030));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2038));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2045));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2104));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2111));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2115));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2121));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2130));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2137));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2142));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2148));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2152));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2156));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2161));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2166));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2051));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2056));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2061));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2067));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2071));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2076));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2094));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(2099));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1883));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1937));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1960));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1955));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1950));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1907));

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6053));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("36a27c99-2d44-4eef-8008-cd1f4108a609"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("38d68903-aa2c-4b7d-8d92-8c9505667aed"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("49072330-fab1-4cf3-ac2a-f9c3be29d3a6"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("879c6da5-ccad-45dd-9ec7-7b12ec0f7443"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("8a03dc57-6d1c-4fe1-8c55-a96420c18609"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("8e081b4f-4ea8-4814-9ce0-98e968067ff6"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("9df4b9ea-3388-410a-9f61-04b58e7b5377"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("ae036424-5e27-46a5-b069-dc6a4d379e6e"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("b35bdbb5-e16d-42e3-95a3-08bdb19336e5"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("b733cc05-840b-4c31-ac07-dbfc9649da77"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("bfc1de40-319b-4313-82fb-d6495670c1e8"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("f57fc56c-5654-4851-bbf6-6e198e0bd4cb"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("180ab2a7-ac8e-49bc-882c-f7d7def5e25e"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1706), new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1704), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1704), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("3ede657f-8d34-4b58-aab6-131cf8a23323"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1696), new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1695), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1694), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("4dab088a-af53-4cc8-956f-e73f23849a0f"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1690), new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1689), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1688), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("55504e3b-ced7-491e-bd77-0380cb90ac4d"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1701), new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1700), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1699), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("69e9f6e9-dc78-425b-82e6-bf7b25089bfc"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1682), new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1681), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1680), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8d0967d7-7050-41ff-9c99-d38c9c9dc2a9"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1663), new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1663), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1662), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("a198a3ca-521d-41b1-b394-7731e66a5ede"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1649), new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1648), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1644), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b87da74b-f82d-4f04-a8f5-48b78752f2c7"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1670), new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1669), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1668), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b96ec959-9314-44ec-a1bb-b16ac05d3770"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1657), new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1656), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1655), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("fd9e433e-69da-48ef-a0a5-d89cf6a6dbcc"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1676), new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1675), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 22, 45, 853, DateTimeKind.Local).AddTicks(1674), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0251f2a8-2be3-493c-ab44-c332e7adbb5c"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1439), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("0f27dad5-c32e-49a8-a0ce-4c1b6f1030a2"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1324), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("105bf70e-617c-4ca4-833e-71f6ba1e4c3b"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1447), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("1392b84d-06fb-46b4-adb4-07f1690f84fc"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1295), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("1bb69e1b-ca73-44a1-9446-b2ec8cdc68e8"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1417), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("1ef64a33-a980-4b1b-8f0f-f61e899143ea"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1185), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("3f11ce48-b79f-405f-9f63-c859d75e74b3"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1279), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("4865d448-30bd-435a-9b55-d3bea49ac5ad"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1454), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("4a602596-792d-44e3-ade6-9c5d1049fb1d"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1487), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("4c77a796-b910-42fd-b64a-153086e7c89d"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1462), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("5bae66c0-e2f0-4bee-a0ef-3ee8dd5c2997"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1495), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("6e117615-7e5a-41b5-b8cc-f1c88a98459c"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1252), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("749c2a01-d7bb-4f24-9ee7-741db9886c33"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1317), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("848e8e26-4631-4bb0-965d-817cf489a779"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1302), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("862963f7-c580-43b2-a871-f9f1d12f799f"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1231), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("9de3564d-d8fa-4cee-8f1e-2c3358972f1f"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1425), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("b305a6df-2a7a-4383-97dc-44d4470de268"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1408), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("cc394daf-4ef6-4357-b9e6-22d3b1cdd0a6"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1201), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("d0da481c-d952-48f2-92d3-00851c3258b4"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1193), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("d216acac-bcca-4e17-bc72-0c3fc925cb47"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1432), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("d29908dc-b459-4bfe-9ec1-e5a7f7817321"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1240), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("d6b238a1-e80d-4956-95b3-967c9c436ea5"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1171), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("f03ec7a0-fcc4-45ad-979f-7b8ef987cede"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1287), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("fcbe218a-7f18-4841-9497-63c0475647a8"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1310), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(9147));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(9187));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(9193));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(9154));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(9181));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(9136));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(9167));

            migrationBuilder.InsertData(
                table: "Product",
                columns: new[] { "ProductId", "Additional", "AddressManufacturer", "Age", "CreateDate", "Description", "Imgs", "Ingredient", "Manufacturer", "NutritionType", "Origin", "Price", "ProductCategory", "ProductName", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UnitProduct", "UpdateDate", "Volume" },
                values: new object[,]
                {
                    { new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), "Không đường, không chất bảo quản, giữ lạnh ở 4°C.", "Dairy Farm, Mộc Châu", "Từ 1 tuổi trở lên", new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9207), "Sữa tươi nguyên chất, thu hoạch và chế biến trực tiếp từ trang trại bò sữa Mộc Châu.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F4.jpg?alt=media\\u0026token=cc2b259e-55e1-4ee8-bd6e-7f619a3ca9b9\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F5.jpg?alt=media\\u0026token=b4c42af8-a554-496f-933f-ee72eaa99ad7\"]", "100% sữa bò tươi", "Trang trại bò sữa Mộc Châu", "Canxi, Vitamin D, Protein", "Mộc Châu, Sơn La", 45000.0, 6, "Sữa tươi thanh trùng Mộc Châu", null, 0, new Guid("d8c8e1d5-2ceb-413d-a5c7-342f7d2b9d63"), 4, null, "1L" },
                    { new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), "Không thuốc trừ sâu, không hóa chất, thu hoạch trong ngày.", "Mộc Châu Xanh, Mộc Châu", "Tất cả mọi người", new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9213), "Rau cải ngọt được trồng theo phương pháp hữu cơ chuẩn OCOP tại trang trại rau Mộc Châu Xanh.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F6.jpg?alt=media\\u0026token=2579c65f-9b67-42f3-a052-3c1fc19c509f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F7.jpg?alt=media\\u0026token=8532128f-6b27-4059-a04b-e912b62f0556\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F8.jpg?alt=media\\u0026token=d1f4592d-ea8d-42a2-b975-ef99493f8f33\"]", "100% rau cải ngọt hữu cơ", "Trang trại rau hữu cơ Mộc Châu Xanh", "Vitamin A, Vitamin C, Sắt", "Mộc Châu, Sơn La", 25000.0, 6, "Rau cải ngọt hữu cơ Mộc Châu", null, 0, new Guid("d8c8e1d5-2ceb-413d-a5c7-342f7d2b9d63"), 1, null, "500g" },
                    { new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), "Các món ăn đều sử dụng nguyên liệu từ Mộc Châu, mang lại hương vị tươi ngon và đậm đà.", "Bản Áng, Mộc Châu", "Từ 12 tuổi trở lên", new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9219), "Bữa trưa gồm các món ăn đặc sản như bê chao, cá suối, rau rừng, và sữa chua Mộc Châu, tất cả đều làm từ nguyên liệu tươi ngon và sạch.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F9.jpg?alt=media\\u0026token=fe337e6e-fe5f-43d7-8a94-622137e2dd3f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F10.jpg?alt=media\\u0026token=2d61b4e2-0451-467a-9ca8-ef26a6cb603f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F11.jpg?alt=media\\u0026token=28e3c536-92a5-4dd8-9dda-c70f3e8b34c0\"]", "Bê chao, cá suối, rau rừng, sữa chua Mộc Châu", "Nhà hàng Truyền thống Bản Áng", "Protein, Vitamin C, Vitamin A", "Mộc Châu, Sơn La", 200000.0, 0, "Món ăn đặc sản Mộc Châu", null, 0, new Guid("d8c8e1d5-2ceb-413d-a5c7-342f7d2b9d63"), 1, null, "Một suất ăn" },
                    { new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), "Không chất bảo quản, đóng lọ thủy tinh cao cấp.", "Bản Áng, Mộc Châu, Sơn La", "Từ 3 tuổi trở lên", new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9201), "Mứt dâu tây thủ công được làm từ những quả dâu tươi được hái tại nông trại trong tour tham quan.", "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F1.jpg?alt=media\\u0026token=b474731f-3c05-418e-ac71-9e7bd36f85d2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F2.jpg?alt=media\\u0026token=7b48babb-d847-4333-ad7f-332c2c051698\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F3.jpg?alt=media\\u0026token=1316b40a-1b2d-4160-a798-905976414bdc\"]", "Dâu tây tươi, đường mía, nước cốt chanh", "Hợp tác xã Nông sản Dâu Mộc Châu", "Vitamin C, Chất xơ", "Mộc Châu, Sơn La", 95000.0, 0, "Mứt dâu tây Mộc Châu", null, 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null, "250g" }
                });

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9026));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9027));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9029));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9030));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9031));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9033));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9034));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9035));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9037));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9038));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9039));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9041));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(9042));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8524));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8490));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8493));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8532));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8527));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8521));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8529));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8483));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8511));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8515));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8518));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8487));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8467));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8537));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8534));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 852, DateTimeKind.Utc).AddTicks(8480));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6199));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6115));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6120), new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6120) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6125));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6129));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6134));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6139), new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6139) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6147), new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6148) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6156), new DateTime(2025, 4, 7, 19, 22, 45, 856, DateTimeKind.Utc).AddTicks(6157) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1791));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1797));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1801));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1774));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1782));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1778));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1786));

            migrationBuilder.InsertData(
                table: "TourismPackage",
                columns: new[] { "PackageId", "CreateDate", "Description", "Durations", "DurationsType", "PackageName", "Price", "ReplyRequest", "StatusApproval", "StatusOperating", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("30000000-0000-0000-0000-000000000001"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1805), "Tham gia trồng rau trên ruộng bậc thang, hái thuốc nam, nấu ăn cùng người bản địa H’Mông tại bản Cát Cát.", 1.0, 3, "Một ngày làm nông dân H'Mông", 1450000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000002"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1808), "Đi bộ xuyên bản Cát Cát, tham quan mô hình trồng dược liệu và rau sạch, trải nghiệm làm giấy thủ công truyền thống.", 8.0, 2, "Hành trình khám phá bản làng và nông nghiệp hữu cơ", 1650000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000003"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1811), "Nghỉ dưỡng tại homestay trong thung lũng Mường Hoa, tham gia thu hoạch rau, chế biến món ăn dân tộc và giao lưu văn nghệ.", 2.0, 3, "Farmstay Sa Pa 2N1Đ", 2700000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("30000000-0000-0000-0000-000000000004"), new DateTime(2025, 4, 7, 19, 22, 45, 853, DateTimeKind.Utc).AddTicks(1814), "Kết hợp tham quan chợ phiên Sa Pa với trải nghiệm gieo trồng, hái rau và học chế biến món ăn đặc sản.", 1.0, 3, "Chợ phiên & nông nghiệp vùng cao", 1100000.0, null, 0, 0, null, new Guid("10000000-0000-0000-0000-000000000002"), null }
                });

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8607));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8632));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8636));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8639));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8643));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8647));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8650));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8654));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8659));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8663));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8666));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8670));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8674));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8690));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8694));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8698));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8701));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8706));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8709));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8718));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8722));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8725));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8733));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8751));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8755));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8758));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8762));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8768));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8783));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8788));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("1d1445e0-d724-4918-a7f8-37a8160739a6"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8950), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("33bfa695-b7ba-4b7b-93fd-b5457e71843b"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8941), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("3e3d7233-55f7-4d5a-b2fb-6ee7f9d0358f"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8967), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("4b234cfb-0a6b-4a7d-a3dd-3fbec8cb24cd"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8961), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("5fe07d19-faa2-4bf3-a9bc-f82d5946e4b5"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8946), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("6418784d-063f-42ad-88fc-e6d44f20ea89"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8955), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("67140e6c-877e-4579-a6c4-6054a9d375a3"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8948), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("94f0e9e8-b179-4156-bd04-1413ba2e0439"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8953), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("ac1f1fff-5242-4d3f-a028-e90a0986a895"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8959), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("c3f8ad01-f5fd-46ab-ae50-a284f73de087"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8957), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("f1daed62-3f8c-4a93-bc47-c7a916e37e09"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8937), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("f8cbe737-15cc-43fb-b006-8ddb486dd9a1"), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8965), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8886), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8887) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8872));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8874), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8877) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8894), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8895) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8870));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8890), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8891) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8881), new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8883) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 8, 2, 22, 45, 852, DateTimeKind.Local).AddTicks(8866));

            migrationBuilder.InsertData(
                table: "ActivityProduct",
                columns: new[] { "ActivityId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55") },
                    { new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17") },
                    { new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18") },
                    { new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988") }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988") });

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("36a27c99-2d44-4eef-8008-cd1f4108a609"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("38d68903-aa2c-4b7d-8d92-8c9505667aed"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("49072330-fab1-4cf3-ac2a-f9c3be29d3a6"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("879c6da5-ccad-45dd-9ec7-7b12ec0f7443"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("8a03dc57-6d1c-4fe1-8c55-a96420c18609"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("8e081b4f-4ea8-4814-9ce0-98e968067ff6"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("9df4b9ea-3388-410a-9f61-04b58e7b5377"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("ae036424-5e27-46a5-b069-dc6a4d379e6e"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("b35bdbb5-e16d-42e3-95a3-08bdb19336e5"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("b733cc05-840b-4c31-ac07-dbfc9649da77"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("bfc1de40-319b-4313-82fb-d6495670c1e8"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("f57fc56c-5654-4851-bbf6-6e198e0bd4cb"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("180ab2a7-ac8e-49bc-882c-f7d7def5e25e"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("3ede657f-8d34-4b58-aab6-131cf8a23323"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("4dab088a-af53-4cc8-956f-e73f23849a0f"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("55504e3b-ced7-491e-bd77-0380cb90ac4d"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("69e9f6e9-dc78-425b-82e6-bf7b25089bfc"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("8d0967d7-7050-41ff-9c99-d38c9c9dc2a9"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("a198a3ca-521d-41b1-b394-7731e66a5ede"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("b87da74b-f82d-4f04-a8f5-48b78752f2c7"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("b96ec959-9314-44ec-a1bb-b16ac05d3770"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("fd9e433e-69da-48ef-a0a5-d89cf6a6dbcc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0251f2a8-2be3-493c-ab44-c332e7adbb5c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0f27dad5-c32e-49a8-a0ce-4c1b6f1030a2"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("105bf70e-617c-4ca4-833e-71f6ba1e4c3b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1392b84d-06fb-46b4-adb4-07f1690f84fc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1bb69e1b-ca73-44a1-9446-b2ec8cdc68e8"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1ef64a33-a980-4b1b-8f0f-f61e899143ea"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3f11ce48-b79f-405f-9f63-c859d75e74b3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4865d448-30bd-435a-9b55-d3bea49ac5ad"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4a602596-792d-44e3-ade6-9c5d1049fb1d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4c77a796-b910-42fd-b64a-153086e7c89d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5bae66c0-e2f0-4bee-a0ef-3ee8dd5c2997"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("6e117615-7e5a-41b5-b8cc-f1c88a98459c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("749c2a01-d7bb-4f24-9ee7-741db9886c33"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("848e8e26-4631-4bb0-965d-817cf489a779"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("862963f7-c580-43b2-a871-f9f1d12f799f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9de3564d-d8fa-4cee-8f1e-2c3358972f1f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b305a6df-2a7a-4383-97dc-44d4470de268"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("cc394daf-4ef6-4357-b9e6-22d3b1cdd0a6"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d0da481c-d952-48f2-92d3-00851c3258b4"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d216acac-bcca-4e17-bc72-0c3fc925cb47"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d29908dc-b459-4bfe-9ec1-e5a7f7817321"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d6b238a1-e80d-4956-95b3-967c9c436ea5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f03ec7a0-fcc4-45ad-979f-7b8ef987cede"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("fcbe218a-7f18-4841-9497-63c0475647a8"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("1d1445e0-d724-4918-a7f8-37a8160739a6"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("33bfa695-b7ba-4b7b-93fd-b5457e71843b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("3e3d7233-55f7-4d5a-b2fb-6ee7f9d0358f"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("4b234cfb-0a6b-4a7d-a3dd-3fbec8cb24cd"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("5fe07d19-faa2-4bf3-a9bc-f82d5946e4b5"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("6418784d-063f-42ad-88fc-e6d44f20ea89"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("67140e6c-877e-4579-a6c4-6054a9d375a3"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("94f0e9e8-b179-4156-bd04-1413ba2e0439"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("ac1f1fff-5242-4d3f-a028-e90a0986a895"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("c3f8ad01-f5fd-46ab-ae50-a284f73de087"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f1daed62-3f8c-4a93-bc47-c7a916e37e09"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f8cbe737-15cc-43fb-b006-8ddb486dd9a1"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"));

            migrationBuilder.DeleteData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"));

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c122b5ab-c2f5-4c01-b1f3-2a9297361f3a", "AQAAAAIAAYagAAAAED74/Q0X451051eSpeHC0DA/X4rw8POFOgL8B3japBVKVkvko79GvTQoNo/FeWfU4w==", "d589fc32-f49f-433f-9087-ba9629664d90" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "828abc56-1e6f-4d8b-92f8-2dfcfd0188e4", "AQAAAAIAAYagAAAAEN4x/PV+W/fneTa3agvDTLXdjTmKi5VdezCOqPy4zt0le55VdamSzY3ZVmLs1zoL4A==", "d481a19c-9eed-407a-8a51-dbb7e1b4af44" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c97d460-dc2a-4ff9-a5e3-706abd3a9043", "AQAAAAIAAYagAAAAEMTFgZRQAswRYB9oIMzQxR2kSzF4sZisjwUzphTReBnX0BmumhbC4kmbICu/qXKwKQ==", "4b9d105c-d17b-44fa-9340-beeb4f15f767" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "beb04211-d3d5-42b8-bdd2-db5e77845c22", "AQAAAAIAAYagAAAAELQ1K9wmMXHAZ5ZZ8b+QbJ/eyRk58hITNOzMNut63oZD1HebJ0M8+hHe8+MiXHbiPA==", "be3934be-8ba7-4750-b1de-a97a1069f3b1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ff2e5a2-74d5-4655-9a3b-1cd6929d4314", "AQAAAAIAAYagAAAAEDVmxobuD1aWw/CovKAjALmNapN+ifY9xjt84My4wJZ71XdRCbpTU4sKYzLM+q1AfQ==", "c5b9c5b0-11d0-4bdd-813d-7b792fbe87fc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae8d604d-c733-47b5-ae32-bfe44433b404", "AQAAAAIAAYagAAAAEADXsLpFgI56OKBcmGmT26cv3zhyeIA60Q8Up6Oks35Ig5uN3z3+zOlR+NGrZRtwBA==", "e717edd0-8974-448c-8b5f-1f309c269545" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a9afd7cb-2431-4ce7-b178-81934b392d4d", "AQAAAAIAAYagAAAAECFSrSzdOTDaj8ZHfAvSjyfuYizeBhGmSiJOvczx0YrV2Rwa0bPAM4dXz9Sk+FD2wg==", "ad241fb3-9669-496f-b262-91d71371dcc1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a945b46c-9e46-4d18-9b83-f413b8c418d0", "AQAAAAIAAYagAAAAEGb2ZkPV94R1p4AiwxILN20D84Cg16R2HaWu5bIUSR9BlH5eNVotEm6EpGa2bxa/Lw==", "2d3b1d3c-ff05-4a37-b98c-c4b3d644fec6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9640aae0-6d24-402b-9fff-39f97a1f0295", "AQAAAAIAAYagAAAAEP1xlU2qjRBXDv4GI+ha1Jb0+SRH24aTPYkMYZfQPEQ5XN8swrnatd9FVBSr6V5fOg==", "a0dd64d4-0869-4c39-95b6-959f9861d4dd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e23c0e11-f953-41bb-87da-ff2d4f719181", "AQAAAAIAAYagAAAAEIu64BCtdYx5Unk78md3EbTe55KOtkwyzBUs5fVAHP8AJr1aFBxe59Cjqx/KtdVoAw==", "994a32de-df49-4aab-b5a4-51a10f23c5b1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d833219-3bbe-415d-92a7-6bd2872f0740", "AQAAAAIAAYagAAAAEGQdgAAHTWqvZBRkPbc97pdooTIig2dRT5NquoDr1CZNWBY6nscEX8uhh+fa4zegJA==", "718f2ea9-9a4b-4b4f-a802-4afc3a129211" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37d74554-2696-4372-ba39-79a897251a9b", "AQAAAAIAAYagAAAAEFfCtXGStW5DWMaIhp460muYxNUKnCLMgnnukPAFIW9CgBHf4NtMRAM7D2ft6g06eg==", "0c4678a4-d3cb-44f9-8bc4-2fab4ab99e39" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0fffbcdd-d2e0-4387-9137-c8daac0fdca8", "AQAAAAIAAYagAAAAEC88z0V6aPLfmF0aJBL9mMOg/gIMsL9g5zWsczitrOkojHHDFE6RVZcBkD6jNiNKUg==", "728fea7d-cb60-475b-b3a6-39e350f96d65" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "48594ba7-2d0e-4382-adc3-c2267fd2b51c", "AQAAAAIAAYagAAAAEAdsHWVmT+1F8YkVaOl7qEJ/dP+/HN5okqXgnhvPqzQJHQfuDs5pEd7xi/x4I9K+OA==", "6add8c61-86c2-41dc-b0d8-d49aa578ef27" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7ac6ac9a-8d42-41b6-8f40-9f5d188a6fb8", "AQAAAAIAAYagAAAAEGGLJL/+zy1D2QaGFfgmhywVlTkQaSE3iG9NpMIPB4Qci9euBJjE58UsnunboGpLog==", "0667a699-d2a8-41e0-96c0-29b5bcaadc75" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10e83764-ae6d-487e-b465-2121cdbf3365", "AQAAAAIAAYagAAAAEHecRkU468UrpkZZpS7IRoAMbHrK2mwLUJX0e1rmzHZ5ciYgoFs5NW3wBnlz0O15dA==", "6bacbb4f-3212-422c-9b9f-a2908012c885" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c40a7cb3-7bf6-4208-8b4b-7a916c809ed7", "AQAAAAIAAYagAAAAEKR2cKMAZnEh9tagE4X0Ks5OJUKNNSvQ7X/9KC6/L8vRhZ5TenU3wlihlqBqV/NN3Q==", "4c0c08b2-4f01-4172-ad50-f70ffa29e810" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8eafd09c-24fe-47d8-97c2-f8f338133237", "AQAAAAIAAYagAAAAEJjPzrLEInRHRlrCVadRhhXh0HHCj18/g0+0xYVVyzPvqrGr6i9nMkCi0uF4FQkUeA==", "e049014c-c12f-40fa-9a8e-1d10d6f0a5d5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "07b0a20d-a220-4d37-b6f0-4e540dcbdc52", "AQAAAAIAAYagAAAAEM5+YGNJvqSodx/URkNqs/O2Qbg6NkSmHK4kULrZUgWdRB2x58rCPK3GQU5HIJCa8Q==", "1844fb6f-0c4a-4d3a-b075-7ee9430f1606" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dcb55f9-d7c1-449f-9852-a13af9027298", "AQAAAAIAAYagAAAAECh4+oajCvmKx7zJfPeAMwy4Nr47cyxYGj9unCWUkVn9OXFJKjJwRO0yT9Cp3nK2WQ==", "63fa79ad-babe-434e-9ae8-4f90d1011041" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e82309c1-37e2-4e01-afd9-1d82bff38ae1", "AQAAAAIAAYagAAAAEDl1py7s6gwJD2ilCxExj8KYTDJLJUSgm4wLHcoqaORYsQnXSNKaP3mWAOrIgTyOLw==", "d07ea8e0-b806-47f8-9a31-5de121f7ede0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9fe3e8f9-d9d2-4db3-99ca-0f402098d07e", "AQAAAAIAAYagAAAAELaXzb/ZeUp3seRfyw05Taqb6FOdIHQgJVIgbSvb5xgeT8GmtXkpK3JxWDG1OFuu0w==", "10e3def3-2eec-4b78-9ee2-953e5b90df00" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f3604e7-9cf3-4aec-8d5b-2cd9dc43b9da", "AQAAAAIAAYagAAAAECI8CtdVKxNv3WFr4cKMbZ6ngOJ6MSWeIh6Y8VtU20NZLJuNeiRTdH2nHqol5/YmbA==", "cf7b0871-00ce-429b-af3c-9a4d848f7c13" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "135447ac-cbb4-4fed-b13c-b3f0363f3579", "AQAAAAIAAYagAAAAEMC3LvTM+gCqcRLFzH8Kw2NSRTV7BI/cAy7m5BlUeClrGp8WZSpxdZw/EqZhT3b9ng==", "398dcad5-ae13-4321-a7ae-425082f39206" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5783440b-3930-4c20-9f40-0f8ea64f9499", "AQAAAAIAAYagAAAAEOG2YVw4pVnXFF+vUfSaPXHV8oU5NnfONNofZMzJVJG4Yfmk0PfXjwqxw0f3YXj6pA==", "30d9feb9-1bf4-4da0-9c44-7fd02d57c3a8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57be784f-bc5e-4b1e-bec9-2a912a34e997", "AQAAAAIAAYagAAAAEH2gt1HKnoar1o4JjAwWOU4EAJeLcEx2VD+ITtsvdFRO/3WHWybUTLJ55wCIPxdAOQ==", "104faff8-555a-462d-9fca-f5a9d24cda9f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ceb73455-73b6-4bad-b08d-8562ba4b0fb9", "AQAAAAIAAYagAAAAEIqGQHr0UMtBsRjLnyprlw1SUfga6/T844oSsP8F15K7mozyBy6OiH2IzxmKcvuwCw==", "ecc5369d-57fe-4e60-af89-12d9e8ae33df" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edf1ea55-2627-4bde-abf4-e7801dda66d1", "AQAAAAIAAYagAAAAEMJZEU17ShVLDxwIoatoYxJ6rYO0eUoK0v1TufR/4L5fayj+ORyFba1NBzGu88rLuQ==", "f1770da2-4d0e-4978-854f-98a551182f10" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1b9dad9-71fe-4d8d-9f73-decf1172997e", "AQAAAAIAAYagAAAAEALoqFqdZKT3O7PxIHxIBmCxzjCVeax4A0SWLsIEgLgds5b5CRtVkNuxbbPatv3B0A==", "353ce3ae-14c2-4e04-9bd9-129f4089918f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "083fc293-ba31-47ed-8a86-ec0652b530a0", "AQAAAAIAAYagAAAAEKjz+zib7EgWlok2Mx/XmZPicL7Qdw8tR0j9iNpP0qrDC1z9LTseXpqNrVCYyfPoaQ==", "05a543b4-8035-4153-8f60-9307bbc334bb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f6000bf-9754-4091-b468-37ce44581d11", "AQAAAAIAAYagAAAAEARg9/empcurWkYAviQvkCLBu7q9v42vaMNVSJAnDPU5/Egy+v4MLodyEDGn6jtTVA==", "992b3729-02f2-4cd2-a900-375f1fbaaa87" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "435eb9a4-819b-43d4-8c57-c09ce3dd904a", "AQAAAAIAAYagAAAAEM5ANqFrEX3hLvyPBVxhjnemKUBDZFjMRqggROIohm7NVDhT5QIPZ6rr70fQ8Jv7xw==", "0ecac154-abd3-4ede-a5bb-d3b2fff9a6c1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac30e40f-e4f8-4299-9cc3-5295055e489a", "AQAAAAIAAYagAAAAEJI6pzgZahsrbgS1MCmCyP6dJWqkdjWb/F87ZxxzsXETELrHUShaw/LrovjGVk5slw==", "e8bc31fb-a6b2-4fc0-bc2b-0a4bbf59767b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "699b7d95-9660-4fdd-80ae-2f72a3d5c672", "AQAAAAIAAYagAAAAEH9RPni6n80vp4eFqLkFKqL7co+ayO7QyXf6jcVTo9hbckdPxT8E6d58H2Gl1sSKrg==", "5daf82c5-b557-434e-80ed-0a772f85534e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74bd9ed7-c2c4-4d10-9c5a-a08a4a40b67a", "AQAAAAIAAYagAAAAEP5QFKeG8E4pgt8+IEbD5kvXsLFAhv2hT6O7DogNEOM4GiHKdSfPoEqi/K3Z6Ex0JA==", "c68e7f4d-9720-4838-b77d-7983bd209897" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77fecab7-5d9e-4cd9-8da4-a41c220fbf80", "AQAAAAIAAYagAAAAENNpBC0tF6XcjlHp9M+sOLb2Bri++b9SkhdVHPSyV7flBw3EM1cBcvF7h3PMCF3zzw==", "e185fd5f-cfb2-47c7-9b08-ef4f9eb19e04" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d1cfdffe-0e25-46b9-b072-5d98440967b6", "AQAAAAIAAYagAAAAEAv4NrCnTe+Wqtjt3ZMfrKoIE3dwA7MU3VeSDrcLCLVHA5dUm2kGlO6u+3aS2mayLA==", "118d9225-1e8b-4f74-91dd-360327022c9f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a36227be-18cd-40a1-b139-bd2a7d08f73a", "AQAAAAIAAYagAAAAEFqyOskFl70euZxeCfTThMcaxwQjK2sXs+3LIb5NkKD+dsRGAsYw/iQldiUVg8teJQ==", "b469b080-0230-4cb9-bc62-c710ab77fb97" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dec24d46-f7ba-4f43-b11d-5aa229ebef3f", "AQAAAAIAAYagAAAAELr56aj1u1QfriK+C9O8Dd6TLvwLO+4xu1idMwBufjk9RagVj/B+N7fSqR+xiB5rcw==", "31408816-5efc-4b29-8626-c0e437413c9c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c441c383-d76f-49c8-81fe-a5512f093d9f", "AQAAAAIAAYagAAAAEIKCIR4dZyjxpZgQzHReN02eIaJEStML+h0IQrHYfis8WmBoB2+pEpfNCdZ0/kIYqg==", "20c16a24-c28f-443a-a585-3229c99a2e66" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4a73eb7-b17d-42d3-b7f7-8572573dcf39", "AQAAAAIAAYagAAAAEH8tpiL8Mfdao14vOfCiLyGViceGKxV5liwjt5AdETbHUGLQhwYJQHguw+LWU2CF4A==", "d8334188-67f6-4874-aa8d-aef8b188df7b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8be2d312-3c09-4ded-b189-87a64ab1ee30", "AQAAAAIAAYagAAAAEHeDSYG8OT87EqS5EekBoAHuAP/afN4JYheJti3qS+0Lk/wtmBZxUKBuZd0VWmvP6Q==", "71df61e3-faae-4b46-b25e-468e3faaee14" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bdaf2fa0-2086-482f-a5ce-8421d7571dc4", "AQAAAAIAAYagAAAAEHchGAx33uRACNryoHxeb9EqODu5+J0ukX/qpvdAu3ouZEwk5W/1IpqnKCrVkqZEZg==", "7651a860-653e-4da3-b9e1-172d4abd262b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "608968d3-a5af-4b36-8099-faf8d7d17d08", "AQAAAAIAAYagAAAAEPYGkgvQAP5umE1nDLt8DfmJWtRWwNXlY/nOpr4T6VdoWoY78k/F0d79iCOWDFpX7g==", "f198b389-6465-49d1-913e-b65fb73909a1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e0497a07-0f0e-4e5c-920c-45b35421d3ee", "AQAAAAIAAYagAAAAEJnAaRnNqoUoyO4VOn5Cr0M8IdHT9LJ8SYIj5i83/emfGukMK2St4AVBFsRbqiKEbw==", "e2f5afbb-460d-4f4b-8872-a56ef883eb39" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7316faed-b1a2-4cca-979c-7dd81bba15fe", "AQAAAAIAAYagAAAAEIjvj9uU8DrDcVrbyC2NVjOec38VkmnyU5s7AVwioiarjFwwGlzE4CkMt7fCMpp6dg==", "4fb4e9e8-34c4-49f9-9881-513c38acaf68" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "983f77bf-228e-42b3-bcab-0529a38bbcfc", "AQAAAAIAAYagAAAAEFdzprn+p6dMQYnQvn+QRTFWdB2xIMutysKw0oGOVIeKwPNCNgbYeDrEs4P0PNUoxw==", "7df15e18-ef0f-4386-a4e0-9fe2cdcf6ff6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "26464355-72c6-4806-9671-7d162deaaf0e", "AQAAAAIAAYagAAAAEGy38wADlUj9Ryj8e3MtDKS3DKAFEukttwhBxLAUqvwxks3mIc5QukveRrPiU8g64g==", "893b3c0f-7d0d-419e-8c1e-f88df75e1c5d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ca8f8a19-a0d8-4069-b872-9827cd86b8dc", "AQAAAAIAAYagAAAAENpfQJAgG12QS/95Tg15TMFU57773ClOVPF+/B3kUlc4j4pC/bYPQWit9Hl8blnRow==", "f3c03c01-5d68-4532-883c-b3cd15e5df41" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e4a24085-4f02-4508-b5d8-984f3fc6f9df", "AQAAAAIAAYagAAAAEGK7U6Eyk8oTKEBd8wjOqbxpNnNEiFHUUu/h4KlFyRpRDXAa1yzPvuhbGtUpQ9ZOAQ==", "3980dbdb-d919-455f-a7ad-ba4f5266e709" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ce30d27b-1719-4e59-902e-82129fda0345", "AQAAAAIAAYagAAAAEPMpaoqBRbm28XuKZNA1XfbK2tqPfDC43nRm3ey5MvxgnukxPRDfqp++5CcXZgwlHA==", "600f4b47-533f-484d-8860-c79d86dbcc15" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5efca35-29b3-476b-9b2b-2d0bead39631", "AQAAAAIAAYagAAAAEOSshlLbNboROtIXXxft5uaHhDweSgio5tUthdv+5rZ1SElp5/SEFj3YhDN79irtwA==", "16235f5b-8e60-485f-a3c7-c28872bfbdd0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fecfad37-a26a-46e6-b826-fe33f64ead49", "AQAAAAIAAYagAAAAEORKfg77TwMeJgeE4Sr0iMTAyRcUMt1IMixgLUjqg7vOzkFfKEkGjuroZXwYW+hrAw==", "388f8558-b0f8-4371-b102-f9b290e5bff4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8b2dd69f-dbe8-4e53-9985-db3ec0ede931", "AQAAAAIAAYagAAAAEI/LBbZstNyGYvZz5XFxmmUvnnGvuyYu9RTvbRoWHexuyjGQjHUZtksCBwVDtfSVzg==", "32f3f46e-6578-43b7-8472-5a71b65c5af8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8f94ebd-8eb1-40c0-a496-e9d62c0ce0de", "AQAAAAIAAYagAAAAECrQXmUU+ZauyZtYUeLDfTxsiTY19jfYXfT2O/ouxPjl9R7mWsgg6s4LlBKr6SGNRg==", "ab07cd58-44df-42fe-8ea0-8876cd18fe2e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6c5b0f6-d705-4cd5-be2d-fa0628f4d69b", "AQAAAAIAAYagAAAAEIcyNSNN/CZhZ+2AYSwqeVrrEUAqt5BOmqF23BXRpgDrIaW1++yQYLsb2BJSGyDHWg==", "53f27f5e-ade7-4964-8638-57449bd22ca0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c59ac0a-5d73-476f-b7a2-e46d45136862", "AQAAAAIAAYagAAAAEKkrMyiyvZdI9r6rj6DrtTlqQDybF6sZIsEA8QpSs4GpeYklcDIHbKu1z9EmHzho7g==", "b43aee7e-9cc2-4714-ada2-c6dabd811713" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a32b131-b9f0-40f6-848e-72dd013720e5", "AQAAAAIAAYagAAAAEFkmFYiZdNfe2vpB7cGrjsXoLqr0EbKJ4omfvjTvqI594HSnSGjw4OKtjNwb0l2oWw==", "0f1965a3-3a30-43c0-adcd-34f0cf8aeacc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "899afc9d-3b59-4df3-a836-0273398b0d7f", "AQAAAAIAAYagAAAAEG9nKIROUnQU5sPvX4Ov68HQEWRHt1pRmmbWf4brxqqcUto1qe4MhQT8t9ricMoU9A==", "7501a92a-b820-4e3d-8f60-ea83f4523540" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8adc92d9-6fc6-4259-a35a-9e43b0ceb447", "AQAAAAIAAYagAAAAEANgAL6OmF63kbKku8ZaX8ohkR4wRqE8/zl5uM4P20Jwhlbyu3SUEE7nVZ0ygp8xgg==", "f86b265f-ba58-44e7-b1af-cb86cda8e8e7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4a3d109-9de1-4813-9826-fb1c272ad438", "AQAAAAIAAYagAAAAEJde41ywG/4jJyTeeqBvO6QhFcift8qq7jNnMeSO0iZcEOKcK/JgSGm5IohD7RlbSA==", "b9c4f558-ae43-4bf4-847a-02a3b7e22c47" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ac4f1ca6-75e7-4305-948d-5b9f7ae24aea", "AQAAAAIAAYagAAAAEPKHi/P0A4BSWrLe/TSvk3QymdzlWmht35+hMfzabVN7IuseQucyGeGudoGRzljm7w==", "74914f1d-8385-49d0-8e2d-59e18feed78a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7b54f0cf-dd44-47e3-b589-69542f8fc73c", "AQAAAAIAAYagAAAAEEZ7I4ODaVKQmv7jr8BmeAJ+38ITU821LtK7XGC5LYWn78YBtr3RHWyu1L8v016tMA==", "fcf107ca-ccae-46fe-a57e-709db6c0ab1f" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7727));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7591));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7716));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7554));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7733));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7682));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7602));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7721));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7574));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7738));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7745));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7751));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7756));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7761));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7766));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7773));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8085));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8136));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8142));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8149));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8162));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8169));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8174));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8178));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8184));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8190));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8198));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8203));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8207));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8093));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8104));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8109));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8114));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8120));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8125));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(8129));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7580));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7676));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7711));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7704));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7700));

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7585));

            migrationBuilder.InsertData(
                table: "ActivityProduct",
                columns: new[] { "ActivityId", "ProductId" },
                values: new object[] { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9671));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("0ffc026f-7d22-4270-861a-0b8a8090e073"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("346a84ba-d4ed-429f-aa55-449248e45ddc"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("40648f95-8509-4c19-8526-3562659a45eb"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("747e1fcc-85ba-4882-aa90-4ceef4c008cd"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("8791aaf1-ef73-4715-bffa-bbdae28a8eb3"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("90be7e35-a368-4953-9414-76f3ce40bc2e"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("a6823f00-13e2-430f-bc42-8aa4176a8982"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("bec89f41-2c0f-4181-89eb-b0f6ef74adbe"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("d5c12974-b7f8-4360-89ad-6f54342e86e3"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("e5c0d451-df35-4608-9967-6761b0a78622"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("ed9025d1-c379-4ef6-925f-224cf056c1de"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("f04d0908-577f-4504-930a-73baa9c565ca"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("11e088b4-8f50-42b6-b8f9-f5b3bc40698c"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7360), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7359), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7358), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("3a3ebde3-229e-4106-9de2-d8828a7ff803"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7342), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7341), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7340), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("5edf3f0a-210b-49f1-99c6-942e6cf11436"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7388), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7387), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7386), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("71cd6afe-75ae-4b54-af41-45baabeea085"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7396), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7395), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7394), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8917f211-106b-49f6-b158-bf60b2566f8b"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7402), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7401), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7401), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("8cef3316-918c-48b5-aa11-2d6e9b084566"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7380), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7379), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7378), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("aa7609c8-cf05-47dc-a1ec-cd140782f74b"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7408), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7406), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7405), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("abbc5dcd-fab3-4769-91c7-d1157836e4e3"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7330), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7329), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7326), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("f560373a-cf0e-403e-aa1e-97c92c9b1feb"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7371), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7370), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7369), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("fdf82f41-f4bd-4322-a290-3e9563334b60"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7351), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7350), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(7350), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0bd542f7-f4c2-433a-bd97-be0729f6c818"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6896), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("13829be6-bdea-4628-8df0-b8899522c476"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7242), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("1bafe2d9-8a0c-47ae-98ae-e1b01102d79e"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7038), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("32771c58-0334-411e-b927-97c7cf0b874a"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6964), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("36fc83f6-685c-4037-a009-29d530d0777e"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7048), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("3a3cd782-18d0-4d60-a007-568ccddcfc61"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7175), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("506de673-dade-4930-93b5-39c47114a57f"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7023), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("533462cb-7c14-4511-9070-b419b6149415"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7163), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("66e32d7d-90e4-4499-9826-bf0f13a9a532"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6956), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("673367c7-d081-436d-9840-9361a22e0016"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7196), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("7024ff62-7c84-426d-9793-e200b29db35e"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7133), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("7397fdaa-3eaa-4e9c-946b-4ebe00f051c2"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6904), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("7f51d3eb-848e-46d7-a548-18ed6d39a123"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6972), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("86867c98-8080-4a9c-8f0f-5d7d2ba5b9ee"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6884), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("87833595-75a5-46e2-8c35-8294fc00b7da"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7186), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("898a85ad-5f9c-403a-810d-f3a1ff244679"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7056), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("96131853-0dc5-4256-952b-ac249fcf4cbf"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7016), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("966745e4-6ea6-4a0d-8098-a58d882951cd"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7031), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("b9cd6cd6-a5b0-43df-aad0-226e61c54b3a"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7008), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("bb6629c7-6e64-494d-98c2-295991235207"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7223), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("c924068f-dc69-4974-b18d-f36de2cd9e05"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7142), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("de4b25da-7648-4899-bac2-39f68744a6a4"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7234), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("ec56d02d-2764-4b72-9179-76254bc4967d"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7210), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("f996bf46-9f33-4b69-adae-c6200ec4c3b7"), new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6912), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6608));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6651));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6658));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6634));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6617));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6644));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6597));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6625));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6457));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6459));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6460));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6462));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6463));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6464));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6466));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6467));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6468));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6470));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6471));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6472));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6474));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6475));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6002));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(5980));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(5983));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6010));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6005));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(5999));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6008));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(5951));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(5990));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(5993));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(5997));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(5954));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(5943));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6016));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(6013));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(5948));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9826));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9735));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9740), new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9741) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9746));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9750));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9753));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9758), new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9759) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9762));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9766), new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9767) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9773));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9777), new DateTime(2025, 4, 7, 19, 1, 56, 499, DateTimeKind.Utc).AddTicks(9777) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7480));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7483));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7487));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7491));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7460));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7472));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7468));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 19, 1, 56, 494, DateTimeKind.Utc).AddTicks(7476));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6085));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6107));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6112));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6116));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6120));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6124));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6127));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6131));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6136));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6140));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6143));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6149));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6152));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6165));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6169));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6173));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6176));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6180));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6184));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6187));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6192));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6195));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6206));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6211));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6215));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6219));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6223));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6227));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6230));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6238));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6252));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6256));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("031a3929-ca36-4687-9263-a39832a74035"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6415), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("0366c77e-8e73-46fc-a461-5cd69ff9165a"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6418), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("053eddbb-aad6-4797-adae-9ff4eab3f8dd"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6396), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("1ac69dc2-49be-450a-9ce6-c161d4d8adbe"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6405), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("869578fb-60b6-477f-8519-bbc4307382ce"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6413), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("937ca06e-3fb6-43b4-87cc-bfc95adeeb2b"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6390), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("ace579ba-8290-4bbd-8716-3f47c3d190bc"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6407), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("be2101e9-2fa8-408b-9fa6-9cce566dbe82"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6411), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("c381cba2-2dba-4c4b-9dc0-cfaaa0c279c4"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6393), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("cfa58783-41c9-45fd-9036-ec1a1aaefe84"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6401), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("e0ba67ed-b234-4dfd-ac3c-0997316f96d1"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6403), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("f663a9ab-8f93-4908-bb77-12cb4470d53a"), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6398), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6338), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6339) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6323));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6326), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6330) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6346), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6347) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6321));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6342), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6343) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6333), new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6335) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 8, 2, 1, 56, 494, DateTimeKind.Local).AddTicks(6317));
        }
    }
}
