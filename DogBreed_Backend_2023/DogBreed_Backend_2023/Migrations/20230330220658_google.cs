using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogBreed_Backend_2023.Migrations
{
    public partial class google : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "GoogleUserId",
                table: "FavoriteBreeds",
                type: "int",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "GoogleUsers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProfileName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    GoogleId = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_GoogleUsers", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_FavoriteBreeds_GoogleUserId",
                table: "FavoriteBreeds",
                column: "GoogleUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_FavoriteBreeds_GoogleUsers_GoogleUserId",
                table: "FavoriteBreeds",
                column: "GoogleUserId",
                principalTable: "GoogleUsers",
                principalColumn: "Id");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_FavoriteBreeds_GoogleUsers_GoogleUserId",
                table: "FavoriteBreeds");

            migrationBuilder.DropTable(
                name: "GoogleUsers");

            migrationBuilder.DropIndex(
                name: "IX_FavoriteBreeds_GoogleUserId",
                table: "FavoriteBreeds");

            migrationBuilder.DropColumn(
                name: "GoogleUserId",
                table: "FavoriteBreeds");
        }
    }
}
