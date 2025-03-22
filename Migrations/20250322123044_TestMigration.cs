using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorApp3.Migrations
{
    /// <inheritdoc />
    public partial class TestMigration : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_QuestionModel_Tests_TestModelId",
                table: "QuestionModel");

            migrationBuilder.DropPrimaryKey(
                name: "PK_QuestionModel",
                table: "QuestionModel");

            migrationBuilder.DropColumn(
                name: "QuestionModelId",
                table: "Tests");

            migrationBuilder.RenameTable(
                name: "QuestionModel",
                newName: "Questions");

            migrationBuilder.RenameIndex(
                name: "IX_QuestionModel_TestModelId",
                table: "Questions",
                newName: "IX_Questions_TestModelId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Questions",
                table: "Questions",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Questions_Tests_TestModelId",
                table: "Questions",
                column: "TestModelId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Questions_Tests_TestModelId",
                table: "Questions");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Questions",
                table: "Questions");

            migrationBuilder.RenameTable(
                name: "Questions",
                newName: "QuestionModel");

            migrationBuilder.RenameIndex(
                name: "IX_Questions_TestModelId",
                table: "QuestionModel",
                newName: "IX_QuestionModel_TestModelId");

            migrationBuilder.AddColumn<int>(
                name: "QuestionModelId",
                table: "Tests",
                type: "INTEGER",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_QuestionModel",
                table: "QuestionModel",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_QuestionModel_Tests_TestModelId",
                table: "QuestionModel",
                column: "TestModelId",
                principalTable: "Tests",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
