﻿// <auto-generated />
using System;
using DailyNutrition.DataContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DailyNutrition.Migrations
{
    [DbContext(typeof(DailyNutritionContext))]
    [Migration("20200722084448_RemoveTimeColumn")]
    partial class RemoveTimeColumn
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("DailyNutrition.Models.Schema", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("FeedingDuration")
                        .HasColumnType("int");

                    b.Property<int>("FormulaAmount")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Schemas");
                });
#pragma warning restore 612, 618
        }
    }
}