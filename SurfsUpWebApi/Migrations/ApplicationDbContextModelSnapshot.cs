﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SurfsUpWebApi.Data;

#nullable disable

namespace SurfsUpWebApi.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "8.0.8");

            modelBuilder.Entity("SurfsUpWebApi.Models.Equipment", b =>
                {
                    b.Property<int>("EquipmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int?>("SurfboardId")
                        .HasColumnType("INTEGER");

                    b.HasKey("EquipmentId");

                    b.HasIndex("SurfboardId");

                    b.ToTable("Equipment");
                });

            modelBuilder.Entity("SurfsUpWebApi.Models.Surfboard", b =>
                {
                    b.Property<int>("SurfboardId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ImageURL")
                        .HasColumnType("TEXT");

                    b.Property<double>("Length")
                        .HasColumnType("REAL");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Price")
                        .HasColumnType("REAL");

                    b.Property<double>("Thickness")
                        .HasColumnType("REAL");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<double>("Volume")
                        .HasColumnType("REAL");

                    b.Property<double>("Width")
                        .HasColumnType("REAL");

                    b.HasKey("SurfboardId");

                    b.ToTable("Surfboards");
                });

            modelBuilder.Entity("SurfsUpWebApi.Models.Equipment", b =>
                {
                    b.HasOne("SurfsUpWebApi.Models.Surfboard", null)
                        .WithMany("Equipment")
                        .HasForeignKey("SurfboardId");
                });

            modelBuilder.Entity("SurfsUpWebApi.Models.Surfboard", b =>
                {
                    b.Navigation("Equipment");
                });
#pragma warning restore 612, 618
        }
    }
}
