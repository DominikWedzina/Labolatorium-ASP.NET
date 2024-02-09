using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class organization7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "0505d130-6951-49e9-8904-7ad5085fa9f4", "0505d130-6951-49e9-8904-7ad5085fa9f4", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "1a697fa9-1890-4679-b85d-ad18dd6bb87a", "1a697fa9-1890-4679-b85d-ad18dd6bb87a", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4099e50d-f7eb-437b-9abd-f744a188a84f", 0, "aab54ac2-b78a-4ae8-b08b-b54180e45c72", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USEREXAMPLE", "AQAAAAEAACcQAAAAEIFZTwNe8ktRNKqaDoIiAtScUhHBSQMxr3a+PDZfF46TCAX0JL5ecomn2x5UMwACKA==", null, false, "3c2272c4-0e22-4bfc-a303-b83e35b37fc1", false, "userexample" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c05ed098-c087-4e64-9e8b-ba8a60ccd07b", 0, "9bbb750c-975d-4c87-b1ca-ba4cf28d2aa1", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEFBwgbQLMySt3nFGhxEPt7vqBa9+u5m98vXKCJw0VPtiBpbhvoIohXo4Jk6sYrRQeQ==", null, false, "18fa4552-c96e-4f49-8588-a9ef95e607e0", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "0505d130-6951-49e9-8904-7ad5085fa9f4", "4099e50d-f7eb-437b-9abd-f744a188a84f" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1a697fa9-1890-4679-b85d-ad18dd6bb87a", "c05ed098-c087-4e64-9e8b-ba8a60ccd07b" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "0505d130-6951-49e9-8904-7ad5085fa9f4", "4099e50d-f7eb-437b-9abd-f744a188a84f" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "1a697fa9-1890-4679-b85d-ad18dd6bb87a", "c05ed098-c087-4e64-9e8b-ba8a60ccd07b" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "0505d130-6951-49e9-8904-7ad5085fa9f4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "1a697fa9-1890-4679-b85d-ad18dd6bb87a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4099e50d-f7eb-437b-9abd-f744a188a84f");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c05ed098-c087-4e64-9e8b-ba8a60ccd07b");

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
    }
}
