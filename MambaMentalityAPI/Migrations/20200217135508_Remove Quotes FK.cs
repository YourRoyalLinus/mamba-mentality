using Microsoft.EntityFrameworkCore.Migrations;

namespace MambaMentalityAPI.Migrations
{
    public partial class RemoveQuotesFK : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Quotes_Quotes_QuoteId",
                table: "Quotes");

            migrationBuilder.DropIndex(
                name: "IX_Quotes_QuoteId",
                table: "Quotes");

            migrationBuilder.DropColumn(
                name: "QuoteId",
                table: "Quotes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "QuoteId",
                table: "Quotes",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Quotes_QuoteId",
                table: "Quotes",
                column: "QuoteId");

            migrationBuilder.AddForeignKey(
                name: "FK_Quotes_Quotes_QuoteId",
                table: "Quotes",
                column: "QuoteId",
                principalTable: "Quotes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
