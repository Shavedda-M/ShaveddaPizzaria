﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShaveddaPizzaria.Data;

#nullable disable

namespace ShaveddaPizzaria.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240120024633_AddRequiredToPizzaModels")]
    partial class AddRequiredToPizzaModels
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

                    b.Property<string>("ImageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PizzaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PizzaSauce")
                        .HasColumnType("int");

                    b.Property<int>("PizzaSize")
                        .HasColumnType("int");

                    b.Property<float>("TotalPrice")
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

                    b.Property<string>("ImageTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PizzaName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PizzaSauce")
                        .HasColumnType("int");

                    b.Property<int>("PizzaSize")
                        .HasColumnType("int");

                    b.HasKey("PizzaId");

                    b.ToTable("PizzaPresets");
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
