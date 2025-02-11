using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserTableWithImageProfile : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "TX_PROFILEIMAGE",
                table: "T_USER",
                type: "text",
                nullable: true);

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "PK_USERID",
                keyValue: new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9e"),
                columns: new[] { "TX_PASSWORD", "TX_PROFILEIMAGE" },
                values: new object[] { "$2a$11$FAGRvw5TQ1yt0PwXJbJ31eXvWcIrIJNWieZGgY/vHd58ANoRWirjO", null });

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "PK_USERID",
                keyValue: new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9f"),
                columns: new[] { "TX_PASSWORD", "TX_PROFILEIMAGE" },
                values: new object[] { "$2a$11$tLsQbsGQTQN1jqlLEo3AL.38YzEauS5TwCViu1hfP9FPCmzH/aaL2", null });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TX_PROFILEIMAGE",
                table: "T_USER");

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "PK_USERID",
                keyValue: new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9e"),
                column: "TX_PASSWORD",
                value: "$2a$11$4Jj/yZtDOfJxj4IAj.Mck.QdcpMzXZKwwUCAbm.qrNqiryTIbSfRi");

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "PK_USERID",
                keyValue: new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9f"),
                column: "TX_PASSWORD",
                value: "$2a$11$j43PZSVEfTpVuM5nnKqWheDkDSNfKU0XEFVyUg8VsMEBCNVh910Ie");
        }
    }
}
