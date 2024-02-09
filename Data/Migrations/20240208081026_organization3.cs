using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Data.Migrations
{
    public partial class organization3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
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
    }
}
