using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleAppPortal.DAL.Migrations
{
    /// <inheritdoc />
    public partial class AddDepartmentTableAndRelationEmpolyeeAndDepartment : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Departmentid",
                table: "Empolyees",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Deapartment",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Deapartment", x => x.id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Empolyees_Departmentid",
                table: "Empolyees",
                column: "Departmentid");

            migrationBuilder.AddForeignKey(
                name: "FK_Empolyees_Deapartment_Departmentid",
                table: "Empolyees",
                column: "Departmentid",
                principalTable: "Deapartment",
                principalColumn: "id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Empolyees_Deapartment_Departmentid",
                table: "Empolyees");

            migrationBuilder.DropTable(
                name: "Deapartment");

            migrationBuilder.DropIndex(
                name: "IX_Empolyees_Departmentid",
                table: "Empolyees");

            migrationBuilder.DropColumn(
                name: "Departmentid",
                table: "Empolyees");
        }
    }
}
