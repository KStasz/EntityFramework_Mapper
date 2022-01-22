using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EntityFramework_Mapper.Migrations
{
    public partial class DefineRelations : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CarId",
                table: "Peoples",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Peoples_CarId",
                table: "Peoples",
                column: "CarId");

            migrationBuilder.AddForeignKey(
                name: "FK_Peoples_Cars_CarId",
                table: "Peoples",
                column: "CarId",
                principalTable: "Cars",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Peoples_Cars_CarId",
                table: "Peoples");

            migrationBuilder.DropIndex(
                name: "IX_Peoples_CarId",
                table: "Peoples");

            migrationBuilder.DropColumn(
                name: "CarId",
                table: "Peoples");
        }
    }
}
