﻿// <auto-generated />
using Api.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace Api.Repository.Migrations
{
    [DbContext(typeof(ApiContext))]
    [Migration("20200722165824_UserSeedAdded")]
    partial class UserSeedAdded
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.6")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("Application.Models.Log", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnName("Description")
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<int>("Frequency")
                        .HasColumnName("Frequency")
                        .HasColumnType("integer");

                    b.Property<string>("Level")
                        .IsRequired()
                        .HasColumnName("Level")
                        .HasColumnType("text");

                    b.Property<string>("Origin")
                        .IsRequired()
                        .HasColumnName("Origin")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Logs");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Description = "Description 1",
                            Frequency = 1000,
                            Level = "High",
                            Origin = "OnModelCreating"
                        },
                        new
                        {
                            Id = 2,
                            Description = "Description 2",
                            Frequency = 2000,
                            Level = "High",
                            Origin = "OnModelCreating"
                        },
                        new
                        {
                            Id = 3,
                            Description = "Description 3",
                            Frequency = 3000,
                            Level = "High",
                            Origin = "OnModelCreating"
                        },
                        new
                        {
                            Id = 4,
                            Description = "Description 4",
                            Frequency = 4000,
                            Level = "High",
                            Origin = "OnModelCreating"
                        },
                        new
                        {
                            Id = 5,
                            Description = "Description 5",
                            Frequency = 5000,
                            Level = "High",
                            Origin = "OnModelCreating"
                        },
                        new
                        {
                            Id = 6,
                            Description = "Description 6",
                            Frequency = 6000,
                            Level = "High",
                            Origin = "OnModelCreating"
                        },
                        new
                        {
                            Id = 7,
                            Description = "Description 7",
                            Frequency = 7000,
                            Level = "High",
                            Origin = "OnModelCreating"
                        },
                        new
                        {
                            Id = 8,
                            Description = "Description 8",
                            Frequency = 8000,
                            Level = "High",
                            Origin = "OnModelCreating"
                        },
                        new
                        {
                            Id = 9,
                            Description = "Description 9",
                            Frequency = 9000,
                            Level = "High",
                            Origin = "OnModelCreating"
                        });
                });

            modelBuilder.Entity("Application.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("Id")
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnName("Email")
                        .HasColumnType("character varying(250)")
                        .HasMaxLength(250);

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnName("Password")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "otavio1@otavio.com",
                            Password = "1123"
                        },
                        new
                        {
                            Id = 2,
                            Email = "otavio2@otavio.com",
                            Password = "2123"
                        },
                        new
                        {
                            Id = 3,
                            Email = "otavio3@otavio.com",
                            Password = "3123"
                        },
                        new
                        {
                            Id = 4,
                            Email = "otavio4@otavio.com",
                            Password = "4123"
                        },
                        new
                        {
                            Id = 5,
                            Email = "otavio5@otavio.com",
                            Password = "5123"
                        },
                        new
                        {
                            Id = 6,
                            Email = "otavio6@otavio.com",
                            Password = "6123"
                        },
                        new
                        {
                            Id = 7,
                            Email = "otavio7@otavio.com",
                            Password = "7123"
                        },
                        new
                        {
                            Id = 8,
                            Email = "otavio8@otavio.com",
                            Password = "8123"
                        },
                        new
                        {
                            Id = 9,
                            Email = "otavio9@otavio.com",
                            Password = "9123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}