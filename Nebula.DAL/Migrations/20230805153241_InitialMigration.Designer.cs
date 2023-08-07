﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Nebula.DAL.Contexts;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Nebula.DAL.Migrations
{
    [DbContext(typeof(NebulaDbContext))]
    [Migration("20230805153241_InitialMigration")]
    partial class InitialMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.12")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Nebula.Domain.Card", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("ExpireDate")
                        .HasColumnType("timestamp with time zone");

                    b.Property<bool>("IsActive")
                        .HasColumnType("boolean");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("Number")
                        .HasColumnType("text");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<long>("UserId")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Cards");
                });

            modelBuilder.Entity("Nebula.Domain.Employee", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<byte>("Type")
                        .HasColumnType("smallint");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8247),
                            DateOfBirth = new DateTime(1988, 4, 6, 20, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Avazbek",
                            IsDeleted = false,
                            LastName = "Siddiqov",
                            Phone = "+998973340334",
                            Type = (byte)3
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8251),
                            DateOfBirth = new DateTime(1998, 7, 21, 20, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Muqimjon",
                            IsDeleted = false,
                            LastName = "Mamadaliyev",
                            Phone = "+998937349808",
                            Type = (byte)4
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8254),
                            DateOfBirth = new DateTime(2001, 11, 27, 21, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Abdualim",
                            IsDeleted = false,
                            LastName = "Normurodov",
                            Phone = "+998950642799",
                            Type = (byte)1
                        });
                });

            modelBuilder.Entity("Nebula.Domain.User", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<long>("Id"));

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.Property<DateTime>("DateOfBirth")
                        .HasColumnType("timestamp with time zone");

                    b.Property<string>("FirstName")
                        .HasColumnType("text");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("boolean");

                    b.Property<string>("LastName")
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .HasColumnType("text");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("timestamp with time zone");

                    b.HasKey("Id");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            Id = 1L,
                            CreatedAt = new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8143),
                            DateOfBirth = new DateTime(2006, 10, 12, 20, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Iskandar",
                            IsDeleted = false,
                            LastName = "Qodirov",
                            Phone = "+998972350120"
                        },
                        new
                        {
                            Id = 2L,
                            CreatedAt = new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8149),
                            DateOfBirth = new DateTime(2005, 11, 3, 21, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Madiyor",
                            IsDeleted = false,
                            LastName = "Odilov",
                            Phone = "+998903638333"
                        },
                        new
                        {
                            Id = 3L,
                            CreatedAt = new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8154),
                            DateOfBirth = new DateTime(2004, 2, 19, 21, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Nodir",
                            IsDeleted = false,
                            LastName = "Ollonazarov",
                            Phone = "+998881813525"
                        },
                        new
                        {
                            Id = 4L,
                            CreatedAt = new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8157),
                            DateOfBirth = new DateTime(2003, 8, 15, 20, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Nurullo",
                            IsDeleted = false,
                            LastName = "Nurmatov",
                            Phone = "+998330022816"
                        },
                        new
                        {
                            Id = 5L,
                            CreatedAt = new DateTime(2023, 8, 5, 15, 32, 41, 737, DateTimeKind.Utc).AddTicks(8161),
                            DateOfBirth = new DateTime(2002, 8, 17, 20, 0, 0, 0, DateTimeKind.Utc),
                            FirstName = "Ravshanbek",
                            IsDeleted = false,
                            LastName = "Isroilov",
                            Phone = "+998902528196"
                        });
                });

            modelBuilder.Entity("Nebula.Domain.Card", b =>
                {
                    b.HasOne("Nebula.Domain.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
