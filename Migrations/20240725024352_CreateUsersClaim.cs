using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Globomantics.Survey.Migrations
{
    /// <inheritdoc />
    public partial class CreateUsersClaim : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b6bc81b0-0ce5-4dd9-af35-cf73485ae281", "6acccbb4-93a7-4bee-9214-a2d8b8e0aa6c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b6bc81b0-0ce5-4dd9-af35-cf73485ae281");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6acccbb4-93a7-4bee-9214-a2d8b8e0aa6c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5cbc3820-df20-43dc-a826-bca767062386", "1", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "39fb8ecf-b13d-4594-bfbd-efd4b54d6631", 0, "ec8c5612-6a29-499d-8a61-f2302a1b2fb8", "Admin@globomantics.com", true, false, null, "ADMIN@GLOBOMANTICS.COM", "ADMIN@GLOBOMANTICS.COM", "AQAAAAIAAYagAAAAEBtXP+AyHaMenSIigxC0aTvWC/NYXcpeM98YkTgvYFSaR+x9r6MDDgmXw06sEjxbRA==", null, false, "00bf9181-5e4b-4df6-b02f-d55ba615adbc", false, "Admin@globomantics.com" },
                    { "46aaf9fb-0d4f-4e89-ae8d-8a6980aeaeb0", 0, "515e1918-e953-4c0a-a5b6-08bc0634aec6", "SuperAdmin@globomantics.com", true, false, null, "SUPERADMIN@GLOBOMANTICS.COM", "SUPERADMIN@GLOBOMANTICS.COM", "AQAAAAIAAYagAAAAEPat62KaazvC9sNTTqU5Q269N6Im1FtGmyqxok45d5MIPReyM+gJ10q3aCpchnYMaw==", null, false, "b132f3ba-2c48-4229-800e-5e4777dd2620", false, "SuperAdmin@globomantics.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "IsManager", "true", "46aaf9fb-0d4f-4e89-ae8d-8a6980aeaeb0" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "5cbc3820-df20-43dc-a826-bca767062386", "39fb8ecf-b13d-4594-bfbd-efd4b54d6631" },
                    { "5cbc3820-df20-43dc-a826-bca767062386", "46aaf9fb-0d4f-4e89-ae8d-8a6980aeaeb0" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserClaims",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5cbc3820-df20-43dc-a826-bca767062386", "39fb8ecf-b13d-4594-bfbd-efd4b54d6631" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5cbc3820-df20-43dc-a826-bca767062386", "46aaf9fb-0d4f-4e89-ae8d-8a6980aeaeb0" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5cbc3820-df20-43dc-a826-bca767062386");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "39fb8ecf-b13d-4594-bfbd-efd4b54d6631");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "46aaf9fb-0d4f-4e89-ae8d-8a6980aeaeb0");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b6bc81b0-0ce5-4dd9-af35-cf73485ae281", "1", "Administrator", "ADMINISTRATOR" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6acccbb4-93a7-4bee-9214-a2d8b8e0aa6c", 0, "b0e288f5-2fbf-405f-9749-5da6764a24eb", "Admin@globomantics.com", true, false, null, "ADMIN@GLOBOMANTICS.COM", "ADMIN@GLOBOMANTICS.COM", "AQAAAAIAAYagAAAAEPwMSarZTc5RZlhsaHJH+qld+8xdmjoQvTxJia1lbk7qganWSPUMKSfWm/r4qq4Fnw==", null, false, "fcbfd637-e324-4370-bc28-eba0c1ac3e8a", false, "Admin@globomantics.com" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b6bc81b0-0ce5-4dd9-af35-cf73485ae281", "6acccbb4-93a7-4bee-9214-a2d8b8e0aa6c" });
        }
    }
}
