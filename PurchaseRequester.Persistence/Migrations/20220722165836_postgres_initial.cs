using System;
using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using PurchaseRequester.Domain.Requests;

#nullable disable

namespace PurchaseRequester.Persistence.Migrations
{
    public partial class postgres_initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("Npgsql:Enum:request_catagory", "misc,tooling,floor_supplies,office_supplies,engineering,production,ppap")
                .Annotation("Npgsql:Enum:request_status", "new,pending,completed");

            migrationBuilder.CreateTable(
                name: "Requests",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    PartNo = table.Column<string>(type: "text", nullable: true),
                    ModelNo = table.Column<string>(type: "text", nullable: true),
                    UsedOn = table.Column<string>(type: "text", nullable: true),
                    Description = table.Column<string>(type: "text", nullable: true),
                    Quantity = table.Column<double>(type: "double precision", nullable: false),
                    LeadTime = table.Column<string>(type: "text", nullable: true),
                    Issuer = table.Column<int>(type: "integer", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "timestamp with time zone", nullable: false),
                    Catagory = table.Column<RequestCatagory>(type: "request_catagory", nullable: false),
                    Status = table.Column<RequestStatus>(type: "request_status", nullable: false),
                    isEmergency = table.Column<bool>(type: "boolean", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Requests", x => x.Id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Requests");
        }
    }
}
