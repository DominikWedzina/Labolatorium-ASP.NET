using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class organization4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "32290a0c-6107-4390-aef4-604528e001bf", "8677ffb0-3932-44e8-963c-0891d07fdf60" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "2b7081b8-bbf0-4a6b-876a-74a400d103cd", "d2ef9211-9e1c-4a6d-b3cf-215e2f58c19f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "2b7081b8-bbf0-4a6b-876a-74a400d103cd");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "32290a0c-6107-4390-aef4-604528e001bf");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "8677ffb0-3932-44e8-963c-0891d07fdf60");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "d2ef9211-9e1c-4a6d-b3cf-215e2f58c19f");

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

        protected override void Down(MigrationBuilder migrationBuilder)
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
                values: new object[] { "2b7081b8-bbf0-4a6b-876a-74a400d103cd", "2b7081b8-bbf0-4a6b-876a-74a400d103cd", "admin", "ADMIN" });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[] { "32290a0c-6107-4390-aef4-604528e001bf", "32290a0c-6107-4390-aef4-604528e001bf", "user", "USER" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "8677ffb0-3932-44e8-963c-0891d07fdf60", 0, "86c596ed-6b53-4b9b-a745-3da0fb244de5", "user@example.com", true, false, null, "USER@EXAMPLE.COM", "USEREXAMPLE", "AQAAAAEAACcQAAAAEOO1a5qkYSvBLeQQMX2yPJwqYfUEVO825RSkqnpIumZHsJQVAzicGSwrAJnXSgcYpQ==", null, false, "f05b5028-1284-421e-92b9-629498719736", false, "userexample" });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "d2ef9211-9e1c-4a6d-b3cf-215e2f58c19f", 0, "02cf24e7-1ab1-48d7-b6c0-536181ebbf7b", "adam@wsei.edu.pl", true, false, null, "ADAM@WSEI.EDU.PL", "ADMIN", "AQAAAAEAACcQAAAAEFJK6pBjXEjvC1LeiW6i4zO5LQP0FdUrWFbLCorDRyiEuNTSlqpApgo+OfeykYILCA==", null, false, "2e2ab736-dacf-4516-9561-42b1b7255909", false, "adam" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "32290a0c-6107-4390-aef4-604528e001bf", "8677ffb0-3932-44e8-963c-0891d07fdf60" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "2b7081b8-bbf0-4a6b-876a-74a400d103cd", "d2ef9211-9e1c-4a6d-b3cf-215e2f58c19f" });
        }
    }
}
