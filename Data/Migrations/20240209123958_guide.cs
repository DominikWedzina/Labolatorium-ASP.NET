using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class guide : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.DropColumn(
                name: "Guide",
                table: "Travels");

            migrationBuilder.AddColumn<int>(
                name: "GuideId",
                table: "Travels",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Guides",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false),
                    Name = table.Column<string>(type: "TEXT", nullable: false),
                    Languages = table.Column<string>(type: "TEXT", nullable: false),
                    Address_City = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Street = table.Column<string>(type: "TEXT", nullable: true),
                    Address_PostalCode = table.Column<string>(type: "TEXT", nullable: true),
                    Address_Region = table.Column<string>(type: "TEXT", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Guides", x => x.Id);
                });

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
                table: "Guides",
                columns: new[] { "Id", "Languages", "Name", "Address_City", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 1, "English, Spanish", "John Doe", "Barcelona", "08001", "Catalonia", "Calle Falsa 123" });

            migrationBuilder.InsertData(
                table: "Guides",
                columns: new[] { "Id", "Languages", "Name", "Address_City", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 2, "French, English", "Anna Smith", "Paris", "75001", "Île-de-France", "Rue de Paris 45" });

            migrationBuilder.InsertData(
                table: "Guides",
                columns: new[] { "Id", "Languages", "Name", "Address_City", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 3, "Spanish, Portuguese", "Carlos Ruiz", "Lisbon", "1250-146", "Lisboa", "Avenida de Liberdade 170" });

            migrationBuilder.InsertData(
                table: "Guides",
                columns: new[] { "Id", "Languages", "Name", "Address_City", "Address_PostalCode", "Address_Region", "Address_Street" },
                values: new object[] { 4, "Chinese, English", "Liu Wei", "Beijing", "100010", "Beijing", "Dongcheng District 5" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "3281719d-9a0f-4d57-9f56-ace9d841b1b4", "c528e923-33a1-4b44-89a8-c4f32b72227d" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "c3dd8f80-d622-459f-b85d-92cb9d6b2d40", "e281da5e-7789-4747-859f-ac2ab9930053" });

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "Id",
                keyValue: 1,
                column: "GuideId",
                value: 1);

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "Id",
                keyValue: 2,
                column: "GuideId",
                value: 2);

            migrationBuilder.CreateIndex(
                name: "IX_Travels_GuideId",
                table: "Travels",
                column: "GuideId");

            migrationBuilder.AddForeignKey(
                name: "FK_Travels_Guides_GuideId",
                table: "Travels",
                column: "GuideId",
                principalTable: "Guides",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Travels_Guides_GuideId",
                table: "Travels");

            migrationBuilder.DropTable(
                name: "Guides");

            migrationBuilder.DropIndex(
                name: "IX_Travels_GuideId",
                table: "Travels");

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

            migrationBuilder.DropColumn(
                name: "GuideId",
                table: "Travels");

            migrationBuilder.AddColumn<string>(
                name: "Guide",
                table: "Travels",
                type: "TEXT",
                maxLength: 50,
                nullable: false,
                defaultValue: "");

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

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "Id",
                keyValue: 1,
                column: "Guide",
                value: "Luis");

            migrationBuilder.UpdateData(
                table: "Travels",
                keyColumn: "Id",
                keyValue: 2,
                column: "Guide",
                value: "Luis");

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "37179afd-2946-4fcf-a5ae-e2692ee12cd6", "2707ec57-7d39-48a7-8248-b21e9278462a" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "28caf48c-3412-41bc-aee5-5eae1d6684cc", "41f3b1a9-af98-4680-bb5f-01867301aef7" });
        }
    }
}
