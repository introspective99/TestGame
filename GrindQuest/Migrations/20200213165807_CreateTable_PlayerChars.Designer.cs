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
    [Migration("20200213165807_CreateTable_PlayerChars")]
    partial class CreateTable_PlayerChars
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("GrindQuest.ObjectModels.PlayerChar", b =>
                {
                    b.Property<int>("PlayerCharID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("InventoryID")
                        .HasColumnType("int");

                    b.Property<string>("PlayerCharName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlayerCharSpec")
                        .HasColumnType("int");

                    b.HasKey("PlayerCharID");

                    b.ToTable("PlayerChars");
                });
#pragma warning restore 612, 618
        }
    }
}
