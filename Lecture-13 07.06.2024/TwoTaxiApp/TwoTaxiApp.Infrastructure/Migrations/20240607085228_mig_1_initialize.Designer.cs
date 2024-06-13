﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using TwoTaxiApp.Infrastructure;

#nullable disable

namespace TwoTaxiApp.Infrastructure.Migrations
{
    [DbContext(typeof(TwoTaxiAppDbContext))]
    [Migration("20240607085228_mig_1_initialize")]
    partial class mig_1_initialize
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("TwoTaxiApp.Domain.Person", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uuid");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("person_type")
                        .IsRequired()
                        .HasMaxLength(13)
                        .HasColumnType("character varying(13)");

                    b.HasKey("Id");

                    b.ToTable("Person");

                    b.HasDiscriminator<string>("person_type").HasValue("Person");

                    b.UseTphMappingStrategy();
                });

            modelBuilder.Entity("TwoTaxiApp.Domain.Passenger", b =>
                {
                    b.HasBaseType("TwoTaxiApp.Domain.Person");

                    b.Property<int>("CarPreference")
                        .HasColumnType("integer");

                    b.HasDiscriminator().HasValue("passenger");
                });

            modelBuilder.Entity("TwoTaxiApp.Domain.TaxiDriver", b =>
                {
                    b.HasBaseType("TwoTaxiApp.Domain.Person");

                    b.Property<string>("Plate")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasDiscriminator().HasValue("taxi_driver");
                });
#pragma warning restore 612, 618
        }
    }
}