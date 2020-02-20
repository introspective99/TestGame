using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class CreateTable_MasterItemsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_ItemsMasterTable",
                table: "ItemsMasterTable");

            migrationBuilder.RenameTable(
                name: "ItemsMasterTable",
                newName: "MasterItemsTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_MasterItemsTable",
                table: "MasterItemsTable",
                column: "ItemID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_MasterItemsTable",
                table: "MasterItemsTable");

            migrationBuilder.RenameTable(
                name: "MasterItemsTable",
                newName: "ItemsMasterTable");

            migrationBuilder.AddPrimaryKey(
                name: "PK_ItemsMasterTable",
                table: "ItemsMasterTable",
                column: "ItemID");
        }
    }
}
