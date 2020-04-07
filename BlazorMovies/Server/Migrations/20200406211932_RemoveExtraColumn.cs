using Microsoft.EntityFrameworkCore.Migrations;

namespace BlazorMovies.Server.Migrations
{
    public partial class RemoveExtraColumn : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoviesGenres_Genres_GenreId",
                table: "MoviesGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesGenres_Movies_MovieId",
                table: "MoviesGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoviesGenres",
                table: "MoviesGenres");

            migrationBuilder.DropIndex(
                name: "IX_MoviesGenres_MovieId",
                table: "MoviesGenres");

            migrationBuilder.DropColumn(
                name: "MoviesId",
                table: "MoviesGenres");

            migrationBuilder.DropColumn(
                name: "GenresId",
                table: "MoviesGenres");

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MoviesGenres",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "MoviesGenres",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoviesGenres",
                table: "MoviesGenres",
                columns: new[] { "MovieId", "GenreId" });

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesGenres_Genres_GenreId",
                table: "MoviesGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesGenres_Movies_MovieId",
                table: "MoviesGenres",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_MoviesGenres_Genres_GenreId",
                table: "MoviesGenres");

            migrationBuilder.DropForeignKey(
                name: "FK_MoviesGenres_Movies_MovieId",
                table: "MoviesGenres");

            migrationBuilder.DropPrimaryKey(
                name: "PK_MoviesGenres",
                table: "MoviesGenres");

            migrationBuilder.AlterColumn<int>(
                name: "GenreId",
                table: "MoviesGenres",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AlterColumn<int>(
                name: "MovieId",
                table: "MoviesGenres",
                type: "int",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddColumn<int>(
                name: "MoviesId",
                table: "MoviesGenres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GenresId",
                table: "MoviesGenres",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_MoviesGenres",
                table: "MoviesGenres",
                columns: new[] { "MoviesId", "GenresId" });

            migrationBuilder.CreateIndex(
                name: "IX_MoviesGenres_MovieId",
                table: "MoviesGenres",
                column: "MovieId");

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesGenres_Genres_GenreId",
                table: "MoviesGenres",
                column: "GenreId",
                principalTable: "Genres",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MoviesGenres_Movies_MovieId",
                table: "MoviesGenres",
                column: "MovieId",
                principalTable: "Movies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
