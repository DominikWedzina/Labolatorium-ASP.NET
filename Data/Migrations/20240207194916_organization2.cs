using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class organization2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ff1b4732-63cf-4446-b533-c26d9fb80003", "9526653b-6de7-4f76-ac4c-d7f7d1332c36" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bc1dd95b-d40e-4f46-8cf7-9e8b5ea6a8f2", "a6998200-5546-4290-846b-e2de96412118" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bc1dd95b-d40e-4f46-8cf7-9e8b5ea6a8f2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ff1b4732-63cf-4446-b533-c26d9fb80003");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9526653b-6de7-4f76-ac4c-d7f7d1332c36");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a6998200-5546-4290-846b-e2de96412118");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "4b27fe93-a656-4dc3-a70a-f8476706d2aa", "4b27fe93-a656-4dc3-a70a-f8476706d2aa", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "55dc27b3-0a4a-4bc9-950a-071547816b37", "55dc27b3-0a4a-4bc9-950a-071547816b37", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "bccf4df2-3aac-4f90-a86f-efa3d231dbce", 0, "cb0beb1f-6a3c-40cc-aa84-225fdb006fad", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEL4zTRswV8RtxBhq+sI81djWUd2vdztWILcpb0rtTsPRKxLqRUu2DGTk6352K/gWcw==", null, false, "0b0869ee-6944-4c89-898c-6864fa6a105b", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d7adb9c2-34ae-4619-9f97-2874d7c6f2ee", 0, "9e74d22f-c139-4430-9b51-8772b0c4a1fd", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USEREXAMPLE", "AQAAAAEAACcQAAAAEHfAEVS+IjapH4yh3948dY44qzssGMRTJ41FOtWwscUAH3CiM6aSoqVSAI7LXYFjsw==", null, false, "64a42752-949a-47cc-abe3-7f9b18e258e3", false, "userexample" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "55dc27b3-0a4a-4bc9-950a-071547816b37", "bccf4df2-3aac-4f90-a86f-efa3d231dbce" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "4b27fe93-a656-4dc3-a70a-f8476706d2aa", "d7adb9c2-34ae-4619-9f97-2874d7c6f2ee" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "55dc27b3-0a4a-4bc9-950a-071547816b37", "bccf4df2-3aac-4f90-a86f-efa3d231dbce" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "4b27fe93-a656-4dc3-a70a-f8476706d2aa", "d7adb9c2-34ae-4619-9f97-2874d7c6f2ee" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "4b27fe93-a656-4dc3-a70a-f8476706d2aa");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "55dc27b3-0a4a-4bc9-950a-071547816b37");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "bccf4df2-3aac-4f90-a86f-efa3d231dbce");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d7adb9c2-34ae-4619-9f97-2874d7c6f2ee");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "bc1dd95b-d40e-4f46-8cf7-9e8b5ea6a8f2", "bc1dd95b-d40e-4f46-8cf7-9e8b5ea6a8f2", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "ff1b4732-63cf-4446-b533-c26d9fb80003", "ff1b4732-63cf-4446-b533-c26d9fb80003", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "9526653b-6de7-4f76-ac4c-d7f7d1332c36", 0, "57e6f087-42f1-4e11-b426-a72cce989768", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEMpIN2wvYtYpBgdaIWl8wlS4rE9CucdmEkbCj8BTMnxYiQpZfWrTRRf71i8D3IxCEg==", null, false, "4e19e05f-7eac-413a-a2a0-ed43252f689c", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "a6998200-5546-4290-846b-e2de96412118", 0, "89ea4ad7-3705-4666-9c17-eeb8876c69c8", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USEREXAMPLE", "AQAAAAEAACcQAAAAEGWOAc7g+/iSggE8l0DVzDTKmNRneKI62rR73wXJC4SQ0tTPsaRD6UjIWlqvuVPpPg==", null, false, "f23e8032-ee37-4b10-8322-81e36b22912d", false, "userexample" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "ff1b4732-63cf-4446-b533-c26d9fb80003", "9526653b-6de7-4f76-ac4c-d7f7d1332c36" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "bc1dd95b-d40e-4f46-8cf7-9e8b5ea6a8f2", "a6998200-5546-4290-846b-e2de96412118" });
        }
    }
}
