using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Data.Migrations
{
    /// <inheritdoc />
    public partial class update1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("042c153b-5b59-423c-805f-2db3ec8916c8"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("097b2f9a-66cf-4b3c-9e11-ed3cfb3d7f07"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("10c384ef-a89c-479d-9c79-055a1339e741"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("1225a5d2-a05a-4d41-a97b-eafc99aef46d"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("197012a4-5d96-4f97-aba2-bdcbb42054e5"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("19c1c3b5-10d2-4620-8c4e-e7a34ed27a04"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("24c95840-0020-4553-8ac4-b45d52d8cb99"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("2973fdef-130f-410d-8499-7f8a8049f323"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("327934a0-0570-4cf6-8aaa-70a216bf47f7"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("333e2450-d9cc-4a22-a0ae-98aa6af7fcfa"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("358a652b-bb87-4d9f-8708-16cd31ae7ec2"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("38cc09af-e98d-4365-9eec-77f158b0b08c"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("3b68f298-b97e-472b-9c37-070d48d226d7"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("403d5ffb-3a9a-41d4-8327-cb99b2894d8a"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("4c421da7-110e-4742-91c1-682e3ebc2e27"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("5473415c-8dfa-463b-a48d-36a41a09697b"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("58b3054c-569d-4884-9498-7d72f52deec7"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("5ec48449-aff5-4357-8aa9-ab97d97d571b"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("71f442f2-988f-4e50-beef-d4e1ba30dba4"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("7ab4baec-a650-45f6-9cda-aabac7d64cb3"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8c0eecaf-0a00-4269-b3b1-357fd2052cfb"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("9928f3d9-68d8-4a0c-8fa8-1e2c472a5213"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("9d05547e-c2b1-40f4-b532-1649dab388f0"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("a6ad2ef5-c2f1-4339-930e-ab16fc444cfc"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("a8f22afd-d296-4e71-bc34-ebaf13b91b4c"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("b0bcd906-5638-4125-acdd-77a1e3732afe"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("b997a562-d898-45dc-a27b-40a0d31c6bc4"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("bdbba0af-c81b-4c69-95af-af3be342cf1d"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f3b5b424-e5bd-4e7e-b98a-f408930c5071"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f40ae8e3-2457-4bdc-86ea-2ae2e2ee7b92"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("fd7e6e7a-f33f-4ad5-9693-c1bb21cb6f4b"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("0d7fa707-c5fc-44d8-9890-4390537554e3"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("10d83f63-b284-46aa-a465-a23bb8e6af9a"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("2b4bb217-cb05-4cd4-a3f4-ba7d44755d5b"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("42c0b897-97db-4181-9cbb-e71fe4dd4e39"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("49026da6-579f-4823-bf94-5e4679aa372d"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("492bf1af-f585-4f6a-bc77-df6758239835"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("54e371c1-8abd-497e-83b7-94c1f04a774c"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("57015234-d97d-4de6-99dd-3da10b137e70"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("7a4bf589-27d5-4f80-a7f1-7fd1f72da947"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("87f8d5d7-645f-4e50-bb99-f02fb880281e"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("8a868015-f57f-4930-aa7a-674b71bde9e9"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("dfd1d074-b18a-407c-8e5e-d63db80f1f90"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("0a2898a5-c36f-441c-b710-e5737d35eb07"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("3b228f24-c786-49e1-b781-fe1e6f58b15c"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("3b689d42-3640-4c27-920c-32ab83185e79"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("49723efc-2988-4227-9f8f-a41a678a137b"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("658f2b48-be26-4178-a886-966a8c7b440c"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("6b4e360e-b8bb-42e2-b02b-b43b877801b6"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("733d096c-a2a8-421c-a91d-dd65cfd02814"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("a4a3b2ab-9642-4458-b242-fd0044833912"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("aef26e64-0228-49e2-993e-beb9fb542f83"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("bd21b4b7-9571-490e-9f85-9a0a0fc0f2e4"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("08546102-1b39-4614-a809-adf7f179a165"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("1bd35c14-2f4c-4c81-b19b-e0a55c23a31e"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("256b3ae7-945f-4227-ae28-a4a93f517e52"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("25daffae-5a2b-4414-907d-28151da4b4cb"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("2c1762fb-70db-4f81-9534-3f15bf6d945e"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("312b60b7-84c4-4e8f-aa73-4c0059d981c4"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("349decd7-8a26-49a4-8c74-4141eb28c197"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("4a28446a-6167-4452-a814-73234c3ded59"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("4ef2a007-b06d-4160-8dd4-7345fd1e8512"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("54124f43-8ac5-4dca-a81b-eb738f27ed42"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("57552467-236a-4c29-ad37-ae3e74658698"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("65f039d3-5872-46ea-b29f-f5e8c01a858d"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("6ec90e6d-9c94-41fd-90a0-3870cb6027d6"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("7842c53e-dd1d-4e9f-8fcb-1cf0a48fd55c"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("79d8cfb8-32fd-4d3a-b1c5-cafd5c0aa83f"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("82a62095-6cc6-427a-b87a-f31db606ed4a"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("91f37766-8591-42be-88a2-75ad43c7d234"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("95f346fc-9271-423d-8b33-7d45b0440be9"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("9b7aab6a-fc75-41e9-8a60-ffa818eb2c00"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("a0a3188e-90ad-4777-970f-72ee94b8e73b"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("af7cb135-efce-484a-8c96-e363fb2a66a8"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("b25c09db-1fc0-46e2-9f5e-f76425fb2938"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("c15a34c6-2341-4dfc-aeee-abdcec1b7bd7"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("c1c91244-f7a9-4e06-869d-52be4f2ea731"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("ca9b5b9a-7a3c-4a0d-9a45-c059e2b983cc"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("cabb3069-10a1-45ad-8338-059c947460c4"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("cc3293e8-412c-4968-bb82-0ed631d5def6"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("ccc87bf7-b7e8-4b3e-8deb-c7cb64ce397b"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("dc5f0780-00ab-4388-97de-cb3ad528ea46"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("eff4e868-6a21-4a0e-8d95-6198cc16f53d"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("fe7cfc28-0094-45dc-a3cc-8a48c23fe5f8"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("070a6899-772d-41ba-aa4e-016aca6f7bd3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0777a9f0-6958-464b-a76c-3d0a783bbecf"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("0b606e08-56e5-4256-883c-d1e32afc9359"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("11885d8a-bc89-400e-a9d3-518fe54deffb"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("1be8aa96-a7ce-4fbc-8f05-41c421a8b40c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("21856b3e-e23b-441e-ac6a-be51068c7b37"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("2fd0158e-9978-4232-9f26-3f76c6382b99"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("361431a5-eed9-40cb-8849-86843534b7b1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("37e63e66-a5a4-4327-847a-8aa901f1e018"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("413d8b3a-70c6-405d-80af-3f00adec1768"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("45b89f30-3a39-4496-a32a-b4a994f1458f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("47f8d21d-2430-48e1-8f18-dc66c293a4d7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4904d67a-647f-4a6d-ac64-9d962794d1dc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4d9a87aa-4526-4c76-864f-dc8c6d6c3e5a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("506cbede-dac2-4074-8850-55db68a50ec6"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("52f04413-55a7-484b-b99c-7beb3f719754"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("543f271a-fb09-4c1b-b761-7ea1396013b3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("56b965e9-d19a-4cb6-bb5d-d810c22fc37c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("56bb59ea-c633-4974-9bfd-7f3956a7ae8d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("77467456-0b25-473b-a79a-b6b57b4cbc6f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7949af45-ab42-44c0-8f3d-38072d9806ee"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7ca23f4f-0c03-41bc-a119-ac6afa2075e6"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8289da52-f4af-4f9d-9d2a-3578e05f1e7b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8351fcfc-d4f0-445a-a19a-d665b9481d17"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("88fd25ac-f9d4-4915-a23d-0ec863dd5227"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9161bd92-eb5b-42fe-a5eb-ed4bc98a289a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a3304ee0-f42b-4d66-9dd9-d95a3ecae6f5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a4d14064-b84e-44df-9e49-b091e0970923"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("a6206ad6-1152-418a-bf97-106708774107"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b9458fd8-89f2-46c8-b2b7-20b467f02907"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("bdc922bc-c218-48c3-b598-6844ddd8690b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("bfe2e30e-1d7a-459d-82f0-d731237242cd"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c00f52f1-3004-40c2-8d9a-452aa74cdc3a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ca354042-9c25-440e-9f9f-51737583791e"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ecde8c8c-8f23-4711-a30f-743938f73fd6"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f6aa7dbb-98c9-4731-a944-fb2d00d39cc4"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("17778b0a-07db-4018-bbf6-8186f94b1dec"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("1e2bc1d8-7143-497e-8095-d0c3ede8f321"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("2137f734-cd08-48de-bb64-30f18818603c"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("24a69220-8fb7-4d12-ae87-2473f09ee6cc"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("2c20a582-0c72-41eb-bda3-0840052a894b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("3bc31551-8e48-447c-8b70-18036fc99472"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("6661bc2a-0f19-4cc5-a699-8d5a00a5f046"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("80cff09d-405a-4b84-ac74-9c9bf5154dc9"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("871808d0-0c74-4ccf-a7af-0c4ccde2814b"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("96b21098-e327-4a3f-9d1a-142ea6c52377"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("e098e8e3-952f-4289-b216-c9f0c50c1186"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("f1d00707-6e9c-4bdd-bca9-25170fc4ce44"));

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/516733727.jpg?alt=media\\u0026token=0b789349-cba9-4e9d-b988-5bce07d457c2\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/du-lich-phan-thiet-mui-ne-khong-gian-resort-song-bien-xanh.webp?alt=media\\u0026token=b6f4bca3-b5aa-4c86-bf5f-f58c358b1477\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/images.jpg?alt=media\\u0026token=ee02614f-fc3b-4b11-a092-fd0be838362f\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/images%20(1).jpg?alt=media\\u0026token=38f10da2-3dc2-4bfc-bbc6-347729ca583a\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/images%20(2).jpg?alt=media\\u0026token=586806c2-bc7f-453d-8646-652d5edf6772\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/khach-san-mat-troi-nha-trang-top.jpg?alt=media\\u0026token=aa18f97e-2c52-4981-80b6-943366ee150c\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/nha-khach-an-binh.jpg?alt=media\\u0026token=ffed214a-b404-4354-a61d-05c1201a6eff\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/1490857443-chen%20sea%20phu%20quoc65_resort%20phu%20quoc.jpg?alt=media\\u0026token=78b1604e-3dff-40a7-8136-336f1d731838\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/278c80de4ccef04ea12ccfd4a3e15aad.jpg?alt=media\\u0026token=54dd0bf7-514f-4daf-b40c-bb861476d91b\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/e7ba17f6_z.webp?alt=media\\u0026token=dbb8ffe7-bf92-4fcd-88ff-51757c0d86f8\"]");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ed0f79bd-ee90-471a-9b1c-5800fd7bb402", "AQAAAAIAAYagAAAAEB0vE1sH5l+mIlxZR1w0KFVRoJErZNffnHgpksEXYBH9u7CjemqZX7nudSkriyV9Nw==", "67c76fc5-769f-44b3-8379-a395cf10f635" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "711689d2-d424-4de5-a707-f0098d5e6aa0", "AQAAAAIAAYagAAAAEHlvze+X16YY6bUSoEb3KoPZwtDhvfSGcdc+YZnMc2Wd1hmygi69JvMaDGF7yORCzw==", "beaa7a9f-9620-453b-9a63-48f4b365ef4d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a7994e3-5626-4b5b-8788-e8b6ae43f277", "AQAAAAIAAYagAAAAEMWRGdlJVGL1e/yifC+Kh/myoUwwGgTkznBmgUXE6M1LHVVIq0p9hhXpYhxxoQr2xw==", "784bcc62-9028-4bda-9715-75dddff952df" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4512c67-80d5-41de-b3bd-6bae3cb86481", "AQAAAAIAAYagAAAAEDNVCQj0Bb82bg3kWHoVj4Jb+DD/eo6PU/iv3O5fLWDOsQcReUaAoGe84GdrfYYDbQ==", "fdbbb387-ec25-46de-968e-d87e68f6fa3a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "aca85f7e-6a71-41f9-b928-d9668be18d13", "AQAAAAIAAYagAAAAEFd0BbGnZsas7zAvNJF5P7GTGAY8bWaUw7H7fbj+jQY5QfLR2HtiVsW3cM/jnI07Dg==", "547c6bb5-db1b-4660-a02f-fca02df94504" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d3ad3aad-23d6-4821-8137-ee21e603dfc3", "AQAAAAIAAYagAAAAENSvpw/a+kMYZbY4qXAKiv2vOQANqqDWITq428eXGnOk2IjSmPbpGRoYp6eZwAJ9SA==", "fee18ede-c7b7-45ab-99d0-ff5304a3cb3c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a899a0df-4cd8-4acf-ad2a-e3b2d2711e35", "AQAAAAIAAYagAAAAEPXijIwjLa515g5yT4Olr4zafrOs+CLW6eBTUDMD4EL30O84bu3Hw46frX/I2y+4Jg==", "a380b696-b913-467f-8c8a-be7cbe858e64" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ebc01da3-1faf-4455-9d90-7183baa373d2", "AQAAAAIAAYagAAAAEEXxc7vQuJEL670Ms/7o7lrUU8RyseMHhMPcxU6GKB56IZao+zCcYFg78/B8BJgWjA==", "9177f89e-9934-4c86-a277-ecd697129f96" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "64e2827d-aec6-4d39-8c03-2d609f4234df", "AQAAAAIAAYagAAAAEPTE78UzjtomV1gx3lu0DHeS+E+zfLujcCMob2R+BY62ZgbW/hJZaFfMZ8PCLwy5SA==", "9e385bc4-2c7e-4b99-b570-a599efa7a436" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5e209337-fa05-43eb-b393-75e7e7b3649d", "AQAAAAIAAYagAAAAEOTkQP4/JYEkCcSZh6Q7BsN7SfgcOdhV2YD7bddK+Je7lKWRRmHF/QY7c7SOtbLwYA==", "04cba807-156a-4600-b011-92958fdf7b0f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44fdaa97-f60d-444f-8ddc-7ccd85b7b0b7", "AQAAAAIAAYagAAAAEPLdrZI+x007MMLxYKSvFUw9jzQD024x+R24A2R1FCEF2L1JlSGKOiRHuf/DewTOgg==", "902f9d4e-e420-4623-8aff-5f318cb4d6a5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9a71131e-8ad8-4a5a-bd15-664c54e5679d", "AQAAAAIAAYagAAAAEEmuaV5MVy++aexjIP92lS6rfdVw7Gm6OQzCGAQKPJkjqbJ+fS9EIf8ThQZpKrjEkQ==", "783c669b-a29d-4dcc-96c1-a7e401ad6d82" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b4818ad-19b0-4ee9-b761-5fea5cb482e3", "AQAAAAIAAYagAAAAEOfjx66h64vCMrI2yOtCnp4zdbFDG9fb9n0x9T+X8IyIcDyDaS7r4EUcHd6swkMDBA==", "6c29ed08-a071-4ef7-a327-e4d8ee9813ee" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f24b5d92-3989-4828-91f3-a22597ac4d17", "AQAAAAIAAYagAAAAEISq50Flt2n6XrUUWWMbrMScf5SZqoXPrHhMCMgcDHgorXv4SaGrnJUlkRo+UMY4Cg==", "bc9836be-b619-4cbf-b191-9b9200ec5a7f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00a2ca42-7164-42b3-ba1f-51ea21e86ce2", "AQAAAAIAAYagAAAAEJCtua6LReC3RLMXadytYyg7QbPkmD/yK4qaCrVNrjDFeUh8Ke68BsSyqLYegNhc1Q==", "3eaa0d6c-ec4c-47cd-b0de-3022f26d02b4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6a060ae2-716d-41be-b8e3-ef0c8607b5c8", "AQAAAAIAAYagAAAAEB25ZkQSgZhVjRO+tQLSWQtNcwhVpMJLkOnHNfyGq7xDvDrANWt9u25k8Qj6NVHwAg==", "44b2f429-5036-43b7-9cec-1a7c222caa99" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f316370-1ac2-4d1e-9c7b-aa8ffb84c49b", "AQAAAAIAAYagAAAAEN7DGnhKeiGyqJBbNrEJARlxvcBjvcVoA2oKKDPPsA+Sd1fNdC7wBhD4E1gMFnROYQ==", "c9ccfbc2-760b-46ee-a45f-6946014812fe" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b8e042a7-79db-4c4d-901f-c8e6e711e4b2", "AQAAAAIAAYagAAAAEH7kD6orXv5N3bcMhJwc3fImfAZAo6hzb65ii6Qgb/sxarU2yfEUrgrtOAk5ss8Lkg==", "bd5b7d40-893b-4454-bf89-5d677cb1f4d4" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0d41ac32-2b5d-4034-be69-3eac848a03e8", "AQAAAAIAAYagAAAAEFfKVvK3mDEczWaPprelrL1g1ZUxUs5+f+8iAk12kKvrfmMaPicLA7zY/6G4bysQMw==", "a78b4f60-a5eb-472a-951a-52c686593042" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "47387321-de9f-4c4f-9d07-25b0484a4a81", "AQAAAAIAAYagAAAAEKrdom0t/BB0+lGyxdapD5XXnIBQYF2Eavlx3F9rIPmMPnvU1GuEDxF7AaU+yEjrjA==", "c1258599-83d3-4282-b396-609434097afb" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8726f892-8747-4cb0-84aa-e08b6b73345c", "AQAAAAIAAYagAAAAEBILVUXlRXlAMXXQxg7+JKcrjR1wzeNj+b3tb9wUZbr1T8tvJneYt6Tn9xwYxXKwsg==", "c92b5a77-6ed1-4491-9087-d14e01fcd74c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f436125d-4204-4685-b8bb-63fd6ce3b13d", "AQAAAAIAAYagAAAAEJ81yQlxdpA0MWQWInpkPQMjdN3qMBawjTeNI3m++zHnle8tlksDvzoDruwePLNrAw==", "a005d0ff-6885-446e-a6a4-2fed5422e474" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4a1256c3-8627-4a41-b2ff-c92b8ca95f46", "AQAAAAIAAYagAAAAEEdztbk+79SASOgfsBkabmHNzX0KFnE3Z3SKcax/nHQPNioxgKOADnlACRDPniTGIA==", "6575c7da-ba50-4f20-9921-7d5d96d16cef" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdb12824-ec55-4290-bdc7-f7885c37cc1a", "AQAAAAIAAYagAAAAEDk4qVvljuY7iu9shbsNavzVSCooPAU/2RNz1b0/8ck3CZd+DkeV5nvngtWagHAEeA==", "28b4c1eb-5fd6-4d4e-96a7-e9ecb1269380" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2bcc9283-b5fc-4bcb-9641-d8de1b38504f", "AQAAAAIAAYagAAAAEJlaz0oFUJ2Y8RdmAKlPfXKujLPE0EbktEJOnZIFyF2ImUESHwEZ43mBbKgqRC6dJA==", "21169640-5337-4d15-971f-c7f840587ffa" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "70162c41-24ab-456e-a28a-088110dd021c", "AQAAAAIAAYagAAAAEJXiaa4bFZPQurS3h2UYCt3VMXd2Z+ukVGD/dB4u68k8Bpm6qaouPBIhrKy4nNN+Rg==", "92118a78-e820-4538-8b44-add322482139" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5f004c4f-11c8-4756-80a2-134857630a4c", "AQAAAAIAAYagAAAAEEO456YC3wPprkDnt/2OTF+XF7626kKF2OEY/dz2b+gRtHMoghvpNRjh7OfAJG5TlQ==", "8129c501-f8ae-4695-9d67-343a7f975bca" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "46ca6c66-2518-4ee2-9a85-01721bb7e77e", "AQAAAAIAAYagAAAAEFxlsxekNPwlMJTbB9uw/zxITSTOZ/Cd2o08iY8vtzxekVKxlTjlxzFrgD/WMy/n5Q==", "1cceecc5-cbc7-44e1-a32b-9d3226d8e949" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "285433d8-f4f7-44cd-9297-614f8819cd26", "AQAAAAIAAYagAAAAELgSvLbfDdscNVbI0vNjjpLs16zW/5laylhigm4esdHqtgG2XJhiyO07iZaIZr5NHA==", "a089aaf0-d9b2-40d0-afd2-2c67ffa3d857" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d9d4f261-d011-4523-a8a9-815e3002c7fb", "AQAAAAIAAYagAAAAEHW1neexTZoyTC469FRTcCBNhhtgmde860/ERhCSi2gpE37uuf6D85nn4yItVx9FJQ==", "3c297e9f-2232-42aa-a5e3-9759498a7e4d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c75d99a9-eb2b-4a67-ab6b-ad1496b879e6", "AQAAAAIAAYagAAAAEE38wg7NU5ns4oAzGkfnhPExthUqgsGbUi3nbsnFMxMBRIDQzjprBYxr2V23IHBYMw==", "6d3f7715-1fa6-45ba-b7b9-a32993ecb1ff" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b57d61d9-6de2-4747-bd1b-4da44de4d700", "AQAAAAIAAYagAAAAEC9mAgrne8v4EnsjQFf5iCAF1wMoT353l1VgMr0dKC+coLJA2ifYkamFg1NITae8mw==", "24ee0368-996c-4899-bdda-56c2489d0a53" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2ff07174-8fa1-4f1e-b57b-483a1bf21cf1", "AQAAAAIAAYagAAAAEPQhkktB3eSZOOAwOEeVE6ukPk7aLpVub0D1VN1TLDsoev8brXZRYqw68fWSPJ6HuQ==", "5ae1633b-8171-42dd-8d3b-002408131f46" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "572ead52-d79e-4203-b717-b37847a82143", "AQAAAAIAAYagAAAAEFXksW9SWt8Pj4GX2qepCljJ3QwufRIIv8L0OTaXwpmu94o8e5BTj8XN0artZG4OdQ==", "5a84eec8-97e1-42c9-b66c-1d4d1c713ad8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000034"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "35fafd24-6ae7-4f1d-a3a0-629b90af0629", "AQAAAAIAAYagAAAAEGAQlj0Y+AUuldeNmzMJxYt0PwNR89bCrCiOiqe8gWEryMo9738EmDmg9SJchln+kQ==", "ad6f5683-fafe-4b12-9c46-ca0e28942131" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000035"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "eb875a7e-be83-4309-a900-6c26e32929f6", "AQAAAAIAAYagAAAAEIzKx3piGHFeYuQ/uasfpgPxdQlRwgf6uuMV0dhi+1mSP4Wd17p4f63QZVrz9PM/9g==", "7b259bf0-94c2-423c-a8f2-3283cd596c86" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000036"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a28b2579-110c-4d0e-bfee-734036562381", "AQAAAAIAAYagAAAAEKlYbfa4uDxhothmPYOLmbHfwYoDtssh4UoVeuDtnrx6xESfDwrjOIWnD5BrdXfC5w==", "8ad9bd05-8585-4050-9dba-11a23e83b6bf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000037"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "646eec7e-f633-4ca5-8743-833ec30261db", "AQAAAAIAAYagAAAAEMZC8hETtcy+6WKRiKIlReiogANmS2YgelFrR8doamJ6genIojQfbZv+ZLg5wSNjCQ==", "dbc69ec3-c93e-457e-a4b1-2db0a8893d03" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000038"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00f1e187-6cd1-46ff-880d-a612e4480598", "AQAAAAIAAYagAAAAEKtx1VtHFeappcjRgTk/vvINc5AantCwneqhpEDmq4ZMQwCX6hInCZ/1wwDp3fNZ8w==", "4b688668-94c0-4eb5-86e8-c334ca19a159" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d914091c-feb4-47b7-81e2-2622e418172a", "AQAAAAIAAYagAAAAEGioNVRY/BSjvQiYNZSWQrcTviJoI7lNMru75gPj89mNznSyYRP7WlNID6esroboCw==", "d8dc7138-6680-4049-a4ad-e02ab16a361e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000040"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ec54d830-2bc1-4c7c-90cf-cec551dd75bd", "AQAAAAIAAYagAAAAEP0fSH2D6kLPFvjzRR41tD6BYeOn5kJbIZn5oSTi11vZL4Yi7XNhLMzIYScHNePseQ==", "b83f92bd-cf24-4755-8342-f88bdef42628" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000041"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "42c875f0-52fa-4565-9d24-e0115b3edf07", "AQAAAAIAAYagAAAAELJl3A7pZeOkX2WIIsiOSwdTNyvJkwx1oM8CTRWxFPRhcSY0kl0bqTJiosg2ANWaaw==", "3edc107e-9f68-481e-a608-843db2bb2cdf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000042"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3abc9f07-a1c4-4396-88f3-7459c0b04747", "AQAAAAIAAYagAAAAEGgDNOYYiotLRd9uup/ZjXWiA/1NYnB/yQhPig8vKRKjpwiVfaAiA9noMcFPtNdpPA==", "bc9ff19e-1203-49a2-968d-4325e460b77f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4078598d-7235-44ae-9a61-3af2fb406c72", "AQAAAAIAAYagAAAAEGGs7t/TohpyfO3eo1sToVoKqYxuOHwIHzMk3cy0n+HCpZRrfO9IJfOEtEuH+z9yUA==", "ca90070f-f1cb-4eea-a14f-e4bfd2461546" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "498473ce-8602-4333-a210-601bdea593d0", "AQAAAAIAAYagAAAAEORROonrALYT8J28iTNXUBA8vbKc9gXThErFrGltu56xS+dq+QZuayrOyoeJtS4mWw==", "e2f68c42-cb5d-4270-b597-96be55f8d699" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5769afc3-5c3b-4ddd-a0c9-becdf83cd9d0", "AQAAAAIAAYagAAAAEMsVmmgPie42ht30MvvBvUZ9RxYxkgB8oVHrXdJPWDWCFlLLO4Ciu5xEaOA0I6gQuQ==", "7f5cfffb-1550-46aa-b27a-7d48b8046f91" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99952957-430a-4ebd-ba7d-b16031d5435f", "AQAAAAIAAYagAAAAEPGWGMaVkqb4+qd5BcCQqV0gF5cKx1SbjpMuTo4zNayQ2tAf8NYbV8Uo9jqTAzhS5w==", "57f233be-30bc-477c-bf36-45be1112ac63" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0f39df06-69e2-485d-b45f-8410a0bbefcb", "AQAAAAIAAYagAAAAEHAdxu5Or3bkjTVTDBhoDSInEUSnffy2Wi4qU3lvu94KAWph72TahMG/BQoVnrDZfA==", "fe79ead8-a762-499f-8b0d-d6595bfd4091" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "854657e3-7a94-48ca-89fd-1229186fa499", "AQAAAAIAAYagAAAAEHy1Ov3+iD7hpT8WXvpSOQnUUADEVBOxdu9tohdMRwhDnihTB+6l457mzH1vPC05CA==", "e38db68c-6e55-4feb-ae51-aa8e1247efe1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "88a3e8c4-be02-4fa4-80ed-620387586ed8", "AQAAAAIAAYagAAAAEFC5zvdnVyo3DHhVNWjORQj+IgoopbxjHg2hxp+3iuRfjm0m7yzNjBEmT1DEp10jbQ==", "ffa2abea-de5d-4ba2-acb3-4cf036fc1c77" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bcfc3b17-1dbb-4785-9986-209d8de5ee1d", "AQAAAAIAAYagAAAAEO0HWFgbjGHAeI0IeZHFS5yCger7AsD+jNqEHShPKMN/2xHGeKKW+4S+Zx7u77z2fg==", "41cc3db6-8f35-45b4-bd15-14cef65ca8cf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "370129a2-eb80-4e19-a802-f3b961d02602", "AQAAAAIAAYagAAAAEHdz9VxnFMEwXQpSzDJ+XP+g2Hl54lbeLZPx57QFRJUb+eGKggEaPoMYpNhkxuUtEg==", "270d91d6-d10d-4270-b279-ec03671e2878" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9461205c-0f79-4dae-a59a-f8a2b9fb0935", "AQAAAAIAAYagAAAAEB9T7SWLhA1+fC7ApA1jYxO2jUYoXf7fQaHmcb02YChNh979IORkFx7vI4hqeLT+vw==", "d6066e96-9fcc-4629-bdbd-39715451d722" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2df49961-d469-4b89-8a88-5855a482c9ed", "AQAAAAIAAYagAAAAEI7vNCR1yrvURw5oD1Cbeul3y/yZSn+RtsU6tF4x3e+8L3oGuUSt/yqDxFzsn8GIRA==", "e096b922-11d1-4282-98ac-11a7a20e678a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "057b0e81-a06a-44f7-bcdf-6a618264d63a", "AQAAAAIAAYagAAAAEOiIXDclEhbHjXZbFCUaiLaZs04l8ms71zu2QXZ/NPcfekT44nGUSux56EijKQkI2A==", "47bf7ec3-9292-432b-b00e-901a065cb474" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "273decfb-31fd-4ec0-aa08-06c8aefb4b39", "AQAAAAIAAYagAAAAEACjhs4TbptcNDbO6hnLUFzCMBDaclkRp9heDbYwT8Q8jAP9QX6egY1usPdecC1ZvQ==", "01f61f9e-fecd-4114-b96e-4568295810a7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "107d38ad-d6bf-4a81-8cd0-a8570b56de17", "AQAAAAIAAYagAAAAELRYBG6gd3b7o12iBZMWlXrXPl7KJrFcUMgetqFUeIrSEgzHtNOfJpV7xnIwFE2PbQ==", "7b1cff35-671e-431a-a186-4279df3e4a09" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "41c1facb-7e3f-4273-9f93-2063efb83bff", "AQAAAAIAAYagAAAAEIik1K6XhCBhBTonc5jf3+1dUFbdpJ5M2bX43VhRqYtj48zDL8R384WbuQgbocxc8Q==", "794b4384-7c27-41bf-9e8e-fbf85df06ed2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "03861025-5cc0-4d5c-ac14-daad5f3f4306", "AQAAAAIAAYagAAAAEGFXGO0wRZrqT3Sj/5vZkInv9zFemsDGHltn0Q1V7HRsCh7JbbCv7m61RsFcHEkX6A==", "0be58a24-b3c2-44f1-87a6-f1243d989f87" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e1007cc2-93d8-4823-b216-2534b07da30e", "AQAAAAIAAYagAAAAEP9jlU02kPTTyQhhjhuQ9+ftX9LIycedi7BIwJRqY51GMaaCOYUOUW0psGGoz1OJyA==", "6cfd6fb7-47ac-4eda-9b00-417ea78b3671" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7d79afbe-0071-4cf4-aa59-500db07128ec", "AQAAAAIAAYagAAAAEIYVI1bNGtvIBJtbVhAqUVBYKu7QVL/CRCOQYzkOfh0Dj4I6bwPzR81ZDCNzCGi+0A==", "ac05a1f4-d51d-4bae-ad28-ace903f502d1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "423c7981-d127-41ec-8598-22ffbd78b525", "AQAAAAIAAYagAAAAECmcuVn+QHpvX/j4H6ppBRo0KFXL+4uB/3znAn2nnGXKf7R3PqOXjbtHb88dCJyNMA==", "7c4ee1df-1fdb-4045-b67d-5b3dc6cb4999" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "559e9b75-fdad-411e-b11b-da8382d9adde", "AQAAAAIAAYagAAAAENXRurA1Vf5qI6qjagY3IHOiACWtPp130t8O0J/yqsbO6uxmDaFmswfqW5sO929MFA==", "8734dc01-0014-4e7d-ac33-1c967b3e06e7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c791fafb-d89a-41e4-9c72-fedfd620c450", "AQAAAAIAAYagAAAAEPr3Kky3WOUcqW77ymO9w6MgNGwahfce06EhvGyccSDELKJowYvuVrjAHNUN5xn9/A==", "8aca6fb7-d2b6-4b48-95a8-6526f61fcb5c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7046be57-5409-44d4-a074-cf6374f9dcc5", "AQAAAAIAAYagAAAAEO5INX0QmFOVUaLsgzMxLVatzt8HEbBuOk8AMY43hrhwVf7hXKvPAIlAjLh1LAJfUA==", "5977e369-64e1-4b4b-b5eb-e9e0f76eca0e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd433cc-4576-448e-b011-1c17b5641d66", "AQAAAAIAAYagAAAAEMztdiH80oiu27UBNWxJEhnkjr89gGYJrPGVMMgxqfa+EMoKfxbS0PJ/tgTW4JwA0g==", "298e11ec-edec-4611-ae98-5881ef71f3cd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "59a910b7-3520-46b8-862d-813fafbb3ef5", "AQAAAAIAAYagAAAAEPxIHfkYvCH/1QzKC+nC11rxKQVJbhwIlqOCXGDCUZk+cpFlPBxTT5kKoa1lPy0Bog==", "02d09545-9b66-4cc8-aa37-d25ca3567e38" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3f83e5d7-07cb-41d5-8da9-a840f0037d88", "AQAAAAIAAYagAAAAEGzXSr1wVc3xpSGK5k9F1yGgIlNDt7xScP856dNkKkIBMNP07QTgdiZ3vumvz1iGlQ==", "5b338a66-4b09-4da3-9845-2ab9ec81933e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6689ab67-75cc-429a-b4b0-b9a55eb7dda2", "AQAAAAIAAYagAAAAEDutRTTutHYlDbQA3EWTgV8ZJpQBAcwEftTDj8j9PP9U6fDekwd549hkWUckciKFvA==", "49ffb3f7-ba7c-4831-8dc1-741b80bebe3a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2a4bce21-2ea5-4d8b-a688-52c66cdec326", "AQAAAAIAAYagAAAAEG8IzucUZG0yasW40oEjnY+EB7e2t+wRDqeYbMlopRBXXtu4Ia/3XYUs0613h52/Yw==", "0683771f-08fb-4fa1-aaee-1a73809027f3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5ba26cb8-31fe-4258-b6ad-a1a636d6134a", "AQAAAAIAAYagAAAAEKSRvaUYmNeMVZPn/0spD0F60yVcBiN4a6TftsHtEsab5brlvtbUUa+rQocx0yp8NQ==", "0430b71c-96ec-4021-b5ac-2405ba2f8cc3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "995fd7c2-84d0-4640-a767-d9cd433aa0e5", "AQAAAAIAAYagAAAAEF15mBj1GIqibV8gPY88fmNyUauVtaIPjwXVWd6XW/lROsEKAlwObAi/c15i1eERCA==", "8ef65a39-916f-4ae1-99ba-6db969eda604" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c0dde647-a124-4e1f-be56-6636cea1432d", "AQAAAAIAAYagAAAAECCI6EW7vEQXNAakzske6b2H5p0EVz8jiJWKjaZire4gzyLPDSAHqDkdYAYzs3Q/hA==", "d97af27a-9506-4007-9d3d-ae36371e19cd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "38d02d19-6ca5-4400-be66-490361c08d8c", "AQAAAAIAAYagAAAAEEPWCLQwyNYINLu2aR4zKE23qt3VdL3/SSpruHDbLDfOTKkUXyMjmZ96S1MDStXr+g==", "0077c7dc-d25c-411e-be06-62913d9fe04d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "322313f1-1e8a-4072-9e66-913eb5bbeabb", "AQAAAAIAAYagAAAAEAyp5GjvDTS/UhH+QWA7LF85A3FBGVn/wby1wnS25NMIjL4v5f1vTIVD5FE1hJyC5A==", "fb72aa0e-f973-4b2f-9edc-f97fedab3a35" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c4d519ff-cb51-4f91-a577-b66ba975e75d", "AQAAAAIAAYagAAAAEFn8FffIlzpTLD7cHJE4mbkuhUH8mXWGeRnucotZWdScZvJvr6RgHl4HTSvISq2k1w==", "d80f7b3b-8f70-4408-8ebc-0a3f3cc99db8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fade632a-3ff1-4f57-9c93-f5fabc18c5ba", "AQAAAAIAAYagAAAAEJ0iPCIuM8OflRJz1a7yVbx3eD9tt4Tz/ADss8VLBcxv0SbuX/MPHIgi96XpTigCRg==", "4dda6cfa-a692-4de7-95ee-0b428fd5f45e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5eb07ed3-85c6-4ed1-921d-831a98f97597", "AQAAAAIAAYagAAAAEJjFF9grnKk52W9i7VyAxTJCNnZhDrVtoVfQmKd/a44X2nVV8xKRp0/aJ/d3udPiIA==", "e26113c6-c3ef-4cfe-8e2d-8bdf21d086e8" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "98338581-e42b-4a5e-baa7-be11be07ce80", "AQAAAAIAAYagAAAAECaUAMMdkKOFGVFn8qMeKDzxcPGf98JdB3o/MXPLi0JUAeFwkuM4rrqvP356jkgM6A==", "e83c9d1f-90fa-4ce2-b686-3692f385617b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cca0ba37-f03f-410a-8e56-7d967a6e4aa2", "AQAAAAIAAYagAAAAEKEjcRT8zIqdpMIeEAwQUpEct8u6R5mFwUOT3KUJoIfDHQlyG0pY9kUMtTn1BSRoVg==", "5dea4a10-8717-4229-9634-19acf6b77270" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "27a6d94a-f244-49c0-a42e-c30f6cff280d", "AQAAAAIAAYagAAAAEE4rpLfdCuw16xWY5j9YnPlX4Z2FgJB0eywswpuuHLJM6BVrvg8JQBGFH9E+IVFEow==", "0b53686b-38be-45ed-8ceb-bff7fd87dc7c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e3f1751d-9d07-491c-9b22-9d3bbc719f2e", "AQAAAAIAAYagAAAAEFMof6Hp5Tr2Yfq12d1xgtfuWJEfjUDGMWDiEg/0rRTik3fwXeViz8k1auFP6HqNXA==", "5cdc7faa-ce12-4344-964a-b3de478525ad" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "40b68f01-1a5c-4b9a-ad67-b5636279ad0d", "AQAAAAIAAYagAAAAEE1WLMh0fSbuDrUogdJ/UCvp7kk7zlzZSSYXrOod2wQJ6ChRtc8Yy+MYJQil1qbidw==", "4e1af2fd-f135-4306-956e-c59f7653d6c1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3a0c4090-8328-44f2-9bd4-8cc01e4a991c", "AQAAAAIAAYagAAAAEEBQur0Cxg3ZKp6BaB4JDrA2MesrzhhKtSgYKXhd94o9nOtuaw6zVQCQRT+AmYXBZA==", "2ae9d65b-0044-4250-8651-c2de04bec65d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "97c3f4d9-46d2-4cbf-a5ed-fe9f379b444a", "AQAAAAIAAYagAAAAEDkoLvzQUILtx9JSOwsUuxAsOH01IWaEKBwBsDa1eliPautn5HpyyrLEfSAd3hsT8A==", "a1b1437b-d7d7-4b9d-a14f-04e24f3d6674" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "df18fd54-9d85-4832-ac14-40d8a485ce86", "AQAAAAIAAYagAAAAEAO3O16w7s3K+HC3Y/lPCLOgWejrkYEzXsfQ7xmaqiCYFEy7UA4MLmmsHI+ElBehSg==", "74f8e519-e0f0-49de-af29-dbe47d06a73a" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9921), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media\\u0026token=d34657e1-2aae-4b60-a825-a7319b98235b\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9880), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche1.jpg?alt=media\\u0026token=e454fa0e-1e95-4b66-9d28-d9de2bf107d0\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9915), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdulich1.jpg?alt=media\\u0026token=d95f8ea1-e72d-4d74-ace7-defb632ef2a8\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9851), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdau%201.jpg?alt=media\\u0026token=37e256ac-3428-4dde-9923-a4ab34d79416\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdau2.webp?alt=media\\u0026token=60ffaa7a-600a-41f6-9997-b01f487965a3\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9925), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media\\u0026token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9900), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media\\u0026token=d34657e1-2aae-4b60-a825-a7319b98235b\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9893), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media\\u0026token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9918), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftrongcay1.webp?alt=media\\u0026token=cbaae9c7-aa33-4943-a297-b1e3d2f95d58\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9867), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua1.jpg?alt=media\\u0026token=680679bc-ae88-495c-b39b-35205cdca5c1\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua2.jpg?alt=media\\u0026token=29672e8d-f9af-4be5-aa8c-9e7922fa3a9f\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9928), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media\\u0026token=26a27576-3ee8-45e5-b4bd-0dfbac591c77\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9937), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcachua1.jpg?alt=media\\u0026token=13165082-87a3-46d1-bc9c-8d08acebc905\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9940), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvatsua1.jpg?alt=media\\u0026token=680679bc-ae88-495c-b39b-35205cdca5c1\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9944), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media\\u0026token=9500933b-9b09-4e07-a3b7-8d3899347fe7\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9947), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Flua.webp?alt=media\\u0026token=2c6a3258-acda-42d4-8a5a-9122a700047a\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9951), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche1.jpg?alt=media\\u0026token=e454fa0e-1e95-4b66-9d28-d9de2bf107d0\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9954), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftra1.jpg?alt=media\\u0026token=d4fa66e3-818a-4641-a3d8-95f75b586fa5\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9957), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media\\u0026token=c9a1233d-7fd4-485b-92af-2d662e830cae\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9991), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fbacthang.webp?alt=media\\u0026token=1090ca2a-4ec4-4de7-99cf-316da2719b9d\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9995), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam1.jpg?alt=media\\u0026token=0c350e96-b627-4792-87e7-45d0502309e4\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9998), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media\\u0026token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 438, DateTimeKind.Utc).AddTicks(1), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdibo1.png?alt=media\\u0026token=85dab42a-d4de-4155-b10f-dcb86020ddbd\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 438, DateTimeKind.Utc).AddTicks(4), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fvuon1.jpg?alt=media\\u0026token=bca13e04-6ddc-4abc-aeea-ceb3544c67c4\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 438, DateTimeKind.Utc).AddTicks(8), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fgiay1.webp?alt=media\\u0026token=8d97fe12-81fb-4baf-bca6-2310db5d10a6\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 438, DateTimeKind.Utc).AddTicks(11), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fsinhthai.jpg?alt=media\\u0026token=e9eca292-9a58-49e7-851a-985a7c2fcc99\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 438, DateTimeKind.Utc).AddTicks(14), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media\\u0026token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 438, DateTimeKind.Utc).AddTicks(17), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media\\u0026token=c9a1233d-7fd4-485b-92af-2d662e830cae\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 438, DateTimeKind.Utc).AddTicks(19), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcho-vung-cao.jpg?alt=media\\u0026token=fb63de66-558d-4ab7-8aae-829750571863\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 438, DateTimeKind.Utc).AddTicks(22), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau2.jpg?alt=media\\u0026token=146de905-406d-4ef8-8ddd-8aa978e38123\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 438, DateTimeKind.Utc).AddTicks(26), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnauan.jpg?alt=media\\u0026token=e6a04105-384e-4ab5-a0f0-f7e0b105f1af\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9960), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk2.png?alt=media\\u0026token=c9a1233d-7fd4-485b-92af-2d662e830cae\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdulich1.jpg?alt=media\\u0026token=d95f8ea1-e72d-4d74-ace7-defb632ef2a8\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9964), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media\\u0026token=9500933b-9b09-4e07-a3b7-8d3899347fe7\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9971), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdangian.jpg?alt=media\\u0026token=7df3d302-ee8c-454b-a2b6-36951632720a\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9974), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fdet.jpg?alt=media\\u0026token=648cbac8-add0-4056-a2a3-44d5241ed9ed\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9978), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fk1.jpeg?alt=media\\u0026token=d34657e1-2aae-4b60-a825-a7319b98235b\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9981), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media\\u0026token=26a27576-3ee8-45e5-b4bd-0dfbac591c77\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9984), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fsinhthai.jpg?alt=media\\u0026token=e9eca292-9a58-49e7-851a-985a7c2fcc99\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9987), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcheche1.jpg?alt=media\\u0026token=64da9bd9-51f5-4a9b-9c9f-64a1ed56bb96\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9872), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau1.jpg?alt=media\\u0026token=26a27576-3ee8-45e5-b4bd-0dfbac591c77\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Frau2.jpg?alt=media\\u0026token=146de905-406d-4ef8-8ddd-8aa978e38123\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9888), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhaiche2.webp?alt=media\\u0026token=0275c711-2581-48c0-9e13-bcc383b8cfe2\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9896), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Ftra1.jpg?alt=media\\u0026token=d4fa66e3-818a-4641-a3d8-95f75b586fa5\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9912), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fhop1.jpg?alt=media\\u0026token=9dd3a3ac-52cb-4632-81aa-91a90dec35d0\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9907), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam1.jpg?alt=media\\u0026token=0c350e96-b627-4792-87e7-45d0502309e4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fnam2.jpg?alt=media\\u0026token=04893537-abb2-4936-ba89-6e26b4b54aea\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9904), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fcachua1.jpg?alt=media\\u0026token=13165082-87a3-46d1-bc9c-8d08acebc905\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9875), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Activity%2Fthuong-thuc-dac-san-tai-moc-chau.jpg?alt=media\\u0026token=9500933b-9b09-4e07-a3b7-8d3899347fe7\"]" });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(2946), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fe1.jpg?alt=media\\u0026token=f05fa6e1-5083-45d9-a750-7ee06162c520\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fe2.jpg?alt=media\\u0026token=53afdfbf-5507-47ee-85d1-ec8442304f7e\"]", 13800000.0, 10100000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(2952), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ff1.jpg?alt=media\\u0026token=37caad37-477d-4e55-873f-2440551d954a\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Ff2.webp?alt=media\\u0026token=a23fd593-3c32-4b72-9ab8-c74e86fa3368\"]", 18900000.0, 10300000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(2957), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fg1.jpg?alt=media\\u0026token=40bc8d8a-10a4-4a6b-a852-bd1ab79ae219\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fg2.jpg?alt=media\\u0026token=7d24a17f-5853-4bea-9aa3-488b283393ee\"]", 14200000.0, 10100000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(2962), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fh1.jpg?alt=media\\u0026token=835dc28e-4ea6-4e76-83e4-36591a577988\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fh2.png?alt=media\\u0026token=162ac610-9f4f-4b8e-b8b7-c16c83f500e1\"]", 19000000.0, 11100000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(2966), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fi1.webp?alt=media\\u0026token=d6f2d4c0-4439-4e9e-afd8-ef36d378a6c4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fi2.jpg?alt=media\\u0026token=76d6c2e9-fe9d-4f4a-abed-55e622effe0a\"]", 10200000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(2971), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fk1.jpg?alt=media\\u0026token=8a1b82a5-d372-49c8-9437-ba1d221ebe90\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fk2.jpg?alt=media\\u0026token=1c08d579-60fe-4071-89fd-b58683ee5388\"]", 17900000.0, 11600000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(2921), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa1.png?alt=media\\u0026token=0e6e621f-912a-4639-a51a-e94e183b95e8\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa2.jpeg?alt=media\\u0026token=8159822e-9515-4532-9531-10c21c397218\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fa3.webp?alt=media\\u0026token=d7b91ee8-ad6c-4ffa-a979-bcf01709d2c1\"]", 10800000.0, 11400000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(2936), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc1.jpg?alt=media\\u0026token=e320026b-8c15-4ca0-9570-1c7f641c3b44\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc2.webp?alt=media\\u0026token=52f3e890-c777-421b-ba33-640a7c6b21b4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fc4.jpg?alt=media\\u0026token=73e89a47-6420-43cd-8bd9-6cc18e3771c5\"]", 19200000.0, 10300000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(2930), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fb1.jpg?alt=media\\u0026token=0baec450-2c25-49fe-b319-360b3f146c89\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fb2.jpg?alt=media\\u0026token=c93ad47c-b5fd-4864-ac53-6bf579f2e5ef\"]", 17700000.0, 11700000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(2942), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd1.jpg?alt=media\\u0026token=de1ecc18-0ac0-424c-93e9-5fb18a05cbc4\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd2.jpg?alt=media\\u0026token=1bb550da-3a3b-4742-b23c-4075a45c7c0b\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Tour%2Fd3.png?alt=media\\u0026token=067466e8-32b9-427a-a2c6-739358f95017\"]", 17400000.0, 11800000.0 });

            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "BankAccountId", "AccountName", "AccountNumber", "BankName", "BranchName", "CreatedDate", "IsPrimary", "OwnerId", "OwnerType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("06694bb8-2c8e-48b4-8a5c-55c529a2569e"), "Hanoitourist", "0011005938546", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3612), true, new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), 0, null },
                    { new Guid("06b2de2a-b19f-4e58-a7d9-109c6dd1e286"), "Sa Pa Eco Farm Tour", "0011001268128", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3526), true, new Guid("10000000-0000-0000-0000-000000000002"), 1, null },
                    { new Guid("0b681cd5-5dec-4892-9163-bbd950a33fba"), "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", "0011004745977", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3509), true, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null },
                    { new Guid("0bf4f7d2-6aab-4f9f-8e82-661a006966e0"), "Vũng Tàu Travel", "0011009799237", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3641), true, new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), 0, null },
                    { new Guid("2e25a6d8-38f7-4520-ba6e-ccba07fd2f55"), "Trang Trại Nông Sản Sạch Tân Châu", "0011008397349", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3557), true, new Guid("10000000-0000-0000-0000-000000000011"), 1, null },
                    { new Guid("362e4f46-ed52-4a80-ae06-cb07489cd671"), "Công ty Cổ phần Vietravel", "0011001094945", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3606), true, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0, null },
                    { new Guid("3a9f79a6-43ec-4609-8d3f-b904e746403d"), "VietSun Travel", "0011009789431", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3620), true, new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), 0, null },
                    { new Guid("3c0cf3a1-669e-4b43-af73-a316ed96b5d9"), "Hà Giang Farmstay & Trek", "0011001109847", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3545), true, new Guid("10000000-0000-0000-0000-000000000006"), 1, null },
                    { new Guid("43da0f04-56fc-4851-b965-08c69bb88a86"), "Danang Travel", "0011005109758", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3617), true, new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), 0, null },
                    { new Guid("5030e2a0-aee4-4a59-8d35-5cf4fb633b93"), "Nha Trang Holiday", "0011002349933", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3643), true, new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), 0, null },
                    { new Guid("5d8feedc-c316-4c96-919e-c445c39f259e"), "Phương Nam Travel", "0011009316234", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3625), true, new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), 0, null },
                    { new Guid("6703d572-1b5f-4176-ada5-90208a355964"), "Trang Trại Châu Đốc", "0011003238666", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3567), true, new Guid("10000000-0000-0000-0000-000000000015"), 1, null },
                    { new Guid("6b683fc1-4f8c-4c61-90d9-a2666a4f11c9"), "Farmstay Nho & Thanh Long Bắc Bình", "0011006616601", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3553), true, new Guid("10000000-0000-0000-0000-000000000009"), 1, null },
                    { new Guid("77baa1f5-3292-48ab-bb36-930192cdb930"), "Ba Bể Lake Ecofarm Tour", "0011001813833", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3555), true, new Guid("10000000-0000-0000-0000-000000000010"), 1, null },
                    { new Guid("77e36a82-af44-4f46-b4b2-3c72a6193581"), "Nông Trại Chè Trải Nghiệm Đại Từ", "0011008589663", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3532), true, new Guid("10000000-0000-0000-0000-000000000004"), 1, null },
                    { new Guid("7a0e133f-fe1e-4af0-88a3-0e82ea2e2b6d"), "Đất Việt Tour", "0011004616856", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3627), true, new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), 0, null },
                    { new Guid("8c3658b6-601a-4f34-a863-6073ad15f011"), "Fiditour", "0011004296256", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3614), true, new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), 0, null },
                    { new Guid("995289b2-f646-4875-be92-fab4e7e59e49"), "Dulichtoday", "0011006377672", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3636), true, new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), 0, null },
                    { new Guid("99ff70fb-a892-49db-a9b9-07fdbe6a4b09"), "Buôn Đôn Coffee Farm Tour", "0011004726042", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3536), true, new Guid("10000000-0000-0000-0000-000000000005"), 1, null },
                    { new Guid("9b5a041f-5d38-46af-937f-4af541c62bad"), "Havatravel", "0011003862779", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3638), true, new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), 0, null },
                    { new Guid("b2fd9f4c-45bc-4050-a3cb-230ad54d5930"), "Mỹ Xuyên Farmstay", "0011005280074", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3565), true, new Guid("10000000-0000-0000-0000-000000000014"), 1, null },
                    { new Guid("b37a7207-3725-4183-ac08-e59cbf973c0f"), "Trang Trại Nông Sản Sạch Càng Long", "0011005169324", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3562), true, new Guid("10000000-0000-0000-0000-000000000013"), 1, null },
                    { new Guid("b9937dff-a088-45ce-a9ce-bfa4386d1dd4"), "Saigontourist", "0011007786473", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3610), true, new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), 0, null },
                    { new Guid("c103cb84-8077-43bf-aaeb-acd31656d0b2"), "Phan Thiết Tours", "0011004328451", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3646), true, new Guid("22275542-0625-47be-a503-2f13b7576e9b"), 0, null },
                    { new Guid("c586039f-30c3-4e87-8827-d9dfd6eaf6e7"), "Farm Du Lịch Grape Valley", "0011001554469", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3528), true, new Guid("10000000-0000-0000-0000-000000000003"), 1, null },
                    { new Guid("c70b8eac-cd6d-4986-9abe-36d95232ca8a"), "Redtour", "0011004804044", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3630), true, new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), 0, null },
                    { new Guid("c7467802-65da-40c3-87d9-ab05256a43aa"), "Bamboo Travel", "0011005797829", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3623), true, new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), 0, null },
                    { new Guid("ca461d48-95b8-40f8-86cc-728357dea0c8"), "Du Lịch Sinh Thái Thác Bản Giốc", "0011008703127", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3523), true, new Guid("10000000-0000-0000-0000-000000000001"), 1, null },
                    { new Guid("db690b87-e164-472e-97d8-97ea9775e71b"), "Trà My Sâm Ngọc Linh Tour", "0011002303223", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3547), true, new Guid("10000000-0000-0000-0000-000000000007"), 1, null },
                    { new Guid("f61351cd-88cb-4e2f-b4e8-4b3b669fc1bc"), "Đà Lạt Organic Farm Tour", "0011006120790", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3549), true, new Guid("10000000-0000-0000-0000-000000000008"), 1, null },
                    { new Guid("f94c1fc8-3a44-413b-931d-c91161f2bf60"), "Trải nghiệm Nông trại Biển & Rau Tuy An", "0011002309239", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3560), true, new Guid("10000000-0000-0000-0000-000000000012"), 1, null }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("21312108-51df-470b-b158-c07116e95983"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fdsc4926-1737442964915949022440.webp?alt=media&token=f4a50238-d2f3-4032-ba89-65c47093ac0a", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("434bffb0-0735-4499-9928-b0447a24ac23"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fz4892392984516_d64f19ae34659675050a19405d2f2f06_20231118151316.jpg?alt=media&token=88ce1721-d11a-4f70-975f-8159879d38af", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("476ea657-6bdb-4020-9aae-be2fb9c17aec"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F0-2346.webp?alt=media&token=60da574f-ccd0-4e3d-9bf6-74a1c6a64728", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("52bf3b53-1a47-45c9-8377-721db71ac554"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2007lamdong1-1689837807306-16898378088711727831861.jpg?alt=media&token=17bcc062-4fb7-4996-8108-5b6f6ff9809a", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null },
                    { new Guid("6b55c40e-b629-463a-978a-99681e097e9f"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Ftet-2.jpg?alt=media&token=6d28efb3-2ed9-4ca9-907e-de6b6c190a5f", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("6d275d54-4511-4dd4-9f58-016aef3cbca3"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F1110.binh-lieu.jpg?alt=media&token=98060066-e58f-4a1d-929f-76c2f4017475", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("9c3f0f41-cee7-44f3-829c-9e9f6b7de239"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2273623_quang_canh_khong_gian_chinh_to_chuc_le_hoi_14003627.jpg?alt=media&token=4023df7a-8efc-4de0-b6dd-b5cdfa0af4d0", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("af8743c1-3866-4c87-9cac-56e1e61bd097"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fbemacatf_2929-(1).jpg?alt=media&token=cccce681-3652-4a07-a2ff-b972392c84da", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("bae20bb7-25e3-406e-ba9d-d62116776451"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F114885_LTT_4830.jpg?alt=media&token=50e303f4-7cc3-42c1-a79e-f5041a1d4389", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("d6a4a202-dd71-4b0d-9bb9-91990208b5ae"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F185215_1-dongnai02.jpg?alt=media&token=6641c733-758a-4e47-a816-f18757f3d646", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("e19586a3-e756-4237-83fd-1b678399983a"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2101.hoabinh.jpg?alt=media&token=9da1280b-fca0-48a3-aacb-a8598212f33c", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("fa185d2c-4595-48f6-97c5-c30a04a93ebd"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2.jpeg?alt=media&token=8dc70894-e01b-4caf-83dd-68dad34318c2", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("024aa355-e88e-44e6-807c-b8ca561a6110"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9607), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9606), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9606), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("233fdfc2-8fd6-4a60-9ff8-4dc9c6c0278d"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9591), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9590), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9590), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("41db84d2-8d3f-4a72-8709-54e4cbbc4a44"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9611), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9611), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9610), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("57289425-b33e-46c3-9ee5-1ce8a94fe0ab"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9586), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9585), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9584), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("5f3f76f2-1fd2-47a7-b8cc-23b73061c174"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9579), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9578), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9578), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("67ac9dc5-cde7-433b-9157-5a3cae48f20e"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9620), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9619), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9619), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("a0004bd1-a352-4694-b8e0-9aca56dfa0c4"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9596), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9595), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9595), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("ccc6834b-6e3e-43ba-9cce-fd18764707aa"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9602), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9601), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9601), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("d34a6856-fa4f-4690-8d9b-9ed4a0071a42"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9616), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9615), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9615), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("e2c01078-fc38-4d48-89eb-e2823aa0fc7c"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9624), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9622), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9622), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "Contract",
                columns: new[] { "ContractId", "ContractContent", "CreateDate", "DiscountRate", "EndDate", "RequestReSignContract", "SignedDate", "SigningStatus", "StartDate", "Status", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("10cd3622-6df0-4376-a435-820434e15e72"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3801), 0.04m, new DateTime(2027, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3800), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3799), null, new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), null, null },
                    { new Guid("2614aadf-a2d7-4168-8d51-0eedb9b15863"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3850), 0.03m, new DateTime(2030, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3850), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3849), null, null, new Guid("10000000-0000-0000-0000-000000000013"), null },
                    { new Guid("2a27d80e-8a1d-4c52-b95d-d9a27ab15ed3"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3776), 0.03m, new DateTime(2028, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3775), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3774), null, new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), null, null },
                    { new Guid("2dd31076-5c92-4beb-9202-b7635593293e"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3831), 0.01m, new DateTime(2027, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3830), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3830), null, null, new Guid("10000000-0000-0000-0000-000000000005"), null },
                    { new Guid("376521dd-ab6c-4d3e-95f8-7106c1cc7818"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3811), 0.01m, new DateTime(2027, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3810), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3810), null, new Guid("22275542-0625-47be-a503-2f13b7576e9b"), null, null },
                    { new Guid("37e1219f-4cf2-49d6-b673-9b54c299cf92"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3781), 0.01m, new DateTime(2027, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3780), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3779), null, new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), null, null },
                    { new Guid("3bde7816-b557-4197-adc6-7334e3dcd28e"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3829), 0.05m, new DateTime(2030, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3828), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3827), null, null, new Guid("10000000-0000-0000-0000-000000000004"), null },
                    { new Guid("43c3af8c-cf70-4c74-9cbd-6781fce6c859"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3795), 0.04m, new DateTime(2028, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3794), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3794), null, new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), null, null },
                    { new Guid("4bbb82f2-bac0-48a4-85c9-8acc5352760c"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3834), 0.02m, new DateTime(2026, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3833), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3833), null, null, new Guid("10000000-0000-0000-0000-000000000006"), null },
                    { new Guid("4d0ab542-c214-4258-a999-89a407e3e7fc"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3859), 0.04m, new DateTime(2028, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3858), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3857), null, null, new Guid("10000000-0000-0000-0000-000000000014"), null },
                    { new Guid("4e81641e-9816-4eff-aaca-a04486e61c71"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3817), 0.01m, new DateTime(2029, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3815), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3814), null, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("53c29caf-d463-449d-9225-0d10348000c9"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3778), 0.03m, new DateTime(2028, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3777), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3777), null, new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), null, null },
                    { new Guid("693963de-8395-47d4-aaf0-5ba25e7ce492"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3826), 0.04m, new DateTime(2028, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3825), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3825), null, null, new Guid("10000000-0000-0000-0000-000000000003"), null },
                    { new Guid("6f0019b3-42ae-418b-8934-691e7495ca80"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3861), 0.05m, new DateTime(2028, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3860), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3860), null, null, new Guid("10000000-0000-0000-0000-000000000015"), null },
                    { new Guid("775aea43-88b9-49a1-bdaa-519bcc764b25"), "Thỏa thuận hợp tác phát triển sản phẩm du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3805), 0.04m, new DateTime(2027, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3804), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3804), null, new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), null, null },
                    { new Guid("7928b5cc-a4a4-49aa-8003-dd16e8115a06"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3788), 0.03m, new DateTime(2029, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3787), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3787), null, new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), null, null },
                    { new Guid("8117da00-ca56-44af-87c1-3ed1f582a408"), "Thỏa thuận hợp tác phát triển sản phẩm du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3791), 0.04m, new DateTime(2027, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3790), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3789), null, new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), null, null },
                    { new Guid("8a69f6b8-ad11-4ce9-a1e4-6030453a90e6"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3844), 0.03m, new DateTime(2028, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3843), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3843), null, null, new Guid("10000000-0000-0000-0000-000000000010"), null },
                    { new Guid("9d926a4a-b1c3-4cd8-883d-3a79743d4a69"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3803), 0.02m, new DateTime(2030, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3802), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3802), null, new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), null, null },
                    { new Guid("9ff8d09e-57f4-4601-8779-03cf9710e1ba"), "Thỏa thuận hợp tác phát triển sản phẩm du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3793), 0.04m, new DateTime(2029, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3792), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3792), null, new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), null, null },
                    { new Guid("a0822ac9-c994-425d-8cfa-8708a16f0ca2"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3842), 0.02m, new DateTime(2027, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3841), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3840), null, null, new Guid("10000000-0000-0000-0000-000000000009"), null },
                    { new Guid("a98803af-c282-415a-992d-076e5c168d28"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3783), 0.04m, new DateTime(2026, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3782), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3782), null, new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), null, null },
                    { new Guid("b16ad767-cb4d-47b8-afea-ddf5d2daa28c"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3808), 0.04m, new DateTime(2027, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3807), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3807), null, new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), null, null },
                    { new Guid("b6588720-975d-4567-9b75-52523e30e13c"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3824), 0.02m, new DateTime(2027, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3822), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3822), null, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("c0e3e50e-c003-45f6-87a4-c76146442753"), "Hợp đồng cung cấp dịch vụ hướng dẫn viên", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3839), 0.05m, new DateTime(2026, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3838), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3838), null, null, new Guid("10000000-0000-0000-0000-000000000008"), null },
                    { new Guid("c413675c-2612-4cb7-a8d9-bf1a6c162180"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3820), 0.01m, new DateTime(2030, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3819), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3819), null, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("c7aef0c3-f0f8-4ceb-9157-a197f527093a"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3766), 0.01m, new DateTime(2030, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3746), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3745), null, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, null },
                    { new Guid("d242fb43-f60d-4812-8e4f-759faed2dd6e"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3848), 0.05m, new DateTime(2029, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3847), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3847), null, null, new Guid("10000000-0000-0000-0000-000000000012"), null },
                    { new Guid("d7ac1c26-e788-45e4-bad3-ecc65a1c7aca"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3798), 0.02m, new DateTime(2030, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3797), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3797), null, new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), null, null },
                    { new Guid("dfab1921-7870-4580-999b-3c7a197366ac"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3837), 0.03m, new DateTime(2028, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3836), null, null, 1, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3836), null, null, new Guid("10000000-0000-0000-0000-000000000007"), null },
                    { new Guid("e534b879-1351-4a24-9023-cb3b28267d3d"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3846), 0.02m, new DateTime(2028, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3845), null, null, 0, new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3845), null, null, new Guid("10000000-0000-0000-0000-000000000011"), null }
                });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Xe-Khach-Hyundai-Universe-45-cho-4.jpg?alt=media\\u0026token=230f0598-5950-42b2-be2b-8bf65ac29074\"]");

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "ActiveStatus", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("01d6f6b3-0c26-4cf1-a7f6-3aa372e564bb"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9366), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 40000.0, 1000.0, null },
                    { new Guid("07593e32-5916-495b-b68b-a9eeaeb69272"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9389), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 80000.0, 1000.0, null },
                    { new Guid("18163aef-0a3b-4bfd-9209-952495d888e1"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9414), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 60000.0, 1000.0, null },
                    { new Guid("18ad7bc6-3d0b-4249-af79-c8f18679f59c"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9384), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 90000.0, 1000.0, null },
                    { new Guid("251ded14-0f34-44a4-b2a6-3ff5a360ad82"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9372), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 40000.0, 1000.0, null },
                    { new Guid("447c4bb8-654c-4237-a740-78b05d696c61"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9463), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 130000.0, 1000.0, null },
                    { new Guid("46242565-0f4f-40cb-badf-c8b7e2228429"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9408), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 60000.0, 1000.0, null },
                    { new Guid("47bdd2d1-ea93-4c83-99a2-b8fd74e14dbb"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9335), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 92000.0, 1000.0, null },
                    { new Guid("48b02f36-1ea4-482b-b13e-e50cbcf80492"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9501), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 70000.0, 1000.0, null },
                    { new Guid("4ca54037-c670-4532-bcc1-53aed519bcf5"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9395), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 90000.0, 1000.0, null },
                    { new Guid("4d3a7648-6e8c-4ba0-b5ed-32e9baaf96ea"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9329), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 92000.0, 1000.0, null },
                    { new Guid("50a6724f-7218-4b87-b2a6-796292fb75d9"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9432), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 90000.0, 1000.0, null },
                    { new Guid("5171d726-a0ce-41b8-a0c1-0b4e43d90a7f"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9323), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 87000.0, 1000.0, null },
                    { new Guid("58d93b89-14b2-4e31-9e4e-2cf0ffedf8f7"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9317), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 85000.0, 1000.0, null },
                    { new Guid("64c736cb-b57c-4d5f-bc28-bb8fc21b0486"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9341), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 92000.0, 1000.0, null },
                    { new Guid("68f42cb3-62cc-40b5-a8d9-8ea87582736b"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9482), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 80000.0, 1000.0, null },
                    { new Guid("731bc299-4752-4ffb-a577-3b1a9a9f9e00"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9438), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 10000.0, 1000.0, null },
                    { new Guid("7c0476ee-f08b-41c3-875a-aa57cee35122"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9310), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 87000.0, 1000.0, null },
                    { new Guid("8459781d-3ce0-44f5-afbf-a1fb6af5eede"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9426), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 130000.0, 1000.0, null },
                    { new Guid("85dcb813-8522-409c-a9d3-ba8152cd84d9"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9506), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 10000.0, 1000.0, null },
                    { new Guid("903b7ef9-ea33-4186-abf9-01805d592b04"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9512), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 110000.0, 1000.0, null },
                    { new Guid("9b03f04c-53d2-471b-856b-8975532143e7"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9402), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 40000.0, 1000.0, null },
                    { new Guid("9dbacc58-a4b8-423c-ae4e-40cfee5c5bfc"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9360), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 120000.0, 1000.0, null },
                    { new Guid("aaecc821-4304-415e-9039-4730d89bc27a"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9354), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 10000.0, 1000.0, null },
                    { new Guid("abcfde0b-f480-45a0-9cfa-5d9946e6b179"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9347), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 120000.0, 1000.0, null },
                    { new Guid("b625565e-a114-4446-96b4-ac88647e67aa"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9488), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 10000.0, 1000.0, null },
                    { new Guid("b7b57156-fa30-4f0b-b09e-58ed3e5833e1"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9518), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 110000.0, 1000.0, null },
                    { new Guid("b9689b1e-dab3-4276-96d0-9e581e8bf3ce"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9420), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 10000.0, 1000.0, null },
                    { new Guid("c4e1930e-350b-4044-a68a-73b3c495792d"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9457), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 70000.0, 1000.0, null },
                    { new Guid("cadd7551-59d6-4987-a621-6f6fac413f3a"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9451), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 130000.0, 1000.0, null },
                    { new Guid("daefa7a2-41bf-416e-8e0b-1600e5a5f2c3"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9475), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 80000.0, 1000.0, null },
                    { new Guid("db6b9af2-ad65-4d4d-83a4-fe0e6641d17a"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9302), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 85000.0, 1000.0, null },
                    { new Guid("ddb49b28-d562-4318-b005-ef9767c0bd38"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9444), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 10000.0, 1000.0, null },
                    { new Guid("ef9a1850-3641-41d7-9f04-f2f1024825fb"), null, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9469), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 70000.0, 1000.0, null },
                    { new Guid("f0a77de6-bf0f-4be3-a311-eedd1ab72ad8"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9494), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 110000.0, 1000.0, null },
                    { new Guid("fed9cfce-37de-4765-b04a-e4547775e481"), true, new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9378), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 120000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("20000000-4444-0000-3333-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9173));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9147), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fsua_moc_chau.webp?alt=media\\u0026token=0bee6dea-0373-4832-a59b-75385e0bf2a6\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fsua_moc_chau_2.webp?alt=media\\u0026token=64822296-e84f-4e59-b2fe-fabe2df2e6b7\"]" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9102));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9129));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9134));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9119));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-7776-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9165));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9108));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9125));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-4445-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9169));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9153), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Frau_cai_moc_chau.jpg?alt=media\\u0026token=7806aa89-1434-4973-a4c4-f75157dc263f\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Frau_cai_moc_chau_2.jpg?alt=media\\u0026token=9d619514-84e3-427a-ba7c-6b56cafb24ba\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Frau_cai_moc_chau_3.jpg?alt=media\\u0026token=01deb8a8-a991-4ec5-bc40-818fa56f80b2\"]" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9091));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9158), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdac_san_moc_chau.png?alt=media\\u0026token=dd60c37e-bee9-45ad-bf3a-49d3ac0a8064\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdac_san_moc_chau_2.png?alt=media\\u0026token=0e22ac4f-c71b-4eac-a69d-8dda23b53608\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdac_san_moc_chau_3.png?alt=media\\u0026token=26fd6f31-d166-412e-abb2-034150f3d37b\"]" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9139), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fmut_dau_moc_chau.jpg?alt=media\\u0026token=5cbd4a36-f066-4014-b922-0bce4c578272\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fmut_dau_moc_chau_2.jpg?alt=media\\u0026token=f172742b-2518-4c49-bc2c-ec96aa161dc7\",\"https://https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fdau-tay-moc-chau-3.jpg?alt=media\\u0026token=7cd28015-7dcd-43c4-b579-8468b7e9a6e6\"]" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9114));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8729));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8736));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8737));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8738));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8739));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8740));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8741));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8742));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8743));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8744));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8745));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8746));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8747));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8748));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8824));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8805));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8807));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8831));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8826));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8821));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8829));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8799));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8809));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8811));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8814));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8803));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8793));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8837));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8835));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(8796));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3194));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3186));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3208));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3018));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3021), new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3022) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3026));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3028));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3089));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3094), new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3095) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3099));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3102), new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3103) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3113), new DateTime(2025, 5, 5, 14, 1, 29, 440, DateTimeKind.Utc).AddTicks(3113) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9793));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9795));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9797));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9799));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9802));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9804));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9806));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9808));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9782));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9788));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9785));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 14, 1, 29, 437, DateTimeKind.Utc).AddTicks(9791));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8891));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8930));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8933));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8936));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8940));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8943));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8946));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8950));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8953));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8957));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8960));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8963));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8967));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8970));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8973));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8976));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8979));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8982));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8984));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8988));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8991));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8994));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(8997));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9000));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9007));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9010));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9013));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9016));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9018));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9021));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9024));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9026));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("3bacfee0-41e6-441f-8de6-4f01eef74057"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9728), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("3e2f276b-7ec1-4b01-b190-d607b86d8a64"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9726), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("53751b8c-f241-4abf-9474-23e2a8a06b71"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9719), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("570fd85b-0417-463f-86f3-f6287bdec8e0"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9721), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("58cb86e0-6a63-4e7e-8657-edcd551c4bdc"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9733), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("5a1ffb08-6748-4295-89b0-b479fa821712"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9740), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("708475fc-ab16-4589-a21f-c2aeb76ac380"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9731), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null },
                    { new Guid("a2d33df4-707d-4776-a0fe-68ef4f39da21"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9729), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("b912e8b5-df64-4778-88d4-e3f207cea6dc"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9734), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("b98cda2a-baee-4a8c-b394-d60724d5d3bf"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9739), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("beccd2a1-d22d-494e-9ebb-f2287f2dbeaa"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9724), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("cd5bb76b-d83c-4356-b511-0d741080f1d5"), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9736), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9682), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9683) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9674));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9676), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9677) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9688), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9689) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9672));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9685), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9686) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9679), new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9680) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 5, 5, 21, 1, 29, 437, DateTimeKind.Local).AddTicks(9669));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("06694bb8-2c8e-48b4-8a5c-55c529a2569e"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("06b2de2a-b19f-4e58-a7d9-109c6dd1e286"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0b681cd5-5dec-4892-9163-bbd950a33fba"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("0bf4f7d2-6aab-4f9f-8e82-661a006966e0"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("2e25a6d8-38f7-4520-ba6e-ccba07fd2f55"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("362e4f46-ed52-4a80-ae06-cb07489cd671"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("3a9f79a6-43ec-4609-8d3f-b904e746403d"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("3c0cf3a1-669e-4b43-af73-a316ed96b5d9"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("43da0f04-56fc-4851-b965-08c69bb88a86"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("5030e2a0-aee4-4a59-8d35-5cf4fb633b93"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("5d8feedc-c316-4c96-919e-c445c39f259e"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("6703d572-1b5f-4176-ada5-90208a355964"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("6b683fc1-4f8c-4c61-90d9-a2666a4f11c9"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("77baa1f5-3292-48ab-bb36-930192cdb930"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("77e36a82-af44-4f46-b4b2-3c72a6193581"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("7a0e133f-fe1e-4af0-88a3-0e82ea2e2b6d"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("8c3658b6-601a-4f34-a863-6073ad15f011"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("995289b2-f646-4875-be92-fab4e7e59e49"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("99ff70fb-a892-49db-a9b9-07fdbe6a4b09"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("9b5a041f-5d38-46af-937f-4af541c62bad"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("b2fd9f4c-45bc-4050-a3cb-230ad54d5930"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("b37a7207-3725-4183-ac08-e59cbf973c0f"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("b9937dff-a088-45ce-a9ce-bfa4386d1dd4"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c103cb84-8077-43bf-aaeb-acd31656d0b2"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c586039f-30c3-4e87-8827-d9dfd6eaf6e7"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c70b8eac-cd6d-4986-9abe-36d95232ca8a"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("c7467802-65da-40c3-87d9-ab05256a43aa"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("ca461d48-95b8-40f8-86cc-728357dea0c8"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("db690b87-e164-472e-97d8-97ea9775e71b"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f61351cd-88cb-4e2f-b4e8-4b3b669fc1bc"));

            migrationBuilder.DeleteData(
                table: "BankAccount",
                keyColumn: "BankAccountId",
                keyValue: new Guid("f94c1fc8-3a44-413b-931d-c91161f2bf60"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("21312108-51df-470b-b158-c07116e95983"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("434bffb0-0735-4499-9928-b0447a24ac23"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("476ea657-6bdb-4020-9aae-be2fb9c17aec"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("52bf3b53-1a47-45c9-8377-721db71ac554"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("6b55c40e-b629-463a-978a-99681e097e9f"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("6d275d54-4511-4dd4-9f58-016aef3cbca3"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("9c3f0f41-cee7-44f3-829c-9e9f6b7de239"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("af8743c1-3866-4c87-9cac-56e1e61bd097"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("bae20bb7-25e3-406e-ba9d-d62116776451"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("d6a4a202-dd71-4b0d-9bb9-91990208b5ae"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("e19586a3-e756-4237-83fd-1b678399983a"));

            migrationBuilder.DeleteData(
                table: "Blog",
                keyColumn: "BlogId",
                keyValue: new Guid("fa185d2c-4595-48f6-97c5-c30a04a93ebd"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("024aa355-e88e-44e6-807c-b8ca561a6110"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("233fdfc2-8fd6-4a60-9ff8-4dc9c6c0278d"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("41db84d2-8d3f-4a72-8709-54e4cbbc4a44"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("57289425-b33e-46c3-9ee5-1ce8a94fe0ab"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("5f3f76f2-1fd2-47a7-b8cc-23b73061c174"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("67ac9dc5-cde7-433b-9157-5a3cae48f20e"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("a0004bd1-a352-4694-b8e0-9aca56dfa0c4"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("ccc6834b-6e3e-43ba-9cce-fd18764707aa"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("d34a6856-fa4f-4690-8d9b-9ed4a0071a42"));

            migrationBuilder.DeleteData(
                table: "Certification",
                keyColumn: "CertificationId",
                keyValue: new Guid("e2c01078-fc38-4d48-89eb-e2823aa0fc7c"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("10cd3622-6df0-4376-a435-820434e15e72"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("2614aadf-a2d7-4168-8d51-0eedb9b15863"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("2a27d80e-8a1d-4c52-b95d-d9a27ab15ed3"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("2dd31076-5c92-4beb-9202-b7635593293e"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("376521dd-ab6c-4d3e-95f8-7106c1cc7818"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("37e1219f-4cf2-49d6-b673-9b54c299cf92"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("3bde7816-b557-4197-adc6-7334e3dcd28e"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("43c3af8c-cf70-4c74-9cbd-6781fce6c859"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("4bbb82f2-bac0-48a4-85c9-8acc5352760c"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("4d0ab542-c214-4258-a999-89a407e3e7fc"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("4e81641e-9816-4eff-aaca-a04486e61c71"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("53c29caf-d463-449d-9225-0d10348000c9"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("693963de-8395-47d4-aaf0-5ba25e7ce492"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("6f0019b3-42ae-418b-8934-691e7495ca80"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("775aea43-88b9-49a1-bdaa-519bcc764b25"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("7928b5cc-a4a4-49aa-8003-dd16e8115a06"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("8117da00-ca56-44af-87c1-3ed1f582a408"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("8a69f6b8-ad11-4ce9-a1e4-6030453a90e6"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("9d926a4a-b1c3-4cd8-883d-3a79743d4a69"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("9ff8d09e-57f4-4601-8779-03cf9710e1ba"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("a0822ac9-c994-425d-8cfa-8708a16f0ca2"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("a98803af-c282-415a-992d-076e5c168d28"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("b16ad767-cb4d-47b8-afea-ddf5d2daa28c"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("b6588720-975d-4567-9b75-52523e30e13c"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("c0e3e50e-c003-45f6-87a4-c76146442753"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("c413675c-2612-4cb7-a8d9-bf1a6c162180"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("c7aef0c3-f0f8-4ceb-9157-a197f527093a"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("d242fb43-f60d-4812-8e4f-759faed2dd6e"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("d7ac1c26-e788-45e4-bad3-ecc65a1c7aca"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("dfab1921-7870-4580-999b-3c7a197366ac"));

            migrationBuilder.DeleteData(
                table: "Contract",
                keyColumn: "ContractId",
                keyValue: new Guid("e534b879-1351-4a24-9023-cb3b28267d3d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("01d6f6b3-0c26-4cf1-a7f6-3aa372e564bb"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("07593e32-5916-495b-b68b-a9eeaeb69272"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("18163aef-0a3b-4bfd-9209-952495d888e1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("18ad7bc6-3d0b-4249-af79-c8f18679f59c"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("251ded14-0f34-44a4-b2a6-3ff5a360ad82"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("447c4bb8-654c-4237-a740-78b05d696c61"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("46242565-0f4f-40cb-badf-c8b7e2228429"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("47bdd2d1-ea93-4c83-99a2-b8fd74e14dbb"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("48b02f36-1ea4-482b-b13e-e50cbcf80492"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4ca54037-c670-4532-bcc1-53aed519bcf5"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("4d3a7648-6e8c-4ba0-b5ed-32e9baaf96ea"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("50a6724f-7218-4b87-b2a6-796292fb75d9"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("5171d726-a0ce-41b8-a0c1-0b4e43d90a7f"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("58d93b89-14b2-4e31-9e4e-2cf0ffedf8f7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("64c736cb-b57c-4d5f-bc28-bb8fc21b0486"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("68f42cb3-62cc-40b5-a8d9-8ea87582736b"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("731bc299-4752-4ffb-a577-3b1a9a9f9e00"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("7c0476ee-f08b-41c3-875a-aa57cee35122"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("8459781d-3ce0-44f5-afbf-a1fb6af5eede"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("85dcb813-8522-409c-a9d3-ba8152cd84d9"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("903b7ef9-ea33-4186-abf9-01805d592b04"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9b03f04c-53d2-471b-856b-8975532143e7"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("9dbacc58-a4b8-423c-ae4e-40cfee5c5bfc"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("aaecc821-4304-415e-9039-4730d89bc27a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("abcfde0b-f480-45a0-9cfa-5d9946e6b179"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b625565e-a114-4446-96b4-ac88647e67aa"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b7b57156-fa30-4f0b-b09e-58ed3e5833e1"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("b9689b1e-dab3-4276-96d0-9e581e8bf3ce"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("c4e1930e-350b-4044-a68a-73b3c495792d"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("cadd7551-59d6-4987-a621-6f6fac413f3a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("daefa7a2-41bf-416e-8e0b-1600e5a5f2c3"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("db6b9af2-ad65-4d4d-83a4-fe0e6641d17a"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ddb49b28-d562-4318-b005-ef9767c0bd38"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("ef9a1850-3641-41d7-9f04-f2f1024825fb"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("f0a77de6-bf0f-4be3-a311-eedd1ab72ad8"));

            migrationBuilder.DeleteData(
                table: "OCOPSell",
                keyColumn: "OCOPSellId",
                keyValue: new Guid("fed9cfce-37de-4765-b04a-e4547775e481"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("3bacfee0-41e6-441f-8de6-4f01eef74057"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("3e2f276b-7ec1-4b01-b190-d607b86d8a64"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("53751b8c-f241-4abf-9474-23e2a8a06b71"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("570fd85b-0417-463f-86f3-f6287bdec8e0"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("58cb86e0-6a63-4e7e-8657-edcd551c4bdc"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("5a1ffb08-6748-4295-89b0-b479fa821712"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("708475fc-ab16-4589-a21f-c2aeb76ac380"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("a2d33df4-707d-4776-a0fe-68ef4f39da21"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("b912e8b5-df64-4778-88d4-e3f207cea6dc"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("b98cda2a-baee-4a8c-b394-d60724d5d3bf"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("beccd2a1-d22d-494e-9ebb-f2287f2dbeaa"));

            migrationBuilder.DeleteData(
                table: "UserIssue",
                keyColumn: "IssueId",
                keyValue: new Guid("cd5bb76b-d83c-4356-b511-0d741080f1d5"));

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(6).jpg?alt=media\\u0026token=ac993bc9-7dcc-485a-aa6a-b9ea4815b7bd\"]");

            migrationBuilder.UpdateData(
                table: "Accommodation",
                keyColumn: "AccommodationId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Hostel%2Funnamed.webp?alt=media\\u0026token=76609c66-a696-4481-aa4f-d05fe8e15631\"]");

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b4ae885e-cc8d-473b-b0c6-cc4d1cd067b4", "AQAAAAIAAYagAAAAEHdEZsnEhaB0zoQALWWW3zoud1IR8oAj+uHFCh3623MavJa2H7x3y7gzPKIiggJvNQ==", "221c1b1f-76b6-489f-9b10-d0d15e63c36b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "18acd610-da28-4efa-88fc-bebdc32ca090", "AQAAAAIAAYagAAAAEB3Y5EIkGgdRld8cPGTLCPepZU7Gy3TlhVbf+/g7zR9MS34Jf/pvdkYAo3YpTEd99Q==", "6bd95c11-ca61-47a0-aaa5-01f49eb75419" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5acacd15-78e5-4155-91ac-f9fc15233161", "AQAAAAIAAYagAAAAELgYZDlJiIFD6oFQK6gZstR119+WZcf4OSbsEpRTYmr1YgnFp8VKN6oj7jhSgnwzYA==", "026de4a6-92fa-48f1-8897-dc61f71bca3a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "117d6aa1-fa08-4d18-8c0f-95d6ff3efc2c", "AQAAAAIAAYagAAAAEGotqWa/cVd5ucWNcinerw/NI0bOf9DTSDlNCocCjck0Hc6OXTsi3rYSLacQo9eAsw==", "62ae92f1-8121-4da1-95ae-80a1335efc4e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50f74aa9-c8ec-4463-93ea-cdc4e47cff4e", "AQAAAAIAAYagAAAAEEYx22oqPcqefWmrBuotmibccp1Ld+DQ/hZogaacNp26LytpFB0BFtXEoZ0Kd8L4rA==", "f6bf43f2-a256-4f9b-9905-61298b376c13" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10cae633-b2e5-453c-8a30-b7725a5596bf", "AQAAAAIAAYagAAAAEMzyTAPAVadhbE0b+YLSY3JCMzGmrOtdPyIFa2bAzMOg2MV/nrEM82h6ZzQgkHiGXA==", "76910792-476d-480f-b1aa-4b9964252467" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d150da6d-6da9-486e-8297-3cfd34943321", "AQAAAAIAAYagAAAAEKo1HPHEXFS+dKbnfr1AzrOAf6zUc2FUcoAPQY2NewSHXOfy1kqjk/3dBR2WYKGWsg==", "a95f2a61-3dab-4b89-8711-3b71e30f8098" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f4376866-79ba-4e22-b017-2946972e845c", "AQAAAAIAAYagAAAAEPNhxxTHmWx+jX+SpU8Dggkas9cN6leCafIXFqZxxlU4U6pKNIzmoHgfvLkuW50IPQ==", "740d44f4-ae19-4612-bb00-a71570a2ab68" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "584684eb-f0af-4f12-b6d9-bd080d6a0678", "AQAAAAIAAYagAAAAEG0RcZ61HfjSsAbsYBAB8Y/BU6IF3o9AU2KnTJBQY79mhuDoPzIXmQuTAQXof9cazw==", "d0b42fa9-7ff2-4292-b72b-278c3770cfe3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "726e27f8-9197-430e-8e38-186c564d1cb7", "AQAAAAIAAYagAAAAEEAzCJWqyqErEMepkwjvYO2AVh6FGjdCTwcUonRXbDyx7hLxzz/8p9Tslqbc0gLF8w==", "cd7f51b2-0298-44ae-8fcb-c21eebb25bb2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6400d4a7-a581-4e2c-a56f-500c60d56f9d", "AQAAAAIAAYagAAAAEJxQyk8uJoWr8dvurOGRZokLkSUzO102XCJ94KIjxUwcAY5hehDc8hlqAWtqcqHAGg==", "00d80c69-d399-46ff-8e78-955ea2a6c7d0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6f667d93-8ca0-41d6-b842-22f11d80d13d", "AQAAAAIAAYagAAAAEGe7dLuCX4OsNnymuWm3loLlfjtyY8bRWeLBUCDQRV3NyxEXswYBNuhDuOkVUZslqg==", "532723f6-f792-4372-8933-a737499bc5be" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e400774c-3d41-4ae2-b7aa-34c80860f1b6", "AQAAAAIAAYagAAAAECQX8X0rl3TWvSDMvT4tc4zVvEqEvp247a0OF52639bv8/C7thEGDX47Dk6ZnMmBXQ==", "48064460-715f-46c9-b212-ede3ce21c6e0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fccb2d82-861f-4792-9e84-34eed55f2cbe", "AQAAAAIAAYagAAAAEA2v3Jo5xTVCQwgtpEGBmazkplefI6S7P8HY2G9ou9jFWUU8ea3WmIDWVXTc+Lgbmw==", "3b20e879-8e15-40a9-a721-b08e7d7d85e2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "44915dc3-ab02-470f-b8c7-662853f333e7", "AQAAAAIAAYagAAAAEB1o3B1LXSfNShflI+qfcWHUeUh9VWfYPfqQnUXTNPNljQJ1YkYhBjirda3qAniqCw==", "f1d876e0-cc79-430f-908d-c43c974c6f0b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5cda1ea0-dde6-471b-be2c-ba7856b10af5", "AQAAAAIAAYagAAAAEOR4xwqEDkorLpaeHKuxohrDu1kTl6vDZs76W7k/3bNykf1ptSLFJl5s6iM51Zy2KQ==", "b6065ef5-d25a-4d90-a3af-27a953dfc64f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8d3caf60-a2eb-4319-9ca4-20b4f77fb958", "AQAAAAIAAYagAAAAECz+tlqh3CA4BKqwNuORXjIx+9YffTkLRUHa8BW4qDOmGtWanqd0G7fVXD0zoyPKdw==", "c0afe56f-5feb-4edd-acbc-c053dab07b19" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7f4e9787-a33e-49d9-8482-9ae5a8534127", "AQAAAAIAAYagAAAAEHa822q5HVdPBIAGWjpy/HObZAA7sDw2vC8gUBB3MRfEJUFqo1JfCVZGShmZDh947g==", "2fb5dc49-5620-40e4-89e4-661f9b6d1bbe" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "11691034-48d3-4729-aa06-1d2935e40a48", "AQAAAAIAAYagAAAAEI1lwB+veMVl1IpIZliQ8JVTDw98aBeHUpU7eRR5hTrbWva4DukuUux4Cd8MbFjCLA==", "fc648a3f-67e2-4917-a065-85384f5f4065" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "67522308-cd65-44e5-8b46-2fd73766d75a", "AQAAAAIAAYagAAAAEDQEO0We6Kj/bftncFcp3t5UL72kEo7PezjYD+v3rUC59OfgxX5cwf0wxXEx0OvbUw==", "3247ec38-30c6-40c0-8254-89984a16733b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e5a113ba-8b84-4719-a23c-1f74023c1487", "AQAAAAIAAYagAAAAEArOjClBsLlcJaXz7c985pg2QvyP3RsBnKdf4QS7PXJ4P9pksmFTSve06B6PUqdY6g==", "674477a2-46aa-4c67-8944-6e3fab2fe1ff" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c5ee22c2-4e04-4555-91f1-47ab5a1b43d1", "AQAAAAIAAYagAAAAEE35d7gMNudW6S0ij4VpEpA57O/0DPmtcuqCqCmflTq60/oP/YFIWK1E9AhpO5mWtQ==", "88abe25f-af2b-460e-ae7a-dc04c6ece06c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3bc74589-3a64-4d16-b381-95fbc48abd24", "AQAAAAIAAYagAAAAEDjnVBQM6+NGbP+kQhwLLA09pVyusyl9AgL/jatOv2OI1qAuT4IipUx8hciRvXCoTw==", "86ba0eeb-9277-4666-96c7-938e984310f3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "118a4fd4-57ec-4d6a-a5d7-5ed4d2de5192", "AQAAAAIAAYagAAAAEECWyRw0z+kAVPYeDlibBudE2EGses7PwnyySBOyn0mAjoUNTppcXCM0SuzXWKPcoA==", "ed53591b-d226-443e-84fc-71501675a86a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cf1c118c-4ebb-4866-9409-d6aef7b6ec30", "AQAAAAIAAYagAAAAEGygaPyt7SEzgt8k240DIPyYTth3dBYlWOoI3b6em6gZTMkdTGa5aQfwBXHOnZbLtA==", "c1db1bb3-9e9e-4593-b94d-58482638a15f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "fdd2cf77-eba2-4855-b5f7-1a1f765301f8", "AQAAAAIAAYagAAAAEDa2VRW8JIcew5k2aDggNOfQGG9z+KqOQ6EAfafM26BEV4rGlOSuIDFcuYR4/ZYeIw==", "29d8c844-7c3f-4a15-901f-0ed36f5a08e2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "00ca54f3-1567-45c3-b053-7692a40e546e", "AQAAAAIAAYagAAAAEBLTI95gPjSAFWuqdd2cACDwaFdRYWTEctVERkQavg59UwnL9hqwC28I4hPKzC5WPw==", "4643294a-7f9a-4084-8737-d7bb2404cf7e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e7904946-4fb5-44e5-a505-48fa2c35bfc5", "AQAAAAIAAYagAAAAEAtfFjrevSINmifI3eLA+Z0A8dG4iAk6zVCZWD+GipsuKM6uPQsuO8SWNNa/OKF09w==", "cc840df1-8721-47d5-95ad-50a5df955a25" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "16e046bf-a3d8-4b2e-a5ce-3230b509b57e", "AQAAAAIAAYagAAAAEGuvDzR0deVKGcjejPt2SyybpX4racee+zKKzedgNGI5tPc4zw4l/CaH9xSjJ3xi+w==", "f8ce2ffa-30b8-43a8-a459-7a66171010ab" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1594a57b-84cc-4bb8-ab17-c11cc3fcd292", "AQAAAAIAAYagAAAAEAQHKcavkjBe096MCW5y4rAO2+/d4ZfYNmOR4G2zgUelB0rvkcrPgiQaMMB2tPm7LQ==", "ea589dfd-6e0f-4ff7-9aae-7e86f7c67067" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "edaf5e97-ad31-46c1-b093-51ff641d4f28", "AQAAAAIAAYagAAAAEN44rzHJT/qOpgRTF5sDIA4wwrGIGXxPAgVYMRVqiSWptBHFQo7+a2W7U7v+Z+sddw==", "9706b671-d762-46bc-b688-6f45c469d3f9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b8fcace-4ee5-4705-8c19-9e59b483296e", "AQAAAAIAAYagAAAAEHNBjwvsVMwtDEeA1bTjFOCIQk8Shqkp4PxeaTNB2u3YklKl6Q3nGgDgBfnvwzatQQ==", "74dc9d54-fbc1-4f4f-9212-8863f469becd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a42c5e59-ee9d-478e-927d-59fe907d54cb", "AQAAAAIAAYagAAAAEKqnpDAF6+sj5Pf0L1WjteNeLILcxvK15Je8uHib0dyAXYYoIufZIdpwFKUrwaBYZg==", "58308b7c-758d-408b-bfd6-fea0f9d7c093" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000033"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1b60a0f9-02f0-4e9f-80f3-f98f1463a366", "AQAAAAIAAYagAAAAECZe6WJPsJsKk5KExkrMQ7S11quSuNP6cAQLp+dgc/+LVNQje4Ifws56bCcMD+S0VQ==", "d3a70a90-ef39-4fad-bdcf-c07605e417c1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000034"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b730e8f7-f174-43c4-8880-a3a24bab1883", "AQAAAAIAAYagAAAAEDK09cU/37kGGlIUNUQB/+S4WSL/BFp1bP6UJiqJKrTnL8dlO8OoVZwKLS07y4TXiw==", "8cab7903-06fd-4972-a396-412814944e42" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000035"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c26751a6-0942-45ad-baed-a1c70b869d17", "AQAAAAIAAYagAAAAECBD6r/fjRWaXZXMQu8VU9USiwQqEgjEfUP6YBMZTK471OUWgU0a7t7ZjZhbcTpDiA==", "ccc7bab4-009f-4c11-b2d0-6b7289533ee1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000036"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b341a709-6253-4fdb-a5cf-bce5b55bd749", "AQAAAAIAAYagAAAAENxDU3joBBo9cjL4OWlnMrTPbLk7szc20yz7Pt5LKYSSkFLDq1xjj1DaFJ+CyurEBw==", "8f74c04d-4955-4d9c-9d38-8b6f25ec1680" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000037"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "233a436f-71c6-4e80-8e25-b27471b91f7e", "AQAAAAIAAYagAAAAEAyzRGHHRpXXL4FRf4t2dHOt0x4QCJijDeliRE8AN/gugRNiWadJX1IIDN4FR7moCg==", "09b8ba5f-7694-4935-a0d2-254e84759eb3" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000038"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f41cf2bf-188c-45db-9533-bf06c355928f", "AQAAAAIAAYagAAAAEK401uTqx1/Lg10T0LqResT9hmsMMfP+wPDomE2L7ow6savkHpwQrkogv5ivPeWZ/g==", "7705ceef-8682-4d93-86a1-fac5bcd3f843" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000039"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ee97117d-4ded-4922-9463-da284962583c", "AQAAAAIAAYagAAAAEEY5W4hmDZWTI+1ps/NGsia9ALl4u4LQs9eZf+oYiKRT/E9dTrviHLBeawRKRbFNMA==", "9898e6a1-7c6d-450e-921d-e3d1b507d0ac" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000040"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2374dad3-85c2-4f6f-b652-a097fd8a6cb2", "AQAAAAIAAYagAAAAEFaRBdr8XsEPR6IjrfB3ANyRTMqvRf3lW1Kh+oLI0Nq8dvCEXLUspF3B9cBuP7C08w==", "08015f43-1ab8-42e7-b005-431af632b95a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000041"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "94e9c777-1232-47e9-ba48-9fa9cc8c663e", "AQAAAAIAAYagAAAAEBoPXxYWzg60mKcS2s3NylfviGf+LH3ZdV0scwd5mLp+oLR45jk3K9ldGc+5Y0xwMQ==", "13ef9f90-80e7-411f-88db-c0057f4060e2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("10000000-0000-0000-0000-000000000042"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "10bdd2f7-31d6-465a-aa08-2e0754e672fa", "AQAAAAIAAYagAAAAEOY8H9JILNmEOMubAXaoS6mpnghEYEk0giGcQeQe5qV+kTMjnxJJrbuUlj6tRjhZ8Q==", "c844a7b4-042a-48d4-8eb6-0c66c9a39f2e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a778b54d-0159-4a5b-b3fc-2ed0322545b7", "AQAAAAIAAYagAAAAEG6dk2wqKcba3hPYIJelL+UVkR5Yw3BozsLI5IAT8Ube/RKmRwtuRladnBjbHomrPw==", "0de1dbb4-899b-4bb5-a897-feac99efc5a9" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000018"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "50cd0058-a92d-462c-85d8-33d57faf82be", "AQAAAAIAAYagAAAAENA1LSKB1IoqgE2EcoPX7bRiEkltRIn6Yp2yMMjEgCwgpm4dvt0ZRYTd2RTm2woPAA==", "f8c1ecc8-e6ff-455f-9150-2a862f7a5cef" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000019"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e6db92d9-b416-4550-8ac5-48a3db93a45e", "AQAAAAIAAYagAAAAEPZMvcORMUNoL0nDDOmUC2jQqXvYPydMd63Loc9dacFyCoUC9YiP1gwi/hVPH8nEOA==", "19c6099c-facf-4870-bede-3fa686ffa530" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000020"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bf7d4cc6-1709-4142-a3bb-8b20c3b751ed", "AQAAAAIAAYagAAAAEJX+xUpdha6wvk5cDj2rrTD9n76O1kBkA/OAk9pgFEYpO+Ukssp9E5EPKaNGy1xQqg==", "44f08d71-6549-4034-b975-294ee956be5c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000021"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0b56d167-d813-4974-86a5-d6f2c075bf37", "AQAAAAIAAYagAAAAEFOThM5/O7EjzCe6IAnwU+hVM2RPmcuqZ04Y6frANGLHpIXHjUmGgufnVd0IMG5vKQ==", "9f7424a5-bbca-4f24-9172-a213667d87bf" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000022"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "08d58c12-af29-426f-8083-71f5ff8e48ce", "AQAAAAIAAYagAAAAEGjQCBdtUt8ZjMusnWnurwGIQ+rqSdsOQE12HAMmH3uYRr8/MYQk2iGsfwq+xc4QLg==", "65abae13-2099-4a08-8912-f20e3a3b2208" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000023"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1cfd316c-9997-404e-87f5-b9732c31294e", "AQAAAAIAAYagAAAAEMYicVKnIBEr/8meI+bgEGZtra51XRqVAqDv7uIfuCIbYSWGab3rNE3amDef7AYEIw==", "b9ccfb2e-811c-4ee1-942d-3711e7010db0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000024"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3d0d9c9c-bef8-456b-9297-68aeefce2853", "AQAAAAIAAYagAAAAEPix4cZx4IyMakIBLVuabpeKZNMEaAGQKqnBlhqAmvylRs/K4OPY6fS1kNpyndAfRA==", "57e9a217-72c8-4bdd-b8d0-6f3036fb2dc2" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000025"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "29418985-f0f3-43c5-ac5c-242cb55b53ff", "AQAAAAIAAYagAAAAEBVkcAWfv7oyadjTcyhOOUJwq8JR83HJzum+sMzrBM5cwUrxxIimZebcgPLYfvRL2Q==", "23dd228a-3ebc-472a-814e-2cb5940a3ed7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000026"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1444faea-c25f-452e-9fe0-f56d0de4ede4", "AQAAAAIAAYagAAAAEKfUZiGTfeZFLr8eV/UbO+oejF7YSFV8klKoAKSgJJwX390Zo7ALgnsNELamC92CEw==", "e224a90d-e837-4cc3-bbd6-10429ef6deda" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000027"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "ccccaf7b-6ee1-49fa-bdd5-b8beb7ae1a20", "AQAAAAIAAYagAAAAEHTUBLeyIXT3j8hcuIo1zHxTev4tI7Qo5CbvYC1uLjAoRNg4YDi0HUmghjuycgJX6w==", "edcf0392-dbcf-4214-87a6-cb6e7224ad58" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("20000000-0000-0000-0000-000000000028"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "8cc7e0c1-7bc3-4dff-8e02-d301c14efd95", "AQAAAAIAAYagAAAAEGcf5OK9cA7V8gKmm7IkHwmyaVJ6atztlqIn8Z/ADvT0Lo/sJePW7+l6oTKoFaV63g==", "4caa68f2-e9fb-429e-a0ce-93b0181046fd" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("22222222-2222-2222-2222-222222222222"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e392b9b4-f8ba-49d9-8c2f-ff0d2f662185", "AQAAAAIAAYagAAAAELrH931fL6WnQshZvADcqefO7s3PemRY/XXKtoBOHLzzCqnIVWConSMBZHi00svH9Q==", "2eda00bf-5a7d-4baf-b708-b72ee380d561" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("2ea71d2c-9932-46bc-9423-730dcc7beb92"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "6cfef78d-d635-4e8b-b547-8ceca2256430", "AQAAAAIAAYagAAAAEEsUiSUcAldrNNhbbvWS/rMNwO50MJWSUrDiHiaYWkMp/FYjnNRGw7aE5btkq4hrbg==", "1e3d41b0-f287-4e5f-952e-ddda376a851d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("34417efe-85a3-43bb-8de0-daab43bc3e29"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "0a92d0c8-0036-4fe6-80cd-bc52e9be7b97", "AQAAAAIAAYagAAAAEBnCWihRMsvgInkzCdy4ItH2vNeCUz+SJhxrhksgNcsjYP8ABBCRaWpSoxH0Ds5uow==", "8a979518-18c6-4640-97cd-ca9eb7d18231" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("44444444-4444-4444-4444-444444444444"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3b3ca8f8-1393-4d08-ae79-c10d4f7fb2bf", "AQAAAAIAAYagAAAAEPs7+fipf2OEs7vw6RY2mW7VxEwQOpf2FjEZrbjtUUi9GCS3Z+KbOQaYtZnFYmkmCA==", "44d373e4-6804-4d5d-98e9-2e5fa6a273f7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("46a916db-f0e3-4855-9171-eff063b5cc90"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "3740f778-9b62-4101-bab0-d99091ce02a1", "AQAAAAIAAYagAAAAEITfUSVVtrOaFf0gGw9Iy2+uqP26pnc+GTWxbZfKGyjxmDC/1taAJoZaaVRPetz/Qw==", "e1fab43b-c69e-419f-86fc-82c894010b4e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("64454a5e-9883-4548-9a9d-d7986bf6b3ad"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "f35d1c8f-bed0-4a25-8da8-d643f33ccdff", "AQAAAAIAAYagAAAAEOvH40xy8iXbzYl8yMi3kpTmLVOaROOwyaCqfZAroUY1cLPCL2+Gryo7RZNDRGK0ng==", "cd65d1ec-1591-4ffb-98ba-feb581659d1a" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("645f6cd7-a359-4643-9e28-0d6eb32d103b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "cc076cc7-09b6-4756-8588-222b1ccc88cc", "AQAAAAIAAYagAAAAEMNsQ278PsX5zP/X0/L5C702+ActsQunFetfTLW5p6sI1x/2CWrp/or8mHoqMf7cMg==", "2fa3e928-7c06-48b5-8705-d9a39dd4dd53" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("66666666-6666-6666-6666-666666666666"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "15135a16-4a29-43d1-b6b9-9c976bbd48e9", "AQAAAAIAAYagAAAAEM7rHLE9xBP9uE4dcI9sWoP1zu4rHdpjz80exXielRdemsUkVsbsZgNiXNCqZSKKtw==", "d89aaa40-4919-43cb-a029-b4d767ec5165" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("679d0aa0-710b-4026-bcde-d274fcc269a0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "45519e4f-1048-4c28-a93f-5f93e395240e", "AQAAAAIAAYagAAAAEKZYZAafgAdjqq2WQK/5kNuK4OXOYM4+Q7QmPWNU1OaiTRkRo81yzHqCKU5Q3/svvw==", "73f4443d-9b13-4db4-be33-d024c113e6c7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("870dd1ec-c340-41ee-9088-0f3612f510cd"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5517c8b8-3f67-4f88-a961-1eae11ea80b4", "AQAAAAIAAYagAAAAEP+pLmWEYlilrzh2gbdTq1z46fRMddMNVyQHwvPEVjLs1gS59FWHBuNU5Xqad7u3jA==", "6a1f119b-3d17-4b12-82d1-caa4bddb3e04" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("88888888-8888-8888-8888-888888888888"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a4af9798-2e1f-41df-937e-eee4166247c5", "AQAAAAIAAYagAAAAEHG4tJVlkADcTOqBaLN84b8x+GX4gWQaLz9pcHy10XuslTUgUD2OsPKVD6+B3cnz5w==", "b1cce4f4-a92d-4b71-95e1-97a487126fe6" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("939a7f24-a476-4e7e-8345-7c58ebb737b4"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a45a07f2-e96d-425b-9694-e29a3b32cc6e", "AQAAAAIAAYagAAAAEEXIH98/eitzL7vnpopdmkahZ56wzpZP28De9yc0vBBZHd74dGkWEckejtQ2bMY53A==", "c85b290c-b528-49be-af2c-081fb996a9e1" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("99990000-aaaa-bbbb-cccc-ddddeeeeffff"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a5e4a5e1-66cf-4a52-9e8e-4a254f0c75a1", "AQAAAAIAAYagAAAAEFYjby4zyl/o2B6cAXrptLdm8+0+9NdF/Hw3ddUtIYReaPLtfXhG6eStNRX9wl73fQ==", "0811f398-b407-41ce-8762-32d4884ec86f" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a173d7b4-e503-4508-892a-5d1a4901cd03"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "1d2e9306-730a-4e26-83e1-189be1562563", "AQAAAAIAAYagAAAAECvX9IdZeiHQSI7IoLypFspZbAB8RL1DCy3nOz4FBj2z2WiEWSTL7Kc6ytZ418GQ9A==", "0b0abfc1-4e42-4e1d-b4e1-70ee27027359" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a2416864-ff31-4e7a-bc1b-368cc7c1ee1c"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "345a1ca8-12fc-480e-8228-e7a882a53765", "AQAAAAIAAYagAAAAEBHwqJO0V43J6/9wc7NPAkIBklP9bW9nDuzY1p2+tZ665zRebqEFf1bVzfhw/SAXvw==", "8862fc73-5c2e-4f20-97ee-db8ddef5aeb5" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("a631bb94-66d8-44db-932b-532892d87754"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "742d94ef-9df2-4a34-b989-75b30aa0544e", "AQAAAAIAAYagAAAAEN3T5QErvNoP3uA6FdBa7NogGRxXuW1QsfDhqA7DCEwqbPjuVI8+9lsbd3hndLjemg==", "0485af32-f788-4f27-9ac5-eb4307ee20ca" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aa5c5293-88e6-4110-af70-68feae5d6a89"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "a3451925-0223-4aee-94ad-e98926ba23c9", "AQAAAAIAAYagAAAAEEWhWMXW4PF/QR2lHnsnMfOlNkPdgvGhcTF50/oxvxXz7zODGI341kh1RZ7s8T9ydQ==", "5262f085-ed48-4fcc-bdd6-3f900bc3a86d" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("aaaaaaaa-aaaa-aaaa-aaaa-aaaaaaaaaaaa"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9c6932f1-a957-4b28-9f5a-0d899a4594c7", "AQAAAAIAAYagAAAAEFfrJDvdzk16+cbmpRqsYNNDROJo328w1Yx4O87r3yA+9xvdBCND4gYX95SVkCoViQ==", "7df2dfb1-8e34-49e8-a5a7-e95ec16d04f0" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b7d23d43-0cf4-41a6-aa07-9cf8f563db77"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2cd5962a-b4d3-4297-b388-2a0468fbed20", "AQAAAAIAAYagAAAAECYRgISnZn5yKhA6mR2zl8rrURz7+kaTC7BH6BIf4+2QsT58jcO0VQ8OI5tX0vixpw==", "6d8a58cf-8594-431c-98e2-69996595972c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("b8c777a9-55b9-4b3d-860a-d7b56e4c24b7"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "541d41cc-fc48-47bb-841a-74f7e62575af", "AQAAAAIAAYagAAAAEKeb4uthDYc2pVIer8q3NHy3NSNvrzT9GvcrzSs6ikF2gaBxkvorM4PNg4wE2MseQw==", "2236b75f-a3bc-471e-bf77-0d425aedef36" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("bd5e9d2c-fb27-4896-b1d6-cc09dad3cfdb"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "2d04efcb-bf81-442b-82b8-67460779c7e8", "AQAAAAIAAYagAAAAEO59CVQo3UbKxaXMIGUcxV8T14MDoxSKxPy+qitfAv5E6BYwt/MFcfZnUEOts2Msiw==", "d50b3a95-ec34-480d-babd-a4e17af43a6c" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("c7e55065-cacd-4fdf-ae68-2a4bb8ae3375"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "92c6b6be-c70c-4363-8215-10c33e32b60e", "AQAAAAIAAYagAAAAEJ/201FP4QD20gajSM/bEe2wnaC3iAiNIAfx5oU+IMiTXG49oIrtAlN3OB+8Tjtxfg==", "8557ce19-19aa-4915-984b-16565824aa3b" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("cccccccc-cccc-cccc-cccc-cccccccccccc"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "74e134d8-2027-4aae-bcba-467f5a363a3e", "AQAAAAIAAYagAAAAEDDzDGzYN92xTjIkKZhcADWHeYNaBldEA19JbdeWxCKlxioldDxq6SLIFCdVggV3Eg==", "b4542269-18ad-4af0-bbe1-e92c201bad4e" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d0e45bee-a768-4555-bfeb-788728a53751"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "e8afdbcc-6e7e-470d-97d2-2cdfba5fd7c3", "AQAAAAIAAYagAAAAEA0lyq9JKWtfbipReXBmF0nBoFH/Vm+4dDxXfxVwtdMwWscwOfuDen3im+l7Q+1CGQ==", "3f86766d-9481-4621-b596-27585f3b5f24" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("d2c3e4f5-6789-0123-4567-89abcdef0123"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bfc3e498-1708-423d-b099-ac21208592d1", "AQAAAAIAAYagAAAAELThZ1ZDKSMhr3UzppilE0zcZLCj90BaQVL0AoEE5YGnYOctt1G/n/w1PnYpCtXCyQ==", "b49adf2f-2f45-4cf5-82ef-3e99c0285dd7" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f0"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d607d27d-29ec-4268-9a10-b8e4ae4583d5", "AQAAAAIAAYagAAAAEFCRF4lCN4Rtgo9bctx00DKxDfcsOAhfdC54Nhz1GJ1YZAvUL6nNezs+fg0xxryPLQ==", "11bc7f8c-60f6-4eb9-a5e5-69eb89671112" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f1"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "7c4b7778-c1ea-4da4-ae28-2fb53519fbaa", "AQAAAAIAAYagAAAAENjzGMA53TGqyFgh8sZDxFbMKizSlvHkzijM5/1d8vif2cGyN/HFVYpqgoSWaNhjQw==", "d075af5a-2f7a-41ee-b531-95a69a0417af" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e025738e-4686-4282-abc3-dae9c65907f2"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da379f74-2244-4f9a-938d-76f81e702b5a", "AQAAAAIAAYagAAAAEKtK3ASntbLptnJwGZpDVSU3xsWvQ0GMcBZDg1CNKDSMk5tj0YssFSb99VOLQd6RKg==", "bea7a2e4-ed60-4f23-a056-51e1b8e28aee" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e469a23d-f6de-4c36-9e44-fc43eeb6a24b"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "da57f2d3-d009-4fdc-9fd4-efe6aee51838", "AQAAAAIAAYagAAAAEJCwM7OfT4Oh0g34DMXAorOBiYOdJE0xKwtcXuCG0osHxjCl/nzLF0qb0uIbhQBFlw==", "8a09ba4a-0b1b-414c-b0e5-0174ac065134" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("e858b667-00c1-4431-8c41-5c9f88b4fcf8"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5558da02-c265-45f2-be5f-adf5abba2c53", "AQAAAAIAAYagAAAAEEoweb8Ym+QlWGF957aaTfNmIcNFwGhALHS/dVqAA5b8fqvBlL9a0tR0GvBBRwaw6g==", "20bd8a8b-c351-4288-80a1-92e7d0f7f602" });

            migrationBuilder.UpdateData(
                table: "Account",
                keyColumn: "Id",
                keyValue: new Guid("eeeeeeee-eeee-eeee-eeee-eeeeeeeeeeee"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "9dd3c6ca-1039-41f3-9751-f104d8d078e9", "AQAAAAIAAYagAAAAEFl48M0xQZrDtyROWTbUG/Al8AWzKEmJL/IfXPhshUO8Qv9zHpR7SjtbfPCuTwWX5w==", "4e840d23-2dce-43df-b630-96cb292e4706" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("1f22ec6d-442c-4632-8a6c-a1bbe87e6c2d"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4314), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F151.jpg?alt=media\\u0026token=637e2ba5-283d-406b-8604-e7a908ebab2d\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F152.jpg?alt=media\\u0026token=e6bd1f38-1a76-4d4d-ada9-25da7f51686f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F153.jpg?alt=media\\u0026token=130839fb-7bbe-4186-bf90-ca1419a80582\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F154.jpg?alt=media\\u0026token=78e68037-8fcd-4fbc-a0d6-7ac9752e33bf\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2a42085c-8a76-4c67-b01e-1c4ad0b5a733"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4272), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F51.jpg?alt=media\\u0026token=47097c1c-c500-44d3-8737-78a0f2a8b1f2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F52.jpg?alt=media\\u0026token=1e207dfe-0474-4f0f-ad34-37bcb330c20e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F53.jpg?alt=media\\u0026token=546add09-5243-44b3-a1ff-0b7f8c799539\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F54.jpg?alt=media\\u0026token=7b90f572-93c1-4378-80da-7fe1421f7a06\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("2d71c1e3-ff2e-4f65-b7c6-2c2b02944c92"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4306), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F131.jpg?alt=media\\u0026token=8d1ad1ca-524b-4c04-b987-ff7a72d12fc2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F132.jpg?alt=media\\u0026token=3ba71565-f467-437e-9b65-d71ccb1da6a8\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F133.jpg?alt=media\\u0026token=c02001f3-d8cb-4c16-a3f8-15d822dadf84\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F134.jpg?alt=media\\u0026token=2cf26d42-a673-4dde-a41c-6f1076363516\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("60f2dcdd-7257-4ce4-8abd-fc01e4eae546"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4236), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F11.jpg?alt=media\\u0026token=892ef66c-cd8d-4228-b4ff-092b82961381\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F12.jpg?alt=media\\u0026token=374f97cb-ad21-4633-8381-8081019edabf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F13.jpg?alt=media\\u0026token=575e9e8b-b7e2-4b84-ac41-2b98313bff4f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F14.jpg?alt=media\\u0026token=19367ec0-3dd2-4349-abcf-fc17911ca4ec\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F15.jpg?alt=media\\u0026token=eebc5140-5778-4ab7-b128-7ec04c37f2b4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F16.jpg?alt=media\\u0026token=7d281318-7494-4c09-b7bb-8bf61c965fc0\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6a6a33f1-37e1-4c32-bed6-4d9c3fb6c99d"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4318), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F161.jpg?alt=media\\u0026token=2d7d29c8-3636-405f-9567-2a4aaae97c30\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F162.jpg?alt=media\\u0026token=9ad86d97-f35d-468b-8937-d1c4d461b0c3\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F163.jpg?alt=media\\u0026token=435f2187-da87-4cae-8b17-5f103f7b1f11\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F164.jpg?alt=media\\u0026token=1008643c-57d9-4b73-adee-a61dfa3a3a85\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F165.jpg?alt=media\\u0026token=be1854b6-921a-4b31-92b4-a8eb074729d0\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("6d94e38b-3d50-4e47-9e1d-ab7d8883cc7f"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4288), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F94.jpg?alt=media\\u0026token=68b2ad20-405c-4353-8dae-e0b6a9a585ea\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F95.jpg?alt=media\\u0026token=bca7674f-dd8a-45ab-85e9-e0a9b9370734\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F93.jpg?alt=media\\u0026token=1190cb37-0960-4738-b183-3659addb4593\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F92.jpg?alt=media\\u0026token=6c678903-0762-44bb-9e34-69c9fbecc053\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F91.jpg?alt=media\\u0026token=aa93f1f6-7464-4016-b32a-dc298f3719a9\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("7df7cb1a-90d7-4761-bd95-1ad4a2c1cf91"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4279), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F71.jpg?alt=media\\u0026token=8c694cc7-240c-4eac-a670-a458de5a8964\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F72.jpg?alt=media\\u0026token=9d082c03-94b1-4bc2-941d-3d80077481cf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F73.jpg?alt=media\\u0026token=955ef861-00bc-479f-ae3f-083a78f72624\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("8e5f378d-2d33-4ac3-9b8b-265ec7f4d34a"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4310), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F141.jpg?alt=media\\u0026token=17bafc4a-ca33-416e-8b02-4d5ed8708569\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F142.jpg?alt=media\\u0026token=59c221c3-f2a5-4065-9282-37bf5874be3e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F143.jpg?alt=media\\u0026token=6ad7d043-ae31-4bb0-a41c-d5f0f9b70e87\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F144.jpg?alt=media\\u0026token=4f03a1ff-ae27-476f-9a83-c69225dd0c3e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F145.jpg?alt=media\\u0026token=0c56159a-0c55-49cc-afe2-86c8de27db2f\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("947af66b-af9b-4c98-888f-9cdbcc3dc84f"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4258), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F21.jpg?alt=media\\u0026token=5a725c29-f7ed-4f52-89e0-94e0f768b8e3\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F22.jpg?alt=media\\u0026token=244dc720-f725-42ed-bbf1-a28f3a59178d\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F23.jpg?alt=media\\u0026token=1a44b12f-8bc0-48d6-b1bb-15a2cb7d3b61\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F24.jpg?alt=media\\u0026token=ccea313e-1a38-438c-b47f-2603da9a003f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F25.jpg?alt=media\\u0026token=7667d7c8-ec34-444a-bfd6-254fa545febb\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4322), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F181.jpg?alt=media\\u0026token=861ec090-60c4-4cce-9b2a-fd20a6a2fc55\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F182.jpg?alt=media\\u0026token=6ba6f500-6e06-45ae-9bc1-42ec00bf0464\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F183.jpg?alt=media\\u0026token=b0f66603-ed84-4706-8a10-261b21cb298c\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4327), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F191.jpg?alt=media\\u0026token=1ae42618-5c61-40f9-af64-b673a2e8b6cc\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F192.jpg?alt=media\\u0026token=ec22f901-1f9b-4d62-8a9b-2efdb9c7a95a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F193.jpg?alt=media\\u0026token=ad98ddae-0d85-474d-a14e-a46cac5292da\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F194.jpg?alt=media\\u0026token=b33f2e48-75dd-4935-896a-e2bed0e81b8e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F195.jpg?alt=media\\u0026token=68e9d11f-5627-4847-bee1-06d127911ba1\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4330), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F201.jpg?alt=media\\u0026token=c8aa9368-60b3-4754-8e68-183ec49665a3\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F202.jpg?alt=media\\u0026token=bdfa0975-acef-4887-b0bc-43140a5cb23b\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F203.jpg?alt=media\\u0026token=7c780014-a798-4891-ad34-a76992d7b532\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F204.jpg?alt=media\\u0026token=aceb4ca4-7664-4fe6-a325-aa77566c78ec\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a1110000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4335), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F211.jpg?alt=media\\u0026token=073d2ffd-c38c-42be-adcd-eeede14e7599\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F212.jpg?alt=media\\u0026token=823c928e-ca0d-4325-a4b7-b468d4186329\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F213.jpg?alt=media\\u0026token=61107119-364a-4a1e-acef-eb88ca4d893b\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F214.jpg?alt=media\\u0026token=9df5e91b-7227-4286-8829-349125c4d5c5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F215.jpg?alt=media\\u0026token=a8fcab98-514f-43d2-b773-d98fee53fcd3\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4339), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F221.jpg?alt=media\\u0026token=b2256b37-3360-4459-afe0-7186726d21c5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F222.jpg?alt=media\\u0026token=7a43cc3a-e217-41ac-a636-5a4ac970d968\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F223.jpg?alt=media\\u0026token=366c16f1-42e2-4294-87a9-ff2ca7e5b9bf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F224.jpg?alt=media\\u0026token=8da7861e-b793-4126-a1d4-e1541b94a286\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4347), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F231.jpg?alt=media\\u0026token=f97e225d-3650-420f-90a5-2de9e9e95cef\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F232.jpg?alt=media\\u0026token=ebbc29cf-f3db-4482-a703-40d22ef83721\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4351), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F241.jpg?alt=media\\u0026token=4463106d-794f-4fdf-a7d5-0d8480924e8c\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F242.jpg?alt=media\\u0026token=0007ab7b-3e71-433b-b91e-2ebeba70c162\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F243.jpg?alt=media\\u0026token=b0b690e9-bdf5-439c-8ef4-28c268db4620\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F244.jpg?alt=media\\u0026token=3604d3cf-9fc5-473d-af7b-c5589c0a97ea\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F245.jpg?alt=media\\u0026token=9eaef8dc-1185-42d7-9cfd-2224b1ccec20\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a2220000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4354), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F251.jpg?alt=media\\u0026token=81823c6d-9776-43f3-9ebf-de22ca576eaa\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F252.jpg?alt=media\\u0026token=36bcc531-71a4-459d-965a-6622849ab584\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4392), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F341.jpg?alt=media\\u0026token=6cd1a961-73ee-484c-8566-9d8797539af4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F342.jpg?alt=media\\u0026token=065f8c5c-45f2-4f48-bbc0-7da25c24c158\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F343.jpg?alt=media\\u0026token=5f5766ec-5fbd-4095-ab88-ebf7f4c1a50a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F344.jpg?alt=media\\u0026token=fb34619f-9131-4144-add2-afca0ba19b9a\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4396), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F351.jpg?alt=media\\u0026token=7f979d6c-7fd1-41fa-95dc-5b916eaaccb6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F352.jpg?alt=media\\u0026token=563f16cd-657a-47ae-bb8a-98a9e73c5e21\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F353.jpg?alt=media\\u0026token=f5b16d9a-5509-43cb-8390-a71fdb4ceded\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F354.jpg?alt=media\\u0026token=9b1add6f-51e5-4224-af5c-e50497f29c33\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4399), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F361.jpg?alt=media\\u0026token=7bcb88d3-ed48-4d65-87ea-8e765f95eacd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F362.jpg?alt=media\\u0026token=3ddd92d0-24eb-4731-8916-fc6ce6cf3fd1\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F363.jpg?alt=media\\u0026token=4fc8b20d-7bb7-4e4c-97f5-2f84c10bdeb9\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4404), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F372.jpg?alt=media\\u0026token=7291e759-0c21-44d3-b21c-2b62c04853e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F371.jpg?alt=media\\u0026token=898cb533-86cf-44dc-a119-5b5f96145d27\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F373.jpg?alt=media\\u0026token=398c95a8-aac6-4a5d-b9cb-628964a0294f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F374.jpg?alt=media\\u0026token=0433021f-55ce-4d70-a332-44e6aab49f8e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F375.jpg?alt=media\\u0026token=9d625a9d-06cc-4f71-8169-190168de597f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F376.jpg?alt=media\\u0026token=bcab3f6a-f04f-4084-b72d-39de575881d1\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000005"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4407), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F381.jpg?alt=media\\u0026token=424e6c80-6192-44f3-9493-4e9e11e83d94\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F382.jpg?alt=media\\u0026token=8f8c59b9-c916-4120-b569-5219537de2aa\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F383.jpg?alt=media\\u0026token=d0758696-6d53-48de-b51d-51e2988571c8\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4411), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F391.jpg?alt=media\\u0026token=3c9ee67a-b22c-4203-b072-5858308ebd84\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F393.jpg?alt=media\\u0026token=a5be846e-f195-44fd-9d0e-02a5382cb5a9\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F392.jpg?alt=media\\u0026token=27c17e64-db04-4907-bfd5-0d6e6b1c233e\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000007"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4415), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F401.jpg?alt=media\\u0026token=d9d59523-c02a-4195-8e28-56e0b2e4eee7\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F402.jpg?alt=media\\u0026token=a48192a3-6c9e-4ecd-9eab-af6a15f5227b\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4419), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F411.jpg?alt=media\\u0026token=1a9c47f9-1b2d-4b92-91f3-28b285573140\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F412.jpg?alt=media\\u0026token=f4987f55-a4f6-42e7-a1dc-7958db0b8559\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000009"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4422), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F421.jpg?alt=media\\u0026token=6d6aee32-1e25-4324-99ad-4f707c3d63d5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F422.jpg?alt=media\\u0026token=a81c9c91-10ec-4bf5-b6ad-d0f78222f6e6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F423.jpg?alt=media\\u0026token=cc1d5656-20e0-44c0-ad9f-c35602eceaf3\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4426), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F431.jpg?alt=media\\u0026token=fedde1c2-82af-4101-96af-ac35b1247c05\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F432.jpg?alt=media\\u0026token=6b2b702f-d2f3-495e-bce4-b03768564e70\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F433.jpg?alt=media\\u0026token=76f636b3-f04a-4c67-a81c-e83203cf98b2\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000011"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4429), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F441.jpg?alt=media\\u0026token=37827a0f-e7c0-4b0a-9c91-dcc11d611846\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F442.jpg?alt=media\\u0026token=0168cdd6-bbd6-4d1a-9b7a-11fa787bc27a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F443.jpg?alt=media\\u0026token=a7283cee-39ee-491b-810e-ee0683483411\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3000000-0000-0000-0000-000000000012"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4433), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F451.jpg?alt=media\\u0026token=2528b14d-5b04-46df-9276-1d8b759f8f00\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F452.jpg?alt=media\\u0026token=6461419d-900a-4753-aacf-ab7a487ce6a7\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F453.jpg?alt=media\\u0026token=cc68f5d2-853d-4efe-a640-301d5f9ef61e\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4362), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F261.jpg?alt=media\\u0026token=5cee2720-206e-4229-b4b5-d87913de7cdd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F262.jpg?alt=media\\u0026token=6389bd14-f169-4352-a396-9a29f68f0268\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F263.jpg?alt=media\\u0026token=f0089a61-9297-482e-8bb8-1846d6ce43b2\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4366), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F271.jpg?alt=media\\u0026token=241821db-3226-4e34-a77e-e836f927b832\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F272.jpg?alt=media\\u0026token=3fd95b94-c080-48a1-a33c-26b124c01729\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F273.jpg?alt=media\\u0026token=9a6da2b9-6b90-4fb0-898e-d53d619661c4\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4370), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F281.jpg?alt=media\\u0026token=f04d5b05-7aaf-416d-97e6-2c822003f677\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F282.jpg?alt=media\\u0026token=305ac0e3-fd04-4970-a70d-47121c1bb920\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a3330000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4374), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F291.jpg?alt=media\\u0026token=359dcbca-21d9-4154-a7d0-5551d716bda1\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F292.jpg?alt=media\\u0026token=8ed946de-f900-42a4-8680-1f3d874c5664\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F293.jpg?alt=media\\u0026token=cd51d4ba-d099-40ef-8f04-45c50b510f4d\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F294.jpg?alt=media\\u0026token=57db7ac9-c488-4f98-afef-4cd8fa0099be\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4377), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F301.jpg?alt=media\\u0026token=fab8ea01-086a-4484-b96f-572b425d36d6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F302.jpg?alt=media\\u0026token=88be30a2-6b3b-4959-a55e-8feab75b12e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F303.jpg?alt=media\\u0026token=eda67947-d9fc-4646-a340-d95738ad6706\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4381), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F311.jpg?alt=media\\u0026token=c5d2e774-2892-4050-8e03-6da8b54ad1b5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F312.jpg?alt=media\\u0026token=2f38325a-17d8-463c-8cf7-6ac1a59d0df2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F314.jpg?alt=media\\u0026token=5b8079cb-fc25-46d1-90d8-919b1d17d017\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F315.jpg?alt=media\\u0026token=cad2491a-a26d-4c9d-a047-dec724e86aed\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4384), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F321.jpg?alt=media\\u0026token=cb1d9b94-1df8-43ff-9c40-2cb2db8e48c8\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F322.jpg?alt=media\\u0026token=9ec5a1d9-fe89-43a2-98f4-adf67c778461\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F323.jpg?alt=media\\u0026token=189aea12-33a9-4033-92c9-3aea8de5c297\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("a4440000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4388), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F331.jpg?alt=media\\u0026token=aeac9ff7-f16d-4843-9f8e-547cd5888511\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F332.jpg?alt=media\\u0026token=c6d546a9-22f0-47d0-b7f2-7b865d475026\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ad5fce0f-1e34-4e92-8f71-df6e99cb72c9"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4263), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F31.jpg?alt=media\\u0026token=c76c7f97-077d-4e11-b851-4d14a5348e39\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F32.jpg?alt=media\\u0026token=1d3da6b4-2733-4281-bee0-e9a005d9e3bd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F33.jpg?alt=media\\u0026token=510e194a-cf09-476d-891e-d30976dbcf74\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F34.jpg?alt=media\\u0026token=cd2d6297-a97d-4119-b924-66f84e686091\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F35.jpg?alt=media\\u0026token=5dab756d-23a9-4df1-97a2-ff3b2afedad5\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("be52b9c5-c471-4dc7-bd41-cc5a2f38cdb2"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4276), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F61.jpg?alt=media\\u0026token=63b5b728-ea1f-4511-a780-d3c095a200bf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F62.jpg?alt=media\\u0026token=c7184c0e-1262-4c7c-8124-d830c6077824\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F63.jpg?alt=media\\u0026token=70feba58-f759-40fa-a09a-afc6013a2a4c\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("df4bc05f-450d-43fd-8a8e-87965cf3b6d4"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4283), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F81.jpg?alt=media\\u0026token=6afd1b86-7467-4378-872e-35653af5b8b1\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F82.jpg?alt=media\\u0026token=70835076-bb28-4f0a-840d-8a417e6aed17\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F83.jpg?alt=media\\u0026token=68a06a61-f77e-44a6-80e7-5da69e44d21a\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e075dfa8-0105-485b-a4f7-dc0551b11069"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4301), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F121.jpg?alt=media\\u0026token=9018f821-dd46-4bc6-aa56-0389aea2bf61\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F122.jpg?alt=media\\u0026token=ad974591-aff7-48af-80e6-a6e7e975941c\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F123.jpg?alt=media\\u0026token=7e9514a5-c205-468d-913e-49da8aa8b473\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("e8c4bc1f-38cb-4642-b58f-6e5b31f93961"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4297), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F111.jpg?alt=media\\u0026token=720b5141-852a-42f7-9501-cd21845aea83\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F112.jpg?alt=media\\u0026token=071f3771-b293-4679-a2b8-9705b064e2ee\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("ef67f287-6846-4271-8f6f-ce6e0c8dc72a"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4294), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F102.jpg?alt=media\\u0026token=05c8e1fe-9719-4a40-ac8b-29240968deca\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F105.jpg?alt=media\\u0026token=6a6f785c-b2ff-4d18-a281-6b4fbdb24858\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F101.jpg?alt=media\\u0026token=543a6d27-d8c1-405e-8cc5-d514df96a517\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F103.jpg?alt=media\\u0026token=61052fcb-66f1-4b78-801c-7753c921eedd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F104.jpg?alt=media\\u0026token=d6fa2240-475b-4342-b38f-4ab3ff860c6c\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F106.jpg?alt=media\\u0026token=04b992aa-add3-494d-afb6-163f295101dd\"]" });

            migrationBuilder.UpdateData(
                table: "Activity",
                keyColumn: "ActivityId",
                keyValue: new Guid("f47a6c1c-9d25-41a2-93af-e2c18f22bfa7"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4268), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F41.jpg?alt=media\\u0026token=e217a4d7-e7f4-4b2a-98dd-0a7dd4dc2984\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F42.jpg?alt=media\\u0026token=149048cb-720f-478f-bcd1-422756adf1ac\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F43.jpg?alt=media\\u0026token=828ef767-521b-43a8-92c3-6611901f65e2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F44.jpg?alt=media\\u0026token=f69dd952-5c11-4080-ba90-2dbc7be04fe0\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F45.jpg?alt=media\\u0026token=815c61a0-c821-4208-ad95-0915e193fd9f\"]" });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7497), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F181.jpg?alt=media\\u0026token=861ec090-60c4-4cce-9b2a-fd20a6a2fc55\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F182.jpg?alt=media\\u0026token=6ba6f500-6e06-45ae-9bc1-42ec00bf0464\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F183.jpg?alt=media\\u0026token=b0f66603-ed84-4706-8a10-261b21cb298c\"]", 10600000.0, 11300000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7503), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F221.jpg?alt=media\\u0026token=b2256b37-3360-4459-afe0-7186726d21c5\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F222.jpg?alt=media\\u0026token=7a43cc3a-e217-41ac-a636-5a4ac970d968\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F223.jpg?alt=media\\u0026token=366c16f1-42e2-4294-87a9-ff2ca7e5b9bf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F224.jpg?alt=media\\u0026token=8da7861e-b793-4126-a1d4-e1541b94a286\"]", 19200000.0, 10800000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7507), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F261.jpg?alt=media\\u0026token=5cee2720-206e-4229-b4b5-d87913de7cdd\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F262.jpg?alt=media\\u0026token=6389bd14-f169-4352-a396-9a29f68f0268\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F263.jpg?alt=media\\u0026token=f0089a61-9297-482e-8bb8-1846d6ce43b2\"]", 10900000.0, 10700000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7512), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F301.jpg?alt=media\\u0026token=fab8ea01-086a-4484-b96f-572b425d36d6\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F302.jpg?alt=media\\u0026token=88be30a2-6b3b-4959-a55e-8feab75b12e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F303.jpg?alt=media\\u0026token=eda67947-d9fc-4646-a340-d95738ad6706\"]", 16400000.0, 10300000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7516), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F341.jpg?alt=media\\u0026token=6cd1a961-73ee-484c-8566-9d8797539af4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F342.jpg?alt=media\\u0026token=065f8c5c-45f2-4f48-bbc0-7da25c24c158\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F343.jpg?alt=media\\u0026token=5f5766ec-5fbd-4095-ab88-ebf7f4c1a50a\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F344.jpg?alt=media\\u0026token=fb34619f-9131-4144-add2-afca0ba19b9a\"]", 10400000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7522), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F372.jpg?alt=media\\u0026token=7291e759-0c21-44d3-b21c-2b62c04853e4\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F371.jpg?alt=media\\u0026token=898cb533-86cf-44dc-a119-5b5f96145d27\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F373.jpg?alt=media\\u0026token=398c95a8-aac6-4a5d-b9cb-628964a0294f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F374.jpg?alt=media\\u0026token=0433021f-55ce-4d70-a332-44e6aab49f8e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F375.jpg?alt=media\\u0026token=9d625a9d-06cc-4f71-8169-190168de597f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F376.jpg?alt=media\\u0026token=bcab3f6a-f04f-4084-b72d-39de575881d1\"]", 18600000.0, 10700000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7470), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F11.jpg?alt=media\\u0026token=892ef66c-cd8d-4228-b4ff-092b82961381\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F12.jpg?alt=media\\u0026token=374f97cb-ad21-4633-8381-8081019edabf\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F13.jpg?alt=media\\u0026token=575e9e8b-b7e2-4b84-ac41-2b98313bff4f\"]", 17000000.0, 10500000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7487), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F94.jpg?alt=media\\u0026token=68b2ad20-405c-4353-8dae-e0b6a9a585ea\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F95.jpg?alt=media\\u0026token=bca7674f-dd8a-45ab-85e9-e0a9b9370734\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F93.jpg?alt=media\\u0026token=1190cb37-0960-4738-b183-3659addb4593\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F92.jpg?alt=media\\u0026token=6c678903-0762-44bb-9e34-69c9fbecc053\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F91.jpg?alt=media\\u0026token=aa93f1f6-7464-4016-b32a-dc298f3719a9\"]", 18500000.0, 10000000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7479), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F51.jpg?alt=media\\u0026token=47097c1c-c500-44d3-8737-78a0f2a8b1f2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F52.jpg?alt=media\\u0026token=1e207dfe-0474-4f0f-ad34-37bcb330c20e\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F53.jpg?alt=media\\u0026token=546add09-5243-44b3-a1ff-0b7f8c799539\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F54.jpg?alt=media\\u0026token=7b90f572-93c1-4378-80da-7fe1421f7a06\"]", 13100000.0, 11300000.0 });

            migrationBuilder.UpdateData(
                table: "AgriculturalTourPackage",
                keyColumn: "TourId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                columns: new[] { "CreateDate", "Imgs", "PriceOfAdults", "PriceOfChildren" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7492), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F131.jpg?alt=media\\u0026token=8d1ad1ca-524b-4c04-b987-ff7a72d12fc2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F132.jpg?alt=media\\u0026token=3ba71565-f467-437e-9b65-d71ccb1da6a8\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F133.jpg?alt=media\\u0026token=c02001f3-d8cb-4c16-a3f8-15d822dadf84\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Activity%2F134.jpg?alt=media\\u0026token=2cf26d42-a673-4dde-a41c-6f1076363516\"]", 13900000.0, 10700000.0 });

            migrationBuilder.InsertData(
                table: "BankAccount",
                columns: new[] { "BankAccountId", "AccountName", "AccountNumber", "BankName", "BranchName", "CreatedDate", "IsPrimary", "OwnerId", "OwnerType", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("042c153b-5b59-423c-805f-2db3ec8916c8"), "Bamboo Travel", "0011004478534", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8036), true, new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), 0, null },
                    { new Guid("097b2f9a-66cf-4b3c-9e11-ed3cfb3d7f07"), "Nông Trại Chè Trải Nghiệm Đại Từ", "0011002673948", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7952), true, new Guid("10000000-0000-0000-0000-000000000004"), 1, null },
                    { new Guid("10c384ef-a89c-479d-9c79-055a1339e741"), "Dulichtoday", "0011002010139", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8046), true, new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), 0, null },
                    { new Guid("1225a5d2-a05a-4d41-a97b-eafc99aef46d"), "Saigontourist", "0011004088190", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8020), true, new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), 0, null },
                    { new Guid("197012a4-5d96-4f97-aba2-bdcbb42054e5"), "Fiditour", "0011006779597", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8028), true, new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), 0, null },
                    { new Guid("19c1c3b5-10d2-4620-8c4e-e7a34ed27a04"), "Phương Nam Travel", "0011002438467", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8039), true, new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), 0, null },
                    { new Guid("24c95840-0020-4553-8ac4-b45d52d8cb99"), "Sa Pa Eco Farm Tour", "0011002150952", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7945), true, new Guid("10000000-0000-0000-0000-000000000002"), 1, null },
                    { new Guid("2973fdef-130f-410d-8499-7f8a8049f323"), "Trang Trại Nông Sản Sạch Tân Châu", "0011008200551", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7972), true, new Guid("10000000-0000-0000-0000-000000000011"), 1, null },
                    { new Guid("327934a0-0570-4cf6-8aaa-70a216bf47f7"), "CTCP TRUYỀN THÔNG & DU LỊCH MỘC CHÂU MỘC", "0011009566084", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7927), true, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), 1, null },
                    { new Guid("333e2450-d9cc-4a22-a0ae-98aa6af7fcfa"), "Nha Trang Holiday", "0011005082683", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8053), true, new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), 0, null },
                    { new Guid("358a652b-bb87-4d9f-8708-16cd31ae7ec2"), "Hanoitourist", "0011004056006", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8022), true, new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), 0, null },
                    { new Guid("38cc09af-e98d-4365-9eec-77f158b0b08c"), "VietSun Travel", "0011006304572", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8034), true, new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), 0, null },
                    { new Guid("3b68f298-b97e-472b-9c37-070d48d226d7"), "Trang Trại Nông Sản Sạch Càng Long", "0011008130318", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7977), true, new Guid("10000000-0000-0000-0000-000000000013"), 1, null },
                    { new Guid("403d5ffb-3a9a-41d4-8327-cb99b2894d8a"), "Farmstay Nho & Thanh Long Bắc Bình", "0011009180951", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7967), true, new Guid("10000000-0000-0000-0000-000000000009"), 1, null },
                    { new Guid("4c421da7-110e-4742-91c1-682e3ebc2e27"), "Ba Bể Lake Ecofarm Tour", "0011006023462", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7969), true, new Guid("10000000-0000-0000-0000-000000000010"), 1, null },
                    { new Guid("5473415c-8dfa-463b-a48d-36a41a09697b"), "Công ty Cổ phần Vietravel", "0011009682115", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8015), true, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), 0, null },
                    { new Guid("58b3054c-569d-4884-9498-7d72f52deec7"), "Havatravel", "0011004668769", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8048), true, new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), 0, null },
                    { new Guid("5ec48449-aff5-4357-8aa9-ab97d97d571b"), "Farm Du Lịch Grape Valley", "0011009341694", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7948), true, new Guid("10000000-0000-0000-0000-000000000003"), 1, null },
                    { new Guid("71f442f2-988f-4e50-beef-d4e1ba30dba4"), "Du Lịch Sinh Thái Thác Bản Giốc", "0011005894078", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7942), true, new Guid("10000000-0000-0000-0000-000000000001"), 1, null },
                    { new Guid("7ab4baec-a650-45f6-9cda-aabac7d64cb3"), "Vũng Tàu Travel", "0011002913478", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8051), true, new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), 0, null },
                    { new Guid("8c0eecaf-0a00-4269-b3b1-357fd2052cfb"), "Trang Trại Châu Đốc", "0011007705760", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7982), true, new Guid("10000000-0000-0000-0000-000000000015"), 1, null },
                    { new Guid("9928f3d9-68d8-4a0c-8fa8-1e2c472a5213"), "Trà My Sâm Ngọc Linh Tour", "0011004841017", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7961), true, new Guid("10000000-0000-0000-0000-000000000007"), 1, null },
                    { new Guid("9d05547e-c2b1-40f4-b532-1649dab388f0"), "Trải nghiệm Nông trại Biển & Rau Tuy An", "0011006743429", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7975), true, new Guid("10000000-0000-0000-0000-000000000012"), 1, null },
                    { new Guid("a6ad2ef5-c2f1-4339-930e-ab16fc444cfc"), "Redtour", "0011008644422", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8044), true, new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), 0, null },
                    { new Guid("a8f22afd-d296-4e71-bc34-ebaf13b91b4c"), "Buôn Đôn Coffee Farm Tour", "0011001490822", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7955), true, new Guid("10000000-0000-0000-0000-000000000005"), 1, null },
                    { new Guid("b0bcd906-5638-4125-acdd-77a1e3732afe"), "Hà Giang Farmstay & Trek", "0011005651699", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7957), true, new Guid("10000000-0000-0000-0000-000000000006"), 1, null },
                    { new Guid("b997a562-d898-45dc-a27b-40a0d31c6bc4"), "Danang Travel", "0011004518439", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8032), true, new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), 0, null },
                    { new Guid("bdbba0af-c81b-4c69-95af-af3be342cf1d"), "Đất Việt Tour", "0011008843956", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8041), true, new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), 0, null },
                    { new Guid("f3b5b424-e5bd-4e7e-b98a-f408930c5071"), "Phan Thiết Tours", "0011004871577", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8055), true, new Guid("22275542-0625-47be-a503-2f13b7576e9b"), 0, null },
                    { new Guid("f40ae8e3-2457-4bdc-86ea-2ae2e2ee7b92"), "Đà Lạt Organic Farm Tour", "0011002607141", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7963), true, new Guid("10000000-0000-0000-0000-000000000008"), 1, null },
                    { new Guid("fd7e6e7a-f33f-4ad5-9693-c1bb21cb6f4b"), "Mỹ Xuyên Farmstay", "0011001420243", "Vietcombank", "Hanoi Branch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7978), true, new Guid("10000000-0000-0000-0000-000000000014"), 1, null }
                });

            migrationBuilder.InsertData(
                table: "Blog",
                columns: new[] { "BlogId", "BlogStatus", "BlogType", "Content", "CreateBy", "CreateDate", "Description", "LinkImg", "ReplyRequest", "Title", "UpdateTime" },
                values: new object[,]
                {
                    { new Guid("0d7fa707-c5fc-44d8-9890-4390537554e3"), 0, 2, "<h2>Kết quả giải thưởng năm nay</h2>\r\n    <p>Việt Nam có 17 đơn vị đạt giải tại 04 hạng mục:</p>\r\n    \r\n    <h3>1. Giải thưởng Dịch vụ Spa ASEAN</h3>\r\n    <ul>\r\n        <li>Yoko Onsen Spa, Khu nghỉ dưỡng khoáng nóng Yoko Onsen Quang Hanh - Tỉnh Quảng Ninh</li>\r\n        <li>An Spa - Thành phố Đà Nẵng</li>\r\n        <li>Akoya Spa, Khách sạn nghỉ dưỡng Vinpearl Resort & Golf Nam Hội An - Tỉnh Quảng Nam</li>\r\n        <li>Six Senses Côn Đảo Spa & Wellness Village, Khách sạn nghỉ dưỡng Six Senses Côn Đảo - Tỉnh Bà Rịa - Vũng Tàu</li>\r\n        <li>KARA SPA, Khách sạn Caravelle - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h3>2. Giải thưởng Du lịch cộng đồng ASEAN - CBT ASEAN</h3>\r\n    <ul>\r\n        <li>Điểm du lịch cộng đồng Hữu Liên, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Khu du lịch Hồng Vân, huyện Thường Tín - Thành phố Hà Nội</li>\r\n        <li>Làng Toom Sara Đà Nẵng - Thành phố Đà Nẵng</li>\r\n        <li>Hợp tác xã du lịch dựa vào cộng đồng Cơ tu Nam Giang - Tỉnh Quảng Nam</li>\r\n        <li>Điểm du lịch cộng đồng Cồn Chim - Tỉnh Trà Vinh</li>\r\n    </ul>\r\n    \r\n    <h3>3. Giải thưởng Nhà ở có phòng cho khách du lịch thuê - Homestay ASEAN</h3>\r\n    <ul>\r\n        <li>Cụm Homestay xã Phương Độ, thành phố Hà Giang - Tỉnh Hà Giang</li>\r\n        <li>Cụm Homestay xã Yên Thịnh, huyện Hữu Lũng - Tỉnh Lạng Sơn</li>\r\n        <li>Cụm Homestay Làng Nhà sàn dân tộc sinh thái Thái Hải - Tỉnh Thái Nguyên</li>\r\n        <li>Cụm Homestay Làng cổ Đường Lâm, Thành phố Hà Nội</li>\r\n        <li>Cụm Homestay Giồng Trôm - Bình Đại - Tỉnh Bến Tre</li>\r\n    </ul>\r\n    \r\n    <h3>4. Giải thưởng Nhà vệ sinh cộng cộng ASEAN</h3>\r\n    <ul>\r\n        <li>Nhà vệ sinh cộng cộng - Đài quan sát Saigon SkyDeck - Tháp tài chính Bitexco - Thành phố Hồ Chí Minh</li>\r\n        <li>Vạn Thịnh Rest Stop - Hộ Kinh doanh Trạm dừng chân Vạn Thịnh - Thành phố Hồ Chí Minh</li>\r\n    </ul>\r\n    \r\n    <h2>Ý nghĩa của giải thưởng</h2>\r\n    <p>Việc các doanh nghiệp du lịch Việt Nam nhận được những giải thưởng quan trọng của ASEAN đã góp phần khẳng định quyết tâm nâng cao chất lượng dịch vụ của du lịch Việt Nam.</p>\r\n    <p>Điều này thể hiện cam kết theo phương châm hành động tại Nghị quyết 82/NQ-CP của Chính phủ: \"Sản phẩm đặc sắc - Dịch vụ chuyên nghiệp - Thủ tục thuận tiện, đơn giản - Giá cả cạnh tranh - Môi trường vệ sinh sạch đẹp - Điểm đến an toàn, văn minh, thân thiện\".</p>\r\n    <p>Đây cũng là điểm nhấn khẳng định sự phục hồi ấn tượng của du lịch Việt Nam trong năm vừa qua, đón 17,6 triệu lượt khách quốc tế, tăng 40% so với năm 2023, phục vụ 110 triệu lượt khách nội địa và tổng thu du lịch đạt 840 nghìn tỷ đồng.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Trong khuôn khổ Diễn đàn Du lịch ASEAN (ATF) 2025 tại Malaysia, tối ngày 20/1 đã diễn ra Lễ trao Giải thưởng Du lịch ASEAN 2025 và Lễ Bế mạc ATF 2025.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fdsc4926-1737442964915949022440.webp?alt=media&token=f4a50238-d2f3-4032-ba89-65c47093ac0a", null, "Giải thưởng Du lịch ASEAN 2025 tôn vinh 17 đơn vị của Việt Nam", null },
                    { new Guid("10d83f63-b284-46aa-a465-a23bb8e6af9a"), 0, 2, "<p>Cùng dự có bà Nguyễn Phương Hòa, Cục trưởng Cục Hợp tác quốc tế; bà Phan Linh Chi, Phó Cục trưởng Cục Du lịch Quốc gia Việt Nam cùng các cán bộ thuộc Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế.</p>\r\n\r\n    <h2>Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire</h2>\r\n    <img src=\"path_to_image\" alt=\"Thứ trưởng Bộ VHTTDL Trịnh Thị Thủy tiếp Tổng Giám đốc OIF Caroline St-Hilaire\">\r\n    <p>Vui mừng tiếp đón bà Caroline St-Hilaire cùng đoàn công tác đến thăm, làm việc tại trụ sở Bộ VHTTDL, Thứ trưởng Trịnh Thị Thủy khẳng định, Việt Nam luôn coi trọng quan hệ hợp tác với OIF cùng các nước trong cộng đồng Pháp ngữ, từ quan hệ chính trị cho đến hợp tác về văn hóa, thể thao và du lịch.</p>\r\n\r\n    <p>Các hoạt động của OIF luôn nhận được sự quan tâm của lãnh đạo Đảng, Nhà nước Việt Nam. Trong đó vào tháng 10/2024, Tổng Bí thư Tô Lâm đã dự Hội nghị cấp cao Pháp ngữ lần thứ 19. Đồng thời gửi lời cảm ơn đến những hỗ trợ của OIF cho các hoạt động của Việt Nam trong cộng đồng Pháp ngữ.</p>\r\n\r\n    <p>Về phía ngành VHTTDL, các hoạt động chuyên môn được tổ chức có sự gắn kết giữa ngành với cộng đồng Pháp ngữ. Thông qua các hoạt động VHTTDL, Việt Nam đã tăng cường sự hiện diện, thể hiện là thành viên có trách nhiệm trong cộng đồng Pháp ngữ thời gian qua.</p>\r\n\r\n    <h2>Toàn cảnh buổi tiếp</h2>\r\n    <img src=\"path_to_image\" alt=\"Toàn cảnh buổi tiếp\">\r\n    <p>Bộ VHTTDL mong muốn thúc đẩy quan hệ hợp tác với OIF cùng các nước thành viên của cộng đồng Pháp ngữ; tiếp tục tăng cường sự hiện diện của Việt Nam trong các hoạt động, Thứ trưởng Trịnh Thị Thủy khẳng định.</p>\r\n\r\n    <p>Việt Nam đã, đang và sẽ tham gia tích cực các hoạt động của OIF cũng như mong muốn tiếp tục nhận được sự quan tâm, giúp đỡ của tổ chức khi triển khai các hoạt động, nhất là các hoạt động hợp tác, giao lưu, quảng bá VHTTDL.</p>\r\n\r\n    <h2>Về du lịch</h2>\r\n    <p>Thứ trưởng Trịnh Thị Thủy cho biết, Chính phủ Việt Nam xác định du lịch là một trong những ngành kinh tế mũi nhọn, đóng góp tích cực cho tăng trưởng kinh tế - xã hội của Việt Nam. Kết nối văn hóa - du lịch với các quốc gia trong cộng đồng Pháp ngữ là một trong những ưu tiên của Việt Nam. Việt Nam mong muốn OIF hỗ trợ phát triển du lịch nông thôn, du lịch cộng đồng cũng như công tác quảng bá văn hóa - du lịch Việt Nam đến các quốc gia trong cộng đồng.</p>\r\n\r\n    <h2>Về văn hóa, nghệ thuật</h2>\r\n    <p>Việt Nam hiện tập trung vào hai đối tượng để phát triển đó là nghệ sĩ và sinh viên trường nghệ thuật. Trong đó, chú ý mời các chuyên gia quốc tế tới Việt Nam huấn luyện chuyên môn cho nghệ sĩ và sinh viên ở các loại hình nghệ thuật đặc thù như múa ba-lê, sản xuất phim hoạt hình, áp dụng kỹ thuật vào làm phim,... Thứ trưởng mong muốn OIF hỗ trợ kết nối nghệ sĩ Việt Nam với các nghệ sĩ trong cộng đồng Pháp ngữ, giúp các nghệ sĩ Việt Nam học hỏi được thêm kinh nghiệm biểu diễn; nâng cao trình độ nguồn nhân lực cho lĩnh vực nghệ thuật biểu diễn, điện ảnh của Việt Nam; hỗ trợ đoàn nghệ sĩ Việt Nam khi đến các nước thuộc cộng đồng. Cùng với đó, các hoạt động phát triển ngôn ngữ giữa các bên cũng cần được đẩy mạnh.</p>\r\n\r\n    <h2>Về thể thao</h2>\r\n    <p>Thứ trưởng đề nghị OIF hỗ trợ Việt Nam nâng cao năng lực, trình độ cho các HLV, VĐV; giúp các VĐV của Việt Nam cải thiện thành tích ở các đấu trường quốc tế.</p>\r\n\r\n    <h2>Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Tổng Giám đốc OIF Caroline St-Hilaire tặng quà lưu niệm\">\r\n    <p>Tổng Giám đốc OIF Caroline St-Hilaire thể hiện sự nhất trí cao với những đề xuất của Thứ trưởng Trịnh Thị Thủy. Theo bà Caroline St-Hilaire, đây đều là những sáng kiến giúp phát triển quan hệ giữa Việt Nam - OIF và các nước thuộc cộng đồng Pháp ngữ, đồng thời thể hiện cam kết mạnh mẽ của Việt Nam trong thúc đẩy hợp tác VHTTDL với OIF.</p>\r\n\r\n    <h2>Chụp hình lưu niệm</h2>\r\n    <img src=\"path_to_image\" alt=\"Lãnh đạo hai bên chụp hình lưu niệm\">\r\n    <p>“Việt Nam là thành viên trách nhiệm, tích cực của OIF khi tham gia nhiều hoạt động văn hóa, thể thao của cộng đồng Pháp ngữ. Việt Nam là quốc gia có nhiều di sản văn hóa ấn tượng, cảnh quan thiên nhiên hùng vĩ. OIF sẽ hỗ trợ Việt Nam thúc đẩy quảng bá văn hóa - du lịch.”, bà Caroline St-Hilaire đánh giá.</p>\r\n\r\n    <p>Tổng Giám đốc OIF khẳng định, OIF luôn sẵn sàng lắng nghe, hỗ trợ Việt Nam tổ chức các hoạt động thúc đẩy hợp tác VHTTDL với các nước trong cộng đồng, đồng thời cam kết hỗ trợ Việt Nam trong công tác đào tạo nguồn nhân lực lĩnh vực VHTTDL.</p>\r\n\r\n    <p>Trong thời gian tới, OIF sẽ thực hiện thí điểm dự án phát triển du lịch bền vững tại các nước khu vực Đông Nam Á, trong đó có Việt Nam, với trọng tâm là tăng cường vai trò của thanh niên, thúc đẩy tính chuyên nghiệp trong phát triển du lịch bền vững. Tổng Giám đốc OIF bày tỏ mong muốn Bộ VHTTDL sẽ cùng hợp tác thực hiện triển khai dự án này.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Sáng 20/1, tại trụ sở Bộ Văn hóa, Thể thao và Du lịch, Thứ trưởng Trịnh Thị Thủy đã có buổi tiếp và làm việc với bà Caroline St-Hilaire, Tổng Giám đốc Tổ chức Quốc tế Pháp ngữ (OIF).", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2.jpeg?alt=media&token=8dc70894-e01b-4caf-83dd-68dad34318c2", null, "Tổ chức Quốc tế Pháp ngữ mong muốn tăng cường hợp tác văn hóa, thể thao, du lịch với Việt Nam", null },
                    { new Guid("2b4bb217-cb05-4cd4-a3f4-ba7d44755d5b"), 0, 1, "<p>\"Để tạo không khí, không gian trải nghiệm Tết, huyện sẽ tổ chức đa dạng các lễ hội xuân, các hoạt động vui chơi, giải trí trên địa bàn huyện, ở các thôn khe bản... đáp ứng nhu cầu hưởng thụ, vui xuân của bà con và cũng là điểm đến hấp dẫn cho hành trình du xuân của du khách\" - ông Vi Ngọc Nhất, Trưởng Phòng Văn hoá - Thông tin huyện cho biết.</p>\r\n\r\n    <h2>Không khí Tết ở Bình Liêu</h2>\r\n    <p>Xuân này về Bình Liêu, du khách sẽ được hoà mình vào không gian Lễ hội đình Lục Nà, lễ hội được mong đợi nhất dịp đầu xuân.</p>\r\n    <p>Về Bình Liêu ngay từ tháng Chạp, du khách đã cảm nhận được không khí Tết đang cận kề bên từng nếp nhà của người Dao, trên những cành đào đá nở sớm. Có lẽ điều mà nhiều du khách thích thú tìm hiểu, hoà mình vào nhất là Tết của người Dao, một lễ hội, nét văn hoá đặc sắc ở Bình Liêu. Người Dao ở đây ăn Tết từ 15 tháng Chạp cho tới 15 tháng Giêng của năm mới. Trong suốt một tháng Tết, người Dao luân phiên ăn Tết từng hộ gia đình trong họ. Rộn ràng nhất là từ 20 tháng Chạp tới rằm tháng Giêng. Không khí Tết, màu sắc Tết sẽ rộn ràng khắp ngõ xóm, làng bản của người Dao.</p>\r\n\r\n    <h2>Lễ hội truyền thống</h2>\r\n    <p>Mỗi cộng đồng dân tộc ở Bình Liêu đều có phong tục đón năm mới riêng. Đây chính là mảnh ghép để làm nên bức tranh văn hóa Tết cổ truyền đặc sắc nơi miền biên viễn. Người Tày tại Bình Liêu thường tổ chức nghi lễ Then để cầu phúc, cầu an vào dịp đầu năm và lễ tạ vào dịp cuối năm. Ngoài thưởng thức không gian đậm chất văn hoá truyền thống, người dân và du khách còn có cơ hội tham gia những trò chơi dân gian... được tổ chức ở quy mô cấp thôn, cấp xã.</p>\r\n\r\n    <h3>Lễ hội đình Lục Nà</h3>\r\n    <p>Tết đến xuân về cũng là thời điểm mà Bình Liêu tổ chức nhiều lễ hội truyền thống. Lễ hội lớn nhất và được mong đợi nhất là Lễ hội đình Lục Nà, tổ chức thường niên từ 15-17 tháng Giêng hàng năm. Lễ hội nổi bật với nghi lễ rước sắc phong, lễ tế thần... và nhiều hoạt động văn hoá, thể thao dân tộc. Du khách có thể hoà mình vào các trò chơi tung còn, đẩy gậy, kéo co, đánh quay... hoặc thưởng thức những làn điệu then trong trẻo cùng tiếng đàn tính ngọt ngào giữa núi rừng.</p>\r\n\r\n    <h3>Hội Soóng cọ của người Sán Chỉ</h3>\r\n    <p>Tiếp theo, hội Soóng cọ của người Sán Chỉ tổ chức thường niên vào 16/3 âm lịch. Lễ hội sẽ tái hiện một số trò chơi dân gian và nghi lễ tâm linh. Nơi đây, du khách có thể hoà mình vào các chương trình văn nghệ hát giao duyên, lễ cầu may của người Sán Chỉ... Điểm mới của lễ hội năm nay là có nhiều hoạt động văn hoá, thể thao sôi động, hoạt động tôn vinh cây dong riềng, miến dong gắn với hoạt động tham quan thác Khe Vằn, đỉnh Cao Ly...</p>\r\n\r\n    <h3>Lễ hội Kiêng gió</h3>\r\n    <p>Không những thế, năm nay là dịp đặc biệt khi Lễ hội Kiêng gió sẽ được tổ chức vào dịp 30/4-01/5 gắn với lễ công bố tục kiêng gió người Dao Thanh Phán là Di sản văn hóa phi vật thể quốc gia. Lễ hội là dịp du khách thưởng thức các tiết mục hát Pả dung, trích đoạn đám cưới người Dao Thanh Phán, trích lễ cấp sắc của người Dao, múa, hát Then… của đồng bào các dân tộc Bình Liêu.</p>\r\n\r\n    <h2>Hoạt động Tết Nguyên Đán 2025</h2>\r\n    <p>Dịp Tết Nguyên đán 2025 năm nay, Bình Liêu đã công bố và sẽ tổ chức khoảng 30 hoạt động văn hoá, thể thao đặc sắc ở khắp 7 xã, thị trấn của huyện. Các hoạt động này sẽ trải dài từ trước, trong và sau Tết Nguyên đán 2025. Đặc biệt, huyện sẽ khôi phục và tổ chức Lễ hội đình Vô Ngại trong 2 ngày 5-6 tháng Giêng.</p>\r\n\r\n    <h2>Du lịch xuyên Tết</h2>\r\n    <p>Được biết, để phục vụ du khách du xuân trảy hội, du lịch xuyên Tết, Bình Liêu cũng đã vận động, khuyến khích mở, duy trì các dịch vụ ăn uống, lưu trú trong dịp Tết. Hiện nay, huyện đã công bố danh sách 14 cơ sở lưu trú là khách sạn, nhà nghỉ, homestay và 6 nhà hàng, quán ăn phục vụ du khách xuyên Tết.</p>\r\n\r\n    <p>Vậy là, xuân này về Bình Liêu, du khách sẽ được du ngoạn xuyên Tết, trải nghiệm không khí tưng bừng, rộn ràng của lễ hội, thưởng lãm thiên nhiên hùng vĩ, hoang sơ của thác Khe Vằn, ruộng bậc thang, những cung đường biên giới uốn lượn và thưởng thức những món ẩm thực đặc sắc của đồng bào.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Hòa trong không khí xuân đang về trên khắp bản làng miền biên viễn, huyện Bình Liêu (tỉnh Quảng Ninh) sẽ tổ chức nhiều lễ hội xuân, các hoạt động văn nghệ, thể thao... phục vụ nhân dân và du khách gần xa.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F1110.binh-lieu.jpg?alt=media&token=98060066-e58f-4a1d-929f-76c2f4017475", null, "Bình Liêu - Quảng Ninh: Sôi động các lễ hội, hoạt động vui xuân", null },
                    { new Guid("42c0b897-97db-4181-9cbb-e71fe4dd4e39"), 0, 2, "<h2>Bà con Sán Chỉ trò chuyện với du khách trong Hội Mùa vàng Bình Liêu năm 2024</h2>\r\n    <p>Từ bao đời nay, cộng đồng dân cư ở Quảng Ninh sống quần cư với tinh thần đoàn kết, trọng tình, trọng nghĩa. Truyền thống này thể hiện ở chữ hiếu với cha mẹ, ông bà, tôn sư trọng đạo, tôn vinh các bậc tiền bối có công khai khẩn mở mang quê hương. Nhiều nơi ở Quảng Ninh có tục tế tổ, chạp tổ, tảo mộ, có miếu thờ Tiên Công.</p>\r\n    <p>Người Quảng Ninh cũng phóng khoáng và tự do trong tư duy nên đây là miền đất có nhiều lễ hội dân gian mang tính xã hội và tính nhân văn cao, là thông điệp nối kết quá khứ và hiện tại. Các lễ hội có phần nghi lễ nghiêm trang, phần hội phóng khoáng, vui vẻ giúp con người gắn kết lại với nhau.</p>\r\n\r\n    <h2>Rước kiệu trong lễ hội đại phan của người Sán Dìu ở xã Hải Hòa, TP Cẩm Phả</h2>\r\n\r\n    <p>Tại Quảng Ninh, cộng đồng tham gia lễ hội còn bao gồm đông đảo khách du lịch. Theo cách hiểu đó, sinh hoạt lễ hội là sinh hoạt văn hoá cộng đồng không chỉ là sinh hoạt cộng đồng của dân cư bản địa mà còn của du khách đến từ nhiều vùng khác. Do đó, hoà mình vào không khí lễ hội, nghĩa là du khách đã được trải nghiệm, được trao truyền các giá trị văn hoá. Do vậy, tính chất bảo tồn đã có sẵn ở hoạt động đó.</p>\r\n\r\n    <p>Tại các lễ hội ở Quảng Ninh, những trò chơi truyền thống như đua thuyền, các đám rước, các tập tục dân gian gắn với lễ hội cũng cần được lan tỏa, để du khách có thể trực tiếp trải nghiệm. Nhập vai vào các hình thức diễn xướng đó, người trải nghiệm không chỉ là du khách, mà còn như một người dân thực thụ, một thành viên trong cộng đồng có lễ hội... Điều này sẽ kích thích và tạo ra sức hút đối với du khách khi hòa mình vào không khí lễ hội.</p>\r\n\r\n    <p>Sự tham gia của cộng đồng du khách cũng sẽ tạo ra sự kết nối các lễ hội, trong đó có lễ hội ở vùng Yên Tử. GS.TS Lê Hồng Lý, Chủ tịch Hội Văn nghệ dân gian Việt Nam, cho rằng, lễ hội dân gian nói lên sự phong phú của không gian văn hóa Yên Tử. Theo không gian của dãy Yên Tử thì lễ hội dân gian trong khu vực này không chỉ thuộc khu vực Yên Tử, mà còn là một hệ thống chuỗi lễ hội suốt dãy Yên Tử trải qua các tỉnh Hải Dương, Bắc Giang và Quảng Ninh. Vì thế, lễ hội dân gian cũng như các loại hình khác không dừng lại ở một điểm mà trải rộng trên một không gian lớn và có sự kết nối giữa các nơi để thành một không gian văn hóa tâm linh hết sức hấp dẫn. Hơn nữa, các lễ hội này không phải chỉ là những lễ hội tôn giáo đơn thuần mà là rất nhiều lễ hội dân gian diễn ra xung quanh khu vực, để tạo nên một không gian văn hóa tín ngưỡng hấp dẫn. Riêng ở Quảng Ninh có thể điểm ra các lễ hội như: Lễ hội đền An Sinh, lễ hội của các làng ven dãy Yên Tử. Kết nối với các lễ hội theo dãy Yên Tử là nhiều lễ hội khác liên quan đến nhà Trần trên đất Quảng Ninh như: Lễ hội Bạch Đằng, Lễ hội đền Đức Ông, Lễ hội đền Cửa Ông, Lễ hội Vân Đồn...</p>\r\n\r\n    <h2>Quang cảnh không gian chính tổ chức lễ hội mùa vàng miền sóong cọ xã Đại Dực, huyện Tiên Yên</h2>\r\n\r\n    <p>Bên cạnh việc bảo tồn lễ hội truyền thống, Quảng Ninh cũng xây dựng và duy trì nhiều lễ hội hiện đại đã được cộng đồng cư dân bản địa và du khách đón nhận. Theo các nhà nghiên cứu văn hoá, lễ hội hiện đại là cơ hội quảng bá tiềm năng thế mạnh những thành tựu phát triển kinh tế - xã hội, quảng bá văn hoá con người Quảng Ninh nói riêng, Việt Nam nói chung. Lễ hội Hoa anh đào hay Lễ hội Hokkaido gần đây là những ví dụ điển hình cho việc thắt chặt quan hệ ngoại giao giữa Việt Nam với các nước trên thế giới, trong đó có ngoại giao nhân dân, thông qua hoạt động văn hoá lễ hội. Đây sẽ là mẫu hình tương lai cho nhiều hoạt động văn hoá tương tự, cho thấy vị trí kết nối hội tụ và lan toả của Quảng Ninh. Không chỉ kết nối với Hải Phòng, Bắc Giang, Hải Dương, mà còn ra các vùng khác trong nước và vượt ra ngoài biên giới.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Chủ thể của lễ hội là cộng đồng, cộng đồng làng, cộng đồng nghề nghiệp, cộng đồng tôn giáo tín ngưỡng, cộng đồng thị dân và lớn hơn cả là cộng đồng quốc gia dân tộc. Cộng đồng chính là chủ thể sáng tạo, hoạt động, hưởng thụ và bảo tồn các giá trị văn hóa của lễ hội.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2273623_quang_canh_khong_gian_chinh_to_chuc_le_hoi_14003627.jpg?alt=media&token=4023df7a-8efc-4de0-b6dd-b5cdfa0af4d0", null, "Quảng Ninh: Cộng đồng tham gia bảo tồn các giá trị văn hoá", null },
                    { new Guid("49026da6-579f-4823-bf94-5e4679aa372d"), 0, 2, "<h2>Những điểm đến đặc sắc</h2>\r\n    <p><strong>KDL Suối Mơ</strong> dự kiến đón từ 35-40 ngàn lượt khách với nhiều hoạt động miễn phí như trò chơi dân gian, múa lân, biểu diễn thư pháp, xếp lá dừa...</p>\r\n    <p><strong>KDL Bửu Long</strong> trang trí hơn 50 ngàn chậu hoa, tổ chức chương trình biểu diễn nghệ thuật với giá vé không đổi: 150.000đ/người lớn, 60.000đ/trẻ em.</p>\r\n    <p>Năm 2025, Đồng Nai tổ chức nhiều lễ hội lớn như: <span class=\"highlight\">Lễ hội Hương bưởi Tân Triều, Lễ hội Khinh khí cầu quốc tế, Festival gốm Biên Hòa</span>.</p>\r\n    \r\n    <h2>Bảo đảm vui chơi an toàn</h2>\r\n    <p>Các khu vui chơi dưới nước như Suối Mơ, Sơn Tiên, Bửu Long, Bò Cạp Vàng, Tre Việt tăng cường đảm bảo an toàn, bố trí nhân viên cứu hộ.</p>\r\n    <p>Giám đốc Sở Văn hóa, Thể thao và Du lịch yêu cầu các cơ sở du lịch phải:</p>\r\n    <ul>\r\n        <li>Bố trí đủ lực lượng phục vụ khách.</li>\r\n        <li>Đảm bảo vệ sinh an toàn thực phẩm.</li>\r\n        <li>Tăng cường nhân viên cứu hộ, chuyên gia hướng dẫn khách.</li>\r\n        <li>Rà soát khu vực nguy hiểm, lắp đặt biển cảnh báo.</li>\r\n        <li>Kiểm tra thiết bị trò chơi mạo hiểm thường xuyên.</li>\r\n    </ul>\r\n    \r\n    <p>Với sự chuẩn bị kỹ lưỡng, du lịch Đồng Nai hứa hẹn sẽ là điểm đến hấp dẫn dịp Tết Nguyên đán 2025.</p>", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Các khu, điểm du lịch trên địa bàn Đồng Nai như: Khu du lịch Công viên Suối Mơ (KDL), Vườn quốc gia Cát Tiên (huyện Tân Phú); KDL Bửu Long, Vườn Xoài… (thành phố Biên Hòa); KDL sinh thái Bò Cạp Vàng, Làng du lịch sinh thái Tre Việt (huyện Nhơn Trạch); núi Chứa Chan (huyện Xuân Lộc)… đã sẵn sàng mùa cao điểm đón khách du lịch dịp Tết Nguyên đán.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F185215_1-dongnai02.jpg?alt=media&token=6641c733-758a-4e47-a816-f18757f3d646", null, "Du lịch Đồng Nai sẵn sàng vào mùa cao điểm Tết Nguyên đán", null },
                    { new Guid("492bf1af-f585-4f6a-bc77-df6758239835"), 0, 2, "<h2>Tiềm năng phát triển du lịch cộng đồng</h2>\r\n    <p>Đắk Lắk có dân số gần 2 triệu người với 49 dân tộc từ các vùng miền trong cả nước. Đồng bào Ê Đê, M’nông và Gia Rai là các dân tộc thiểu số tại chỗ, ngoài ra còn có các dân tộc khác như Mường, Tày, Nùng, Dao, Thái, Mông.</p>\r\n    <p>Không gian văn hóa cồng chiêng Tây Nguyên đã được UNESCO ghi danh là Di sản văn hóa phi vật thể đại diện của nhân loại.</p>\r\n    \r\n    <h2>Điểm du lịch sinh thái và danh thắng</h2>\r\n    <p>Đắk Lắk có nhiều danh thắng như thác Dray Nur, Dray Sáp Thượng, Thủy Tiên, Bìm Bịp, hồ Lắk, Ea Kao, Ea Súp... cùng hệ sinh thái đa dạng như Vườn quốc gia Yok Đôn, Chư Yang Sin.</p>\r\n    \r\n    <h2>Chính sách phát triển du lịch</h2>\r\n    <p>Năm 2022, Tỉnh ủy Đắk Lắk ban hành Đề án phát triển du lịch giai đoạn 2021-2025, định hướng đến năm 2030. Năm 2021, HĐND tỉnh ban hành Nghị quyết hỗ trợ phát triển du lịch cộng đồng.</p>\r\n    \r\n    <h2>Kết quả đạt được</h2>\r\n    <p>Giai đoạn 2021-2023, tỉnh đã hỗ trợ phát triển du lịch cộng đồng tại buôn Akǒ Dhông, buôn Kuốp và buôn Trí. Năm 2024, Đắk Lắk thu hút hơn 2,4 triệu lượt khách, doanh thu đạt hơn 9.000 tỷ đồng.</p>\r\n    \r\n    <h2>Mục tiêu phát triển</h2>\r\n    <p>Trong năm 2025, tỉnh tiếp tục hỗ trợ du lịch cộng đồng tại buôn Tour (Hòa Phú) và buôn Kli A (Đạt Hiếu). Đến năm 2030, Đắk Lắk đặt mục tiêu đưa du lịch trở thành ngành kinh tế mũi nhọn.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Đắk Lắk là vùng đất nổi bật với những sản vật có giá trị cao về kinh tế và văn hóa gắn với phát triển du lịch cộng đồng như du lịch voi, văn hóa ẩm thực... làm cơ sở để phát triển hệ thống sản phẩm du lịch đặc thù, nâng cao vị thế và năng lực cạnh tranh của tỉnh trên thị trường điểm đến.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fz4892392984516_d64f19ae34659675050a19405d2f2f06_20231118151316.jpg?alt=media&token=88ce1721-d11a-4f70-975f-8159879d38af", null, "Đắk Lắk phát triển tiềm năng du lịch cộng đồng", null },
                    { new Guid("54e371c1-8abd-497e-83b7-94c1f04a774c"), 0, 1, " <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp.</p>\r\n    \r\n    <p>Trong không gian Tết ấm cúng, du khách sẽ được tham gia vào các hoạt động truyền thống như dựng cây nêu, gói bánh chưng, viết thư pháp… Ngoài ra, hoạt động in tranh Đông Hồ cũng sẽ được tái hiện, mang đến không khí Tết xưa và là cơ hội để mọi người tự tay tạo ra những tác phẩm nghệ thuật độc đáo. Các em nhỏ sẽ được chơi các trò chơi dân gian hấp dẫn như kéo co, cỏ búng, đập phủ phủ, đánh cầu lông gà, đánh mảng, đánh quay, ném pao, tung còn, đẩy gậy… Những trò chơi này không chỉ mang tính giải trí mà còn giúp các em hiểu rõ hơn về giá trị văn hóa truyền thống của dân tộc.</p>\r\n\r\n    <p>Năm nay, chương trình có thêm những điểm nhấn đặc biệt, ứng dụng công nghệ để mang đến trải nghiệm mới mẻ, thú vị cho du khách, đặc biệt là giới trẻ. Du khách sẽ được tham gia vào các hoạt động như “Vượt thử thách khám phá Tết Ất Tỵ”, nơi họ sẽ tìm hiểu những đặc trưng của Tết qua các câu đố và thử thách thú vị. Bên cạnh đó, chương trình “Tour năm rắn” sẽ giúp du khách tìm hiểu về loài rắn trong văn hóa dân tộc, qua hiện vật tại bảo tàng. Du khách cũng có cơ hội trải nghiệm vẽ rắn và tìm hiểu ý nghĩa của loài vật này trong các truyền thuyết và tín ngưỡng dân gian của nhiều dân tộc.</p>\r\n\r\n    <p>Với sự kết hợp giữa các hoạt động truyền thống và công nghệ hiện đại, chương trình “Vui xuân Ất Tỵ” hứa hẹn sẽ là một trải nghiệm đầy màu sắc, mang đậm bản sắc văn hóa dân tộc và là cơ hội để du khách khám phá và trải nghiệm Tết cổ truyền trong không gian đậm đà sắc xuân.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Nhằm hưởng ứng chương trình “Vui xuân Ất Tỵ: Sắc thái văn hóa Mường, Hòa Bình”, Bảo tàng Dân tộc học Việt Nam (Hà Nội) sẽ tổ chức chuỗi hoạt động đặc sắc vào hai ngày mùng 4-5 Tết (tức ngày 01 và 02/02 dương lịch).", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F114885_LTT_4830.jpg?alt=media&token=50e303f4-7cc3-42c1-a79e-f5041a1d4389", null, "Trải nghiệm Tết truyền thống cùng sắc thái văn hóa Mường, Hòa Bình", null },
                    { new Guid("57015234-d97d-4de6-99dd-3da10b137e70"), 0, 2, "<p>Ngoài ra, đồng bào các dân tộc huyện Bát Xát còn bảo tồn, trao truyền và phát triển các nghề thủ công truyền thống độc đáo, như đan lát tre, mây, nứa, vầu; ủ bia của người Hà Nhì, chạm khắc bạc, nấu rượu của người Dao; may thêu, dệt vải, rèn nông cụ của người Mông, Dao…</p>\r\n\r\n    <p>Ông Phạm Văn Tâm, Trưởng Phòng Văn hóa - Thông tin huyện Bát Xát cho biết: Để văn hóa các dân tộc ngày càng đậm đà bản sắc, các cấp, ngành chức năng của huyện đã triển khai, thực hiện nhiều giải pháp hữu hiệu gìn giữ, phát huy “sức mạnh mềm” của văn hóa.</p>\r\n\r\n    <p>Huyện Bát Xát đã triển khai Đề án 05 về “Phát triển du lịch gắn với bảo tồn và phát huy bản sắc văn hóa các dân tộc huyện Bát Xát giai đoạn 2020 - 2025”; phối hợp với các sở, ngành đẩy nhanh công tác quy hoạch, trọng tâm là khu vực Y Tý; rà soát thống kê, quản lý các tài nguyên du lịch; xây dựng Đề án phát triển du lịch Y Tý đến năm 2030, tầm nhìn đến năm 2050; thành lập Ban Chỉ đạo du lịch cấp huyện, Tổ quản lý du lịch Y Tý - Mường Hum và xây dựng Đề án thành lập Ban Quản lý Di tích và phát triển du lịch cấp huyện. Đồng thời, tăng cường xúc tiến, quảng bá du lịch trên các kênh truyền thông, qua các sự kiện, hội nghị; bước đầu hình thành và gắn kết chuỗi sản phẩm OCOP, đặc sản địa phương, làng nghề truyền thống với các hoạt động du lịch…</p>\r\n\r\n    <p>Đến nay, huyện Bát Xát có 2 di tích được công nhận cấp quốc gia và 7 di tích cấp tỉnh. Thời gian tới, huyện Bát Xát tập trung nâng cao chất lượng phong trào “Toàn dân đoàn kết xây dựng đời sống văn hóa”; tạo thuận lợi để đội ngũ nghệ nhân ở địa phương sáng tạo, trao truyền nét đẹp bản sắc văn hóa dân tộc cho thế hệ trẻ và tham gia các hoạt động quảng bá bản sắc văn hóa truyền thống, góp phần thúc đẩy du lịch địa phương phát triển theo phương châm “biến di sản thành tài sản”.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Huyện Bát Xát (Lào Cai) có 23 nhóm ngành dân tộc, sở hữu kho tàng văn hóa, nghệ thuật lớn, với nhiều di sản văn hóa phi vật thể, như: Nghi lễ cấp sắc của người Dao; Lễ hội Roóng Poọc của người Giáy; Lễ hội Khô Già Già của người Hà Nhì đen; Nghệ thuật múa khèn của người Mông; Lễ Khoi Kìm của người Dao; Lễ Gạ Ma Do của người Hà Nhì; Nghi lễ Then của người Giáy; Lễ hội Pút Tồng của người Dao đỏ; Tri thức dân gian trong canh tác ruộng bậc thang của người Hà Nhì...", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F0-2346.webp?alt=media&token=60da574f-ccd0-4e3d-9bf6-74a1c6a64728", null, "Lào Cai: Bát Xát bảo tồn, phát huy bản sắc văn hóa dân tộc", null },
                    { new Guid("7a4bf589-27d5-4f80-a7f1-7fd1f72da947"), 0, 2, "<p>Buổi lễ có sự tham dự của các Bộ trưởng, Thứ trưởng phụ trách du lịch, lãnh đạo cơ quan du lịch các quốc gia ASEAN, các đối tác, tổ chức quốc tế, phóng viên báo chí khu vực và quốc tế.</p>\r\n\r\n<p>Diễn ra từ ngày 15-20/01/2025, đoàn Việt Nam do Thứ trưởng Bộ Văn hóa, Thể thao và Du lịch Hồ An Phong làm trưởng đoàn, cùng Cục trưởng Cục Du lịch Quốc gia Việt Nam Nguyễn Trùng Khánh và các cán bộ Cục Du lịch Quốc gia Việt Nam, Cục Hợp tác quốc tế (Bộ VHTTDL) đã tham dự hàng loạt các hội nghị và sự kiện bên lề của ATF 2025 như: Hội nghị Bộ trưởng Du lịch ASEAN lần thứ 28, Hội nghị Bộ trưởng Du lịch với các đối tác ASEAN+3 lần thứ 24; Hội nghị Bộ trưởng Du lịch ASEAN - Ấn Độ lần thứ 12; Hội nghị Bộ trưởng Du lịch ASEAN - Nga lần thứ 4; Hội nghị Cơ quan Du lịch Quốc gia ASEAN lần thứ 61; Hội nghị Cơ quan Du lịch Quốc gia với các đối tác; chương trình làm việc với các tổ chức quốc tế như CNN, Agoda, WTTC, US-ABC, EU-ABC...</p>\r\n\r\n<p>Các đại biểu Việt Nam dự lễ bế mạc ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Tại Diễn đàn năm nay, đoàn Việt Nam tham dự Hội chợ TRAVEX với Gian hàng Du lịch Việt Nam nhằm mục đích thúc đẩy sự chủ động hội nhập ASEAN, thể hiện vai trò thành viên tích cực của Cộng đồng kinh tế khu vực; giới thiệu một số chính sách phát triển du lịch mới nhằm đẩy mạnh thu hút khách du lịch quốc tế đến Việt Nam; giới thiệu về Năm Du lịch quốc gia - Huế 2025; đồng thời tăng cường quảng bá thương hiệu du lịch Việt Nam với các giá trị nổi bật và các dòng sản phẩm du lịch chủ đạo, truyền tải thông điệp Việt Nam là điểm đến an toàn, thân thiện, hấp dẫn tới cộng đồng các quốc gia ASEAN, các nước đối tác và bạn bè trên thế giới.</p>\r\n\r\n<p>Chương trình biểu diễn nghệ thuật khép lại ATF 2025 (Ảnh: TITC)</p>\r\n\r\n<p>Nhân dịp này, Lễ trao giải thưởng du lịch ASEAN đã tôn vinh 17 đơn vị của Việt Nam ở các hạng mục giải thưởng, gồm có: Giải thưởng Dịch vụ Spa ASEAN; Giải thưởng Du lịch cộng đồng ASEAN (CBT ASEAN); Giải thưởng nhà ở có phòng cho khách du lịch thuê (homestay ASEAN); Giải thưởng Nhà vệ sinh công cộng ASEAN.</p>\r\n\r\n<p>Chuyển giao quyền đăng cai ATF 2026 cho Bộ trưởng Bộ Du lịch Philippines Christina Garcia Frasco (Ảnh: TITC)</p>\r\n\r\n<p>ATF 2025 đã chính thức khép lại, truyền đi thông điệp “Đoàn kết trong hành động - Định hình du lịch ASEAN ngày mai”, khẳng định sự phục hồi mạnh mẽ của du lịch ASEAN, nâng cao khả năng thích ứng và cạnh tranh để trở thành điểm đến du lịch hàng đầu của thế giới. Việc tổ chức Diễn đàn Du lịch ASEAN hàng năm góp phần nâng cao vị thế của ASEAN như một khu vực hòa bình, đáng tin cậy và trở thành một khối kinh tế thịnh vượng, quan trọng của thế giới.</p>\r\n\r\n<p>Theo kế hoạch, Diễn đàn Du lịch ASEAN 2026 sẽ được tổ chức tại Philippines.</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "(TITC) - Tối ngày 20/1, Diễn đàn Du lịch ASEAN (ATF) 2025 đã chính thức bế mạc tại Malaysia, khép lại chương trình với nhiều hoạt động sôi nổi và hiệu quả.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Fbemacatf_2929-(1).jpg?alt=media&token=cccce681-3652-4a07-a2ff-b972392c84da", null, "Bế mạc Diễn đàn Du lịch ASEAN 2025: Khẳng định sự phục hồi mạnh mẽ và nâng cao vị thế điểm đến du lịch khu vực", null },
                    { new Guid("87f8d5d7-645f-4e50-bb99-f02fb880281e"), 0, 2, "<p>Không gian trưng bày “Tết xưa - Tết thời bao cấp” sẽ đưa du khách ngược dòng thời gian trở về “Tết xưa - Tết thời bao cấp” của thập kỷ 70, 80 để cùng sống lại một giai đoạn lịch sử đặc biệt của đất nước. Tết thời bao cấp tuy còn thiếu thốn về vật chất nhưng đầy ắp tình người và thiêng liêng.</p>\r\n\r\n    <h2>Không gian trưng bày Tết xưa tại Hoàng thành Thăng Long</h2>\r\n    <p>“Tết thời bao cấp” được tái hiện qua 3 không gian trưng bày: Gian hàng mậu dịch quốc doanh, gian hàng tranh - hoa - pháo Tết và không gian thờ cúng. Mặc dù không gian trưng bày không lớn nhưng đã làm nổi bật được đời sống vật chất, tinh thần và văn hóa tâm linh của người dân thủ đô Hà Nội cách đây nửa thế kỷ.</p>\r\n\r\n    <h2>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”</h2>\r\n    <p>Không gian trưng bày “Nghi lễ Tết cung đình ngày xuân”, được trưng bày thông qua hình thức giới thiệu tư liệu, diễn giải bằng tranh vẽ phỏng dựng và hiện vật mô hình, giúp du khách có thể hình dung ra được phần nào đời sống chính trị, văn hóa, lịch sử quá khứ vàng son hoàng cung xưa kia.</p>\r\n\r\n    <h2>Nghi lễ “Tống cựu nghinh tân”</h2>\r\n    <p>Vào ngày 23 tháng Chạp, sẽ tái hiện nghi lễ “Tống cựu nghinh tân” tại Khu di sản Hoàng thành Thăng Long - Hà Nội, thể nghiệm những lễ nghi trong dịp Tết Nguyên đán đã từng diễn ra trong cung đình Thăng Long xưa thể hiện mong muốn hưng thịnh cho quốc gia, bình an no ấm cho nhân dân.</p>\r\n\r\n    <h2>Nghi lễ Tiến lịch</h2>\r\n    <p>Nghi lễ Tiến lịch không chỉ là một nghi lễ thiêng liêng đóng vai trò quan trọng trong đời sống cung đình và dân gian xưa mà “lịch” đã trở thành một vật đặc biệt gắn liền với đời sống của con người trong quá khứ, hiện tại và tương lai.</p>\r\n\r\n    <h2>Lễ dựng Nêu</h2>\r\n    <p>Lễ dựng Nêu là một trong những hoạt động điểm nhấn của chương trình. Cây nêu ngày Tết là một phong tục truyền thống của người Việt Nam, thường được dựng vào dịp Tết Nguyên đán. Cây nêu được dựng vào ngày 23 tháng Chạp Âm lịch, sau lễ tiễn ông Táo về trời, và hạ xuống vào ngày mùng 7 tháng Giêng, kết thúc kỳ nghỉ Tết. Phong tục dựng cây nêu không chỉ phổ biến trong cộng đồng người Kinh và trong dân gian mà còn được duy trì trong kinh thành Thăng long cũng như xuất hiện ở nhiều dân tộc thiểu số khác tại Việt Nam.</p>\r\n\r\n    <h2>Các Nghi Lễ Khác</h2>\r\n    <p>Trong khuôn khổ chương trình còn có các nghi lễ thả cá chép tiễn ông Công ông Táo về trời; Lễ đổi gác, Lễ khai xuân…</p>\r\n", new Guid("a631bb94-66d8-44db-932b-532892d87754"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Trung tâm Bảo tồn Di sản Thăng Long - Hà Nội tổ chức chuỗi hoạt động Tết từ ngày 20/01 đến 06/02 gồm nhiều hoạt động đặc sắc nhằm phát huy giá trị các nghi lễ Tết tiêu biểu của cung đình cũng như những phong tục Tết dân gian truyền thống của Thăng Long xưa, Hà Nội nay.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2Ftet-2.jpg?alt=media&token=6d28efb3-2ed9-4ca9-907e-de6b6c190a5f", null, "Tết Việt 2025: Tái hiện nghi lễ “tống cựu nghinh tân” tại Hoàng thành Thăng Long (Hà Nội)", null },
                    { new Guid("8a868015-f57f-4930-aa7a-674b71bde9e9"), 0, 2, "<p>Thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.</p>\r\n    <p>Khai thác vẻ đẹp cảnh quan thiên nhiên và bản sắc văn hóa dân tộc, hàng năm huyện Mai Châu thu hút đông khách du lịch quốc tế đến tham quan, trải nghiệm.</p>\r\n\r\n    <h2>Đưa du lịch trở thành ngành kinh tế mũi nhọn</h2>\r\n    <p>Từ việc tạo được bứt phá trong phát triển du lịch cộng đồng (DLCĐ), Mai Châu trở thành cái tên đầy sức hút đối với du khách và đứng trước nhiều vận hội mới để vươn tầm phát triển... \"Lĩnh vực du lịch của huyện đã trải qua một hành trình đặc biệt đánh dấu sự chung sức, đồng lòng của đảng bộ, chính quyền và nhân dân các dân tộc trong toàn huyện,” đồng chí Hà Công Nghị, Phó Bí thư Thường trực Huyện ủy Mai Châu chia sẻ. Với phương châm chỉ đạo xuyên suốt qua 3 kỳ ĐHĐB huyện \"phát triển DLCĐ gắn với xây dựng nông thôn mới” đã tạo được sự đồng lòng, nhất trí cao từ cấp ủy, chính quyền cơ sở, phù hợp với nguyện vọng của người dân.</p>\r\n    <p>Thực hiện chủ trương phát triển DLCĐ, năm 2010 được coi là vạch xuất phát để Mai Châu bắt đầu thực hiện hành trình phát triển mới. Thời điểm đó, toàn huyện mới có 11 nhà nghỉ, 54 hộ kinh doanh nhà nghỉ cộng đồng, 8 xã có hoạt động DLCĐ. Tổng doanh thu từ hoạt động du lịch đạt gần 10 tỷ đồng/năm. Cả năm đón khoảng 64 nghìn lượt khách du lịch. Toàn huyện cũng chỉ có bản Lác (xã Chiềng Châu) được coi là bản DLCĐ. Sản phẩm du lịch nghèo nàn, chất lượng dịch vụ thấp nên chưa tạo sức hút đáng kể đối với du khách. Trong bối cảnh đầy thử thách, cả hệ thống chính trị huyện Mai Châu quyết tâm tạo ra hướng phát triển mang tính đột phá cho lĩnh vực du lịch của huyện, đó là DLCĐ.</p>\r\n    <p>Sau 15 năm, Mai Châu đang hiện thực hóa những chỉ tiêu phát triển kinh tế - xã hội một cách toàn diện. Đáng kể nhất là sự phát triển vươn tầm của ngành du lịch. Đến thời điểm này, huyện có quy hoạch đồng bộ, bài bản về phát triển du lịch. Bằng cách thực hiện hiệu quả những quyết sách quan trọng về phát triển du lịch, Mai Châu đã bứt phá, đưa du lịch trở thành ngành kinh tế mũi nhọn. \"Nghị quyết ĐHĐB huyện qua các nhiệm kỳ là \"kim chỉ nam” định hướng cho các hoạt động phát triển du lịch của huyện. Từ nghị quyết đã có nhiều giải pháp được triển khai đồng bộ, hiệu quả. Công tác quản lý nhà nước đối với hoạt động du lịch được tăng cường. Hạ tầng phục vụ du lịch được quan tâm đầu tư. Phát triển du lịch gắn với bảo tồn, giữ gìn và phát huy bản sắc văn hóa được quan tâm. Nhờ đó, từ 1 điểm DLCĐ ban đầu là bản Lác, đến nay toàn huyện có gần 150 cơ sở lưu trú du lịch, 7 điểm DLCĐ, 12 khách sạn, 28 nhà nghỉ, 106 homestay, thu hút, tạo việc làm cho trên 1.200 lao động trong lĩnh vực du lịch. Trên địa bàn huyện có 15 dự án du lịch, thương mại được UBND tỉnh quyết định chủ trương đầu tư, tổng vốn đăng ký trên 1.178 tỷ đồng. Các dự án đều có quy mô, khả năng đáp ứng nhu cầu về nghỉ dưỡng chất lượng cao cho khách du lịch. Từ những nỗ lực đó đã đưa ngành thương mại, dịch vụ, du lịch chiếm tỷ trọng lớn nhất trong cơ cấu kinh tế của huyện (chiếm 37% năm 2024), vượt chỉ tiêu Nghị quyết ĐHĐB huyện lần thứ XXVI đề ra.</p>\r\n\r\n    <h2>Xây dựng nền \"kinh tế xanh”, bền vững</h2>\r\n    <p>Không chỉ đặt mục tiêu tạo ra những dấu ấn rõ nét trong lĩnh vực du lịch, theo đồng chí Phạm Văn Hoàn, Chủ tịch UBND huyện Mai Châu thì huyện xác định nông nghiệp vẫn là một \"trụ đỡ” cho sự phát triển kinh tế - xã hội. Để đưa giá trị sản xuất nông nghiệp ngày càng cao theo tinh thần Nghị quyết ĐHĐB huyện lần thứ XXVI, thời gian qua huyện đã nỗ lực để tạo ra những bước đột phá mới.</p>\r\n    <p>Đảng bộ, chính quyền các cấp trong huyện tăng cường công tác lãnh đạo, chỉ đạo sản xuất. Đẩy mạnh chuyển đổi cơ cấu cây trồng, vật nuôi theo hướng hàng hóa, phù hợp từng vùng, theo hướng nâng cao giá trị gia tăng và phát triển bền vững. Đồng chí Ngần Văn Toàn, Phó trưởng phòng NN&PTNT huyện Mai Châu cho biết, huyện tích cực tuyên truyền, khuyến khích người dân lựa chọn cây trồng, vật nuôi phù hợp đưa vào sản xuất. Thực hiện thâm canh tăng vụ, chuyển đổi sang sản xuất hàng hóa, xây dựng mô hình sản xuất có giá trị kinh tế cao, như mô hình trồng rau an toàn tại xã Chiềng Châu, Bao La, Mai Hịch...; ứng dụng công nghệ cao trong chăn nuôi, thực hiện giám sát an toàn dịch bệnh...</p>\r\n    <p>Để thúc đẩy tiêu thụ, nâng cao giá trị sản phẩm, huyện quan tâm đầu tư, xây dựng nhãn hiệu tập thể cho sản phẩm nông nghiệp, nhất là những sản phẩm có tính đặc trưng như \"Ngô nếp Thung Khe”, \"Khoai sọ Phúc Sạn”, \"Tỏi tía Thành Sơn”, \"Lợn đen Mường Pa”, \"Rượu Mai Hạ”, \"Gà đen Hang Kia, Pà Cò”, mới đây nhất là \"Cá dầm xanh Mai Châu” nhằm góp phần nâng cao giá trị, tăng sức cạnh tranh của sản phẩm...</p>\r\n    <p>Từ việc thực hiện có hiệu quả lộ trình phát triển kinh tế nông nghiệp phù hợp với điều kiện thực tế địa phương đã thúc đẩy kinh tế - xã hội của huyện Mai Châu ngày càng phát triển bền vững. Trong đó, nông nghiệp vẫn đóng vai trò \"trụ đỡ” với giá trị sản xuất nông, lâm, thuỷ sản năm 2024 đạt 1.452,3 tỷ đồng, chiếm tỷ trọng 28%. Du lịch - ngành kinh tế mũi nhọn tiếp tục là ngành chiếm tỷ trọng cao nhất trong cơ cấu kinh tế của huyện.</p>\r\n", new Guid("11a068d3-9af4-484c-82a2-e2b5c9d8b5ab"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Xác định thế mạnh của địa phương là du lịch và sản xuất nông nghiệp, thực hiện Nghị quyết Đại hội Đảng bộ (ĐHĐB) huyện lần thứ XXVI, huyện Mai Châu (tỉnh Hòa Bình) đã hướng tới việc xây dựng \"nền kinh tế xanh” bằng chương trình hành động với những lộ trình cụ thể và đạt được những kết quả đáng ghi nhận.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2101.hoabinh.jpg?alt=media&token=9da1280b-fca0-48a3-aacb-a8598212f33c", null, "Hòa Bình: Huyện Mai Châu xây dựng “nền kinh tế xanh”", null },
                    { new Guid("dfd1d074-b18a-407c-8e5e-d63db80f1f90"), 0, 2, "<h2>Văn hóa bản địa Tây Nguyên là một tiềm năng du lịch của tỉnh Lâm Đồng</h2>\r\n    <p>Thực tế tại tỉnh Lâm Đồng, một số huyện và thành phố đã có nhiều cách tiếp cận trong việc khai thác tài nguyên tự nhiên, tài nguyên nhân văn có sẵn của địa phương, xây dựng thành các chương trình du lịch đặc trưng như:</p>\r\n    <ul>\r\n        <li>Du lịch lịch sử - văn hóa (Khu di tích Quốc gia đặc biệt khảo cổ Cát Tiên, Khu ủy Khu VI..., huyện Đạ Huoai)</li>\r\n        <li>Du lịch miệt vườn (Vườn trái cây Nam Nhi, huyện Đạ Huoai)</li>\r\n        <li>Du lịch sinh thái - văn hóa (trải nghiệm văn hóa trà, văn hóa người Mạ, huyện Bảo Lâm)</li>\r\n        <li>Du lịch tham quan sản xuất tơ lụa ở TP Bảo Lộc</li>\r\n        <li>Du lịch trải nghiệm âm nhạc cồng chiêng tại huyện Lạc Dương</li>\r\n        <li>Du lịch tắm suối nước nóng ở huyện Đam Rông</li>\r\n    </ul>\r\n    \r\n    <p>Ngoài ra, Đức Trọng, Đơn Dương, Lâm Hà cũng đã tận dụng những di sản văn hóa xã hội, cùng cảnh quan thiên nhiên tại địa phương để thu hút du khách đến trải nghiệm.</p>\r\n    \r\n    <h3>Tiềm năng du lịch tại xã Đạ Đờn</h3>\r\n    <p>“Qua khảo sát các tài nguyên du lịch tại địa phương, chúng tôi nhận thấy xã Đạ Đờn (huyện Lâm Hà) có đủ tiềm năng để phát triển các loại hình du lịch sinh thái, du lịch nông nghiệp, du lịch cộng đồng, du lịch văn hóa, du lịch làng nghề...” - Phó Chủ tịch UBND xã Đạ Đờn Ka Điệp chia sẻ.</p>\r\n    \r\n    <h3>Quan điểm từ các chuyên gia du lịch</h3>\r\n    <p>Ông Touneh Tín - Công ty We For U - cho biết: “Du lịch nông thôn chính là thế mạnh của tỉnh Lâm Đồng.” Ông nhấn mạnh việc khai thác tiềm năng du lịch nông thôn không chỉ nâng cao thu nhập cho nông dân, mà còn tạo ra những giá trị kết nối kinh tế - văn hóa - nhân văn.</p>\r\n    \r\n    <p>“Thời gian qua, các hoạt động du lịch nông thôn đã tạo ra ‘kênh’ quảng bá, tiêu thụ các sản phẩm OCOP tại chỗ. Thông qua quà tặng là những sản phẩm OCOP, địa phương giúp nông dân tiêu thụ sản phẩm và phát triển loại hình du lịch trải nghiệm nông sản đặc trưng của địa phương” - ông Touneh Tín chia sẻ.</p>\r\n    \r\n    <h3>Kết nối giữa các địa phương</h3>\r\n    <p>Từ thực tiễn du lịch nông thôn ở Lâm Đồng cho thấy, việc kết nối giữa các địa phương cũng rất cần thiết. Việc kết nối không chỉ thể hiện được tính đa dạng về cảnh quan, kinh tế, lịch sử, văn hóa mà còn tăng thêm tính trải nghiệm cho du khách.</p>\r\n", new Guid("053d18ef-ba0e-4141-b142-898d28fa9b5d"), new DateTime(2025, 1, 22, 3, 38, 59, 419, DateTimeKind.Local).AddTicks(3253), "Thêm việc làm cho nông dân, qua đó đẩy mạnh phát triển kinh tế nông nghiệp, tạo sự gắn kết giữa nông dân với chính mảnh đất quê hương... là những lợi ích thấy rõ từ việc phát triển du lịch nông nghiệp - nông thôn.", "https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Blog%2F2007lamdong1-1689837807306-16898378088711727831861.jpg?alt=media&token=17bcc062-4fb7-4996-8108-5b6f6ff9809a", null, "Lâm Đồng: Tiềm năng du lịch nông thôn", null }
                });

            migrationBuilder.InsertData(
                table: "Certification",
                columns: new[] { "CertificationId", "CertificationDetails", "CertificationName", "CreateDate", "ExpiryDate", "Imgs", "IssueDate", "IssuingOrganization", "ProductId", "ReplyRequest", "StatusApproval", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("0a2898a5-c36f-441c-b710-e5737d35eb07"), "Chứng nhận hệ thống quản lý chất lượng", "Chứng nhận TQC", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3997), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3996), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3996), "Trung tâm kiểm nghiệm và chứng nhận CGLOBAL", null, "Yêu cầu xác nhận chứng chỉ chưa đạt yêu cầu!", 2, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("3b228f24-c786-49e1-b781-fe1e6f58b15c"), "Sản phẩm: Viên nghệ mật ong \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3955), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3954), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3953), "Ủy ban nhân dân xã", new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("3b689d42-3640-4c27-920c-32ab83185e79"), "Chứng nhận chất lượng sản phẩm", "Chứng nhận chất lượng sản phẩm", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4000), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3999), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3999), "Tổng cục tiêu chuẩn đo lường chất lượng", null, "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("49723efc-2988-4227-9f8f-a41a678a137b"), "Sản phẩm: Tinh Bột Sắn Dây \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3960), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3960), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3959), "Ủy ban nhân dân xã", new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("658f2b48-be26-4178-a886-966a8c7b440c"), "Sản phẩm: Bột tía tô \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3987), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3986), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3986), "Ủy ban nhân dân xã", new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("6b4e360e-b8bb-42e2-b02b-b43b877801b6"), "Sản phẩm: Ống rượu tre Việt Nam \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3982), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3982), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3981), "Ủy ban nhân dân xã", new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("733d096c-a2a8-421c-a91d-dd65cfd02814"), "Sản phẩm: Cơm cháy \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3966), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3965), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3965), "Ủy ban nhân dân xã", new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("a4a3b2ab-9642-4458-b242-fd0044833912"), "Sản phẩm: Nhang trầm hương \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3992), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3991), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3991), "Ủy ban nhân dân xã", new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), null, 1, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("aef26e64-0228-49e2-993e-beb9fb542f83"), "Sản phẩm: Dầu gội dược liệu \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3971), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3971), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3970), "Ủy ban nhân dân xã", new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("bd21b4b7-9571-490e-9f85-9a0a0fc0f2e4"), "Sản phẩm: Trà Sen Tây Hồ \r\n Đơn vị: Hợp tác xã Dịch vụ Nông nghiệp tổng hợp Đồng Tâm \r\n Địa chỉ: Thôn 9, xã Quỳnh Vinh, thị xã Hoàng mai, tỉnh Nghệ An\r\nĐã tham gia đánh giá phân hạng sản phẩm chương trình một xã một sản phẩm OCOP đợt 2 năm 2022", "Chứng nhận OCOP", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3976), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3976), "[\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\",\"https://firebasestorage.googleapis.com/v0/b/arms-acdfc.appspot.com/o/Product%2Fc1.webp?alt=media\\u0026token=891959b2-1cc7-448a-a86e-e5cf270fe4d9\"]", new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3975), "Ủy ban nhân dân xã", new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), "Yêu cầu xác nhận chứng chỉ được phê duyệt!", 0, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null }
                });

            migrationBuilder.InsertData(
                table: "Contract",
                columns: new[] { "ContractId", "ContractContent", "CreateDate", "DiscountRate", "EndDate", "RequestReSignContract", "SignedDate", "SigningStatus", "StartDate", "Status", "TourCompanyId", "TouristFacilityId", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("08546102-1b39-4614-a809-adf7f179a165"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8257), 0.01m, new DateTime(2028, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8256), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8256), null, null, new Guid("10000000-0000-0000-0000-000000000009"), null },
                    { new Guid("1bd35c14-2f4c-4c81-b19b-e0a55c23a31e"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8189), 0.01m, new DateTime(2030, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8189), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8188), null, new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"), null, null },
                    { new Guid("256b3ae7-945f-4227-ae28-a4a93f517e52"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8242), 0.02m, new DateTime(2029, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8241), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8241), null, null, new Guid("10000000-0000-0000-0000-000000000006"), null },
                    { new Guid("25daffae-5a2b-4414-907d-28151da4b4cb"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8206), 0.04m, new DateTime(2029, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8205), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8205), null, new Guid("896386c5-c839-48ca-8459-e4d033a644c0"), null, null },
                    { new Guid("2c1762fb-70db-4f81-9534-3f15bf6d945e"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8192), 0.02m, new DateTime(2028, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8191), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8190), null, new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"), null, null },
                    { new Guid("312b60b7-84c4-4e8f-aa73-4c0059d981c4"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8219), 0.01m, new DateTime(2030, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8219), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8218), null, new Guid("22275542-0625-47be-a503-2f13b7576e9b"), null, null },
                    { new Guid("349decd7-8a26-49a4-8c74-4141eb28c197"), "Hợp đồng cung cấp dịch vụ hướng dẫn viên", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8174), 0.05m, new DateTime(2026, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8152), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8151), null, new Guid("e33545b1-c97e-412f-b844-17b15cd28b74"), null, null },
                    { new Guid("4a28446a-6167-4452-a814-73234c3ded59"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8240), 0.04m, new DateTime(2026, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8239), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8238), null, null, new Guid("10000000-0000-0000-0000-000000000005"), null },
                    { new Guid("4ef2a007-b06d-4160-8dd4-7345fd1e8512"), "Thỏa thuận hợp tác phát triển tour", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8195), 0.05m, new DateTime(2026, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8194), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8194), null, new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"), null, null },
                    { new Guid("54124f43-8ac5-4dca-a81b-eb738f27ed42"), "Thỏa thuận hợp tác phát triển sản phẩm du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8272), 0.03m, new DateTime(2030, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8271), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8271), null, null, new Guid("10000000-0000-0000-0000-000000000015"), null },
                    { new Guid("57552467-236a-4c29-ad37-ae3e74658698"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8262), 0.02m, new DateTime(2028, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8261), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8261), null, null, new Guid("10000000-0000-0000-0000-000000000011"), null },
                    { new Guid("65f039d3-5872-46ea-b29f-f5e8c01a858d"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8255), 0.03m, new DateTime(2027, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8254), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8254), null, null, new Guid("10000000-0000-0000-0000-000000000008"), null },
                    { new Guid("6ec90e6d-9c94-41fd-90a0-3870cb6027d6"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8232), 0.03m, new DateTime(2028, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8231), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8231), null, null, new Guid("10000000-0000-0000-0000-000000000002"), null },
                    { new Guid("7842c53e-dd1d-4e9f-8fcb-1cf0a48fd55c"), "Hợp đồng hợp tác kinh doanh du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8264), 0.01m, new DateTime(2030, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8263), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8263), null, null, new Guid("10000000-0000-0000-0000-000000000012"), null },
                    { new Guid("79d8cfb8-32fd-4d3a-b1c5-cafd5c0aa83f"), "Thỏa thuận hợp tác phát triển sản phẩm du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8237), 0.04m, new DateTime(2029, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8236), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8236), null, null, new Guid("10000000-0000-0000-0000-000000000004"), null },
                    { new Guid("82a62095-6cc6-427a-b87a-f31db606ed4a"), "Thỏa thuận hợp tác đào tạo nhân lực", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8259), 0.01m, new DateTime(2027, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8259), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8258), null, null, new Guid("10000000-0000-0000-0000-000000000010"), null },
                    { new Guid("91f37766-8591-42be-88a2-75ad43c7d234"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8268), 0.03m, new DateTime(2026, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8268), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8267), null, null, new Guid("10000000-0000-0000-0000-000000000014"), null },
                    { new Guid("95f346fc-9271-423d-8b33-7d45b0440be9"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8199), 0.01m, new DateTime(2030, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8198), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8198), null, new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"), null, null },
                    { new Guid("9b7aab6a-fc75-41e9-8a60-ffa818eb2c00"), "Thỏa thuận cung cấp dịch vụ lưu trú", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8203), 0.05m, new DateTime(2026, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8203), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8202), null, new Guid("7f325be1-4b4a-4153-8151-23706fc88617"), null, null },
                    { new Guid("a0a3188e-90ad-4777-970f-72ee94b8e73b"), "Hợp đồng cung cấp dịch vụ hướng dẫn viên", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8235), 0.04m, new DateTime(2026, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8234), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8234), null, null, new Guid("10000000-0000-0000-0000-000000000003"), null },
                    { new Guid("af7cb135-efce-484a-8c96-e363fb2a66a8"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8214), 0.01m, new DateTime(2027, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8213), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8213), null, new Guid("444f5ca4-481e-4004-af73-78ec29765e05"), null, null },
                    { new Guid("b25c09db-1fc0-46e2-9f5e-f76425fb2938"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8211), 0.02m, new DateTime(2026, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8210), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8210), null, new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"), null, null },
                    { new Guid("c15a34c6-2341-4dfc-aeee-abdcec1b7bd7"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8185), 0.01m, new DateTime(2030, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8183), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8183), null, new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"), null, null },
                    { new Guid("c1c91244-f7a9-4e06-869d-52be4f2ea731"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8253), 0.01m, new DateTime(2026, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8252), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8251), null, null, new Guid("10000000-0000-0000-0000-000000000007"), null },
                    { new Guid("ca9b5b9a-7a3c-4a0d-9a45-c059e2b983cc"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8201), 0.01m, new DateTime(2027, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8200), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8200), null, new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"), null, null },
                    { new Guid("cabb3069-10a1-45ad-8338-059c947460c4"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8216), 0.01m, new DateTime(2026, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8215), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8215), null, new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"), null, null },
                    { new Guid("cc3293e8-412c-4968-bb82-0ed631d5def6"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8187), 0.03m, new DateTime(2030, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8186), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8186), null, new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"), null, null },
                    { new Guid("ccc87bf7-b7e8-4b3e-8deb-c7cb64ce397b"), "Hợp đồng cung cấp dịch vụ ăn uống", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8226), 0.01m, new DateTime(2027, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8224), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8223), null, null, new Guid("d9e2de12-d4bc-436a-9209-9f1de3ef185c"), null },
                    { new Guid("dc5f0780-00ab-4388-97de-cb3ad528ea46"), "Hợp đồng cung cấp dịch vụ vận chuyển", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8266), 0.04m, new DateTime(2026, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8265), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8265), null, null, new Guid("10000000-0000-0000-0000-000000000013"), null },
                    { new Guid("eff4e868-6a21-4a0e-8d95-6198cc16f53d"), "Hợp đồng đại lý du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8230), 0.04m, new DateTime(2030, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8229), null, null, 1, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8228), null, null, new Guid("10000000-0000-0000-0000-000000000001"), null },
                    { new Guid("fe7cfc28-0094-45dc-a3cc-8a48c23fe5f8"), "Thỏa thuận hợp tác quảng bá du lịch", new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8209), 0.03m, new DateTime(2030, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8208), null, null, 0, new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(8208), null, new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"), null, null }
                });

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.UpdateData(
                table: "Driver",
                keyColumn: "DriverId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "Imgs",
                value: "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/t%E1%BA%A3i%20xu%E1%BB%91ng%20(5).jpg?alt=media\\u0026token=edf3ca4b-17fe-4a84-8be1-92db77df7a67\"]");

            migrationBuilder.InsertData(
                table: "OCOPSell",
                columns: new[] { "OCOPSellId", "ActiveStatus", "CreateDate", "ExpiryDate", "ManufacturingDate", "ProductId", "SalePrice", "SellVolume", "UpdateDate" },
                values: new object[,]
                {
                    { new Guid("070a6899-772d-41ba-aa4e-016aca6f7bd3"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3840), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 130000.0, 1000.0, null },
                    { new Guid("0777a9f0-6958-464b-a76c-3d0a783bbecf"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3738), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 120000.0, 1000.0, null },
                    { new Guid("0b606e08-56e5-4256-883c-d1e32afc9359"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3809), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 90000.0, 1000.0, null },
                    { new Guid("11885d8a-bc89-400e-a9d3-518fe54deffb"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3701), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 87000.0, 1000.0, null },
                    { new Guid("1be8aa96-a7ce-4fbc-8f05-41c421a8b40c"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3761), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 90000.0, 1000.0, null },
                    { new Guid("21856b3e-e23b-441e-ac6a-be51068c7b37"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3730), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 10000.0, 1000.0, null },
                    { new Guid("2fd0158e-9978-4232-9f26-3f76c6382b99"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3786), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 60000.0, 1000.0, null },
                    { new Guid("361431a5-eed9-40cb-8849-86843534b7b1"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3876), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 70000.0, 1000.0, null },
                    { new Guid("37e63e66-a5a4-4327-847a-8aa901f1e018"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3803), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 130000.0, 1000.0, null },
                    { new Guid("413d8b3a-70c6-405d-80af-3f00adec1768"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3792), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 60000.0, 1000.0, null },
                    { new Guid("45b89f30-3a39-4496-a32a-b4a994f1458f"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3834), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 70000.0, 1000.0, null },
                    { new Guid("47f8d21d-2430-48e1-8f18-dc66c293a4d7"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3827), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"), 130000.0, 1000.0, null },
                    { new Guid("4904d67a-647f-4a6d-ac64-9d962794d1dc"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3883), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 10000.0, 1000.0, null },
                    { new Guid("4d9a87aa-4526-4c76-864f-dc8c6d6c3e5a"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3798), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"), 10000.0, 1000.0, null },
                    { new Guid("506cbede-dac2-4074-8850-55db68a50ec6"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3889), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 110000.0, 1000.0, null },
                    { new Guid("52f04413-55a7-484b-b99c-7beb3f719754"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3859), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 80000.0, 1000.0, null },
                    { new Guid("543f271a-fb09-4c1b-b761-7ea1396013b3"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3767), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 80000.0, 1000.0, null },
                    { new Guid("56b965e9-d19a-4cb6-bb5d-d810c22fc37c"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3846), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 70000.0, 1000.0, null },
                    { new Guid("56bb59ea-c633-4974-9bfd-7f3956a7ae8d"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3725), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 120000.0, 1000.0, null },
                    { new Guid("77467456-0b25-473b-a79a-b6b57b4cbc6f"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3755), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"), 120000.0, 1000.0, null },
                    { new Guid("7949af45-ab42-44c0-8f3d-38072d9806ee"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3815), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 10000.0, 1000.0, null },
                    { new Guid("7ca23f4f-0c03-41bc-a119-ac6afa2075e6"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3719), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"), 92000.0, 1000.0, null },
                    { new Guid("8289da52-f4af-4f9d-9d2a-3578e05f1e7b"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3870), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 110000.0, 1000.0, null },
                    { new Guid("8351fcfc-d4f0-445a-a19a-d665b9481d17"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3821), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"), 10000.0, 1000.0, null },
                    { new Guid("88fd25ac-f9d4-4915-a23d-0ec863dd5227"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3695), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 85000.0, 1000.0, null },
                    { new Guid("9161bd92-eb5b-42fe-a5eb-ed4bc98a289a"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3707), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 92000.0, 1000.0, null },
                    { new Guid("a3304ee0-f42b-4d66-9dd9-d95a3ecae6f5"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3749), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 40000.0, 1000.0, null },
                    { new Guid("a4d14064-b84e-44df-9e49-b091e0970923"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3894), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"), 110000.0, 1000.0, null },
                    { new Guid("a6206ad6-1152-418a-bf97-106708774107"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3779), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 40000.0, 1000.0, null },
                    { new Guid("b9458fd8-89f2-46c8-b2b7-20b467f02907"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3744), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"), 40000.0, 1000.0, null },
                    { new Guid("bdc922bc-c218-48c3-b598-6844ddd8690b"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3688), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 87000.0, 1000.0, null },
                    { new Guid("bfe2e30e-1d7a-459d-82f0-d731237242cd"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3678), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2023, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"), 85000.0, 1000.0, null },
                    { new Guid("c00f52f1-3004-40c2-8d9a-452aa74cdc3a"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3864), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"), 10000.0, 1000.0, null },
                    { new Guid("ca354042-9c25-440e-9f9f-51737583791e"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3713), new DateTime(2027, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"), 92000.0, 1000.0, null },
                    { new Guid("ecde8c8c-8f23-4711-a30f-743938f73fd6"), true, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3852), new DateTime(2026, 9, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"), 80000.0, 1000.0, null },
                    { new Guid("f6aa7dbb-98c9-4731-a944-fb2d00d39cc4"), null, new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3773), new DateTime(2026, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(2024, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"), 90000.0, 1000.0, null }
                });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("20000000-4444-0000-3333-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3544));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("23c7f3c2-5915-4f10-b937-6a34da949a17"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3515), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F4.jpg?alt=media\\u0026token=cc2b259e-55e1-4ee8-bd6e-7f619a3ca9b9\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F5.jpg?alt=media\\u0026token=b4c42af8-a554-496f-933f-ee72eaa99ad7\"]" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("4335f0e8-9ea3-48a7-b0cf-5185ff675dde"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3467));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("639e1cfc-1266-4b30-9022-3927c1721afd"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3501));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("65966980-988a-4d92-89b4-2b74425fe3f3"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3505));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-4b8e-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3490));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("69006cfe-5233-7776-b181-d81a485873e3"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3536));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("798a3b9b-f7c9-4e84-a563-39421e6585f4"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3473));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-40dd-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3496));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("98e14da8-4445-4e50-bd9b-eb74112f6625"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3540));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("9a8ba610-2fb7-4b75-a482-328d76dc1d18"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3523), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F6.jpg?alt=media\\u0026token=2579c65f-9b67-42f3-a052-3c1fc19c509f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F7.jpg?alt=media\\u0026token=8532128f-6b27-4059-a04b-e912b62f0556\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F8.jpg?alt=media\\u0026token=d1f4592d-ea8d-42a2-b975-ef99493f8f33\"]" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("c58bb9c8-ad26-40bc-a5d5-f8d09049f7aa"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3458));

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("d56f8c35-68b1-4c42-95f5-d0e4a5d89988"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3532), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F9.jpg?alt=media\\u0026token=fe337e6e-fe5f-43d7-8a94-622137e2dd3f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F10.jpg?alt=media\\u0026token=2d61b4e2-0451-467a-9ca8-ef26a6cb603f\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F11.jpg?alt=media\\u0026token=28e3c536-92a5-4dd8-9dda-c70f3e8b34c0\"]" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("e5c3d8d2-6fc1-41f0-a2c9-28d3ddbbfa55"),
                columns: new[] { "CreateDate", "Imgs" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3510), "[\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F1.jpg?alt=media\\u0026token=b474731f-3c05-418e-ac71-9e7bd36f85d2\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F2.jpg?alt=media\\u0026token=7b48babb-d847-4333-ad7f-332c2c051698\",\"https://firebasestorage.googleapis.com/v0/b/ato-c80b3.firebasestorage.app/o/Product%2F3.jpg?alt=media\\u0026token=1316b40a-1b2d-4160-a798-905976414bdc\"]" });

            migrationBuilder.UpdateData(
                table: "Product",
                keyColumn: "ProductId",
                keyValue: new Guid("f51aaaf7-9bb1-4a69-a634-0ab1162fd9c1"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3485));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 1,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3105));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 2,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3109));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 3,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3110));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 4,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3111));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 5,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3112));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 6,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3113));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 7,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3114));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 8,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3116));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 9,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 10,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3117));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 11,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3118));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 12,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 13,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3120));

            migrationBuilder.UpdateData(
                table: "SystemConfigurations",
                keyColumn: "ConfigId",
                keyValue: 14,
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3121));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("09b0336b-c136-4fc3-bb9f-ceb605b7a7f8"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3195));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("0ea7235b-cc8c-4c1b-8304-4c0fc5bd26ba"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3177));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("1301343c-9827-4152-8fc8-b72c13cc3b4a"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3179));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("22275542-0625-47be-a503-2f13b7576e9b"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3202));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("444f5ca4-481e-4004-af73-78ec29765e05"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3197));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("4d0a0c3f-de0a-4985-b188-21a65eb1f9b9"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3192));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("5887a0db-ed74-49d2-aa02-7db5943f11a3"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3199));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("74e66def-a1c3-4140-a386-fa10e49d80f6"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3171));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7c1df83b-aced-4175-a3be-280c8d651cc2"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3181));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("7f325be1-4b4a-4153-8151-23706fc88617"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("896386c5-c839-48ca-8459-e4d033a644c0"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3190));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("98d9cab9-c57e-4395-b1db-00bea4d22e46"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3174));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("a1d2c3e4-f567-8901-2345-6789abcdef01"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3166));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("c2a98b89-b536-48a0-96f6-29d23a0138ac"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3206));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("cd55e17f-17e9-4df8-82ab-1bd0fdfdee92"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3204));

            migrationBuilder.UpdateData(
                table: "TourCompany",
                keyColumn: "TourCompanyId",
                keyValue: new Guid("dc13d1dd-12cc-4153-9511-f59ff63f679b"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(3169));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7652));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7657));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7660));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7645));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7667));

            migrationBuilder.UpdateData(
                table: "TourDestination",
                keyColumn: "TourDestinationId",
                keyValue: new Guid("64000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7663));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7576));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7580), new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7580) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7584));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7588));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7590));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7594), new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7594) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7597));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7602), new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7603) });

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7605));

            migrationBuilder.UpdateData(
                table: "TourGuide",
                keyColumn: "GuideId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                columns: new[] { "CreateDate", "UpdateDate" },
                values: new object[] { new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7608), new DateTime(2025, 5, 5, 10, 22, 57, 395, DateTimeKind.Utc).AddTicks(7608) });

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4170));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4172));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4175));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("20000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4177));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4179));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4185));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4188));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("30000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4190));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("64fad407-a8bb-4b84-923f-65a9131d77e4"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4159));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("9115f3c1-f621-464d-9c4a-71d67fe65a22"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4165));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("b07f1613-0a7d-4bbf-8a2f-8f5f3a4e118c"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4162));

            migrationBuilder.UpdateData(
                table: "TourismPackage",
                keyColumn: "PackageId",
                keyValue: new Guid("c2d2ad88-bf20-4ac9-9e2c-0b1b5fe502ad"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 10, 22, 57, 393, DateTimeKind.Utc).AddTicks(4168));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000001"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3255));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000002"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3293));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000003"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3297));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000004"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3300));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000005"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3303));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000006"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3307));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000007"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3310));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000008"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3313));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000009"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3316));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000010"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3319));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000011"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3323));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000012"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3326));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000013"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3331));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000014"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3335));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000015"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3337));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000016"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3340));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000017"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3343));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000018"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3346));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000019"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3349));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000020"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3352));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000021"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3355));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000022"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3358));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000023"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3365));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000024"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3368));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000025"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3372));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000026"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3375));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000027"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3378));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000028"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3381));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000029"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3384));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000030"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3387));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000031"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3390));

            migrationBuilder.UpdateData(
                table: "TouristFacility",
                keyColumn: "TouristFacilityId",
                keyValue: new Guid("10000000-0000-0000-0000-000000000032"),
                column: "CreateDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(3393));

            migrationBuilder.InsertData(
                table: "UserIssue",
                columns: new[] { "IssueId", "CreatedDate", "IssueDescription", "IssueType", "SolutionContent", "UpdatedDate" },
                values: new object[,]
                {
                    { new Guid("17778b0a-07db-4018-bbf6-8186f94b1dec"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4118), "Người dùng yêu cầu cập nhật thông tin cá nhân (email, số điện thoại).", 10, "1. Xác minh danh tính người yêu cầu. \n2. Cập nhật thông tin theo yêu cầu nếu hợp lệ. \n3. Gửi xác nhận thay đổi cho người dùng.", null },
                    { new Guid("1e2bc1d8-7143-497e-8095-d0c3ede8f321"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4116), "Cần thêm tính năng xuất báo cáo sang Excel.", 9, "1. Ghi nhận yêu cầu và đưa vào backlog. \n2. Xác định mức độ ưu tiên của tính năng. \n3. Đưa vào kế hoạch phát triển nếu phù hợp.", null },
                    { new Guid("2137f734-cd08-48de-bb64-30f18818603c"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4120), "Vấn đề khác không thuộc các danh mục trên.", 11, "1. Xác minh chi tiết vấn đề. \n2. Chuyển đến bộ phận phù hợp để xử lý. \n3. Phản hồi cho người dùng về cách giải quyết.", null },
                    { new Guid("24a69220-8fb7-4d12-ae87-2473f09ee6cc"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4114), "Người dùng bị trừ sai số tiền khi thanh toán.", 8, "1. Kiểm tra lịch sử giao dịch và xác minh số tiền bị trừ. \n2. Nếu lỗi thuộc về hệ thống, tiến hành hoàn tiền cho khách hàng. \n3. Sửa lỗi hệ thống nếu có để tránh tái diễn.", null },
                    { new Guid("2c20a582-0c72-41eb-bda3-0840052a894b"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4103), "Trang dashboard tải rất chậm, mất hơn 10 giây để hiển thị dữ liệu.", 1, "1. Kiểm tra truy vấn SQL xem có truy vấn nặng không. \n2. Sử dụng caching để giảm tải dữ liệu truy vấn lặp lại. \n3. Tối ưu code frontend/backend để giảm thời gian tải trang.", null },
                    { new Guid("3bc31551-8e48-447c-8b70-18036fc99472"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4108), "Tài khoản bị khóa do nhập sai mật khẩu nhiều lần.", 4, "1. Kiểm tra trạng thái tài khoản trong hệ thống. \n2. Nếu bị khóa, hướng dẫn người dùng xác thực email hoặc liên hệ hỗ trợ. \n3. Cung cấp tùy chọn mở khóa tài khoản nếu hợp lệ.", null },
                    { new Guid("6661bc2a-0f19-4cc5-a699-8d5a00a5f046"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4106), "API kết nối với hệ thống thanh toán báo lỗi 500 Internal Server Error.", 2, "1. Xác minh API key và endpoint có chính xác không. \n2. Kiểm tra log server để biết nguyên nhân lỗi. \n3. Liên hệ với nhà cung cấp API để kiểm tra nếu cần.", null },
                    { new Guid("80cff09d-405a-4b84-ac74-9c9bf5154dc9"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4098), "Người dùng không thể đăng nhập dù đã nhập đúng tài khoản và mật khẩu.", 3, "1. Kiểm tra xem tài khoản có bị khóa hay không. \n2. Hướng dẫn người dùng đặt lại mật khẩu. \n3. Kiểm tra lỗi hệ thống xác thực nếu sự cố vẫn tiếp diễn.", null },
                    { new Guid("871808d0-0c74-4ccf-a7af-0c4ccde2814b"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4110), "Người dùng không thể truy cập trang quản lý mặc dù có quyền admin.", 5, "1. Kiểm tra xem quyền truy cập đã được cấp đúng chưa. \n2. Cập nhật phân quyền nếu cần thiết. \n3. Kiểm tra lại mã nguồn hoặc chính sách bảo mật.", null },
                    { new Guid("96b21098-e327-4a3f-9d1a-142ea6c52377"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4113), "Người dùng yêu cầu hoàn tiền do giao dịch lỗi.", 7, "1. Xác minh giao dịch và lý do hoàn tiền. \n2. Thực hiện hoàn tiền theo chính sách công ty. \n3. Gửi thông báo cho người dùng về trạng thái hoàn tiền.", null },
                    { new Guid("e098e8e3-952f-4289-b216-c9f0c50c1186"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4101), "Lỗi không thể thêm sản phẩm vào giỏ hàng.", 0, "1. Kiểm tra lại logic xử lý thêm sản phẩm vào giỏ hàng. \n2. Xem xét console log hoặc error log để xác định lỗi cụ thể. \n3. Cập nhật hoặc sửa lỗi trong mã nguồn nếu cần thiết.", null },
                    { new Guid("f1d00707-6e9c-4bdd-bca9-25170fc4ce44"), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4111), "Thanh toán không thành công do lỗi ngân hàng.", 6, "1. Kiểm tra xem số dư tài khoản của khách hàng có đủ không. \n2. Hướng dẫn thử lại hoặc sử dụng phương thức thanh toán khác. \n3. Kiểm tra log giao dịch để xác minh nguyên nhân.", null }
                });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("114f2c5f-1bd9-40db-b843-439bc8977870"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4057), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4058) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("17b8cac1-6f3b-4915-bdff-9c79a7038d15"),
                column: "RequestDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4048));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("43ad2d80-0753-48c1-b699-8a0267205d33"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4050), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4051) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("80776a2c-237f-4f1a-b014-a8c40698f02e"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4063), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4064) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b3f8be2e-b550-472e-ba86-035476b4296d"),
                column: "RequestDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4046));

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("b90b8b8f-0a33-419c-9e44-a69531155625"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4060), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4061) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("c55339f0-3fc2-4de6-8ca5-c78a49248981"),
                columns: new[] { "RequestDate", "ResponseDate" },
                values: new object[] { new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4053), new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4054) });

            migrationBuilder.UpdateData(
                table: "UserSupport",
                keyColumn: "SupportId",
                keyValue: new Guid("d549690a-59da-4c91-8179-7ba2102800e2"),
                column: "RequestDate",
                value: new DateTime(2025, 5, 5, 17, 22, 57, 393, DateTimeKind.Local).AddTicks(4043));
        }
    }
}
