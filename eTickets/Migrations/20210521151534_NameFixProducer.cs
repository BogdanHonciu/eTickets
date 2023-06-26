using Microsoft.EntityFrameworkCore.Migrations;

namespace eFarm.Migrations
{
    public partial class NameFixProducer : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Prducers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Prducers",
                table: "Prducers");

            migrationBuilder.RenameTable(
                name: "Prducers",
                newName: "Couriers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Producers",
                table: "Couriers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Couriers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Producers",
                table: "Couriers");

            migrationBuilder.RenameTable(
                name: "Couriers",
                newName: "Prducers");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Prducers",
                table: "Prducers",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Prducers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Prducers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
