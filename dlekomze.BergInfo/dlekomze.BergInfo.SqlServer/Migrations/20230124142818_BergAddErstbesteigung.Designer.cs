﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dlekomze.BergInfo.SqlServer;

#nullable disable

namespace dlekomze.BergInfo.SqlServer.Migrations
{
    [DbContext(typeof(BergInfoDbContext))]
    [Migration("20230124142818_BergAddErstbesteigung")]
    partial class BergAddErstbesteigung
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("BergInfo")
                .HasAnnotation("ProductVersion", "7.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dlekomze.BergInfo.Entity.Berg", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime?>("Ersbesteigung")
                        .HasColumnType("date");

                    b.Property<int>("Hoehe")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(30)
                        .HasColumnType("nvarchar(30)");

                    b.HasKey("ID");

                    b.HasIndex("Name")
                        .IsUnique();

                    b.ToTable("Berg", "BergInfo");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            Hoehe = 2962,
                            Name = "Zugspitze"
                        },
                        new
                        {
                            ID = 2,
                            Hoehe = 8672,
                            Name = "K2"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
