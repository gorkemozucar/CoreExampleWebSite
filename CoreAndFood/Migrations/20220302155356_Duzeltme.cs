using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreAndFood.Migrations
{
    public partial class Duzeltme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryID",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "CategoryID",
                table: "Foods",
                newName: "CategoryId");

            migrationBuilder.RenameIndex(
                name: "IX_Foods_CategoryID",
                table: "Foods",
                newName: "IX_Foods_CategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods",
                column: "CategoryId",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Foods_Categories_CategoryId",
                table: "Foods");

            migrationBuilder.RenameColumn(
                name: "CategoryId",
                table: "Foods",
                newName: "CategoryID");

            migrationBuilder.RenameIndex(
                name: "IX_Foods_CategoryId",
                table: "Foods",
                newName: "IX_Foods_CategoryID");

            migrationBuilder.AddForeignKey(
                name: "FK_Foods_Categories_CategoryID",
                table: "Foods",
                column: "CategoryID",
                principalTable: "Categories",
                principalColumn: "CategoryId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
