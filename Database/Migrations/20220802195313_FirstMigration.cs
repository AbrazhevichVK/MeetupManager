using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Storage.Migrations
{
    public partial class FirstMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Meetups",
                columns: table => new
                {
                    MeetupId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(nullable: true),
                    Theme = table.Column<string>(nullable: true),
                    Description = table.Column<string>(nullable: true),
                    Plan = table.Column<string>(nullable: true),
                    Organizar = table.Column<string>(nullable: true),
                    Speaker = table.Column<string>(nullable: true),
                    MeetupTime = table.Column<DateTime>(nullable: false),
                    MeetupPlace = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Meetups", x => x.MeetupId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Meetups");
        }
    }
}
