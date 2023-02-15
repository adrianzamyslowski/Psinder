using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Psinder.Repository.Migrations
{
    /// <inheritdoc />
    public partial class dodanie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "96827cbf-86eb-4f1b-8560-b11b64455570", "31230d16-6f5e-4513-b287-35a630cde420" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "be236bd2-ca25-48ae-a320-dc7d4ff99fed", "9a18b49c-4d61-4d2b-8c35-ea7c36c21622" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "fa57b9a0-1fc5-4261-88e4-96929a293a08", "e8fde6f7-2405-4fd2-bb64-51f51945e4c3" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "96827cbf-86eb-4f1b-8560-b11b64455570");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "be236bd2-ca25-48ae-a320-dc7d4ff99fed");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "fa57b9a0-1fc5-4261-88e4-96929a293a08");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "31230d16-6f5e-4513-b287-35a630cde420");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "9a18b49c-4d61-4d2b-8c35-ea7c36c21622");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8fde6f7-2405-4fd2-bb64-51f51945e4c3");

            migrationBuilder.RenameColumn(
                name: "Gender",
                table: "Dogs",
                newName: "GenderId");

            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GenderDog = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "024f11cf-e2b2-4677-a5d7-3ad99d645eb6", null, "IdentityRole", "Admin", "ADMIN" },
                    { "b3a2eef0-502d-4429-a20a-5f32b276074b", null, "IdentityRole", "RegularUser", "REGULARUSER" },
                    { "d070a5c2-addd-4128-b645-6768de3edc6b", null, "IdentityRole", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5af782bb-bcbf-4dc4-84cb-ef12a0374ba4", 0, "64a232e2-a6ba-4264-99f8-6a8674903c34", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "regular@regular.pl", false, false, null, "REGULAR@REGULAR.PL", "REGULAR", "AQAAAAIAAYagAAAAEDimiubZhqVBuC65JcYIJ9cxMmb5cZkKU2RJww1QJKmxP1nM/aLPQTMdO29/KZUPBw==", null, false, "f6c7e292-6284-459c-8bb4-e5c51d19e075", false, "regular" },
                    { "a4103b8b-96cf-4e4a-b515-c1888e9b1f66", 0, "7b5bfd5a-63b9-4248-8a3e-e7d30f12893f", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "moderator@moderator.pl", false, false, null, "MODERATOR@MODERATOR.PL", "MODERATOR", "AQAAAAIAAYagAAAAED2w5NOguUjo3/Iaj1fgIytj21ipfPlIglKbInkdACNzwcGKlpl+BEX0AfIkjSolIg==", null, false, "941dc97c-a673-43e9-aa73-995ab36060e7", false, "moderator" },
                    { "f91f31d2-10bf-4fea-9a21-52931ada3480", 0, "e50529f3-4f39-4bec-a2da-cbfef76d8f4c", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.pl", false, false, null, "ADMIN@ADMIN.PL", "ADMIN", "AQAAAAIAAYagAAAAENoY0kM9o3cZoML0Rm+z9Ea7FXQOQOo1Wff8xwPyylTdovWh421iSGcnB2HHfvKqnA==", null, false, "4410807a-459d-46b0-a999-015702a80602", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "GenderDog" },
                values: new object[,]
                {
                    { 1, "Pies" },
                    { 2, "Suczka" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "b3a2eef0-502d-4429-a20a-5f32b276074b", "5af782bb-bcbf-4dc4-84cb-ef12a0374ba4" },
                    { "d070a5c2-addd-4128-b645-6768de3edc6b", "a4103b8b-96cf-4e4a-b515-c1888e9b1f66" },
                    { "024f11cf-e2b2-4677-a5d7-3ad99d645eb6", "f91f31d2-10bf-4fea-9a21-52931ada3480" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_GenderId",
                table: "Dogs",
                column: "GenderId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_Genders_GenderId",
                table: "Dogs",
                column: "GenderId",
                principalTable: "Genders",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_Genders_GenderId",
                table: "Dogs");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_GenderId",
                table: "Dogs");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "b3a2eef0-502d-4429-a20a-5f32b276074b", "5af782bb-bcbf-4dc4-84cb-ef12a0374ba4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "d070a5c2-addd-4128-b645-6768de3edc6b", "a4103b8b-96cf-4e4a-b515-c1888e9b1f66" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "024f11cf-e2b2-4677-a5d7-3ad99d645eb6", "f91f31d2-10bf-4fea-9a21-52931ada3480" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "024f11cf-e2b2-4677-a5d7-3ad99d645eb6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "b3a2eef0-502d-4429-a20a-5f32b276074b");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "d070a5c2-addd-4128-b645-6768de3edc6b");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5af782bb-bcbf-4dc4-84cb-ef12a0374ba4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a4103b8b-96cf-4e4a-b515-c1888e9b1f66");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f91f31d2-10bf-4fea-9a21-52931ada3480");

            migrationBuilder.RenameColumn(
                name: "GenderId",
                table: "Dogs",
                newName: "Gender");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "96827cbf-86eb-4f1b-8560-b11b64455570", null, "IdentityRole", "RegularUser", "REGULARUSER" },
                    { "be236bd2-ca25-48ae-a320-dc7d4ff99fed", null, "IdentityRole", "Moderator", "MODERATOR" },
                    { "fa57b9a0-1fc5-4261-88e4-96929a293a08", null, "IdentityRole", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "31230d16-6f5e-4513-b287-35a630cde420", 0, "f889d7cf-e9c2-4836-bb77-61341e59051e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "regular@regular.pl", false, false, null, "REGULAR@REGULAR.PL", "REGULAR", "AQAAAAIAAYagAAAAEP0GaQyAJHIeQnI0z8vs+B1msI1Xk53fp+odHc4vDKeCalF7KO+yYl9wj7iIv4NuuA==", null, false, "ff2545e7-afa5-469c-bb9a-ad99258cfef7", false, "regular" },
                    { "9a18b49c-4d61-4d2b-8c35-ea7c36c21622", 0, "4b047164-33a8-4fab-81ef-faa3201a6379", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "moderator@moderator.pl", false, false, null, "MODERATOR@MODERATOR.PL", "MODERATOR", "AQAAAAIAAYagAAAAEPHl/McMuuO1wry+BEnFKd6ij20q5FW7BFJEQ9nWT79lrHxS3uKqzW3qrD0rOioidg==", null, false, "6a4a1a19-78bb-4782-b240-bc4ae1b1c5e2", false, "moderator" },
                    { "e8fde6f7-2405-4fd2-bb64-51f51945e4c3", 0, "001d49e1-e3e8-4cd9-ae8a-04d435170246", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.pl", false, false, null, "ADMIN@ADMIN.PL", "ADMIN", "AQAAAAIAAYagAAAAENSudBPbBC4T/qsouskR69oC6zqPqOnXmF6dnlu03XunqEExphWzxvD6oN8MCqUrDg==", null, false, "d7eb2ff4-1a77-42ed-baf8-4680f06605d6", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "96827cbf-86eb-4f1b-8560-b11b64455570", "31230d16-6f5e-4513-b287-35a630cde420" },
                    { "be236bd2-ca25-48ae-a320-dc7d4ff99fed", "9a18b49c-4d61-4d2b-8c35-ea7c36c21622" },
                    { "fa57b9a0-1fc5-4261-88e4-96929a293a08", "e8fde6f7-2405-4fd2-bb64-51f51945e4c3" }
                });
        }
    }
}
