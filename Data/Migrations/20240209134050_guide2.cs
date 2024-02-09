using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class guide2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "3281719d-9a0f-4d57-9f56-ace9d841b1b4", "c528e923-33a1-4b44-89a8-c4f32b72227d" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c3dd8f80-d622-459f-b85d-92cb9d6b2d40", "e281da5e-7789-4747-859f-ac2ab9930053" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "3281719d-9a0f-4d57-9f56-ace9d841b1b4");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c3dd8f80-d622-459f-b85d-92cb9d6b2d40");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "c528e923-33a1-4b44-89a8-c4f32b72227d");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e281da5e-7789-4747-859f-ac2ab9930053");

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

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "6db591a7-bf50-428a-9f1c-2c7be03781d6", "6986b48b-dc48-4bcc-82c0-48238a779873" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "5e594085-58f8-40f8-aebb-6a639f2effe9", "d08aadee-ec9c-46ec-abc7-655b6337810c" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "3281719d-9a0f-4d57-9f56-ace9d841b1b4", "3281719d-9a0f-4d57-9f56-ace9d841b1b4", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "c3dd8f80-d622-459f-b85d-92cb9d6b2d40", "c3dd8f80-d622-459f-b85d-92cb9d6b2d40", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "c528e923-33a1-4b44-89a8-c4f32b72227d", 0, "f0f09be4-7d8d-447b-90ff-8e637d1ddb42", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USEREXAMPLE", "AQAAAAEAACcQAAAAEOlaXIRxY88vLHZYV/0BxyHCXIzBqqgnnhSV8PsnUShGofRRrFxt2y+3v/I0A9IVGw==", null, false, "e8b8afd5-3637-4cee-96ee-77e122f5e48b", false, "userexample" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "e281da5e-7789-4747-859f-ac2ab9930053", 0, "780cff25-d703-4bcd-8513-def4c83db882", "admin@example.com", true, false, null, "ADMIN@EXAMPLE.COM", "ADMIN", "AQAAAAEAACcQAAAAEPE736Kz7XNZoZQgeOiPWQ14nbX9vwAS+ebaJrtZ0+JmAtdiLto+0FsSVbuAClnsmg==", null, false, "5e4aeddc-13c6-4346-9ab5-bb7b22b09181", false, "admin" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3281719d-9a0f-4d57-9f56-ace9d841b1b4", "c528e923-33a1-4b44-89a8-c4f32b72227d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c3dd8f80-d622-459f-b85d-92cb9d6b2d40", "e281da5e-7789-4747-859f-ac2ab9930053" });
        }
    }
}
