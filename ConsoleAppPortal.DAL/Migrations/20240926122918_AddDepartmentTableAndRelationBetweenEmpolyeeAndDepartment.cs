using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppPortal.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentTableAndRelationBetweenEmpolyeeAndDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Empolyees",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<int>(
                name: "DeptId",
                table: "Empolyees",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Email",
                table: "Empolyees",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DeptId",
                table: "Empolyees");

            migrationBuilder.DropColumn(
                name: "Email",
                table: "Empolyees");

            migrationBuilder.AlterColumn<string>(
                name: "Name",
                table: "Empolyees",
                type: "nvarchar(max)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200);
        }
    }
}
