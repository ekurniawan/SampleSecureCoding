using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Globomantics.Survey.Migrations
{
    /// <inheritdoc />
    public partial class CreateUsersRole : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
        }
    }
}
