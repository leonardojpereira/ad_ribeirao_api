using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace Project.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class AddUserAndRoleTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "T_ROLE",
                columns: table => new
                {
                    PK_ROLEID = table.Column<Guid>(type: "uuid", nullable: false),
                    DT_CREATEDAT = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DT_UPDATEDAT = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FL_DELETED = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false),
                    TX_NAME = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_ROLE", x => x.PK_ROLEID);
                });

            migrationBuilder.CreateTable(
                name: "T_USER",
                columns: table => new
                {
                    PK_USERID = table.Column<Guid>(type: "uuid", nullable: false),
                    TX_USERNAME = table.Column<string>(type: "text", nullable: false),
                    TX_PASSWORD = table.Column<string>(type: "text", nullable: false),
                    TX_EMAIL = table.Column<string>(type: "text", nullable: false),
                    FK_ROLEID = table.Column<Guid>(type: "uuid", nullable: false),
                    DT_CREATEDAT = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    DT_UPDATEDAT = table.Column<DateTime>(type: "timestamp with time zone", nullable: true),
                    FL_DELETED = table.Column<bool>(type: "boolean", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_T_USER", x => x.PK_USERID);
                    table.ForeignKey(
                        name: "FK_USER_ROLE",
                        column: x => x.FK_ROLEID,
                        principalTable: "T_ROLE",
                        principalColumn: "PK_ROLEID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "T_ROLE",
                columns: new[] { "PK_ROLEID", "DT_CREATEDAT", "TX_NAME", "DT_UPDATEDAT" },
                values: new object[,]
                {
                    { new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9a"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Admin", null },
                    { new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9b"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "User", null }
                });

            migrationBuilder.InsertData(
                table: "T_USER",
                columns: new[] { "PK_USERID", "DT_CREATEDAT", "TX_EMAIL", "TX_PASSWORD", "FK_ROLEID", "DT_UPDATEDAT", "TX_USERNAME" },
                values: new object[,]
                {
                    { new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9e"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@admin.com", "$2a$11$4Jj/yZtDOfJxj4IAj.Mck.QdcpMzXZKwwUCAbm.qrNqiryTIbSfRi", new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9a"), null, "admin" },
                    { new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9f"), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@user.com", "$2a$11$j43PZSVEfTpVuM5nnKqWheDkDSNfKU0XEFVyUg8VsMEBCNVh910Ie", new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9b"), null, "user" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_T_USER_FK_ROLEID",
                table: "T_USER",
                column: "FK_ROLEID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "T_USER");

            migrationBuilder.DropTable(
                name: "T_ROLE");
        }
    }
}
