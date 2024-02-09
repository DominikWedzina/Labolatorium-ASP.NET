using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class organization8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                values: new object[] { "28caf48c-3412-41bc-aee5-5eae1d6684cc", "28caf48c-3412-41bc-aee5-5eae1d6684cc", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "37179afd-2946-4fcf-a5ae-e2692ee12cd6", "37179afd-2946-4fcf-a5ae-e2692ee12cd6", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "2707ec57-7d39-48a7-8248-b21e9278462a", 0, "fdf36d90-7eeb-4332-9bb1-b81372e4ad97", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEG1aOGI3GtTo4qbqRVZcp1sg134uHPS6IligzDkvqkZB/tDqjzeWhwF4MQrNXoz/lQ==", null, false, "3dd9f5b9-581a-4d53-bd78-93bf9738bc1f", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "41f3b1a9-af98-4680-bb5f-01867301aef7", 0, "e4c5221d-546f-4452-b817-727b1e59bca9", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USEREXAMPLE", "AQAAAAEAACcQAAAAEM4742cGs8dU0DIughPAUXnvHZ6v4Oc4TdRx0DBR21dTF5VwT/OwAfcVsLP/pj+AUw==", null, false, "1c0647f9-ffed-45b2-8ca9-cb350b77a0dc", false, "userexample" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "37179afd-2946-4fcf-a5ae-e2692ee12cd6", "2707ec57-7d39-48a7-8248-b21e9278462a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "28caf48c-3412-41bc-aee5-5eae1d6684cc", "41f3b1a9-af98-4680-bb5f-01867301aef7" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "37179afd-2946-4fcf-a5ae-e2692ee12cd6", "2707ec57-7d39-48a7-8248-b21e9278462a" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28caf48c-3412-41bc-aee5-5eae1d6684cc", "41f3b1a9-af98-4680-bb5f-01867301aef7" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28caf48c-3412-41bc-aee5-5eae1d6684cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "37179afd-2946-4fcf-a5ae-e2692ee12cd6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2707ec57-7d39-48a7-8248-b21e9278462a");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "41f3b1a9-af98-4680-bb5f-01867301aef7");

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
    }
}
