using Microsoft.EntityFrameworkCore.Migrations;

namespace Etickets_.Migrations
{
    public partial class Fixed : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_movies_movieId",
                table: "Actors_Movies");

            migrationBuilder.RenameColumn(
                name: "profilepiciture",
                table: "producers",
                newName: "profilepicitureurl");

            migrationBuilder.RenameColumn(
                name: "StertDate",
                table: "movies",
                newName: "StartDate");

            migrationBuilder.RenameColumn(
                name: "Describtion",
                table: "movies",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "Describtion",
                table: "cinemas",
                newName: "Description");

            migrationBuilder.RenameColumn(
                name: "movieId",
                table: "Actors_Movies",
                newName: "MovieId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_movieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_MovieId");

            migrationBuilder.RenameColumn(
                name: "profilepiciture",
                table: "Actors",
                newName: "profilepicitureurl");

            migrationBuilder.AddColumn<int>(
                name: "movecategoryId",
                table: "movies",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "Movecategory",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Movecategory", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_movies_movecategoryId",
                table: "movies",
                column: "movecategoryId");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_movies_MovieId",
                table: "Actors_Movies",
                column: "MovieId",
                principalTable: "movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_movies_Movecategory_movecategoryId",
                table: "movies",
                column: "movecategoryId",
                principalTable: "Movecategory",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Actors_Movies_movies_MovieId",
                table: "Actors_Movies");

            migrationBuilder.DropForeignKey(
                name: "FK_movies_Movecategory_movecategoryId",
                table: "movies");

            migrationBuilder.DropTable(
                name: "Movecategory");

            migrationBuilder.DropIndex(
                name: "IX_movies_movecategoryId",
                table: "movies");

            migrationBuilder.DropColumn(
                name: "movecategoryId",
                table: "movies");

            migrationBuilder.RenameColumn(
                name: "profilepicitureurl",
                table: "producers",
                newName: "profilepiciture");

            migrationBuilder.RenameColumn(
                name: "StartDate",
                table: "movies",
                newName: "StertDate");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "movies",
                newName: "Describtion");

            migrationBuilder.RenameColumn(
                name: "Description",
                table: "cinemas",
                newName: "Describtion");

            migrationBuilder.RenameColumn(
                name: "MovieId",
                table: "Actors_Movies",
                newName: "movieId");

            migrationBuilder.RenameIndex(
                name: "IX_Actors_Movies_MovieId",
                table: "Actors_Movies",
                newName: "IX_Actors_Movies_movieId");

            migrationBuilder.RenameColumn(
                name: "profilepicitureurl",
                table: "Actors",
                newName: "profilepiciture");

            migrationBuilder.AddForeignKey(
                name: "FK_Actors_Movies_movies_movieId",
                table: "Actors_Movies",
                column: "movieId",
                principalTable: "movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
