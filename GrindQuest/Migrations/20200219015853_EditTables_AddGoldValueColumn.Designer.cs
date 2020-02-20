﻿// <auto-generated />
using GrindQuest;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace GrindQuest.Migrations
{
    [DbContext(typeof(GameDbContext))]
    [Migration("20200219015853_EditTables_AddGoldValueColumn")]
    partial class EditTables_AddGoldValueColumn
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

                    b.ToTable("CharacterMasterTable");
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
#pragma warning restore 612, 618
        }
    }
}
