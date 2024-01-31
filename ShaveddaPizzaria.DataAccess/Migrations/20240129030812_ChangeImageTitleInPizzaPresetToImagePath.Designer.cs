﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShaveddaPizzaria.DataAccess.Data;

#nullable disable

namespace ShaveddaPizzaria.DataAccess.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240129030812_ChangeImageTitleInPizzaPresetToImagePath")]
    partial class ChangeImageTitleInPizzaPresetToImagePath
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.26")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ShaveddaPizzaria.Models.PizzaOrder", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("OrderId");

                    b.ToTable("PizzaOrders");
                });

            modelBuilder.Entity("ShaveddaPizzaria.Models.PizzaOrderDetails", b =>
                {
                    b.Property<int>("PizzaId")
                        .HasColumnType("int");

                    b.Property<bool>("HasBeef")
                        .HasColumnType("bit");

                    b.Property<bool>("HasCheese")
                        .HasColumnType("bit");

                    b.Property<bool>("HasHam")
                        .HasColumnType("bit");

                    b.Property<bool>("HasMushroom")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPepperoni")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPineapple")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPrawn")
                        .HasColumnType("bit");

                    b.Property<bool>("HasTuna")
                        .HasColumnType("bit");

                    b.Property<string>("PizzaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PizzaSauce")
                        .HasColumnType("int");

                    b.Property<int>("PizzaSize")
                        .HasColumnType("int");

                    b.Property<float?>("TotalPrice")
                        .HasColumnType("real");

                    b.HasKey("PizzaId");

                    b.ToTable("PizzaOrderDetails");
                });

            modelBuilder.Entity("ShaveddaPizzaria.Models.PizzaPreset", b =>
                {
                    b.Property<int>("PizzaId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("PizzaId"), 1L, 1);

                    b.Property<bool>("HasBeef")
                        .HasColumnType("bit");

                    b.Property<bool>("HasCheese")
                        .HasColumnType("bit");

                    b.Property<bool>("HasHam")
                        .HasColumnType("bit");

                    b.Property<bool>("HasMushroom")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPepperoni")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPineapple")
                        .HasColumnType("bit");

                    b.Property<bool>("HasPrawn")
                        .HasColumnType("bit");

                    b.Property<bool>("HasTuna")
                        .HasColumnType("bit");

                    b.Property<string>("ImagePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PizzaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PizzaSauce")
                        .HasColumnType("int");

                    b.HasKey("PizzaId");

                    b.ToTable("PizzaPresets");

                    b.HasData(
                        new
                        {
                            PizzaId = 1,
                            HasBeef = false,
                            HasCheese = true,
                            HasHam = false,
                            HasMushroom = false,
                            HasPepperoni = false,
                            HasPineapple = false,
                            HasPrawn = false,
                            HasTuna = false,
                            ImagePath = "images\\presets\\Margerita.png",
                            PizzaName = "Margerita",
                            PizzaSauce = 1
                        },
                        new
                        {
                            PizzaId = 2,
                            HasBeef = true,
                            HasCheese = true,
                            HasHam = false,
                            HasMushroom = false,
                            HasPepperoni = false,
                            HasPineapple = false,
                            HasPrawn = false,
                            HasTuna = false,
                            ImagePath = "images\\presets\\Bolognese.png",
                            PizzaName = "Bolognese",
                            PizzaSauce = 1
                        },
                        new
                        {
                            PizzaId = 3,
                            HasBeef = false,
                            HasCheese = true,
                            HasHam = true,
                            HasMushroom = false,
                            HasPepperoni = false,
                            HasPineapple = true,
                            HasPrawn = true,
                            HasTuna = false,
                            ImagePath = "images\\presets\\Hawaiian.png",
                            PizzaName = "Hawaiian",
                            PizzaSauce = 1
                        },
                        new
                        {
                            PizzaId = 4,
                            HasBeef = false,
                            HasCheese = true,
                            HasHam = true,
                            HasMushroom = true,
                            HasPepperoni = false,
                            HasPineapple = false,
                            HasPrawn = false,
                            HasTuna = false,
                            ImagePath = "images\\presets\\Carbonara.png",
                            PizzaName = "Carbonara",
                            PizzaSauce = 1
                        },
                        new
                        {
                            PizzaId = 5,
                            HasBeef = true,
                            HasCheese = true,
                            HasHam = true,
                            HasMushroom = false,
                            HasPepperoni = false,
                            HasPineapple = false,
                            HasPrawn = false,
                            HasTuna = false,
                            ImagePath = "images\\presets\\MeatFeast.png",
                            PizzaName = "MeatFeast",
                            PizzaSauce = 1
                        },
                        new
                        {
                            PizzaId = 6,
                            HasBeef = false,
                            HasCheese = true,
                            HasHam = false,
                            HasMushroom = true,
                            HasPepperoni = false,
                            HasPineapple = false,
                            HasPrawn = false,
                            HasTuna = false,
                            ImagePath = "images\\presets\\Mushroom.png",
                            PizzaName = "Mushroom",
                            PizzaSauce = 1
                        },
                        new
                        {
                            PizzaId = 7,
                            HasBeef = false,
                            HasCheese = true,
                            HasHam = false,
                            HasMushroom = false,
                            HasPepperoni = true,
                            HasPineapple = false,
                            HasPrawn = false,
                            HasTuna = false,
                            ImagePath = "images\\presets\\Pepperoni.png",
                            PizzaName = "Pepperoni",
                            PizzaSauce = 1
                        },
                        new
                        {
                            PizzaId = 8,
                            HasBeef = false,
                            HasCheese = true,
                            HasHam = false,
                            HasMushroom = false,
                            HasPepperoni = false,
                            HasPineapple = false,
                            HasPrawn = true,
                            HasTuna = true,
                            ImagePath = "images\\presets\\Seafood.png",
                            PizzaName = "Seafood",
                            PizzaSauce = 1
                        },
                        new
                        {
                            PizzaId = 9,
                            HasBeef = false,
                            HasCheese = true,
                            HasHam = false,
                            HasMushroom = true,
                            HasPepperoni = false,
                            HasPineapple = true,
                            HasPrawn = false,
                            HasTuna = false,
                            ImagePath = "images\\presets\\Vegetarian.png",
                            PizzaName = "Vegetarian",
                            PizzaSauce = 1
                        });
                });

            modelBuilder.Entity("ShaveddaPizzaria.Models.PizzaOrderDetails", b =>
                {
                    b.HasOne("ShaveddaPizzaria.Models.PizzaOrder", "PizzaOrder")
                        .WithOne("OrderDetails")
                        .HasForeignKey("ShaveddaPizzaria.Models.PizzaOrderDetails", "PizzaId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PizzaOrder");
                });

            modelBuilder.Entity("ShaveddaPizzaria.Models.PizzaOrder", b =>
                {
                    b.Navigation("OrderDetails")
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}