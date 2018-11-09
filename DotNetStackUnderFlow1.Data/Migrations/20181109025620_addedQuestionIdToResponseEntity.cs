using Microsoft.EntityFrameworkCore.Migrations;

namespace DotNetStackUnderFlow1.Data.Migrations
{
    public partial class addedQuestionIdToResponseEntity : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuestionId",
                table: "Responses",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "QuestionId",
                table: "Responses");
        }
    }
}
