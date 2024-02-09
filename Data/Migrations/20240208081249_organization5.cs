using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class organization5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d5f51bc1-a01c-49b1-ac80-918f524dbf89", "3d3b3672-741c-46a6-8883-3b587e44c777" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "627ac77e-1b46-403b-8b30-63d5b77224d6", "c12de0e2-0e9e-4d48-b47c-236064a057e4" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "627ac77e-1b46-403b-8b30-63d5b77224d6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d5f51bc1-a01c-49b1-ac80-918f524dbf89");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "3d3b3672-741c-46a6-8883-3b587e44c777");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c12de0e2-0e9e-4d48-b47c-236064a057e4");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "627ac77e-1b46-403b-8b30-63d5b77224d6", "627ac77e-1b46-403b-8b30-63d5b77224d6", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d5f51bc1-a01c-49b1-ac80-918f524dbf89", "d5f51bc1-a01c-49b1-ac80-918f524dbf89", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "3d3b3672-741c-46a6-8883-3b587e44c777", 0, "dd31f8d1-e7d9-4705-be44-2104057acaac", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEFfp9v+67ISvCviNOBXaTjhk7QnkV/GgtC80rXHgleLntmThSElfL1m+bToOmVWgWQ==", null, false, "ada09f91-1c47-4f40-81e0-2455e168f1ce", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c12de0e2-0e9e-4d48-b47c-236064a057e4", 0, "bd713d5d-d9cd-4035-9077-c0f41fd4e193", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USEREXAMPLE", "AQAAAAEAACcQAAAAEJUXxl3z40P6FkNBmPrGtxpLW8nI3FpPhMNe0WANxoz0M4E+f0EpBOwQiqpnlqA4pQ==", null, false, "7cbdedc2-50c7-4fd2-8bda-cfabefee8f54", false, "userexample" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d5f51bc1-a01c-49b1-ac80-918f524dbf89", "3d3b3672-741c-46a6-8883-3b587e44c777" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "627ac77e-1b46-403b-8b30-63d5b77224d6", "c12de0e2-0e9e-4d48-b47c-236064a057e4" });
        }
    }
}
