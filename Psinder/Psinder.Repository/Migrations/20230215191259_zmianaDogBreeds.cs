using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Psinder.Repository.Migrations
{
    /// <inheritdoc />
    public partial class zmianaDogBreeds : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogBreeds_DogBreedsId",
                table: "Dogs");

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

            migrationBuilder.AlterColumn<int>(
                name: "DogBreedsId",
                table: "Dogs",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.AddColumn<string>(
                name: "DogBreeds",
                table: "Dogs",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "28be6f96-93ee-4a1c-b16d-fad06f2736c2", null, "IdentityRole", "Admin", "ADMIN" },
                    { "a52dab56-d8d7-4ee8-a87a-1707c240130f", null, "IdentityRole", "Moderator", "MODERATOR" },
                    { "c371524f-afdf-428c-97d9-5c5283d2d9a1", null, "IdentityRole", "RegularUser", "REGULARUSER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "5d360276-b4a2-458d-86ef-49e6938fc8db", 0, "b40dd549-febf-43ca-9d17-2787d97f04e1", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.pl", false, false, null, "ADMIN@ADMIN.PL", "ADMIN", "AQAAAAIAAYagAAAAEM/eRu3Tt5RYjBKazFbZWJhRMuZEpiUf01aYWkWMIyZlK1WXACcZkaCViqOIaL+8QQ==", null, false, "9322ab59-830b-4d6f-88b0-7f6e3713cd3e", false, "admin" },
                    { "657c207c-8564-4671-94ac-0fc76aa29bd9", 0, "3ecba50e-8cfa-430b-b396-630dc6ff1a5e", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "regular@regular.pl", false, false, null, "REGULAR@REGULAR.PL", "REGULAR", "AQAAAAIAAYagAAAAELdpIdSv6n0CVeaimCPo1qc6NYCuyFEFzw+vsh9iV7Zv6VRtxaW0DTH9aJk/uVAofQ==", null, false, "bc023890-877d-46ae-b6a3-9d562b6141a2", false, "regular" },
                    { "70f48c21-a14d-4826-86bf-1663f85d3edd", 0, "c4fae9c4-6ea0-4297-bab2-968b4298bbde", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "moderator@moderator.pl", false, false, null, "MODERATOR@MODERATOR.PL", "MODERATOR", "AQAAAAIAAYagAAAAELK7XvIuIqo8cNOO2gUNWrkG5mD/Hdb+CuweTTd+Ap+SlFWbmKGlI5x9B9O/18G8aw==", null, false, "8db56c2e-9505-4ba3-b6d6-38f487a7e0bd", false, "moderator" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "28be6f96-93ee-4a1c-b16d-fad06f2736c2", "5d360276-b4a2-458d-86ef-49e6938fc8db" },
                    { "c371524f-afdf-428c-97d9-5c5283d2d9a1", "657c207c-8564-4671-94ac-0fc76aa29bd9" },
                    { "a52dab56-d8d7-4ee8-a87a-1707c240130f", "70f48c21-a14d-4826-86bf-1663f85d3edd" }
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogBreeds_DogBreedsId",
                table: "Dogs",
                column: "DogBreedsId",
                principalTable: "DogBreeds",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogBreeds_DogBreedsId",
                table: "Dogs");

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "28be6f96-93ee-4a1c-b16d-fad06f2736c2", "5d360276-b4a2-458d-86ef-49e6938fc8db" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c371524f-afdf-428c-97d9-5c5283d2d9a1", "657c207c-8564-4671-94ac-0fc76aa29bd9" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "a52dab56-d8d7-4ee8-a87a-1707c240130f", "70f48c21-a14d-4826-86bf-1663f85d3edd" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "28be6f96-93ee-4a1c-b16d-fad06f2736c2");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "a52dab56-d8d7-4ee8-a87a-1707c240130f");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c371524f-afdf-428c-97d9-5c5283d2d9a1");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "5d360276-b4a2-458d-86ef-49e6938fc8db");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "657c207c-8564-4671-94ac-0fc76aa29bd9");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "70f48c21-a14d-4826-86bf-1663f85d3edd");

            migrationBuilder.DropColumn(
                name: "DogBreeds",
                table: "Dogs");

            migrationBuilder.AlterColumn<int>(
                name: "DogBreedsId",
                table: "Dogs",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

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

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogBreeds_DogBreedsId",
                table: "Dogs",
                column: "DogBreedsId",
                principalTable: "DogBreeds",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
