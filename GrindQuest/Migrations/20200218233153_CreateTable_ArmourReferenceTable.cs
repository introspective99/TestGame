using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class CreateTable_ArmourReferenceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "ArmourReferenceTable",
                columns: table => new
                {
                    ArmourId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ArmourName = table.Column<string>(nullable: true),
                    ArmourMaxStrength = table.Column<int>(nullable: false),
                    ArmourMinStrength = table.Column<int>(nullable: false),
                    ArmourMaxIntellect = table.Column<int>(nullable: false),
                    ArmourMinIntellect = table.Column<int>(nullable: false),
                    ArmourMaxAgility = table.Column<int>(nullable: false),
                    ArmourMinAgility = table.Column<int>(nullable: false),
                    ArmourMaxStamina = table.Column<int>(nullable: false),
                    ArmourMinStamina = table.Column<int>(nullable: false),
                    ArmourMaxSpeed = table.Column<int>(nullable: false),
                    ArmourMinSpeed = table.Column<int>(nullable: false),
                    ArmourDurability = table.Column<int>(nullable: false),
                    ArmourQuality = table.Column<string>(nullable: true),
                    ArmourSlot = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArmourReferenceTable", x => x.ArmourId);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArmourReferenceTable");
        }
    }
}
