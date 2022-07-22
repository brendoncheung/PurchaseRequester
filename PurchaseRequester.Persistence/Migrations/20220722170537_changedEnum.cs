using Microsoft.EntityFrameworkCore.Migrations;
using PurchaseRequester.Domain.Requests;

#nullable disable

namespace PurchaseRequester.Persistence.Migrations
{
    public partial class changedEnum : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Status",
                table: "Requests",
                type: "text",
                nullable: false,
                oldClrType: typeof(RequestStatus),
                oldType: "request_status");

            migrationBuilder.AlterColumn<string>(
                name: "Catagory",
                table: "Requests",
                type: "text",
                nullable: false,
                oldClrType: typeof(RequestCatagory),
                oldType: "request_catagory");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<RequestStatus>(
                name: "Status",
                table: "Requests",
                type: "request_status",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");

            migrationBuilder.AlterColumn<RequestCatagory>(
                name: "Catagory",
                table: "Requests",
                type: "request_catagory",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "text");
        }
    }
}
