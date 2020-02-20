using Microsoft.EntityFrameworkCore.Migrations;

namespace GrindQuest.Migrations
{
    public partial class CreateTable_Inventory : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CharacterInventoryInventoryId",
                table: "CharacterMasterTable",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "InventorySlot",
                columns: table => new
                {
                    InventorySlotId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ParentInventoryId = table.Column<int>(nullable: false),
                    ItemId = table.Column<int>(nullable: false),
                    SlotUnlocked = table.Column<bool>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventorySlot", x => x.InventorySlotId);
                });

            migrationBuilder.CreateTable(
                name: "InventoryReferenceTable",
                columns: table => new
                {
                    InventoryId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InventoryOwnerId = table.Column<int>(nullable: false),
                    InventorySlotOneInventorySlotId = table.Column<int>(nullable: true),
                    InventorySlotTwoInventorySlotId = table.Column<int>(nullable: true),
                    InventorySlotThreeInventorySlotId = table.Column<int>(nullable: true),
                    InventorySlotFourInventorySlotId = table.Column<int>(nullable: true),
                    InventorySlotFiveInventorySlotId = table.Column<int>(nullable: true),
                    InventorySlotSixInventorySlotId = table.Column<int>(nullable: true),
                    InventorySlotSevenInventorySlotId = table.Column<int>(nullable: true),
                    InventorySlotEightInventorySlotId = table.Column<int>(nullable: true),
                    InventorySlotNineInventorySlotId = table.Column<int>(nullable: true),
                    InventorySlotTenInventorySlotId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InventoryReferenceTable", x => x.InventoryId);
                    table.ForeignKey(
                        name: "FK_InventoryReferenceTable_InventorySlot_InventorySlotEightInventorySlotId",
                        column: x => x.InventorySlotEightInventorySlotId,
                        principalTable: "InventorySlot",
                        principalColumn: "InventorySlotId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryReferenceTable_InventorySlot_InventorySlotFiveInventorySlotId",
                        column: x => x.InventorySlotFiveInventorySlotId,
                        principalTable: "InventorySlot",
                        principalColumn: "InventorySlotId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryReferenceTable_InventorySlot_InventorySlotFourInventorySlotId",
                        column: x => x.InventorySlotFourInventorySlotId,
                        principalTable: "InventorySlot",
                        principalColumn: "InventorySlotId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryReferenceTable_InventorySlot_InventorySlotNineInventorySlotId",
                        column: x => x.InventorySlotNineInventorySlotId,
                        principalTable: "InventorySlot",
                        principalColumn: "InventorySlotId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryReferenceTable_InventorySlot_InventorySlotOneInventorySlotId",
                        column: x => x.InventorySlotOneInventorySlotId,
                        principalTable: "InventorySlot",
                        principalColumn: "InventorySlotId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryReferenceTable_InventorySlot_InventorySlotSevenInventorySlotId",
                        column: x => x.InventorySlotSevenInventorySlotId,
                        principalTable: "InventorySlot",
                        principalColumn: "InventorySlotId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryReferenceTable_InventorySlot_InventorySlotSixInventorySlotId",
                        column: x => x.InventorySlotSixInventorySlotId,
                        principalTable: "InventorySlot",
                        principalColumn: "InventorySlotId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryReferenceTable_InventorySlot_InventorySlotTenInventorySlotId",
                        column: x => x.InventorySlotTenInventorySlotId,
                        principalTable: "InventorySlot",
                        principalColumn: "InventorySlotId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryReferenceTable_InventorySlot_InventorySlotThreeInventorySlotId",
                        column: x => x.InventorySlotThreeInventorySlotId,
                        principalTable: "InventorySlot",
                        principalColumn: "InventorySlotId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_InventoryReferenceTable_InventorySlot_InventorySlotTwoInventorySlotId",
                        column: x => x.InventorySlotTwoInventorySlotId,
                        principalTable: "InventorySlot",
                        principalColumn: "InventorySlotId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_CharacterMasterTable_CharacterInventoryInventoryId",
                table: "CharacterMasterTable",
                column: "CharacterInventoryInventoryId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReferenceTable_InventorySlotEightInventorySlotId",
                table: "InventoryReferenceTable",
                column: "InventorySlotEightInventorySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReferenceTable_InventorySlotFiveInventorySlotId",
                table: "InventoryReferenceTable",
                column: "InventorySlotFiveInventorySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReferenceTable_InventorySlotFourInventorySlotId",
                table: "InventoryReferenceTable",
                column: "InventorySlotFourInventorySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReferenceTable_InventorySlotNineInventorySlotId",
                table: "InventoryReferenceTable",
                column: "InventorySlotNineInventorySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReferenceTable_InventorySlotOneInventorySlotId",
                table: "InventoryReferenceTable",
                column: "InventorySlotOneInventorySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReferenceTable_InventorySlotSevenInventorySlotId",
                table: "InventoryReferenceTable",
                column: "InventorySlotSevenInventorySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReferenceTable_InventorySlotSixInventorySlotId",
                table: "InventoryReferenceTable",
                column: "InventorySlotSixInventorySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReferenceTable_InventorySlotTenInventorySlotId",
                table: "InventoryReferenceTable",
                column: "InventorySlotTenInventorySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReferenceTable_InventorySlotThreeInventorySlotId",
                table: "InventoryReferenceTable",
                column: "InventorySlotThreeInventorySlotId");

            migrationBuilder.CreateIndex(
                name: "IX_InventoryReferenceTable_InventorySlotTwoInventorySlotId",
                table: "InventoryReferenceTable",
                column: "InventorySlotTwoInventorySlotId");

            migrationBuilder.AddForeignKey(
                name: "FK_CharacterMasterTable_InventoryReferenceTable_CharacterInventoryInventoryId",
                table: "CharacterMasterTable",
                column: "CharacterInventoryInventoryId",
                principalTable: "InventoryReferenceTable",
                principalColumn: "InventoryId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_CharacterMasterTable_InventoryReferenceTable_CharacterInventoryInventoryId",
                table: "CharacterMasterTable");

            migrationBuilder.DropTable(
                name: "InventoryReferenceTable");

            migrationBuilder.DropTable(
                name: "InventorySlot");

            migrationBuilder.DropIndex(
                name: "IX_CharacterMasterTable_CharacterInventoryInventoryId",
                table: "CharacterMasterTable");

            migrationBuilder.DropColumn(
                name: "CharacterInventoryInventoryId",
                table: "CharacterMasterTable");
        }
    }
}
