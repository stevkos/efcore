using Microsoft.EntityFrameworkCore.Migrations;

namespace BankIS_MVC.Migrations
{
    public partial class index : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateIndex(
                name: "IX_Clients_LastName",
                table: "Clients",
                column: "LastName");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Clients_LastName",
                table: "Clients");
        }
    }
}
