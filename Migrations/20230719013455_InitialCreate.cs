using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RelacionamentosEF.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 19, 1, 34, 55, 806, DateTimeKind.Utc).AddTicks(5441),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2023, 7, 19, 1, 29, 3, 873, DateTimeKind.Utc).AddTicks(9865));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "LastUpdateDate",
                table: "Post",
                type: "SMALLDATETIME",
                nullable: false,
                defaultValue: new DateTime(2023, 7, 19, 1, 29, 3, 873, DateTimeKind.Utc).AddTicks(9865),
                oldClrType: typeof(DateTime),
                oldType: "SMALLDATETIME",
                oldDefaultValue: new DateTime(2023, 7, 19, 1, 34, 55, 806, DateTimeKind.Utc).AddTicks(5441));
        }
    }
}
