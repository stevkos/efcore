using Microsoft.EntityFrameworkCore.Migrations;

namespace BankIS_MVC.Migrations
{
    public partial class Transactionsadd : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Clients_ClientId",
                table: "Transactions");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Transactions",
                nullable: false,
                oldClrType: typeof(int),
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Clients_ClientId",
                table: "Transactions",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Transactions_Clients_ClientId",
                table: "Transactions");

            migrationBuilder.AlterColumn<int>(
                name: "ClientId",
                table: "Transactions",
                nullable: true,
                oldClrType: typeof(int));

            migrationBuilder.AddForeignKey(
                name: "FK_Transactions_Clients_ClientId",
                table: "Transactions",
                column: "ClientId",
                principalTable: "Clients",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
