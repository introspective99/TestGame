using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class CreateTable_ItemsMaster : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "InventoryID",
                table: "PlayerChars");

            migrationBuilder.CreateTable(
                name: "ItemsMasterTable",
                columns: table => new
                {
                    ItemID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemMaxStack = table.Column<int>(nullable: false),
                    ItemName = table.Column<string>(nullable: true),
                    ItemEffect = table.Column<string>(nullable: true),
                    ItemType = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ItemsMasterTable", x => x.ItemID);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ItemsMasterTable");

            migrationBuilder.AddColumn<int>(
                name: "InventoryID",
                table: "PlayerChars",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }
    }
}
