using Microsoft.EntityFrameworkCore.Migrations;

namespace Etickets_.Migrations
{
    public partial class ModDB1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_producerId",
                table: "Movies");

            migrationBuilder.RenameColumn(
                name: "producerId",
                table: "Movies",
                newName: "ProducerId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_producerId",
                table: "Movies",
                newName: "IX_Movies_ProducerId");

            migrationBuilder.AddColumn<int>(
                name: "MovieId1",
                table: "Actors_Movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Actors_Movies_MovieId1",
                table: "Actors_Movies",
                column: "MovieId1");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId1",
                table: "Actors_Movies",
                column: "MovieId1",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies",
                column: "ProducerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_Movies_MovieId1",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_Movies_Producers_ProducerId",
                table: "Movies");

            migrationBuilder.DropIndex(
                name: "IX_Actors_Movies_MovieId1",
                table: "Actors_Movies");

            migrationBuilder.DropColumn(
                name: "MovieId1",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "ProducerId",
                table: "Movies",
                newName: "producerId");

            migrationBuilder.RenameIndex(
                name: "IX_Movies_ProducerId",
                table: "Movies",
                newName: "IX_Movies_producerId");

            migrationBuilder.AddForeignKey(
                name: "FK_Movies_Producers_producerId",
                table: "Movies",
                column: "producerId",
                principalTable: "Producers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
