using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class addedDeafultUsersAndRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "8d39cc8e-771d-47e8-2117-b5fc36f048cc", "7db7d152-937b-4c5c-a186-aa16ee693dfa", "Admin", "ADMIN" },
                    { "9d39cc8e-441d-47e8-3221-b5fc36f048cc", "50dab54f-30b0-44cc-b293-30e939f884e3", "user", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateOfBirth", "DateOfJoined", "Email", "EmailConfirmed", "FirstName", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "1d39cc8e-111d-47e8-1117-b5fc36f048cc", 0, "f3843fbd-39c3-4522-9c27-83a156626a35", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOT.COM", null, "AQAAAAEAACcQAAAAEOUPCFAQbiP0aF+K3DLOt544uXyYrahkCHmfQ7rirlkmw/OKXb6YgAVo03es6XkkmA==", null, false, "17cd7df4-b25b-4eba-9f26-73beaf85e52d", null, false, null },
                    { "2d39cc8e-222b-47e8-2227-b5fc36f048cc", 0, "dd1552d2-c946-472e-8819-50ba35bb304d", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "Default", "User", false, null, "USER@LOCALHOT.COM", null, "AQAAAAEAACcQAAAAEDdG3A8LwTdhSe1Y6X2AqIxRBaj1i+BJ7rs9Noi4p90u0EbpnkPfaCfVtTq4QHJ0TQ==", null, false, "d57f32da-06da-43ed-a960-efe0a9c59512", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "8d39cc8e-771d-47e8-2117-b5fc36f048cc", "1d39cc8e-111d-47e8-1117-b5fc36f048cc" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "9d39cc8e-441d-47e8-3221-b5fc36f048cc", "2d39cc8e-222b-47e8-2227-b5fc36f048cc" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "8d39cc8e-771d-47e8-2117-b5fc36f048cc", "1d39cc8e-111d-47e8-1117-b5fc36f048cc" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "9d39cc8e-441d-47e8-3221-b5fc36f048cc", "2d39cc8e-222b-47e8-2227-b5fc36f048cc" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d39cc8e-771d-47e8-2117-b5fc36f048cc");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d39cc8e-441d-47e8-3221-b5fc36f048cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d39cc8e-111d-47e8-1117-b5fc36f048cc");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d39cc8e-222b-47e8-2227-b5fc36f048cc");
        }
    }
}
