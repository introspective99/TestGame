﻿// <auto-generated />
using System;
using GrindQuest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GrindQuest.Migrations
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20200220112615_DropMasterItemsTable")]
    partial class DropMasterItemsTable
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GrindQuest.ObjectModels.Armour", b =>
                {
                    b.Property<int>("ArmourId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ArmourDurability")
                        .HasColumnType("int");

                    b.Property<int>("ArmourGoldValue")
                        .HasColumnType("int");

                    b.Property<int>("ArmourMaxAgility")
                        .HasColumnType("int");

                    b.Property<int>("ArmourMaxIntellect")
                        .HasColumnType("int");

                    b.Property<int>("ArmourMaxSpeed")
                        .HasColumnType("int");

                    b.Property<int>("ArmourMaxStamina")
                        .HasColumnType("int");

                    b.Property<int>("ArmourMaxStrength")
                        .HasColumnType("int");

                    b.Property<int>("ArmourMinAgility")
                        .HasColumnType("int");

                    b.Property<int>("ArmourMinIntellect")
                        .HasColumnType("int");

                    b.Property<int>("ArmourMinSpeed")
                        .HasColumnType("int");

                    b.Property<int>("ArmourMinStamina")
                        .HasColumnType("int");

                    b.Property<int>("ArmourMinStrength")
                        .HasColumnType("int");

                    b.Property<string>("ArmourName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArmourQuality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ArmourSlot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ArmourId");

                    b.ToTable("ArmourReferenceTable");
                });

            modelBuilder.Entity("GrindQuest.ObjectModels.Character", b =>
                {
                    b.Property<int>("CharacterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CharacterAgility")
                        .HasColumnType("int");

                    b.Property<int>("CharacterIntellect")
                        .HasColumnType("int");

                    b.Property<int?>("CharacterInventoryInventoryId")
                        .HasColumnType("int");

                    b.Property<int>("CharacterLevel")
                        .HasColumnType("int");

                    b.Property<string>("CharacterName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CharacterSpeed")
                        .HasColumnType("int");

                    b.Property<int>("CharacterStamina")
                        .HasColumnType("int");

                    b.Property<int>("CharacterStrength")
                        .HasColumnType("int");

                    b.HasKey("CharacterId");

                    b.HasIndex("CharacterInventoryInventoryId");

                    b.ToTable("CharacterMasterTable");
                });

            modelBuilder.Entity("GrindQuest.ObjectModels.Inventory", b =>
                {
                    b.Property<int>("InventoryId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InventoryOwnerId")
                        .HasColumnType("int");

                    b.Property<int?>("InventorySlotEightInventorySlotId")
                        .HasColumnType("int");

                    b.Property<int?>("InventorySlotFiveInventorySlotId")
                        .HasColumnType("int");

                    b.Property<int?>("InventorySlotFourInventorySlotId")
                        .HasColumnType("int");

                    b.Property<int?>("InventorySlotNineInventorySlotId")
                        .HasColumnType("int");

                    b.Property<int?>("InventorySlotOneInventorySlotId")
                        .HasColumnType("int");

                    b.Property<int?>("InventorySlotSevenInventorySlotId")
                        .HasColumnType("int");

                    b.Property<int?>("InventorySlotSixInventorySlotId")
                        .HasColumnType("int");

                    b.Property<int?>("InventorySlotTenInventorySlotId")
                        .HasColumnType("int");

                    b.Property<int?>("InventorySlotThreeInventorySlotId")
                        .HasColumnType("int");

                    b.Property<int?>("InventorySlotTwoInventorySlotId")
                        .HasColumnType("int");

                    b.HasKey("InventoryId");

                    b.HasIndex("InventorySlotEightInventorySlotId");

                    b.HasIndex("InventorySlotFiveInventorySlotId");

                    b.HasIndex("InventorySlotFourInventorySlotId");

                    b.HasIndex("InventorySlotNineInventorySlotId");

                    b.HasIndex("InventorySlotOneInventorySlotId");

                    b.HasIndex("InventorySlotSevenInventorySlotId");

                    b.HasIndex("InventorySlotSixInventorySlotId");

                    b.HasIndex("InventorySlotTenInventorySlotId");

                    b.HasIndex("InventorySlotThreeInventorySlotId");

                    b.HasIndex("InventorySlotTwoInventorySlotId");

                    b.ToTable("InventoryReferenceTable");
                });

            modelBuilder.Entity("GrindQuest.ObjectModels.InventorySlot", b =>
                {
                    b.Property<int>("InventorySlotId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("ItemId")
                        .HasColumnType("int");

                    b.Property<int>("ParentInventoryId")
                        .HasColumnType("int");

                    b.Property<bool>("SlotUnlocked")
                        .HasColumnType("bit");

                    b.HasKey("InventorySlotId");

                    b.ToTable("InventorySlot");
                });

            modelBuilder.Entity("GrindQuest.ObjectModels.Item", b =>
                {
                    b.Property<int>("ItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ItemEffect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("ItemGoldValue")
                        .HasColumnType("int");

                    b.Property<int>("ItemMaxStack")
                        .HasColumnType("int");

                    b.Property<string>("ItemName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ItemType")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ItemId");

                    b.ToTable("ItemsReferenceTable");
                });

            modelBuilder.Entity("GrindQuest.ObjectModels.Weapon", b =>
                {
                    b.Property<int>("WeaponId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("WeaponEfffect")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("WeaponGoldValue")
                        .HasColumnType("int");

                    b.Property<int>("WeaponMaxBaseDamage")
                        .HasColumnType("int");

                    b.Property<int>("WeaponMinBaseDamage")
                        .HasColumnType("int");

                    b.Property<string>("WeaponName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeaponQuality")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("WeaponSlot")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WeaponId");

                    b.ToTable("WeaponReferenceTable");
                });

            modelBuilder.Entity("GrindQuest.ObjectModels.Character", b =>
                {
                    b.HasOne("GrindQuest.ObjectModels.Inventory", "CharacterInventory")
                        .WithMany()
                        .HasForeignKey("CharacterInventoryInventoryId");
                });

            modelBuilder.Entity("GrindQuest.ObjectModels.Inventory", b =>
                {
                    b.HasOne("GrindQuest.ObjectModels.InventorySlot", "InventorySlotEight")
                        .WithMany()
                        .HasForeignKey("InventorySlotEightInventorySlotId");

                    b.HasOne("GrindQuest.ObjectModels.InventorySlot", "InventorySlotFive")
                        .WithMany()
                        .HasForeignKey("InventorySlotFiveInventorySlotId");

                    b.HasOne("GrindQuest.ObjectModels.InventorySlot", "InventorySlotFour")
                        .WithMany()
                        .HasForeignKey("InventorySlotFourInventorySlotId");

                    b.HasOne("GrindQuest.ObjectModels.InventorySlot", "InventorySlotNine")
                        .WithMany()
                        .HasForeignKey("InventorySlotNineInventorySlotId");

                    b.HasOne("GrindQuest.ObjectModels.InventorySlot", "InventorySlotOne")
                        .WithMany()
                        .HasForeignKey("InventorySlotOneInventorySlotId");

                    b.HasOne("GrindQuest.ObjectModels.InventorySlot", "InventorySlotSeven")
                        .WithMany()
                        .HasForeignKey("InventorySlotSevenInventorySlotId");

                    b.HasOne("GrindQuest.ObjectModels.InventorySlot", "InventorySlotSix")
                        .WithMany()
                        .HasForeignKey("InventorySlotSixInventorySlotId");

                    b.HasOne("GrindQuest.ObjectModels.InventorySlot", "InventorySlotTen")
                        .WithMany()
                        .HasForeignKey("InventorySlotTenInventorySlotId");

                    b.HasOne("GrindQuest.ObjectModels.InventorySlot", "InventorySlotThree")
                        .WithMany()
                        .HasForeignKey("InventorySlotThreeInventorySlotId");

                    b.HasOne("GrindQuest.ObjectModels.InventorySlot", "InventorySlotTwo")
                        .WithMany()
                        .HasForeignKey("InventorySlotTwoInventorySlotId");
                });
#pragma warning restore 612, 618
        }
    }
}
