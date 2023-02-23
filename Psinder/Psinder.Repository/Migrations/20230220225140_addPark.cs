using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Psinder.Repository.Migrations
{
    /// <inheritdoc />
    public partial class addPark : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
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

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Discriminator", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "039b5b44-da40-409b-9f06-78a5d5c81cba", null, "IdentityRole", "Admin", "ADMIN" },
                    { "17aa6123-2342-4ea7-bc57-c9ead9b92ab3", null, "IdentityRole", "RegularUser", "REGULARUSER" },
                    { "f36d0978-2689-4297-a278-836c3c7488c4", null, "IdentityRole", "Moderator", "MODERATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "0c12c4bb-0459-4284-a09b-ec81508ff9e4", 0, "24f4d034-035a-4ecd-888b-5b714f644028", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.pl", false, false, null, "ADMIN@ADMIN.PL", "ADMIN", "AQAAAAIAAYagAAAAEMYNHpv34eBPljNmPWkcV4gHu4TpR86ybQQEizRKMQcVnie4+4C1x61fUnntsnhmtA==", null, false, "f1278735-51ec-474a-ae90-b1be5546c0a2", false, "admin" },
                    { "a519c692-1b67-495b-ae6d-92a76008f712", 0, "9de97126-4ba7-4833-9fdc-b76efb36eb04", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "moderator@moderator.pl", false, false, null, "MODERATOR@MODERATOR.PL", "MODERATOR", "AQAAAAIAAYagAAAAEFE9G+H1Jr9T4k2uKuN+Ksvs27n4WfROEBpe8nMNXwRcyKYb2srFPuX+5z1m0afjCg==", null, false, "8db157a8-9f11-467f-93b4-9e889cbe707d", false, "moderator" },
                    { "ae46984a-e210-45a9-b5fb-00fe39918c21", 0, "452d611b-6a50-4358-a130-a4b4cc934791", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "regular@regular.pl", false, false, null, "REGULAR@REGULAR.PL", "REGULAR", "AQAAAAIAAYagAAAAECMORzvEmD//licdYavwj480ziYGVfiLh6GAZm3xDQOIa2iyY4NdG5i4oEZlSg39NA==", null, false, "8349b5f0-2c42-40ba-9e3a-e2486beb9f4c", false, "regular" }
                });

            migrationBuilder.InsertData(
                table: "Parks",
                columns: new[] { "Id", "City", "Country", "NamePark", "PostalCode", "Street" },
                values: new object[,]
                {
                    { 2, "Kraków", "Polska", "Krakowski Park", "32-000", "Mogilska 2" },
                    { 3, "Kraków", "Polska", "Lubostroń", "00-000", "Karlemicka 22" },
                    { 4, "Kraków", "Polska", "Nowa Huta", "11-544", "Nowohucka 2" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "039b5b44-da40-409b-9f06-78a5d5c81cba", "0c12c4bb-0459-4284-a09b-ec81508ff9e4" },
                    { "f36d0978-2689-4297-a278-836c3c7488c4", "a519c692-1b67-495b-ae6d-92a76008f712" },
                    { "17aa6123-2342-4ea7-bc57-c9ead9b92ab3", "ae46984a-e210-45a9-b5fb-00fe39918c21" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "039b5b44-da40-409b-9f06-78a5d5c81cba", "0c12c4bb-0459-4284-a09b-ec81508ff9e4" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "f36d0978-2689-4297-a278-836c3c7488c4", "a519c692-1b67-495b-ae6d-92a76008f712" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "17aa6123-2342-4ea7-bc57-c9ead9b92ab3", "ae46984a-e210-45a9-b5fb-00fe39918c21" });

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Parks",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "039b5b44-da40-409b-9f06-78a5d5c81cba");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "17aa6123-2342-4ea7-bc57-c9ead9b92ab3");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "f36d0978-2689-4297-a278-836c3c7488c4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "0c12c4bb-0459-4284-a09b-ec81508ff9e4");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "a519c692-1b67-495b-ae6d-92a76008f712");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "ae46984a-e210-45a9-b5fb-00fe39918c21");

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
    }
}
