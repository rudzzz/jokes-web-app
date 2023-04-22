using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Xml.Linq;

#nullable disable

namespace Jokes.Migrations
{
    public partial class initialsetup : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder) {
            migrationBuilder.CreateTable(
            name: "Jokes",
            columns: table => new
            {
                Id = table.Column<int>(nullable: false)
                    .Annotation("Sq1Server:Identity", "1, 1"),
                JokeQuestion = table.Column<string>(nullable: true),
                JokeAnswer = table.Column<string>(nullable: true)
            },
            constraints: table =>
            {
                table.PrimaryKey("PK_Jokes", x => x.Id);
            });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
