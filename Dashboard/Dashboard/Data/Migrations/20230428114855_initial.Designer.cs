﻿// <auto-generated />
using System;
using Dashboard.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Dashboard.Data.Migrations
{
    [DbContext(typeof(CandidatDbContext))]
    [Migration("20230428114855_initial")]
    partial class initial
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.5");

            modelBuilder.Entity("Dashboard.Models.Candidat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("CV")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime?>("Complet")
                        .HasColumnType("TEXT");

                    b.Property<int>("Gender")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Summary")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime>("Vide")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Candidats");
                });
#pragma warning restore 612, 618
        }
    }
}
