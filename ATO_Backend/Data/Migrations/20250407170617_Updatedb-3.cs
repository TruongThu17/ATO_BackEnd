using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class Updatedb3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") });

            migrationBuilder.DeleteData(
                table: "ActivityProduct",
                keyColumns: new[] { "ActivityId", "ProductId" },
                keyValues: new object[] { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") });

            migrationBuilder.DeleteData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("276cb0a3-4406-4943-8e7a-ee2b62e49e79"));

            migrationBuilder.DeleteData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("2df2222f-37be-4780-9ebd-d4fcf4107e28"));

            migrationBuilder.DeleteData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("7d92159e-bd23-42e8-ba5d-94f02e8abc7a"));

            migrationBuilder.DeleteData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("938425a8-1ef7-4b26-a01e-effe123015c7"));

            migrationBuilder.DeleteData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d470cefb-e618-420f-a399-31bbe277596e"));

            migrationBuilder.DeleteData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("d83b9062-ca46-48e2-8db9-a05d24436ff1"));

            migrationBuilder.DeleteData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f0cfb5d7-bfa4-4d0c-bf72-c8d37f62c0a1"));

            migrationBuilder.DeleteData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("f12a6bbe-5187-4713-b9bc-1b5e1d4ebeb8"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("139a52e4-89b1-4ffa-b68f-e898b445d2ac"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("2f8e7030-710d-4c12-b7e4-153a04eaf3ba"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("50669b85-6daf-4e32-b018-6e500aa7f49d"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("66b1cb84-d71d-47c6-969b-5aa5c0a46676"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("8ab30ef2-9a02-425b-92d5-6645022ce866"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("b7c5ac42-9ef3-4170-85fc-f24433a4233e"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("bde668a7-1634-4037-8d25-ea80ccdb7168"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("cae9a3e6-0773-4b30-87e4-983430b26658"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d038f481-60d1-4aed-b049-7aa31cbdb8cb"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("de92f025-db90-47cc-8398-509af452eecd"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("e2fbbd9c-9f6c-4560-b326-652e161866c6"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("f0ffa2be-f07c-4873-8807-089e7232b36c"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("47cadd26-4cb2-4e01-b41a-cabec9d96f66"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("598800a2-9208-400e-ac84-abfe6ff22a7b"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("68d50ee1-5016-48fb-8bc5-32087b9eeca9"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("84c2bffc-0f8c-4773-a044-86d4bf132460"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("b8db551c-a4d8-4c95-a73d-11964b50c6f0"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("dd178ca9-98da-4d3d-8a7c-c2d80ae0c2fb"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("e1a1df2e-0e92-4b9c-bed0-a815d40f7ac4"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("e60babad-5676-4b47-9b6b-2ca16faaa836"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("ed15f40e-767a-4255-8c5b-aa6052fa96f7"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("ee9f27fe-400d-4893-b692-530c38da9a44"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0ee2a34c-27b7-4525-85ad-aef149c1e21d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1e9a5e34-6606-443e-a77a-1d6e2811bd10"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("24cf0b85-0885-4a9c-987e-c05da8f1005c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2abfd18a-73d8-4cb4-aa73-b267d07a2a11"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("31ebce20-eb7b-4dd3-b40d-28176b7ef18b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3fb8cd9b-01d0-475b-b810-648953c1b652"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("486f2338-d2d5-42c1-a3bb-feaa946b4394"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("55e5ca0a-cea8-47d4-a6fd-c18b581bc2fd"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("63dde3a6-46bd-467b-984f-544496cff60f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7f9fe374-4f44-4773-92af-b3d7745d8315"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("856bec89-c867-4d2f-9e1e-c6672f8deaf1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("85e96aa1-e765-43e6-864c-253bd6c1a5e5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("86a4eae3-eb3f-4dcb-b660-a2299e59c1fb"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a14a12a1-1827-43b4-98ed-ff70367a1bda"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a47436f6-14cb-45af-93a8-00af4296260d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a93420f6-8cf6-4a3c-8924-cf3cb6ebbb33"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c85fb9a0-a01a-4098-9d92-b44d22e40b0c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d1b57c31-6f8d-4dc2-8d40-74ae96a58322"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d2ac5ea5-df41-4319-b586-eb50a0f63b2e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d4dd540b-d5f3-43b4-8bb4-91cb74a14600"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("d8c964a1-ec0a-475f-8ebe-04150fda0c83"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("dfdbf0c4-6d62-43c8-ab39-f264d6513346"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f83aa640-85eb-42ce-b97f-2f9396fa8acf"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("fd161858-668b-40bb-a826-2e75c7e7c5cf"));

            migrationBuilder.DeleteData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"));

            migrationBuilder.DeleteData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"));

            migrationBuilder.DeleteData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("0ab4ef73-7c48-4093-9ca8-93f45e9e8ec3"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("19b0b864-eab1-4f6d-b260-a901c4e994fd"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("3876aed7-77de-468b-b279-e3d796d137f7"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("403c514c-10af-4647-b0ea-9efb3d5807e5"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("4becc314-8df7-4f46-8702-e64c1ffc28da"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("8381b7fc-a1fc-4607-94f1-4d4855a70be6"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("8a1ba9aa-d318-4b1a-a33a-dea71450f35b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("a24ccbd1-c29d-4b9c-9e82-0776249585ae"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("a286627f-b7e4-4c4b-8b9d-e67ba98f76ec"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("b6db755a-584e-4118-a04c-7b4e898d0a2e"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("c092839e-1993-45ee-9630-fa525e9e9342"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f90ceb34-4761-48eb-9ac6-31fe67634350"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("06f562cf-b39e-428f-921e-8fc94826505e"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df9849b-ddd8-457c-babf-303356349173"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7874fc31-cdae-4cf7-9aee-b802ed19ed58"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"));

            migrationBuilder.AddColumn<string>(
                name: "Imgs",
                table: "Feedback",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "36065067-242a-48c7-a6c5-94b0e2579d78", "AQAAAAIAAYagAAAAEJsMaVIwDDeffrrkfQjyLf3F5gLmqzeaoggNqdW+aWO/ROpxW1YU+9hZCzrtIUzjLg==", "6942b7c7-32d3-450d-83ce-5039c8f8d3da" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "61bbb1a4-883d-461b-bd56-147984c739b3", "AQAAAAIAAYagAAAAEMeq7QoJ2LNCKDZMkgF/HOMNTSrl3BNtYzEyvVPJjz6swbZR789DkLTJMjvDcjNy2A==", "788f2b86-820a-401b-a616-5ad10bbb9c82" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d7a9472c-66f4-4360-a3f8-ede58b56b03b", "AQAAAAIAAYagAAAAEDLqfj8IevHeuPL7duluMQTY2fFrjNygKkqAECVKY8WjYK6cVITMPgIqYs/HR+jLWQ==", "67333e94-d833-45d2-bdd3-bb1675ccbba1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57ebf879-014a-4aa9-9ada-5a249330dd11", "AQAAAAIAAYagAAAAEMJU2AZV0YjHVQEdb+k0iH1CtHvsvIO8B/0k/oltvjFA85D3AcX0qI+mp2wnDUcuwA==", "d9a0c168-2859-49ca-8b85-f5954128be6c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6aa41a91-b496-4112-addc-801b7ab8733a", "AQAAAAIAAYagAAAAEIGNs/DwoMgg1hkU4TX9uOBf0Vk9Qb1mgP82HcIcQy8bMOtA+sNDp1aULRM02+96LQ==", "eed28392-57e0-45ee-8fec-bf0b98a22649" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c3f4c76-0eaa-4ea8-8776-da34ef32a336", "AQAAAAIAAYagAAAAEIzwy61u8VqjZj8unmsoH0Zom35k63i7oJIyQd7tVWiEQzfCoDSO55xgvZEoVz4qPw==", "7f2aec7e-5245-4ed4-8c12-2f5585d7f52d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33ca086c-1caf-4e2a-9989-0c676cc24534", "AQAAAAIAAYagAAAAEPQ9wzBLmY0N1f0BSua1j4mqQNjZAgOnrwlASb80zj6c2MPrOvGmV4SrQJaDw+t67A==", "4764a1c9-b95f-4b67-8171-7317132e4bbb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c54299c3-ec85-4ff0-9272-80ac7bf9028b", "AQAAAAIAAYagAAAAEFJjGv3yqhoJQAxnkXFKRyB+IPOoGA46H/JPUYM6B6auCyPmv3CNPkck9Q1NVkjXNA==", "3bf9f013-abdc-4faa-a29d-ad2943172094" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ae4e9e2f-8511-4c78-acd7-a10f67f43180", "AQAAAAIAAYagAAAAEEhQ0KlVXL53cIZ3cEg+N56HokoMwOoa8Bg8dyLNqpItGUwhPrVG2571+oVEmeIRjA==", "0569cc5b-73b2-4150-8f33-6f6d9b450f42" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "285279fb-49e9-4526-94e3-c4d60c4640a8", "AQAAAAIAAYagAAAAEPtdamDWWuTy5Xfr/pMuglk8kFFvnt7hIfnPAA7VXUgFjUuRpWY1UfhrFRn+Ag4QeQ==", "dc0eef1d-f311-49a3-8c2f-a66b3e4aba7b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2d3f056-3421-4dc3-9502-8c66870bd707", "AQAAAAIAAYagAAAAEJo1viNAs9Qj0CirWWzScay9DMfDzOXFl/SiucQGf2bTvlYAzRp1+xQmeKtmvkla7w==", "ceecf0e3-93d5-4ff8-a180-0c5526bae9df" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70454c0f-cb58-4fe3-95d4-11e423a75560", "AQAAAAIAAYagAAAAEHI0SYQ4HOz0SuG81pN3ak3LRypw97qeRMX8Cg2oGuXV2BGVkifeL7XT2YDkew6+Bg==", "eab607d6-8aa2-4159-9b41-206ded987056" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a94d42f2-a721-4116-a174-be639e839905", "AQAAAAIAAYagAAAAEG5Vq/9oqQDhwsmhB2D7Rm5dTxjMlDSUNdbRf8772lAHHE8zJNxBkl8pRgMhWamcEQ==", "4516b894-7556-4ed9-ba0f-d3b56cd2400b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "22a90970-d444-48ba-ba06-4682079a33ba", "AQAAAAIAAYagAAAAEGqJzycB2UWETDlcVHPyxgsGdo0tX20kUR7KmUWMmtsc3qdrJtyJnHazhhW1D/WewQ==", "31a62518-c939-476b-a979-bc603b0fc02d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a17e5bf-d9dc-4b80-bda6-33655bf3a021", "AQAAAAIAAYagAAAAEA7FEd2am3wojscRjSKk/4ef/x1Silnjj485mWqKYb0esuHqBQM603/dvTdHcRDO2w==", "92d66b22-3805-4642-81e8-b4c219a11bd0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "785c1c21-aeb6-4edf-a332-d0accc12a9c9", "AQAAAAIAAYagAAAAEGjkbwzFAoVyU5piXgB8SbrxdgV8BXh2CBwjRaJKt3TkJ4a35SY96kRbQDUwf+X8pw==", "81cc3241-1d07-4567-8914-e793767d3afc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3606368-4769-4e12-b0a8-706a023b816e", "AQAAAAIAAYagAAAAEGZQg69KZX6DIeUmADhKb6Czx8ZWz2vxv+NSiBzpGA0W6KN/qKAtJJl6Eyj0wEpEbQ==", "a592d18a-45ec-4aa7-aa3e-2a0f734e61a5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d5775fe9-8686-442f-9032-210dd9733112", "AQAAAAIAAYagAAAAEDH3/HamTtaXGf4jNdlHKy7cYnZG7PitmvTULYomZEdPY9vK8LTC5DM9dYrNKmRXMQ==", "15a2e0e6-02c7-4496-bdc3-cc979b48ea8c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "675c5174-3733-40bf-bfec-9a5233f4d21d", "AQAAAAIAAYagAAAAEGJSycOEBQ0VzB3bj+yBnJYYdyAtJdbHaxzkiH+eBq7gIcb9WhZA58uzxTYWeUmfFg==", "46d20cdf-1346-4689-a632-90d0ef18eddd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "54f35efe-c243-469f-b75d-2c89a295050a", "AQAAAAIAAYagAAAAEDwj0oewGBJ2Uw9r7XI6hleYe7j+l2ktFLpWcnkUrBuKKUco07WRo3cZJ+tLl1Vz+w==", "b99358e9-4ee4-4239-acda-827a91b64884" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6eecb817-8346-490a-8da6-b5de9163194a", "AQAAAAIAAYagAAAAEGukKMkG+v9TWFEYxtkdiQGwplaTditYh8z+gheUOEwoMhlWhXI0Nzd3SNxzWI6DtQ==", "0f72cdf8-2123-4c31-b8c6-e417fcb86a3e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f56e6ee-234d-4e8d-bac5-d15211b1f261", "AQAAAAIAAYagAAAAEOpFnvPDIJPqEmS1hqNVbhGUNhXJPY2u4+Wf4DznPRBHvjfBaI3u9Z4GRYKCCnqMjw==", "ae307fe5-e9b8-4c7c-acf4-fe37f3752b77" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0903ece3-3023-46e6-90b8-d766769840a4", "AQAAAAIAAYagAAAAEKd2Nzl3vB2L0gHID7FJ/+KvGIvlu/11SWdailo/XmpVgA5AlpNXII8Ap6NMWTuWXA==", "62a8c8c5-3506-4097-ba89-28b2903193a0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f3ef0e2-ca1e-4b1a-b9e9-ac3023d73788", "AQAAAAIAAYagAAAAEPARAvRZ3y6OA2j4RsfRTmxiVgsw50FpnMpyEkPPiyjITrHOKj50wfeQoMjj10ZTew==", "1f634f61-f3db-4e86-8fb9-31fc2ecee1a1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "deb81156-8e4d-4171-9262-2c79439c4d52", "AQAAAAIAAYagAAAAEDDfe/qzxo9wmeKyiNZOFRzHS6oAW3+icBdxDFo78HccrvubCg7Ohhr94qQeJ0xEPA==", "74a8550a-8476-403c-a01d-72fefe8e464a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15a22158-a50a-4797-982d-703955f370bd", "AQAAAAIAAYagAAAAECjbeNjc7TkHP4AearylS0O5BPY6rzmv/HXHMC810TieLBl/Z1q2zoBqQR5+EX3ALg==", "57cf6aba-4644-429e-bd61-d30358b0144e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2454d0f4-bc4d-4959-b976-c84df928e919", "AQAAAAIAAYagAAAAEKMLEU/+TF1SUijrJp4PiPH6HJwbgZ5boNlXH/hARekz/e0QS5uJmdkoWd+aHM5iEQ==", "b3a6c243-741a-44db-a11e-ce2565afd159" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "acfe3cbd-b0b1-4cbe-9f1a-7bb7a965499d", "AQAAAAIAAYagAAAAEHod15zAbtAu4KxTl1ahV3L37mf9D5BqDzQtkeGtc/JSq32oIo44WpdNZ+b/5K0+3A==", "f65c1d51-b22c-4143-9b75-0887f6587117" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5b74161-15f2-455f-9e51-48a214a72989", "AQAAAAIAAYagAAAAEKXG9HKin3IrrVQxIdwmanYIaqWy7rlNbHQ7wN/k2qgOcuYkpTqdldMGS/46Sf6/Fw==", "6d671862-d6d2-40e1-ab83-8af0aa9e2c4b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00ff0aa0-a4a6-4870-918f-38ba5729b26a", "AQAAAAIAAYagAAAAEO8twuEu9y71RW60tjcIXzJdEZsN8hSER3D9wedRebmKfrpBht8+QRUxStlKr+Ca4g==", "2c59c67f-bb7b-4a40-b36b-c3d94ff6c4e8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "23d912e5-7e19-4f9c-9936-9a514280ac3e", "AQAAAAIAAYagAAAAEJsCNx+JJ7QAfLJf5p3YwwgC64EEE3nVhFEKNIK5vQPBHxTbUNYNH3MNpZ7nr6L09w==", "4401df1b-f086-4a8e-b215-61051551b5ed" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b89bbd48-6633-4857-8b33-aeab16bdd5c1", "AQAAAAIAAYagAAAAEDHrSJOR50LSr0E1CXkjj+beMeUwevScdXgCKF8unM6FcX1ZA/BpLFu+1EE+4PeXFw==", "ba77c1f0-0be3-4dbd-a8d5-3da6d57f1de6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4c26d480-f70e-428e-8391-4934f7ac6130", "AQAAAAIAAYagAAAAEK9cjMjlJD3tIjjZEengX5eNyIS3GqpSO0eUhrpjZgzqzZiQwEPyJanxVaEsTTjjxQ==", "e6700978-a862-474d-a045-ddc02b33ffe9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "380d63c8-858c-4f00-b06e-5e36f5ec3e5e", "AQAAAAIAAYagAAAAEKINIB0/YttwQ4SnoDLkehUNZ4f8aMpROc9+ghWuBhkriuaAop0Jh23D9uH5MuY6DQ==", "86a8165c-f101-42f7-b164-7d8725b3eab7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03bfc90d-bd0a-4459-96ff-169eb88f3bf7", "AQAAAAIAAYagAAAAEJL0LUgJDQqypmlBGaQ842mljP5tpaXdZvZ4x0RPoWCAfh2rXW+TlB17eIjUFANedA==", "5daeddd5-a3d7-409e-8489-5b61aab42f22" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c4bc33c-4b42-4282-a833-b40d7fb7d434", "AQAAAAIAAYagAAAAENJPMOu8HWTtlZtdB9q6CugoOOCLZNAMXP2aIHhcFCAvkuayLScMT2oqiTkGEm0NAQ==", "fa07b933-0c44-4fde-9ad5-2dc03afe2754" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "01fbf3f6-faee-414f-a103-64e69353c8cc", "AQAAAAIAAYagAAAAEBJnyk2vaPBA2yzk9VQ2bIeqSJlBgaxTTtC2yCcfIiaKTclyHfj42NlMMpD2QFKIJA==", "c869bee5-f6aa-43af-81c2-99b801d5f474" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b6b268a3-86d5-46b2-b190-771a8c33b228", "AQAAAAIAAYagAAAAEN0B8cabQRovbWJecSU/DMVUKNvoTY2PU2pjk8Kpy8P+Dl8fYk2kKq++CGBbmLM8SQ==", "15901d74-2b8c-489f-9ca6-7ed8d69ebc1d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "79c41b3b-6491-4579-90cf-12d8785148d4", "AQAAAAIAAYagAAAAEJXTWa4i+Dd7ZASbjDbPKgC+ndW78iDYisX4va6jkg9DA/hj2YLprS7O7DAYa1iIvw==", "3258e86a-d7f2-4421-a7b9-df68929a9b5a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a94ab4f-47d8-4968-bde6-2d9a4c2f2dac", "AQAAAAIAAYagAAAAEHmcqnhgPNCL2jYDuUdLsV0Ho+a8/Q6l7+kye6g++WGmLC8MdoeSmzakYyU7ruvsDA==", "e09003ad-d3e9-4e20-82be-51a3044ba491" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3015a874-5c90-4ae2-b188-fb68b2d5c5a1", "AQAAAAIAAYagAAAAENsiNgyvV+fHgdhXa4pbxymYP63tw+wP/8plBZglT3XHhBr9hbj5hlQgILSgG0ZCpA==", "a710ad5c-a518-476c-a041-54118e5e5dc3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7727d482-e302-424e-b64d-8387a5bec51d", "AQAAAAIAAYagAAAAEDDBEF+SPJH7P0WwQxXcmQjDFYbSNEESnciHK1UneDFtcN07iX/mCUpPa0/cTQusLQ==", "8cb3fe08-2532-4e60-b88f-234f7a228a36" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92775b77-b5b7-4ad7-87e1-25bfa2a93d51", "AQAAAAIAAYagAAAAEEhMGyaQHsPYVm28Ck7ScJNyr+Plnyu3mklUzlAMReag4dDZhowv3P1NcIfJSyQBJA==", "447ff52e-3e12-4ec9-b7f1-c6952af09fe0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea69c93f-78c1-4eae-9650-03ebce76045c", "AQAAAAIAAYagAAAAEM3osx/k405pnblA0DKROzyW2dDd6UaafB/i5n2Syc62ff7rMDSY6RF9K0zTLVw3Yg==", "3dd91f5d-0242-428e-bd27-42101f874234" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a2fe5341-7e75-4c70-b42a-403c513c847c", "AQAAAAIAAYagAAAAEDJ67FXmj19mv79bbVFGPHR5SDlYnrAGJN8tbddFcAXiLVOjYYr6ploropXgDWuSUQ==", "24cabfb4-7375-45e4-b4b6-5351d02f4a70" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "73dc7c13-4464-4a11-aab7-2a5f06ef75b5", "AQAAAAIAAYagAAAAEEa0G3X/duJjqeOw5XFryqw4xD1H0lwtqKEa8C3hEZRVjg6DYxh4LYKj7Ld8t0ljcQ==", "ed91f4fc-9bb2-4878-90e7-6c4e6e744203" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8a7ac398-5125-4524-a0cd-4a9fecdb526d", "AQAAAAIAAYagAAAAEPr8H5VUQG5Ly4TzqVo7vnDFtuKEFQjgQB8s8h6eujJYIvjxgYQQ1o9NsHSbP/P6FA==", "de1606a4-2fe4-4c4a-80d5-6ea917555c64" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8c8bf84-ad28-413f-addd-d6b467b00a83", "AQAAAAIAAYagAAAAEOfMNQ2DYGT7gkCXDCTSsSv+cHlGVQjp+2vm8i5gjI0gScIaxMdn9f+5ih2owCXlVg==", "a13a2d6f-6880-4a73-af14-60c5c0523cfc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "742683be-6850-4e80-8c6b-4a61cf43680c", "AQAAAAIAAYagAAAAEKOr5eyGZlBbeiXkg9kWWgorL7ShKWK1AlPORzvbSqq4SIGFRVDwrakMBN0eBXTptA==", "7e4a9884-d75b-41fc-af6d-d4981f9e073b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "37563e93-fcf7-4f84-b61a-5a631fa51d5b", "AQAAAAIAAYagAAAAEF+cmYkizMFNC2I4dpLEgoH87wgQLenjzin4prEvsrQ8cRl+i7CZlBMaMQz2q8M4Aw==", "846588c7-524b-453e-893c-f2ae3b444260" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1740ce5d-fabf-4c71-9205-444a66fa88d0", "AQAAAAIAAYagAAAAEJTInf7R/PNS3FIYe8rOtqAtsaBllUin7uXMsgpjz1vMdEqDqGeK9nNxUEQ94LUibQ==", "582bd835-0b7b-45f0-99b3-f15c5a6306ee" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "19b9784d-594e-4dd5-b32a-d61dcaae7195", "AQAAAAIAAYagAAAAEP65JMDg/5ibLQ8HsozcUk4W8+XWWAX25+zhGXcyEH9k3qWOUC1rtrxZ1mqcQWwjQg==", "88da6e54-5162-4aef-aca0-4aeb81ebecf6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ac9cfed-2deb-422c-bf66-0a24c6f66fbe", "AQAAAAIAAYagAAAAEEmwg9HdTnHP8yGMPcSEB9HXdjjC/7xVLu38r0fo8YyTceLOJGBEmwVliOrsAz6NLg==", "27972249-dc46-40aa-93c3-fc89e40401d4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "037c4699-be08-4f12-a610-fe2e45e4cd76", "AQAAAAIAAYagAAAAEC21PvcfRFg8Fypu34wY21reMn5hbzAZXD/c0fPptsF1IXIgz42nSY4dnm9zTmg+0g==", "0883d969-ad7e-4e9a-a477-4e1bd22387d7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3250769f-db16-4bd7-9dc4-837b39c39eeb", "AQAAAAIAAYagAAAAELpHZ8SgVLCt5jSRo0vbixlyDC+hsT4UtNLTJJdcCYpIFL3G96SgT4Bs2ypDygWaIg==", "0eb5a4b1-ec2f-487d-9d27-ff84746bf374" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "faad2bc8-18c5-487d-8ebc-e6a9dca05673", "AQAAAAIAAYagAAAAEKMQy04A+X4ejJ+DYxZz3WBg8HvAbGbz27LzkYGqWpWGX282feCIjKbn3bjRbMvjqg==", "25e52ecc-565e-457b-8d89-cf4d43705d4a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ce65a7f-5d81-42fc-a890-11a70aa2a063", "AQAAAAIAAYagAAAAEFFURFMB9r9ggDhi0/l+JW5MOQJ+FobdaBidOTLH74h/h0DZfxSLOdidj963hIPmUg==", "003a23a4-5bbc-4202-8e34-def00aeddf4d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "06937ceb-0b69-47f1-8f59-412171d82a43", "AQAAAAIAAYagAAAAEAFo0E73M33zoQwWnGVPrrK3VHFZOq3A2pKsbbHaHGs7cVGCNDyiKjm7ifPx1O+jHw==", "80989185-bb40-4c8f-97c3-031b0bb655b5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1f79e67f-e413-4025-895a-003e52a1ecfe", "AQAAAAIAAYagAAAAEJDJ3Xdq31dcPC4fZer3WaT7WBsheg8Hmtp8+rMRrD7rDZbvqQ4hSeCzOMeMvInKHA==", "08cc76bb-1122-4c75-b143-c9ebbc70b1ce" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9df40a54-0624-4f72-a500-a37b92bd6fa5", "AQAAAAIAAYagAAAAEL+cjlyIZPlm30JdpHk/NxV101fIXpZ5ilkt4amjQ2XT0r3GFnuthJHH2A5267AOfQ==", "62ad7360-5e30-447a-88e9-8197165808bc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1550ce7c-23a2-48a7-952e-6a164eac45dc", "AQAAAAIAAYagAAAAEM0joOWRsH+wUvMvF96DMY0FrQCjldxHL0ONR3A4J4+1fOvOxQzQYs0qMk04RJ70rQ==", "3e9f84ef-4dd8-46b9-a9dd-b3871abb7bc5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "530766bd-c7f2-4a01-a33b-af4e12d0dc63", "AQAAAAIAAYagAAAAEJDwam6FuXz/E62ioak5HyazMNv1eKufs5bG2+Iaz3rvCnl7QzXw8FfvAYnbL0Ybrg==", "cebcf478-d01b-4e76-93c6-1dd5d3750b4e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "549e1432-f577-44ef-9181-89071d27d3e2", "AQAAAAIAAYagAAAAEDdxhAGD+4EW2Vq4wxMpMcrh7XlOt6H9VsDnxUNGKhsJeowSt/WvWr1rgcQ1unK4nA==", "1f9bea65-be2f-41f2-b9ac-0fa921abac20" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                columns: new[] { "ActivityName", "BreakTimeInMinutesType", "CreateDate", "Description", "DurationInHours", "DurationInHoursType", "Imgs", "Location", "PackageId" },
                values: new object[] { "Tham quan nông trại dâu tây", 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5358), "Du khách được hướng dẫn tham quan nông trại dâu, tìm hiểu quy trình trồng dâu và tự tay hái dâu chín.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F11.jpg?alt=media\\u0026token=892ef66c-cd8d-4228-b4ff-092b82961381\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F12.jpg?alt=media\\u0026token=374f97cb-ad21-4633-8381-8081019edabf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F13.jpg?alt=media\\u0026token=575e9e8b-b7e2-4b84-ac41-2b98313bff4f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F14.jpg?alt=media\\u0026token=19367ec0-3dd2-4349-abcf-fc17911ca4ec\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F15.jpg?alt=media\\u0026token=eebc5140-5778-4ab7-b128-7ec04c37f2b4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F16.jpg?alt=media\\u0026token=7d281318-7494-4c09-b7bb-8bf61c965fc0\"]", "Nông trại Dâu Mộc Châu – Bản Áng", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4") });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8029));

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("03e82315-1bb5-4158-bc4e-2f311e819a65"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("0fb5b97f-ba6b-46de-b5da-02f4028b37db"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("1d014b4c-a27c-497b-9cbe-08b01924c2d4"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("2663f269-05c8-4637-b4f9-7d570145e585"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("298af754-ffee-41d5-9ab4-2f64e880ec8a"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("4986a26a-1b0a-40a1-8bac-1f20ef08abb4"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("5d7ef2be-e30e-4593-bcdc-b67b642da556"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("73be2a17-48b2-46ed-a66b-5ac151b683ca"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("912c3a2d-eaeb-4e28-8059-f84cd208ad5b"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("bbaafb5a-320c-4dab-95de-c82b193640fd"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("d48b5925-e10b-4ab5-ba6e-21a0b28a0e79"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("f929ad74-a99d-4e45-85e2-e525cdca6b58"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("4b0566a2-638d-430a-8cdb-ad6baf615798"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5169), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5167), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5166), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("79984041-cbd8-4fae-85ea-e0773ce3ee8f"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5223), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5222), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5221), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("799eb97e-ecb9-477e-b034-6ff61a83e22d"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5216), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5215), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5214), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b3187ec9-eff7-48b1-a1fe-4ab85a73bdf2"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5178), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5178), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5177), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c0f912c6-a6e6-45c2-8faa-74f082c7be41"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5204), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5203), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5202), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c6621cb0-0ac8-4e0c-9dbe-114672135c3e"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5191), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5191), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5190), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c794e5b0-557c-4ad6-a199-bc71837063f4"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5228), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5227), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5226), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("df5f0f33-d7d4-46f9-845f-33b42f1a4070"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5235), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5233), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5232), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("e174c355-0888-4449-b74b-f3fd0538826b"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5185), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5184), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5184), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("e3d00064-8b24-46a0-ac3b-62534836fe3a"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5198), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5197), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(5196), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("01b8ec44-7825-4608-a030-15c3167207f0"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5049), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("0ce69ed6-ed5a-4043-b015-947dc32870ac"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4826), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("186cdddb-b40e-4cae-9ebf-9a40964436c7"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4937), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("1d20fdd6-cf41-41ee-ab27-11dd40474c7d"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4874), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("1e88ff36-fdee-487c-80aa-5c35915d3430"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5057), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("30d597c8-1136-414e-bf09-2103730033ea"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5042), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("370a8241-23ef-4a60-94df-a76ae926d97e"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4922), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("3ad01813-bd1b-463d-b7c4-a033b2f317df"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4944), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("46134b09-1254-4149-b466-285841129a4c"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4930), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("5c7a328f-ec28-47b7-8e5d-ec4da7f11b21"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5065), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("85bc3a3f-3d23-4e6f-9ad6-6286ba1199ae"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5079), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("99c91e80-a318-4b98-bfc4-d4da554ed916"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5008), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("9bbd6179-5e74-47e1-8c5f-89b54a0ddd67"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4881), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("a18f2042-7917-4e65-9319-2ef836b798d0"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4952), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("a7d55666-b903-4821-a691-ec64cb7add78"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5017), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("aa548f62-3a1e-4e36-a5c5-35506ed7bae3"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4834), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("c368e64c-9809-4743-a47d-cf3ecbc581af"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4842), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("c95df78e-490b-4404-aecf-551c5740245b"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5072), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("ca0c51a2-2f73-4677-a527-745797abca29"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4865), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("dd7983ed-7829-4efe-b726-9fbc6da97119"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4913), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("e26b6fa6-ce20-42bf-91ea-d88109293f3e"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5034), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("e4a7f297-8bd1-4a91-88f9-47b1e70ca373"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4905), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("ef4f55f2-08d4-4475-8275-aa45cf76b432"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4810), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("f9ad3645-e0b3-44cc-bfb5-d7f541008689"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5025), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(4475));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(4519));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(4525));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(4505));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(4482));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(4512));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(4456));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(4498));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4326));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4329));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4331));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4332));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4333));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4335));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4336));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4338));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4339));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4340));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4342));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4343));

            migrationBuilder.InsertData(
                table: "SystemConfigurations",
                columns: new[] { "ConfigId", "ConfigKey", "ConfigType", "ConfigValue", "CreateDate", "UpdateTime" },
                values: new object[,]
                {
                    { 13, "BookingUrl", 1, "https://localhost:5001/api/tourist/book-tour/return_book", new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4344), null },
                    { 14, "OrderUrl", 1, "https://localhost:5001/api/tourist/order/return_order", new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(4346), null }
                });

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2519));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2497));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2502));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2527));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2522));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2524));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2490));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2509));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2512));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2494));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2480));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2542));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2540));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(2487));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8167));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8083));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8089), new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8090) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8095));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8098));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8101));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8105), new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8105) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8108));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8112), new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8113) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8117));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8121), new DateTime(2025, 4, 7, 17, 6, 16, 267, DateTimeKind.Utc).AddTicks(8122) });

            migrationBuilder.InsertData(
                table: "TourismPackage",
                columns: new[] { "PackageId", "CreateDate", "Description", "Durations", "DurationsType", "PackageName", "Price", "ReplyRequest", "StatusApproval", "StatusOperating", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5290), "Trải nghiệm làm nông dân tại nông trại: hái dâu, vắt sữa bò, tham quan vườn rau hữu cơ, dùng bữa trưa đặc sản.", 6.0, 2, "Khám phá nông nghiệp Mộc Châu", 3500000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5299), "Trải nghiệm canh tác nông nghiệp sạch: chăm vườn rau, thu hoạch cà chua, nấm và tìm hiểu quy trình đóng gói sản phẩm OCOP.", 1.0, 3, "Một ngày làm nông dân OCOP", 3200000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5295), "Tham quan đồi chè xanh mướt, trải nghiệm hái chè, quy trình chế biến chè thủ công và thưởng thức trà OCOP Mộc Châu.", 4.0, 2, "Tour hái chè và thưởng trà OCOP", 2800000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5305), "Kết hợp hoạt động từ thiện tại bản làng với trải nghiệm trồng cây xanh, chăm sóc vườn hoa và chế biến thực phẩm từ nông sản địa phương.", 2.0, 3, "Du lịch thiện nguyện & nông nghiệp xanh", 4000000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2626));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2647));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2651));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2655));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2659));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2664));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2668));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2672));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2675));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2681));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2686));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2691));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2696));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2708));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2712));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2715));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2719));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2722));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2726));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2735));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2740));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2744));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2752));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2755));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2759));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2810));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2816));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2820));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2823));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2831));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2852));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2856));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0798449c-04c3-412b-90c4-1436469220a0"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3028), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("16bf2d04-3e1a-4b21-a4fd-99df71cf3023"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3032), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("28345700-7496-4969-94c9-dc9eae899028"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3034), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("3610b020-6726-44ef-b842-55053a438d9a"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3017), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("3c56fca0-5b52-4338-bac7-31767293a1c3"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3030), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("6064827e-32fe-4d1b-a4a1-edf543ed5050"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3012), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("87779a8b-c1f4-4c59-b654-921b6339f7cc"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3036), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("929d3bd7-7174-4cbe-8bde-28484f5421bf"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3026), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("9b8ab68b-b8c4-4bdd-8952-9d74e874a00b"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3024), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("b4701a2f-e66e-491e-8ac7-973ecff5430c"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3008), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("b87f079e-095b-44d3-b26c-a0def4fe0eee"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3019), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("ecd3fd95-c0b2-4853-8b89-8bcfd5cd95b1"), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(3014), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2954), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2955) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2939));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2941), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2946) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2962), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2963) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2936));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2958), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2959) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2950), new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2951) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 8, 0, 6, 16, 264, DateTimeKind.Local).AddTicks(2932));

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "ActivityId", "ActivityName", "BreakTimeInMinutes", "BreakTimeInMinutesType", "CreateDate", "Description", "DurationInHours", "DurationInHoursType", "Imgs", "Location", "PackageId", "ReplyRequest", "StatusApproval", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"), "Chăm sóc vườn hoa và cây cảnh", 15.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5645), "Du khách sẽ tham gia chăm sóc vườn hoa, cắt tỉa và trang trí cây cảnh, tạo không gian xanh cho khu vực du lịch.", 2.0, 2, "[\"https://example.com/imgs/vuonhoa1.jpg\"]", "Vườn hoa du lịch – Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"), "Tham quan đồi chè Mộc Châu", 10.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5386), "Hướng dẫn viên dẫn du khách khám phá vẻ đẹp đồi chè xanh mướt, giới thiệu về lịch sử và đặc sản chè của vùng đất Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F51.jpg?alt=media\\u0026token=47097c1c-c500-44d3-8737-78a0f2a8b1f2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F52.jpg?alt=media\\u0026token=1e207dfe-0474-4f0f-ad34-37bcb330c20e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F53.jpg?alt=media\\u0026token=546add09-5243-44b3-a1ff-0b7f8c799539\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F54.jpg?alt=media\\u0026token=7b90f572-93c1-4378-80da-7fe1421f7a06\"]", "Đồi chè trái tim – Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"), "Hoạt động từ thiện tại bản làng", 30.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5638), "Du khách tham gia các hoạt động thiện nguyện tại bản làng, giúp đỡ bà con địa phương với các công việc như sửa chữa nhà cửa, tặng quà cho trẻ em, hoặc tổ chức các hoạt động vui chơi.", 4.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F131.jpg?alt=media\\u0026token=8d1ad1ca-524b-4c04-b987-ff7a72d12fc2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F132.jpg?alt=media\\u0026token=3ba71565-f467-437e-9b65-d71ccb1da6a8\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F133.jpg?alt=media\\u0026token=c02001f3-d8cb-4c16-a3f8-15d822dadf84\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F134.jpg?alt=media\\u0026token=2cf26d42-a673-4dde-a41c-6f1076363516\"]", "Bản làng vùng cao Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"), "Chế biến thực phẩm từ nông sản địa phương", 20.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5649), "Du khách sẽ học cách chế biến các món ăn đặc sản từ nông sản địa phương như rau, quả, thịt tươi và các sản phẩm OCOP.", 3.0, 2, "[\"https://example.com/imgs/chebien1.jpg\"]", "Xưởng chế biến thực phẩm – Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"), "Chăm sóc vườn rau hữu cơ", 15.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5615), "Du khách sẽ được hướng dẫn cách chăm sóc các loại rau sạch như cải, xà lách, rau mùi... trong vườn hữu cơ của trang trại.", 2.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F94.jpg?alt=media\\u0026token=68b2ad20-405c-4353-8dae-e0b6a9a585ea\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F95.jpg?alt=media\\u0026token=bca7674f-dd8a-45ab-85e9-e0a9b9370734\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F93.jpg?alt=media\\u0026token=1190cb37-0960-4738-b183-3659addb4593\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F92.jpg?alt=media\\u0026token=6c678903-0762-44bb-9e34-69c9fbecc053\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F91.jpg?alt=media\\u0026token=aa93f1f6-7464-4016-b32a-dc298f3719a9\"]", "Vườn rau hữu cơ – Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"), "Tham gia chế biến chè thủ công", 5.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5397), "Học cách sao chè, vò chè và sấy khô theo phương pháp truyền thống cùng nghệ nhân địa phương.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F71.jpg?alt=media\\u0026token=8c694cc7-240c-4eac-a670-a458de5a8964\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F72.jpg?alt=media\\u0026token=9d082c03-94b1-4bc2-941d-3d80077481cf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F73.jpg?alt=media\\u0026token=955ef861-00bc-479f-ae3f-083a78f72624\"]", "Xưởng chè OCOP Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"), "Trồng cây xanh tại khu vực du lịch", 20.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5642), "Du khách sẽ tham gia vào các hoạt động trồng cây xanh, giúp bảo vệ môi trường và tạo cảnh quan xanh cho khu vực du lịch.", 3.0, 2, "[\"https://example.com/imgs/trongcay1.jpg\"]", "Khu du lịch Mộc Châu", new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"), null, 0, null },
                    { new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"), "Vắt sữa bò tại trang trại", 10.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5366), "Trải nghiệm vắt sữa bò, cho bò ăn và tìm hiểu quy trình sản xuất sữa tươi đặc sản Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F21.jpg?alt=media\\u0026token=5a725c29-f7ed-4f52-89e0-94e0f768b8e3\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F22.jpg?alt=media\\u0026token=244dc720-f725-42ed-bbf1-a28f3a59178d\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F23.jpg?alt=media\\u0026token=1a44b12f-8bc0-48d6-b1bb-15a2cb7d3b61\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F24.jpg?alt=media\\u0026token=ccea313e-1a38-438c-b47f-2603da9a003f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F25.jpg?alt=media\\u0026token=7667d7c8-ec34-444a-bfd6-254fa545febb\"]", "Trang trại bò sữa Dairy Farm", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"), "Tham quan và thu hoạch rau hữu cơ", 5.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5372), "Hướng dẫn chăm sóc, thu hoạch rau sạch, tìm hiểu kỹ thuật canh tác hữu cơ chuẩn OCOP.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F31.jpg?alt=media\\u0026token=c76c7f97-077d-4e11-b851-4d14a5348e39\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F32.jpg?alt=media\\u0026token=1d3da6b4-2733-4281-bee0-e9a005d9e3bd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F33.jpg?alt=media\\u0026token=510e194a-cf09-476d-891e-d30976dbcf74\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F34.jpg?alt=media\\u0026token=cd2d6297-a97d-4119-b924-66f84e686091\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F35.jpg?alt=media\\u0026token=5dab756d-23a9-4df1-97a2-ff3b2afedad5\"]", "Trang trại rau hữu cơ Mộc Châu Xanh", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null },
                    { new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"), "Trải nghiệm hái chè", 10.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5392), "Du khách mặc trang phục truyền thống, tự tay hái những lá chè non, tìm hiểu về cách chọn lựa lá chè ngon.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F61.jpg?alt=media\\u0026token=63b5b728-ea1f-4511-a780-d3c095a200bf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F62.jpg?alt=media\\u0026token=c7184c0e-1262-4c7c-8124-d830c6077824\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F63.jpg?alt=media\\u0026token=70feba58-f759-40fa-a09a-afc6013a2a4c\"]", "Đồi chè Thanh Bình – Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"), "Thưởng thức trà OCOP", 0.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5607), "Tham gia buổi thưởng trà, trải nghiệm các loại trà đạt chuẩn OCOP cùng bánh ngọt địa phương.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F81.jpg?alt=media\\u0026token=6afd1b86-7467-4378-872e-35653af5b8b1\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F82.jpg?alt=media\\u0026token=70835076-bb28-4f0a-840d-8a417e6aed17\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F83.jpg?alt=media\\u0026token=68a06a61-f77e-44a6-80e7-5da69e44d21a\"]", "Không gian trà đạo Mộc Châu", new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"), null, 0, null },
                    { new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"), "Tìm hiểu quy trình đóng gói sản phẩm OCOP", 5.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5632), "Hướng dẫn du khách quy trình đóng gói sản phẩm OCOP, từ khâu vệ sinh, đóng gói đến dán nhãn và vận chuyển sản phẩm.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F121.jpg?alt=media\\u0026token=9018f821-dd46-4bc6-aa56-0389aea2bf61\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F122.jpg?alt=media\\u0026token=ad974591-aff7-48af-80e6-a6e7e975941c\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F123.jpg?alt=media\\u0026token=7e9514a5-c205-468d-913e-49da8aa8b473\"]", "Xưởng sản xuất nông sản OCOP Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"), "Thu hoạch và chế biến nấm", 10.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5627), "Du khách sẽ được tham gia thu hoạch nấm và tìm hiểu quy trình chế biến nấm thành các sản phẩm tươi ngon.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F111.jpg?alt=media\\u0026token=720b5141-852a-42f7-9501-cd21845aea83\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F112.jpg?alt=media\\u0026token=071f3771-b293-4679-a2b8-9705b064e2ee\"]", "Trang trại nấm – Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"), "Thu hoạch cà chua", 10.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5622), "Du khách tham gia thu hoạch cà chua từ vườn, học cách lựa chọn quả chín và chuẩn bị sản phẩm cho việc đóng gói.", 1.5, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F102.jpg?alt=media\\u0026token=05c8e1fe-9719-4a40-ac8b-29240968deca\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F105.jpg?alt=media\\u0026token=6a6f785c-b2ff-4d18-a281-6b4fbdb24858\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F101.jpg?alt=media\\u0026token=543a6d27-d8c1-405e-8cc5-d514df96a517\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F103.jpg?alt=media\\u0026token=61052fcb-66f1-4b78-801c-7753c921eedd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F104.jpg?alt=media\\u0026token=d6fa2240-475b-4342-b38f-4ab3ff860c6c\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F106.jpg?alt=media\\u0026token=04b992aa-add3-494d-afb6-163f295101dd\"]", "Vườn cà chua – Mộc Châu", new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"), null, 0, null },
                    { new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"), "Dùng bữa trưa đặc sản Mộc Châu", 0.0, 1, new DateTime(2025, 4, 7, 17, 6, 16, 264, DateTimeKind.Utc).AddTicks(5381), "Thưởng thức các món ăn chế biến từ nguyên liệu sạch địa phương như bê chao, cá suối, rau rừng, sữa chua Mộc Châu.", 1.0, 2, "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F41.jpg?alt=media\\u0026token=e217a4d7-e7f4-4b2a-98dd-0a7dd4dc2984\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F42.jpg?alt=media\\u0026token=149048cb-720f-478f-bcd1-422756adf1ac\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F43.jpg?alt=media\\u0026token=828ef767-521b-43a8-92c3-6611901f65e2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F44.jpg?alt=media\\u0026token=f69dd952-5c11-4080-ba90-2dbc7be04fe0\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F45.jpg?alt=media\\u0026token=815c61a0-c821-4208-ad95-0915e193fd9f\"]", "Nhà hàng Truyền thống Bản Áng", new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"), null, 0, null }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"));

            migrationBuilder.DeleteData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("03e82315-1bb5-4158-bc4e-2f311e819a65"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("0fb5b97f-ba6b-46de-b5da-02f4028b37db"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("1d014b4c-a27c-497b-9cbe-08b01924c2d4"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("2663f269-05c8-4637-b4f9-7d570145e585"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("298af754-ffee-41d5-9ab4-2f64e880ec8a"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("4986a26a-1b0a-40a1-8bac-1f20ef08abb4"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("5d7ef2be-e30e-4593-bcdc-b67b642da556"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("73be2a17-48b2-46ed-a66b-5ac151b683ca"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("912c3a2d-eaeb-4e28-8059-f84cd208ad5b"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("bbaafb5a-320c-4dab-95de-c82b193640fd"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d48b5925-e10b-4ab5-ba6e-21a0b28a0e79"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("f929ad74-a99d-4e45-85e2-e525cdca6b58"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("4b0566a2-638d-430a-8cdb-ad6baf615798"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("79984041-cbd8-4fae-85ea-e0773ce3ee8f"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("799eb97e-ecb9-477e-b034-6ff61a83e22d"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("b3187ec9-eff7-48b1-a1fe-4ab85a73bdf2"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("c0f912c6-a6e6-45c2-8faa-74f082c7be41"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("c6621cb0-0ac8-4e0c-9dbe-114672135c3e"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("c794e5b0-557c-4ad6-a199-bc71837063f4"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("df5f0f33-d7d4-46f9-845f-33b42f1a4070"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("e174c355-0888-4449-b74b-f3fd0538826b"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("e3d00064-8b24-46a0-ac3b-62534836fe3a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("01b8ec44-7825-4608-a030-15c3167207f0"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0ce69ed6-ed5a-4043-b015-947dc32870ac"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("186cdddb-b40e-4cae-9ebf-9a40964436c7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1d20fdd6-cf41-41ee-ab27-11dd40474c7d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1e88ff36-fdee-487c-80aa-5c35915d3430"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("30d597c8-1136-414e-bf09-2103730033ea"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("370a8241-23ef-4a60-94df-a76ae926d97e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("3ad01813-bd1b-463d-b7c4-a033b2f317df"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("46134b09-1254-4149-b466-285841129a4c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5c7a328f-ec28-47b7-8e5d-ec4da7f11b21"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("85bc3a3f-3d23-4e6f-9ad6-6286ba1199ae"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("99c91e80-a318-4b98-bfc4-d4da554ed916"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9bbd6179-5e74-47e1-8c5f-89b54a0ddd67"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a18f2042-7917-4e65-9319-2ef836b798d0"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a7d55666-b903-4821-a691-ec64cb7add78"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("aa548f62-3a1e-4e36-a5c5-35506ed7bae3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c368e64c-9809-4743-a47d-cf3ecbc581af"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c95df78e-490b-4404-aecf-551c5740245b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ca0c51a2-2f73-4677-a527-745797abca29"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("dd7983ed-7829-4efe-b726-9fbc6da97119"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e26b6fa6-ce20-42bf-91ea-d88109293f3e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("e4a7f297-8bd1-4a91-88f9-47b1e70ca373"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ef4f55f2-08d4-4475-8275-aa45cf76b432"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f9ad3645-e0b3-44cc-bfb5-d7f541008689"));

            migrationBuilder.DeleteData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("0798449c-04c3-412b-90c4-1436469220a0"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("16bf2d04-3e1a-4b21-a4fd-99df71cf3023"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("28345700-7496-4969-94c9-dc9eae899028"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("3610b020-6726-44ef-b842-55053a438d9a"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("3c56fca0-5b52-4338-bac7-31767293a1c3"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("6064827e-32fe-4d1b-a4a1-edf543ed5050"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("87779a8b-c1f4-4c59-b654-921b6339f7cc"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("929d3bd7-7174-4cbe-8bde-28484f5421bf"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("9b8ab68b-b8c4-4bdd-8952-9d74e874a00b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("b4701a2f-e66e-491e-8ac7-973ecff5430c"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("b87f079e-095b-44d3-b26c-a0def4fe0eee"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("ecd3fd95-c0b2-4853-8b89-8bcfd5cd95b1"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"));

            migrationBuilder.DeleteData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"));

            migrationBuilder.DropColumn(
                name: "Imgs",
                table: "Feedback");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "31bbd372-f0a7-4e0b-bad0-aa03801c46a8", "AQAAAAIAAYagAAAAEKRc9obzM3uG1TPwIqSCD2qBpep6ifsZO3jl0dVFlXvcfQA2fVEr5+FVFO6tIpGs4Q==", "12fb8579-50b7-4264-8e7b-7a52aba5c760" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ef8bff4b-5f46-4f39-a730-cd48fda72d82", "AQAAAAIAAYagAAAAEDITjkhPdRr+g3GvzulvOMzvzRqYYWdsM77yHfCrpQEAfiZpdKEk0I220DY2siAKtA==", "6c7e5375-d6c1-4892-97d0-90e878473f85" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "87c76c6a-2fe6-49fe-96bc-62b386dc968d", "AQAAAAIAAYagAAAAEBgIFy81PgQMNPEfSnKmBbxjEwfwciOZR4X0by9hFeBn3rtf+ZJ9sw3oPfWmr1tlmw==", "1977c697-fee0-416c-a314-f73aee23781a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5900200e-d44e-487a-a721-ac99b9284d7e", "AQAAAAIAAYagAAAAEPQlnYMoobZpXpCMDDQNHEzQg9OnOz8PhvGywK2Qm62ANUb1vBhB6bsdX7rblQUWlA==", "cdf74bee-a58a-4c4d-89f0-2137d416755f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a88d99db-56ba-4f90-aaa9-b079f0ec152c", "AQAAAAIAAYagAAAAENHgziQj9WShD9ellm01KfzUvu+Xs0JFnlFrombyqkM0lPYFP8ksDYnzkh51ZcubDQ==", "0dbe4c86-20cf-45a6-8110-9e342c55a93f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99869f91-b330-4d4c-9807-34bba54037df", "AQAAAAIAAYagAAAAEBvYV+u9IA/etZtTv+5V99JuS6WWdT6kYW2xs+lTmlU5Xx5Zfx5i1C8RlNHr3nPzyA==", "f62d5d3b-de22-423d-ab23-aae109b619df" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f08ed8a4-f55d-4495-ac58-e801e459cd0a", "AQAAAAIAAYagAAAAEBIpcOHrdlXcuEVn7aK8ptyjnszX9ZLNACXmhPAXDfDGjPIZ4plPCqH8CPElUNld3w==", "29cf00e6-d7eb-46a5-800f-e187fb7537aa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74b04f98-7be5-40dd-bc97-615fe322eba3", "AQAAAAIAAYagAAAAEBtfMTMehO0SYYn5+tZDDaq0SxRp4nvMQee27bmqWoOxgRFC+YSezD7HR+k+F716KA==", "8c5e800d-6689-4706-b5ac-76a0381bbf3f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e81354d7-110b-4588-b2d0-0ecf4ad76ae2", "AQAAAAIAAYagAAAAEJNBcfTgtcgT/D0hCtUmBh+6CtqttKwFv/RKnPrRpx1/ryPGXKi493Vh4RQPd51KIg==", "3b01f144-b2bb-4086-bedd-a3a0e2e55a8b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "788b396c-6e81-4b8f-91f9-187750cf318a", "AQAAAAIAAYagAAAAEC1DATFY7T35Uf+s82DX8oWt3ZW4kM1c0HyNzS6TjSzkjhr83MwEgFEZtb9KVQHbcw==", "29566ec1-bffb-4f90-b472-53a1879b89b5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3e6f8ee7-7106-4d1c-8576-dce29af2ef97", "AQAAAAIAAYagAAAAEARpiA1DnXDGzSOSNq3BMQBxPStRHUsD/S7cBNSVPAiNB+F0VjwutErehZSSuigy4Q==", "61d45436-5ece-43e7-a5d7-7e864c88078e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8fd61f14-3bf6-44e5-b01f-fb1c7d0da7aa", "AQAAAAIAAYagAAAAEBSaInA0wrTukJ4CDb3UmiTnk40m2Ch82EhF7jbHv3nao2piqApVM0ESI4iqZoYiKw==", "5be13ca2-1d5e-4e66-a75b-b3fff873bdb2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "982c7d16-fc53-4dd6-b79c-7c188b34c874", "AQAAAAIAAYagAAAAENhewt/PT1SBkhuGQPTuGWcB7oLhgS7pgbcIpCYe8bvDEl5LExKa6Tqm72gLg5KCVw==", "d425ac51-ab5e-4d90-aac5-248ce00827bc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "550f3258-5022-4e11-a123-64663a84d55d", "AQAAAAIAAYagAAAAEMytPHD7F4TS130Y420NwWTWg3df9eYwhJGzIwhREFAm/93Bgp8YvsFBM+VtUxzakg==", "285bd718-0e00-43b0-aeca-6d0d535eb7d1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "710471b7-eac1-4958-9dda-93db9ffed8f3", "AQAAAAIAAYagAAAAEIm/TVKTBqCtsK8wTuiROm5NV56sm3+NMtgpM/QYUXMo1RQv3k6DpfwItD5XZRmcvw==", "d3fd90b0-64c4-401a-b6df-c1ab5208a9f9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ba6cdcc-b4c0-4190-b529-0bd76f9a5f40", "AQAAAAIAAYagAAAAELBmbZ0bIvsBCjXAvhOEZ0Zgk41WkJzGb8Fx1vIjGVD4F3rIDBgpX1Ajt3hz7xIXrQ==", "324ba56a-b795-4b82-b4aa-ad8de7c29abd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6dbd711e-1b93-4d00-b1f3-ac077b3bf394", "AQAAAAIAAYagAAAAEPszYXPosI5NkSYY8f/mLhP1pHioO3jnQdXDv6HEO3tU242n5OwSNmsVRBolP5AMHA==", "7b281094-f5cb-4740-becc-c42791916df6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec053d78-1855-4078-9592-d55f0f6ff865", "AQAAAAIAAYagAAAAEOT3BjdEhzshiwbRODRdqdP8qamA+wmO83BayRbwQR+Bdd718RWRicUv9j+PgKbZkA==", "0dc63fa7-ab8f-42db-88d5-70ee15cae838" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f481e47-07a3-484f-ad72-5f6140eb178b", "AQAAAAIAAYagAAAAELu9tj4B1PTjcmLO08ExfQrJoHZuhx04X9iVjQpClGtwo6k/HVIGmlWVWFsO1NYCbw==", "0e7caace-16e8-456a-9308-0a677364ed6d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "abc31bd5-2ae0-42f4-a3a8-cae20e1ba321", "AQAAAAIAAYagAAAAEG2Ui4hkqv8ZeczQ36PgqDwj/h9c+X4tGj4wFSj2wxnF06WP7Jo5ccQwW6J14EvSMQ==", "b1a987f4-b20d-411e-a060-da42fc1b08b1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e9126da9-2f16-4821-bf25-089d40e61e6c", "AQAAAAIAAYagAAAAEFltFc3V2Ev5DEz1Wa7j8M3AM9BEapm+wfgn/ffTlezU2HP2vI8XGCnnELofcX8kug==", "6393a09f-e7f7-43fd-81b7-b1d7bb122869" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ea12515e-625b-4daf-9280-3e59472d53c3", "AQAAAAIAAYagAAAAEC/8KCxdrQFPVDyY1q2mVelcfSsgQjOoWP9tXTKh6NSyjOCrKFQrURM5ai1BLRIgJg==", "37f2e0db-fe94-412e-a696-90a80d5b7df9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7af14ad4-d8ec-491c-a068-6df3f0f22f4d", "AQAAAAIAAYagAAAAEFVbcqeLozMEP1SuZHNq16f5lW+GjFwMBWW7HJc43Rmyediwa2+s/mVRwB8EKoD/qA==", "cc57b826-e4f0-4625-a1c8-c92fa97a1165" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "17889044-857d-4b8c-b8cb-174ad14e37a7", "AQAAAAIAAYagAAAAEObhksvaX2F/pQEYjAhuV5q9fnHpIA/f+aZc/9LczK4H9A3CfgRBrdqo3LSlUvXe5g==", "1e55e66d-eaa3-46dd-a990-00c50cc3156e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "57340601-ab37-4741-baa7-70f18604bdd9", "AQAAAAIAAYagAAAAEP6DZ5se1oOgl7e8KNES2YAGz/p3reMKL+tlxivZhb/izRSfReW8dj0lAVMVBYjGOA==", "e1eb8221-fb75-4b82-9a28-043e5fdc8049" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8ecaf1ef-16c0-486f-89e7-6de06b6b92cb", "AQAAAAIAAYagAAAAELtrZ9iYYDbe+hzpW6iohV/4CQCjfmBVFMPYK4TRuhGSwr3bktzKltHFBpIuiGBdlQ==", "4520a01f-ca63-4f99-85e5-3c7cc6750ffb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "dfa449d2-eb6e-4979-95ac-821dd21222d9", "AQAAAAIAAYagAAAAEA7A7l1atVLN1V+A5nE9rAyvvZjf1sT79P2+cNcxWvnqZRkIu/tfKUdgnALByFsCVg==", "2f8ef8fc-c39f-4c94-968f-e475618d056f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "43e036e6-444f-4783-badd-7b23e00d182b", "AQAAAAIAAYagAAAAEKnYKvBdq4StPjN9E+A9AF96nRfHGMRtJWCP2JAHGPWwla8okWwupTQfnAsoBgvATg==", "1d412242-0298-4f37-8b26-14d26d0e87fb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7cd93560-27fa-4beb-84bd-4b9da7a31a81", "AQAAAAIAAYagAAAAEMVMp7I0xl+APjUUa2baVIUpZkUZ05MGEQvMCsNCQDEvIaobKkwIIE2ceOqIasq8ZA==", "d863c865-2f98-40da-97cf-a9d8d9e46f74" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c13d3669-ee76-46e8-bcd1-3c7d1b5979e6", "AQAAAAIAAYagAAAAEKJ6oXASoeIyTMs4C/k5NYI18ticolM1RrI6+11kdYggKt0FjtJUBeGvSePJ2BpVJg==", "3fb266c0-a537-4870-bb79-fcf4c0c903cc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "21874775-fc2d-4fca-aa95-0289f3800596", "AQAAAAIAAYagAAAAEAmaH0ODj5z1v0y/H9AkOtkGt4gkhyW/iGc7jAZrb3k2W4ac4ejnb3UadQPhshx3cQ==", "63b74b12-955a-4d78-a32a-d97e9f5efe36" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5d70285-1b95-4130-be4f-66827c02a484", "AQAAAAIAAYagAAAAEAa4FMFvmUvZH0VMwqV3AcHk4EXH2TgKlITVFGdfwhzwkumOL6avx2aBmlfROZOHSQ==", "3bc620ec-a196-4bae-b2b8-9e54e4fbc3d2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d4a19c9-1362-4321-b6aa-b5555e7113ad", "AQAAAAIAAYagAAAAEC5bxfVLmfwx8cM4zAKKqLRUOtD7gYPTEtcj/hCWgtK1D8paGWfqsKFa1zVGIQ2YWQ==", "f3c8f8a1-3b58-4c16-9a9e-6c0e9bd6f3b7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e07e777c-d963-4a7a-9482-86f8983fd72c", "AQAAAAIAAYagAAAAEBrMQHQQgWH916rMR0jKod1GinpKWctsX5G38/DeCCYBKQDdC7kosrsXJ3hw5YI2+Q==", "66eb62cd-5295-4455-a989-06986add7b4e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c7b9902-a53e-4a63-90f9-b2b9712e7d73", "AQAAAAIAAYagAAAAEMlB4e7LSJYDNqc52KbIDbyfZPrP/LtvLKFNGMqFVvJeC1rMzNATDRUQ2AfSJi0SZQ==", "bc5c140c-7930-45bd-83ac-377e511b3cc2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0ba3f571-97c6-4eac-85a2-1d1a62df7862", "AQAAAAIAAYagAAAAEDHjos7X9qXSg6ghR1fKC7wmn7JKv75xKIa4mXr+/1G9gOoTBHlfc0SpwOq3au5hXw==", "f2496812-133d-4d5d-95cd-eeab4a115b8c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b20c8ff5-7491-4281-a982-a6e1e26aebf4", "AQAAAAIAAYagAAAAEOsdQ/LqCHtSexZMLusNlqXERZ2v/7AC1SbpmvIu5W92QxFU/zxxw7tqrYzFwcgouw==", "369b93ce-2629-4e8b-bace-2fb941126ccc" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cb09b5ef-9d8a-49c9-9574-86d2ae3f59ab", "AQAAAAIAAYagAAAAEHPwlacoJf3DolICv2csh39GBtWf0vtxxiYOyR3+OUqzRqCJCoJJe41jB762n+GUdA==", "bb0735ec-47d6-42cc-bef0-fd27f3a9f7d1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed51a028-5133-4234-9a14-10baf76af09a", "AQAAAAIAAYagAAAAEGdYej9IoL8sc9bWRU3LmGaU28j4TZra8idmzw/8mZkIF6PJC9UuQOm/ym5Eaqv58A==", "fc58d9e0-4907-43a0-8362-261cb341559f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67e00a08-b1b9-4b19-aa67-8a4e675521dc", "AQAAAAIAAYagAAAAENjGg9gCQD6n2cp7MHfknAvIxBX1HTYPkODin48yUfgcLCg1qa6hsWL746G2fdZSOw==", "639fad36-21a7-427e-85b8-32365fd58795" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c33c8520-3d81-44df-b6e2-106806609c9c", "AQAAAAIAAYagAAAAEBcl3220GtuMGbpwUjJ/hciVs9Rigtus4eFWEWsrptaHm8/OiBwjVS68usxYdq4QJg==", "a44f4b07-c051-4bd2-9e6d-ffe80ccaabf2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "230b4b10-00b6-4232-893f-643ed4ab62df", "AQAAAAIAAYagAAAAEJnSaNpdDm5oel6E/kbu2onnmT+Fh9+sLbgr9SVE7kPO9MaJ90Pj7rdotoUqqwto5w==", "3feeb7e6-ec75-4b25-9bd9-46566a3f07ee" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f1e8077d-16c7-4cb4-b8c7-168f3aac323c", "AQAAAAIAAYagAAAAEL+w9nM9Fg267bzLdtsgOTVB0lYelJModY1YCUgP2g4e3TPpJ/R9h/6Vi8CYS+9NFg==", "73120d3c-53ca-4485-a165-5a641f40554c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bda6c4a3-6d2b-43f4-a2cc-3c283ae67e75", "AQAAAAIAAYagAAAAEAw1i8fWvxMLaPeOJ7EpLND+kMuJ6/xRQwSocnLIif4nmxhnGOkKasXem8CYrCNTTQ==", "32b2eb69-6686-411a-aa61-6c21baed8a95" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4d8ba56-1d00-4ec4-bc53-7978526d11d5", "AQAAAAIAAYagAAAAEHOlwS49OqNc9K8o95lJvdoC564onc0yc4Ayy5HdRKPxVjz7ooNNji9Kfs+4CgLMxw==", "5a9b1a83-be3d-4218-bfe4-281afc14d3dd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b7ee95c5-9bec-4fff-ab6c-712a5da2cddb", "AQAAAAIAAYagAAAAEPyKfJyIjHEwlFMoiBREAArKT9KwFofh4A494DtehsnK2w53jC1lR/TdLrcOkSHUPA==", "7b79edc0-04f5-4df7-b6f9-2985a9dee0cb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "77123cc8-2f11-4252-94a0-2cf493828d8a", "AQAAAAIAAYagAAAAEL9vIg8ZrG5ECWizvHWMk7sOC5nD1xd+VttR/sgILAv9ESn6fIoSZ4W4tfL3dvxhiA==", "7735b98e-30ad-4efa-a70e-ff65c996351f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c2debdb6-aa8d-4957-b59d-972b0fcd215f", "AQAAAAIAAYagAAAAEM6fR0AYY0HwV/32qNHjnmqN48Hvt0b2bNqCQVRPuFI9wfch54TptZm6tnbhAU/51Q==", "b0fefd5f-d4cd-4146-977d-56c1e5c81a5a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f47c45b-1223-4689-99f9-49766b7e2dd7", "AQAAAAIAAYagAAAAEAOMhcz0aj3s6BAGpJ16Q3CAA6cud6LcweifWLMp6hwjMy+r/VQStJe0NEXuzTt2tQ==", "31340c0e-a7b6-4f8c-bf1b-dfe790ed7a11" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "145734c7-4408-4148-83f6-2331bd88b884", "AQAAAAIAAYagAAAAELYdZnwZkgZ2TPXqpyBqxSR/ek5WW89KZ1cP/6ygsTWNAgRvLRrD95HiTeOntEN0ZQ==", "15de1f79-a684-440a-8f95-367e28b6f61e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5a1285c8-050d-4a50-8cd8-9a2d98e48de4", "AQAAAAIAAYagAAAAECzPrZ3H557WSM/KXKm3NTROQNfjQ3DLlnH327pzA0/anrLQFaDHNb1htbYoWcH9rw==", "dbbe141e-e467-4406-b651-d1856c77171b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3ab85b37-57b1-4c8d-bab3-ca3028af161e", "AQAAAAIAAYagAAAAECXUy2NTM8l8b8pyJn4FJyLhE93lGJzlYsoRiTxtLu/6mMJ1NEp5tEGmP7P/5N7G1Q==", "0adc7388-0bed-421f-a34a-e6b3b6c791bf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "553cf064-ddfc-4fd3-aac5-7a2c775c1216", "AQAAAAIAAYagAAAAECPnjkADq1EMLqe1yapLlN0I52qp0tBUTyAl03s/EBCAH1SxMKKZtEaIBh0UGprBRQ==", "15a49ba5-5c90-45dd-92b4-0f627b260068" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6d5e7365-0ba5-4957-972a-9a273193eb4f", "AQAAAAIAAYagAAAAENUMK+oN0z4qzyq4WELLyk8eR6/ZBtIeAIiZlcfqjrbTIC9N9hXpLXEKw5qwhSRjEQ==", "3d725090-85bf-495a-864c-910509e7fb88" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b5445fec-fd98-46fc-91af-43cfd268fa02", "AQAAAAIAAYagAAAAEEh566V9Ra/ck1R0bM1/XQbmFwv3U166FDrFyohWh3ZZUoNlXUHHBqTvckkuTo3cgw==", "87f3c92b-c058-412e-9e5c-0c55cb7bdcba" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "757a09b9-2c2c-4a34-8722-5efa89f02b63", "AQAAAAIAAYagAAAAEIjVSC8SOMW3rWZb3R+7k9X3Kcu3TKdYvsC4i5E27GBwAVc7ssUKu+Z3Lw6k7NfWIQ==", "4aa3a410-9534-43ad-bac9-27b8f38181f3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "841cba56-2946-404c-931c-b4caddb0e167", "AQAAAAIAAYagAAAAEOhdps9cPctqabpwAhxGocH/mg+FfeYtDWiLYE8pRx8bZWEL5zIge5K/blT/99sgtg==", "b7b4b1c2-82a3-4b6b-8c64-b3bdf1b0f56c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8561a738-1f72-4ed0-8a2a-4d879f1493c3", "AQAAAAIAAYagAAAAEJKuXBWeZCfb6266yxLf+jkY4rarlNs2iOm26xUTBYY6IKUMWxz6gK/SZhvALLfK8g==", "4b1cf456-2bf0-4678-adc7-2c6413b0be72" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1c8e79f8-06c5-4feb-bc29-7bcc3b0459cf", "AQAAAAIAAYagAAAAEMHIbQNUW9+V6ciCaTw3WpZMo+V7FOgAMN9C4/gQ7gtuQoYgKfskC84LM3BqTrRI7A==", "2de87501-c39a-4774-940b-061e4641eb2c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "531d9e2b-5f26-422a-9b6d-068e0bae6865", "AQAAAAIAAYagAAAAEAw/ikCcWQ6Ht+83+Q9Xm2gnoZJs9oHf3M279UNvmaJRCbZroTR1CcZRIuTmdBaigg==", "5382bbeb-d767-4c62-986f-c12c6ee3a248" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "876e2a1d-846a-4b7c-a48c-51f1852e5cdd", "AQAAAAIAAYagAAAAEAHblTHXByaN9pkgmKzkKwGoA5Udd3MQZWZ4LjUC/fgd4TVTohdAK7MYQFHv9VY53A==", "417111c6-5e52-4a32-b818-379cf7d64840" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bacc6856-88df-474c-bf20-36b8841dcf4c", "AQAAAAIAAYagAAAAEPb6ZM8/XyoUZJFYnxl0V/0seaiE8lPddH3hgegZcYs+udtIVwqK8UwbHN1LQqJrCQ==", "cfea20e5-5e4f-4b47-bf18-c0df1d2e464c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a8b15daa-83f0-4ae3-9273-734e7191e500", "AQAAAAIAAYagAAAAELwxbFlyceLxPIoUK6bQg0of9qMBTqR4SZE9154P7P8/Do2ian/WD+YydaqRKw7q+A==", "8bb2fad5-cdc5-4e40-a1c4-03b978c04e13" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                columns: new[] { "ActivityName", "BreakTimeInMinutesType", "CreateDate", "Description", "DurationInHours", "DurationInHoursType", "Imgs", "Location", "PackageId" },
                values: new object[] { "Khám phá Hang Sửng Sốt", 2, new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3826), "Hành trình khám phá hang động kỳ vĩ nhất Hạ Long.", 2.5, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Vịnh Hạ Long", new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138") });

            migrationBuilder.InsertData(
                table: "ActivityProduct",
                columns: new[] { "ActivityId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") }
                });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2369));

            migrationBuilder.InsertData(
                table: "AgriculturalTourPackage",
                columns: new[] { "TourId", "CreateDate", "Description", "Durations", "DurationsType", "EndTime", "Imgs", "PackageName", "Price", "Slot", "StartTime", "StatusActive", "TourCompanyId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("276cb0a3-4406-4943-8e7a-ee2b62e49e79"), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2429), "Tham gia hành trình khám phá đại dương với hoạt động lặn ngắm san hô tại Hòn Thơm, kết hợp tham quan làng chài Rạch Vẹm - nơi nổi tiếng với những cây cầu gỗ và sao biển tự nhiên.", 8.0, 2, new DateTime(2024, 9, 16, 17, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Khám phá đại dương & làng chài Phú Quốc", 1500000.0, 20, new DateTime(2024, 9, 15, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("2df2222f-37be-4780-9ebd-d4fcf4107e28"), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2382), "Tận hưởng kỳ nghỉ thú vị với hoạt động tắm biển tại Bãi Cháy, Quảng Ninh.", 2.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Gói Tắm Biển Bãi Cháy", 800000.0, 30, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("7d92159e-bd23-42e8-ba5d-94f02e8abc7a"), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2396), "Trải nghiệm không gian lung linh của phố cổ Hội An về đêm với hàng trăm chiếc đèn lồng rực rỡ.", 3.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Khám Phá Hội An Về Đêm", 900000.0, 30, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("938425a8-1ef7-4b26-a01e-effe123015c7"), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2390), "Hành trình khám phá Bà Nà Hills, trải nghiệm cáp treo và tham quan Cầu Vàng.", 4.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Gói Tham Quan Bà Nà Hills", 1200000.0, 25, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("d470cefb-e618-420f-a399-31bbe277596e"), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2421), "Trải nghiệm lặn biển ngắm san hô tại Hòn Thơm, tận hưởng làn nước trong xanh và hệ sinh thái đa dạng dưới đáy biển.", 3.5, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Khám phá đại dương Phú Quốc", 950000.0, 15, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("d83b9062-ca46-48e2-8db9-a05d24436ff1"), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2415), "Tham quan chợ nổi Cái Răng vào buổi sáng, khám phá vườn trái cây buổi chiều. Trải nghiệm cuộc sống dân dã miền Tây và thưởng thức trái cây tươi ngon.", 8.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Trải nghiệm miền Tây sông nước", 950000.0, 20, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("f0cfb5d7-bfa4-4d0c-bf72-c8d37f62c0a1"), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2403), "Chinh phục nóc nhà Đông Dương bằng cáp treo hoặc đường bộ, tận hưởng khung cảnh tuyệt đẹp của Sapa.", 6.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Chinh Phục Fansipan", 1200000.0, 25, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null },
                    { new Guid("f12a6bbe-5187-4713-b9bc-1b5e1d4ebeb8"), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2409), "Khám phá nét văn hóa miền Tây sông nước với chợ nổi Cái Răng vào sáng sớm. Thưởng thức các món ăn đặc sản trên thuyền và giao lưu với người dân địa phương.", 3.0, 3, new DateTime(2025, 6, 10, 11, 30, 0, 0, DateTimeKind.Unspecified), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Trải nghiệm chợ nổi Cái Răng", 750000.0, 20, new DateTime(2025, 6, 10, 9, 0, 0, 0, DateTimeKind.Unspecified), 0, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("139a52e4-89b1-4ffa-b68f-e898b445d2ac"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F7.jpg?alt=media&token=335319e3-a4dc-4660-a1bc-6fc7e1ec7715", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("2f8e7030-710d-4c12-b7e4-153a04eaf3ba"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F5.jpg?alt=media&token=556db399-72c6-4e4b-b526-696ba6964a06", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("50669b85-6daf-4e32-b018-6e500aa7f49d"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F1.jpg?alt=media&token=400d8921-0982-43d9-8a4c-84fada93ffd7", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("66b1cb84-d71d-47c6-969b-5aa5c0a46676"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F4.jpg?alt=media&token=033dfae9-48dc-438b-99b8-28ed3d677ce9", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("8ab30ef2-9a02-425b-92d5-6645022ce866"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F11.jpg?alt=media&token=5c5cc822-5aaa-4b00-aec4-43283761602c", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("b7c5ac42-9ef3-4170-85fc-f24433a4233e"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F2.jpg?alt=media&token=c6b2a429-ae21-4ebd-ab21-0bb9d4f8f6de", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("bde668a7-1634-4037-8d25-ea80ccdb7168"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F12.jpg?alt=media&token=750bb7af-fd92-4efb-ae05-6c960a669bf6", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("cae9a3e6-0773-4b30-87e4-983430b26658"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F10.jpg?alt=media&token=8e99e1e3-6684-4214-8a48-1abf03eedf68", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("d038f481-60d1-4aed-b049-7aa31cbdb8cb"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F3.jpg?alt=media&token=9d4ed8b5-9798-482c-8eb0-95267f4af3c7", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("de92f025-db90-47cc-8398-509af452eecd"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F9.jpg?alt=media&token=ccd4085f-f132-4f27-a079-c61407ea41ce", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("e2fbbd9c-9f6c-4560-b326-652e161866c6"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F8.jpg?alt=media&token=640bc226-acf9-47ad-9f92-61728b6a1f5d", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("f0ffa2be-f07c-4873-8807-089e7232b36c"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Blog%2F6.jpg?alt=media&token=f28b7b16-42a3-49ed-a647-6a10682badfe", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("47cadd26-4cb2-4e01-b41a-cabec9d96f66"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3639), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3638), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3638), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("598800a2-9208-400e-ac84-abfe6ff22a7b"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3598), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3597), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3596), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("68d50ee1-5016-48fb-8bc5-32087b9eeca9"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3625), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3624), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3624), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("84c2bffc-0f8c-4773-a044-86d4bf132460"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3703), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3701), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3701), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("b8db551c-a4d8-4c95-a73d-11964b50c6f0"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3612), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3612), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3611), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("dd178ca9-98da-4d3d-8a7c-c2d80ae0c2fb"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3606), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3605), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3604), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("e1a1df2e-0e92-4b9c-bed0-a815d40f7ac4"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3650), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3649), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3649), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("e60babad-5676-4b47-9b6b-2ca16faaa836"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3619), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3618), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3618), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ed15f40e-767a-4255-8c5b-aa6052fa96f7"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3631), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3630), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3630), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ee9f27fe-400d-4893-b692-530c38da9a44"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3645), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3644), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(3644), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0ee2a34c-27b7-4525-85ad-aef149c1e21d"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3277), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("1e9a5e34-6606-443e-a77a-1d6e2811bd10"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3494), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("24cf0b85-0885-4a9c-987e-c05da8f1005c"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3478), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("2abfd18a-73d8-4cb4-aa73-b267d07a2a11"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3470), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("31ebce20-eb7b-4dd3-b40d-28176b7ef18b"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3269), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("3fb8cd9b-01d0-475b-b810-648953c1b652"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3207), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("486f2338-d2d5-42c1-a3bb-feaa946b4394"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3227), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 100000.0, 1000.0, null },
                    { new Guid("55e5ca0a-cea8-47d4-a6fd-c18b581bc2fd"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3527), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("63dde3a6-46bd-467b-984f-544496cff60f"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3501), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("7f9fe374-4f44-4773-92af-b3d7745d8315"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3509), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 100000.0, 1000.0, null },
                    { new Guid("856bec89-c867-4d2f-9e1e-c6672f8deaf1"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3289), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("85e96aa1-e765-43e6-864c-253bd6c1a5e5"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3353), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("86a4eae3-eb3f-4dcb-b660-a2299e59c1fb"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3486), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 100000.0, 1000.0, null },
                    { new Guid("a14a12a1-1827-43b4-98ed-ff70367a1bda"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3368), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("a47436f6-14cb-45af-93a8-00af4296260d"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3376), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null },
                    { new Guid("a93420f6-8cf6-4a3c-8924-cf3cb6ebbb33"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3517), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("c85fb9a0-a01a-4098-9d92-b44d22e40b0c"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3360), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("d1b57c31-6f8d-4dc2-8d40-74ae96a58322"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3329), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("d2ac5ea5-df41-4319-b586-eb50a0f63b2e"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3337), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 100000.0, 1000.0, null },
                    { new Guid("d4dd540b-d5f3-43b4-8bb4-91cb74a14600"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3345), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 100000.0, 1000.0, null },
                    { new Guid("d8c964a1-ec0a-475f-8ebe-04150fda0c83"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3218), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 90000.0, 1000.0, null },
                    { new Guid("dfdbf0c4-6d62-43c8-ab39-f264d6513346"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3534), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 100000.0, 1000.0, null },
                    { new Guid("f83aa640-85eb-42ce-b97f-2f9396fa8acf"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3236), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 100000.0, 1000.0, null },
                    { new Guid("fd161858-668b-40bb-a826-2e75c7e7c5cf"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3460), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 100000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2849));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2912));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2920));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2881));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2858));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2890));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2834));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2873));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2268));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2271));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2273));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2275));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2277));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2279));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2281));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2283));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2285));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2287));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2289));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(2291));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1618));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1590));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1595));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1632));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1624));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1614));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1628));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1581));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1599));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1604));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1609));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1586));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1568));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1640));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1637));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(1576));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2587));

            migrationBuilder.InsertData(
                table: "TourDestination",
                columns: new[] { "TourDestinationId", "AccommodationId", "ActivityId", "CheckInDate", "CheckOutDate", "CreateDate", "Description", "DriverId", "EndTime", "ReplyRequest", "StartTime", "StatusApproval", "Title", "TourId", "TourismPackageId", "TypeActivity", "UpdateDate", "VisitOrder" },
                values: new object[] { new Guid("10000000-0000-0000-0000-000000000001"), new Guid("10000000-0000-0000-0000-000000000001"), null, null, null, new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2598), "Mô tả khách sạn.", null, new DateTime(2025, 6, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 6, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), 0, "Khách sạn", new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"), null, 0, null, 3 });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2491));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2498), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2499) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2505));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2511));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2515));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2520), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2520) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2525));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2529), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2530) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2535));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2540), new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2541) });

            migrationBuilder.InsertData(
                table: "TourismPackage",
                columns: new[] { "PackageId", "CreateDate", "Description", "Durations", "DurationsType", "PackageName", "Price", "ReplyRequest", "StatusApproval", "StatusOperating", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"), new DateTime(2025, 3, 28, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3780), "Tour 4 ngày 3 đêm tận hưởng vẻ đẹp của bãi biển Phú Quốc, lặn san hô, thưởng thức hải sản.", 4.0, 2, "Du lịch Phú Quốc - Thiên đường biển đảo", 7000000.0, "", 1, 1, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), new DateTime(2025, 4, 5, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3781) },
                    { new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3758), "Tour du lịch Hạ Long 3 ngày 2 đêm với nhiều hoạt động thú vị.", 3.0, 2, "Hành trình khám phá Hạ Long", 3500000.0, null, 1, 1, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("7874fc31-cdae-4cf7-9aee-b802ed19ed58"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3764), "Tour 4 ngày 3 đêm tham quan các điểm nổi bật như Bà Nà Hills, Hội An.", 4.0, 2, "Trải nghiệm du lịch Đà Nẵng", 5000000.0, "", 1, 1, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3767), "Tour khám phá Sapa, Mộc Châu 5 ngày 4 đêm, thích hợp cho người yêu thiên nhiên.", 5.0, 2, "Khám phá vùng Tây Bắc", 6000000.0, "Chưa đáp ứng yêu cầu về an toàn.", 2, 1, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3768) },
                    { new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"), new DateTime(2025, 4, 2, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3772), "Tour 3 ngày 2 đêm khám phá chợ nổi Cái Răng, vườn trái cây, và cuộc sống người dân.", 3.0, 2, "Trải nghiệm miền Tây sông nước", 3200000.0, null, 0, 0, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1735));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1766));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1771));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1777));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1783));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1789));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1794));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1800));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1806));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1813));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1819));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1825));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1830));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1848));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1854));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1859));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1864));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1870));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1876));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1882));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1887));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1893));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1899));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1904));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1909));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1916));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1921));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1926));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1931));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1945));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1987));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(1992));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("0ab4ef73-7c48-4093-9ca8-93f45e9e8ec3"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2212), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("19b0b864-eab1-4f6d-b260-a901c4e994fd"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2197), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("3876aed7-77de-468b-b279-e3d796d137f7"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2173), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("403c514c-10af-4647-b0ea-9efb3d5807e5"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2184), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("4becc314-8df7-4f46-8702-e64c1ffc28da"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2203), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("8381b7fc-a1fc-4607-94f1-4d4855a70be6"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2200), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("8a1ba9aa-d318-4b1a-a33a-dea71450f35b"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2194), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("a24ccbd1-c29d-4b9c-9e82-0776249585ae"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2209), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("a286627f-b7e4-4c4b-8b9d-e67ba98f76ec"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2181), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("b6db755a-584e-4118-a04c-7b4e898d0a2e"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2191), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("c092839e-1993-45ee-9630-fa525e9e9342"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2187), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("f90ceb34-4761-48eb-9ac6-31fe67634350"), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2169), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2108), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2110) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2087));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2091), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2096) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2120), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2122) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2083));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2114), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2116) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2102), new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2104) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 4, 7, 21, 54, 35, 334, DateTimeKind.Local).AddTicks(2077));

            migrationBuilder.InsertData(
                table: "Activity",
                columns: new[] { "ActivityId", "ActivityName", "BreakTimeInMinutes", "BreakTimeInMinutesType", "CreateDate", "Description", "DurationInHours", "DurationInHoursType", "Imgs", "Location", "PackageId", "ReplyRequest", "StatusApproval", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), "Khám phá chợ nổi Cái Răng", 15.0, 2, new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3851), "Trải nghiệm chợ nổi Cái Răng vào buổi sáng, thưởng thức các món ăn đặc sản trên thuyền.", 3.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Cần Thơ", new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"), null, 0, null },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), "Tham quan vườn trái cây", 10.0, 2, new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3855), "Tận hưởng không gian xanh mát, thưởng thức trái cây tươi ngay tại vườn.", 2.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Vĩnh Long", new Guid("a649b3b4-10a2-4225-a229-be4d66f29552"), null, 0, null },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), "Tắm biển tại Bãi Cháy", 10.0, 2, new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3833), "Thư giãn và tận hưởng không khí trong lành tại bãi biển nổi tiếng.", 2.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Bãi Cháy, Quảng Ninh", new Guid("7874fc31-cdae-4cf7-9aee-b802ed19ed58"), null, 0, null },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), "Leo núi Fansipan", 30.0, 2, new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3846), "Chinh phục nóc nhà Đông Dương bằng cáp treo hoặc đường bộ.", 6.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Sapa, Lào Cai", new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"), "", 1, null },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), "Dạo phố cổ Hội An về đêm", 15.0, 2, new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3842), "Khám phá phố cổ Hội An với hàng trăm chiếc đèn lồng lung linh.", 3.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Hội An, Quảng Nam", new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"), null, 0, null },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), "Tham quan Bà Nà Hills", 20.0, 2, new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3837), "Trải nghiệm cáp treo, thăm Cầu Vàng và nhiều địa điểm thú vị.", 4.0, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Đà Nẵng", new Guid("7e5d0a21-9f4b-4c2a-ac11-aaae96fcec31"), "Cần bổ sung thêm hướng dẫn viên.", 1, null },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), "Lặn ngắm san hô tại Hòn Thơm", 20.0, 2, new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3865), "Lặn biển ngắm san hô, tận hưởng làn nước trong xanh của Phú Quốc.", 3.5, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Hòn Thơm, Phú Quốc", new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"), "Cần xác nhận thời tiết.", 1, null },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), "Khám phá làng chài Rạch Vẹm", 15.0, 2, new DateTime(2025, 4, 7, 14, 54, 35, 334, DateTimeKind.Utc).AddTicks(3871), "Tham quan làng chài nổi tiếng với những cây cầu gỗ và sao biển tự nhiên.", 2.5, 1, "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/imgtour.jpg?alt=media\\u0026token=9219bd24-5a76-43cb-b70c-4cabf30d8c74\"]", "Rạch Vẹm, Phú Quốc", new Guid("321c5b3a-d096-4406-bd11-fbfbd4436fc5"), null, 0, null }
                });

            migrationBuilder.InsertData(
                table: "TourDestination",
                columns: new[] { "TourDestinationId", "AccommodationId", "ActivityId", "CheckInDate", "CheckOutDate", "CreateDate", "Description", "DriverId", "EndTime", "ReplyRequest", "StartTime", "StatusApproval", "Title", "TourId", "TourismPackageId", "TypeActivity", "UpdateDate", "VisitOrder" },
                values: new object[,]
                {
                    { new Guid("10000000-0000-0000-0000-000000000002"), null, new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), null, null, new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2613), "Khởi hành từ bến cảng nổi tiếng của Hạ Long.", null, new DateTime(2025, 6, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 6, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), 0, "Cảng Tuần Châu", new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"), new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"), 2, null, 2 },
                    { new Guid("10000000-0000-0000-0000-000000000003"), null, new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"), null, null, new DateTime(2025, 4, 7, 14, 54, 35, 339, DateTimeKind.Utc).AddTicks(2605), "Khởi hành từ bến cảng nổi tiếng của Hạ Long.", null, new DateTime(2025, 6, 10, 10, 30, 0, 0, DateTimeKind.Unspecified), null, new DateTime(2025, 6, 10, 9, 30, 0, 0, DateTimeKind.Unspecified), 0, "Cảng Tuần Châu", new Guid("72985040-386d-43ac-833d-1c2cc36cbd17"), new Guid("32ba5585-d88d-4c07-8c3a-5c3f846cd138"), 2, null, 1 }
                });

            migrationBuilder.InsertData(
                table: "ActivityProduct",
                columns: new[] { "ActivityId", "ProductId" },
                values: new object[,]
                {
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") },
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("06f562cf-b39e-428f-921e-8fc94826505e"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("26dc3636-9823-4900-ad4d-7ab5f408cbba"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("5acd4e26-7ec5-4633-8fe7-a0d97692ef7a"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("6723a17d-ae68-478e-9667-d2e62cb0aeba"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("694fce72-18eb-44d0-97e5-fd2ca2840c96"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("7df9849b-ddd8-457c-babf-303356349173"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("c0fe9c22-a634-48f1-9847-279c95f9c483"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa") },
                    { new Guid("cda718c5-68f0-49ed-a33a-3b564182031e"), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1") }
                });
        }
    }
}
