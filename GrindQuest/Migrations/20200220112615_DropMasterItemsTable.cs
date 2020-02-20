using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class DropMasterItemsTable : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
            name: "MasterItemsTable");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
