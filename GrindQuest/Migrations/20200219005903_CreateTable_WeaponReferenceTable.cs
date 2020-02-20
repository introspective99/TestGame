using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class CreateTable_WeaponReferenceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "WeaponReferenceTable",
                columns: table => new
                {
                    WeaponId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WeaponName = table.Column<string>(nullable: true),
                    WeaponMaxBaseDamage = table.Column<int>(nullable: false),
                    WeaponMinBaseDamage = table.Column<int>(nullable: false),
                    WeaponQuality = table.Column<string>(nullable: true),
                    WeaponSlot = table.Column<string>(nullable: true),
                    WeaponEfffect = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WeaponReferenceTable", x => x.WeaponId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "WeaponReferenceTable");
        }
    }
}
