using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Project.Infrastructure.Migrations
{
    /// <inheritdoc />
    public partial class UpdateUserSeedTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "PK_USERID",
                keyValue: new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9e"),
                column: "TX_PASSWORD",
                value: "$2a$11$Lou0gILEi6v.gt9XPQB/SeE4i/SFupDtG7CrvPs3qNCd0/tYvMphq");

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "PK_USERID",
                keyValue: new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9f"),
                column: "TX_PASSWORD",
                value: "$2a$11$.LPnTmEvoWFum1fwI2JwZOBCKbM8pc5oyMSAyRgQN7b2X4/U10Voy");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "PK_USERID",
                keyValue: new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9e"),
                column: "TX_PASSWORD",
                value: "$2a$11$FAGRvw5TQ1yt0PwXJbJ31eXvWcIrIJNWieZGgY/vHd58ANoRWirjO");

            migrationBuilder.UpdateData(
                table: "T_USER",
                keyColumn: "PK_USERID",
                keyValue: new Guid("f7d4d7a9-4d1e-4a8d-9a8e-9b9a9b9a9b9f"),
                column: "TX_PASSWORD",
                value: "$2a$11$tLsQbsGQTQN1jqlLEo3AL.38YzEauS5TwCViu1hfP9FPCmzH/aaL2");
        }
    }
}
