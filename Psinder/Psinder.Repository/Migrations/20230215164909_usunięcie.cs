using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Psinder.Repository.Migrations
{
    /// <inheritdoc />
    public partial class usunięcie : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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
                    { "21d1a525-9b2b-4a4d-bea9-c61881016ef0", null, "IdentityRole", "Admin", "ADMIN" },
                    { "bd9049ac-2fa7-4e0a-b672-86ba5bc5e677", null, "IdentityRole", "RegularUser", "REGULARUSER" },
                    { "ce4035a2-fe09-4919-b93c-161361374788", null, "IdentityRole", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "af9e1e58-41b7-47bc-90d2-249fab81b347", 0, "08eb996f-8caa-47f2-a21f-65c7d0e3be18", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "regular@regular.pl", false, false, null, "REGULAR@REGULAR.PL", "REGULAR", "AQAAAAIAAYagAAAAEOYNjvwVfCbXKihuMzHhThnt1fe4UEjmGmaDTYDFOsEukiadPhPtxRUmlcF4DBCUBg==", null, false, "7d1941c8-557f-4c4e-99da-77e4b0444066", false, "regular" },
                    { "b5f397da-41e4-4dc8-9fd3-c67382491d07", 0, "cbc5c73f-f959-4eef-bebb-5666a84e5df4", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.pl", false, false, null, "ADMIN@ADMIN.PL", "ADMIN", "AQAAAAIAAYagAAAAEMxs9IgWgq2C0YSTlu+4IqSLNJUcB9m6AsE++d6cU+592bAAMyDXb3065SLX+1Zj4Q==", null, false, "39f80e21-d3de-4e3c-a549-29a8061477b6", false, "admin" },
                    { "e8a1fed1-661d-49b5-ae53-13b054d09584", 0, "33bc3729-9a72-4d8b-af4b-16ff11703708", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "moderator@moderator.pl", false, false, null, "MODERATOR@MODERATOR.PL", "MODERATOR", "AQAAAAIAAYagAAAAEGo+uZdgRGz1LVlWUROrub0t43MK/XTbDKMXAJIvfEi4ErGjE2hvaQtbRHTiWkV6JQ==", null, false, "69d732a4-e165-4eb2-abf6-792272c22b4c", false, "moderator" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "bd9049ac-2fa7-4e0a-b672-86ba5bc5e677", "af9e1e58-41b7-47bc-90d2-249fab81b347" },
                    { "21d1a525-9b2b-4a4d-bea9-c61881016ef0", "b5f397da-41e4-4dc8-9fd3-c67382491d07" },
                    { "ce4035a2-fe09-4919-b93c-161361374788", "e8a1fed1-661d-49b5-ae53-13b054d09584" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "bd9049ac-2fa7-4e0a-b672-86ba5bc5e677", "af9e1e58-41b7-47bc-90d2-249fab81b347" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "21d1a525-9b2b-4a4d-bea9-c61881016ef0", "b5f397da-41e4-4dc8-9fd3-c67382491d07" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "ce4035a2-fe09-4919-b93c-161361374788", "e8a1fed1-661d-49b5-ae53-13b054d09584" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "21d1a525-9b2b-4a4d-bea9-c61881016ef0");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "bd9049ac-2fa7-4e0a-b672-86ba5bc5e677");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "ce4035a2-fe09-4919-b93c-161361374788");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "af9e1e58-41b7-47bc-90d2-249fab81b347");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "b5f397da-41e4-4dc8-9fd3-c67382491d07");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e8a1fed1-661d-49b5-ae53-13b054d09584");

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
    }
}
