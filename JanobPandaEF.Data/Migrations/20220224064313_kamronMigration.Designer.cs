﻿// <auto-generated />
using JanobPandaEF.Data.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

namespace JanobPandaEF.Data.Migrations
{
    [DbContext(typeof(NajotTalimDbContext))]
    [Migration("20220224064313_kamronMigration")]
    partial class kamronMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 63)
                .HasAnnotation("ProductVersion", "5.0.14")
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

            modelBuilder.Entity("JanobPandaEF.Domain.Group", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .HasMaxLength(30)
                        .HasColumnType("character varying(30)");

                    b.Property<int>("SubjectId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("SubjectId");

                    b.ToTable("Groups");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "dotNET #1",
                            SubjectId = 1
                        },
                        new
                        {
                            Id = 2,
                            Name = "Java #1",
                            SubjectId = 2
                        });
                });

            modelBuilder.Entity("JanobPandaEF.Domain.Student", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FullName")
                        .HasMaxLength(50)
                        .HasColumnType("character varying(50)");

                    b.Property<int>("GroupId")
                        .HasColumnType("integer");

                    b.Property<int>("UniversityId")
                        .HasColumnType("integer");

                    b.HasKey("Id");

                    b.HasIndex("GroupId");

                    b.HasIndex("UniversityId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            FullName = "Ahmadjon Sirojiddinov",
                            GroupId = 1,
                            UniversityId = 2
                        },
                        new
                        {
                            Id = 2,
                            FullName = "Muhammadabdulloh Komilov",
                            GroupId = 2,
                            UniversityId = 1
                        },
                        new
                        {
                            Id = 3,
                            FullName = "Abbos Haydarov",
                            GroupId = 1,
                            UniversityId = 1
                        });
                });

            modelBuilder.Entity("JanobPandaEF.Domain.Subject", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Subjects");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = ".NET"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Java"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Go"
                        });
                });

            modelBuilder.Entity("JanobPandaEF.Domain.University", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Address")
                        .HasColumnType("text");

                    b.Property<int>("Level")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Universities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Address = "Tashkent",
                            Level = 1,
                            Name = "TUIT"
                        },
                        new
                        {
                            Id = 2,
                            Address = "Tashkent",
                            Level = 2,
                            Name = "WIUT"
                        });
                });

            modelBuilder.Entity("JanobPandaEF.Domain.ViewModels.StudentData", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer")
                        .HasColumnName("id")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("FullName")
                        .HasColumnType("text")
                        .HasColumnName("fullname");

                    b.Property<string>("GroupName")
                        .HasColumnType("text")
                        .HasColumnName("group_name");

                    b.Property<string>("SubjectName")
                        .HasColumnType("text")
                        .HasColumnName("subject_name");

                    b.Property<string>("UniversityName")
                        .HasColumnType("text")
                        .HasColumnName("university_name");

                    b.HasKey("Id");

                    b.ToTable("StudentData", t => t.ExcludeFromMigrations());
                });

            modelBuilder.Entity("JanobPandaEF.Domain.Group", b =>
                {
                    b.HasOne("JanobPandaEF.Domain.Subject", "Subject")
                        .WithMany()
                        .HasForeignKey("SubjectId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Subject");
                });

            modelBuilder.Entity("JanobPandaEF.Domain.Student", b =>
                {
                    b.HasOne("JanobPandaEF.Domain.Group", "Group")
                        .WithMany()
                        .HasForeignKey("GroupId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JanobPandaEF.Domain.University", "University")
                        .WithMany()
                        .HasForeignKey("UniversityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Group");

                    b.Navigation("University");
                });
#pragma warning restore 612, 618
        }
    }
}
