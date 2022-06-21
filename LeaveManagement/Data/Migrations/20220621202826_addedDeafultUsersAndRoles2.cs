using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class addedDeafultUsersAndRoles2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d39cc8e-771d-47e8-2117-b5fc36f048cc",
                column: "ConcurrencyStamp",
                value: "976c88ca-6be3-4411-9023-5299d763db56");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d39cc8e-441d-47e8-3221-b5fc36f048cc",
                column: "ConcurrencyStamp",
                value: "3ac243d4-8efc-4956-a842-893f3788a493");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d39cc8e-111d-47e8-1117-b5fc36f048cc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "75ee446f-1989-4ec8-a441-61aa8f1b0859", true, "ADMIN@LOCALHOT.COM", "AQAAAAEAACcQAAAAEGzMgDF6gHkhAbML0gf9AZD+Lb1yyLTX8DlpA+lo5kCU8IEBBmZXKxuLSQlEnF7kZQ==", "a9d30c90-c5e2-44b5-b92d-a215d9915e9d", "admin@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d39cc8e-222b-47e8-2227-b5fc36f048cc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "21d3b4f1-8b01-4644-b8f2-e4d27da976dd", true, "USER@LOCALHOT.COM", "AQAAAAEAACcQAAAAELMl7zHcR4Ddnz72DkO4dmw8SZRABmroZwa4YOGh3ODunRRajdKiJNQmrKwW+WLBpQ==", "8af62e11-d286-4f42-ba6f-e0a1b0fac923", "user@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "8d39cc8e-771d-47e8-2117-b5fc36f048cc",
                column: "ConcurrencyStamp",
                value: "7db7d152-937b-4c5c-a186-aa16ee693dfa");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "9d39cc8e-441d-47e8-3221-b5fc36f048cc",
                column: "ConcurrencyStamp",
                value: "50dab54f-30b0-44cc-b293-30e939f884e3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "1d39cc8e-111d-47e8-1117-b5fc36f048cc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "f3843fbd-39c3-4522-9c27-83a156626a35", false, null, "AQAAAAEAACcQAAAAEOUPCFAQbiP0aF+K3DLOt544uXyYrahkCHmfQ7rirlkmw/OKXb6YgAVo03es6XkkmA==", "17cd7df4-b25b-4eba-9f26-73beaf85e52d", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "2d39cc8e-222b-47e8-2227-b5fc36f048cc",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "dd1552d2-c946-472e-8819-50ba35bb304d", false, null, "AQAAAAEAACcQAAAAEDdG3A8LwTdhSe1Y6X2AqIxRBaj1i+BJ7rs9Noi4p90u0EbpnkPfaCfVtTq4QHJ0TQ==", "d57f32da-06da-43ed-a960-efe0a9c59512", null });
        }
    }
}
