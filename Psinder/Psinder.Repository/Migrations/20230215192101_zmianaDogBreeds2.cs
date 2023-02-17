using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Psinder.Repository.Migrations
{
    /// <inheritdoc />
    public partial class zmianaDogBreeds2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dogs_DogBreeds_DogBreedsId",
                table: "Dogs");

            migrationBuilder.DropIndex(
                name: "IX_Dogs_DogBreedsId",
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
                name: "DogBreedsId",
                table: "Dogs");

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "26bee6ac-09de-4046-a52c-67ba1f44d1f6", null, "IdentityRole", "Moderator", "MODERATOR" },
                    { "583a1659-b98b-4297-a0ed-00f1c48c8d59", null, "IdentityRole", "Admin", "ADMIN" },
                    { "c1fce7f9-b7bc-4550-bd92-dfa460b50b72", null, "IdentityRole", "RegularUser", "REGULARUSER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "080d6805-fd50-4dce-bc26-be8346a9712c", 0, "07784db4-5fd6-4046-bf4c-c2231ccd5696", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "moderator@moderator.pl", false, false, null, "MODERATOR@MODERATOR.PL", "MODERATOR", "AQAAAAIAAYagAAAAEAI6RyhhIi9iwpbzy408CGKXiYlPbFMbaFvi6nanozkM4IFVUXFJSqhaVkhWjSaMiQ==", null, false, "9aea18e8-a835-4a82-a42d-c72ce2393cc4", false, "moderator" },
                    { "844f59c8-8b04-45e4-bc24-3b4fafc57afb", 0, "df1bbf1c-c153-42c8-b29f-2be591688496", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "regular@regular.pl", false, false, null, "REGULAR@REGULAR.PL", "REGULAR", "AQAAAAIAAYagAAAAEG/aztJQdCNCO7IHkmTQywazqE3caXz5HkE9tFPx/mYd30Wt3FYO9e3upiw7KSIVyA==", null, false, "43e0214b-1740-4d49-94c0-13f8a69d8d03", false, "regular" },
                    { "f931c504-3e37-47cc-8fef-eafc3cea363f", 0, "9a5032c2-00be-463e-86a0-5c7d400e8496", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.pl", false, false, null, "ADMIN@ADMIN.PL", "ADMIN", "AQAAAAIAAYagAAAAEDbmVxzgrnf7a9uVutAer994Q9qn1p4KOTrEW6/osIAJxy8gjvLM3aY9kDGuWEXv4w==", null, false, "e383f1ee-2c73-40f4-bf62-8be88f154d43", false, "admin" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "26bee6ac-09de-4046-a52c-67ba1f44d1f6", "080d6805-fd50-4dce-bc26-be8346a9712c" },
                    { "c1fce7f9-b7bc-4550-bd92-dfa460b50b72", "844f59c8-8b04-45e4-bc24-3b4fafc57afb" },
                    { "583a1659-b98b-4297-a0ed-00f1c48c8d59", "f931c504-3e37-47cc-8fef-eafc3cea363f" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "26bee6ac-09de-4046-a52c-67ba1f44d1f6", "080d6805-fd50-4dce-bc26-be8346a9712c" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "c1fce7f9-b7bc-4550-bd92-dfa460b50b72", "844f59c8-8b04-45e4-bc24-3b4fafc57afb" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "583a1659-b98b-4297-a0ed-00f1c48c8d59", "f931c504-3e37-47cc-8fef-eafc3cea363f" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "26bee6ac-09de-4046-a52c-67ba1f44d1f6");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "583a1659-b98b-4297-a0ed-00f1c48c8d59");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "c1fce7f9-b7bc-4550-bd92-dfa460b50b72");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "080d6805-fd50-4dce-bc26-be8346a9712c");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "844f59c8-8b04-45e4-bc24-3b4fafc57afb");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "f931c504-3e37-47cc-8fef-eafc3cea363f");

            migrationBuilder.AddColumn<int>(
                name: "DogBreedsId",
                table: "Dogs",
                type: "int",
                nullable: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_Dogs_DogBreedsId",
                table: "Dogs",
                column: "DogBreedsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dogs_DogBreeds_DogBreedsId",
                table: "Dogs",
                column: "DogBreedsId",
                principalTable: "DogBreeds",
                principalColumn: "Id");
        }
    }
}
