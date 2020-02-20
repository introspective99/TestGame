using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class CreateNewItemsReferenceTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            /*migrationBuilder.CreateTable(
                name: "ItemsReferenceTable",
                columns: table => new
                {
                    ItemId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ItemMaxStack = table.Column<int>(type: "int", nullable: false),
                    ItemName = table.Column<string>(type: "varchar(50)", nullable: false),
                    ItemEffect = table.Column<string>(type: "varchar(50)", nullable: false),
                    ItemType = table.Column<string>(type: "varchar(50)", nullable: false),
                });*/
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "ItemId",
                table: "ItemsReferenceTable",
                newName: "ItemID");
        }
    }
}
