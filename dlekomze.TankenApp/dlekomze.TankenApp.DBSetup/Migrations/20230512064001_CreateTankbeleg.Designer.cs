﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using dlekomze.TankenApp;

#nullable disable

namespace dlekomze.TankenApp.DBSetup.Migrations
{
    [DbContext(typeof(TankBelegDBContext))]
    [Migration("20230512064001_CreateTankbeleg")]
    partial class CreateTankbeleg
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasDefaultSchema("Tank")
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("dlekomze.TankenApp.Model.Tankbeleg", b =>
                {
                    b.Property<int>("TankbelegID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TankbelegID"));

                    b.Property<DateTime>("Datum")
                        .HasColumnType("date");

                    b.Property<double>("GefahreneKilometer")
                        .HasColumnType("float");

                    b.Property<double>("Kilometerstand")
                        .HasColumnType("float");

                    b.Property<double>("Liter")
                        .HasColumnType("float");

                    b.Property<double>("Preis")
                        .HasColumnType("float");

                    b.HasKey("TankbelegID");

                    b.ToTable("Tankbeleg", "Tank");
                });
#pragma warning restore 612, 618
        }
    }
}
