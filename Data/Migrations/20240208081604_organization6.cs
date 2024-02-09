using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class organization6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b575e3e4-0b66-462c-86d0-c8a591a7a275", "0b974d69-6648-41a8-aab2-522f3a1e6e97" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "09b3e106-0b67-4f9b-b2ee-13c3fdc24681", "b97ddb36-a506-45ec-b57c-c26e2afb2a95" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "09b3e106-0b67-4f9b-b2ee-13c3fdc24681");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b575e3e4-0b66-462c-86d0-c8a591a7a275");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0b974d69-6648-41a8-aab2-522f3a1e6e97");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b97ddb36-a506-45ec-b57c-c26e2afb2a95");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b37fb77-4756-4a2a-b8ba-ac51a1e81846", "4b37fb77-4756-4a2a-b8ba-ac51a1e81846", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "a0367655-7195-4426-9d7e-94e7eaac4437", "a0367655-7195-4426-9d7e-94e7eaac4437", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b4a5b0e0-192e-4fc4-892d-86129dcf5d2e", 0, "f97dddf6-9b88-4354-a376-53809cb6af2a", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USEREXAMPLE", "AQAAAAEAACcQAAAAEOwdlQaS2eP/XOV0VoD6dBDfDC7Kyuecec0c78rBtROD8sTYGgn6Btpuf49rN8SP2A==", null, false, "085c757e-bf8f-4bcf-8116-f3c52ccba68b", false, "userexample" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "f237c03f-6c63-444d-b4a3-224d9dd04df2", 0, "90b2e11b-ce64-445c-89aa-cb79e22da4ee", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEAuyID3/W/1MepYTJGJCd3pAx39T7+PQKnF15Xxg5Noqbe4hwvSwRFkmRi+cRUPP3Q==", null, false, "d98aa1f2-9ec3-49ea-ae14-6f3010faf941", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "a0367655-7195-4426-9d7e-94e7eaac4437", "b4a5b0e0-192e-4fc4-892d-86129dcf5d2e" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4b37fb77-4756-4a2a-b8ba-ac51a1e81846", "f237c03f-6c63-444d-b4a3-224d9dd04df2" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a0367655-7195-4426-9d7e-94e7eaac4437", "b4a5b0e0-192e-4fc4-892d-86129dcf5d2e" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4b37fb77-4756-4a2a-b8ba-ac51a1e81846", "f237c03f-6c63-444d-b4a3-224d9dd04df2" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b37fb77-4756-4a2a-b8ba-ac51a1e81846");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a0367655-7195-4426-9d7e-94e7eaac4437");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b4a5b0e0-192e-4fc4-892d-86129dcf5d2e");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f237c03f-6c63-444d-b4a3-224d9dd04df2");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "09b3e106-0b67-4f9b-b2ee-13c3fdc24681", "09b3e106-0b67-4f9b-b2ee-13c3fdc24681", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "b575e3e4-0b66-462c-86d0-c8a591a7a275", "b575e3e4-0b66-462c-86d0-c8a591a7a275", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "0b974d69-6648-41a8-aab2-522f3a1e6e97", 0, "11383031-080f-4b7d-80e9-4ef772923fc5", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USEREXAMPLE", "AQAAAAEAACcQAAAAEOvQ8pcQ3dpRzO+S06Y8qT4PBUwa3LnyjekXZvCOSqpbOxdKmsrvX7+LjOi6N/Av2A==", null, false, "7d3c134b-cb27-496f-93b8-d9eb9496c338", false, "userexample" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "b97ddb36-a506-45ec-b57c-c26e2afb2a95", 0, "d7e70620-e621-404e-a3de-4e88fb20a374", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEPdpz9YWbDFmWJwCV7DLUu5uwOCEVSs2gDD5QcVqDet23/zqzzyblAYlZnlQ0i8KYQ==", null, false, "51d01de3-92b8-499e-9b88-908775338ad6", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "b575e3e4-0b66-462c-86d0-c8a591a7a275", "0b974d69-6648-41a8-aab2-522f3a1e6e97" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "09b3e106-0b67-4f9b-b2ee-13c3fdc24681", "b97ddb36-a506-45ec-b57c-c26e2afb2a95" });
        }
    }
}
