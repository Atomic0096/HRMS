using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace HRMS.Migrations
{
    /// <inheritdoc />
    public partial class Fourth : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "ApplicationUserId",
                table: "Recruitment",
                type: "TEXT",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Recruitment_ApplicationUserId",
                table: "Recruitment",
                column: "ApplicationUserId");

            migrationBuilder.AddForeignKey(
                name: "FK_Recruitment_AspNetUsers_ApplicationUserId",
                table: "Recruitment",
                column: "ApplicationUserId",
                principalTable: "AspNetUsers",
                principalColumn: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Recruitment_AspNetUsers_ApplicationUserId",
                table: "Recruitment");

            migrationBuilder.DropIndex(
                name: "IX_Recruitment_ApplicationUserId",
                table: "Recruitment");

            migrationBuilder.DropColumn(
                name: "ApplicationUserId",
                table: "Recruitment");
        }
    }
}
