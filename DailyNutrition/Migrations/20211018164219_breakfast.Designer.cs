﻿// <auto-generated />
using System;
using DailyNutrition.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DailyNutrition.Migrations
{
    [DbContext(typeof(DailyNutritionContext))]
    [Migration("20211018164219_breakfast")]
    partial class breakfast
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DailyNutrition.Models.Breakfast", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Beverage")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("D_Vitamin_Intake")
                        .HasColumnType("bit");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Portion")
                        .HasColumnType("float");

                    b.Property<int>("Volym")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Breakfast");
                });
#pragma warning restore 612, 618
        }
    }
}
