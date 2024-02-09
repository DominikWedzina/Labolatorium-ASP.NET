using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "6db591a7-bf50-428a-9f1c-2c7be03781d6", "6986b48b-dc48-4bcc-82c0-48238a779873" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "5e594085-58f8-40f8-aebb-6a639f2effe9", "d08aadee-ec9c-46ec-abc7-655b6337810c" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "5e594085-58f8-40f8-aebb-6a639f2effe9");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "6db591a7-bf50-428a-9f1c-2c7be03781d6");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "6986b48b-dc48-4bcc-82c0-48238a779873");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d08aadee-ec9c-46ec-abc7-655b6337810c");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d56dd5ab-b9eb-482c-920e-525f23af99be", "d56dd5ab-b9eb-482c-920e-525f23af99be", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "d7ef5c65-788d-4e2c-801d-b3419cef09ec", "d7ef5c65-788d-4e2c-801d-b3419cef09ec", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "4fab78ca-73d2-45e2-b5f7-1c78fbac3f70", 0, "f3c0a0c8-d16a-4cb6-a26e-87f828d37366", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEPY3bv9a5KDMZBA5r+UhPMou01xLbwKPc7Yf3MWlycmXQ/N8w//EC7CNbXbeAFjMTA==", null, false, "52d2cdfd-de52-4f72-849b-5e6533859202", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "76ab7f2d-a679-4b49-8d67-ad41f08f1c96", 0, "66926ae6-6012-481b-a654-1c9122259382", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USEREXAMPLE", "AQAAAAEAACcQAAAAEPe7hxirICejSAwRAtsk0M8hl4cLTIE3vfeztVBZO5Ca2FV8coKJ41C5PlK0vb24BA==", null, false, "6804491f-6bad-4fc4-b7b5-e8adf1c1a822", false, "userexample" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "ITAKA");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "TUI");

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "To Madrid");

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndPlace", "Name", "Participants", "StartPlace" },
                values: new object[] { "Paris", "To Paris", "Matt, Arthur, Kate", "London" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d7ef5c65-788d-4e2c-801d-b3419cef09ec", "4fab78ca-73d2-45e2-b5f7-1c78fbac3f70" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "d56dd5ab-b9eb-482c-920e-525f23af99be", "76ab7f2d-a679-4b49-8d67-ad41f08f1c96" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d7ef5c65-788d-4e2c-801d-b3419cef09ec", "4fab78ca-73d2-45e2-b5f7-1c78fbac3f70" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d56dd5ab-b9eb-482c-920e-525f23af99be", "76ab7f2d-a679-4b49-8d67-ad41f08f1c96" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d56dd5ab-b9eb-482c-920e-525f23af99be");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d7ef5c65-788d-4e2c-801d-b3419cef09ec");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "4fab78ca-73d2-45e2-b5f7-1c78fbac3f70");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "76ab7f2d-a679-4b49-8d67-ad41f08f1c96");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "5e594085-58f8-40f8-aebb-6a639f2effe9", "5e594085-58f8-40f8-aebb-6a639f2effe9", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "6db591a7-bf50-428a-9f1c-2c7be03781d6", "6db591a7-bf50-428a-9f1c-2c7be03781d6", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6986b48b-dc48-4bcc-82c0-48238a779873", 0, "7219f2e3-6f67-41dd-ae46-f808e6dd93a0", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEC69OsehVa4Ryga/INArsVZRDj6/i7c6hWF7S+klcNYgQ5GFPCLDIoKmnBjNg9kCpw==", null, false, "53ded1ba-0b46-4ef5-8edd-b9ee9a19078b", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d08aadee-ec9c-46ec-abc7-655b6337810c", 0, "4f9c2939-6d2a-4233-a919-d98961c61231", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USEREXAMPLE", "AQAAAAEAACcQAAAAEKHHbCmP7NoWT9ASZPJhBEFqJ6UqcqnpgGrIAesd6B4ulMOXOECyXTzlrNx6PuHDjw==", null, false, "6bbd5f8b-daaa-48d8-9d21-68113bd88ba8", false, "userexample" });

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 1,
                column: "Title",
                value: "WSEI");

            migrationBuilder.UpdateData(
                table: "Organizations",
                keyColumn: "Id",
                keyValue: 2,
                column: "Title",
                value: "Administracja");

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Viaje a la luna");

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "Id",
                keyValue: 2,
                columns: new[] { "EndPlace", "Name", "Participants", "StartPlace" },
                values: new object[] { "Luna", "Viaje a la luna 2", "Juan, Pedro, Luis", "Madrid" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6db591a7-bf50-428a-9f1c-2c7be03781d6", "6986b48b-dc48-4bcc-82c0-48238a779873" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5e594085-58f8-40f8-aebb-6a639f2effe9", "d08aadee-ec9c-46ec-abc7-655b6337810c" });
        }
    }
}
