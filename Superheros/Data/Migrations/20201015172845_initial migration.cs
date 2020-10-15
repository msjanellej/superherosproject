using Microsoft.EntityFrameworkCore.Migrations;

namespace Superheros.Data.Migrations
{
    public partial class initialmigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Superheros",
                columns: table => new
                {
                    SuperheroName = table.Column<string>(nullable: false),
                    AlterEgoName = table.Column<string>(nullable: true),
                    PrimarySuperAbility = table.Column<string>(nullable: true),
                    SecondarySuperAbility = table.Column<string>(nullable: true),
                    Catchphrase = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Superheros", x => x.SuperheroName);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Superheros");
        }
    }
}
