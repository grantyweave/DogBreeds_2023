using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DogBreed_Backend_2023.Migrations
{
    public partial class userupdate2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserIcon",
                table: "Users",
                newName: "UserName");

            migrationBuilder.RenameColumn(
                name: "ProfileName",
                table: "Users",
                newName: "Password");

            migrationBuilder.RenameColumn(
                name: "GoogleId",
                table: "Users",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "UserName",
                table: "Users",
                newName: "UserIcon");

            migrationBuilder.RenameColumn(
                name: "Password",
                table: "Users",
                newName: "ProfileName");

            migrationBuilder.RenameColumn(
                name: "Email",
                table: "Users",
                newName: "GoogleId");
        }
    }
}
